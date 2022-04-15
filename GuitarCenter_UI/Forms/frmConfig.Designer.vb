<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tabSqlConfig = New System.Windows.Forms.TabPage()
        Me.grpServerName = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpSqlUser = New System.Windows.Forms.GroupBox()
        Me.txtSqlUser = New System.Windows.Forms.TextBox()
        Me.grpSqlPassword = New System.Windows.Forms.GroupBox()
        Me.txtSqlPassword = New System.Windows.Forms.TextBox()
        Me.grpSqlDataBaseName = New System.Windows.Forms.GroupBox()
        Me.cmbSqlDataBaseName = New System.Windows.Forms.ComboBox()
        Me.chkAuthenticationWin = New System.Windows.Forms.CheckBox()
        Me.grpProvider = New System.Windows.Forms.GroupBox()
        Me.lblProvider = New System.Windows.Forms.Label()
        Me.tabConfiguration = New System.Windows.Forms.TabControl()
        Me.tabSqlConfig.SuspendLayout()
        Me.grpServerName.SuspendLayout()
        Me.grpSqlUser.SuspendLayout()
        Me.grpSqlPassword.SuspendLayout()
        Me.grpSqlDataBaseName.SuspendLayout()
        Me.grpProvider.SuspendLayout()
        Me.tabConfiguration.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.GuitarCenter_UI.My.Resources.Resources.Ok_Gwhite
        Me.btnSave.Location = New System.Drawing.Point(218, 289)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 37)
        Me.btnSave.TabIndex = 0
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = Global.GuitarCenter_UI.My.Resources.Resources.No_Gwhite
        Me.btnCancel.Location = New System.Drawing.Point(295, 289)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 37)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'tabSqlConfig
        '
        Me.tabSqlConfig.Controls.Add(Me.grpProvider)
        Me.tabSqlConfig.Controls.Add(Me.chkAuthenticationWin)
        Me.tabSqlConfig.Controls.Add(Me.grpSqlDataBaseName)
        Me.tabSqlConfig.Controls.Add(Me.grpSqlPassword)
        Me.tabSqlConfig.Controls.Add(Me.grpSqlUser)
        Me.tabSqlConfig.Controls.Add(Me.grpServerName)
        Me.tabSqlConfig.Location = New System.Drawing.Point(4, 22)
        Me.tabSqlConfig.Name = "tabSqlConfig"
        Me.tabSqlConfig.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSqlConfig.Size = New System.Drawing.Size(358, 251)
        Me.tabSqlConfig.TabIndex = 0
        Me.tabSqlConfig.Text = "sql config"
        Me.tabSqlConfig.UseVisualStyleBackColor = True
        '
        'grpServerName
        '
        Me.grpServerName.Controls.Add(Me.txtName)
        Me.grpServerName.Location = New System.Drawing.Point(6, 6)
        Me.grpServerName.Name = "grpServerName"
        Me.grpServerName.Size = New System.Drawing.Size(263, 43)
        Me.grpServerName.TabIndex = 7
        Me.grpServerName.TabStop = False
        Me.grpServerName.Text = "Server name :"
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Location = New System.Drawing.Point(3, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(257, 20)
        Me.txtName.TabIndex = 0
        '
        'grpSqlUser
        '
        Me.grpSqlUser.Controls.Add(Me.txtSqlUser)
        Me.grpSqlUser.Location = New System.Drawing.Point(6, 55)
        Me.grpSqlUser.Name = "grpSqlUser"
        Me.grpSqlUser.Size = New System.Drawing.Size(100, 43)
        Me.grpSqlUser.TabIndex = 8
        Me.grpSqlUser.TabStop = False
        Me.grpSqlUser.Text = "User :"
        '
        'txtSqlUser
        '
        Me.txtSqlUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSqlUser.Location = New System.Drawing.Point(3, 16)
        Me.txtSqlUser.Name = "txtSqlUser"
        Me.txtSqlUser.Size = New System.Drawing.Size(94, 20)
        Me.txtSqlUser.TabIndex = 0
        '
        'grpSqlPassword
        '
        Me.grpSqlPassword.Controls.Add(Me.txtSqlPassword)
        Me.grpSqlPassword.Location = New System.Drawing.Point(6, 104)
        Me.grpSqlPassword.Name = "grpSqlPassword"
        Me.grpSqlPassword.Size = New System.Drawing.Size(141, 43)
        Me.grpSqlPassword.TabIndex = 9
        Me.grpSqlPassword.TabStop = False
        Me.grpSqlPassword.Text = "Password :"
        '
        'txtSqlPassword
        '
        Me.txtSqlPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSqlPassword.Location = New System.Drawing.Point(3, 16)
        Me.txtSqlPassword.Name = "txtSqlPassword"
        Me.txtSqlPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSqlPassword.Size = New System.Drawing.Size(135, 20)
        Me.txtSqlPassword.TabIndex = 0
        '
        'grpSqlDataBaseName
        '
        Me.grpSqlDataBaseName.Controls.Add(Me.cmbSqlDataBaseName)
        Me.grpSqlDataBaseName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpSqlDataBaseName.Location = New System.Drawing.Point(6, 153)
        Me.grpSqlDataBaseName.Name = "grpSqlDataBaseName"
        Me.grpSqlDataBaseName.Size = New System.Drawing.Size(263, 46)
        Me.grpSqlDataBaseName.TabIndex = 10
        Me.grpSqlDataBaseName.TabStop = False
        Me.grpSqlDataBaseName.Text = "Data Base :"
        '
        'cmbSqlDataBaseName
        '
        Me.cmbSqlDataBaseName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbSqlDataBaseName.FormattingEnabled = True
        Me.cmbSqlDataBaseName.Location = New System.Drawing.Point(3, 16)
        Me.cmbSqlDataBaseName.Name = "cmbSqlDataBaseName"
        Me.cmbSqlDataBaseName.Size = New System.Drawing.Size(257, 21)
        Me.cmbSqlDataBaseName.TabIndex = 0
        '
        'chkAuthenticationWin
        '
        Me.chkAuthenticationWin.AutoSize = True
        Me.chkAuthenticationWin.Location = New System.Drawing.Point(139, 71)
        Me.chkAuthenticationWin.Name = "chkAuthenticationWin"
        Me.chkAuthenticationWin.Size = New System.Drawing.Size(119, 17)
        Me.chkAuthenticationWin.TabIndex = 11
        Me.chkAuthenticationWin.Text = "Authentication Win."
        Me.chkAuthenticationWin.UseVisualStyleBackColor = True
        '
        'grpProvider
        '
        Me.grpProvider.Controls.Add(Me.lblProvider)
        Me.grpProvider.Location = New System.Drawing.Point(6, 208)
        Me.grpProvider.Name = "grpProvider"
        Me.grpProvider.Size = New System.Drawing.Size(348, 42)
        Me.grpProvider.TabIndex = 12
        Me.grpProvider.TabStop = False
        Me.grpProvider.Text = "Provider :"
        '
        'lblProvider
        '
        Me.lblProvider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProvider.Location = New System.Drawing.Point(3, 16)
        Me.lblProvider.Name = "lblProvider"
        Me.lblProvider.Size = New System.Drawing.Size(342, 23)
        Me.lblProvider.TabIndex = 0
        Me.lblProvider.Text = "<none>"
        '
        'tabConfiguration
        '
        Me.tabConfiguration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabConfiguration.Controls.Add(Me.tabSqlConfig)
        Me.tabConfiguration.Location = New System.Drawing.Point(7, 10)
        Me.tabConfiguration.Name = "tabConfiguration"
        Me.tabConfiguration.SelectedIndex = 0
        Me.tabConfiguration.Size = New System.Drawing.Size(366, 277)
        Me.tabConfiguration.TabIndex = 2
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 329)
        Me.Controls.Add(Me.tabConfiguration)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmConfig"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuration"
        Me.tabSqlConfig.ResumeLayout(False)
        Me.tabSqlConfig.PerformLayout()
        Me.grpServerName.ResumeLayout(False)
        Me.grpServerName.PerformLayout()
        Me.grpSqlUser.ResumeLayout(False)
        Me.grpSqlUser.PerformLayout()
        Me.grpSqlPassword.ResumeLayout(False)
        Me.grpSqlPassword.PerformLayout()
        Me.grpSqlDataBaseName.ResumeLayout(False)
        Me.grpProvider.ResumeLayout(False)
        Me.tabConfiguration.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tabSqlConfig As TabPage
    Friend WithEvents grpProvider As GroupBox
    Friend WithEvents lblProvider As Label
    Friend WithEvents chkAuthenticationWin As CheckBox
    Friend WithEvents grpSqlDataBaseName As GroupBox
    Friend WithEvents cmbSqlDataBaseName As ComboBox
    Friend WithEvents grpSqlPassword As GroupBox
    Friend WithEvents txtSqlPassword As TextBox
    Friend WithEvents grpSqlUser As GroupBox
    Friend WithEvents txtSqlUser As TextBox
    Friend WithEvents grpServerName As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents tabConfiguration As TabControl
End Class
