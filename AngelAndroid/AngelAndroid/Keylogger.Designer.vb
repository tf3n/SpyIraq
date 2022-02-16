<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keylogger
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Keylogger_Start = New System.Windows.Forms.Button()
        Me.Keylogger_Stop = New System.Windows.Forms.Button()
        Me.BOXP = New System.Windows.Forms.Panel()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.DGV0 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOXP.SuspendLayout()
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Keylogger_Start
        '
        Me.Keylogger_Start.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Keylogger_Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Keylogger_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Keylogger_Start.ForeColor = System.Drawing.Color.Black
        Me.Keylogger_Start.Location = New System.Drawing.Point(334, 4)
        Me.Keylogger_Start.Name = "Keylogger_Start"
        Me.Keylogger_Start.Size = New System.Drawing.Size(75, 23)
        Me.Keylogger_Start.TabIndex = 1
        Me.Keylogger_Start.Text = "Start"
        Me.Keylogger_Start.UseVisualStyleBackColor = False
        '
        'Keylogger_Stop
        '
        Me.Keylogger_Stop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Keylogger_Stop.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Keylogger_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Keylogger_Stop.ForeColor = System.Drawing.Color.Black
        Me.Keylogger_Stop.Location = New System.Drawing.Point(253, 4)
        Me.Keylogger_Stop.Name = "Keylogger_Stop"
        Me.Keylogger_Stop.Size = New System.Drawing.Size(75, 23)
        Me.Keylogger_Stop.TabIndex = 2
        Me.Keylogger_Stop.Text = "Stop"
        Me.Keylogger_Stop.UseVisualStyleBackColor = False
        '
        'BOXP
        '
        Me.BOXP.BackColor = System.Drawing.Color.Black
        Me.BOXP.Controls.Add(Me.Keylogger_Start)
        Me.BOXP.Controls.Add(Me.Keylogger_Stop)
        Me.BOXP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BOXP.Location = New System.Drawing.Point(0, 210)
        Me.BOXP.Name = "BOXP"
        Me.BOXP.Size = New System.Drawing.Size(414, 31)
        Me.BOXP.TabIndex = 3
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV0.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column3, Me.Column2})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV0.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV0.EnableHeadersVisualStyles = False
        Me.DGV0.GridColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DGV0.Location = New System.Drawing.Point(0, 0)
        Me.DGV0.Name = "DGV0"
        Me.DGV0.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV0.RowHeadersVisible = False
        Me.DGV0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV0.Size = New System.Drawing.Size(414, 210)
        Me.DGV0.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "State"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 58
        '
        'Column6
        '
        Me.Column6.HeaderText = "App"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 52
        '
        'Column3
        '
        Me.Column3.HeaderText = "Text"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 53
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.FillWeight = 1.0!
        Me.Column2.HeaderText = ""
        Me.Column2.MinimumWidth = 2
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Column2.Width = 2
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.ShowImageMargin = False
        Me.ctxMenu.Size = New System.Drawing.Size(156, 70)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.Visible = False
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        Me.SaveAsToolStripMenuItem.Visible = False
        '
        'Keylogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 241)
        Me.Controls.Add(Me.DGV0)
        Me.Controls.Add(Me.BOXP)
        Me.Name = "Keylogger"
        Me.Opacity = 0R
        Me.Text = "Keylogger"
        Me.BOXP.ResumeLayout(False)
        CType(Me.DGV0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Keylogger_Start As Button
    Friend WithEvents Keylogger_Stop As Button
    Friend WithEvents BOXP As Panel
    Friend WithEvents TOpacity As Timer
    Friend WithEvents DGV0 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
End Class
