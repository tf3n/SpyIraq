<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Microphone
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
        Me.bIN = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OutHZ = New System.Windows.Forms.ComboBox()
        Me.OutBoxSource = New System.Windows.Forms.ComboBox()
        Me.b_sta = New System.Windows.Forms.Button()
        Me.T0 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeviceSOurVictim = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inHZ = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InBoxSource = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.LAB_ERR = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bIN
        '
        Me.bIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.bIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bIN.ForeColor = System.Drawing.Color.Black
        Me.bIN.Location = New System.Drawing.Point(296, 156)
        Me.bIN.Name = "bIN"
        Me.bIN.Size = New System.Drawing.Size(67, 23)
        Me.bIN.TabIndex = 1
        Me.bIN.Tag = "0"
        Me.bIN.Text = "Run"
        Me.bIN.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.OutHZ)
        Me.Panel1.Controls.Add(Me.OutBoxSource)
        Me.Panel1.Controls.Add(Me.b_sta)
        Me.Panel1.Controls.Add(Me.T0)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(374, 147)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "sound source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "sample rate"
        '
        'OutHZ
        '
        Me.OutHZ.BackColor = System.Drawing.Color.Black
        Me.OutHZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutHZ.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OutHZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.OutHZ.FormattingEnabled = True
        Me.OutHZ.Items.AddRange(New Object() {"8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)"})
        Me.OutHZ.Location = New System.Drawing.Point(8, 85)
        Me.OutHZ.Name = "OutHZ"
        Me.OutHZ.Size = New System.Drawing.Size(357, 21)
        Me.OutHZ.TabIndex = 17
        '
        'OutBoxSource
        '
        Me.OutBoxSource.BackColor = System.Drawing.Color.Black
        Me.OutBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutBoxSource.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OutBoxSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.OutBoxSource.FormattingEnabled = True
        Me.OutBoxSource.Items.AddRange(New Object() {"DEFAULT", "MIC", "RECOGNITION", "COMMUNICATION", "CAMCORDER"})
        Me.OutBoxSource.Location = New System.Drawing.Point(8, 43)
        Me.OutBoxSource.Name = "OutBoxSource"
        Me.OutBoxSource.Size = New System.Drawing.Size(357, 21)
        Me.OutBoxSource.TabIndex = 15
        '
        'b_sta
        '
        Me.b_sta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_sta.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.b_sta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_sta.ForeColor = System.Drawing.Color.Black
        Me.b_sta.Location = New System.Drawing.Point(296, 112)
        Me.b_sta.Name = "b_sta"
        Me.b_sta.Size = New System.Drawing.Size(67, 23)
        Me.b_sta.TabIndex = 14
        Me.b_sta.Tag = "2"
        Me.b_sta.Text = "Stop"
        Me.b_sta.UseVisualStyleBackColor = False
        '
        'T0
        '
        Me.T0.Dock = System.Windows.Forms.DockStyle.Top
        Me.T0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.T0.Location = New System.Drawing.Point(0, 0)
        Me.T0.Name = "T0"
        Me.T0.Size = New System.Drawing.Size(374, 25)
        Me.T0.TabIndex = 13
        Me.T0.Text = "[--- output---]"
        Me.T0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.DeviceSOurVictim)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.inHZ)
        Me.Panel2.Controls.Add(Me.bIN)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.InBoxSource)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 189)
        Me.Panel2.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(5, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "device source (victim)"
        '
        'DeviceSOurVictim
        '
        Me.DeviceSOurVictim.BackColor = System.Drawing.Color.Black
        Me.DeviceSOurVictim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeviceSOurVictim.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeviceSOurVictim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.DeviceSOurVictim.FormattingEnabled = True
        Me.DeviceSOurVictim.Items.AddRange(New Object() {"CALL", "MUSIC"})
        Me.DeviceSOurVictim.Location = New System.Drawing.Point(8, 86)
        Me.DeviceSOurVictim.Name = "DeviceSOurVictim"
        Me.DeviceSOurVictim.Size = New System.Drawing.Size(357, 21)
        Me.DeviceSOurVictim.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "sample rate"
        '
        'inHZ
        '
        Me.inHZ.BackColor = System.Drawing.Color.Black
        Me.inHZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inHZ.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.inHZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.inHZ.FormattingEnabled = True
        Me.inHZ.Items.AddRange(New Object() {"8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)"})
        Me.inHZ.Location = New System.Drawing.Point(8, 129)
        Me.inHZ.Name = "inHZ"
        Me.inHZ.Size = New System.Drawing.Size(357, 21)
        Me.inHZ.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "device source"
        '
        'InBoxSource
        '
        Me.InBoxSource.BackColor = System.Drawing.Color.Black
        Me.InBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InBoxSource.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.InBoxSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.InBoxSource.FormattingEnabled = True
        Me.InBoxSource.Location = New System.Drawing.Point(8, 43)
        Me.InBoxSource.Name = "InBoxSource"
        Me.InBoxSource.Size = New System.Drawing.Size(357, 21)
        Me.InBoxSource.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(374, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "[--- input---]"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'LAB_ERR
        '
        Me.LAB_ERR.AutoSize = True
        Me.LAB_ERR.Dock = System.Windows.Forms.DockStyle.Top
        Me.LAB_ERR.Location = New System.Drawing.Point(0, 336)
        Me.LAB_ERR.Name = "LAB_ERR"
        Me.LAB_ERR.Size = New System.Drawing.Size(19, 13)
        Me.LAB_ERR.TabIndex = 25
        Me.LAB_ERR.Text = "..."
        Me.LAB_ERR.Visible = False
        '
        'Microphone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(374, 361)
        Me.Controls.Add(Me.LAB_ERR)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Microphone"
        Me.Opacity = 0R
        Me.Text = "Microphone"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bIN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents T0 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OutHZ As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OutBoxSource As ComboBox
    Friend WithEvents b_sta As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DeviceSOurVictim As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents inHZ As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents InBoxSource As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TOpacity As Timer
    Friend WithEvents LAB_ERR As Label
End Class
