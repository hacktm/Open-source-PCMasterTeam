<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Grbox_Control = New System.Windows.Forms.GroupBox()
        Me.Help = New System.Windows.Forms.PictureBox()
        Me.Setup = New System.Windows.Forms.PictureBox()
        Me.Cleanup = New System.Windows.Forms.PictureBox()
        Me.Restart = New System.Windows.Forms.PictureBox()
        Me.ShutDown = New System.Windows.Forms.PictureBox()
        Me.Grbox_Settings = New System.Windows.Forms.GroupBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Rem_Linux = New System.Windows.Forms.Button()
        Me.btn_Add_Linux = New System.Windows.Forms.Button()
        Me.btn_AddWin = New System.Windows.Forms.Button()
        Me.lbl_TotalSpace = New System.Windows.Forms.Label()
        Me.lbl_UsedSpace = New System.Windows.Forms.Label()
        Me.StorageSpace = New System.Windows.Forms.ProgressBar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.BrowseFile = New System.Windows.Forms.OpenFileDialog()
        Me.Grbox_Control.SuspendLayout()
        CType(Me.Help, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Setup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cleanup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Restart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShutDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grbox_Settings.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 20000
        Me.ToolTip.InitialDelay = 100
        Me.ToolTip.ReshowDelay = 100
        '
        'Grbox_Control
        '
        Me.Grbox_Control.Controls.Add(Me.Help)
        Me.Grbox_Control.Controls.Add(Me.Setup)
        Me.Grbox_Control.Controls.Add(Me.Cleanup)
        Me.Grbox_Control.Controls.Add(Me.Restart)
        Me.Grbox_Control.Controls.Add(Me.ShutDown)
        Me.Grbox_Control.Location = New System.Drawing.Point(588, 13)
        Me.Grbox_Control.Name = "Grbox_Control"
        Me.Grbox_Control.Size = New System.Drawing.Size(48, 233)
        Me.Grbox_Control.TabIndex = 0
        Me.Grbox_Control.TabStop = False
        '
        'Help
        '
        Me.Help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Help.Image = CType(resources.GetObject("Help.Image"), System.Drawing.Image)
        Me.Help.Location = New System.Drawing.Point(6, 187)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(36, 36)
        Me.Help.TabIndex = 4
        Me.Help.TabStop = False
        '
        'Setup
        '
        Me.Setup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Setup.Image = CType(resources.GetObject("Setup.Image"), System.Drawing.Image)
        Me.Setup.Location = New System.Drawing.Point(6, 145)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(36, 36)
        Me.Setup.TabIndex = 3
        Me.Setup.TabStop = False
        '
        'Cleanup
        '
        Me.Cleanup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cleanup.Image = CType(resources.GetObject("Cleanup.Image"), System.Drawing.Image)
        Me.Cleanup.Location = New System.Drawing.Point(6, 103)
        Me.Cleanup.Name = "Cleanup"
        Me.Cleanup.Size = New System.Drawing.Size(36, 36)
        Me.Cleanup.TabIndex = 2
        Me.Cleanup.TabStop = False
        '
        'Restart
        '
        Me.Restart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Restart.Image = CType(resources.GetObject("Restart.Image"), System.Drawing.Image)
        Me.Restart.Location = New System.Drawing.Point(6, 61)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(36, 36)
        Me.Restart.TabIndex = 1
        Me.Restart.TabStop = False
        '
        'ShutDown
        '
        Me.ShutDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ShutDown.Image = CType(resources.GetObject("ShutDown.Image"), System.Drawing.Image)
        Me.ShutDown.Location = New System.Drawing.Point(6, 19)
        Me.ShutDown.Name = "ShutDown"
        Me.ShutDown.Size = New System.Drawing.Size(36, 36)
        Me.ShutDown.TabIndex = 0
        Me.ShutDown.TabStop = False
        '
        'Grbox_Settings
        '
        Me.Grbox_Settings.Controls.Add(Me.logo)
        Me.Grbox_Settings.Controls.Add(Me.Button1)
        Me.Grbox_Settings.Controls.Add(Me.btn_Rem_Linux)
        Me.Grbox_Settings.Controls.Add(Me.btn_Add_Linux)
        Me.Grbox_Settings.Controls.Add(Me.btn_AddWin)
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(352, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 19)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Remove Windows"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.btn_Add_Linux.Location = New System.Drawing.Point(119, 19)
        Me.btn_Add_Linux.Name = "btn_Add_Linux"
        Me.btn_Add_Linux.Size = New System.Drawing.Size(103, 19)
        Me.btn_Add_Linux.TabIndex = 3
        Me.btn_Add_Linux.Text = "Add Linux"
        Me.btn_Add_Linux.UseVisualStyleBackColor = True
        '
        'btn_AddWin
        '
        Me.btn_AddWin.Location = New System.Drawing.Point(10, 18)
        Me.btn_AddWin.Name = "btn_AddWin"
        Me.btn_AddWin.Size = New System.Drawing.Size(103, 20)
        Me.btn_AddWin.TabIndex = 2
        Me.btn_AddWin.Text = "Add Windows"
        Me.btn_AddWin.UseVisualStyleBackColor = True
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(570, 173)
        Me.ListBox1.TabIndex = 3
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(564, 13)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 173)
        Me.VScrollBar1.TabIndex = 4
        '
        'FolderBrowser
        '
        '
        'BrowseFile
        '
        Me.BrowseFile.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(648, 276)
        Me.Controls.Add(Me.lbl_TotalSpace)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.lbl_UsedSpace)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.StorageSpace)
        Me.Controls.Add(Me.Grbox_Settings)
        Me.Controls.Add(Me.Grbox_Control)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(664, 330)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(664, 267)
        Me.Name = "Form1"
        Me.Text = "OS Changer"
        Me.Grbox_Control.ResumeLayout(False)
        CType(Me.Help, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Setup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cleanup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Restart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShutDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grbox_Settings.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Grbox_Control As System.Windows.Forms.GroupBox
    Friend WithEvents Help As System.Windows.Forms.PictureBox
    Friend WithEvents Setup As System.Windows.Forms.PictureBox
    Friend WithEvents Cleanup As System.Windows.Forms.PictureBox
    Friend WithEvents Restart As System.Windows.Forms.PictureBox
    Friend WithEvents ShutDown As System.Windows.Forms.PictureBox
    Friend WithEvents Grbox_Settings As System.Windows.Forms.GroupBox
    Friend WithEvents StorageSpace As System.Windows.Forms.ProgressBar
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents lbl_UsedSpace As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalSpace As System.Windows.Forms.Label
    Friend WithEvents btn_AddWin As System.Windows.Forms.Button
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Rem_Linux As System.Windows.Forms.Button
    Friend WithEvents btn_Add_Linux As System.Windows.Forms.Button
    Friend WithEvents BrowseFile As System.Windows.Forms.OpenFileDialog

End Class
