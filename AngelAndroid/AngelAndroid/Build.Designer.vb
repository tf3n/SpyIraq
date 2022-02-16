<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Build
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
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.po = New System.Windows.Forms.NumericUpDown()
        Me.b_del = New System.Windows.Forms.Button()
        Me.b_Add = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.T0 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextIP = New System.Windows.Forms.TextBox()
        Me.box = New System.Windows.Forms.Panel()
        Me.SelectedApk = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextPackage = New System.Windows.Forms.TextBox()
        Me.CheckOpenPackage = New System.Windows.Forms.CheckBox()
        Me.CheckBIND = New System.Windows.Forms.CheckBox()
        Me.CheckIconPatch = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextFlavor = New System.Windows.Forms.TextBox()
        Me.sleep = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.T1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextFutex = New System.Windows.Forms.TextBox()
        Me.TextVersion = New System.Windows.Forms.TextBox()
        Me.TextNamePatch = New System.Windows.Forms.TextBox()
        Me.CheckDoze = New System.Windows.Forms.CheckBox()
        Me.TextNameVictim = New System.Windows.Forms.TextBox()
        Me.CheckHide = New System.Windows.Forms.CheckBox()
        Me.TiMAT = New System.Windows.Forms.Timer(Me.components)
        Me.FolderPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.FilePathApk = New System.Windows.Forms.OpenFileDialog()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.startTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.po, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.box.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.sleep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV0
        '
        Me.DGV0.AllowUserToAddRows = False
        Me.DGV0.AllowUserToDeleteRows = False
        Me.DGV0.AllowUserToResizeColumns = False
        Me.DGV0.AllowUserToResizeRows = False
        Me.DGV0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.DGV0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV0.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV0.EnableHeadersVisualStyles = False
        Me.DGV0.GridColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV0.Location = New System.Drawing.Point(4, 66)
        Me.DGV0.Name = "DGV0"
        Me.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV0.RowHeadersVisible = False
        Me.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV0.Size = New System.Drawing.Size(174, 270)
        Me.DGV0.TabIndex = 5
        '
        'Column2
        '
        Me.Column2.HeaderText = "DNS/ip:port"
        Me.Column2.Name = "Column2"
        '
        'po
        '
        Me.po.BackColor = System.Drawing.Color.Black
        Me.po.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.po.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.po.Location = New System.Drawing.Point(187, 91)
        Me.po.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.po.Name = "po"
        Me.po.Size = New System.Drawing.Size(67, 16)
        Me.po.TabIndex = 9
        Me.po.Value = New Decimal(New Integer() {7744, 0, 0, 0})
        '
        'b_del
        '
        Me.b_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.b_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_del.ForeColor = System.Drawing.Color.Black
        Me.b_del.Location = New System.Drawing.Point(187, 159)
        Me.b_del.Name = "b_del"
        Me.b_del.Size = New System.Drawing.Size(67, 23)
        Me.b_del.TabIndex = 8
        Me.b_del.Text = "DEL"
        Me.b_del.UseVisualStyleBackColor = False
        '
        'b_Add
        '
        Me.b_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.b_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_Add.ForeColor = System.Drawing.Color.Black
        Me.b_Add.Location = New System.Drawing.Point(187, 130)
        Me.b_Add.Name = "b_Add"
        Me.b_Add.Size = New System.Drawing.Size(67, 23)
        Me.b_Add.TabIndex = 7
        Me.b_Add.Text = "Add"
        Me.b_Add.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Controls.Add(Me.T0)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.b_Add)
        Me.Panel1.Controls.Add(Me.b_del)
        Me.Panel1.Controls.Add(Me.DGV0)
        Me.Panel1.Controls.Add(Me.po)
        Me.Panel1.Controls.Add(Me.TextIP)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 351)
        Me.Panel1.TabIndex = 10
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.ForeColor = System.Drawing.Color.Black
        Me.btnUp.Location = New System.Drawing.Point(187, 256)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(67, 23)
        Me.btnUp.TabIndex = 14
        Me.btnUp.Text = "up"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.ForeColor = System.Drawing.Color.Black
        Me.btnDown.Location = New System.Drawing.Point(187, 285)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(67, 23)
        Me.btnDown.TabIndex = 13
        Me.btnDown.Text = "down"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'T0
        '
        Me.T0.AutoSize = True
        Me.T0.ForeColor = System.Drawing.Color.Black
        Me.T0.Location = New System.Drawing.Point(5, 5)
        Me.T0.Name = "T0"
        Me.T0.Size = New System.Drawing.Size(97, 13)
        Me.T0.TabIndex = 12
        Me.T0.Text = "[--- connection ---]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(184, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "dynamic DNS/ip"
        '
        'TextIP
        '
        Me.TextIP.BackColor = System.Drawing.Color.Black
        Me.TextIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextIP.Location = New System.Drawing.Point(5, 41)
        Me.TextIP.Name = "TextIP"
        Me.TextIP.Size = New System.Drawing.Size(173, 13)
        Me.TextIP.TabIndex = 0
        Me.TextIP.Text = "127.0.0.1"
        '
        'box
        '
        Me.box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.box.Controls.Add(Me.SelectedApk)
        Me.box.Controls.Add(Me.Panel3)
        Me.box.Controls.Add(Me.Panel1)
        Me.box.Dock = System.Windows.Forms.DockStyle.Fill
        Me.box.Location = New System.Drawing.Point(0, 0)
        Me.box.Name = "box"
        Me.box.Size = New System.Drawing.Size(543, 392)
        Me.box.TabIndex = 11
        '
        'SelectedApk
        '
        Me.SelectedApk.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.SelectedApk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectedApk.ForeColor = System.Drawing.Color.Black
        Me.SelectedApk.Location = New System.Drawing.Point(457, 360)
        Me.SelectedApk.Name = "SelectedApk"
        Me.SelectedApk.Size = New System.Drawing.Size(69, 23)
        Me.SelectedApk.TabIndex = 13
        Me.SelectedApk.Text = "OK"
        Me.SelectedApk.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TextPackage)
        Me.Panel3.Controls.Add(Me.CheckOpenPackage)
        Me.Panel3.Controls.Add(Me.CheckBIND)
        Me.Panel3.Controls.Add(Me.CheckIconPatch)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TextFlavor)
        Me.Panel3.Controls.Add(Me.sleep)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.T1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TextFutex)
        Me.Panel3.Controls.Add(Me.TextVersion)
        Me.Panel3.Controls.Add(Me.TextNamePatch)
        Me.Panel3.Controls.Add(Me.CheckDoze)
        Me.Panel3.Controls.Add(Me.TextNameVictim)
        Me.Panel3.Controls.Add(Me.CheckHide)
        Me.Panel3.Location = New System.Drawing.Point(272, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(263, 351)
        Me.Panel3.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(5, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Package Name"
        '
        'TextPackage
        '
        Me.TextPackage.BackColor = System.Drawing.Color.Black
        Me.TextPackage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextPackage.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextPackage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextPackage.Location = New System.Drawing.Point(5, 282)
        Me.TextPackage.MaxLength = 99
        Me.TextPackage.Name = "TextPackage"
        Me.TextPackage.ShortcutsEnabled = False
        Me.TextPackage.Size = New System.Drawing.Size(249, 13)
        Me.TextPackage.TabIndex = 23
        Me.TextPackage.Text = "package.name"
        '
        'CheckOpenPackage
        '
        Me.CheckOpenPackage.AutoSize = True
        Me.CheckOpenPackage.ForeColor = System.Drawing.Color.Black
        Me.CheckOpenPackage.Location = New System.Drawing.Point(150, 146)
        Me.CheckOpenPackage.Name = "CheckOpenPackage"
        Me.CheckOpenPackage.Size = New System.Drawing.Size(107, 17)
        Me.CheckOpenPackage.TabIndex = 22
        Me.CheckOpenPackage.Text = "Merge Advanced"
        Me.CheckOpenPackage.UseVisualStyleBackColor = True
        '
        'CheckBIND
        '
        Me.CheckBIND.AutoSize = True
        Me.CheckBIND.ForeColor = System.Drawing.Color.Black
        Me.CheckBIND.Location = New System.Drawing.Point(75, 169)
        Me.CheckBIND.Name = "CheckBIND"
        Me.CheckBIND.Size = New System.Drawing.Size(46, 17)
        Me.CheckBIND.TabIndex = 21
        Me.CheckBIND.Text = "bind"
        Me.CheckBIND.UseVisualStyleBackColor = True
        '
        'CheckIconPatch
        '
        Me.CheckIconPatch.AutoSize = True
        Me.CheckIconPatch.ForeColor = System.Drawing.Color.Black
        Me.CheckIconPatch.Location = New System.Drawing.Point(75, 146)
        Me.CheckIconPatch.Name = "CheckIconPatch"
        Me.CheckIconPatch.Size = New System.Drawing.Size(45, 17)
        Me.CheckIconPatch.TabIndex = 20
        Me.CheckIconPatch.Text = "icon"
        Me.CheckIconPatch.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(5, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "flavor"
        '
        'TextFlavor
        '
        Me.TextFlavor.BackColor = System.Drawing.Color.Black
        Me.TextFlavor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextFlavor.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextFlavor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextFlavor.Location = New System.Drawing.Point(5, 323)
        Me.TextFlavor.MaxLength = 25
        Me.TextFlavor.Name = "TextFlavor"
        Me.TextFlavor.ShortcutsEnabled = False
        Me.TextFlavor.Size = New System.Drawing.Size(249, 13)
        Me.TextFlavor.TabIndex = 18
        Me.TextFlavor.Text = ".suffix"
        '
        'sleep
        '
        Me.sleep.BackColor = System.Drawing.Color.Black
        Me.sleep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sleep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.sleep.Location = New System.Drawing.Point(5, 205)
        Me.sleep.Maximum = New Decimal(New Integer() {86400000, 0, 0, 0})
        Me.sleep.Name = "sleep"
        Me.sleep.Size = New System.Drawing.Size(249, 16)
        Me.sleep.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(5, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "futex"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "sleep"
        '
        'T1
        '
        Me.T1.AutoSize = True
        Me.T1.ForeColor = System.Drawing.Color.Black
        Me.T1.Location = New System.Drawing.Point(5, 4)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(96, 13)
        Me.T1.TabIndex = 13
        Me.T1.Text = "[--- installation ---]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "version"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "name patch"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "name of victim"
        '
        'TextFutex
        '
        Me.TextFutex.BackColor = System.Drawing.Color.Black
        Me.TextFutex.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextFutex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextFutex.Location = New System.Drawing.Point(5, 244)
        Me.TextFutex.Name = "TextFutex"
        Me.TextFutex.ReadOnly = True
        Me.TextFutex.ShortcutsEnabled = False
        Me.TextFutex.Size = New System.Drawing.Size(249, 13)
        Me.TextFutex.TabIndex = 5
        Me.TextFutex.Text = "mx-zo-jr-eo"
        '
        'TextVersion
        '
        Me.TextVersion.BackColor = System.Drawing.Color.Black
        Me.TextVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextVersion.Location = New System.Drawing.Point(5, 120)
        Me.TextVersion.Name = "TextVersion"
        Me.TextVersion.ShortcutsEnabled = False
        Me.TextVersion.Size = New System.Drawing.Size(249, 13)
        Me.TextVersion.TabIndex = 3
        Me.TextVersion.Text = "1.0.0.0"
        '
        'TextNamePatch
        '
        Me.TextNamePatch.BackColor = System.Drawing.Color.Black
        Me.TextNamePatch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextNamePatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextNamePatch.Location = New System.Drawing.Point(5, 80)
        Me.TextNamePatch.Name = "TextNamePatch"
        Me.TextNamePatch.Size = New System.Drawing.Size(249, 13)
        Me.TextNamePatch.TabIndex = 2
        Me.TextNamePatch.Text = "spymax"
        '
        'CheckDoze
        '
        Me.CheckDoze.AutoSize = True
        Me.CheckDoze.ForeColor = System.Drawing.Color.Black
        Me.CheckDoze.Location = New System.Drawing.Point(5, 169)
        Me.CheckDoze.Name = "CheckDoze"
        Me.CheckDoze.Size = New System.Drawing.Size(49, 17)
        Me.CheckDoze.TabIndex = 1
        Me.CheckDoze.Text = "doze"
        Me.CheckDoze.UseVisualStyleBackColor = True
        '
        'TextNameVictim
        '
        Me.TextNameVictim.BackColor = System.Drawing.Color.Black
        Me.TextNameVictim.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextNameVictim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextNameVictim.Location = New System.Drawing.Point(5, 41)
        Me.TextNameVictim.Name = "TextNameVictim"
        Me.TextNameVictim.Size = New System.Drawing.Size(249, 13)
        Me.TextNameVictim.TabIndex = 1
        Me.TextNameVictim.Text = "hacked"
        '
        'CheckHide
        '
        Me.CheckHide.AutoSize = True
        Me.CheckHide.ForeColor = System.Drawing.Color.Black
        Me.CheckHide.Location = New System.Drawing.Point(5, 146)
        Me.CheckHide.Name = "CheckHide"
        Me.CheckHide.Size = New System.Drawing.Size(46, 17)
        Me.CheckHide.TabIndex = 0
        Me.CheckHide.Text = "hide"
        Me.CheckHide.UseVisualStyleBackColor = True
        '
        'TiMAT
        '
        '
        'FilePathApk
        '
        Me.FilePathApk.FileName = "OpenFileDialog1"
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'startTime
        '
        Me.startTime.Interval = 500
        '
        'Build
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(543, 392)
        Me.Controls.Add(Me.box)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Build"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "Build"
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.po, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.box.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.sleep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV0 As DataGridView
    Friend WithEvents po As NumericUpDown
    Friend WithEvents b_del As Button
    Friend WithEvents b_Add As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextIP As TextBox
    Friend WithEvents box As Panel
    Friend WithEvents TextFutex As TextBox
    Friend WithEvents CheckDoze As CheckBox
    Friend WithEvents CheckHide As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextVersion As TextBox
    Friend WithEvents TextNamePatch As TextBox
    Friend WithEvents TextNameVictim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents T0 As Label
    Friend WithEvents T1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SelectedApk As Button
    Friend WithEvents TiMAT As Timer
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents sleep As NumericUpDown
    Friend WithEvents FolderPath As FolderBrowserDialog
    Friend WithEvents FilePathApk As OpenFileDialog
    Friend WithEvents Label9 As Label
    Friend WithEvents TextFlavor As TextBox
    Friend WithEvents CheckIconPatch As CheckBox
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents TOpacity As Timer
    Friend WithEvents startTime As Timer
    Friend WithEvents CheckBIND As CheckBox
    Friend WithEvents CheckOpenPackage As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextPackage As TextBox
End Class
