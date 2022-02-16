Public Class Ports
    Public _ports As String = Nothing

    Sub New()


        InitializeComponent()

        Me.Font = reso.f


    End Sub
    Private Sub SpyStyle()
        For Each gr As DataGridView In pnl0.Controls.OfType(Of DataGridView)()
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
        For Each btn As Button In pnl1.Controls.OfType(Of Button)()
            btn.BackColor = SpySettings.DefaultColor_Foreground
            btn.ForeColor = SpySettings.DefaultColor_Background
        Next

        For Each pnls As Panel In Me.Controls.OfType(Of Panel)()
            pnls.BackColor = SpySettings.DefaultColor_Background
        Next
        RectPO.Add(New Rectangle(po.Location.X - 1, po.Location.Y - 1, po.Width + 1, po.Height + 1))
        po.BackColor = SpySettings.DefaultColor_Background
        po.ForeColor = SpySettings.DefaultColor_Foreground
        Me.Refresh()
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub Ports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.max

        DGV0.ColumnHeadersVisible = False

        DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f

        DGV0.DefaultCellStyle.Font = reso.f

        SpyStyle()

        For Each p In My.Settings.ports.Split(":")

            DGV0.Rows.Add(p)

        Next

        po.Value = My.Settings.build_text_port

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True

        b_ok.Focus()

        b_ok.Select()

    End Sub

    Private Sub b_Add_Click(sender As Object, e As EventArgs) Handles b_Add.Click

        Dim p As String = po.Value

        Dim b As Boolean

        For i As Integer = 0 To DGV0.Rows.Count - 1

            If DGV0.Rows(i).Cells(0).Value = p Then

                b = True

            End If

        Next

        If b = False Then

            DGV0.Rows.Add(po.Value)

        End If

    End Sub

    Private Sub b_del_Click(sender As Object, e As EventArgs) Handles b_del.Click


        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index)


            Next

        End If


    End Sub

    Private Sub b_ok_Click(sender As Object, e As EventArgs) Handles b_ok.Click

        If DGV0.Rows.Count > 0 Then

            For i As Integer = 0 To DGV0.Rows.Count - 1

                If i = DGV0.Rows.Count - 1 Then

                    _ports &= DGV0.Rows(i).Cells(0).Value

                Else

                    _ports &= DGV0.Rows(i).Cells(0).Value & ":"

                End If


            Next
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If

    End Sub
    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click

        Rowinsert(True)

    End Sub
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click

        Rowinsert(False)

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


    Private Sub pnl1_Paint(sender As Object, e As PaintEventArgs) Handles pnl1.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim transColor As Color = SpySettings.DefaultColor_Foreground
        If RectPO.Count > 0 Then
            For Each rec In RectPO
                If rec.Width > 0 Then
                    e.Graphics.FillRectangle(New SolidBrush(transColor), rec)
                End If
            Next
        End If
    End Sub

    Private RectPO As New List(Of Rectangle)

End Class