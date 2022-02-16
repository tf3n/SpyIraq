<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AngelAndroidForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV0 = New System.Windows.Forms.DataGridView()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FilesManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CallsManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocationManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GPSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GSMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CameraManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellTerminalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MicrophoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CallPhoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyloggerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcquirePowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimumPowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSocketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TVW = New System.Windows.Forms.Timer(Me.components)
        Me.ctxMu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.notfi = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BoxTitle = New System.Windows.Forms.PictureBox()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column0 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.ctxMu.SuspendLayout()
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DGV0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column6, Me.Column9, Me.Column7, Me.Column4, Me.Column2, Me.Column3, Me.Column8, Me.Column5})
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
        Me.DGV0.GridColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.DGV0.Location = New System.Drawing.Point(0, 0)
        Me.DGV0.MultiSelect = False
        Me.DGV0.Name = "DGV0"
        Me.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV0.RowHeadersVisible = False
        Me.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV0.ShowCellToolTips = False
        Me.DGV0.Size = New System.Drawing.Size(812, 334)
        Me.DGV0.TabIndex = 1
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesManagerToolStripMenuItem, Me.SMSManagerToolStripMenuItem, Me.CallsManagerToolStripMenuItem, Me.ContactsManagerToolStripMenuItem, Me.LocationManagerToolStripMenuItem, Me.AccountManagerToolStripMenuItem, Me.CameraManagerToolStripMenuItem, Me.ShellTerminalToolStripMenuItem, Me.InformationToolStripMenuItem, Me.ApplicationsToolStripMenuItem, Me.MicrophoneToolStripMenuItem, Me.CallPhoneToolStripMenuItem, Me.ClipboardToolStripMenuItem, Me.KeyloggerToolStripMenuItem, Me.ServerToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.Size = New System.Drawing.Size(172, 334)
        Me.ctxMenu.Tag = ""
        '
        'FilesManagerToolStripMenuItem
        '
        Me.FilesManagerToolStripMenuItem.Name = "FilesManagerToolStripMenuItem"
        Me.FilesManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FilesManagerToolStripMenuItem.Tag = ""
        Me.FilesManagerToolStripMenuItem.Text = "Files Manager"
        '
        'SMSManagerToolStripMenuItem
        '
        Me.SMSManagerToolStripMenuItem.Name = "SMSManagerToolStripMenuItem"
        Me.SMSManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SMSManagerToolStripMenuItem.Tag = ""
        Me.SMSManagerToolStripMenuItem.Text = "SMS Manager"
        '
        'CallsManagerToolStripMenuItem
        '
        Me.CallsManagerToolStripMenuItem.Name = "CallsManagerToolStripMenuItem"
        Me.CallsManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CallsManagerToolStripMenuItem.Tag = ""
        Me.CallsManagerToolStripMenuItem.Text = "Calls Manager"
        '
        'ContactsManagerToolStripMenuItem
        '
        Me.ContactsManagerToolStripMenuItem.Name = "ContactsManagerToolStripMenuItem"
        Me.ContactsManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ContactsManagerToolStripMenuItem.Tag = ""
        Me.ContactsManagerToolStripMenuItem.Text = "Contacts Manager"
        '
        'LocationManagerToolStripMenuItem
        '
        Me.LocationManagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPSToolStripMenuItem, Me.GSMToolStripMenuItem})
        Me.LocationManagerToolStripMenuItem.Name = "LocationManagerToolStripMenuItem"
        Me.LocationManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LocationManagerToolStripMenuItem.Tag = ""
        Me.LocationManagerToolStripMenuItem.Text = "Location Manager"
        '
        'GPSToolStripMenuItem
        '
        Me.GPSToolStripMenuItem.Name = "GPSToolStripMenuItem"
        Me.GPSToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.GPSToolStripMenuItem.Text = "GPS"
        '
        'GSMToolStripMenuItem
        '
        Me.GSMToolStripMenuItem.Name = "GSMToolStripMenuItem"
        Me.GSMToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.GSMToolStripMenuItem.Text = "GSM"
        '
        'AccountManagerToolStripMenuItem
        '
        Me.AccountManagerToolStripMenuItem.Name = "AccountManagerToolStripMenuItem"
        Me.AccountManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AccountManagerToolStripMenuItem.Tag = ""
        Me.AccountManagerToolStripMenuItem.Text = "Account Manager"
        '
        'CameraManagerToolStripMenuItem
        '
        Me.CameraManagerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrontToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.CameraManagerToolStripMenuItem.Name = "CameraManagerToolStripMenuItem"
        Me.CameraManagerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CameraManagerToolStripMenuItem.Tag = ""
        Me.CameraManagerToolStripMenuItem.Text = "Camera Manager"
        '
        'FrontToolStripMenuItem
        '
        Me.FrontToolStripMenuItem.Name = "FrontToolStripMenuItem"
        Me.FrontToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.FrontToolStripMenuItem.Text = "Front"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'ShellTerminalToolStripMenuItem
        '
        Me.ShellTerminalToolStripMenuItem.Name = "ShellTerminalToolStripMenuItem"
        Me.ShellTerminalToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ShellTerminalToolStripMenuItem.Tag = ""
        Me.ShellTerminalToolStripMenuItem.Text = "Shell Terminal"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.InformationToolStripMenuItem.Tag = ""
        Me.InformationToolStripMenuItem.Text = "informations"
        '
        'ApplicationsToolStripMenuItem
        '
        Me.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem"
        Me.ApplicationsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ApplicationsToolStripMenuItem.Tag = ""
        Me.ApplicationsToolStripMenuItem.Text = "Applications"
        '
        'MicrophoneToolStripMenuItem
        '
        Me.MicrophoneToolStripMenuItem.Name = "MicrophoneToolStripMenuItem"
        Me.MicrophoneToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.MicrophoneToolStripMenuItem.Tag = ""
        Me.MicrophoneToolStripMenuItem.Text = "Microphone"
        '
        'CallPhoneToolStripMenuItem
        '
        Me.CallPhoneToolStripMenuItem.Name = "CallPhoneToolStripMenuItem"
        Me.CallPhoneToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CallPhoneToolStripMenuItem.Text = "Call Phone"
        '
        'ClipboardToolStripMenuItem
        '
        Me.ClipboardToolStripMenuItem.Name = "ClipboardToolStripMenuItem"
        Me.ClipboardToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ClipboardToolStripMenuItem.Text = "Clipboard"
        '
        'KeyloggerToolStripMenuItem
        '
        Me.KeyloggerToolStripMenuItem.Name = "KeyloggerToolStripMenuItem"
        Me.KeyloggerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.KeyloggerToolStripMenuItem.Text = "Keylogger"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcquirePowerToolStripMenuItem, Me.MinimumPowerToolStripMenuItem, Me.EditSocketToolStripMenuItem, Me.RestartToolStripMenuItem, Me.RenameToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ServerToolStripMenuItem.Tag = ""
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'AcquirePowerToolStripMenuItem
        '
        Me.AcquirePowerToolStripMenuItem.Name = "AcquirePowerToolStripMenuItem"
        Me.AcquirePowerToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AcquirePowerToolStripMenuItem.Text = "Maximum power"
        '
        'MinimumPowerToolStripMenuItem
        '
        Me.MinimumPowerToolStripMenuItem.Name = "MinimumPowerToolStripMenuItem"
        Me.MinimumPowerToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MinimumPowerToolStripMenuItem.Text = "Minimum power"
        '
        'EditSocketToolStripMenuItem
        '
        Me.EditSocketToolStripMenuItem.Name = "EditSocketToolStripMenuItem"
        Me.EditSocketToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EditSocketToolStripMenuItem.Text = "EditSocket"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'TVW
        '
        '
        'ctxMu
        '
        Me.ctxMu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuildToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.UsersToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ctxMu.Name = "ctxMu"
        Me.ctxMu.ShowImageMargin = False
        Me.ctxMu.Size = New System.Drawing.Size(92, 114)
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'notfi
        '
        Me.notfi.ContextMenuStrip = Me.ctxMu
        Me.notfi.Text = "Spy Max"
        Me.notfi.Visible = True
        '
        'BoxTitle
        '
        Me.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BoxTitle.ErrorImage = Nothing
        Me.BoxTitle.InitialImage = Nothing
        Me.BoxTitle.Location = New System.Drawing.Point(0, 334)
        Me.BoxTitle.Name = "BoxTitle"
        Me.BoxTitle.Size = New System.Drawing.Size(812, 18)
        Me.BoxTitle.TabIndex = 2
        Me.BoxTitle.TabStop = False
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AngelAndroid_v2.My.Resources.Resources.logo2
        Me.PictureBox1.Location = New System.Drawing.Point(340, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "Version"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 73
        '
        'Column8
        '
        Me.Column8.HeaderText = "Defender"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 81
        '
        'Column3
        '
        Me.Column3.HeaderText = "ip"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "Country"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 74
        '
        'Column4
        '
        Me.Column4.HeaderText = "Flag"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 33
        '
        'Column7
        '
        Me.Column7.HeaderText = "Release"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 74
        '
        'Column9
        '
        Me.Column9.HeaderText = "OS"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 45
        '
        'Column6
        '
        Me.Column6.HeaderText = "Device-Name"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 101
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 61
        '
        'Column0
        '
        Me.Column0.HeaderText = ""
        Me.Column0.Name = "Column0"
        Me.Column0.Width = 5
        '
        'AngelAndroidForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(812, 352)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGV0)
        Me.Controls.Add(Me.BoxTitle)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Name = "AngelAndroidForm"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spy Max"
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.ctxMu.ResumeLayout(False)
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV0 As DataGridView
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents FilesManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SMSManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CallsManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocationManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CameraManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShellTerminalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MicrophoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TVW As Timer
    Friend WithEvents FrontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GPSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GSMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ctxMu As ContextMenuStrip
    Friend WithEvents BuildToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents notfi As NotifyIcon
    Friend WithEvents ApplicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditSocketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoxTitle As PictureBox
    Friend WithEvents TOpacity As Timer
    Friend WithEvents KeyloggerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcquirePowerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CallPhoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClipboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimumPowerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column0 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
