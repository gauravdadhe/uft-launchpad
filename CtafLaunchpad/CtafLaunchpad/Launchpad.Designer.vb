<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class f_launchpad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_launchpad))
        Me.rtb_logs = New System.Windows.Forms.RichTextBox()
        Me.bw_runUft = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gb_executionMode = New System.Windows.Forms.GroupBox()
        Me.b_runUft = New System.Windows.Forms.Button()
        Me.b_batchRun = New System.Windows.Forms.Button()
        Me.l_executionInfo = New System.Windows.Forms.Label()
        Me.l_ctDriver = New System.Windows.Forms.Label()
        Me.b_browseExecutionInfo = New System.Windows.Forms.Button()
        Me.b_browseDriver = New System.Windows.Forms.Button()
        Me.gb_control = New System.Windows.Forms.GroupBox()
        Me.b_pause = New System.Windows.Forms.Button()
        Me.b_stop = New System.Windows.Forms.Button()
        Me.b_continue = New System.Windows.Forms.Button()
        Me.b_killUft = New System.Windows.Forms.Button()
        Me.tb_executionInfo = New System.Windows.Forms.TextBox()
        Me.tb_ctDriver = New System.Windows.Forms.TextBox()
        Me.t_global = New System.Windows.Forms.TabControl()
        Me.Execution = New System.Windows.Forms.TabPage()
        Me.Updates = New System.Windows.Forms.TabPage()
        Me.gb_Updates_downloadProj = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Updates_projects = New System.Windows.Forms.ComboBox()
        Me.b_Updates_projectArtiDownload = New System.Windows.Forms.Button()
        Me.b_Updates_browseDownload = New System.Windows.Forms.Button()
        Me.l_Updates_downloadPath = New System.Windows.Forms.Label()
        Me.tb_Updates_downloadPath = New System.Windows.Forms.TextBox()
        Me.gb_Updates_install = New System.Windows.Forms.GroupBox()
        Me.l_Updates_fwInstaNote = New System.Windows.Forms.Label()
        Me.b_Updates_install = New System.Windows.Forms.Button()
        Me.b_Updates_browseInstallPath = New System.Windows.Forms.Button()
        Me.l_Updates_install = New System.Windows.Forms.Label()
        Me.tb_Updates_InstallPath = New System.Windows.Forms.TextBox()
        Me.gb_Updates_update = New System.Windows.Forms.GroupBox()
        Me.b_Updates_update = New System.Windows.Forms.Button()
        Me.clb_framework = New System.Windows.Forms.CheckedListBox()
        Me.b_Updates_browseUpdatePath = New System.Windows.Forms.Button()
        Me.l_Updates_installPath = New System.Windows.Forms.Label()
        Me.tb_Updates_updatePath = New System.Windows.Forms.TextBox()
        Me.Encryption = New System.Windows.Forms.TabPage()
        Me.gb_Encryption_encXml = New System.Windows.Forms.GroupBox()
        Me.rtb_encryptedCredXml = New System.Windows.Forms.RichTextBox()
        Me.gb_Encryption_encrIni = New System.Windows.Forms.GroupBox()
        Me.rtb_encryptedCredIni = New System.Windows.Forms.RichTextBox()
        Me.gb_Encryption_OrgValues = New System.Windows.Forms.GroupBox()
        Me.rtb_credentials = New System.Windows.Forms.RichTextBox()
        Me.b_insertCred = New System.Windows.Forms.Button()
        Me.l_credential = New System.Windows.Forms.Label()
        Me.tb_credential = New System.Windows.Forms.TextBox()
        Me.b_resetAll = New System.Windows.Forms.Button()
        Me.b_encrypt = New System.Windows.Forms.Button()
        Me.Help = New System.Windows.Forms.TabPage()
        Me.pb_help = New System.Windows.Forms.PictureBox()
        Me.Ctaf_project = New CtafLaunchpad.ctaf_project()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tt_execution = New System.Windows.Forms.ToolTip(Me.components)
        Me.fbd_ctDriver = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofd_executionInfo = New System.Windows.Forms.OpenFileDialog()
        Me.bw_batchRun = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecutionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadProjectResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncryptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.l_updates_UpdateWarning = New System.Windows.Forms.Label()
        Me.l_updates_checkedFolders = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gb_executionMode.SuspendLayout()
        Me.gb_control.SuspendLayout()
        Me.t_global.SuspendLayout()
        Me.Execution.SuspendLayout()
        Me.Updates.SuspendLayout()
        Me.gb_Updates_downloadProj.SuspendLayout()
        Me.gb_Updates_install.SuspendLayout()
        Me.gb_Updates_update.SuspendLayout()
        Me.Encryption.SuspendLayout()
        Me.gb_Encryption_encXml.SuspendLayout()
        Me.gb_Encryption_encrIni.SuspendLayout()
        Me.gb_Encryption_OrgValues.SuspendLayout()
        Me.Help.SuspendLayout()
        CType(Me.pb_help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctaf_project, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtb_logs
        '
        Me.rtb_logs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtb_logs.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_logs.Location = New System.Drawing.Point(3, 185)
        Me.rtb_logs.MaxLength = 150
        Me.rtb_logs.Name = "rtb_logs"
        Me.rtb_logs.Size = New System.Drawing.Size(614, 279)
        Me.rtb_logs.TabIndex = 9
        Me.rtb_logs.Text = ""
        '
        'bw_runUft
        '
        Me.bw_runUft.WorkerReportsProgress = True
        Me.bw_runUft.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gb_executionMode)
        Me.Panel1.Controls.Add(Me.l_executionInfo)
        Me.Panel1.Controls.Add(Me.l_ctDriver)
        Me.Panel1.Controls.Add(Me.b_browseExecutionInfo)
        Me.Panel1.Controls.Add(Me.b_browseDriver)
        Me.Panel1.Controls.Add(Me.gb_control)
        Me.Panel1.Controls.Add(Me.tb_executionInfo)
        Me.Panel1.Controls.Add(Me.tb_ctDriver)
        Me.Panel1.Controls.Add(Me.rtb_logs)
        Me.Panel1.Location = New System.Drawing.Point(16, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 467)
        Me.Panel1.TabIndex = 12
        '
        'gb_executionMode
        '
        Me.gb_executionMode.BackColor = System.Drawing.Color.Transparent
        Me.gb_executionMode.Controls.Add(Me.b_runUft)
        Me.gb_executionMode.Controls.Add(Me.b_batchRun)
        Me.gb_executionMode.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.gb_executionMode.Location = New System.Drawing.Point(11, 91)
        Me.gb_executionMode.Name = "gb_executionMode"
        Me.gb_executionMode.Size = New System.Drawing.Size(148, 80)
        Me.gb_executionMode.TabIndex = 18
        Me.gb_executionMode.TabStop = False
        Me.gb_executionMode.Text = "Execution Mode"
        '
        'b_runUft
        '
        Me.b_runUft.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.b_runUft.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_runUft.Image = Global.CtafLaunchpad.My.Resources.Resources.runUft11
        Me.b_runUft.Location = New System.Drawing.Point(16, 23)
        Me.b_runUft.Name = "b_runUft"
        Me.b_runUft.Size = New System.Drawing.Size(50, 50)
        Me.b_runUft.TabIndex = 0
        Me.b_runUft.UseVisualStyleBackColor = True
        '
        'b_batchRun
        '
        Me.b_batchRun.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.b_batchRun.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_batchRun.Image = Global.CtafLaunchpad.My.Resources.Resources.batchRun11
        Me.b_batchRun.Location = New System.Drawing.Point(83, 23)
        Me.b_batchRun.Name = "b_batchRun"
        Me.b_batchRun.Size = New System.Drawing.Size(50, 50)
        Me.b_batchRun.TabIndex = 1
        Me.b_batchRun.UseVisualStyleBackColor = True
        '
        'l_executionInfo
        '
        Me.l_executionInfo.AutoSize = True
        Me.l_executionInfo.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.l_executionInfo.Location = New System.Drawing.Point(20, 49)
        Me.l_executionInfo.Name = "l_executionInfo"
        Me.l_executionInfo.Size = New System.Drawing.Size(113, 18)
        Me.l_executionInfo.TabIndex = 17
        Me.l_executionInfo.Text = "ExecutionInfo File"
        '
        'l_ctDriver
        '
        Me.l_ctDriver.AutoSize = True
        Me.l_ctDriver.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.l_ctDriver.Location = New System.Drawing.Point(20, 14)
        Me.l_ctDriver.Name = "l_ctDriver"
        Me.l_ctDriver.Size = New System.Drawing.Size(62, 18)
        Me.l_ctDriver.TabIndex = 16
        Me.l_ctDriver.Text = "CT Driver"
        '
        'b_browseExecutionInfo
        '
        Me.b_browseExecutionInfo.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_browseExecutionInfo.Location = New System.Drawing.Point(476, 43)
        Me.b_browseExecutionInfo.Name = "b_browseExecutionInfo"
        Me.b_browseExecutionInfo.Size = New System.Drawing.Size(76, 31)
        Me.b_browseExecutionInfo.TabIndex = 15
        Me.b_browseExecutionInfo.Text = "Browse"
        Me.b_browseExecutionInfo.UseVisualStyleBackColor = True
        '
        'b_browseDriver
        '
        Me.b_browseDriver.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_browseDriver.Location = New System.Drawing.Point(476, 10)
        Me.b_browseDriver.Name = "b_browseDriver"
        Me.b_browseDriver.Size = New System.Drawing.Size(76, 31)
        Me.b_browseDriver.TabIndex = 14
        Me.b_browseDriver.Text = "Browse"
        Me.b_browseDriver.UseVisualStyleBackColor = True
        '
        'gb_control
        '
        Me.gb_control.Controls.Add(Me.b_pause)
        Me.gb_control.Controls.Add(Me.b_stop)
        Me.gb_control.Controls.Add(Me.b_continue)
        Me.gb_control.Controls.Add(Me.b_killUft)
        Me.gb_control.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.gb_control.Location = New System.Drawing.Point(358, 92)
        Me.gb_control.Name = "gb_control"
        Me.gb_control.Size = New System.Drawing.Size(256, 80)
        Me.gb_control.TabIndex = 13
        Me.gb_control.TabStop = False
        Me.gb_control.Text = "Control Panel"
        '
        'b_pause
        '
        Me.b_pause.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.b_pause.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_pause.Image = Global.CtafLaunchpad.My.Resources.Resources.pause1
        Me.b_pause.Location = New System.Drawing.Point(18, 22)
        Me.b_pause.Name = "b_pause"
        Me.b_pause.Size = New System.Drawing.Size(50, 50)
        Me.b_pause.TabIndex = 5
        Me.b_pause.UseVisualStyleBackColor = True
        '
        'b_stop
        '
        Me.b_stop.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.b_stop.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_stop.Image = Global.CtafLaunchpad.My.Resources.Resources.stop1
        Me.b_stop.Location = New System.Drawing.Point(132, 21)
        Me.b_stop.Name = "b_stop"
        Me.b_stop.Size = New System.Drawing.Size(50, 50)
        Me.b_stop.TabIndex = 7
        Me.b_stop.UseVisualStyleBackColor = True
        '
        'b_continue
        '
        Me.b_continue.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.b_continue.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_continue.Image = Global.CtafLaunchpad.My.Resources.Resources.resume1
        Me.b_continue.Location = New System.Drawing.Point(75, 21)
        Me.b_continue.Name = "b_continue"
        Me.b_continue.Size = New System.Drawing.Size(50, 50)
        Me.b_continue.TabIndex = 6
        Me.b_continue.UseVisualStyleBackColor = True
        '
        'b_killUft
        '
        Me.b_killUft.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.b_killUft.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_killUft.Image = Global.CtafLaunchpad.My.Resources.Resources.if_edit_clear_232271
        Me.b_killUft.Location = New System.Drawing.Point(189, 22)
        Me.b_killUft.Name = "b_killUft"
        Me.b_killUft.Size = New System.Drawing.Size(50, 50)
        Me.b_killUft.TabIndex = 8
        Me.b_killUft.UseVisualStyleBackColor = True
        '
        'tb_executionInfo
        '
        Me.tb_executionInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_executionInfo.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.tb_executionInfo.Location = New System.Drawing.Point(145, 47)
        Me.tb_executionInfo.Name = "tb_executionInfo"
        Me.tb_executionInfo.Size = New System.Drawing.Size(325, 23)
        Me.tb_executionInfo.TabIndex = 12
        Me.tb_executionInfo.Text = "C:\RABO CTAF\metadata\ExecutionInfo.xml"
        '
        'tb_ctDriver
        '
        Me.tb_ctDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_ctDriver.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.tb_ctDriver.Location = New System.Drawing.Point(145, 12)
        Me.tb_ctDriver.Name = "tb_ctDriver"
        Me.tb_ctDriver.Size = New System.Drawing.Size(325, 23)
        Me.tb_ctDriver.TabIndex = 11
        Me.tb_ctDriver.Text = "C:\RABO CTAF\CT_Driver_V3.0"
        '
        't_global
        '
        Me.t_global.Controls.Add(Me.Execution)
        Me.t_global.Controls.Add(Me.Updates)
        Me.t_global.Controls.Add(Me.Encryption)
        Me.t_global.Controls.Add(Me.Help)
        Me.t_global.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.t_global.Location = New System.Drawing.Point(12, 32)
        Me.t_global.Name = "t_global"
        Me.t_global.SelectedIndex = 0
        Me.t_global.Size = New System.Drawing.Size(650, 510)
        Me.t_global.TabIndex = 13
        '
        'Execution
        '
        Me.Execution.BackColor = System.Drawing.Color.Gainsboro
        Me.Execution.Controls.Add(Me.Panel1)
        Me.Execution.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Execution.Location = New System.Drawing.Point(4, 27)
        Me.Execution.Name = "Execution"
        Me.Execution.Padding = New System.Windows.Forms.Padding(3)
        Me.Execution.Size = New System.Drawing.Size(642, 479)
        Me.Execution.TabIndex = 0
        Me.Execution.Text = "Execution"
        '
        'Updates
        '
        Me.Updates.BackColor = System.Drawing.Color.LightGray
        Me.Updates.Controls.Add(Me.gb_Updates_downloadProj)
        Me.Updates.Controls.Add(Me.gb_Updates_install)
        Me.Updates.Controls.Add(Me.gb_Updates_update)
        Me.Updates.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updates.Location = New System.Drawing.Point(4, 27)
        Me.Updates.Name = "Updates"
        Me.Updates.Padding = New System.Windows.Forms.Padding(3)
        Me.Updates.Size = New System.Drawing.Size(642, 479)
        Me.Updates.TabIndex = 1
        Me.Updates.Text = "Updates"
        '
        'gb_Updates_downloadProj
        '
        Me.gb_Updates_downloadProj.Controls.Add(Me.Label1)
        Me.gb_Updates_downloadProj.Controls.Add(Me.cb_Updates_projects)
        Me.gb_Updates_downloadProj.Controls.Add(Me.b_Updates_projectArtiDownload)
        Me.gb_Updates_downloadProj.Controls.Add(Me.b_Updates_browseDownload)
        Me.gb_Updates_downloadProj.Controls.Add(Me.l_Updates_downloadPath)
        Me.gb_Updates_downloadProj.Controls.Add(Me.tb_Updates_downloadPath)
        Me.gb_Updates_downloadProj.Enabled = False
        Me.gb_Updates_downloadProj.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.gb_Updates_downloadProj.Location = New System.Drawing.Point(6, 353)
        Me.gb_Updates_downloadProj.Name = "gb_Updates_downloadProj"
        Me.gb_Updates_downloadProj.Size = New System.Drawing.Size(625, 98)
        Me.gb_Updates_downloadProj.TabIndex = 21
        Me.gb_Updates_downloadProj.TabStop = False
        Me.gb_Updates_downloadProj.Text = "Download Project Artifacts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Select Project"
        '
        'cb_Updates_projects
        '
        Me.cb_Updates_projects.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.cb_Updates_projects.FormattingEnabled = True
        Me.cb_Updates_projects.Location = New System.Drawing.Point(141, 24)
        Me.cb_Updates_projects.Name = "cb_Updates_projects"
        Me.cb_Updates_projects.Size = New System.Drawing.Size(121, 23)
        Me.cb_Updates_projects.TabIndex = 20
        '
        'b_Updates_projectArtiDownload
        '
        Me.b_Updates_projectArtiDownload.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_Updates_projectArtiDownload.Location = New System.Drawing.Point(436, 53)
        Me.b_Updates_projectArtiDownload.Name = "b_Updates_projectArtiDownload"
        Me.b_Updates_projectArtiDownload.Size = New System.Drawing.Size(78, 27)
        Me.b_Updates_projectArtiDownload.TabIndex = 19
        Me.b_Updates_projectArtiDownload.Text = "Download"
        Me.b_Updates_projectArtiDownload.UseVisualStyleBackColor = True
        '
        'b_Updates_browseDownload
        '
        Me.b_Updates_browseDownload.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_Updates_browseDownload.Location = New System.Drawing.Point(351, 53)
        Me.b_Updates_browseDownload.Name = "b_Updates_browseDownload"
        Me.b_Updates_browseDownload.Size = New System.Drawing.Size(68, 27)
        Me.b_Updates_browseDownload.TabIndex = 18
        Me.b_Updates_browseDownload.Text = "Browse"
        Me.b_Updates_browseDownload.UseVisualStyleBackColor = True
        '
        'l_Updates_downloadPath
        '
        Me.l_Updates_downloadPath.AutoSize = True
        Me.l_Updates_downloadPath.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.l_Updates_downloadPath.Location = New System.Drawing.Point(6, 57)
        Me.l_Updates_downloadPath.Name = "l_Updates_downloadPath"
        Me.l_Updates_downloadPath.Size = New System.Drawing.Size(100, 18)
        Me.l_Updates_downloadPath.TabIndex = 17
        Me.l_Updates_downloadPath.Text = "Download Path"
        '
        'tb_Updates_downloadPath
        '
        Me.tb_Updates_downloadPath.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.tb_Updates_downloadPath.Location = New System.Drawing.Point(141, 56)
        Me.tb_Updates_downloadPath.Name = "tb_Updates_downloadPath"
        Me.tb_Updates_downloadPath.Size = New System.Drawing.Size(203, 23)
        Me.tb_Updates_downloadPath.TabIndex = 12
        Me.tb_Updates_downloadPath.Text = "C:\"
        '
        'gb_Updates_install
        '
        Me.gb_Updates_install.BackColor = System.Drawing.Color.Transparent
        Me.gb_Updates_install.Controls.Add(Me.l_Updates_fwInstaNote)
        Me.gb_Updates_install.Controls.Add(Me.b_Updates_install)
        Me.gb_Updates_install.Controls.Add(Me.b_Updates_browseInstallPath)
        Me.gb_Updates_install.Controls.Add(Me.l_Updates_install)
        Me.gb_Updates_install.Controls.Add(Me.tb_Updates_InstallPath)
        Me.gb_Updates_install.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.gb_Updates_install.Location = New System.Drawing.Point(6, 25)
        Me.gb_Updates_install.Name = "gb_Updates_install"
        Me.gb_Updates_install.Size = New System.Drawing.Size(625, 96)
        Me.gb_Updates_install.TabIndex = 20
        Me.gb_Updates_install.TabStop = False
        Me.gb_Updates_install.Text = "Install CTAF"
        '
        'l_Updates_fwInstaNote
        '
        Me.l_Updates_fwInstaNote.AutoSize = True
        Me.l_Updates_fwInstaNote.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.l_Updates_fwInstaNote.ForeColor = System.Drawing.Color.Firebrick
        Me.l_Updates_fwInstaNote.Location = New System.Drawing.Point(6, 73)
        Me.l_Updates_fwInstaNote.Name = "l_Updates_fwInstaNote"
        Me.l_Updates_fwInstaNote.Size = New System.Drawing.Size(38, 15)
        Me.l_Updates_fwInstaNote.TabIndex = 20
        Me.l_Updates_fwInstaNote.Text = "Note: "
        '
        'b_Updates_install
        '
        Me.b_Updates_install.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_Updates_install.Location = New System.Drawing.Point(436, 28)
        Me.b_Updates_install.Name = "b_Updates_install"
        Me.b_Updates_install.Size = New System.Drawing.Size(69, 27)
        Me.b_Updates_install.TabIndex = 19
        Me.b_Updates_install.Text = "Install"
        Me.b_Updates_install.UseVisualStyleBackColor = True
        '
        'b_Updates_browseInstallPath
        '
        Me.b_Updates_browseInstallPath.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_Updates_browseInstallPath.Location = New System.Drawing.Point(350, 28)
        Me.b_Updates_browseInstallPath.Name = "b_Updates_browseInstallPath"
        Me.b_Updates_browseInstallPath.Size = New System.Drawing.Size(69, 27)
        Me.b_Updates_browseInstallPath.TabIndex = 18
        Me.b_Updates_browseInstallPath.Text = "Browse"
        Me.b_Updates_browseInstallPath.UseVisualStyleBackColor = True
        '
        'l_Updates_install
        '
        Me.l_Updates_install.AutoSize = True
        Me.l_Updates_install.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.l_Updates_install.Location = New System.Drawing.Point(6, 32)
        Me.l_Updates_install.Name = "l_Updates_install"
        Me.l_Updates_install.Size = New System.Drawing.Size(129, 18)
        Me.l_Updates_install.TabIndex = 17
        Me.l_Updates_install.Text = "FW Installation Path"
        '
        'tb_Updates_InstallPath
        '
        Me.tb_Updates_InstallPath.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.tb_Updates_InstallPath.Location = New System.Drawing.Point(141, 31)
        Me.tb_Updates_InstallPath.Name = "tb_Updates_InstallPath"
        Me.tb_Updates_InstallPath.Size = New System.Drawing.Size(203, 23)
        Me.tb_Updates_InstallPath.TabIndex = 12
        Me.tb_Updates_InstallPath.Text = "C:"
        '
        'gb_Updates_update
        '
        Me.gb_Updates_update.Controls.Add(Me.l_updates_checkedFolders)
        Me.gb_Updates_update.Controls.Add(Me.l_updates_UpdateWarning)
        Me.gb_Updates_update.Controls.Add(Me.b_Updates_update)
        Me.gb_Updates_update.Controls.Add(Me.clb_framework)
        Me.gb_Updates_update.Controls.Add(Me.b_Updates_browseUpdatePath)
        Me.gb_Updates_update.Controls.Add(Me.l_Updates_installPath)
        Me.gb_Updates_update.Controls.Add(Me.tb_Updates_updatePath)
        Me.gb_Updates_update.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.gb_Updates_update.Location = New System.Drawing.Point(6, 137)
        Me.gb_Updates_update.Name = "gb_Updates_update"
        Me.gb_Updates_update.Size = New System.Drawing.Size(625, 210)
        Me.gb_Updates_update.TabIndex = 19
        Me.gb_Updates_update.TabStop = False
        Me.gb_Updates_update.Text = "Update CTAF"
        '
        'b_Updates_update
        '
        Me.b_Updates_update.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_Updates_update.Location = New System.Drawing.Point(436, 17)
        Me.b_Updates_update.Name = "b_Updates_update"
        Me.b_Updates_update.Size = New System.Drawing.Size(69, 27)
        Me.b_Updates_update.TabIndex = 19
        Me.b_Updates_update.Text = "Update"
        Me.b_Updates_update.UseVisualStyleBackColor = True
        '
        'clb_framework
        '
        Me.clb_framework.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.clb_framework.FormattingEnabled = True
        Me.clb_framework.Items.AddRange(New Object() {"CT_Driver", "Tools", "SupportApps", "Help", "Execution", "Metadata", "Resources-proj"})
        Me.clb_framework.Location = New System.Drawing.Point(141, 53)
        Me.clb_framework.Name = "clb_framework"
        Me.clb_framework.Size = New System.Drawing.Size(203, 130)
        Me.clb_framework.TabIndex = 0
        Me.clb_framework.ThreeDCheckBoxes = True
        '
        'b_Updates_browseUpdatePath
        '
        Me.b_Updates_browseUpdatePath.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_Updates_browseUpdatePath.Location = New System.Drawing.Point(350, 17)
        Me.b_Updates_browseUpdatePath.Name = "b_Updates_browseUpdatePath"
        Me.b_Updates_browseUpdatePath.Size = New System.Drawing.Size(69, 27)
        Me.b_Updates_browseUpdatePath.TabIndex = 18
        Me.b_Updates_browseUpdatePath.Text = "Browse"
        Me.b_Updates_browseUpdatePath.UseVisualStyleBackColor = True
        '
        'l_Updates_installPath
        '
        Me.l_Updates_installPath.AutoSize = True
        Me.l_Updates_installPath.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.l_Updates_installPath.Location = New System.Drawing.Point(6, 22)
        Me.l_Updates_installPath.Name = "l_Updates_installPath"
        Me.l_Updates_installPath.Size = New System.Drawing.Size(129, 18)
        Me.l_Updates_installPath.TabIndex = 17
        Me.l_Updates_installPath.Text = "FW Installation Path"
        '
        'tb_Updates_updatePath
        '
        Me.tb_Updates_updatePath.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.tb_Updates_updatePath.Location = New System.Drawing.Point(141, 20)
        Me.tb_Updates_updatePath.Name = "tb_Updates_updatePath"
        Me.tb_Updates_updatePath.Size = New System.Drawing.Size(203, 23)
        Me.tb_Updates_updatePath.TabIndex = 12
        Me.tb_Updates_updatePath.Text = "C:\RABO CTAF"
        '
        'Encryption
        '
        Me.Encryption.BackColor = System.Drawing.Color.LightGray
        Me.Encryption.Controls.Add(Me.gb_Encryption_encXml)
        Me.Encryption.Controls.Add(Me.gb_Encryption_encrIni)
        Me.Encryption.Controls.Add(Me.gb_Encryption_OrgValues)
        Me.Encryption.Controls.Add(Me.b_insertCred)
        Me.Encryption.Controls.Add(Me.l_credential)
        Me.Encryption.Controls.Add(Me.tb_credential)
        Me.Encryption.Controls.Add(Me.b_resetAll)
        Me.Encryption.Controls.Add(Me.b_encrypt)
        Me.Encryption.Location = New System.Drawing.Point(4, 27)
        Me.Encryption.Name = "Encryption"
        Me.Encryption.Padding = New System.Windows.Forms.Padding(3)
        Me.Encryption.Size = New System.Drawing.Size(642, 479)
        Me.Encryption.TabIndex = 2
        Me.Encryption.Text = "Encryption"
        '
        'gb_Encryption_encXml
        '
        Me.gb_Encryption_encXml.Controls.Add(Me.rtb_encryptedCredXml)
        Me.gb_Encryption_encXml.Location = New System.Drawing.Point(433, 93)
        Me.gb_Encryption_encXml.Name = "gb_Encryption_encXml"
        Me.gb_Encryption_encXml.Size = New System.Drawing.Size(200, 365)
        Me.gb_Encryption_encXml.TabIndex = 16
        Me.gb_Encryption_encXml.TabStop = False
        Me.gb_Encryption_encXml.Text = "Encrypted Values [for .xml]"
        '
        'rtb_encryptedCredXml
        '
        Me.rtb_encryptedCredXml.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_encryptedCredXml.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.rtb_encryptedCredXml.Location = New System.Drawing.Point(6, 25)
        Me.rtb_encryptedCredXml.Name = "rtb_encryptedCredXml"
        Me.rtb_encryptedCredXml.ReadOnly = True
        Me.rtb_encryptedCredXml.Size = New System.Drawing.Size(188, 334)
        Me.rtb_encryptedCredXml.TabIndex = 12
        Me.rtb_encryptedCredXml.Text = ""
        '
        'gb_Encryption_encrIni
        '
        Me.gb_Encryption_encrIni.Controls.Add(Me.rtb_encryptedCredIni)
        Me.gb_Encryption_encrIni.Location = New System.Drawing.Point(225, 93)
        Me.gb_Encryption_encrIni.Name = "gb_Encryption_encrIni"
        Me.gb_Encryption_encrIni.Size = New System.Drawing.Size(200, 365)
        Me.gb_Encryption_encrIni.TabIndex = 15
        Me.gb_Encryption_encrIni.TabStop = False
        Me.gb_Encryption_encrIni.Text = "Encypted Values [for .ini]"
        '
        'rtb_encryptedCredIni
        '
        Me.rtb_encryptedCredIni.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_encryptedCredIni.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.rtb_encryptedCredIni.Location = New System.Drawing.Point(6, 25)
        Me.rtb_encryptedCredIni.Name = "rtb_encryptedCredIni"
        Me.rtb_encryptedCredIni.ReadOnly = True
        Me.rtb_encryptedCredIni.Size = New System.Drawing.Size(186, 334)
        Me.rtb_encryptedCredIni.TabIndex = 10
        Me.rtb_encryptedCredIni.Text = ""
        '
        'gb_Encryption_OrgValues
        '
        Me.gb_Encryption_OrgValues.Controls.Add(Me.rtb_credentials)
        Me.gb_Encryption_OrgValues.Location = New System.Drawing.Point(15, 93)
        Me.gb_Encryption_OrgValues.Name = "gb_Encryption_OrgValues"
        Me.gb_Encryption_OrgValues.Size = New System.Drawing.Size(200, 365)
        Me.gb_Encryption_OrgValues.TabIndex = 14
        Me.gb_Encryption_OrgValues.TabStop = False
        Me.gb_Encryption_OrgValues.Text = "Original Values"
        '
        'rtb_credentials
        '
        Me.rtb_credentials.BackColor = System.Drawing.SystemColors.Window
        Me.rtb_credentials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtb_credentials.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.rtb_credentials.Location = New System.Drawing.Point(6, 25)
        Me.rtb_credentials.Name = "rtb_credentials"
        Me.rtb_credentials.Size = New System.Drawing.Size(188, 334)
        Me.rtb_credentials.TabIndex = 2
        Me.rtb_credentials.Text = ""
        '
        'b_insertCred
        '
        Me.b_insertCred.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_insertCred.Location = New System.Drawing.Point(317, 37)
        Me.b_insertCred.Name = "b_insertCred"
        Me.b_insertCred.Size = New System.Drawing.Size(67, 30)
        Me.b_insertCred.TabIndex = 8
        Me.b_insertCred.Text = "Insert"
        Me.b_insertCred.UseVisualStyleBackColor = True
        '
        'l_credential
        '
        Me.l_credential.AutoSize = True
        Me.l_credential.Location = New System.Drawing.Point(45, 43)
        Me.l_credential.Name = "l_credential"
        Me.l_credential.Size = New System.Drawing.Size(104, 18)
        Me.l_credential.TabIndex = 7
        Me.l_credential.Text = "Enter Credential"
        '
        'tb_credential
        '
        Me.tb_credential.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_credential.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.tb_credential.Location = New System.Drawing.Point(153, 41)
        Me.tb_credential.Name = "tb_credential"
        Me.tb_credential.Size = New System.Drawing.Size(146, 23)
        Me.tb_credential.TabIndex = 6
        '
        'b_resetAll
        '
        Me.b_resetAll.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_resetAll.Location = New System.Drawing.Point(483, 37)
        Me.b_resetAll.Name = "b_resetAll"
        Me.b_resetAll.Size = New System.Drawing.Size(72, 30)
        Me.b_resetAll.TabIndex = 4
        Me.b_resetAll.Text = "Reset All"
        Me.b_resetAll.UseVisualStyleBackColor = True
        '
        'b_encrypt
        '
        Me.b_encrypt.Font = New System.Drawing.Font("Calibri Light", 11.25!)
        Me.b_encrypt.Location = New System.Drawing.Point(399, 37)
        Me.b_encrypt.Name = "b_encrypt"
        Me.b_encrypt.Size = New System.Drawing.Size(73, 30)
        Me.b_encrypt.TabIndex = 3
        Me.b_encrypt.Text = "Encrypt"
        Me.b_encrypt.UseVisualStyleBackColor = True
        '
        'Help
        '
        Me.Help.Controls.Add(Me.pb_help)
        Me.Help.Location = New System.Drawing.Point(4, 27)
        Me.Help.Name = "Help"
        Me.Help.Padding = New System.Windows.Forms.Padding(3)
        Me.Help.Size = New System.Drawing.Size(642, 479)
        Me.Help.TabIndex = 4
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = True
        '
        'pb_help
        '
        Me.pb_help.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_help.Image = Global.CtafLaunchpad.My.Resources.Resources.Execution
        Me.pb_help.Location = New System.Drawing.Point(3, 3)
        Me.pb_help.Name = "pb_help"
        Me.pb_help.Size = New System.Drawing.Size(636, 473)
        Me.pb_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pb_help.TabIndex = 0
        Me.pb_help.TabStop = False
        '
        'Ctaf_project
        '
        Me.Ctaf_project.DataSetName = "ctaf_project"
        Me.Ctaf_project.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 547)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(671, 22)
        Me.StatusStrip.TabIndex = 14
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Calibri Light", 9.0!)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(162, 17)
        Me.ToolStripStatusLabel1.Text = "A tool from Radical Automation"
        '
        'fbd_ctDriver
        '
        Me.fbd_ctDriver.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'ofd_executionInfo
        '
        Me.ofd_executionInfo.Filter = "Supported files|*.ini;*.xml|All files|*.*"
        '
        'bw_batchRun
        '
        Me.bw_batchRun.WorkerReportsProgress = True
        Me.bw_batchRun.WorkerSupportsCancellation = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(671, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExecutionToolStripMenuItem1, Me.UpdatesToolStripMenuItem, Me.EncryptionToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExecutionToolStripMenuItem1
        '
        Me.ExecutionToolStripMenuItem1.Name = "ExecutionToolStripMenuItem1"
        Me.ExecutionToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ExecutionToolStripMenuItem1.Text = "Execution"
        '
        'UpdatesToolStripMenuItem
        '
        Me.UpdatesToolStripMenuItem.Name = "UpdatesToolStripMenuItem"
        Me.UpdatesToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.UpdatesToolStripMenuItem.Text = "Updates"
        '
        'EncryptionToolStripMenuItem1
        '
        Me.EncryptionToolStripMenuItem1.Name = "EncryptionToolStripMenuItem1"
        Me.EncryptionToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.EncryptionToolStripMenuItem1.Text = "Encryption"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExecutionToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.EncryptionToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ExecutionToolStripMenuItem
        '
        Me.ExecutionToolStripMenuItem.Name = "ExecutionToolStripMenuItem"
        Me.ExecutionToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ExecutionToolStripMenuItem.Text = "Execution"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstallToolStripMenuItem, Me.UpdateToolStripMenuItem1, Me.DownloadProjectResourcesToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.UpdateToolStripMenuItem.Text = "Updates"
        '
        'InstallToolStripMenuItem
        '
        Me.InstallToolStripMenuItem.Name = "InstallToolStripMenuItem"
        Me.InstallToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.InstallToolStripMenuItem.Text = "Install"
        '
        'UpdateToolStripMenuItem1
        '
        Me.UpdateToolStripMenuItem1.Name = "UpdateToolStripMenuItem1"
        Me.UpdateToolStripMenuItem1.Size = New System.Drawing.Size(224, 22)
        Me.UpdateToolStripMenuItem1.Text = "Update"
        '
        'DownloadProjectResourcesToolStripMenuItem
        '
        Me.DownloadProjectResourcesToolStripMenuItem.Name = "DownloadProjectResourcesToolStripMenuItem"
        Me.DownloadProjectResourcesToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.DownloadProjectResourcesToolStripMenuItem.Text = "Download Project Resources"
        '
        'EncryptionToolStripMenuItem
        '
        Me.EncryptionToolStripMenuItem.Name = "EncryptionToolStripMenuItem"
        Me.EncryptionToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EncryptionToolStripMenuItem.Text = "Encryption"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AboutUsToolStripMenuItem.Text = "AboutUs"
        '
        'l_updates_UpdateWarning
        '
        Me.l_updates_UpdateWarning.AutoSize = True
        Me.l_updates_UpdateWarning.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Bold)
        Me.l_updates_UpdateWarning.ForeColor = System.Drawing.Color.Firebrick
        Me.l_updates_UpdateWarning.Location = New System.Drawing.Point(350, 53)
        Me.l_updates_UpdateWarning.Name = "l_updates_UpdateWarning"
        Me.l_updates_UpdateWarning.Size = New System.Drawing.Size(182, 45)
        Me.l_updates_UpdateWarning.TabIndex = 21
        Me.l_updates_UpdateWarning.Text = "Warning : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selected directories will be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "replaced with latest version."
        '
        'l_updates_checkedFolders
        '
        Me.l_updates_checkedFolders.AutoSize = True
        Me.l_updates_checkedFolders.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.l_updates_checkedFolders.ForeColor = System.Drawing.Color.Firebrick
        Me.l_updates_checkedFolders.Location = New System.Drawing.Point(363, 87)
        Me.l_updates_checkedFolders.Name = "l_updates_checkedFolders"
        Me.l_updates_checkedFolders.Size = New System.Drawing.Size(0, 15)
        Me.l_updates_checkedFolders.TabIndex = 21
        '
        'f_launchpad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 569)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.t_global)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "f_launchpad"
        Me.Text = "CTAF Launchpad"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gb_executionMode.ResumeLayout(False)
        Me.gb_control.ResumeLayout(False)
        Me.t_global.ResumeLayout(False)
        Me.Execution.ResumeLayout(False)
        Me.Updates.ResumeLayout(False)
        Me.gb_Updates_downloadProj.ResumeLayout(False)
        Me.gb_Updates_downloadProj.PerformLayout()
        Me.gb_Updates_install.ResumeLayout(False)
        Me.gb_Updates_install.PerformLayout()
        Me.gb_Updates_update.ResumeLayout(False)
        Me.gb_Updates_update.PerformLayout()
        Me.Encryption.ResumeLayout(False)
        Me.Encryption.PerformLayout()
        Me.gb_Encryption_encXml.ResumeLayout(False)
        Me.gb_Encryption_encrIni.ResumeLayout(False)
        Me.gb_Encryption_OrgValues.ResumeLayout(False)
        Me.Help.ResumeLayout(False)
        CType(Me.pb_help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctaf_project, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_batchRun As Button
    Friend WithEvents b_runUft As Button
    Friend WithEvents b_stop As Button
    Friend WithEvents b_continue As Button
    Friend WithEvents b_pause As Button
    Friend WithEvents rtb_logs As RichTextBox
    Friend WithEvents b_killUft As Button
    Friend WithEvents bw_runUft As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents t_global As TabControl
    Friend WithEvents Execution As TabPage
    Friend WithEvents Updates As TabPage
    Friend WithEvents Encryption As TabPage
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tt_execution As ToolTip
    Friend WithEvents gb_control As GroupBox
    Friend WithEvents tb_executionInfo As TextBox
    Friend WithEvents tb_ctDriver As TextBox
    Friend WithEvents fbd_ctDriver As FolderBrowserDialog
    Friend WithEvents gb_executionMode As GroupBox
    Friend WithEvents l_executionInfo As Label
    Friend WithEvents l_ctDriver As Label
    Friend WithEvents b_browseExecutionInfo As Button
    Friend WithEvents b_browseDriver As Button
    Friend WithEvents ofd_executionInfo As OpenFileDialog
    Friend WithEvents bw_batchRun As System.ComponentModel.BackgroundWorker
    Friend WithEvents b_resetAll As Button
    Friend WithEvents b_encrypt As Button
    Friend WithEvents rtb_credentials As RichTextBox
    Friend WithEvents rtb_encryptedCredXml As RichTextBox
    Friend WithEvents rtb_encryptedCredIni As RichTextBox
    Friend WithEvents b_insertCred As Button
    Friend WithEvents l_credential As Label
    Friend WithEvents tb_credential As TextBox
    Friend WithEvents clb_framework As CheckedListBox
    Friend WithEvents b_Updates_browseUpdatePath As Button
    Friend WithEvents l_Updates_installPath As Label
    Friend WithEvents tb_Updates_updatePath As TextBox
    Friend WithEvents gb_Updates_downloadProj As GroupBox
    Friend WithEvents b_Updates_projectArtiDownload As Button
    Friend WithEvents b_Updates_browseDownload As Button
    Friend WithEvents l_Updates_downloadPath As Label
    Friend WithEvents tb_Updates_downloadPath As TextBox
    Friend WithEvents gb_Updates_install As GroupBox
    Friend WithEvents b_Updates_install As Button
    Friend WithEvents b_Updates_browseInstallPath As Button
    Friend WithEvents l_Updates_install As Label
    Friend WithEvents tb_Updates_InstallPath As TextBox
    Friend WithEvents gb_Updates_update As GroupBox
    Friend WithEvents b_Updates_update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_Updates_projects As ComboBox
    Friend WithEvents Help As TabPage
    Friend WithEvents Ctaf_project As ctaf_project
    Friend WithEvents gb_Encryption_encXml As GroupBox
    Friend WithEvents gb_Encryption_encrIni As GroupBox
    Friend WithEvents gb_Encryption_OrgValues As GroupBox
    Friend WithEvents l_Updates_fwInstaNote As Label
    Friend WithEvents pb_help As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExecutionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DownloadProjectResourcesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncryptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExecutionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncryptionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents l_updates_UpdateWarning As Label
    Friend WithEvents l_updates_checkedFolders As Label
End Class
