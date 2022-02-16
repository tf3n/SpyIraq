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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Build))
        Me.PG = New System.Windows.Forms.ProgressBar()
        Me.t = New System.Windows.Forms.Timer(Me.components)
        Me.Ti1 = New System.Windows.Forms.Timer(Me.components)
        Me.Ti2 = New System.Windows.Forms.Timer(Me.components)
        Me.virusBox = New System.Windows.Forms.PictureBox()
        CType(Me.virusBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PG
        '
        Me.PG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PG.Location = New System.Drawing.Point(0, 551)
        Me.PG.Name = "PG"
        Me.PG.Size = New System.Drawing.Size(409, 10)
        Me.PG.TabIndex = 2
        '
        't
        '
        '
        'Ti1
        '
        '
        'Ti2
        '
        Me.Ti2.Interval = 1000
        '
        'virusBox
        '
        Me.virusBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.virusBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.virusBox.Location = New System.Drawing.Point(0, 0)
        Me.virusBox.Name = "virusBox"
        Me.virusBox.Size = New System.Drawing.Size(409, 561)
        Me.virusBox.TabIndex = 3
        Me.virusBox.TabStop = False
        '
        'Build
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(409, 561)
        Me.Controls.Add(Me.PG)
        Me.Controls.Add(Me.virusBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "Build"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Build"
        CType(Me.virusBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PG As ProgressBar
    Friend WithEvents t As Timer
    Friend WithEvents Ti1 As Timer
    Friend WithEvents Ti2 As Timer
    Friend WithEvents virusBox As PictureBox
End Class
