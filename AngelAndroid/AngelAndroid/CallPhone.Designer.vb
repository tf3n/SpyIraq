<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CallPhone
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_DEL = New System.Windows.Forms.Button()
        Me.B_hash = New System.Windows.Forms.Button()
        Me.b0 = New System.Windows.Forms.Button()
        Me.B_star = New System.Windows.Forms.Button()
        Me.b9 = New System.Windows.Forms.Button()
        Me.b8 = New System.Windows.Forms.Button()
        Me.b7 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.Button()
        Me.L0 = New System.Windows.Forms.Label()
        Me.CMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.CMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(0, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(232, 13)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(91, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Call"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.b_DEL)
        Me.Panel1.Controls.Add(Me.B_hash)
        Me.Panel1.Controls.Add(Me.b0)
        Me.Panel1.Controls.Add(Me.B_star)
        Me.Panel1.Controls.Add(Me.b9)
        Me.Panel1.Controls.Add(Me.b8)
        Me.Panel1.Controls.Add(Me.b7)
        Me.Panel1.Controls.Add(Me.b6)
        Me.Panel1.Controls.Add(Me.b5)
        Me.Panel1.Controls.Add(Me.b4)
        Me.Panel1.Controls.Add(Me.b3)
        Me.Panel1.Controls.Add(Me.b2)
        Me.Panel1.Controls.Add(Me.b1)
        Me.Panel1.Controls.Add(Me.L0)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 326)
        Me.Panel1.TabIndex = 2
        '
        'b_DEL
        '
        Me.b_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_DEL.Location = New System.Drawing.Point(37, 279)
        Me.b_DEL.Name = "b_DEL"
        Me.b_DEL.Size = New System.Drawing.Size(48, 35)
        Me.b_DEL.TabIndex = 15
        Me.b_DEL.Text = "<"
        Me.b_DEL.UseVisualStyleBackColor = True
        '
        'B_hash
        '
        Me.B_hash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_hash.Location = New System.Drawing.Point(145, 224)
        Me.B_hash.Name = "B_hash"
        Me.B_hash.Size = New System.Drawing.Size(48, 48)
        Me.B_hash.TabIndex = 14
        Me.B_hash.Text = "#"
        Me.B_hash.UseVisualStyleBackColor = True
        '
        'b0
        '
        Me.b0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b0.Location = New System.Drawing.Point(91, 224)
        Me.b0.Name = "b0"
        Me.b0.Size = New System.Drawing.Size(48, 48)
        Me.b0.TabIndex = 13
        Me.b0.Text = "0"
        Me.b0.UseVisualStyleBackColor = True
        '
        'B_star
        '
        Me.B_star.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_star.Location = New System.Drawing.Point(37, 224)
        Me.B_star.Name = "B_star"
        Me.B_star.Size = New System.Drawing.Size(48, 48)
        Me.B_star.TabIndex = 12
        Me.B_star.Text = "*"
        Me.B_star.UseVisualStyleBackColor = True
        '
        'b9
        '
        Me.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b9.Location = New System.Drawing.Point(145, 170)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(48, 48)
        Me.b9.TabIndex = 11
        Me.b9.Text = "9"
        Me.b9.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b8.Location = New System.Drawing.Point(91, 170)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(48, 48)
        Me.b8.TabIndex = 10
        Me.b8.Text = "8"
        Me.b8.UseVisualStyleBackColor = True
        '
        'b7
        '
        Me.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b7.Location = New System.Drawing.Point(37, 170)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(48, 48)
        Me.b7.TabIndex = 9
        Me.b7.Text = "7"
        Me.b7.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b6.Location = New System.Drawing.Point(145, 116)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(48, 48)
        Me.b6.TabIndex = 8
        Me.b6.Text = "6"
        Me.b6.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b5.Location = New System.Drawing.Point(91, 116)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(48, 48)
        Me.b5.TabIndex = 7
        Me.b5.Text = "5"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b4.Location = New System.Drawing.Point(37, 116)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(48, 48)
        Me.b4.TabIndex = 6
        Me.b4.Text = "4"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b3.Location = New System.Drawing.Point(145, 62)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(48, 48)
        Me.b3.TabIndex = 5
        Me.b3.Text = "3"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b2.Location = New System.Drawing.Point(91, 62)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(48, 48)
        Me.b2.TabIndex = 4
        Me.b2.Text = "2"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b1.Location = New System.Drawing.Point(37, 62)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(48, 48)
        Me.b1.TabIndex = 3
        Me.b1.Text = "1"
        Me.b1.UseVisualStyleBackColor = True
        '
        'L0
        '
        Me.L0.AutoSize = True
        Me.L0.Location = New System.Drawing.Point(3, 9)
        Me.L0.Name = "L0"
        Me.L0.Size = New System.Drawing.Size(23, 13)
        Me.L0.TabIndex = 2
        Me.L0.Text = "null"
        '
        'CMenu
        '
        Me.CMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.CMenu.Name = "CMenu"
        Me.CMenu.ShowImageMargin = False
        Me.CMenu.Size = New System.Drawing.Size(78, 70)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'CallPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 326)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CallPhone"
        Me.Opacity = 0R
        Me.Text = "Call Phone"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TOpacity As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents L0 As Label
    Friend WithEvents B_hash As Button
    Friend WithEvents b0 As Button
    Friend WithEvents B_star As Button
    Friend WithEvents b9 As Button
    Friend WithEvents b8 As Button
    Friend WithEvents b7 As Button
    Friend WithEvents b6 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents b_DEL As Button
    Friend WithEvents CMenu As ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
End Class
