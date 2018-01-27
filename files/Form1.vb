Imports System.IO
Imports System.ComponentModel
Public Class GUI
    Const Quote As String = Chr(34)
    Dim ProcessInfo As New ProcessStartInfo
    'Dim BackgroundRun As New BackgroundWorker
    Dim downCompiler As New Process()
    Dim urlText As String
    Dim dirBinYDL, dirBinFMPG, dirFolderDownload As String 'Marks the location of the ydl/fmpg files
    Protected username, password As String
    Dim useFFMpeg As Boolean
    'These files are found by either inputting directly or selected with folder selector. Your choice :D
    'Use a input box or set a folder browser to this folder...
    Private Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkCustomFormatBox()
        checkPasswordBox()
        setDefaultValues()
        checkUseFMP.Checked = True
        If (Not System.IO.Directory.Exists("settings")) Then
            System.IO.Directory.CreateDirectory("settings")
        End If
    End Sub
    Private Sub setDefaultValues()
        listOptions.SelectedItem = "Video and Audio"
        listFormatVideo.SelectedItem = "720p"
        listFormatAudio.SelectedItem = "128k"
        dirFolderDownload = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
        textBrowseFolder.Text = dirFolderDownload
    End Sub
    Private Sub buttonDownload_Click(sender As Object, e As EventArgs) Handles buttonDownload.Click
        Select Case TextURL.Text
            Case ""
                textOutputLog.Text = "URL empty, please enter URL."
            Case Else
                Select Case CheckRequiresLogin.Checked
                    Case False
                        username = ""
                        password = ""
                        setDownload()
                    'BackgroundRun.RunWorkerAsync()
                    Case True
                        If textUsername.Text <> "" And textPassword.Text <> "" Then
                            username = " -u " & textUsername.Text
                            password = " -p " & textPassword.Text
                            'BackgroundRun.RunWorkerAsync()
                            setDownload()
                        Else
                            textOutputLog.Text = "Username/Password fields blank, please enter."
                        End If
                End Select
        End Select
    End Sub
    Private Sub setDownload()
        textOutputLog.AppendText("Download started" & vbNewLine)
        textOutputLog.AppendText("Download location set to " & dirFolderDownload & vbNewLine)
        If CheckRequiresLogin.Checked = True And textUsername.Text <> "" And textPassword.Text <> "" Then
            textOutputLog.AppendText("Using credentials of username " & textUsername.Text & vbNewLine & vbNewLine)
        End If
        If checkUseFMP.Checked = True Then
            useFFMpeg = True
        Else
            useFFMpeg = False
        End If
        If checkStoredLocationFiles() = False Then
            textOutputLog.AppendText("ERROR: YouTube-DL/FFMpeg not present in specified location" & vbNewLine & "------------------" & vbNewLine)
        Else
            setCompiler()
            checkDownloadType()
        End If
    End Sub
    Private Sub checkCustomFormat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckFormatCustom.CheckedChanged
        checkCustomFormatBox()
    End Sub
    Private Sub buttonBrowseFolder_Click(sender As Object, e As EventArgs) Handles buttonBrowseFolder.Click
        Dim downloadBrowser As New FolderBrowserDialog
        downloadBrowser.Description = "Select folder to download videos to."
        downloadBrowser.ShowDialog()
        dirFolderDownload = downloadBrowser.SelectedPath
        If (dirFolderDownload = "") Or (dirFolderDownload = " ") Then
            textOutputLog.AppendText("Please enter valid directory!" & vbNewLine)
            dirFolderDownload = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
        Else
            textOutputLog.AppendText("Download path selected to " & dirFolderDownload & vbNewLine & "------------------" & vbNewLine)
        End If
        textBrowseFolder.Text = dirFolderDownload
    End Sub
    Private Sub checkCustomFormatBox()
        Select Case CheckFormatCustom.Checked
            Case False
                listFormatVideo.Enabled = False
                listFormatAudio.Enabled = False
            Case True
                listFormatVideo.Enabled = True
                listFormatAudio.Enabled = True
        End Select
    End Sub
    Private Sub checkPasswordBox()
        Select Case CheckRequiresLogin.Checked
            Case False
                textUsername.Clear()
                textPassword.Clear()
                textUsername.Enabled = False
                textPassword.Enabled = False
            Case True
                textUsername.Enabled = True
                textPassword.Enabled = True
        End Select
    End Sub
    Private Sub checkRequiresLogin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckRequiresLogin.CheckedChanged
        checkPasswordBox()
    End Sub

#Region "Form-Unrelated"
    Private Sub setCompiler()
        ProcessInfo.FileName = dirBinYDL
        ProcessInfo.UseShellExecute = False
        ProcessInfo.RedirectStandardOutput = True
        ProcessInfo.RedirectStandardError = True
        ProcessInfo.CreateNoWindow = True
    End Sub
    Private Function checkStoredLocationFiles()
        If My.Computer.FileSystem.FileExists("settings/directory_YDL.txt") <> True Then
            checkDirectoryYDL()
            Return False
        Else
            dirBinYDL = My.Computer.FileSystem.ReadAllText("settings/directory_YDL.txt")
            If My.Computer.FileSystem.FileExists(dirBinYDL) <> True Then
                checkDirectoryYDL()
                Return False
            Else
                If useFFMpeg = False Then
                    Return True
                Else
                    If My.Computer.FileSystem.FileExists("settings/directory_FMPG.txt") <> True Then
                        checkDirectoryFMPG()
                        Return False
                    Else
                        dirBinFMPG = My.Computer.FileSystem.ReadAllText("settings/directory_FMPG.txt")
                        If My.Computer.FileSystem.FileExists(dirBinFMPG & "\ffmpeg.exe") <> True Then
                            checkDirectoryFMPG()
                            Return False
                        Else
                            Return True
                        End If
                    End If
                End If
            End If
        End If
    End Function
    Private Sub checkDirectoryYDL()
        Dim ydlBrowser As New FolderBrowserDialog
        ydlBrowser.Description = "Select folder with youtube-dl.exe and its related files."
        ydlBrowser.ShowDialog()
        dirBinYDL = ydlBrowser.SelectedPath & "\youtube-dl.exe"
        Dim ydlWriter As New StreamWriter("settings/directory_YDL.txt")
        ydlWriter.Write(dirBinYDL)
        ydlWriter.Close()
        'checkStoredLocationFiles()
    End Sub
    Private Sub checkDirectoryFMPG()
        Dim ffmpegBrowser As New FolderBrowserDialog
        ffmpegBrowser.Description = "Select folder with ffmpeg.exe and its related files."
        ffmpegBrowser.ShowDialog()
        dirBinFMPG = ffmpegBrowser.SelectedPath
        Dim ffmpegWriter As New StreamWriter("settings/directory_FMPG.txt")
        ffmpegWriter.Write(dirBinFMPG)
        ffmpegWriter.Close()
        'checkStoredLocationFiles()
    End Sub
#End Region
#Region "Download"
    Private Sub checkDownloadType()
        Dim downloadTypeChoice As Integer
        Select Case listOptions.SelectedItem
            Case "Video and Audio"
                downloadTypeChoice = 1
            Case "Video Only"
                downloadTypeChoice = 2
            Case "Audio Only"
                downloadTypeChoice = 3
        End Select
        checkDownloadFormat(downloadTypeChoice)
    End Sub
    Private Sub checkDownloadFormat(ByVal downloadTypeChoice As Integer)
        Dim qualityVideo, qualityAudio As String
        If CheckFormatCustom.Checked <> True Then
            qualityVideo = "bestvideo[ext=mp4]"
            qualityAudio = "bestaudio"
        ElseIf CheckFormatCustom.Checked = True Then
            Select Case listFormatVideo.SelectedItem
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
            Select Case listFormatAudio.SelectedItem
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
        End If
        selectEachLineURL(downloadTypeChoice, qualityVideo, qualityAudio)
    End Sub
    Private Sub selectEachLineURL(ByVal downloadTypeChoice As Integer, ByVal qualityVideo As String, ByVal qualityAudio As String)
        For Each urlText In TextURL.Lines
            textOutputLog.AppendText(vbNewLine & "Downloading URL " & urlText & vbNewLine)
            checkURL(downloadTypeChoice, qualityVideo, qualityAudio)
        Next
        textOutputLog.AppendText(vbNewLine & "Download complete" & vbNewLine & "------------------" & vbNewLine)
    End Sub

    Private Sub checkURL(ByVal downloadTypeChoice As Integer, ByVal qualityVideo As String, ByVal qualityAudio As String)
        Dim constArgument As String = "-ciw --embed-sub --convert-subtitles srt --all-subs --recode-video mp4 --no-part --prefer-ffmpeg " & username & password 'Constant for all downloaded options.
        Dim qualityString, isPlaylistString, directoryDownloadString As String
        If useFFMpeg = True Then
            constArgument = constArgument & " --ffmpeg-location " & Quote & dirBinFMPG & Quote
        End If
        Select Case UCase(urlText).Contains("PLAYLIST")
            Case True
                isPlaylistString = " --yes-playlist"
                directoryDownloadString = " -o " & Quote & dirFolderDownload & "\%(playlist)s\%(title)s.%(ext)s" & Quote
            Case False
                isPlaylistString = " --no-playlist"
                directoryDownloadString = " -o " & Quote & dirFolderDownload & "\%(title)s.%(ext)s" & Quote
        End Select

        Select Case downloadTypeChoice
            Case 1
                qualityString = " -f " & qualityVideo & "+" & qualityAudio & " -vcodec libx264 --audio-format m4a "
            Case 2
                qualityString = " -f " & qualityVideo & " -vcodec libx264 "
            Case 3
                qualityString = " -f " & qualityAudio & " --embed-thumbnail --audio-format mp3 -x "
        End Select
        dirFolderDownload = textBrowseFolder.Text
        ProcessInfo.Arguments = constArgument & qualityString & isPlaylistString & directoryDownloadString & " " & urlText
        MsgBox(ProcessInfo.Arguments)
        runDownloadUpdate()
    End Sub
    Private Sub buttonOpenFolder_Click(sender As Object, e As EventArgs) Handles buttonOpenFolder.Click
        Process.Start("explorer.exe", textBrowseFolder.Text)
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        textOutputLog.Clear()
    End Sub

    Private Sub runDownloadUpdate() ' Handles BackgroundWorker1.DoWork 'ByRef downCompiler As Object)
        'textOutput.Text = "Download started" & vbNewLine & vbNewLine
        downCompiler.StartInfo = ProcessInfo
        downCompiler.Start()
        'BackgroundRun.ReportProgress(10)
        Do
            'Dim outputStream As String
            'textOutput.AppendText(downCompiler.StandardOutput.ReadLine & vbNewLine)
            textOutputLog.AppendText(downCompiler.StandardOutput.ReadLine & vbNewLine)
        Loop Until downCompiler.HasExited = True
        textOutputLog.AppendText(downCompiler.StandardError.ReadToEnd)
    End Sub

    Private Sub buttonUpdateYDL_Click(sender As Object, e As EventArgs) Handles buttonUpdateYDL.Click
        ProcessInfo.Arguments = "-U"
        checkStoredLocationFiles()
        setCompiler()
        runDownloadUpdate()
    End Sub
    Private Sub buttonSaveLog_Click(sender As Object, e As EventArgs) Handles buttonSaveLog.Click
        If (Not System.IO.Directory.Exists("log")) Then
            System.IO.Directory.CreateDirectory("log")
        End If
        Dim logDirectory As String = "log/log" & DateTime.Now.ToString("yyMMdd") & "_" & DateTime.Now.ToString("HHmmss") & ".txt"
        Dim logWriter As New StreamWriter(logDirectory)
        logWriter.Write(textOutputLog.Text)
        logWriter.Close()
        textOutputLog.AppendText("Log saved" & vbNewLine & "------------------" & vbNewLine)
    End Sub
#End Region
End Class