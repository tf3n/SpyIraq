Imports System.ComponentModel

Public Class About
    Private mge As Image
    Private tip As New ThemeToolTip

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.max

        BXICO.Image = My.Resources.LOGO

        Label1.Font = reso.f

        Label2.Font = reso.f

        Label3.Font = reso.f

        Label4.Font = reso.f

        Label1.Text = reso.nameRAT & " - Android RAT (Remote Access Trojan)"

        Label2.Text = "version 2.0"

        Label3.Text = ""

        Label4.Text = "Report a issue"

        Label4.Tag = "https://www.sa3ka.com/cc/threads/721/"

        tip._ToolTip.Active = True

        tip._ToolTip.SetToolTip(Label3, String.Format("Skype:{0}" & vbNewLine & "Telegram:{1}", "496", "udpip"))

        mge = BXICO.Image

        Label1.ForeColor = SpySettings.DefaultColor_Foreground
        Label2.ForeColor = SpySettings.DefaultColor_Foreground
        Label3.ForeColor = SpySettings.DefaultColor_Foreground
        Label4.ForeColor = SpySettings.DefaultColor_Foreground
        Label1.BackColor = SpySettings.DefaultColor_Background
        Label2.BackColor = SpySettings.DefaultColor_Background
        Label3.BackColor = SpySettings.DefaultColor_Background
        Label4.BackColor = SpySettings.DefaultColor_Background
        BXICO.BackColor = SpySettings.DefaultColor_Background
        Me.BackColor = SpySettings.DefaultColor_Background
        Me.TOpacity.Interval = SpySettings.T_Interval
        TOpacity.Enabled = True
        tmr.Enabled = True
    End Sub

    Private Sub About_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Me.DialogResult = DialogResult.OK

    End Sub
    Public Function RECOLOR(image As Image, baseColor As Color, newColor As Color) As Bitmap
        Dim transformation As New Imaging.ColorMatrix(New Single()() {
        New Single() {1, 0, 0, 0, 0},
        New Single() {0, 1, 0, 0, 0},
        New Single() {0, 0, 1, 0, 0},
        New Single() {0, 0, 0, 1, 0},
        New Single() {(CInt(newColor.R) - CInt(baseColor.R)) / 255.0!, (CInt(newColor.G) - CInt(baseColor.G)) / 255.0!, (CInt(newColor.B) - CInt(baseColor.B)) / 255.0!, 0, 1}
    })

        Dim imageAttributes As New Imaging.ImageAttributes()
        imageAttributes.SetColorMatrix(transformation)

        Dim result As New Bitmap(image.Width, image.Height)

        Using g As Graphics = Graphics.FromImage(result)
            g.DrawImage(image, New Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes)
        End Using

        Return result
    End Function

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick

        If Not BXICO.Height >= 148 Then

            BXICO.Height = BXICO.Height + 10
            BXICO.Image = RECOLOR(mge, Color.FromArgb(255, 255, 255), RandomColor())
            Label1.ForeColor = RandomColor()
            Label2.ForeColor = RandomColor()
            Label3.ForeColor = RandomColor()
        Else

            BXICO.Image = RECOLOR(mge, Color.FromArgb(255, 255, 255), SpySettings.DefaultColor_Foreground)
            Label1.ForeColor = SpySettings.DefaultColor_Foreground
            Label2.ForeColor = SpySettings.DefaultColor_Foreground
            Label3.ForeColor = SpySettings.DefaultColor_Foreground
            Label1.BackColor = SpySettings.DefaultColor_Background
            Label2.BackColor = SpySettings.DefaultColor_Background
            Label3.BackColor = SpySettings.DefaultColor_Background
            BXICO.BackColor = SpySettings.DefaultColor_Background
            Me.BackColor = SpySettings.DefaultColor_Background
            tmr.Enabled = False
            chtmr.Enabled = True
        End If


    End Sub
    Private Function RandomColor() As Color

        Dim rand As New Random

        Return Color.FromArgb(rand.Next(0, 190), rand.Next(0, 190), rand.Next(0, 190))

    End Function

    Private count As Integer = 0
    Private Sub chtmr_Tick(sender As Object, e As EventArgs) Handles chtmr.Tick
        count += 1
        Select Case count
            Case 0 To 10
                Label3.Text = GenRandom(1)
            Case 10 To 20
                Label3.Text = "b" & GenRandom(1)
            Case 20 To 30
                Label3.Text = "by " & GenRandom(3)
            Case 30 To 40
                Label3.Text = "by s" & GenRandom(1)
            Case 40 To 50
                Label3.Text = "by sc" & GenRandom(2)
            Case 50 To 60
                Label3.Text = "by scr" & GenRandom(5)
            Case 60 To 70
                Label3.Text = "by scre" & GenRandom(3)
            Case 70 To 80
                Label3.Text = "by screa" & GenRandom(2)
            Case >= 80
                Label3.Text = "by scream"
                chtmr.Enabled = False
                Label4.Visible = True
        End Select


    End Sub
    Function GenRandom(ByVal Length As Integer) As String
        Dim Output As String = Nothing
        Dim UsedLetters As String = "q+s\z!x#C7$G^k[H;d4*R_]/i6t-?j8A?<.B>:X?\{N}m_3"
        For i = 1 To Length
            Threading.Thread.Sleep(5)
            Dim Rnd As New Random(Now.Millisecond)
            Output &= UsedLetters(Rnd.Next(0, UsedLetters.Length))
        Next
        Return Output
    End Function

    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else

            Me.TOpacity.Enabled = False
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        If Label4.Tag.ToString.Length > 0 Then

            Process.Start(Label4.Tag.ToString)

        End If

    End Sub
End Class