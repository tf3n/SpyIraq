<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
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
        Me.EditText = New System.Windows.Forms.RichTextBox()
        Me.b_ok = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.CMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.CMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditText
        '
        Me.EditText.BackColor = System.Drawing.Color.Black
        Me.EditText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EditText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.EditText.Location = New System.Drawing.Point(0, 0)
        Me.EditText.Name = "EditText"
        Me.EditText.Size = New System.Drawing.Size(414, 213)
        Me.EditText.TabIndex = 1
        Me.EditText.Text = ""
        Me.EditText.WordWrap = False
        '
        'b_ok
        '
        Me.b_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_ok.ForeColor = System.Drawing.Color.Black
        Me.b_ok.Location = New System.Drawing.Point(343, 3)
        Me.b_ok.Name = "b_ok"
        Me.b_ok.Size = New System.Drawing.Size(67, 23)
        Me.b_ok.TabIndex = 2
        Me.b_ok.Text = "save"
        Me.b_ok.UseVisualStyleBackColor = False
        Me.b_ok.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.b_ok)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 213)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 28)
        Me.Panel1.TabIndex = 3
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'CMenu
        '
        Me.CMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.CMenu.Name = "CMenu"
        Me.CMenu.ShowImageMargin = False
        Me.CMenu.Size = New System.Drawing.Size(156, 92)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 241)
        Me.Controls.Add(Me.EditText)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Editor"
        Me.Opacity = 0R
        Me.Text = "Editor"
        Me.Panel1.ResumeLayout(False)
        Me.CMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EditText As RichTextBox
    Friend WithEvents b_ok As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TOpacity As Timer
    Friend WithEvents CMenu As ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
End Class
