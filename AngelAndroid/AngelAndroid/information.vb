Public Class information

    Public Client As Net.Sockets.TcpClient

    Public classClient As sockets.Client

    Public Title As String = "null"

    Private LastComboDGV5, LastComboDGV6 As ComboBox

    Private EventArgs As DataGridViewCellCancelEventArgs

    Private EventName As String

    Public tmpTable As DataTable = Nothing

    Public tmpFolderUSER, tmpClientName, tmpCountry, tmpAddressIP As String

    Public DS As DataSet = Nothing
    Sub New()

        InitializeComponent()

        Me.Font = reso.f

    End Sub

    Private Sub SpyStyle()


        Me.ctxMenu.Renderer = New ThemeToolStrip


        For Each gr As DataGridView In Panel1.Controls.OfType(Of DataGridView)()
            gr.BackgroundColor = SpySettings.DefaultColor_Background
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
            gr.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
            gr.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background

            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            gr.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
            gr.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground
            gr.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground


            gr.CellBorderStyle = DataGridViewCellBorderStyle.Single
            gr.GridColor = SpySettings.DefaultColor_Foreground
            gr.BorderStyle = System.Windows.Forms.BorderStyle.None
            gr.ColumnHeadersVisible = False
            gr.EnableHeadersVisualStyles = False
            gr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            gr.RowHeadersVisible = False
            gr.SelectionMode = DataGridViewSelectionMode.CellSelect
            gr.MultiSelect = False
            gr.ContextMenuStrip = Me.ctxMenu
        Next
        For Each gr As Label In Panel1.Controls.OfType(Of Label)()
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ForeColor = SpySettings.DefaultColor_ColorTitles
            gr.ContextMenuStrip = Me.ctxMenu
        Next
        For Each gr As Panel In Me.Controls.OfType(Of Panel)()
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ForeColor = SpySettings.DefaultColor_Foreground
        Next
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Public Sub grreSize()
        For Each gr As DataGridView In Panel1.Controls.OfType(Of DataGridView)()
            Dim reSize As Integer = gr.Rows.Count * gr.Rows(0).Height
            gr.Height = reSize + 5
        Next
    End Sub
    Private Sub info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SaveToolStripMenuItem.Visible = True

        SaveAsToolStripMenuItem.Visible = True

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\11.ico")

        SpyStyle()

        grreSize()

        Me.Text = Title

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True

    End Sub

    Private Sub ClearSEL(ByVal DG0 As DataGridView)
        For Each gr As DataGridView In Panel1.Controls.OfType(Of DataGridView)()
            If Not gr.Name = DG0.Name Then
                If gr.Rows.Count > 0 Then
                    gr.CurrentCell = gr.Rows(0).Cells(0)
                    gr.ClearSelection()
                End If
            End If
        Next
    End Sub
    Private Sub DGV0_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV0.CellEnter
        ClearSEL(DGV0)
    End Sub
    Private Sub DGV1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellEnter
        ClearSEL(DGV1)
    End Sub
    Private Sub DGV2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellEnter
        ClearSEL(DGV2)
    End Sub
    Private Sub DGV3_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV3.CellEnter
        ClearSEL(DGV3)
    End Sub
    Private Sub DGV4_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV4.CellEnter
        ClearSEL(DGV4)
    End Sub
    Private Sub DGV5_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV5.CellEnter
        ClearSEL(DGV5)
    End Sub
    Private Sub DGV6_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGV6.CellEnter
        ClearSEL(DGV6)
    End Sub
    Private Sub DGV5_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGV5.CellBeginEdit
        EventName = "DGV5"
        EventArgs = e
    End Sub
    Private Sub DGV6_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGV6.CellBeginEdit
        EventName = "DGV6"
        EventArgs = e
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If tmpTable IsNot Nothing Then
            reso.Directory_Exist(classClient)
            If DS Is Nothing Then
                DS = New DataSet("info")
                DS.Tables.Add(tmpTable)
            End If
            Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {DS, tmpFolderUSER, "informations",
            tmpClientName, tmpCountry & " - " & tmpAddressIP, "informations", "info", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveAS As New SaveFileDialog
        SaveAS.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"
        SaveAS.Filter = "html (*.html)|*.html"
        If SaveAS.ShowDialog = Windows.Forms.DialogResult.OK Then
            If DS Is Nothing Then
                DS = New DataSet("info")
                DS.Tables.Add(tmpTable)
            End If
            Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {DS, "null", SaveAS.FileName,
            tmpClientName, tmpCountry & " - " & tmpAddressIP, "informations", "info", "null"})
        End If
        SaveAS.Dispose()
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim comboBox1 As ComboBox = CType(sender, ComboBox)
        If comboBox1 IsNot Nothing Then
            If comboBox1.Text.Length > 0 Then
                If EventArgs IsNot Nothing Then
                    If Not EventArgs.ColumnIndex = -1 And Not EventArgs.RowIndex = -1 And Not EventName = Nothing Then
                        Select Case EventName
                            Case "DGV5"
                                If EventArgs.ColumnIndex = 1 And EventArgs.RowIndex = 0 Then
                                    'Ring
                                    change("ring", CStr(comboBox1.SelectedIndex))
                                ElseIf EventArgs.ColumnIndex = 1 And EventArgs.RowIndex = 1 Then
                                    'Music
                                    change("music", CStr(comboBox1.SelectedIndex))
                                ElseIf EventArgs.ColumnIndex = 1 And EventArgs.RowIndex = 2 Then
                                    'Notification
                                    change("notification", CStr(comboBox1.SelectedIndex))
                                ElseIf EventArgs.ColumnIndex = 1 And EventArgs.RowIndex = 3 Then
                                    'System
                                    change("system", CStr(comboBox1.SelectedIndex))
                                End If
                            Case "DGV6"
                                If EventArgs.ColumnIndex = 1 And EventArgs.RowIndex = 0 Then
                                    'Ringer Mode
                                    change("ringer_mode", CStr(comboBox1.SelectedIndex))
                                ElseIf EventArgs.ColumnIndex = 1 And EventArgs.RowIndex = 1 Then
                                    'Wi-Fi Mode
                                    change("wifi_mode", CStr(comboBox1.SelectedIndex))
                                End If
                        End Select
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub change(ByVal num As String, ByVal vul As String)

        If Not classClient Is Nothing Then

            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & num & sockets.Data.SPL_DATA & vul, Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

        End If

    End Sub
    Private Sub DGV5_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV5.EditingControlShowing
        Dim combo As ComboBox = CType(e.Control, ComboBox)
        If Not IsNothing(combo.SelectedItem) Then
            If Not IsNothing(LastComboDGV5) Then
                RemoveHandler LastComboDGV5.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
            End If
            LastComboDGV5 = combo
            AddHandler LastComboDGV5.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
        End If
    End Sub
    Private Sub DGV6_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV6.EditingControlShowing
        Dim combo As ComboBox = CType(e.Control, ComboBox)
        If Not IsNothing(combo.SelectedItem) Then
            If Not IsNothing(LastComboDGV6) Then
                RemoveHandler LastComboDGV6.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
            End If
            LastComboDGV6 = combo
            AddHandler LastComboDGV6.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectedIndexChanged)
        End If
    End Sub
End Class





