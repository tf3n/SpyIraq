<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BXICO = New System.Windows.Forms.PictureBox()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.chtmr = New System.Windows.Forms.Timer(Me.components)
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.BXICO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(395, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BXICO
        '
        Me.BXICO.BackColor = System.Drawing.Color.Black
        Me.BXICO.Dock = System.Windows.Forms.DockStyle.Top
        Me.BXICO.Location = New System.Drawing.Point(0, 0)
        Me.BXICO.Name = "BXICO"
        Me.BXICO.Size = New System.Drawing.Size(395, 10)
        Me.BXICO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BXICO.TabIndex = 3
        Me.BXICO.TabStop = False
        '
        'tmr
        '
        Me.tmr.Interval = 1
        '
        'chtmr
        '
        Me.chtmr.Interval = 1
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(395, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(395, 301)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BXICO)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.BXICO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BXICO As PictureBox
    Friend WithEvents tmr As Timer
    Friend WithEvents chtmr As Timer
    Friend WithEvents TOpacity As Timer
    Friend WithEvents Label4 As Label
End Class
