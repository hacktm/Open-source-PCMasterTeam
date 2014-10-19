Public Class Form1
    REM Determines the drive letter of the USB
    Dim DriveLetter As Char = (Application.StartupPath.Substring(0, 2))
    Dim Path As String = "\OSChanger\"
    REM Storage Bar Update
    Sub StorageBar()
        Dim cdrive As System.IO.DriveInfo
        Dim FreeSpace As Double
        Dim TotalSpace As Double
        Dim UsedSpace As Double

        cdrive = My.Computer.FileSystem.GetDriveInfo(DriveLetter & ":\")
        FreeSpace = CStr(cdrive.TotalFreeSpace) / 1073741824
        FreeSpace = Format(FreeSpace, "0.00")
        TotalSpace = CStr(cdrive.TotalSize) / 1073741824
        TotalSpace = Format(TotalSpace, "0.00")
        UsedSpace = TotalSpace - FreeSpace
        StorageSpace.Minimum = 0
        StorageSpace.Maximum = TotalSpace
        StorageSpace.Value = UsedSpace
        lbl_UsedSpace.Text = "Used Space: " & UsedSpace & " GB"
        lbl_TotalSpace.Text = "Total Space:" & TotalSpace & "GB"

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StorageBar()
    End Sub

    REM CONTROL (RIGHT COLON) BUTTONS:

    Private Sub ShutDown_Click(sender As Object, e As EventArgs) Handles ShutDown.Click
        Dim response = MsgBox("Are you sure you want to shut down?", vbYesNo, "Shut Down System")
        If response = MsgBoxResult.Yes Then Shell("Shutdown -t 3")
    End Sub
    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        Dim response = MsgBox("Are you sure you want to reboot?", vbYesNo, "Reboot System")
        If response = MsgBoxResult.Yes Then Shell("Shutdown -r -t 3")
    End Sub

    
    Private Sub Cleanup_Click(sender As Object, e As EventArgs) Handles Cleanup.Click
        REM TODOOOOOO
    End Sub

    Private Sub Setup_Click(sender As Object, e As EventArgs) Handles Setup.Click
        If My.Computer.FileSystem.FileExists(DriveLetter & ":\" & "setup.exe") Then
            Process.Start(DriveLetter + ":\Setup.exe")
        End If
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        If My.Computer.FileSystem.FileExists(DriveLetter & Path & "help.html") Then
            Process.Start(DriveLetter + Path + "help.html")
        End If

    End Sub

    REM UI Buttons change background on Hover
    
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

    Private Sub Help_MouseEnter(sender As Object, e As EventArgs) Handles Help.MouseEnter
        Help.BackColor = Color.LightGray
    End Sub

    Private Sub Help_MouseLeave(sender As Object, e As EventArgs) Handles Help.MouseLeave
        Help.BackColor = Color.Transparent
    End Sub

    REM Adds A Linux Distribution
    Private Sub btn_Add_Linux_Click(sender As Object, e As EventArgs) Handles btn_Add_Linux.Click
        REM Copies the .ISO
        Dim ISOpath As String = ""
        Dim LinuxISO As System.IO.FileInfo
        Dim LinuxISOName As String
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            ISOpath = dialog.FileName
            LinuxISO = My.Computer.FileSystem.GetFileInfo(ISOpath)
            LinuxISOName = LinuxISO.Name
            My.Computer.FileSystem.CopyFile(ISOpath, DriveLetter + Path + LinuxISOName, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

        REM Creates GRUB Menu Entry
        My.Computer.FileSystem.WriteAllText(DriveLetter + Path + "Linux.LST", "title     > " + LinuxISO.Name + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(DriveLetter + Path + "Linux.LST", "map " + Path + LinuxISOName + " (0xff)" + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(DriveLetter + Path + "Linux.LST", "map --hook" + vbCrLf, True)
        My.Computer.FileSystem.WriteAllText(DriveLetter + Path + "Linux.LST", "chainloader (0xff)" + vbCrLf + vbCrLf, True)
    End Sub
End Class