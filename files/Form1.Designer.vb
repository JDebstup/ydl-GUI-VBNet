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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
        Me.TextURL = New System.Windows.Forms.TextBox()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.TextOutputLog = New System.Windows.Forms.TextBox()
        Me.ListOptions = New System.Windows.Forms.ComboBox()
        Me.GroupDownloadChoice = New System.Windows.Forms.GroupBox()
        Me.RadioQualityAuto = New System.Windows.Forms.RadioButton()
        Me.RadioQualityBest = New System.Windows.Forms.RadioButton()
        Me.RadioQualityCustom = New System.Windows.Forms.RadioButton()
        Me.LabelChoiceAudio = New System.Windows.Forms.Label()
        Me.LabelChoiceVideo = New System.Windows.Forms.Label()
        Me.ListFormatAudio = New System.Windows.Forms.ComboBox()
        Me.ListFormatVideo = New System.Windows.Forms.ComboBox()
        Me.LabelDownloadType = New System.Windows.Forms.Label()
        Me.LabelURL = New System.Windows.Forms.Label()
        Me.LabelDownloadLocation = New System.Windows.Forms.Label()
        Me.TextBrowseFolder = New System.Windows.Forms.TextBox()
        Me.ButtonBrowseFolder = New System.Windows.Forms.Button()
        Me.ButtonUpdateYDL = New System.Windows.Forms.Button()
        Me.GroupOutput = New System.Windows.Forms.GroupBox()
        Me.ButtonSaveLog = New System.Windows.Forms.Button()
        Me.GroupDownloadLocation = New System.Windows.Forms.GroupBox()
        Me.ButtonOpenFolder = New System.Windows.Forms.Button()
        Me.GroupCredential = New System.Windows.Forms.GroupBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.LabelCredentialPassword = New System.Windows.Forms.Label()
        Me.LabelCredentialUsername = New System.Windows.Forms.Label()
        Me.CheckRequiresLogin = New System.Windows.Forms.CheckBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.GroupDownloadChoice.SuspendLayout()
        Me.GroupOutput.SuspendLayout()
        Me.GroupDownloadLocation.SuspendLayout()
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
        'ButtonDownload
        '
        Me.ButtonDownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDownload.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonDownload.Location = New System.Drawing.Point(373, 589)
        Me.ButtonDownload.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Size = New System.Drawing.Size(204, 40)
        Me.ButtonDownload.TabIndex = 3
        Me.ButtonDownload.Text = "Download"
        Me.ButtonDownload.UseVisualStyleBackColor = True
        '
        'TextOutputLog
        '
        Me.TextOutputLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextOutputLog.ForeColor = System.Drawing.Color.DarkRed
        Me.TextOutputLog.Location = New System.Drawing.Point(11, 30)
        Me.TextOutputLog.Margin = New System.Windows.Forms.Padding(4)
        Me.TextOutputLog.Multiline = True
        Me.TextOutputLog.Name = "TextOutputLog"
        Me.TextOutputLog.ReadOnly = True
        Me.TextOutputLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextOutputLog.Size = New System.Drawing.Size(481, 405)
        Me.TextOutputLog.TabIndex = 7
        Me.TextOutputLog.WordWrap = False
        '
        'ListOptions
        '
        Me.ListOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListOptions.ForeColor = System.Drawing.Color.DarkRed
        Me.ListOptions.FormattingEnabled = True
        Me.ListOptions.Items.AddRange(New Object() {"Video and Audio", "Video Only", "Audio Only"})
        Me.ListOptions.Location = New System.Drawing.Point(160, 286)
        Me.ListOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.ListOptions.Name = "ListOptions"
        Me.ListOptions.Size = New System.Drawing.Size(201, 24)
        Me.ListOptions.TabIndex = 8
        '
        'GroupDownloadChoice
        '
        Me.GroupDownloadChoice.Controls.Add(Me.RadioQualityAuto)
        Me.GroupDownloadChoice.Controls.Add(Me.RadioQualityBest)
        Me.GroupDownloadChoice.Controls.Add(Me.RadioQualityCustom)
        Me.GroupDownloadChoice.Controls.Add(Me.LabelChoiceAudio)
        Me.GroupDownloadChoice.Controls.Add(Me.LabelChoiceVideo)
        Me.GroupDownloadChoice.Controls.Add(Me.ListFormatAudio)
        Me.GroupDownloadChoice.Controls.Add(Me.ListFormatVideo)
        Me.GroupDownloadChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDownloadChoice.ForeColor = System.Drawing.Color.White
        Me.GroupDownloadChoice.Location = New System.Drawing.Point(11, 315)
        Me.GroupDownloadChoice.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupDownloadChoice.Name = "GroupDownloadChoice"
        Me.GroupDownloadChoice.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupDownloadChoice.Size = New System.Drawing.Size(352, 197)
        Me.GroupDownloadChoice.TabIndex = 9
        Me.GroupDownloadChoice.TabStop = False
        Me.GroupDownloadChoice.Text = "Video/Audio Quality"
        '
        'RadioQualityAuto
        '
        Me.RadioQualityAuto.AutoSize = True
        Me.RadioQualityAuto.Location = New System.Drawing.Point(8, 26)
        Me.RadioQualityAuto.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioQualityAuto.Name = "RadioQualityAuto"
        Me.RadioQualityAuto.Size = New System.Drawing.Size(290, 24)
        Me.RadioQualityAuto.TabIndex = 16
        Me.RadioQualityAuto.TabStop = True
        Me.RadioQualityAuto.Text = "Auto (Downloads Video and Audio)"
        Me.RadioQualityAuto.UseVisualStyleBackColor = True
        '
        'RadioQualityBest
        '
        Me.RadioQualityBest.AutoSize = True
        Me.RadioQualityBest.Location = New System.Drawing.Point(8, 58)
        Me.RadioQualityBest.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioQualityBest.Name = "RadioQualityBest"
        Me.RadioQualityBest.Size = New System.Drawing.Size(157, 24)
        Me.RadioQualityBest.TabIndex = 15
        Me.RadioQualityBest.TabStop = True
        Me.RadioQualityBest.Text = "Use Best Quality"
        Me.RadioQualityBest.UseVisualStyleBackColor = True
        '
        'RadioQualityCustom
        '
        Me.RadioQualityCustom.AutoSize = True
        Me.RadioQualityCustom.Location = New System.Drawing.Point(8, 90)
        Me.RadioQualityCustom.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioQualityCustom.Name = "RadioQualityCustom"
        Me.RadioQualityCustom.Size = New System.Drawing.Size(180, 24)
        Me.RadioQualityCustom.TabIndex = 14
        Me.RadioQualityCustom.TabStop = True
        Me.RadioQualityCustom.Text = "Use Custom Quality"
        Me.RadioQualityCustom.UseVisualStyleBackColor = True
        '
        'LabelChoiceAudio
        '
        Me.LabelChoiceAudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChoiceAudio.ForeColor = System.Drawing.Color.White
        Me.LabelChoiceAudio.Location = New System.Drawing.Point(8, 154)
        Me.LabelChoiceAudio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelChoiceAudio.Name = "LabelChoiceAudio"
        Me.LabelChoiceAudio.Size = New System.Drawing.Size(117, 30)
        Me.LabelChoiceAudio.TabIndex = 13
        Me.LabelChoiceAudio.Text = "Audio Quality"
        Me.LabelChoiceAudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelChoiceVideo
        '
        Me.LabelChoiceVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChoiceVideo.ForeColor = System.Drawing.Color.White
        Me.LabelChoiceVideo.Location = New System.Drawing.Point(8, 117)
        Me.LabelChoiceVideo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelChoiceVideo.Name = "LabelChoiceVideo"
        Me.LabelChoiceVideo.Size = New System.Drawing.Size(117, 30)
        Me.LabelChoiceVideo.TabIndex = 12
        Me.LabelChoiceVideo.Text = "Video Quality"
        Me.LabelChoiceVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListFormatAudio
        '
        Me.ListFormatAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListFormatAudio.ForeColor = System.Drawing.Color.DarkRed
        Me.ListFormatAudio.FormattingEnabled = True
        Me.ListFormatAudio.ItemHeight = 20
        Me.ListFormatAudio.Items.AddRange(New Object() {"160k", "128k", "117k", "70k", "50k"})
        Me.ListFormatAudio.Location = New System.Drawing.Point(133, 155)
        Me.ListFormatAudio.Margin = New System.Windows.Forms.Padding(4)
        Me.ListFormatAudio.Name = "ListFormatAudio"
        Me.ListFormatAudio.Size = New System.Drawing.Size(207, 28)
        Me.ListFormatAudio.TabIndex = 11
        '
        'ListFormatVideo
        '
        Me.ListFormatVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListFormatVideo.ForeColor = System.Drawing.Color.DarkRed
        Me.ListFormatVideo.FormattingEnabled = True
        Me.ListFormatVideo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListFormatVideo.Items.AddRange(New Object() {"1080p", "720p", "480p", "360p", "240p", "144p"})
        Me.ListFormatVideo.Location = New System.Drawing.Point(133, 118)
        Me.ListFormatVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.ListFormatVideo.Name = "ListFormatVideo"
        Me.ListFormatVideo.Size = New System.Drawing.Size(207, 28)
        Me.ListFormatVideo.TabIndex = 10
        '
        'LabelDownloadType
        '
        Me.LabelDownloadType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDownloadType.ForeColor = System.Drawing.Color.White
        Me.LabelDownloadType.Location = New System.Drawing.Point(11, 286)
        Me.LabelDownloadType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDownloadType.Name = "LabelDownloadType"
        Me.LabelDownloadType.Size = New System.Drawing.Size(149, 20)
        Me.LabelDownloadType.TabIndex = 14
        Me.LabelDownloadType.Text = "Download Type: "
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
        'LabelDownloadLocation
        '
        Me.LabelDownloadLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDownloadLocation.ForeColor = System.Drawing.Color.White
        Me.LabelDownloadLocation.Location = New System.Drawing.Point(11, 20)
        Me.LabelDownloadLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDownloadLocation.Name = "LabelDownloadLocation"
        Me.LabelDownloadLocation.Size = New System.Drawing.Size(331, 20)
        Me.LabelDownloadLocation.TabIndex = 16
        Me.LabelDownloadLocation.Text = "Location to download to: "
        '
        'TextBrowseFolder
        '
        Me.TextBrowseFolder.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBrowseFolder.Location = New System.Drawing.Point(11, 39)
        Me.TextBrowseFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBrowseFolder.Name = "TextBrowseFolder"
        Me.TextBrowseFolder.Size = New System.Drawing.Size(331, 26)
        Me.TextBrowseFolder.TabIndex = 17
        '
        'ButtonBrowseFolder
        '
        Me.ButtonBrowseFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrowseFolder.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonBrowseFolder.Location = New System.Drawing.Point(11, 74)
        Me.ButtonBrowseFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBrowseFolder.Name = "ButtonBrowseFolder"
        Me.ButtonBrowseFolder.Size = New System.Drawing.Size(331, 30)
        Me.ButtonBrowseFolder.TabIndex = 18
        Me.ButtonBrowseFolder.Text = "Browse Download Folder..."
        Me.ButtonBrowseFolder.UseVisualStyleBackColor = True
        '
        'ButtonUpdateYDL
        '
        Me.ButtonUpdateYDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdateYDL.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonUpdateYDL.Location = New System.Drawing.Point(585, 588)
        Me.ButtonUpdateYDL.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonUpdateYDL.Name = "ButtonUpdateYDL"
        Me.ButtonUpdateYDL.Size = New System.Drawing.Size(288, 41)
        Me.ButtonUpdateYDL.TabIndex = 19
        Me.ButtonUpdateYDL.Text = "Update YouTube-DL"
        Me.ButtonUpdateYDL.UseVisualStyleBackColor = True
        '
        'GroupOutput
        '
        Me.GroupOutput.Controls.Add(Me.TextOutputLog)
        Me.GroupOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupOutput.ForeColor = System.Drawing.Color.White
        Me.GroupOutput.Location = New System.Drawing.Point(373, 138)
        Me.GroupOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupOutput.Name = "GroupOutput"
        Me.GroupOutput.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupOutput.Size = New System.Drawing.Size(500, 443)
        Me.GroupOutput.TabIndex = 14
        Me.GroupOutput.TabStop = False
        Me.GroupOutput.Text = "Output"
        '
        'ButtonSaveLog
        '
        Me.ButtonSaveLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveLog.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonSaveLog.Location = New System.Drawing.Point(585, 637)
        Me.ButtonSaveLog.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSaveLog.Name = "ButtonSaveLog"
        Me.ButtonSaveLog.Size = New System.Drawing.Size(288, 30)
        Me.ButtonSaveLog.TabIndex = 20
        Me.ButtonSaveLog.Text = "Save Download Log"
        Me.ButtonSaveLog.UseVisualStyleBackColor = True
        '
        'GroupDownloadLocation
        '
        Me.GroupDownloadLocation.Controls.Add(Me.ButtonOpenFolder)
        Me.GroupDownloadLocation.Controls.Add(Me.LabelDownloadLocation)
        Me.GroupDownloadLocation.Controls.Add(Me.TextBrowseFolder)
        Me.GroupDownloadLocation.Controls.Add(Me.ButtonBrowseFolder)
        Me.GroupDownloadLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDownloadLocation.ForeColor = System.Drawing.Color.White
        Me.GroupDownloadLocation.Location = New System.Drawing.Point(11, 519)
        Me.GroupDownloadLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupDownloadLocation.Name = "GroupDownloadLocation"
        Me.GroupDownloadLocation.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupDownloadLocation.Size = New System.Drawing.Size(352, 148)
        Me.GroupDownloadLocation.TabIndex = 21
        Me.GroupDownloadLocation.TabStop = False
        Me.GroupDownloadLocation.Text = "Download Location"
        '
        'ButtonOpenFolder
        '
        Me.ButtonOpenFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpenFolder.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonOpenFolder.Location = New System.Drawing.Point(11, 108)
        Me.ButtonOpenFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOpenFolder.Name = "ButtonOpenFolder"
        Me.ButtonOpenFolder.Size = New System.Drawing.Size(331, 30)
        Me.ButtonOpenFolder.TabIndex = 19
        Me.ButtonOpenFolder.Text = "Open Folder"
        Me.ButtonOpenFolder.UseVisualStyleBackColor = True
        '
        'GroupCredential
        '
        Me.GroupCredential.Controls.Add(Me.TextPassword)
        Me.GroupCredential.Controls.Add(Me.TextUsername)
        Me.GroupCredential.Controls.Add(Me.LabelCredentialPassword)
        Me.GroupCredential.Controls.Add(Me.LabelCredentialUsername)
        Me.GroupCredential.Controls.Add(Me.CheckRequiresLogin)
        Me.GroupCredential.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCredential.ForeColor = System.Drawing.Color.White
        Me.GroupCredential.Location = New System.Drawing.Point(373, 10)
        Me.GroupCredential.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupCredential.Name = "GroupCredential"
        Me.GroupCredential.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupCredential.Size = New System.Drawing.Size(500, 128)
        Me.GroupCredential.TabIndex = 14
        Me.GroupCredential.TabStop = False
        Me.GroupCredential.Text = "Credentials"
        '
        'TextPassword
        '
        Me.TextPassword.ForeColor = System.Drawing.Color.DarkRed
        Me.TextPassword.Location = New System.Drawing.Point(107, 89)
        Me.TextPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextPassword.Size = New System.Drawing.Size(385, 26)
        Me.TextPassword.TabIndex = 20
        '
        'TextUsername
        '
        Me.TextUsername.ForeColor = System.Drawing.Color.DarkRed
        Me.TextUsername.Location = New System.Drawing.Point(107, 49)
        Me.TextUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(385, 26)
        Me.TextUsername.TabIndex = 19
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
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonClear.Location = New System.Drawing.Point(373, 637)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(204, 30)
        Me.ButtonClear.TabIndex = 23
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(886, 676)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.GroupCredential)
        Me.Controls.Add(Me.GroupDownloadLocation)
        Me.Controls.Add(Me.ButtonSaveLog)
        Me.Controls.Add(Me.GroupOutput)
        Me.Controls.Add(Me.ButtonUpdateYDL)
        Me.Controls.Add(Me.ButtonDownload)
        Me.Controls.Add(Me.LabelURL)
        Me.Controls.Add(Me.LabelDownloadType)
        Me.Controls.Add(Me.GroupDownloadChoice)
        Me.Controls.Add(Me.ListOptions)
        Me.Controls.Add(Me.TextURL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.Name = "GUI"
        Me.Text = "YouTube-DL GUI"
        Me.GroupDownloadChoice.ResumeLayout(False)
        Me.GroupDownloadChoice.PerformLayout()
        Me.GroupOutput.ResumeLayout(False)
        Me.GroupOutput.PerformLayout()
        Me.GroupDownloadLocation.ResumeLayout(False)
        Me.GroupDownloadLocation.PerformLayout()
        Me.GroupCredential.ResumeLayout(False)
        Me.GroupCredential.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextURL As TextBox
    Friend WithEvents ButtonDownload As Button
    Friend WithEvents TextOutputLog As TextBox
    Friend WithEvents ListOptions As ComboBox
    Friend WithEvents GroupDownloadChoice As GroupBox
    Friend WithEvents LabelChoiceAudio As Label
    Friend WithEvents LabelChoiceVideo As Label
    Friend WithEvents ListFormatAudio As ComboBox
    Friend WithEvents ListFormatVideo As ComboBox
    Friend WithEvents LabelDownloadType As Label
    Friend WithEvents LabelURL As Label
    Friend WithEvents LabelDownloadLocation As Label
    Friend WithEvents TextBrowseFolder As TextBox
    Friend WithEvents ButtonBrowseFolder As Button
    Friend WithEvents ButtonUpdateYDL As Button
    Friend WithEvents GroupOutput As GroupBox
    Friend WithEvents ButtonSaveLog As Button
    Friend WithEvents GroupDownloadLocation As GroupBox
    Friend WithEvents GroupCredential As GroupBox
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents TextUsername As TextBox
    Friend WithEvents LabelCredentialPassword As Label
    Friend WithEvents LabelCredentialUsername As Label
    Friend WithEvents CheckRequiresLogin As CheckBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonOpenFolder As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents RadioQualityCustom As RadioButton
    Friend WithEvents RadioQualityAuto As RadioButton
    Friend WithEvents RadioQualityBest As RadioButton
End Class
