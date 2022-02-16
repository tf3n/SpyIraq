<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV0 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PathsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExternalStorageDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryDownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryPicturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirectoryDCIMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnZipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetWallpaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaySoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderDownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilesUpload = New System.Windows.Forms.OpenFileDialog()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.BoxTitle = New System.Windows.Forms.PictureBox()
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV0
        '
        Me.DGV0.AllowUserToAddRows = False
        Me.DGV0.AllowUserToDeleteRows = False
        Me.DGV0.AllowUserToResizeColumns = False
        Me.DGV0.AllowUserToResizeRows = False
        Me.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV0.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV0.BackgroundColor = System.Drawing.Color.Black
        Me.DGV0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV0.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGV0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV0.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column6, Me.Column9, Me.Column3})
        Me.DGV0.ContextMenuStrip = Me.ctxMenu
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV0.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV0.EnableHeadersVisualStyles = False
        Me.DGV0.GridColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV0.Location = New System.Drawing.Point(0, 0)
        Me.DGV0.Name = "DGV0"
        Me.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV0.RowHeadersVisible = False
        Me.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV0.Size = New System.Drawing.Size(414, 213)
        Me.DGV0.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "type"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 54
        '
        'Column4
        '
        Me.Column4.HeaderText = "name"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 61
        '
        'Column2
        '
        Me.Column2.HeaderText = "size"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 53
        '
        'Column6
        '
        Me.Column6.HeaderText = "modified-date"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 107
        '
        'Column9
        '
        Me.Column9.HeaderText = "date"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 54
        '
        'Column3
        '
        Me.Column3.HeaderText = " "
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 14
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PathsToolStripMenuItem, Me.OpenToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ViewToolStripMenuItem, Me.DownloadToolStripMenuItem, Me.UploadToolStripMenuItem, Me.EncryptToolStripMenuItem, Me.DecodeToolStripMenuItem, Me.ZipToolStripMenuItem, Me.UnZipToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.AddFilesToolStripMenuItem, Me.RenameToolStripMenuItem, Me.EditToolStripMenuItem, Me.HideToolStripMenuItem, Me.ShowToolStripMenuItem, Me.SetWallpaperToolStripMenuItem, Me.PlaySoundToolStripMenuItem, Me.FolderDownloadsToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(181, 510)
        '
        'PathsToolStripMenuItem
        '
        Me.PathsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExternalStorageDirectoryToolStripMenuItem, Me.DirectoryDownloadsToolStripMenuItem, Me.DirectoryPicturesToolStripMenuItem, Me.DirectoryDCIMToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.PathsToolStripMenuItem.Name = "PathsToolStripMenuItem"
        Me.PathsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PathsToolStripMenuItem.Text = "Paths"
        '
        'ExternalStorageDirectoryToolStripMenuItem
        '
        Me.ExternalStorageDirectoryToolStripMenuItem.Name = "ExternalStorageDirectoryToolStripMenuItem"
        Me.ExternalStorageDirectoryToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ExternalStorageDirectoryToolStripMenuItem.Text = "External Storage Directory"
        '
        'DirectoryDownloadsToolStripMenuItem
        '
        Me.DirectoryDownloadsToolStripMenuItem.Name = "DirectoryDownloadsToolStripMenuItem"
        Me.DirectoryDownloadsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DirectoryDownloadsToolStripMenuItem.Text = "Directory Downloads"
        '
        'DirectoryPicturesToolStripMenuItem
        '
        Me.DirectoryPicturesToolStripMenuItem.Name = "DirectoryPicturesToolStripMenuItem"
        Me.DirectoryPicturesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DirectoryPicturesToolStripMenuItem.Text = "Directory Pictures"
        '
        'DirectoryDCIMToolStripMenuItem
        '
        Me.DirectoryDCIMToolStripMenuItem.Name = "DirectoryDCIMToolStripMenuItem"
        Me.DirectoryDCIMToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DirectoryDCIMToolStripMenuItem.Text = "Directory DCIM"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CustomToolStripMenuItem.Text = "Custom..."
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewToolStripMenuItem.Text = "View File"
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DownloadToolStripMenuItem.Text = "Download"
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UploadToolStripMenuItem.Text = "Upload"
        '
        'EncryptToolStripMenuItem
        '
        Me.EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem"
        Me.EncryptToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EncryptToolStripMenuItem.Text = "Encrypt"
        '
        'DecodeToolStripMenuItem
        '
        Me.DecodeToolStripMenuItem.Name = "DecodeToolStripMenuItem"
        Me.DecodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DecodeToolStripMenuItem.Text = "Decode"
        '
        'ZipToolStripMenuItem
        '
        Me.ZipToolStripMenuItem.Name = "ZipToolStripMenuItem"
        Me.ZipToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ZipToolStripMenuItem.Text = "Zip"
        '
        'UnZipToolStripMenuItem
        '
        Me.UnZipToolStripMenuItem.Name = "UnZipToolStripMenuItem"
        Me.UnZipToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UnZipToolStripMenuItem.Text = "UnZip"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'AddFilesToolStripMenuItem
        '
        Me.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem"
        Me.AddFilesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddFilesToolStripMenuItem.Text = "Add Files"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HideToolStripMenuItem.Text = "Hidden"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowToolStripMenuItem.Text = "UnHidden"
        '
        'SetWallpaperToolStripMenuItem
        '
        Me.SetWallpaperToolStripMenuItem.Name = "SetWallpaperToolStripMenuItem"
        Me.SetWallpaperToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SetWallpaperToolStripMenuItem.Text = "Set wallpaper"
        '
        'PlaySoundToolStripMenuItem
        '
        Me.PlaySoundToolStripMenuItem.Name = "PlaySoundToolStripMenuItem"
        Me.PlaySoundToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PlaySoundToolStripMenuItem.Text = "Play sound"
        '
        'FolderDownloadsToolStripMenuItem
        '
        Me.FolderDownloadsToolStripMenuItem.Name = "FolderDownloadsToolStripMenuItem"
        Me.FolderDownloadsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FolderDownloadsToolStripMenuItem.Text = "Downloads"
        '
        'FilesUpload
        '
        Me.FilesUpload.FileName = "OpenFileDialog1"
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'PB
        '
        Me.PB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PB.Location = New System.Drawing.Point(0, 213)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(414, 10)
        Me.PB.TabIndex = 5
        '
        'BoxTitle
        '
        Me.BoxTitle.BackColor = System.Drawing.Color.Black
        Me.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BoxTitle.ErrorImage = Nothing
        Me.BoxTitle.InitialImage = Nothing
        Me.BoxTitle.Location = New System.Drawing.Point(0, 223)
        Me.BoxTitle.Name = "BoxTitle"
        Me.BoxTitle.Size = New System.Drawing.Size(414, 18)
        Me.BoxTitle.TabIndex = 6
        Me.BoxTitle.TabStop = False
        '
        'FileManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 241)
        Me.Controls.Add(Me.DGV0)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.BoxTitle)
        Me.Name = "FileManager"
        Me.Opacity = 0R
        Me.Text = "FileManager"
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV0 As DataGridView
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents DownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilesUpload As OpenFileDialog
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PathsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExternalStorageDirectoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryDownloadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryPicturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DirectoryDCIMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderDownloadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncryptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TOpacity As Timer
    Friend WithEvents PB As ProgressBar
    Friend WithEvents BoxTitle As PictureBox
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents SetWallpaperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaySoundToolStripMenuItem As ToolStripMenuItem
End Class
