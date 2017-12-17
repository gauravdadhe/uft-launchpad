Imports System.ComponentModel
Imports System.IO
Imports System.Reflection.Assembly
Public Class f_launchpad
    Public Shared sf As SupportFunction = New SupportFunction
    Public Shared kilUft As Boolean = False
    Public Shared fwInstallPath = ""
    Public Shared coreDriver = ""
    Public Shared coreExeInfo = ""
    Public Shared orgExeInfoXmlName As String = "ExecutionInfo_" & sf.sEdit_TimeStamp() & "_" & Int((10000 - 3 + 1) * Rnd() + 3) & ".xml"
    '************************************************************************************************
    '* Function Name: runUFTDriver
    '* Objective	: Execute CT_DriverVx.x
    '* Author		: GD
    '* Date			: 16-June-2017
    '* Last Modified: 21-Nov-2017
    '* Comments		: This utility works only for default FW installation. (C:\Rabo CTAF)
    '************************************************************************************************
    Private Sub b_runUft_Click(sender As Object, e As EventArgs) Handles b_runUft.Click
        Try
            Dim thisExeInfoFilePath : thisExeInfoFilePath = Trim(tb_executionInfo.Text)
            Dim preCondFlag As Boolean = True
            kilUft = True
            b_runUft.Enabled = False
            b_batchRun.Enabled = False
            tb_ctDriver.Enabled = False
            tb_executionInfo.Enabled = False
            b_browseDriver.Enabled = False
            b_browseExecutionInfo.Enabled = False

            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Using CT Driver: " & coreDriver))
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Using ExeInfo: " & thisExeInfoFilePath))

            '----------------------------------
            'Precondition Checks
            '----------------------------------
            '1. DriverPath Empty or not found
            If coreDriver = "" Or Not (sf.doesFolderExists(coreDriver)) Then
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "ERROR: CT Driver path [" & coreDriver & "] is empty or does not exist. Stopping the execution."))
                preCondFlag = False
            End If

            '2. ExecutionInfo Empty or not found
            If thisExeInfoFilePath = "" Or (Not (sf.isfileExist(thisExeInfoFilePath))) And preCondFlag Then
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "ERROR: ExecutionInfo file path [" & thisExeInfoFilePath & "] is empty or does not exist. Stopping the execution."))
                preCondFlag = False
            End If

            If preCondFlag Then
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Starting UFT execution."))
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Tear-down existing UFT instances."))
                Call sf.killProcess("uft.exe")

                If thisExeInfoFilePath <> coreExeInfo Then
                    'Take backup of existing ExecutionInfo.xml file
                    If sf.isfileExist(coreExeInfo) Then
                        rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Taking backup of existing ExecutionInfo.xml File. [" & fwInstallPath & "\metadata\" & orgExeInfoXmlName & "]"))
                        Call sf.moveFile(coreExeInfo, fwInstallPath & "\metadata\" & orgExeInfoXmlName, rtb_logs)
                    End If

                    If UCase(sf.getExtensionName(thisExeInfoFilePath, rtb_logs)) = "XML" Then
                        'New ExecutionInfo is an XML. Use as is.
                        rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Copying [" & thisExeInfoFilePath & "] to [" & coreExeInfo & "]"))
                        Call sf.copyFile(thisExeInfoFilePath, coreExeInfo, rtb_logs)
                    Else
                        'New file is not XML. Covert it to XML and then use it.
                        rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & thisExeInfoFilePath & " is not XML file. Converting it to ExecutionInfo.xml"))
                        Call sf.createExecutionInfoXml(thisExeInfoFilePath, coreExeInfo)
                    End If
                End If

                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Launching new UFT instance using " & coreDriver))
                'Launch UFT with the Driver
                sf.launchUFTAndTest(coreDriver)
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "[" & thisExeInfoFilePath & "] Execution started."))
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "[" & thisExeInfoFilePath & "] Check UFT console for the execution progress."))
                'Run the Driver
                bw_runUft.RunWorkerAsync()
            Else
                If My.Application.CommandLineArgs.Count > 0 Then
                    Me.Close()
                End If
            End If
        Catch
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & Err.Description & "."))
            If My.Application.CommandLineArgs.Count > 0 Then
                Me.Close()
            End If
        End Try
        b_runUft.Enabled = True
        b_batchRun.Enabled = True
        tb_ctDriver.Enabled = True
        tb_executionInfo.Enabled = True
        b_browseDriver.Enabled = True
        b_browseExecutionInfo.Enabled = True

        'MsgBox(My.Application.CommandLineArgs.Count)
        'For i = 1 To (My.Application.CommandLineArgs.Count)
        'MsgBox(My.Application.CommandLineArgs.Item(i - 1))
        'Next
    End Sub

    Private Sub f_launchpad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Control.CheckForIllegalCrossThreadCalls = False
        fwInstallPath = "C:\RABO CTAF"
        coreDriver = fwInstallPath & "\CT_Driver_V3.0"
        coreExeInfo = fwInstallPath & "\metadata\ExecutionInfo.xml"

        '------------------------------------
        'Page1 : controls
        '------------------------------------
        rtb_logs.ReadOnly = True
        rtb_logs.Text = "|*******************************************************************************|" & vbNewLine &
                        "|* Welcome to CTAF Test Automation Framework!!                                  |" & vbNewLine &
                        "|* Using this tool you can avail below features,                                |" & vbNewLine &
                        "|*                                                                              |" & vbNewLine &
                        "|* 1. Execute CT_Driver and control the execution in single or batch mode       |" & vbNewLine &
                        "|* 2. Update CTAF framework with latest version                                 |" & vbNewLine &
                        "|* 3. Credentials Encryption                                                    |" & vbNewLine &
                        "|*******************************************************************************|"

        'Me.Top = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - Me.Height - 40
        'Me.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - Me.Width
        'Me.Location = New Point(Me.Left, Me.Top)
        Me.CenterToScreen()
        MaximizeBox = False

        '------------------------------------
        'Page2 : Updates
        '------------------------------------
        l_Updates_fwInstaNote.Text = "Note : Framework will be installed at [" & tb_Updates_InstallPath.Text & "\RABO CTAF]"

        'Dim warningText As String = ""
        For i = 0 To (clb_framework.Items.Count - 1)
            Select Case UCase(clb_framework.Items(i).ToString)
                Case "CT_DRIVER", "TOOLS", "SUPPORTAPPS", "HELP"
                    clb_framework.SetItemChecked(i, True)
                    'warningText = warningText & clb_framework.Items(i).ToString & vbNewLine
                Case Else
                    clb_framework.SetItemChecked(i, False)
            End Select
        Next
        'l_updates_checkedFolders.Text = warningText


        If My.Application.CommandLineArgs.Count > 0 Then
            Me.WindowState = FormWindowState.Minimized
            Select Case My.Application.CommandLineArgs.Count
                Case 1
                    tb_ctDriver.Text = "C:\RABO CTAF\CT_Driver_V3.0"
                    tb_executionInfo.Text = "C:\RABO CTAF\metadata\ExecutionInfo.xml"
                Case 2
                    tb_ctDriver.Text = My.Application.CommandLineArgs.Item(1)
                    tb_executionInfo.Text = "C:\RABO CTAF\metadata\ExecutionInfo.xml"
                Case Else
                    tb_ctDriver.Text = My.Application.CommandLineArgs.Item(1)
                    tb_executionInfo.Text = My.Application.CommandLineArgs.Item(2)
            End Select

            Select Case UCase(My.Application.CommandLineArgs.Item(0))
                Case "RUNUFT"
                    Call b_runUft_Click(sender, e)
                Case "BATCHRUN"
                    Call b_batchRun_Click(sender, e)
                Case Else
                    Me.Close()
            End Select
        Else
            tb_ctDriver.Text = "C:\RABO CTAF\CT_Driver_V3.0"
            tb_executionInfo.Text = "C:\RABO CTAF\metadata\ExecutionInfo.xml"
        End If

    End Sub

    Private Sub b_pause_Click(sender As Object, e As EventArgs) Handles b_pause.Click
        Try
            Dim qtAppObj
            Dim sf = New SupportFunction
            If sf.isProcessRunning("uft.exe") = True Then
                qtAppObj = CreateObject("quicktest.application")
                qtAppObj.Test.Pause
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] Current execution is PAUSED by the user."))
            Else
                'rtb_logs.Appendtext( vbNewLine & ("[" & Now & "] WARNING [Pause]: No execution is found.")
                rtb_logs.AppendText(vbNewLine & "[" & Now & "] WARNING [Pause]: No execution is found.")
            End If

        Catch
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] WARNING [Pause]: " & Err.Description))
        End Try
    End Sub

    Private Sub b_continue_Click(sender As Object, e As EventArgs) Handles b_continue.Click
        Try
            Dim qtAppObj
            Dim sf = New SupportFunction
            If sf.isProcessRunning("uft.exe") = True Then
                qtAppObj = CreateObject("quicktest.application")
                qtAppObj.Test.Continue
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] Current execution is RESUMED by the user."))
            Else
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] WARNING [Continue]: No execution is found."))
            End If
        Catch
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] WARNING [Continue]: " & Err.Description))
        End Try
    End Sub

    Private Sub b_stop_Click(sender As Object, e As EventArgs) Handles b_stop.Click
        Try
            Dim qtAppObj
            Dim sf = New SupportFunction
            kilUft = False
            If sf.isProcessRunning("uft.exe") = True Then
                qtAppObj = CreateObject("quicktest.application")
                qtAppObj.Test.Stop
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] Current execution is STOPPED by the user."))
                b_runUft.Enabled = True
                b_batchRun.Enabled = True
                tb_ctDriver.Enabled = True
                tb_executionInfo.Enabled = True
                b_browseDriver.Enabled = True
                b_browseExecutionInfo.Enabled = True
            Else
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] WARNING [Stop]: No execution is found."))
            End If
        Catch
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] WARNING [Stop]: " & Err.Description))
        End Try
    End Sub

    Private Sub b_killUft_Click(sender As Object, e As EventArgs) Handles b_killUft.Click
        sf.killProcess("uft.exe")
        rtb_logs.AppendText(vbNewLine & ("[" & Now & "] UFT is CLOSED by the user."))
        b_runUft.Enabled = True
        b_batchRun.Enabled = True
        tb_ctDriver.Enabled = True
        tb_executionInfo.Enabled = True
        b_browseDriver.Enabled = True
        b_browseExecutionInfo.Enabled = True
    End Sub


    Private Sub bw_runUft_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_runUft.DoWork
        b_runUft.Enabled = False
        b_batchRun.Enabled = False
        tb_ctDriver.Enabled = False
        tb_executionInfo.Enabled = False
        b_browseDriver.Enabled = False
        b_browseExecutionInfo.Enabled = False

        sf.runUFTScript()
        'rtb_logs.Appendtext( vbNewLine & ("[" & Now & "] Current Execution Completed.")
        'Close Driver and UFT
        Call sf.closeUFTScript()
        If kilUft = True Then
            Call sf.killProcess("uft.exe")
        End If

        'Retain existing ExecutionInfo.xml
        If sf.isfileExist(fwInstallPath & "\metadata\" & orgExeInfoXmlName) Then
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Removing temporary ExecutionInfo.xml."))
            Call sf.deleteFile(coreExeInfo, rtb_logs)
            Call sf.moveFile(fwInstallPath & "\metadata\" & orgExeInfoXmlName, coreExeInfo, rtb_logs)
        End If

        rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Tearing-down UFT instance."))
        rtb_logs.AppendText(vbNewLine & ("[" & Now & "] CURRENT EXECUTION COMPLETED...!!"))
        rtb_logs.AppendText(vbNewLine & ("|*******************************************************************************|"))

        b_runUft.Enabled = True
        b_batchRun.Enabled = True
        tb_ctDriver.Enabled = True
        tb_executionInfo.Enabled = True
        b_browseDriver.Enabled = True
        b_browseExecutionInfo.Enabled = True

        If My.Application.CommandLineArgs.Count > 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub rtb_logs_TextChanged(sender As Object, e As EventArgs) Handles rtb_logs.TextChanged
        rtb_logs.SelectionStart = rtb_logs.TextLength
        rtb_logs.ScrollToCaret()
    End Sub

    Private Sub b_pause_MouseHover(sender As Object, e As EventArgs) Handles b_pause.MouseHover
        tt_execution.SetToolTip(b_pause, "Pause current Execution")
    End Sub

    Private Sub b_killUft_MouseHover(sender As Object, e As EventArgs) Handles b_killUft.MouseHover
        tt_execution.SetToolTip(b_killUft, "Close UFT")
    End Sub

    Private Sub b_runUft_MouseHover(sender As Object, e As EventArgs) Handles b_runUft.MouseHover
        tt_execution.SetToolTip(b_runUft, "Run CT_Driver")
    End Sub

    Private Sub b_stop_MouseHover(sender As Object, e As EventArgs) Handles b_stop.MouseHover
        tt_execution.SetToolTip(b_stop, "Stop current Execution")
    End Sub

    Private Sub b_batchRun_MouseHover(sender As Object, e As EventArgs) Handles b_batchRun.MouseHover
        tt_execution.SetToolTip(b_batchRun, "Run CT_Driver in batch mode")
    End Sub

    Private Sub b_continue_MouseHover(sender As Object, e As EventArgs) Handles b_continue.MouseHover
        tt_execution.SetToolTip(b_continue, "Resume current Execution")
    End Sub

    Private Sub b_browseDriver_Click(sender As Object, e As EventArgs) Handles b_browseDriver.Click
        If fbd_ctDriver.ShowDialog() = DialogResult.OK Then
            tb_ctDriver.Text = fbd_ctDriver.SelectedPath
        End If
    End Sub

    Private Sub b_browseExecutionInfo_Click(sender As Object, e As EventArgs) Handles b_browseExecutionInfo.Click
        ofd_executionInfo.FileName = tb_executionInfo.Text
        If ofd_executionInfo.ShowDialog() = DialogResult.OK Then
            tb_executionInfo.Text = ofd_executionInfo.FileName
        End If
    End Sub

    Private Sub tb_ctDriver_TextChanged(sender As Object, e As EventArgs) Handles tb_ctDriver.TextChanged
        Dim temp As String = ""
        For i = 0 To (UBound(Split(tb_ctDriver.Text, "\")) - 1)
            temp = temp & "\" & Split(tb_ctDriver.Text, "\")(i)
        Next

        fwInstallPath = Replace(temp, "\", "", 1, 1)
        coreDriver = Trim(tb_ctDriver.Text)
        coreExeInfo = fwInstallPath & "\metadata\ExecutionInfo.xml"
        tb_executionInfo.Text = coreExeInfo
    End Sub

    Private Sub b_batchRun_Click(sender As Object, e As EventArgs) Handles b_batchRun.Click
        Try
            Dim arguments = My.Application.CommandLineArgs
            Dim preCondFlag As Boolean = True
            kilUft = True
            b_runUft.Enabled = False
            b_batchRun.Enabled = False
            tb_ctDriver.Enabled = False
            tb_executionInfo.Enabled = False
            b_browseDriver.Enabled = False
            b_browseExecutionInfo.Enabled = False

            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Using CT Driver: " & coreDriver))

            '----------------------------------
            'Precondition Checks
            '----------------------------------
            '1. DriverPath Empty or not found
            If coreDriver = "" Or Not (sf.doesFolderExists(coreDriver)) Then
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "ERROR: CT Driver path [" & coreDriver & "] is empty or does not exist. Stopping the execution."))
                preCondFlag = False
            End If

            If preCondFlag Then
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Starting UFT execution."))
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Tear-down existing UFT instances."))
                Call sf.killProcess("uft.exe")
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Launching new UFT instance using " & coreDriver))
                'Launch UFT with the Driver
                sf.launchUFTAndTest(coreDriver)
                bw_batchRun.RunWorkerAsync()
            Else
                If My.Application.CommandLineArgs.Count > 0 Then
                    Me.Close()
                End If
            End If
        Catch
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & Err.Description & "."))
            If My.Application.CommandLineArgs.Count > 0 Then
                Me.Close()
            End If
        End Try
        b_runUft.Enabled = True
        b_batchRun.Enabled = True
        tb_ctDriver.Enabled = True
        tb_executionInfo.Enabled = True
        b_browseDriver.Enabled = True
        b_browseExecutionInfo.Enabled = True
    End Sub

    Private Sub bw_batchRun_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw_batchRun.DoWork
        Dim thisExeInfoFilePath : thisExeInfoFilePath = ""
        Dim dictInfo As DirectoryInfo = New DirectoryInfo(fwInstallPath & "\metadata\batchRun\work")
        Dim filesInWork As FileInfo() = dictInfo.GetFiles()
        Dim fileInWork As FileInfo
        b_runUft.Enabled = False
        b_batchRun.Enabled = False
        tb_ctDriver.Enabled = False
        tb_executionInfo.Enabled = False
        b_browseDriver.Enabled = False
        b_browseExecutionInfo.Enabled = False

        For Each fileInWork In filesInWork
            If UCase(sf.getExtensionName(fileInWork.FullName, rtb_logs)) = "XML" Or UCase(sf.getExtensionName(fileInWork.FullName, rtb_logs)) = "INI" Then
                thisExeInfoFilePath = fileInWork.FullName
                'Step 1 : Take backup of existing ExecutionInfo.xml file
                If sf.isfileExist(coreExeInfo) Then
                    rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Taking backup of existing ExecutionInfo.xml File. [" & fwInstallPath & "\metadata\" & orgExeInfoXmlName & "]"))
                    Call sf.moveFile(coreExeInfo, fwInstallPath & "\metadata\" & orgExeInfoXmlName, rtb_logs)
                End If

                'Step 2 : Check if the input file is XML or not. If XML then use AS IS else convert it to XML
                If UCase(sf.getExtensionName(thisExeInfoFilePath, rtb_logs)) = "XML" Then
                    'New ExecutionInfo is an XML. Use as is.
                    rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Copying [" & thisExeInfoFilePath & "] to [" & coreExeInfo & "]"))
                    Call sf.copyFile(thisExeInfoFilePath, coreExeInfo, rtb_logs)
                Else
                    'New file is not XML. Covert it to XML and then use it.
                    rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & thisExeInfoFilePath & " is not XML file. Converting it to ExecutionInfo.xml"))
                    Call sf.createExecutionInfoXml(thisExeInfoFilePath, coreExeInfo)
                End If

                'Step 3 : Move file from WORK to BUSY folder
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Moving [" & thisExeInfoFilePath & "] from work to busy directory."))
                Call sf.moveFile(thisExeInfoFilePath, fwInstallPath & "\metadata\batchRun\busy\" & fileInWork.Name, rtb_logs)

                'Step 4 : Run the Driver
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "[" & thisExeInfoFilePath & "] Execution started."))
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "[" & thisExeInfoFilePath & "] Check UFT console for the execution progress."))
                sf.runUFTScript()

                'Step 5 : Retain existing ExecutionInfo.xml
                If sf.isfileExist(fwInstallPath & "\metadata\" & orgExeInfoXmlName) Then
                    rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Removing temporary ExecutionInfo.xml."))
                    Call sf.deleteFile(coreExeInfo, rtb_logs)
                    Call sf.moveFile(fwInstallPath & "\metadata\" & orgExeInfoXmlName, coreExeInfo, rtb_logs)
                End If

                'Step 6 : Move file from BUSY to DONE
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Moving [" & thisExeInfoFilePath & "] from work to busy directory."))
                Call sf.moveFile(fwInstallPath & "\metadata\batchRun\busy\" & fileInWork.Name, fwInstallPath & "\metadata\batchRun\done\" & fileInWork.Name, rtb_logs)
                rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "[" & thisExeInfoFilePath & "] Execution Completed."))
                rtb_logs.AppendText(vbNewLine & ("|*******************************************************************************|"))
            End If
        Next

        'Step 7 : Close Driver and UFT
        Call sf.closeUFTScript()
        If kilUft = True Then
            Call sf.killProcess("uft.exe")
        End If

        rtb_logs.AppendText(vbNewLine & ("[" & Now & "] " & "Tearing-down UFT instance."))
        rtb_logs.AppendText(vbNewLine & ("[" & Now & "] CURRENT BATCH EXECUTION COMPLETED...!!"))
        rtb_logs.AppendText(vbNewLine & ("|*******************************************************************************|"))

        b_runUft.Enabled = True
        b_batchRun.Enabled = True
        tb_ctDriver.Enabled = True
        tb_executionInfo.Enabled = True
        b_browseDriver.Enabled = True
        b_browseExecutionInfo.Enabled = True

        If My.Application.CommandLineArgs.Count > 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub b_encryptForIni_Click(sender As Object, e As EventArgs) Handles b_encrypt.Click
        Dim enc As Encryption = New Encryption
        Dim x As Xml = New Xml
        Dim input As String() = Split(rtb_credentials.Text, vbLf)

        rtb_credentials.ReadOnly = True
        rtb_encryptedCredIni.Clear()
        rtb_encryptedCredXml.Clear()

        For i = 0 To UBound(input)
            If rtb_encryptedCredIni.TextLength = 0 Then
                rtb_encryptedCredIni.AppendText(enc.encrypt(input(i)))
            Else
                rtb_encryptedCredIni.AppendText(vbLf & enc.encrypt(input(i)))
            End If

            If rtb_encryptedCredXml.TextLength = 0 Then
                rtb_encryptedCredXml.AppendText(x.encodeXmlSpecialChars(enc.encrypt(input(i))))
            Else
                rtb_encryptedCredXml.AppendText(vbLf & x.encodeXmlSpecialChars(enc.encrypt(input(i))))
            End If
        Next
    End Sub

    Private Sub b_resetAll_Click(sender As Object, e As EventArgs) Handles b_resetAll.Click
        rtb_credentials.Clear()
        rtb_credentials.ReadOnly = False
        rtb_encryptedCredIni.Clear()
        rtb_encryptedCredXml.Clear()

    End Sub

    Private Sub b_insertCred_Click(sender As Object, e As EventArgs) Handles b_insertCred.Click
        If Not (String.IsNullOrWhiteSpace(Trim(tb_credential.Text))) Then
            If rtb_credentials.TextLength = 0 Then
                rtb_credentials.AppendText(tb_credential.Text)
            Else
                rtb_credentials.AppendText(vbLf & tb_credential.Text)
            End If
        End If

        tb_credential.Clear()
    End Sub

    Private Sub tb_credential_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_credential.KeyPress
        If e.KeyChar = Chr(13) Then
            Call b_insertCred_Click(sender, e)

        End If
    End Sub

    Private Sub b_Updates_browseInstallPath_Click(sender As Object, e As EventArgs) Handles b_Updates_browseUpdatePath.Click
        If fbd_ctDriver.ShowDialog() = DialogResult.OK Then
            tb_Updates_updatePath.Text = fbd_ctDriver.SelectedPath
        End If
    End Sub

    Private Sub b_Updates_install_Click(sender As Object, e As EventArgs) Handles b_Updates_install.Click

        Dim sf As SupportFunction = New SupportFunction
        Dim gt As Git = New Git
        Dim assemble As Assembly = New Assembly
        Dim installDir As String = tb_Updates_InstallPath.Text
        Dim tempFolderPath As String = Path.GetTempPath() & "CTAF_" & sf.sEdit_TimeStamp()
        Dim gitUrl As String = "https://git.rabobank.nl/scm/ra/rabo_ctaf_v3.git"

        Try
            'Step 1: Folder should not be blank
            'If (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\GitForWindows", "InstallPath", Nothing)) Is Nothing Then
            '    MsgBox("ERROR: GIT is not installed. Kindly install git and try again.")
            '    Exit Sub
            'End If

            If String.IsNullOrWhiteSpace(installDir) Then
                MsgBox("ERROR: Installation path is not entered.")
                Exit Sub
            End If

            If Not (Directory.Exists(installDir)) Then
                MsgBox("ERROR: Installation Path does not exist. [" & installDir & "]")
                Exit Sub
            End If

            If Directory.Exists(installDir & "\RABO CTAF") Then
                MsgBox("ERROR: Framework already exists. [" & installDir & "\RABO CTAF]")
                Exit Sub
            End If

            'Step 2: Download the framework
            Call gt.donwloadRepository(gitUrl, tempFolderPath)

            'Step 3: Move FW to Given Path
            If Directory.Exists(tempFolderPath) Then
                If (Directory.GetDirectories(tempFolderPath).Length = 0) Then
                    MsgBox("ERROR: It seems GIT is not installed. Kindly install GIT and try again.")
                    Exit Sub
                End If
            Else
                MsgBox("ERROR: It seems GIT is not installed. Kindly install GIT and try again.")
                Exit Sub
            End If

            'Copy temporary fw to installation path
            'My.Computer.FileSystem.MoveDirectory(tempFolderPath, installDir & "\RABO CTAF")
            My.Computer.FileSystem.CopyDirectory(tempFolderPath, installDir & "\RABO CTAF")

            'Load Assemblies
            Dim folders As String() = Directory.GetDirectories(installDir & "\RABO CTAF")
            Dim files As String()
            For i = 0 To UBound(folders)
                If InStr(folders(i), "CT_Driver", CompareMethod.Text) > 0 Then
                    files = Directory.GetFiles(folders(i) & "\root\bin")
                    For j = 0 To UBound(files)
                        If UCase(sf.getExtensionName(files(j), rtb_logs)) = "DLL" Then
                            Call assemble.loadAssembly(files(j))
                        End If
                    Next
                End If
            Next

            MsgBox("SUCCESS: Framework Installation is Successful.")
        Catch ex As Exception
            MsgBox("ERROR: Framework Installation Failed." & ex.Message)
        Finally
            If Directory.Exists(tempFolderPath) Then
                Directory.Delete(tempFolderPath, True)
            End If
        End Try
    End Sub

    Private Sub b_Updates_browseInstallPath_Click_1(sender As Object, e As EventArgs) Handles b_Updates_browseInstallPath.Click
        If fbd_ctDriver.ShowDialog() = DialogResult.OK Then
            tb_Updates_InstallPath.Text = fbd_ctDriver.SelectedPath
        End If
    End Sub

    Private Sub b_Updates_update_Click(sender As Object, e As EventArgs) Handles b_Updates_update.Click

        Dim sf As SupportFunction = New SupportFunction
        Dim gt As Git = New Git
        Dim assemble As Assembly = New Assembly
        Dim installDir As String = tb_Updates_updatePath.Text
        Dim tempFolderPath As String = Path.GetTempPath() & "CTAF_" & sf.sEdit_TimeStamp()
        Dim gitUrl As String = "https://git.rabobank.nl/scm/ra/rabo_ctaf_v3.git"
        Dim currDirUpdate As String = ""
        Dim currDirUpdateName As String = ""
        Dim updateTools As Boolean = False

        Try
            'Step 1: Folder should not be blank
            'If (My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\GitForWindows", "InstallPath", Nothing)) Is Nothing Then
            '    MsgBox("ERROR: GIT is not installed. Kindly install git and try again.")
            '    Exit Sub
            'End If

            If String.IsNullOrWhiteSpace(installDir) Then
                MsgBox("ERROR: Installation path is not entered.")
                Exit Sub
            End If

            If Not (Directory.Exists(installDir)) Then
                MsgBox("ERROR: Installation Path does not exist. [" & installDir & "]")
                Exit Sub
            End If

            'Step 2: Download the framework
            Call gt.donwloadRepository(gitUrl, tempFolderPath)

            'Step 3: Move FW to Given Path
            If Directory.Exists(tempFolderPath) Then
                If (Directory.GetDirectories(tempFolderPath).Length = 0) Then
                    MsgBox("ERROR: It seems GIT is not installed. Kindly install GIT and try again.")
                    Exit Sub
                End If
            Else
                MsgBox("ERROR: It seems GIT is not installed. Kindly install GIT and try again.")
                Exit Sub
            End If

            'Step 4[A]: Update the Framework folders [CT_Driver, supportApps, Help, Execution, Metadata, Resources-proj]
            For i = 0 To (clb_framework.Items.Count - 1)
                If clb_framework.GetItemChecked(i) Then
                    If UCase(clb_framework.Items(i).ToString) = "TOOLS" Then
                        updateTools = True
                    Else
                        currDirUpdate = Directory.GetDirectories(tempFolderPath, UCase(clb_framework.Items(i).ToString) & "*")(0)
                        currDirUpdateName = Split(currDirUpdate, "\")(UBound(Split(currDirUpdate, "\")))
                        'Delete the directory from installDir if exists
                        If Directory.Exists(installDir & "\" & currDirUpdateName) Then
                            Directory.Delete(installDir & "\" & currDirUpdateName, True)
                        End If

                        'Move the directory from donwloaded folder to installDir
                        My.Computer.FileSystem.CopyDirectory(currDirUpdate, installDir & "\" & currDirUpdateName)
                    End If
                End If
            Next

            ''Step 4[B]: Load Assemblies.
            Dim folders As String() = Directory.GetDirectories(installDir)
            Dim files As String()
            For i = 0 To UBound(folders)
                If InStr(folders(i), "CT_Driver", CompareMethod.Text) > 0 Then
                    If Directory.Exists(folders(i) & "\root\bin") Then
                        files = Directory.GetFiles(folders(i) & "\root\bin")
                        For j = 0 To UBound(files)
                            If UCase(sf.getExtensionName(files(j), rtb_logs)) = "DLL" Then
                                Call assemble.loadAssembly(files(j))
                            End If
                        Next
                    End If
                End If
            Next

            'Step 4[C]: Update the FrameworkHistory.txt file.
            If File.Exists(installDir & "\VersionHistory.txt") Then
                File.Delete(installDir & "\VersionHistory.txt")
            End If
            My.Computer.FileSystem.CopyFile(tempFolderPath & "\VersionHistory.txt", installDir & "\VersionHistory.txt")

            'Step 4[D]: Update the Tools.
            If updateTools Then
                currDirUpdate = Directory.GetDirectories(tempFolderPath, "Tools*")(0)
                currDirUpdateName = Split(currDirUpdate, "\")(UBound(Split(currDirUpdate, "\")))

                Dim cmd As String = "ECHO Wait for few Seconds...!" &
                           " & timeout 3" &
                           " & CSCRIPT " & Chr(34) & Path.GetTempPath() & "ctafToolsUpdate.vbs" & Chr(34) &
                           " & " & Chr(34) & installDir & "\" & currDirUpdateName & "\CtafLaunchpad.exe" & Chr(34) & vbNewLine &
                           " & exit"

                Dim vbCmd As String = "myfolder = " & Chr(34) & installDir & "\" & currDirUpdateName & Chr(34) & vbNewLine &
                                        "openFlag = False " & vbNewLine &
                                        "Set shl = CreateObject(" & Chr(34) & "shell.application" & Chr(34) & ")" & vbNewLine &
                                        "'Step 1: Close the opened (tool) folder" & vbNewLine &
                                        "For Each docItem In shl.Windows" & vbNewLine &
                                            "If uCase(docItem.name) = " & Chr(34) & "WINDOWS EXPLORER" & Chr(34) & " Then" & vbNewLine &
                                                "If uCase(docItem.document.folder.self.Path) = uCase(myfolder) Then" & vbNewLine &
                                                    "docItem.Quit()" & vbNewLine &
                                                    "openFlag = True" & vbNewLine &
                                                "End If" & vbNewLine &
                                            "End If" & vbNewLine &
                                        "Next" & vbNewLine &
                                        "CreateObject(" & Chr(34) & "WScript.Shell" & Chr(34) & ").run " & Chr(34) & "cmd.exe /K RMDIR /S/Q " & Chr(34) & Chr(34) & installDir & "\" & currDirUpdateName & Chr(34) & Chr(34) &
                                        " & XCOPY " & Chr(34) & Chr(34) & currDirUpdate & "\*" & Chr(34) & Chr(34) & " " & Chr(34) & Chr(34) & installDir & "\" & currDirUpdateName & "\*" & Chr(34) & Chr(34) & " /Y " &
                                        " & RMDIR /S/Q " & Chr(34) & Chr(34) & tempFolderPath & Chr(34) & Chr(34) &
                                        " & CLS" &
                                        " & ECHO *************************************" &
                                        " & ECHO *   FRAMEWORK UPDATE IS SUCCESSFUL  *" &
                                        " & ECHO *************************************" &
                                        " & pause & Exit" & Chr(34) & vbNewLine &
                                        "WScript.sleep 3000" & vbNewLine &
                                        "If openFlag Then" & vbNewLine &
                                        "shl.open " & Chr(34) & installDir & "\" & currDirUpdateName & Chr(34) & vbNewLine &
                                        "End If"
                File.WriteAllText(Path.GetTempPath() & "ctafToolsUpdate.vbs", vbCmd)
                Shell("cmd.exe /k " & cmd, AppWinStyle.NormalFocus)
                Me.Close()
            End If
            MsgBox("SUCCESS: Framework Update is Successful.")
        Catch ex As Exception
            MsgBox("ERROR: Framework Update Failed." & ex.Message)
        End Try
    End Sub

    Private Sub tb_Updates_InstallPath_TextChanged(sender As Object, e As EventArgs) Handles tb_Updates_InstallPath.TextChanged
        l_Updates_fwInstaNote.Text = "Note : Framework will be installed at [" & tb_Updates_InstallPath.Text & "\RABO CTAF]"
    End Sub

    Private Sub ExecutionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecutionToolStripMenuItem.Click
        t_global.SelectTab("Help")
        pb_help.Image = My.Resources.Execution
    End Sub

    Private Sub InstallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallToolStripMenuItem.Click
        t_global.SelectTab("Help")
        pb_help.Image = My.Resources.install
    End Sub

    Private Sub UpdateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem1.Click
        t_global.SelectTab("Help")
        pb_help.Image = My.Resources.Update
    End Sub

    Private Sub DownloadProjectResourcesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadProjectResourcesToolStripMenuItem.Click
        t_global.SelectTab("Help")
        pb_help.Image = My.Resources.DownloadProjectRes
    End Sub

    Private Sub EncryptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncryptionToolStripMenuItem.Click
        t_global.SelectTab("Help")
        pb_help.Image = My.Resources.Encryption
    End Sub

    Private Sub ExecutionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExecutionToolStripMenuItem1.Click
        t_global.SelectTab("Execution")
    End Sub

    Private Sub UpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatesToolStripMenuItem.Click
        t_global.SelectTab("Updates")
    End Sub

    Private Sub EncryptionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EncryptionToolStripMenuItem1.Click
        t_global.SelectTab("Encryption")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Dim abtUs As AboutBox = New AboutBox

        'abtUs.Parent = Me
        abtUs.StartPosition = FormStartPosition.CenterParent
        abtUs.ShowDialog()

    End Sub

    Private Sub clb_framework_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_framework.SelectedIndexChanged
        'Dim text As String = ""

        'For i = 0 To (clb_framework.Items.Count - 1)
        '    If clb_framework.GetItemChecked(i) Then
        '        text = text & UCase(clb_framework.Items(i).ToString) & vbNewLine
        '    End If
        'Next
        'l_updates_checkedFolders.Text = text
    End Sub
End Class

Public Class SupportFunction
    '################################################################################################
    '#SUPPORTING FUNCTIONS
    '################################################################################################
    '************************************************************************************************
    '* Function Name: launchUFTAndTest
    '* Objective	: Launch UFT and a Test
    '* Author		: GD
    '* Date			: 22-Nov-2017
    '* Last Modified: 
    '************************************************************************************************
    Function launchUFTAndTest(ByVal scriptPathInLocal As String)
        Dim qtApp

        'Create the QTP Application object
        qtApp = CreateObject("QuickTest.Application")

        'If QTP is notopen then open it
        If qtApp.launched <> True Then
            qtApp.Launch
        End If

        'Make the QuickTest application visible
        qtApp.Visible = False
        'Set QuickTest run options
        'Instruct QuickTest to perform next step when error occurs

        qtApp.Options.Run.ImageCaptureForTestResults = "OnError"
        qtApp.Options.Run.RunMode = "Fast"
        qtApp.Options.Run.ViewResults = False

        'Open the test in read-only mode
        qtApp.Open(scriptPathInLocal, True)
    End Function

    '************************************************************************************************
    '* Function Name: runUFTScript
    '* Objective	: Run UFT Test
    '* Author		: GD
    '* Date			: 22-Nov-2017
    '* Last Modified: 
    '************************************************************************************************
    Function runUFTScript()
        Dim qtApp = CreateObject("QuickTest.Application")
        qtApp.Test.Settings.Run.OnError = "NextStep"
        qtApp.Test.Run
    End Function

    '************************************************************************************************
    '* Function Name: closeUFTScript
    '* Objective	: Cloase UFT Test and UFT app object
    '* Author		: GD
    '* Date			: 22-Nov-2017
    '* Last Modified: 
    '************************************************************************************************
    Function closeUFTScript()
        Dim qtApp = CreateObject("QuickTest.Application")
        qtApp.Quit
    End Function


    '************************************************************************************************
    '* Function Name: killProcess
    '* Objective	: Kills the process by appName
    '* Author		: GD
    '* Date			: 22-Nov-2017
    '* Last Modified: 
    '************************************************************************************************
    Function killProcess(appName)
        Dim objService, Process
        objService = GetObject("winmgmts:")
        On Error Resume Next
        For Each Process In objService.InstancesOf("Win32_process")
            If UCase(Process.Name) = UCase(appName) Then
                Process.Terminate
                System.Threading.Thread.Sleep(3)
            End If
        Next
        On Error GoTo 0
    End Function

    '************************************************************************************************
    '* Function Name: isProcessRunning
    '* Objective	: Kills the process by appName
    '* Author		: GD
    '* Date			: 22-Nov-2017
    '* Last Modified: 
    '************************************************************************************************
    Function isProcessRunning(appName) As Boolean
        Dim objService, Process
        objService = GetObject("winmgmts:")
        On Error Resume Next
        For Each Process In objService.InstancesOf("Win32_process")
            If UCase(Process.Name) = UCase(appName) Then
                isProcessRunning = True
                Exit Function
            End If
        Next
        isProcessRunning = False
        On Error GoTo 0
    End Function

    '************************************************************************************************
    '* Function Name: doesFolderExists
    '* Objective	: checks whether the folder exists or not
    '* Author		: GD
    '* Date			: 22-Nov-2017
    '* Last Modified: 
    '************************************************************************************************
    Function doesFolderExists(MyFolder)
        Dim fso
        fso = CreateObject("Scripting.FileSystemObject")
        Dim doesExist

        doesExist = fso.FolderExists(MyFolder)
        doesFolderExists = doesExist

    End Function

    '************************************************************************************************
    '* Function Name: createExecutionInfoXml
    '* Objective	: Creates ExecutionInfo.xml using executionInfo.ini file
    '* Author		: GD
    '* Date			: 22-Nov-2017
    '* Last Modified: 
    '************************************************************************************************
    Function createExecutionInfoXml(sourceFile, destFile)
        Dim fso As Object
        Dim ofso As Object
        Dim xf As Xml = New Xml
        fso = CreateObject("Scripting.FileSystemObject")
        ofso = fso.OpenTextFile(sourceFile, 1)
        Dim data : data = "<?xml version='1.0'?><CtafIni><Envt name='' runFlag='ON'><ExeInfos><ExeInfo name='BATCH-RUN'>"
        Dim x : x = ""
        Dim temp : temp = ""
        Do While ofso.AtEndOfStream <> True
            temp = ofso.ReadLine()
            If Mid(Trim(Replace(temp, vbTab, "")), 1, 2) <> "/*" And Mid(Trim(Replace(temp, vbTab, "")), 1, 2) <> "" Then
                If UBound(Split(temp, "=", 2)) = 1 Then
                    x = "<" & Trim(Split(temp, "=", 2)(0)) & ">" & xf.encodeXmlSpecialChars(Trim(Split(temp, "=", 2)(1))) & "</" & Trim(Split(temp, "=", 2)(0)) & ">"
                Else
                    x = "</" & Trim(Split(temp, "=", 2)(0)) & "/>"
                End If
            End If
            data = data & x
            x = ""
            temp = ""
        Loop
        data = data & "</ExeInfo></ExeInfos></Envt></CtafIni>"
        ofso.close
        ofso = fso.CreateTextFile(destFile, True)
        ofso.Write(data)
        ofso.close

        fso = Nothing
    End Function
    '************************************************************************************************
    '* Function Name: sEdit_TimeStamp
    '* Objective	: Creates a unique timestamp 
    '* Author		: GD
    '* Date			: 22-Nov-2017
    '* Last Modified: 
    '************************************************************************************************
    Function sEdit_TimeStamp()
        Dim datetoday As Date
        Dim strDay As String
        Dim strMonth As String
        Dim strYear As String
        Dim strHour As String
        Dim strMinute As String
        Dim strSecond As String
        Dim daytoday As String

        'Create TimeStamp 
        datetoday = Now
        strDay = DateAndTime.Day(datetoday)
        If strDay < 10 Then
            strDay = "0" & strDay
        End If

        strMonth = Month(datetoday)
        If strMonth < 10 Then
            strMonth = "0" & strMonth
        End If

        strYear = Year(datetoday)

        strHour = Hour(datetoday)
        If strHour < 10 Then
            strHour = "0" & strHour
        End If

        strMinute = Minute(datetoday)
        If strMinute < 10 Then
            strMinute = "0" & strMinute
        End If

        strSecond = Second(datetoday)
        If strSecond < 10 Then
            strSecond = "0" & strSecond
        End If

        daytoday = strDay & strMonth & strYear & "_" & strHour & strMinute & strSecond
        'timetoday =  strHour&"Hrs" & "_" & strMinute&"Min" & "_" & strSecond&"Sec"
        sEdit_TimeStamp = daytoday
    End Function

    Function userAction(ByVal rtb_logs As RichTextBox)
        rtb_logs.AppendText(vbNewLine & ("Enter any key to continue"))
        Console.Read()
    End Function

    Function isfileExist(ByVal Path)
        Dim fsoUftRun : fsoUftRun = CreateObject("Scripting.FileSystemObject")
        isfileExist = fsoUftRun.FileExists(Path)
        fsoUftRun = Nothing
    End Function

    Function moveFile(ByVal source As String, ByVal dest As String, ByVal rtb_logs As RichTextBox)
        Dim fsoUftRun : fsoUftRun = CreateObject("Scripting.FileSystemObject")
        On Error Resume Next
        Call fsoUftRun.moveFile(source, dest)

        If Err.Number = 0 Then
            moveFile = True
        Else
            moveFile = False
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] ERROR: [Func-moveFile]" & Err.Description))
        End If
        fsoUftRun = Nothing
        Err.Clear()
        On Error GoTo 0
    End Function

    Function copyFile(ByVal source As String, ByVal dest As String, ByVal rtb_logs As RichTextBox)
        Dim fsoUftRun : fsoUftRun = CreateObject("Scripting.FileSystemObject")
        On Error Resume Next
        Call fsoUftRun.copyfile(source, dest)
        If Err.Number = 0 Then
            copyFile = True
        Else
            copyFile = False
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] ERROR: [Func-copyFile]" & Err.Description))
        End If
        fsoUftRun = Nothing
        Err.Clear()
        On Error GoTo 0
    End Function

    Function deleteFile(ByVal file As String, ByVal rtb_logs As RichTextBox)
        Dim fsoUftRun : fsoUftRun = CreateObject("Scripting.FileSystemObject")
        Dim idx
        On Error Resume Next
        Call fsoUftRun.deleteFile(file, True)

        For idx = 0 To 5
            System.Threading.Thread.Sleep(5)
            If isfileExist(file) Then
                Call fsoUftRun.deleteFile(file, True)
            Else
                Exit For
            End If
        Next

        If Err.Number = 0 Then
            deleteFile = True
        Else
            deleteFile = False
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] ERROR: [Func-deleteFile]" & Err.Description))
        End If
        fsoUftRun = Nothing
        Err.Clear()
        On Error GoTo 0
    End Function

    Function getExtensionName(ByVal path As String, ByVal rtb_logs As RichTextBox) As String
        Dim fsoUftRun : fsoUftRun = CreateObject("Scripting.FileSystemObject")
        Dim extension As String
        On Error Resume Next
        extension = fsoUftRun.getExtensionName(path)
        If Err.Number = 0 Then
            getExtensionName = extension
        Else
            getExtensionName = ""
            rtb_logs.AppendText(vbNewLine & ("[" & Now & "] ERROR: [Func-getExtensionName]" & Err.Description))
        End If
        fsoUftRun = Nothing
        Err.Clear()
        On Error GoTo 0
    End Function
End Class

Public Class Encryption
    Function encryptionPrecondition(inputString As String) As String
        Dim outString

        outString = inputString
        'Replace all horizontal Tabs
        outString = Replace(outString, Chr(9), "")

        'Replace all New Lines
        outString = Replace(outString, Chr(10), "")

        'Replace all blanks
        outString = Replace(outString, Chr(32), "")

        encryptionPrecondition = outString
    End Function

    Function encrypt(p_pwd)
        Dim lenPwd
        Dim i
        Dim j
        Dim tempPwd
        Dim encryptedPwd
        Dim encryptRandom
        Dim sampleKey
        Dim currChar
        Dim encryptAscii

        On Error Resume Next
        sampleKey = 377

        If (p_pwd = "" Or String.IsNullOrEmpty(p_pwd)) Then
            encryptedPwd = ""
        Else
            p_pwd = Trim(p_pwd)
            tempPwd = ""

            For i = 1 To Len(p_pwd)
                'fetch the Charachter
                currChar = Mid(p_pwd, i, 1)

                'find Ascii of the char
                encryptRandom = (Asc(currChar) - 32) + (sampleKey * i) + i
                '-----------------------------------
                If (encryptRandom Mod 93) = 0 Then
                    encryptAscii = (93 + 32)
                Else
                    encryptAscii = (encryptRandom Mod 93 + 32)
                End If

                tempPwd = tempPwd & Chr(encryptAscii)

            Next
            encryptedPwd = Chr(126) & StrReverse(tempPwd) 'Add encryption prefix and reverse the encrypted password.
        End If
        On Error GoTo 0
        encrypt = encryptedPwd
    End Function
    Function decrypt(p_pwd)
        Dim lenPwd
        Dim i
        Dim j
        Dim tempPwd
        Dim decryptedPwd
        Dim pwd
        Dim decryptAscii
        Dim decryptRandom
        Dim sampleKey
        Dim currChar

        On Error Resume Next
        sampleKey = 377
        If (p_pwd = "" Or String.IsNullOrEmpty(p_pwd)) Then
            decryptedPwd = ""
        Else
            If Asc(Mid(Trim(p_pwd), 1, 1)) = 126 Then
                p_pwd = Replace(p_pwd, Chr(126), "") 'Remove the encryption prefix
                pwd = StrReverse(p_pwd)
                tempPwd = ""
                lenPwd = Len(pwd)

                For i = 1 To lenPwd
                    'fetch the Charachter
                    currChar = Mid(pwd, i, 1)
                    '--------------------------------
                    'find Ascii of the char
                    'If Asc(currChar) < 94 Then
                    If Asc(currChar) < 125 Then
                        decryptRandom = (Asc(currChar) + 93 - 32)
                        decryptAscii = (decryptRandom + 32) - (sampleKey * i) - i

                        If decryptAscii > 125 Then
                            decryptAscii = decryptAscii Mod 93
                            If (decryptAscii) = 0 Then
                                decryptAscii = (93 + 32)
                            Else
                                Do While (decryptAscii < 33)
                                    decryptAscii = decryptAscii + 93
                                Loop
                                'If decryptAscii < 33 Then
                                '    decryptAscii = (decryptAscii + 94)
                                'End If
                            End If
                        Else
                            Do While (decryptAscii < 33)
                                decryptAscii = decryptAscii + 93
                            Loop
                            'If decryptAscii < 33 Then
                            '   decryptAscii = decryptAscii + 94
                            'End If
                        End If

                    Else
                        decryptRandom = Asc(currChar)
                        decryptAscii = decryptRandom - (sampleKey * i) - i

                        If decryptAscii > 125 Then
                            decryptAscii = decryptAscii Mod 93
                        Else
                            Do While (decryptAscii < 33)
                                decryptAscii = decryptAscii + 93
                            Loop
                            'If decryptAscii < 33 Then
                            '    decryptAscii = decryptAscii + 94
                            'End If
                        End If
                    End If
                    tempPwd = tempPwd & Chr(decryptAscii)
                    '--------------------------------
                Next
                decryptedPwd = tempPwd
            Else
                decryptedPwd = p_pwd
            End If
        End If
        On Error GoTo 0
        decrypt = decryptedPwd
    End Function

End Class

Public Class Xml
    Function encodeXmlSpecialChars(ByVal str)
        If Not (Trim(str) = "" Or String.IsNullOrEmpty(str)) Then
            str = Replace(str, "&", "&amp;")
            str = Replace(str, "<", "&lt;")
            str = Replace(str, ">", "&gt;")
            str = Replace(str, Chr(34), "&quot;")
            str = Replace(str, "'", "&apos;")
        End If
        encodeXmlSpecialChars = str
    End Function


    Function decodeXmlSpecialChars(ByVal str)
        If Not (Trim(str) = "" Or String.IsNullOrEmpty(str)) Then
            str = Replace(str, "&amp;", "&")
            str = Replace(str, "&lt;", "<")
            str = Replace(str, "&gt;", ">")
            str = Replace(str, "&quot;", Chr(34))
            str = Replace(str, "&apos;", "'")
        End If
        decodeXmlSpecialChars = str
    End Function
End Class

Public Class Git
    Function donwloadRepository(ByVal gitUrl As String, ByVal downloadFolder As String) As Boolean

        Dim cmd As String = "git clone " & gitUrl & " " & downloadFolder &
                            " & RMDIR /S/Q " & downloadFolder & "\.git" &
                            " & Exit"
        Try
            Shell("cmd.exe /k " & cmd, AppWinStyle.NormalFocus, True)

            Return True
        Catch ex As Exception
            Return True
        End Try
    End Function
End Class

Public Class Assembly
    Function loadAssembly(ByVal dllPath As String) As Boolean
        Try
            System.Reflection.Assembly.LoadFile(dllPath)
            Return True
        Catch ex As Exception
            Return True
        End Try
    End Function
End Class