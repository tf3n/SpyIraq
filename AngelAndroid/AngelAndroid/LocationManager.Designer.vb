<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LocationManager
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
        Me.Map = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenUsingGoogleMapsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenUsingMapBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Map, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Map
        '
        Me.Map.BackColor = System.Drawing.Color.Black
        Me.Map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Map.Location = New System.Drawing.Point(0, 0)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(464, 311)
        Me.Map.TabIndex = 0
        Me.Map.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 311)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(464, 10)
        Me.ProgressBar1.TabIndex = 1
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.OpenUsingGoogleMapsToolStripMenuItem, Me.OpenUsingMapBoxToolStripMenuItem})
        Me.ctxMenu.Name = "ctxMenu"
        Me.ctxMenu.ShowImageMargin = False
        Me.ctxMenu.Size = New System.Drawing.Size(184, 114)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.Visible = False
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        Me.SaveAsToolStripMenuItem.Visible = False
        '
        'OpenUsingGoogleMapsToolStripMenuItem
        '
        Me.OpenUsingGoogleMapsToolStripMenuItem.Name = "OpenUsingGoogleMapsToolStripMenuItem"
        Me.OpenUsingGoogleMapsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OpenUsingGoogleMapsToolStripMenuItem.Text = "Open using Google Maps"
        '
        'OpenUsingMapBoxToolStripMenuItem
        '
        Me.OpenUsingMapBoxToolStripMenuItem.Name = "OpenUsingMapBoxToolStripMenuItem"
        Me.OpenUsingMapBoxToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OpenUsingMapBoxToolStripMenuItem.Text = "Open using Mapbox"
        '
        'LocationManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 321)
        Me.Controls.Add(Me.Map)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 360)
        Me.Name = "LocationManager"
        Me.Opacity = 0R
        Me.Text = "LocationManager"
        CType(Me.Map, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Map As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TOpacity As Timer
    Friend WithEvents ctxMenu As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenUsingGoogleMapsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenUsingMapBoxToolStripMenuItem As ToolStripMenuItem
End Class
