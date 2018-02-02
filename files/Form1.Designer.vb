<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
        Me.TextURL = New System.Windows.Forms.TextBox()
        Me.buttonDownload = New System.Windows.Forms.Button()
        Me.CheckFormatCustom = New System.Windows.Forms.CheckBox()
        Me.TextOutputLog = New System.Windows.Forms.TextBox()
        Me.listOptions = New System.Windows.Forms.ComboBox()
        Me.GroupQuality = New System.Windows.Forms.GroupBox()
        Me.LabelQualityAudio = New System.Windows.Forms.Label()
        Me.LabelQualityVideo = New System.Windows.Forms.Label()
        Me.listFormatAudio = New System.Windows.Forms.ComboBox()
        Me.listFormatVideo = New System.Windows.Forms.ComboBox()
        Me.LabelTypeDownload = New System.Windows.Forms.Label()
        Me.LabelURL = New System.Windows.Forms.Label()
        Me.LabelDownload = New System.Windows.Forms.Label()
        Me.TextBrowseFolder = New System.Windows.Forms.TextBox()
        Me.buttonBrowseFolder = New System.Windows.Forms.Button()
        Me.buttonUpdateYDL = New System.Windows.Forms.Button()
        Me.GroupLogOutput = New System.Windows.Forms.GroupBox()
        Me.buttonSaveLog = New System.Windows.Forms.Button()
        Me.GroupDownload = New System.Windows.Forms.GroupBox()
        Me.buttonOpenFolder = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.textPassword = New System.Windows.Forms.TextBox()
        Me.textUsername = New System.Windows.Forms.TextBox()
        Me.LabelCredentialPassword = New System.Windows.Forms.Label()
        Me.LabelCredentialUsername = New System.Windows.Forms.Label()
        Me.CheckRequiresLogin = New System.Windows.Forms.CheckBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.GroupCredential = New System.Windows.Forms.GroupBox()
        Me.checkUseFMP = New System.Windows.Forms.CheckBox()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TextOutputCurrent = New System.Windows.Forms.TextBox()
        Me.GroupQuality.SuspendLayout()
        Me.GroupLogOutput.SuspendLayout()
        Me.GroupDownload.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupCredential.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextURL
        '
        Me.TextURL.ForeColor = System.Drawing.Color.DarkRed
        Me.TextURL.Location = New System.Drawing.Point(11, 98)
        Me.TextURL.Margin = New System.Windows.Forms.Padding(4)
        Me.TextURL.Multiline = True
        Me.TextURL.Name = "TextURL"
        Me.TextURL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextURL.Size = New System.Drawing.Size(351, 176)
        Me.TextURL.TabIndex = 1
        Me.TextURL.WordWrap = False
        '
        'buttonDownload
        '
        Me.buttonDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDownload.ForeColor = System.Drawing.Color.DarkRed
        Me.buttonDownload.Location = New System.Drawing.Point(370, 543)
        Me.buttonDownload.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonDownload.Name = "buttonDownload"
        Me.buttonDownload.Size = New System.Drawing.Size(407, 30)
        Me.buttonDownload.TabIndex = 3
        Me.buttonDownload.Text = "Download"
        Me.buttonDownload.UseVisualStyleBackColor = True
        '
        'CheckFormatCustom
        '
        Me.CheckFormatCustom.AutoSize = True
        Me.CheckFormatCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckFormatCustom.ForeColor = System.Drawing.Color.White
        Me.CheckFormatCustom.Location = New System.Drawing.Point(11, 20)
        Me.CheckFormatCustom.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckFormatCustom.Name = "CheckFormatCustom"
        Me.CheckFormatCustom.Size = New System.Drawing.Size(281, 24)
        Me.CheckFormatCustom.TabIndex = 6
        Me.CheckFormatCustom.Text = "Use custom quality; select below."
        Me.CheckFormatCustom.UseVisualStyleBackColor = True
        '
        'TextOutputLog
        '
        Me.TextOutputLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextOutputLog.ForeColor = System.Drawing.Color.DarkRed
        Me.TextOutputLog.Location = New System.Drawing.Point(7, 59)
        Me.TextOutputLog.Margin = New System.Windows.Forms.Padding(4)
        Me.TextOutputLog.Multiline = True
        Me.TextOutputLog.Name = "TextOutputLog"
        Me.TextOutputLog.ReadOnly = True
        Me.TextOutputLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextOutputLog.Size = New System.Drawing.Size(636, 271)
        Me.TextOutputLog.TabIndex = 7
        Me.TextOutputLog.WordWrap = False
        '
        'listOptions
        '
        Me.listOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listOptions.ForeColor = System.Drawing.Color.DarkRed
        Me.listOptions.FormattingEnabled = True
        Me.listOptions.Items.AddRange(New Object() {"Video and Audio", "Video Only", "Audio Only"})
        Me.listOptions.Location = New System.Drawing.Point(160, 286)
        Me.listOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.listOptions.Name = "listOptions"
        Me.listOptions.Size = New System.Drawing.Size(201, 24)
        Me.listOptions.TabIndex = 8
        '
        'GroupQuality
        '
        Me.GroupQuality.Controls.Add(Me.LabelQualityAudio)
        Me.GroupQuality.Controls.Add(Me.LabelQualityVideo)
        Me.GroupQuality.Controls.Add(Me.listFormatAudio)
        Me.GroupQuality.Controls.Add(Me.listFormatVideo)
        Me.GroupQuality.Controls.Add(Me.CheckFormatCustom)
        Me.GroupQuality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupQuality.ForeColor = System.Drawing.Color.White
        Me.GroupQuality.Location = New System.Drawing.Point(11, 315)
        Me.GroupQuality.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupQuality.Name = "GroupQuality"
        Me.GroupQuality.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupQuality.Size = New System.Drawing.Size(352, 128)
        Me.GroupQuality.TabIndex = 9
        Me.GroupQuality.TabStop = False
        Me.GroupQuality.Text = "Video/Audio Quality"
        '
        'LabelQualityAudio
        '
        Me.LabelQualityAudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQualityAudio.ForeColor = System.Drawing.Color.White
        Me.LabelQualityAudio.Location = New System.Drawing.Point(11, 89)
        Me.LabelQualityAudio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelQualityAudio.Name = "LabelQualityAudio"
        Me.LabelQualityAudio.Size = New System.Drawing.Size(117, 30)
        Me.LabelQualityAudio.TabIndex = 13
        Me.LabelQualityAudio.Text = "Audio Quality"
        Me.LabelQualityAudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelQualityVideo
        '
        Me.LabelQualityVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQualityVideo.ForeColor = System.Drawing.Color.White
        Me.LabelQualityVideo.Location = New System.Drawing.Point(11, 49)
        Me.LabelQualityVideo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelQualityVideo.Name = "LabelQualityVideo"
        Me.LabelQualityVideo.Size = New System.Drawing.Size(117, 30)
        Me.LabelQualityVideo.TabIndex = 12
        Me.LabelQualityVideo.Text = "Video Quality"
        Me.LabelQualityVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'listFormatAudio
        '
        Me.listFormatAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listFormatAudio.ForeColor = System.Drawing.Color.DarkRed
        Me.listFormatAudio.FormattingEnabled = True
        Me.listFormatAudio.ItemHeight = 20
        Me.listFormatAudio.Items.AddRange(New Object() {"160k", "128k", "117k", "70k", "50k"})
        Me.listFormatAudio.Location = New System.Drawing.Point(128, 89)
        Me.listFormatAudio.Margin = New System.Windows.Forms.Padding(4)
        Me.listFormatAudio.Name = "listFormatAudio"
        Me.listFormatAudio.Size = New System.Drawing.Size(215, 28)
        Me.listFormatAudio.TabIndex = 11
        '
        'listFormatVideo
        '
        Me.listFormatVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.listFormatVideo.ForeColor = System.Drawing.Color.DarkRed
        Me.listFormatVideo.FormattingEnabled = True
        Me.listFormatVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.listFormatVideo.Items.AddRange(New Object() {"1080p", "720p", "480p", "360p", "240p", "144p"})
        Me.listFormatVideo.Location = New System.Drawing.Point(128, 49)
        Me.listFormatVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.listFormatVideo.Name = "listFormatVideo"
        Me.listFormatVideo.Size = New System.Drawing.Size(212, 28)
        Me.listFormatVideo.TabIndex = 10
        '
        'LabelTypeDownload
        '
        Me.LabelTypeDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTypeDownload.ForeColor = System.Drawing.Color.White
        Me.LabelTypeDownload.Location = New System.Drawing.Point(11, 286)
        Me.LabelTypeDownload.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTypeDownload.Name = "LabelTypeDownload"
        Me.LabelTypeDownload.Size = New System.Drawing.Size(149, 20)
        Me.LabelTypeDownload.TabIndex = 14
        Me.LabelTypeDownload.Text = "Download Type: "
        '
        'LabelURL
        '
        Me.LabelURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelURL.ForeColor = System.Drawing.Color.White
        Me.LabelURL.Location = New System.Drawing.Point(11, 69)
        Me.LabelURL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelURL.Name = "LabelURL"
        Me.LabelURL.Size = New System.Drawing.Size(352, 20)
        Me.LabelURL.TabIndex = 15
        Me.LabelURL.Text = "List of URL to download: "
        '
        'LabelDownload
        '
        Me.LabelDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDownload.ForeColor = System.Drawing.Color.White
        Me.LabelDownload.Location = New System.Drawing.Point(7, 23)
        Me.LabelDownload.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDownload.Name = "LabelDownload"
        Me.LabelDownload.Size = New System.Drawing.Size(336, 31)
        Me.LabelDownload.TabIndex = 16
        Me.LabelDownload.Text = "Location to download to: "
        Me.LabelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBrowseFolder
        '
        Me.TextBrowseFolder.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBrowseFolder.Location = New System.Drawing.Point(8, 58)
        Me.TextBrowseFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBrowseFolder.Name = "TextBrowseFolder"
        Me.TextBrowseFolder.Size = New System.Drawing.Size(336, 26)
        Me.TextBrowseFolder.TabIndex = 17
        '
        'buttonBrowseFolder
        '
        Me.buttonBrowseFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonBrowseFolder.ForeColor = System.Drawing.Color.DarkRed
        Me.buttonBrowseFolder.Location = New System.Drawing.Point(8, 92)
        Me.buttonBrowseFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonBrowseFolder.Name = "buttonBrowseFolder"
        Me.buttonBrowseFolder.Size = New System.Drawing.Size(336, 30)
        Me.buttonBrowseFolder.TabIndex = 18
        Me.buttonBrowseFolder.Text = "Browse Download Folder..."
        Me.buttonBrowseFolder.UseVisualStyleBackColor = True
        '
        'buttonUpdateYDL
        '
        Me.buttonUpdateYDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonUpdateYDL.ForeColor = System.Drawing.Color.DarkRed
        Me.buttonUpdateYDL.Location = New System.Drawing.Point(785, 543)
        Me.buttonUpdateYDL.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonUpdateYDL.Name = "buttonUpdateYDL"
        Me.buttonUpdateYDL.Size = New System.Drawing.Size(239, 30)
        Me.buttonUpdateYDL.TabIndex = 19
        Me.buttonUpdateYDL.Text = "Update YouTube-DL"
        Me.buttonUpdateYDL.UseVisualStyleBackColor = True
        '
        'GroupLogOutput
        '
        Me.GroupLogOutput.Controls.Add(Me.TextOutputCurrent)
        Me.GroupLogOutput.Controls.Add(Me.TextOutputLog)
        Me.GroupLogOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupLogOutput.ForeColor = System.Drawing.Color.White
        Me.GroupLogOutput.Location = New System.Drawing.Point(373, 197)
        Me.GroupLogOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupLogOutput.Name = "GroupLogOutput"
        Me.GroupLogOutput.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupLogOutput.Size = New System.Drawing.Size(651, 338)
        Me.GroupLogOutput.TabIndex = 14
        Me.GroupLogOutput.TabStop = False
        Me.GroupLogOutput.Text = "Output"
        '
        'buttonSaveLog
        '
        Me.buttonSaveLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSaveLog.ForeColor = System.Drawing.Color.DarkRed
        Me.buttonSaveLog.Location = New System.Drawing.Point(785, 581)
        Me.buttonSaveLog.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonSaveLog.Name = "buttonSaveLog"
        Me.buttonSaveLog.Size = New System.Drawing.Size(239, 30)
        Me.buttonSaveLog.TabIndex = 20
        Me.buttonSaveLog.Text = "Save Download Log"
        Me.buttonSaveLog.UseVisualStyleBackColor = True
        '
        'GroupDownload
        '
        Me.GroupDownload.Controls.Add(Me.buttonOpenFolder)
        Me.GroupDownload.Controls.Add(Me.LabelDownload)
        Me.GroupDownload.Controls.Add(Me.TextBrowseFolder)
        Me.GroupDownload.Controls.Add(Me.buttonBrowseFolder)
        Me.GroupDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDownload.ForeColor = System.Drawing.Color.White
        Me.GroupDownload.Location = New System.Drawing.Point(11, 443)
        Me.GroupDownload.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupDownload.Name = "GroupDownload"
        Me.GroupDownload.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupDownload.Size = New System.Drawing.Size(352, 168)
        Me.GroupDownload.TabIndex = 21
        Me.GroupDownload.TabStop = False
        Me.GroupDownload.Text = "Download Location"
        '
        'buttonOpenFolder
        '
        Me.buttonOpenFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonOpenFolder.ForeColor = System.Drawing.Color.DarkRed
        Me.buttonOpenFolder.Location = New System.Drawing.Point(8, 130)
        Me.buttonOpenFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonOpenFolder.Name = "buttonOpenFolder"
        Me.buttonOpenFolder.Size = New System.Drawing.Size(336, 30)
        Me.buttonOpenFolder.TabIndex = 19
        Me.buttonOpenFolder.Text = "Open Folder"
        Me.buttonOpenFolder.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.textPassword)
        Me.GroupBox4.Controls.Add(Me.textUsername)
        Me.GroupBox4.Controls.Add(Me.LabelCredentialPassword)
        Me.GroupBox4.Controls.Add(Me.LabelCredentialUsername)
        Me.GroupBox4.Controls.Add(Me.CheckRequiresLogin)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(11, 49)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(632, 128)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Credentials"
        '
        'textPassword
        '
        Me.textPassword.ForeColor = System.Drawing.Color.DarkRed
        Me.textPassword.Location = New System.Drawing.Point(107, 89)
        Me.textPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.textPassword.Size = New System.Drawing.Size(516, 26)
        Me.textPassword.TabIndex = 20
        '
        'textUsername
        '
        Me.textUsername.ForeColor = System.Drawing.Color.DarkRed
        Me.textUsername.Location = New System.Drawing.Point(107, 49)
        Me.textUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.Size = New System.Drawing.Size(516, 26)
        Me.textUsername.TabIndex = 19
        '
        'LabelCredentialPassword
        '
        Me.LabelCredentialPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCredentialPassword.ForeColor = System.Drawing.Color.White
        Me.LabelCredentialPassword.Location = New System.Drawing.Point(11, 89)
        Me.LabelCredentialPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCredentialPassword.Name = "LabelCredentialPassword"
        Me.LabelCredentialPassword.Size = New System.Drawing.Size(96, 30)
        Me.LabelCredentialPassword.TabIndex = 13
        Me.LabelCredentialPassword.Text = "Password"
        Me.LabelCredentialPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCredentialUsername
        '
        Me.LabelCredentialUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCredentialUsername.ForeColor = System.Drawing.Color.White
        Me.LabelCredentialUsername.Location = New System.Drawing.Point(11, 49)
        Me.LabelCredentialUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCredentialUsername.Name = "LabelCredentialUsername"
        Me.LabelCredentialUsername.Size = New System.Drawing.Size(96, 30)
        Me.LabelCredentialUsername.TabIndex = 12
        Me.LabelCredentialUsername.Text = "Username"
        Me.LabelCredentialUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckRequiresLogin
        '
        Me.CheckRequiresLogin.AutoSize = True
        Me.CheckRequiresLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckRequiresLogin.ForeColor = System.Drawing.Color.White
        Me.CheckRequiresLogin.Location = New System.Drawing.Point(11, 20)
        Me.CheckRequiresLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckRequiresLogin.Name = "CheckRequiresLogin"
        Me.CheckRequiresLogin.Size = New System.Drawing.Size(259, 24)
        Me.CheckRequiresLogin.TabIndex = 6
        Me.CheckRequiresLogin.Text = "Requires Username/Password"
        Me.CheckRequiresLogin.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(11, 10)
        Me.LabelTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(352, 59)
        Me.LabelTitle.TabIndex = 22
        Me.LabelTitle.Text = "YouTube-DL GUI"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupCredential
        '
        Me.GroupCredential.Controls.Add(Me.checkUseFMP)
        Me.GroupCredential.Controls.Add(Me.GroupBox4)
        Me.GroupCredential.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCredential.ForeColor = System.Drawing.Color.White
        Me.GroupCredential.Location = New System.Drawing.Point(373, 10)
        Me.GroupCredential.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupCredential.Name = "GroupCredential"
        Me.GroupCredential.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupCredential.Size = New System.Drawing.Size(651, 187)
        Me.GroupCredential.TabIndex = 21
        Me.GroupCredential.TabStop = False
        Me.GroupCredential.Text = "Optional"
        '
        'checkUseFMP
        '
        Me.checkUseFMP.AutoSize = True
        Me.checkUseFMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkUseFMP.ForeColor = System.Drawing.Color.White
        Me.checkUseFMP.Location = New System.Drawing.Point(11, 20)
        Me.checkUseFMP.Margin = New System.Windows.Forms.Padding(4)
        Me.checkUseFMP.Name = "checkUseFMP"
        Me.checkUseFMP.Size = New System.Drawing.Size(127, 24)
        Me.checkUseFMP.TabIndex = 6
        Me.checkUseFMP.Text = "Use FFMpeg"
        Me.checkUseFMP.UseVisualStyleBackColor = True
        '
        'buttonClear
        '
        Me.buttonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClear.ForeColor = System.Drawing.Color.DarkRed
        Me.buttonClear.Location = New System.Drawing.Point(370, 581)
        Me.buttonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(407, 30)
        Me.buttonClear.TabIndex = 23
        Me.buttonClear.Text = "Clear Log"
        Me.buttonClear.UseVisualStyleBackColor = True
        '
        'TextOutputCurrent
        '
        Me.TextOutputCurrent.Location = New System.Drawing.Point(7, 26)
        Me.TextOutputCurrent.Name = "TextOutputCurrent"
        Me.TextOutputCurrent.ReadOnly = True
        Me.TextOutputCurrent.Size = New System.Drawing.Size(636, 26)
        Me.TextOutputCurrent.TabIndex = 8
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1040, 624)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.GroupCredential)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.GroupDownload)
        Me.Controls.Add(Me.buttonSaveLog)
        Me.Controls.Add(Me.GroupLogOutput)
        Me.Controls.Add(Me.buttonUpdateYDL)
        Me.Controls.Add(Me.buttonDownload)
        Me.Controls.Add(Me.LabelURL)
        Me.Controls.Add(Me.LabelTypeDownload)
        Me.Controls.Add(Me.GroupQuality)
        Me.Controls.Add(Me.listOptions)
        Me.Controls.Add(Me.TextURL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.Name = "GUI"
        Me.Text = "YouTube-DL GUI"
        Me.GroupQuality.ResumeLayout(False)
        Me.GroupQuality.PerformLayout()
        Me.GroupLogOutput.ResumeLayout(False)
        Me.GroupLogOutput.PerformLayout()
        Me.GroupDownload.ResumeLayout(False)
        Me.GroupDownload.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupCredential.ResumeLayout(False)
        Me.GroupCredential.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextURL As TextBox
    Friend WithEvents buttonDownload As Button
    Friend WithEvents CheckFormatCustom As CheckBox
    Friend WithEvents TextOutputLog As TextBox
    Friend WithEvents listOptions As ComboBox
    Friend WithEvents GroupQuality As GroupBox
    Friend WithEvents LabelQualityAudio As Label
    Friend WithEvents LabelQualityVideo As Label
    Friend WithEvents listFormatAudio As ComboBox
    Friend WithEvents listFormatVideo As ComboBox
    Friend WithEvents LabelTypeDownload As Label
    Friend WithEvents LabelURL As Label
    Friend WithEvents LabelDownload As Label
    Friend WithEvents TextBrowseFolder As TextBox
    Friend WithEvents buttonBrowseFolder As Button
    Friend WithEvents buttonUpdateYDL As Button
    Friend WithEvents GroupLogOutput As GroupBox
    Friend WithEvents buttonSaveLog As Button
    Friend WithEvents GroupDownload As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents textPassword As TextBox
    Friend WithEvents textUsername As TextBox
    Friend WithEvents LabelCredentialPassword As Label
    Friend WithEvents LabelCredentialUsername As Label
    Friend WithEvents CheckRequiresLogin As CheckBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents buttonOpenFolder As Button
    Friend WithEvents GroupCredential As GroupBox
    Friend WithEvents checkUseFMP As CheckBox
    Friend WithEvents buttonClear As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextOutputCurrent As TextBox
End Class
