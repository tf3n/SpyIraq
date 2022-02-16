<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CameraManager
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
        Me.CAM0 = New System.Windows.Forms.PictureBox()
        Me.TP = New System.Windows.Forms.Timer(Me.components)
        Me.Frames = New System.Windows.Forms.Timer(Me.components)
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New AngelAndroid_v2.PBar()
        CType(Me.CAM0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CAM0
        '
        Me.CAM0.BackColor = System.Drawing.Color.Black
        Me.CAM0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CAM0.Location = New System.Drawing.Point(10, 0)
        Me.CAM0.Name = "CAM0"
        Me.CAM0.Size = New System.Drawing.Size(404, 241)
        Me.CAM0.TabIndex = 0
        Me.CAM0.TabStop = False
        '
        'TP
        '
        Me.TP.Interval = 5
        '
        'Frames
        '
        Me.Frames.Interval = 1000
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(10, 241)
        Me.ProgressBar1.TabIndex = 2
        '
        'CameraManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 241)
        Me.Controls.Add(Me.CAM0)
        Me.Controls.Add(Me.ProgressBar1)
        Me.MaximizeBox = False
        Me.Name = "CameraManager"
        Me.Opacity = 0R
        Me.Text = "CameraManager"
        CType(Me.CAM0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CAM0 As PictureBox
    Friend WithEvents TP As Timer
    Friend WithEvents Frames As Timer
    Friend WithEvents TOpacity As Timer
    Friend WithEvents ProgressBar1 As PBar
End Class
