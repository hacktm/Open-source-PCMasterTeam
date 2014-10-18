Public Class Form1
    REM Determines the drive letter of the USB
    Dim DriveLetter As Char = (Application.StartupPath.Substring(0, 1))
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

    End Sub

    Private Sub Setup_Click(sender As Object, e As EventArgs) Handles Setup.Click
        If My.Computer.FileSystem.FileExists(DriveLetter & ":\" & "setup.exe") Then

        End If
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click

    End Sub
End Class