<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Color_Box0
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
        Me.C_Box3 = New System.Windows.Forms.PictureBox()
        Me.C_Box2 = New System.Windows.Forms.PictureBox()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.C_Box0 = New System.Windows.Forms.PictureBox()
        Me.ti = New System.Windows.Forms.Timer(Me.components)
        Me.CK1 = New System.Windows.Forms.CheckBox()
        Me.BoxTitle = New System.Windows.Forms.PictureBox()
        CType(Me.C_Box3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Box2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C_Box0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C_Box3
        '
        Me.C_Box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_Box3.Location = New System.Drawing.Point(98, 117)
        Me.C_Box3.Name = "C_Box3"
        Me.C_Box3.Size = New System.Drawing.Size(50, 48)
        Me.C_Box3.TabIndex = 7
        Me.C_Box3.TabStop = False
        '
        'C_Box2
        '
        Me.C_Box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_Box2.Location = New System.Drawing.Point(3, 117)
        Me.C_Box2.Name = "C_Box2"
        Me.C_Box2.Size = New System.Drawing.Size(93, 19)
        Me.C_Box2.TabIndex = 6
        Me.C_Box2.TabStop = False
        '
        'BTN_OK
        '
        Me.BTN_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTN_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_OK.ForeColor = System.Drawing.Color.Black
        Me.BTN_OK.Location = New System.Drawing.Point(3, 142)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(93, 23)
        Me.BTN_OK.TabIndex = 5
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = False
        '
        'C_Box0
        '
        Me.C_Box0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C_Box0.Location = New System.Drawing.Point(3, 3)
        Me.C_Box0.Name = "C_Box0"
        Me.C_Box0.Size = New System.Drawing.Size(145, 86)
        Me.C_Box0.TabIndex = 4
        Me.C_Box0.TabStop = False
        '
        'ti
        '
        '
        'CK1
        '
        Me.CK1.AutoSize = True
        Me.CK1.Location = New System.Drawing.Point(3, 94)
        Me.CK1.Name = "CK1"
        Me.CK1.Size = New System.Drawing.Size(93, 17)
        Me.CK1.TabIndex = 8
        Me.CK1.Tag = ""
        Me.CK1.Text = "Color Dropper"
        Me.CK1.UseVisualStyleBackColor = True
        '
        'BoxTitle
        '
        Me.BoxTitle.BackColor = System.Drawing.Color.Black
        Me.BoxTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BoxTitle.ErrorImage = Nothing
        Me.BoxTitle.InitialImage = Nothing
        Me.BoxTitle.Location = New System.Drawing.Point(0, 169)
        Me.BoxTitle.Name = "BoxTitle"
        Me.BoxTitle.Size = New System.Drawing.Size(151, 18)
        Me.BoxTitle.TabIndex = 9
        Me.BoxTitle.TabStop = False
        '
        'Color_Box0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(151, 187)
        Me.Controls.Add(Me.BoxTitle)
        Me.Controls.Add(Me.CK1)
        Me.Controls.Add(Me.C_Box3)
        Me.Controls.Add(Me.C_Box2)
        Me.Controls.Add(Me.BTN_OK)
        Me.Controls.Add(Me.C_Box0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Color_Box0"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Box"
        CType(Me.C_Box3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Box2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C_Box0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C_Box3 As PictureBox
    Friend WithEvents C_Box2 As PictureBox
    Friend WithEvents BTN_OK As Button
    Friend WithEvents C_Box0 As PictureBox
    Friend WithEvents ti As Timer
    Friend WithEvents CK1 As CheckBox
    Friend WithEvents BoxTitle As PictureBox
End Class
