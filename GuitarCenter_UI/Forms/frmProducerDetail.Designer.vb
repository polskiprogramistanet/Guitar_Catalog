<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducerDetail
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
        Me.grpProducerDetail = New System.Windows.Forms.GroupBox()
        Me.grpName = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpCountry = New System.Windows.Forms.GroupBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.picProducer = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpProducerDetail.SuspendLayout()
        Me.grpName.SuspendLayout()
        Me.grpCountry.SuspendLayout()
        CType(Me.picProducer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpProducerDetail
        '
        Me.grpProducerDetail.Controls.Add(Me.grpName)
        Me.grpProducerDetail.Controls.Add(Me.grpCountry)
        Me.grpProducerDetail.Location = New System.Drawing.Point(12, 12)
        Me.grpProducerDetail.Name = "grpProducerDetail"
        Me.grpProducerDetail.Size = New System.Drawing.Size(266, 146)
        Me.grpProducerDetail.TabIndex = 10
        Me.grpProducerDetail.TabStop = False
        Me.grpProducerDetail.Text = "Detail :"
        '
        'grpName
        '
        Me.grpName.Controls.Add(Me.txtName)
        Me.grpName.Location = New System.Drawing.Point(6, 19)
        Me.grpName.Name = "grpName"
        Me.grpName.Size = New System.Drawing.Size(254, 43)
        Me.grpName.TabIndex = 6
        Me.grpName.TabStop = False
        Me.grpName.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Location = New System.Drawing.Point(3, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(248, 20)
        Me.txtName.TabIndex = 0
        '
        'grpCountry
        '
        Me.grpCountry.Controls.Add(Me.txtCountry)
        Me.grpCountry.Location = New System.Drawing.Point(6, 68)
        Me.grpCountry.Name = "grpCountry"
        Me.grpCountry.Size = New System.Drawing.Size(254, 43)
        Me.grpCountry.TabIndex = 7
        Me.grpCountry.TabStop = False
        Me.grpCountry.Text = "Country :"
        '
        'txtCountry
        '
        Me.txtCountry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCountry.Location = New System.Drawing.Point(3, 16)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(248, 20)
        Me.txtCountry.TabIndex = 0
        '
        'picProducer
        '
        Me.picProducer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picProducer.Image = Global.GuitarCenter_UI.My.Resources.Resources.blac_customers
        Me.picProducer.Location = New System.Drawing.Point(303, 25)
        Me.picProducer.Name = "picProducer"
        Me.picProducer.Size = New System.Drawing.Size(52, 42)
        Me.picProducer.TabIndex = 13
        Me.picProducer.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Salmon
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = Global.GuitarCenter_UI.My.Resources.Resources.No_Gwhite
        Me.btnCancel.Location = New System.Drawing.Point(285, 121)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 37)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(285, 79)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 37)
        Me.btnSave.TabIndex = 11
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmProducerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 170)
        Me.Controls.Add(Me.picProducer)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpProducerDetail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmProducerDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Producer detail"
        Me.grpProducerDetail.ResumeLayout(False)
        Me.grpName.ResumeLayout(False)
        Me.grpName.PerformLayout()
        Me.grpCountry.ResumeLayout(False)
        Me.grpCountry.PerformLayout()
        CType(Me.picProducer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpProducerDetail As GroupBox
    Friend WithEvents grpName As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpCountry As GroupBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents picProducer As PictureBox
End Class
