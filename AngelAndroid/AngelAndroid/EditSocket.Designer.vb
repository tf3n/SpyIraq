<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditSocket
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
        Me.PanelBOX = New System.Windows.Forms.Panel()
        Me.OKY = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.T0 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_Add = New System.Windows.Forms.Button()
        Me.b_del = New System.Windows.Forms.Button()
        Me.DGV0 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.po = New System.Windows.Forms.NumericUpDown()
        Me.TextIP = New System.Windows.Forms.TextBox()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBOX.SuspendLayout()
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.po, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBOX
        '
        Me.PanelBOX.Controls.Add(Me.OKY)
        Me.PanelBOX.Controls.Add(Me.btnUp)
        Me.PanelBOX.Controls.Add(Me.btnDown)
        Me.PanelBOX.Controls.Add(Me.T0)
        Me.PanelBOX.Controls.Add(Me.Label2)
        Me.PanelBOX.Controls.Add(Me.Label1)
        Me.PanelBOX.Controls.Add(Me.b_Add)
        Me.PanelBOX.Controls.Add(Me.b_del)
        Me.PanelBOX.Controls.Add(Me.DGV0)
        Me.PanelBOX.Controls.Add(Me.po)
        Me.PanelBOX.Controls.Add(Me.TextIP)
        Me.PanelBOX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBOX.Location = New System.Drawing.Point(0, 0)
        Me.PanelBOX.Name = "PanelBOX"
        Me.PanelBOX.Size = New System.Drawing.Size(269, 362)
        Me.PanelBOX.TabIndex = 11
        '
        'OKY
        '
        Me.OKY.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.OKY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKY.ForeColor = System.Drawing.Color.Black
        Me.OKY.Location = New System.Drawing.Point(185, 299)
        Me.OKY.Name = "OKY"
        Me.OKY.Size = New System.Drawing.Size(67, 23)
        Me.OKY.TabIndex = 14
        Me.OKY.Text = "OK"
        Me.OKY.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.ForeColor = System.Drawing.Color.Black
        Me.btnUp.Location = New System.Drawing.Point(185, 241)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(67, 23)
        Me.btnUp.TabIndex = 14
        Me.btnUp.Text = "up"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.ForeColor = System.Drawing.Color.Black
        Me.btnDown.Location = New System.Drawing.Point(185, 270)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(67, 23)
        Me.btnDown.TabIndex = 13
        Me.btnDown.Text = "down"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'T0
        '
        Me.T0.AutoSize = True
        Me.T0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.T0.Location = New System.Drawing.Point(-1, 0)
        Me.T0.Name = "T0"
        Me.T0.Size = New System.Drawing.Size(97, 13)
        Me.T0.TabIndex = 12
        Me.T0.Text = "[--- connection ---]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(182, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "port"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "dynamic DNS/ip"
        '
        'b_Add
        '
        Me.b_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.b_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_Add.ForeColor = System.Drawing.Color.Black
        Me.b_Add.Location = New System.Drawing.Point(185, 130)
        Me.b_Add.Name = "b_Add"
        Me.b_Add.Size = New System.Drawing.Size(67, 23)
        Me.b_Add.TabIndex = 7
        Me.b_Add.Text = "Add"
        Me.b_Add.UseVisualStyleBackColor = False
        '
        'b_del
        '
        Me.b_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.b_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_del.ForeColor = System.Drawing.Color.Black
        Me.b_del.Location = New System.Drawing.Point(185, 159)
        Me.b_del.Name = "b_del"
        Me.b_del.Size = New System.Drawing.Size(67, 23)
        Me.b_del.TabIndex = 8
        Me.b_del.Text = "DEL"
        Me.b_del.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV0.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV0.EnableHeadersVisualStyles = False
        Me.DGV0.GridColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV0.Location = New System.Drawing.Point(2, 66)
        Me.DGV0.Name = "DGV0"
        Me.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV0.RowHeadersVisible = False
        Me.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV0.Size = New System.Drawing.Size(174, 240)
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
        Me.po.Location = New System.Drawing.Point(185, 91)
        Me.po.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.po.Name = "po"
        Me.po.Size = New System.Drawing.Size(67, 16)
        Me.po.TabIndex = 9
        Me.po.Value = New Decimal(New Integer() {7744, 0, 0, 0})
        '
        'TextIP
        '
        Me.TextIP.BackColor = System.Drawing.Color.Black
        Me.TextIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextIP.Location = New System.Drawing.Point(3, 44)
        Me.TextIP.Name = "TextIP"
        Me.TextIP.Size = New System.Drawing.Size(173, 13)
        Me.TextIP.TabIndex = 0
        Me.TextIP.Text = "127.0.0.1"
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'EditSocket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(269, 362)
        Me.Controls.Add(Me.PanelBOX)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "EditSocket"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "EditSocket"
        Me.PanelBOX.ResumeLayout(False)
        Me.PanelBOX.PerformLayout()
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.po, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBOX As Panel
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents T0 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents b_Add As Button
    Friend WithEvents b_del As Button
    Friend WithEvents DGV0 As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TextIP As TextBox
    Friend WithEvents OKY As Button
    Friend WithEvents po As NumericUpDown
    Friend WithEvents TOpacity As Timer
End Class
