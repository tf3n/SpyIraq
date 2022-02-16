Public Class EditSocket
    Sub New()

        InitializeComponent()
        Me.Font = reso.f

    End Sub


    Private Sub SpyStyle()
        po.BackColor = SpySettings.DefaultColor_Background
        po.ForeColor = SpySettings.DefaultColor_Foreground
        RectInputText0.Add(New Rectangle(po.Location.X - 1, po.Location.Y - 1, po.Width + 1, po.Height + 1))
        For Each gr As DataGridView In PanelBOX.Controls.OfType(Of DataGridView)()
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
        For Each gr As Label In PanelBOX.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
        Next
        For Each gr As Button In PanelBOX.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As TextBox In PanelBOX.Controls.OfType(Of TextBox)()
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            RectInputText0.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        Next
        For Each gr As Panel In Me.Controls.OfType(Of Panel)()
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        Me.Refresh()
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub EditSocket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\12.ico")

        SpyStyle()

        TextIP.Text = Codes.GetIPAddress()

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True
    End Sub

    Private Sub b_Add_Click(sender As Object, e As EventArgs) Handles b_Add.Click

        DGV0.Rows.Add(TextIP.Text & ":" & po.Value)

    End Sub

    Private Sub b_del_Click(sender As Object, e As EventArgs) Handles b_del.Click

        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index)

            Next

        End If

    End Sub
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click

        Rowinsert(False)

    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click

        Rowinsert(True)

    End Sub
    Private Sub Rowinsert(ByVal isDown As Boolean)

        If DGV0.SelectedRows.Count = 1 And Not DGV0.Rows.Count = 1 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                Dim vul As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Value

                If isDown Then

                    DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index)

                    DGV0.Rows.Insert(DGV0.SelectedRows(i).Index + 1, vul)

                    DGV0.CurrentCell = DGV0.Rows(DGV0.SelectedRows(i).Index + 1).Cells(0)

                Else

                    If Not DGV0.SelectedRows(i).Index = 0 Then

                        DGV0.Rows.Insert(DGV0.SelectedRows(i).Index - 1, vul)

                        DGV0.CurrentCell = DGV0.Rows(DGV0.SelectedRows(i).Index - 1).Cells(0)

                        DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index + 1)

                        DGV0.CurrentCell = DGV0.Rows(DGV0.SelectedRows(i).Index - 1).Cells(0)

                    End If

                End If

            Next

        End If

    End Sub

    Private Sub OKY_Click(sender As Object, e As EventArgs) Handles OKY.Click

        Me.DialogResult = DialogResult.OK

    End Sub



    Private Sub PanelBOX_Paint(sender As Object, e As PaintEventArgs) Handles PanelBOX.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim transColor As Color = SpySettings.DefaultColor_Foreground
        If RectInputText0.Count > 0 Then
            For Each rec In RectInputText0
                If rec.Width > 0 Then
                    e.Graphics.FillRectangle(New SolidBrush(transColor), rec)
                End If
            Next
        End If
    End Sub

    Private RectInputText0 As New List(Of Rectangle)



End Class