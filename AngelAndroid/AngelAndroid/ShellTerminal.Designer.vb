<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShellTerminal
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
        Me.Caret = New System.Windows.Forms.Timer(Me.components)
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutText = New AngelAndroid_v2.RTB()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Caret
        '
        Me.Caret.Interval = 500
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'PB
        '
        Me.PB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PB.Location = New System.Drawing.Point(0, 231)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(414, 10)
        Me.PB.TabIndex = 6
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.ShowImageMargin = False
        Me.ctxMenu.Size = New System.Drawing.Size(78, 48)
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
        'OutText
        '
        Me.OutText.BackColor = System.Drawing.Color.Black
        Me.OutText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OutText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.OutText.Location = New System.Drawing.Point(0, 0)
        Me.OutText.Name = "OutText"
        Me.OutText.Size = New System.Drawing.Size(414, 231)
        Me.OutText.TabIndex = 2
        Me.OutText.Text = ""
        Me.OutText.WordWrap = False
        '
        'ShellTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 241)
        Me.Controls.Add(Me.OutText)
        Me.Controls.Add(Me.PB)
        Me.Name = "ShellTerminal"
        Me.Opacity = 0R
        Me.Text = "ShellTerminal"
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OutText As RTB
    Friend WithEvents Caret As Timer
    Friend WithEvents TOpacity As Timer
    Friend WithEvents PB As ProgressBar
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
End Class
