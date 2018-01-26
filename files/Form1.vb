Imports System.IO
Public Class GUI
    Const Quote As String = Chr(34)
    Dim ProcessInfo As New ProcessStartInfo
    Dim downCompiler As New Process()
    Dim urlText As String
    Dim dirBinYDL, dirBinFMPG, dirFolderDownload As String 'Marks the location of the ydl/fmpg files
    Protected username, password As String
    'These files are found by either inputting directly or selected with folder selector. Your choice :D
    'Use a input box or set a folder browser to this folder...
    Private Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkCustomFormatBox()
        checkPasswordBox()
        setDefaultValues()
    End Sub
    Private Sub setDefaultValues()
        ListOptions.SelectedItem = "Video and Audio"
        ListFormatVideo.SelectedItem = "720p"
        ListFormatAudio.SelectedItem = "128k"
        dirFolderDownload = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
        TextBrowseFolder.Text = dirFolderDownload
        RadioQualityAuto.Checked = True
    End Sub
    Private Sub buttonDownload_Click(sender As Object, e As EventArgs) Handles ButtonDownload.Click
        Select Case TextURL.Text = ""
            Case False
                If CheckRequiresLogin.Checked <> True Then
                    username = ""
                    password = ""
                    setDownload()
                ElseIf CheckRequiresLogin.Checked = True And TextUsername.Text <> "" And TextPassword.Text <> "" Then
                    username = " -u " & TextUsername.Text
                    password = " -p " & TextPassword.Text
                    setDownload()
                Else
                    TextOutputLog.Text = "Username/Password fields blank, please enter."
                End If
            Case Else
                TextOutputLog.Text = "URL empty, please enter URL."
        End Select
    End Sub
    Private Sub setDownload()
        TextOutputLog.AppendText("Download started" & vbNewLine)
        If CheckRequiresLogin.Checked = True And TextUsername.Text <> "" And TextPassword.Text <> "" Then
            TextOutputLog.AppendText("Using credentials of username " & TextUsername.Text & vbNewLine & vbNewLine)
        End If
        If checkStoredLocationFiles() = True Then
            setCompiler()
            checkDownloadType()
        End If
    End Sub
    Private Sub checkCustomFormat_CheckedChanged(sender As Object, e As EventArgs)
        checkCustomFormatBox()
    End Sub
    Private Sub buttonBrowseFolder_Click(sender As Object, e As EventArgs) Handles ButtonBrowseFolder.Click
        Dim downloadBrowser As New FolderBrowserDialog
        downloadBrowser.Description = "Select folder to download videos to."
        downloadBrowser.ShowDialog()
        dirFolderDownload = downloadBrowser.SelectedPath
        If (dirFolderDownload = "") Or (dirFolderDownload = " ") Then
            TextOutputLog.AppendText("Please enter valid directory!" & vbNewLine)
            dirFolderDownload = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
        Else
            TextOutputLog.AppendText("Download path selected to " & dirFolderDownload & vbNewLine)
        End If
        TextBrowseFolder.Text = dirFolderDownload
    End Sub
    Private Sub checkCustomFormatBox()
        Select Case RadioQualityCustom.Checked
            Case False
                ListFormatVideo.Enabled = False
                ListFormatAudio.Enabled = False
            Case True
                ListFormatVideo.Enabled = True
                ListFormatAudio.Enabled = True
        End Select
    End Sub
    Private Sub checkPasswordBox()
        Select Case CheckRequiresLogin.Checked
            Case False
                TextUsername.Clear()
                TextPassword.Clear()
                TextUsername.Enabled = False
                TextPassword.Enabled = False
            Case True
                TextUsername.Enabled = True
                TextPassword.Enabled = True
        End Select
    End Sub
    Private Sub checkRequiresLogin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRequiresLogin.CheckedChanged
        checkPasswordBox()
    End Sub
    Private Sub setCompiler()
        ProcessInfo.FileName = dirBinYDL
        ProcessInfo.UseShellExecute = False
        ProcessInfo.RedirectStandardOutput = True
        ProcessInfo.RedirectStandardError = True
        ProcessInfo.CreateNoWindow = True
    End Sub
    Private Function checkStoredLocationFiles()
        Select Case My.Computer.FileSystem.FileExists("settings/directory_YDL.txt")
            Case True
                dirBinYDL = My.Computer.FileSystem.ReadAllText("settings/directory_YDL.txt")
                Select Case My.Computer.FileSystem.FileExists(dirBinYDL)
                    Case True
                        Select Case My.Computer.FileSystem.FileExists("settings/directory_FMPG.txt")
                            Case True
                                dirBinFMPG = My.Computer.FileSystem.ReadAllText("settings/directory_FMPG.txt")
                                Select Case My.Computer.FileSystem.FileExists(dirBinFMPG & "\ffmpeg.exe")
                                    Case True
                                        Return True
                                    Case Else
                                        checkDirectoryFMPG()
                                        Return False
                                End Select
                            Case Else
                                checkDirectoryFMPG()
                                Return False
                        End Select
                    Case Else
                        checkDirectoryYDL()
                        Return False
                End Select
            Case Else
                checkDirectoryYDL()
                Return False
        End Select
    End Function
    Private Sub checkDirectoryYDL()
        TextOutputLog.AppendText("ERROR: YouTube-DL or FFMpeg not present in specified location" & vbNewLine & vbNewLine)
        Dim ydlBrowser As New FolderBrowserDialog
        ydlBrowser.Description = "Select folder with youtube-dl.exe and its related files."
        ydlBrowser.ShowDialog()
        dirBinYDL = ydlBrowser.SelectedPath & "\youtube-dl.exe"
        If (Not System.IO.Directory.Exists("settings")) Then
            System.IO.Directory.CreateDirectory("settings")
        End If
        Dim ydlWriter As New StreamWriter("settings/directory_YDL.txt")
        ydlWriter.Write(dirBinYDL)
        ydlWriter.Close()
    End Sub
    Private Sub checkDirectoryFMPG()
        TextOutputLog.AppendText("ERROR: YouTube-DL or FFMpeg not present in specified location" & vbNewLine & vbNewLine)
        Dim ffmpegBrowser As New FolderBrowserDialog
        ffmpegBrowser.Description = "Select folder with ffmpeg.exe and its related files."
        ffmpegBrowser.ShowDialog()
        dirBinFMPG = ffmpegBrowser.SelectedPath
        If (Not System.IO.Directory.Exists("settings")) Then
            System.IO.Directory.CreateDirectory("settings")
        End If
        Dim ffmpegWriter As New StreamWriter("settings/directory_FMPG.txt")
        ffmpegWriter.Write(dirBinFMPG)
        ffmpegWriter.Close()
    End Sub
    Private Sub checkDownloadType()
        Dim downloadTypeChoice As Integer
        Select Case ListOptions.SelectedItem
            Case "Video and Audio"
                downloadTypeChoice = 1
            Case "Video Only"
                downloadTypeChoice = 2
            Case "Audio Only"
                downloadTypeChoice = 3
        End Select
        checkDownloadFormat(downloadTypeChoice)
    End Sub
    Private Function checkQualityRadio()
        If RadioQualityAuto.Checked And Not RadioQualityBest.Checked And Not RadioQualityCustom.Checked Then
            Return "Auto"
        ElseIf RadioQualityBest.Checked And Not RadioQualityAuto.Checked And Not RadioQualityCustom.Checked Then
            Return "Best"
        Else
            Return "Custom"
        End If
    End Function
    Private Sub checkDownloadFormat(ByVal downloadTypeChoice As Integer)
        Dim qualityVideo, qualityAudio As String
        Dim qualityString
        Select Case checkQualityRadio()
            Case "Auto"
                qualityString = ""
                downloadTypeChoice = 1
            Case "Best"
                Select Case ListOptions.SelectedItem
                    Case "Video and Audio"
                        qualityString = "-f bestvideo+bestaudio "
                    Case "Video Only"
                        qualityString = "-f bestvideo "
                    Case "Audio Only"
                        qualityString = "-f bestaudio "
                End Select
            Case "Custom"
                chooseCustomQuality(qualityVideo, qualityAudio)
                Select Case ListOptions.SelectedItem
                    Case "Video and Audio"
                        qualityString = "-f " & Quote & qualityVideo & "+" & qualityAudio & Quote & " "
                    Case "Video Only"
                        qualityString = "-f " & Quote & qualityVideo & Quote & " "
                    Case "Audio Only"
                        qualityString = "-f " & Quote & qualityAudio & Quote & " "
                End Select
        End Select
        selectEachLineURL(downloadTypeChoice, qualityString)
    End Sub
    Private Sub chooseCustomQuality(ByRef qualityVideo As String, ByRef qualityAudio As String)
        Select Case ListFormatVideo.SelectedItem
            Case "1080p"
                qualityVideo = "137"
            Case "720p"
                qualityVideo = "136"
            Case "480p"
                qualityVideo = "135"
            Case "360p"
                qualityVideo = "134"
            Case "240p"
                qualityVideo = "133"
            Case "144p"
                qualityVideo = "160"
        End Select
        Select Case ListFormatAudio.SelectedItem
            Case "160k"
                qualityAudio = "251"
            Case "128k"
                qualityAudio = "140"
            Case "117k"
                qualityAudio = "171"
            Case "70k"
                qualityAudio = "250"
            Case "50k"
                qualityAudio = "249"
        End Select
    End Sub
    Private Sub selectEachLineURL(ByVal downloadTypeChoice As Integer, ByVal qualityString As String)
        For Each urlText In TextURL.Lines
            checkURL(downloadTypeChoice, qualityString)
        Next
    End Sub
    Private Sub checkURL(ByVal downloadTypeChoice As Integer, ByVal qualityString As String)
        Dim constArgument, playlistString As String '= "-ciw --no-part --ffmpeg-location " & Quote & dirBinFMPG & Quote & username & password & qualityString 'Constant for all downloaded options.
        'urlText = textURL.Text 'Remember quotations to allow ffmpeg
        dirFolderDownload = TextBrowseFolder.Text
        Select Case UCase(urlText).Contains("PLAYLIST")
            Case True
                playlistString = "--yes-playlist -o " & Quote & dirFolderDownload & "\%(playlist)s\%(title)s.%(ext)s" & Quote
            Case False
                playlistString = "--no-playlist -o " & Quote & dirFolderDownload & "\%(title)s.%(ext)s" & Quote
        End Select
        constArgument = "-ciw --embed-sub --convert-subtitles srt --all-subs --recode-video mp4 --no-part --prefer-ffmpeg " & username & password 'Constant for all downloaded options.
        Select Case downloadTypeChoice
            Case 1
                'ProcessInfo.Arguments = constArgument & " -f bestvideo+bestaudio --audio-format m4a -o downloaded/both/%(playlist)s/%(title)s.%(ext)s --merge-output-format mp4 " & urlText
                ProcessInfo.Arguments = constArgument & " --audio-format m4a --recode-video mp4 --convert-subs srt --embed-subs " & Quote & urlText & Quote
            Case 2
                ProcessInfo.Arguments = constArgument & " --convert-subs srt --recode-video mp4 --embed-subs " & Quote & urlText & Quote
            Case 3
                ProcessInfo.Arguments = constArgument & " --audio-format mp3 --embed-thumbnail -x " & Quote & urlText & Quote
        End Select
        'MsgBox(ProcessInfo.Arguments)
        TextOutputLog.AppendText(vbNewLine & "Argument: " & ProcessInfo.Arguments & vbNewLine)
        runDownloadUpdate()
    End Sub
    Private Sub buttonOpenFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenFolder.Click
        Process.Start("explorer.exe", TextBrowseFolder.Text)
    End Sub
    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextOutputLog.Clear()
    End Sub
    Private Sub isAutoQuality_CheckedChanged(sender As Object, e As EventArgs) Handles RadioQualityAuto.CheckedChanged
        ListOptions.Enabled = False
        checkCustomFormatBox()
    End Sub
    Private Sub isBestQuality_CheckedChanged(sender As Object, e As EventArgs) Handles RadioQualityBest.CheckedChanged
        ListOptions.Enabled = True
        checkCustomFormatBox()
    End Sub
    Private Sub isCustomQuality_CheckedChanged(sender As Object, e As EventArgs) Handles RadioQualityCustom.CheckedChanged
        ListOptions.Enabled = True
        checkCustomFormatBox()
    End Sub
    Private Sub runDownloadUpdate()
        downCompiler.StartInfo = ProcessInfo
        downCompiler.Start()
        Do
            TextOutputLog.AppendText(downCompiler.StandardOutput.ReadLine & vbNewLine)
        Loop Until downCompiler.HasExited = True
        TextOutputLog.AppendText(downCompiler.StandardError.ReadToEnd)
        TextOutputLog.AppendText(vbNewLine & "Download complete" & vbNewLine & "------------------" & vbNewLine)
    End Sub
    Private Sub buttonUpdateYDL_Click(sender As Object, e As EventArgs) Handles ButtonUpdateYDL.Click
        ProcessInfo.Arguments = "-U"
        checkStoredLocationFiles()
        setCompiler()
        runDownloadUpdate()
    End Sub
    Private Sub buttonSaveLog_Click(sender As Object, e As EventArgs) Handles ButtonSaveLog.Click
        If (Not System.IO.Directory.Exists("log")) Then
            System.IO.Directory.CreateDirectory("log")
        End If
        Dim logDirectory As String = "log/log" & DateTime.Now.ToString("yyMMdd") & "_" & DateTime.Now.ToString("HHmmss") & ".txt"
        Dim logWriter As New StreamWriter(logDirectory)
        logWriter.Write(TextOutputLog.Text)
        logWriter.Close()
        TextOutputLog.AppendText("Log saved" & vbNewLine & "------------------" & vbNewLine)
    End Sub
End Class