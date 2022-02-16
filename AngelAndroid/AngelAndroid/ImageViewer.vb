Imports System.ComponentModel

Public Class ImageViewer
    Public Client As Net.Sockets.TcpClient

    Public classClient As sockets.Client

    Public fps As Long = 0

    Public duration As Long = 0

    Public count As Integer = 0

    Public frames As New List(Of Image)

    Public time As New List(Of Long)

    Public Title As String = "null"

    Private Sub SpyStyle()
        Me.BackColor = SpySettings.DefaultColor_Background
        For Each gr As Label In info.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next

        For Each gr As Panel In info.Controls.OfType(Of Panel)()
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub

    Sub New()

        InitializeComponent()

        Me.Font = reso.f

    End Sub
    Private Sub ImageViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\17.ico")

        SpyStyle()

        TP.Start()

        Me.Text = Title

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True
    End Sub

    Private Sub TP_Tick(sender As Object, e As EventArgs) Handles TP.Tick

        If Not classClient Is Nothing Then

            ProgressBar1.Value = classClient.Progresr()

        End If

    End Sub

    Private Sub ImageViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        TP.Enabled = False

        If Not classClient Is Nothing Then

            classClient.qit = True

            If classClient.EXI = False Then

                classClient.Close(Client)

            End If



        End If


    End Sub

    Private Sub Viewer_Click(sender As Object, e As EventArgs) Handles Viewer.Click

    End Sub

    Private Sub Viewer_MouseClick(sender As Object, e As MouseEventArgs) Handles Viewer.MouseClick

        If Chek() Then

            If frames.Count > 0 And time.Count > 0 Then

                If frames.Count = time.Count Then

                    count = 0

                    Viewer.Image = GetFrame(count)

                    rest.Interval = 30

                    rest.Enabled = True

                End If

            End If

        End If


    End Sub
    Private Function Chek() As Boolean

        If Not Me.info.Visible Then

            Return False

        End If
        Dim d As Boolean = duration > fps

        If d Then

            If duration - fps <= 1000 Then

                Return True

            End If

        Else

            If duration = fps Then

                Return True

            Else

                If fps - duration <= 1000 Then

                    Return True

                End If

            End If

        End If

        Return False

    End Function
    Private Function GetFrame(ByVal i As Integer) As Image

        Try

            If frames.Count > 0 Then

                If i >= frames.Count Then

                    Return Nothing

                Else

                    LTime.Text = Codes.VideoTime(time(i)) & Space(1) & Codes.VideoTime(duration)

                    Return frames(i)

                End If

            End If

        Catch ex As Exception

            Return Nothing

        End Try

        Return Nothing

    End Function
    Private Sub rest_Tick(sender As Object, e As EventArgs) Handles rest.Tick

        If GetFrame(count) Is Nothing Then
            count = 0

            rest.Enabled = False
        Else

            Viewer.Image = GetFrame(count)

            count += 1


        End If


    End Sub
End Class