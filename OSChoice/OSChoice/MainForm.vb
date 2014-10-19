Imports System
Imports System.IO
Imports System.Text

Public Class MainForm
    REM //////////////////////////// VARIABLE DECLARATIONS ////////////////////////////////////
    REM Determines the drive letter of the USB
    Dim DriveLetter As String = (Application.StartupPath.Substring(0, 2))
    Dim Path As String = "\OSChanger\"
    Dim LinuxPath As String = "\OSChanger\Linux\"
    Dim WinPath As String = "\OSChanger\Windows\"

    REM //////////////////////////// ON START-UP //////////////////////////////////////////////
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM Initial Preparations that happen when the Program is opened
        StorageBar()
        DetectLinux()
        DetectWin()
    End Sub

    REM ////////////////// FUNCTIONS AND SUBS / UNDER THE HOOD ////////////////////////////////
    REM Storage Bar Update
    Sub StorageBar()

        Dim cdrive As System.IO.DriveInfo
        Dim FreeSpace As Double
        Dim TotalSpace As Double
        Dim UsedSpace As Double

        REM Gathers Required Information
        cdrive = My.Computer.FileSystem.GetDriveInfo(DriveLetter & "\")
        FreeSpace = CStr(cdrive.TotalFreeSpace) / 1073741824
        FreeSpace = Format(FreeSpace, "0.00")
        TotalSpace = CStr(cdrive.TotalSize) / 1073741824
        TotalSpace = Format(TotalSpace, "0.00")
        UsedSpace = TotalSpace - FreeSpace

        REM Sets Parameters and Updates the Storage Bar
        StorageSpace.Minimum = 0
        StorageSpace.Maximum = TotalSpace
        StorageSpace.Value = UsedSpace

        REM Updates the Labels on either side of the bar
        lbl_UsedSpace.Text = "Used Space: " & UsedSpace & " GB"
        lbl_TotalSpace.Text = "Total Space:" & TotalSpace & "GB"

    End Sub

    REM Linux ISO Detection
    Sub DetectLinux()
        REM If the Linux.lst does not exist, it tells the user and aborts the action to prevent errors
        If Not My.Computer.FileSystem.FileExists(DriveLetter + LinuxPath + "Linux.lst") Then
            Call Missing_LST()
            Exit Sub
        End If

        REM Detects any ISOs in the Linux Folder that have been added with the OSChanger and adds them to the list
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(DriveLetter + LinuxPath)
            Dim foundFileInfo As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(foundFile)
            If foundFileInfo.Name.Substring(foundFileInfo.Name.Length - 4) = ".iso" Then
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText(DriveLetter + LinuxPath + "Linux.LST")
                Dim GrubEntry As String = "title      >> " + foundFileInfo.Name
                If fileReader.Contains(GrubEntry) Then
                    LinuxList.Items.Add(foundFileInfo.Name)
                End If
            End If
        Next
    End Sub

    REM Windows Detection
    Sub DetectWin()
        REM If the Menu.lst does not exist, it tells the user and aborts the action to prevent errors
        If Not My.Computer.FileSystem.FileExists(DriveLetter + WinPath + "Windows.lst") Then
            Call Missing_LST()
            Exit Sub
        End If

        REM Detects any Folders in the Windows Folder that have been added with the OSChanger and adds them to the list
        Dim fileReader As String = My.Computer.FileSystem.ReadAllText(DriveLetter + WinPath + "Windows.LST")
        Dim GrubEntry As String
        Dim WinFolder As String

        For Each Directory As String In My.Computer.FileSystem.GetDirectories(DriveLetter + WinPath)
            WinFolder = Directory.Substring(Directory.LastIndexOf("\") + 1)
            GrubEntry = "iftitle [find --ignore-floppies --ignore-cd /" + WinFolder + ".txt]     >> " + WinFolder
            If fileReader.Contains(GrubEntry) Then
                WinList.Items.Add(WinFolder)
            End If
        Next

    End Sub

    REM Removes the currently prepared windows from root and moves it to the Windows Folder
    Sub WinCleanup()

    End Sub
    REM Missing LST WARNING
    Sub Missing_LST()
        MsgBox("Oops! Critical Error. It seems like the LST file went missing!" + vbCrLf + "Try to copy it from a backup or reinstall OSChanger")
    End Sub

    Public Sub MoveDirectory(ByVal sourcePath As String, ByVal destinationPath As String)
        Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(sourcePath)
        Dim fileSystemInfo As System.IO.FileSystemInfo
        For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
            Dim destinationFileName As String =
                System.IO.Path.Combine(destinationPath, fileSystemInfo.Name)

            ' Now check whether its a file or a folder and take action accordingly
            If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                My.Computer.FileSystem.MoveFile(fileSystemInfo.FullName, destinationFileName)
            Else
                My.Computer.FileSystem.MoveDirectory("...", "...")
                ' Recursively call the mothod to copy all the neste folders
                REM MoveDirectory(fileSystemInfo.FullName, destinationFileName)
            End If
        Next
    End Sub
    REM //////////////////////////////// CONTROL BUTTONS: ///////////////////////////////
    Private Sub PrepareWindows_Click(sender As Object, e As EventArgs) Handles PrepareWindows.Click
        If CurrentOS.Text = "None" And Not WinList.SelectedIndex = -1 Then
            My.Computer.FileSystem.MoveDirectory(DriveLetter + WinPath + WinList.SelectedItem.ToString, DriveLetter + "\")
        Else
            Call WinCleanup()
        End If
    End Sub
    Private Sub ShutDown_Click(sender As Object, e As EventArgs) Handles ShutDown.Click
        REM Prompts the User wether or not he wants to Shut Down the PC or not.
        Dim response = MsgBox("Are you sure you want to shut down?", vbYesNo, "Shut Down System")
        If response = MsgBoxResult.Yes Then Shell("Shutdown -s -t 3")
    End Sub
    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        REM Prompts the User wether or not he wants to Reboot the PC or not.
        Dim response = MsgBox("Are you sure you want to reboot?", vbYesNo, "Reboot System")
        If response = MsgBoxResult.Yes Then Shell("Shutdown -r -t 3")
    End Sub

    Private Sub Cleanup_Click(sender As Object, e As EventArgs) Handles Cleanup.Click
        REM Moves the currently installed Windows back to the Windows Folder in order to
        REM Allow another Windows to take its place in the USB Root

        Call WinCleanup()

    End Sub

    Private Sub Setup_Click(sender As Object, e As EventArgs) Handles Setup.Click
        REM If a Setup is available, runs it from windows. 
        If My.Computer.FileSystem.FileExists(DriveLetter & ":\" & "setup.exe") Then
            Process.Start(DriveLetter + ":\setup.exe")
        Else
            MsgBox("There are currently no Setup files ready.")
        End If
    End Sub

    Private Sub Downloads_Click(sender As Object, e As EventArgs) Handles Downloads.Click
        REM If it exists, opens up the Downloads page which guide the user to Setup ISOs
        If My.Computer.FileSystem.FileExists(DriveLetter & Path & "downloads.html") Then
            Process.Start(DriveLetter + Path + "downloads.html")
        Else
            MsgBox("Oops! It seems like that file is missing...")
        End If
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        REM If it exists, opens up the Help and Documentation page
        If My.Computer.FileSystem.FileExists(DriveLetter & Path & "help.html") Then
            Process.Start(DriveLetter + Path + "help.html")
        Else
            MsgBox("Oops! It seems like that file is missing...")
        End If
    End Sub

    REM ///////////////////////// BUTTON GUI BACKGROUND /////////////////////////////////////////
    REM Makes it so that when Image Buttons are hovered over they change background colors
    Private Sub ShutDown_MouseEnter(sender As Object, e As EventArgs) Handles ShutDown.MouseEnter
        ShutDown.BackColor = Color.LightGray
    End Sub

    Private Sub ShutDown_MouseLeave(sender As Object, e As EventArgs) Handles ShutDown.MouseLeave
        ShutDown.BackColor = Color.Transparent
    End Sub

    Private Sub Restart_MouseEnter(sender As Object, e As EventArgs) Handles Restart.MouseEnter
        Restart.BackColor = Color.LightGray
    End Sub

    Private Sub Restart_MouseLeave(sender As Object, e As EventArgs) Handles Restart.MouseLeave
        Restart.BackColor = Color.Transparent
    End Sub

    Private Sub Cleanup_MouseEnter(sender As Object, e As EventArgs) Handles Cleanup.MouseEnter
        Cleanup.BackColor = Color.LightGray
    End Sub

    Private Sub Cleanup_MouseLeave(sender As Object, e As EventArgs) Handles Cleanup.MouseLeave
        Cleanup.BackColor = Color.Transparent
    End Sub

    Private Sub Setup_MouseEnter(sender As Object, e As EventArgs) Handles Setup.MouseEnter
        Setup.BackColor = Color.LightGray
    End Sub

    Private Sub Setup_MouseLeave(sender As Object, e As EventArgs) Handles Setup.MouseLeave
        Setup.BackColor = Color.Transparent
    End Sub

    Private Sub Downloads_MouseEnter(sender As Object, e As EventArgs) Handles Downloads.MouseEnter
        Downloads.BackColor = Color.LightGray
    End Sub

    Private Sub Downloads_MouseLeave(sender As Object, e As EventArgs) Handles Downloads.MouseLeave
        Downloads.BackColor = Color.Transparent
    End Sub

    Private Sub Help_MouseEnter(sender As Object, e As EventArgs) Handles Help.MouseEnter
        Help.BackColor = Color.LightGray
    End Sub

    Private Sub Help_MouseLeave(sender As Object, e As EventArgs) Handles Help.MouseLeave
        Help.BackColor = Color.Transparent
    End Sub

    REM //////////////////////////// ADD AND REMOVE BUTTONS ///////////////////////////////////////
    Private Sub btn_Add_Linux_Click(sender As Object, e As EventArgs) Handles btn_Add_Linux.Click
        REM If the Linux.lst does not exist, it tells the user and aborts the action to prevent errors
        If Not My.Computer.FileSystem.FileExists(DriveLetter + LinuxPath + "Linux.lst") Then
            Call Missing_LST()
            Exit Sub
        End If

        REM Copies the .ISO
        Dim ISOpath As String = ""
        Dim LinuxISO As System.IO.FileInfo
        Dim dialog As New OpenFileDialog()

        dialog.Filter = "ISO Image|*.iso"
        If DialogResult.OK = dialog.ShowDialog Then

            REM If User Chose an ISO, it copies it into the Linux Folder, or if its there already, it just creates entries
            REM If the source and destination are on the same drive, the ISO is just moved.
            ISOpath = dialog.FileName
            LinuxISO = My.Computer.FileSystem.GetFileInfo(ISOpath)

            If ISOpath.Substring(0, 2) <> DriveLetter Then
                My.Computer.FileSystem.CopyFile(ISOpath, DriveLetter + LinuxPath + LinuxISO.Name, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            ElseIf ISOpath.Substring(0, 2) = DriveLetter And ISOpath <> DriveLetter + LinuxPath + LinuxISO.Name Then
                My.Computer.FileSystem.MoveFile(ISOpath, DriveLetter + LinuxPath + LinuxISO.Name, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            End If

            REM Creates Linux List and GRUB Menu Entry
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(DriveLetter + LinuxPath + "Linux.LST")
            Dim GrubEntry As String = "title      >> " + LinuxISO.Name
            If Not fileReader.Contains(GrubEntry) Then
                LinuxList.Items.Add(LinuxISO.Name)
                My.Computer.FileSystem.WriteAllText(DriveLetter + LinuxPath + "Linux.LST", "title      >> " + LinuxISO.Name + vbCrLf + "map /OSChanger/Linux/" + LinuxISO.Name + " (0xff)" + vbCrLf + "map --hook" + vbCrLf + "chainloader (0xff)" + vbCrLf + vbCrLf, True)
            Else
                MsgBox("You have already setup this ISO!")
            End If
        End If

        REM Updates the Storage Bar
        StorageBar()
    End Sub

    Private Sub btn_Rem_Linux_Click(sender As Object, e As EventArgs) Handles btn_Rem_Linux.Click
        REM If the Linux.lst does not exist, it tells the user and aborts the action to prevent errors
        If Not My.Computer.FileSystem.FileExists(DriveLetter + LinuxPath + "Linux.lst") Then
            Call Missing_LST()
            Exit Sub
        End If

        If Not LinuxList.SelectedIndex = -1 Then
            REM Removes GRUB Entry
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(DriveLetter + LinuxPath + "Linux.LST")
            Dim GrubEntry As String = "title      >> " + LinuxList.SelectedItem.ToString
            If fileReader.Contains(GrubEntry) Then
                Dim FirstCharacter As Integer = fileReader.IndexOf(GrubEntry)
                Dim LengthofEntry As Integer = 80 + 2 * LinuxList.SelectedItem.ToString.Length
                fileReader = fileReader.Remove(FirstCharacter, LengthofEntry)
                My.Computer.FileSystem.WriteAllText(DriveLetter + LinuxPath + "Linux.LST", fileReader, False)
            End If

            REM Deletes the ISO and the List Entry
            My.Computer.FileSystem.DeleteFile(DriveLetter + LinuxPath + LinuxList.SelectedItem.ToString)
            LinuxList.Items.Remove(LinuxList.SelectedItem)

            REM Updates the Storage Bar
            StorageBar()

        End If
    End Sub

    Private Sub btn_Add_Win_Click(sender As Object, e As EventArgs) Handles btn_Add_Win.Click
        REM If the Windows.lst does not exist, it tells the user and aborts the action to prevent errors
        If Not My.Computer.FileSystem.FileExists(DriveLetter + WinPath + "Windows.lst") Then
            Call Missing_LST()
            Exit Sub
        End If

        REM Copies the .ISO
        Dim WinFpath As String = ""
        Dim WinFolder As String = ""
        Dim dialog As New FolderBrowserDialog

        If DialogResult.OK = dialog.ShowDialog Then

            REM If User Chose a Folder, it copies it into the Windows Folder, or if its there already, it just creates entries
            REM If the source and destination are on the same drive, the Folder is just moved.
            WinFpath = dialog.SelectedPath
            WinFolder = dialog.SelectedPath.Substring(dialog.SelectedPath.LastIndexOf("\") + 1)

            If WinFpath.Substring(0, 2) <> DriveLetter Then
                My.Computer.FileSystem.CopyDirectory(WinFpath, DriveLetter + WinPath + WinFolder, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            ElseIf WinFpath.Substring(0, 2) = DriveLetter And WinFpath <> DriveLetter + WinPath + WinFolder Then
                My.Computer.FileSystem.MoveDirectory(WinFpath, DriveLetter + WinPath + WinFolder, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            End If

            REM Creates Windows List and GRUB Menu Entry
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(DriveLetter + WinPath + "Windows.LST")
            Dim GrubEntry As String = "iftitle [find --ignore-floppies --ignore-cd /" + WinFolder + ".txt]     >> " + WinFolder
            If Not fileReader.Contains(GrubEntry) Then
                My.Computer.FileSystem.WriteAllText(DriveLetter + WinPath + "Windows.LST", "iftitle [find --ignore-floppies --ignore-cd /" + WinFolder + ".txt]     >> " + WinFolder + vbCrLf + "find --set-root --ignore-floppies --ignore-cd /bootmgr " + vbCrLf + "chainloader /bootmgr" + vbCrLf + vbCrLf, True)
            Else
                MsgBox("You have already setup this Win!")
            End If

            REM Creates an Identifier and then adds the Windows to the List
            Dim fs As FileStream = File.Create(WinFpath + "\" + WinFolder + ".txt")
            fs.Close()

            WinList.Items.Add(WinFolder)

        End If

        REM Updates Storage Box
        StorageBar()

    End Sub

    Private Sub btn_rem_win_Click(sender As Object, e As EventArgs) Handles btn_rem_win.Click
        REM If the Windows.lst does not exist, it tells the user and aborts the action to prevent errors
        If Not My.Computer.FileSystem.FileExists(DriveLetter + WinPath + "Windows.lst") Then
            Call Missing_LST()
            Exit Sub
        End If
        If Not WinList.SelectedIndex = -1 Then
            REM Removes GRUB Entry
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(DriveLetter + WinPath + "Windows.LST")
            Dim GrubEntry As String = "iftitle [find --ignore-floppies --ignore-cd /" + WinList.SelectedItem.ToString + ".txt]     >> " + WinList.SelectedItem.ToString
            If fileReader.Contains(GrubEntry) Then
                Dim FirstCharacter As Integer = fileReader.IndexOf(GrubEntry)
                Dim LengthofEntry As Integer = 141 + 2 * WinList.SelectedItem.ToString.Length
                fileReader = fileReader.Remove(FirstCharacter, LengthofEntry)
                My.Computer.FileSystem.WriteAllText(DriveLetter + WinPath + "Windows.LST", fileReader, False)
            End If

            REM Deletes the ISO and the List Entry

            My.Computer.FileSystem.DeleteDirectory(DriveLetter + WinPath + WinList.SelectedItem.ToString, FileIO.DeleteDirectoryOption.DeleteAllContents)
            WinList.Items.Remove(WinList.SelectedItem)

            REM Updates the Storage Bar
            StorageBar()

        End If

    End Sub

End Class