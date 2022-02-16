<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ports
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
        Me.pnl0 = New System.Windows.Forms.Panel()
        Me.DGV0 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.po = New System.Windows.Forms.NumericUpDown()
        Me.b_del = New System.Windows.Forms.Button()
        Me.b_Add = New System.Windows.Forms.Button()
        Me.b_ok = New System.Windows.Forms.Button()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.pnl0.SuspendLayout()
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        CType(Me.po, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl0
        '
        Me.pnl0.BackColor = System.Drawing.Color.Black
        Me.pnl0.Controls.Add(Me.DGV0)
        Me.pnl0.Controls.Add(Me.pnl1)
        Me.pnl0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.pnl0.Location = New System.Drawing.Point(0, 0)
        Me.pnl0.Name = "pnl0"
        Me.pnl0.Size = New System.Drawing.Size(279, 214)
        Me.pnl0.TabIndex = 0
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
        Me.DGV0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
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
        Me.DGV0.Size = New System.Drawing.Size(205, 214)
        Me.DGV0.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ports"
        Me.Column1.Name = "Column1"
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.Transparent
        Me.pnl1.Controls.Add(Me.btnUp)
        Me.pnl1.Controls.Add(Me.btnDown)
        Me.pnl1.Controls.Add(Me.po)
        Me.pnl1.Controls.Add(Me.b_del)
        Me.pnl1.Controls.Add(Me.b_Add)
        Me.pnl1.Controls.Add(Me.b_ok)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl1.Location = New System.Drawing.Point(205, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(74, 214)
        Me.pnl1.TabIndex = 5
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.ForeColor = System.Drawing.Color.Black
        Me.btnUp.Location = New System.Drawing.Point(3, 109)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(67, 23)
        Me.btnUp.TabIndex = 16
        Me.btnUp.Text = "up"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.ForeColor = System.Drawing.Color.Black
        Me.btnDown.Location = New System.Drawing.Point(3, 138)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(67, 23)
        Me.btnDown.TabIndex = 15
        Me.btnDown.Text = "down"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'po
        '
        Me.po.BackColor = System.Drawing.Color.Black
        Me.po.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.po.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.po.Location = New System.Drawing.Point(3, 12)
        Me.po.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.po.Name = "po"
        Me.po.Size = New System.Drawing.Size(67, 16)
        Me.po.TabIndex = 6
        Me.po.Value = New Decimal(New Integer() {7744, 0, 0, 0})
        '
        'b_del
        '
        Me.b_del.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.b_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_del.ForeColor = System.Drawing.Color.Black
        Me.b_del.Location = New System.Drawing.Point(3, 67)
        Me.b_del.Name = "b_del"
        Me.b_del.Size = New System.Drawing.Size(67, 23)
        Me.b_del.TabIndex = 2
        Me.b_del.Text = "DEL"
        Me.b_del.UseVisualStyleBackColor = False
        '
        'b_Add
        '
        Me.b_Add.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.b_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_Add.ForeColor = System.Drawing.Color.Black
        Me.b_Add.Location = New System.Drawing.Point(3, 38)
        Me.b_Add.Name = "b_Add"
        Me.b_Add.Size = New System.Drawing.Size(67, 23)
        Me.b_Add.TabIndex = 1
        Me.b_Add.Text = "Add"
        Me.b_Add.UseVisualStyleBackColor = False
        '
        'b_ok
        '
        Me.b_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_ok.ForeColor = System.Drawing.Color.Black
        Me.b_ok.Location = New System.Drawing.Point(3, 179)
        Me.b_ok.Name = "b_ok"
        Me.b_ok.Size = New System.Drawing.Size(67, 23)
        Me.b_ok.TabIndex = 0
        Me.b_ok.Text = "OK"
        Me.b_ok.UseVisualStyleBackColor = False
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'Ports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(279, 214)
        Me.Controls.Add(Me.pnl0)
        Me.MinimumSize = New System.Drawing.Size(295, 253)
        Me.Name = "Ports"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ports"
        Me.pnl0.ResumeLayout(False)
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        CType(Me.po, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl0 As Panel
    Friend WithEvents b_ok As Button
    Friend WithEvents pnl1 As Panel
    Friend WithEvents DGV0 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents po As NumericUpDown
    Friend WithEvents b_del As Button
    Friend WithEvents b_Add As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents TOpacity As Timer
End Class
