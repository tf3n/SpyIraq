<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageViewer
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
        Me.Viewer = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TP = New System.Windows.Forms.Timer(Me.components)
        Me.info = New System.Windows.Forms.Panel()
        Me.LTime = New System.Windows.Forms.Label()
        Me.rest = New System.Windows.Forms.Timer(Me.components)
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.info.SuspendLayout()
        Me.SuspendLayout()
        '
        'Viewer
        '
        Me.Viewer.BackColor = System.Drawing.Color.Black
        Me.Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewer.Location = New System.Drawing.Point(0, 0)
        Me.Viewer.Name = "Viewer"
        Me.Viewer.Size = New System.Drawing.Size(240, 178)
        Me.Viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Viewer.TabIndex = 2
        Me.Viewer.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 207)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(240, 10)
        Me.ProgressBar1.TabIndex = 3
        '
        'TP
        '
        Me.TP.Interval = 5
        '
        'info
        '
        Me.info.Controls.Add(Me.LTime)
        Me.info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.info.Location = New System.Drawing.Point(0, 178)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(240, 29)
        Me.info.TabIndex = 4
        '
        'LTime
        '
        Me.LTime.AutoSize = True
        Me.LTime.Location = New System.Drawing.Point(13, 7)
        Me.LTime.Name = "LTime"
        Me.LTime.Size = New System.Drawing.Size(93, 13)
        Me.LTime.TabIndex = 0
        Me.LTime.Text = "00:00:00/4:00:00"
        '
        'rest
        '
        Me.rest.Interval = 1000
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'ImageViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(240, 217)
        Me.Controls.Add(Me.Viewer)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "ImageViewer"
        Me.Opacity = 0R
        Me.Text = "ImageViewer"
        CType(Me.Viewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.info.ResumeLayout(False)
        Me.info.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Viewer As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TP As Timer
    Friend WithEvents info As Panel
    Friend WithEvents LTime As Label
    Friend WithEvents rest As Timer
    Friend WithEvents TOpacity As Timer
End Class
