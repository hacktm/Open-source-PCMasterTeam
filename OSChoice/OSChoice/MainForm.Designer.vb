<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Help = New System.Windows.Forms.PictureBox()
        Me.Setup = New System.Windows.Forms.PictureBox()
        Me.Cleanup = New System.Windows.Forms.PictureBox()
        Me.Restart = New System.Windows.Forms.PictureBox()
        Me.ShutDown = New System.Windows.Forms.PictureBox()
        Me.Grbox_Settings = New System.Windows.Forms.GroupBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.btn_rem_win = New System.Windows.Forms.Button()
        Me.btn_Rem_Linux = New System.Windows.Forms.Button()
        Me.btn_Add_Linux = New System.Windows.Forms.Button()
        Me.btn_Add_Win = New System.Windows.Forms.Button()
        Me.lbl_TotalSpace = New System.Windows.Forms.Label()
        Me.lbl_UsedSpace = New System.Windows.Forms.Label()
        Me.StorageSpace = New System.Windows.Forms.ProgressBar()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.BrowseFile = New System.Windows.Forms.OpenFileDialog()
        Me.LinuxList = New System.Windows.Forms.ListBox()
        Me.LabelLinux = New System.Windows.Forms.Label()
        Me.Linux = New System.Windows.Forms.PictureBox()
        Me.Downloads = New System.Windows.Forms.PictureBox()
        Me.grbox_Control = New System.Windows.Forms.GroupBox()
        Me.PrepareWindows = New System.Windows.Forms.Button()
        Me.LabelWindows = New System.Windows.Forms.Label()
        Me.Windows = New System.Windows.Forms.PictureBox()
        Me.WinList = New System.Windows.Forms.ListBox()
        Me.CurrentOS = New System.Windows.Forms.Label()
        Me.CurOS = New System.Windows.Forms.Label()
        CType(Me.Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Setup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cleanup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Restart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShutDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grbox_Settings.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Linux, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Downloads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbox_Control.SuspendLayout()
        CType(Me.Windows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 20000
        Me.ToolTip.InitialDelay = 100
        Me.ToolTip.ReshowDelay = 100
        '
        'Help
        '
        Me.Help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Help.Image = CType(resources.GetObject("Help.Image"), System.Drawing.Image)
        Me.Help.Location = New System.Drawing.Point(49, 103)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(36, 36)
        Me.Help.TabIndex = 4
        Me.Help.TabStop = False
        '
        'Setup
        '
        Me.Setup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Setup.Image = CType(resources.GetObject("Setup.Image"), System.Drawing.Image)
        Me.Setup.Location = New System.Drawing.Point(49, 61)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(36, 36)
        Me.Setup.TabIndex = 3
        Me.Setup.TabStop = False
        '
        'Cleanup
        '
        Me.Cleanup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cleanup.Image = CType(resources.GetObject("Cleanup.Image"), System.Drawing.Image)
        Me.Cleanup.Location = New System.Drawing.Point(7, 61)
        Me.Cleanup.Name = "Cleanup"
        Me.Cleanup.Size = New System.Drawing.Size(36, 36)
        Me.Cleanup.TabIndex = 2
        Me.Cleanup.TabStop = False
        '
        'Restart
        '
        Me.Restart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Restart.Image = CType(resources.GetObject("Restart.Image"), System.Drawing.Image)
        Me.Restart.Location = New System.Drawing.Point(49, 19)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(36, 36)
        Me.Restart.TabIndex = 1
        Me.Restart.TabStop = False
        '
        'ShutDown
        '
        Me.ShutDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShutDown.Image = CType(resources.GetObject("ShutDown.Image"), System.Drawing.Image)
        Me.ShutDown.Location = New System.Drawing.Point(7, 19)
        Me.ShutDown.Name = "ShutDown"
        Me.ShutDown.Size = New System.Drawing.Size(36, 36)
        Me.ShutDown.TabIndex = 0
        Me.ShutDown.TabStop = False
        '
        'Grbox_Settings
        '
        Me.Grbox_Settings.Controls.Add(Me.logo)
        Me.Grbox_Settings.Controls.Add(Me.btn_rem_win)
        Me.Grbox_Settings.Controls.Add(Me.btn_Rem_Linux)
        Me.Grbox_Settings.Controls.Add(Me.btn_Add_Linux)
        Me.Grbox_Settings.Controls.Add(Me.btn_Add_Win)
        Me.Grbox_Settings.Location = New System.Drawing.Point(12, 221)
        Me.Grbox_Settings.Name = "Grbox_Settings"
        Me.Grbox_Settings.Size = New System.Drawing.Size(570, 48)
        Me.Grbox_Settings.TabIndex = 1
        Me.Grbox_Settings.TabStop = False
        Me.Grbox_Settings.Text = "Settings: Add or Remove"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(228, 14)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(118, 28)
        Me.logo.TabIndex = 6
        Me.logo.TabStop = False
        '
        'btn_rem_win
        '
        Me.btn_rem_win.Location = New System.Drawing.Point(119, 19)
        Me.btn_rem_win.Name = "btn_rem_win"
        Me.btn_rem_win.Size = New System.Drawing.Size(103, 19)
        Me.btn_rem_win.TabIndex = 5
        Me.btn_rem_win.Text = "Remove Windows"
        Me.btn_rem_win.UseVisualStyleBackColor = True
        '
        'btn_Rem_Linux
        '
        Me.btn_Rem_Linux.Location = New System.Drawing.Point(461, 19)
        Me.btn_Rem_Linux.Name = "btn_Rem_Linux"
        Me.btn_Rem_Linux.Size = New System.Drawing.Size(103, 19)
        Me.btn_Rem_Linux.TabIndex = 4
        Me.btn_Rem_Linux.Text = "Remove Linux"
        Me.btn_Rem_Linux.UseVisualStyleBackColor = True
        '
        'btn_Add_Linux
        '
        Me.btn_Add_Linux.Location = New System.Drawing.Point(352, 19)
        Me.btn_Add_Linux.Name = "btn_Add_Linux"
        Me.btn_Add_Linux.Size = New System.Drawing.Size(103, 19)
        Me.btn_Add_Linux.TabIndex = 3
        Me.btn_Add_Linux.Text = "Add Linux"
        Me.btn_Add_Linux.UseVisualStyleBackColor = True
        '
        'btn_Add_Win
        '
        Me.btn_Add_Win.Location = New System.Drawing.Point(10, 18)
        Me.btn_Add_Win.Name = "btn_Add_Win"
        Me.btn_Add_Win.Size = New System.Drawing.Size(103, 20)
        Me.btn_Add_Win.TabIndex = 2
        Me.btn_Add_Win.Text = "Add Windows"
        Me.btn_Add_Win.UseVisualStyleBackColor = True
        '
        'lbl_TotalSpace
        '
        Me.lbl_TotalSpace.AutoSize = True
        Me.lbl_TotalSpace.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TotalSpace.Location = New System.Drawing.Point(469, 200)
        Me.lbl_TotalSpace.Name = "lbl_TotalSpace"
        Me.lbl_TotalSpace.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_TotalSpace.Size = New System.Drawing.Size(112, 13)
        Me.lbl_TotalSpace.TabIndex = 1
        Me.lbl_TotalSpace.Text = "Total Space: xx.xx GB"
        Me.lbl_TotalSpace.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_UsedSpace
        '
        Me.lbl_UsedSpace.AutoSize = True
        Me.lbl_UsedSpace.BackColor = System.Drawing.Color.Transparent
        Me.lbl_UsedSpace.Location = New System.Drawing.Point(12, 200)
        Me.lbl_UsedSpace.Name = "lbl_UsedSpace"
        Me.lbl_UsedSpace.Size = New System.Drawing.Size(113, 13)
        Me.lbl_UsedSpace.TabIndex = 0
        Me.lbl_UsedSpace.Text = "Used Space: xx.xx GB"
        '
        'StorageSpace
        '
        Me.StorageSpace.Location = New System.Drawing.Point(131, 200)
        Me.StorageSpace.Name = "StorageSpace"
        Me.StorageSpace.Size = New System.Drawing.Size(332, 13)
        Me.StorageSpace.TabIndex = 2
        '
        'BrowseFile
        '
        Me.BrowseFile.FileName = "OpenFileDialog1"
        '
        'LinuxList
        '
        Me.LinuxList.FormattingEnabled = True
        Me.LinuxList.Location = New System.Drawing.Point(342, 52)
        Me.LinuxList.Name = "LinuxList"
        Me.LinuxList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LinuxList.Size = New System.Drawing.Size(240, 134)
        Me.LinuxList.TabIndex = 5
        '
        'LabelLinux
        '
        Me.LabelLinux.AutoSize = True
        Me.LabelLinux.Location = New System.Drawing.Point(364, 13)
        Me.LabelLinux.MaximumSize = New System.Drawing.Size(185, 0)
        Me.LabelLinux.Name = "LabelLinux"
        Me.LabelLinux.Size = New System.Drawing.Size(184, 26)
        Me.LabelLinux.TabIndex = 6
        Me.LabelLinux.Text = "Linux Distributions: These are always available for install"
        '
        'Linux
        '
        Me.Linux.Image = CType(resources.GetObject("Linux.Image"), System.Drawing.Image)
        Me.Linux.Location = New System.Drawing.Point(546, 10)
        Me.Linux.Name = "Linux"
        Me.Linux.Size = New System.Drawing.Size(36, 36)
        Me.Linux.TabIndex = 7
        Me.Linux.TabStop = False
        '
        'Downloads
        '
        Me.Downloads.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Downloads.Image = CType(resources.GetObject("Downloads.Image"), System.Drawing.Image)
        Me.Downloads.Location = New System.Drawing.Point(7, 103)
        Me.Downloads.Name = "Downloads"
        Me.Downloads.Size = New System.Drawing.Size(36, 36)
        Me.Downloads.TabIndex = 8
        Me.Downloads.TabStop = False
        '
        'grbox_Control
        '
        Me.grbox_Control.Controls.Add(Me.ShutDown)
        Me.grbox_Control.Controls.Add(Me.Cleanup)
        Me.grbox_Control.Controls.Add(Me.Help)
        Me.grbox_Control.Controls.Add(Me.Restart)
        Me.grbox_Control.Controls.Add(Me.Downloads)
        Me.grbox_Control.Controls.Add(Me.Setup)
        Me.grbox_Control.Location = New System.Drawing.Point(251, 42)
        Me.grbox_Control.Name = "grbox_Control"
        Me.grbox_Control.Size = New System.Drawing.Size(91, 152)
        Me.grbox_Control.TabIndex = 9
        Me.grbox_Control.TabStop = False
        '
        'PrepareWindows
        '
        Me.PrepareWindows.Location = New System.Drawing.Point(251, 8)
        Me.PrepareWindows.Name = "PrepareWindows"
        Me.PrepareWindows.Size = New System.Drawing.Size(91, 38)
        Me.PrepareWindows.TabIndex = 10
        Me.PrepareWindows.Text = "Install Selected Windows"
        Me.PrepareWindows.UseVisualStyleBackColor = True
        '
        'LabelWindows
        '
        Me.LabelWindows.AutoSize = True
        Me.LabelWindows.Location = New System.Drawing.Point(64, 10)
        Me.LabelWindows.MaximumSize = New System.Drawing.Size(185, 0)
        Me.LabelWindows.Name = "LabelWindows"
        Me.LabelWindows.Size = New System.Drawing.Size(177, 39)
        Me.LabelWindows.TabIndex = 11
        Me.LabelWindows.Text = "Windows: Select an item from your list, then click the big button right of this t" & _
    "ext."
        '
        'Windows
        '
        Me.Windows.Image = CType(resources.GetObject("Windows.Image"), System.Drawing.Image)
        Me.Windows.Location = New System.Drawing.Point(12, 10)
        Me.Windows.Name = "Windows"
        Me.Windows.Size = New System.Drawing.Size(36, 36)
        Me.Windows.TabIndex = 12
        Me.Windows.TabStop = False
        '
        'WinList
        '
        Me.WinList.FormattingEnabled = True
        Me.WinList.Location = New System.Drawing.Point(12, 52)
        Me.WinList.Name = "WinList"
        Me.WinList.Size = New System.Drawing.Size(240, 108)
        Me.WinList.TabIndex = 13
        '
        'CurrentOS
        '
        Me.CurrentOS.AutoSize = True
        Me.CurrentOS.Location = New System.Drawing.Point(109, 168)
        Me.CurrentOS.Name = "CurrentOS"
        Me.CurrentOS.Size = New System.Drawing.Size(33, 13)
        Me.CurrentOS.TabIndex = 14
        Me.CurrentOS.Text = "None"
        '
        'CurOS
        '
        Me.CurOS.AutoSize = True
        Me.CurOS.Location = New System.Drawing.Point(12, 168)
        Me.CurOS.Name = "CurOS"
        Me.CurOS.Size = New System.Drawing.Size(91, 13)
        Me.CurOS.TabIndex = 15
        Me.CurOS.Text = "Current Windows:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(593, 276)
        Me.Controls.Add(Me.CurOS)
        Me.Controls.Add(Me.CurrentOS)
        Me.Controls.Add(Me.WinList)
        Me.Controls.Add(Me.Windows)
        Me.Controls.Add(Me.LabelWindows)
        Me.Controls.Add(Me.PrepareWindows)
        Me.Controls.Add(Me.grbox_Control)
        Me.Controls.Add(Me.Linux)
        Me.Controls.Add(Me.LabelLinux)
        Me.Controls.Add(Me.LinuxList)
        Me.Controls.Add(Me.lbl_TotalSpace)
        Me.Controls.Add(Me.lbl_UsedSpace)
        Me.Controls.Add(Me.StorageSpace)
        Me.Controls.Add(Me.Grbox_Settings)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(609, 314)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(609, 314)
        Me.Name = "MainForm"
        Me.Text = "OS Changer"
        CType(Me.Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Setup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cleanup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Restart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShutDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grbox_Settings.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Linux, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Downloads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbox_Control.ResumeLayout(False)
        CType(Me.Windows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Help As System.Windows.Forms.PictureBox
    Friend WithEvents Setup As System.Windows.Forms.PictureBox
    Friend WithEvents Cleanup As System.Windows.Forms.PictureBox
    Friend WithEvents Restart As System.Windows.Forms.PictureBox
    Friend WithEvents ShutDown As System.Windows.Forms.PictureBox
    Friend WithEvents Grbox_Settings As System.Windows.Forms.GroupBox
    Friend WithEvents StorageSpace As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_UsedSpace As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalSpace As System.Windows.Forms.Label
    Friend WithEvents btn_Add_Win As System.Windows.Forms.Button
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents btn_rem_win As System.Windows.Forms.Button
    Friend WithEvents btn_Rem_Linux As System.Windows.Forms.Button
    Friend WithEvents btn_Add_Linux As System.Windows.Forms.Button
    Friend WithEvents BrowseFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LinuxList As System.Windows.Forms.ListBox
    Friend WithEvents LabelLinux As System.Windows.Forms.Label
    Friend WithEvents Linux As System.Windows.Forms.PictureBox
    Friend WithEvents Downloads As System.Windows.Forms.PictureBox
    Friend WithEvents grbox_Control As System.Windows.Forms.GroupBox
    Friend WithEvents PrepareWindows As System.Windows.Forms.Button
    Friend WithEvents LabelWindows As System.Windows.Forms.Label
    Friend WithEvents Windows As System.Windows.Forms.PictureBox
    Friend WithEvents WinList As System.Windows.Forms.ListBox
    Friend WithEvents CurrentOS As System.Windows.Forms.Label
    Friend WithEvents CurOS As System.Windows.Forms.Label

End Class
