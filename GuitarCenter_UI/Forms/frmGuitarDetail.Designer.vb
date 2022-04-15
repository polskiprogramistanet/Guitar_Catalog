<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuitarDetail
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.grpBrand = New System.Windows.Forms.GroupBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.grpNumOfStrings = New System.Windows.Forms.GroupBox()
        Me.cmbNumOfStrings = New System.Windows.Forms.ComboBox()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.cmbColor = New System.Windows.Forms.ComboBox()
        Me.grpTypeOfGuitar = New System.Windows.Forms.GroupBox()
        Me.cmbTypeOfGuitar = New System.Windows.Forms.ComboBox()
        Me.grpProducer = New System.Windows.Forms.GroupBox()
        Me.grpProducerName = New System.Windows.Forms.GroupBox()
        Me.lblProducerName = New System.Windows.Forms.Label()
        Me.lnkSelectProducer = New System.Windows.Forms.LinkLabel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpPrice = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.pnlHeader.SuspendLayout()
        Me.grpBrand.SuspendLayout()
        Me.grpNumOfStrings.SuspendLayout()
        Me.grpColor.SuspendLayout()
        Me.grpTypeOfGuitar.SuspendLayout()
        Me.grpProducer.SuspendLayout()
        Me.grpProducerName.SuspendLayout()
        Me.grpPrice.SuspendLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(508, 42)
        Me.pnlHeader.TabIndex = 4
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(132, 18)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Add new guitar"
        '
        'grpBrand
        '
        Me.grpBrand.Controls.Add(Me.txtBrand)
        Me.grpBrand.Location = New System.Drawing.Point(14, 58)
        Me.grpBrand.Name = "grpBrand"
        Me.grpBrand.Size = New System.Drawing.Size(161, 43)
        Me.grpBrand.TabIndex = 1
        Me.grpBrand.TabStop = False
        Me.grpBrand.Text = "Brand :"
        '
        'txtBrand
        '
        Me.txtBrand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBrand.Location = New System.Drawing.Point(3, 16)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(155, 20)
        Me.txtBrand.TabIndex = 0
        '
        'grpNumOfStrings
        '
        Me.grpNumOfStrings.Controls.Add(Me.cmbNumOfStrings)
        Me.grpNumOfStrings.Location = New System.Drawing.Point(15, 107)
        Me.grpNumOfStrings.Name = "grpNumOfStrings"
        Me.grpNumOfStrings.Size = New System.Drawing.Size(160, 43)
        Me.grpNumOfStrings.TabIndex = 2
        Me.grpNumOfStrings.TabStop = False
        Me.grpNumOfStrings.Text = "Number of strings :"
        '
        'cmbNumOfStrings
        '
        Me.cmbNumOfStrings.FormattingEnabled = True
        Me.cmbNumOfStrings.Items.AddRange(New Object() {"4", "5", "6", "7", "12"})
        Me.cmbNumOfStrings.Location = New System.Drawing.Point(35, 16)
        Me.cmbNumOfStrings.Name = "cmbNumOfStrings"
        Me.cmbNumOfStrings.Size = New System.Drawing.Size(121, 21)
        Me.cmbNumOfStrings.TabIndex = 0
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.cmbColor)
        Me.grpColor.Location = New System.Drawing.Point(14, 156)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(160, 43)
        Me.grpColor.TabIndex = 3
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Color :"
        '
        'cmbColor
        '
        Me.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColor.FormattingEnabled = True
        Me.cmbColor.Items.AddRange(New Object() {"Black", "White", "Yellow", "Red", "Pink", "Blue"})
        Me.cmbColor.Location = New System.Drawing.Point(35, 16)
        Me.cmbColor.Name = "cmbColor"
        Me.cmbColor.Size = New System.Drawing.Size(121, 21)
        Me.cmbColor.TabIndex = 0
        '
        'grpTypeOfGuitar
        '
        Me.grpTypeOfGuitar.Controls.Add(Me.cmbTypeOfGuitar)
        Me.grpTypeOfGuitar.Location = New System.Drawing.Point(14, 205)
        Me.grpTypeOfGuitar.Name = "grpTypeOfGuitar"
        Me.grpTypeOfGuitar.Size = New System.Drawing.Size(160, 43)
        Me.grpTypeOfGuitar.TabIndex = 4
        Me.grpTypeOfGuitar.TabStop = False
        Me.grpTypeOfGuitar.Text = "Type :"
        '
        'cmbTypeOfGuitar
        '
        Me.cmbTypeOfGuitar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeOfGuitar.FormattingEnabled = True
        Me.cmbTypeOfGuitar.Items.AddRange(New Object() {"Electric Guitar", "Bass Guitar", "Acoustic Guitar", "Banjo"})
        Me.cmbTypeOfGuitar.Location = New System.Drawing.Point(35, 16)
        Me.cmbTypeOfGuitar.Name = "cmbTypeOfGuitar"
        Me.cmbTypeOfGuitar.Size = New System.Drawing.Size(121, 21)
        Me.cmbTypeOfGuitar.TabIndex = 0
        '
        'grpProducer
        '
        Me.grpProducer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProducer.Controls.Add(Me.grpProducerName)
        Me.grpProducer.Controls.Add(Me.lnkSelectProducer)
        Me.grpProducer.Location = New System.Drawing.Point(181, 58)
        Me.grpProducer.Name = "grpProducer"
        Me.grpProducer.Size = New System.Drawing.Size(317, 122)
        Me.grpProducer.TabIndex = 6
        Me.grpProducer.TabStop = False
        Me.grpProducer.Text = "Producer :"
        '
        'grpProducerName
        '
        Me.grpProducerName.Controls.Add(Me.lblProducerName)
        Me.grpProducerName.Location = New System.Drawing.Point(6, 19)
        Me.grpProducerName.Name = "grpProducerName"
        Me.grpProducerName.Size = New System.Drawing.Size(305, 40)
        Me.grpProducerName.TabIndex = 2
        Me.grpProducerName.TabStop = False
        Me.grpProducerName.Text = "Name :"
        '
        'lblProducerName
        '
        Me.lblProducerName.BackColor = System.Drawing.Color.White
        Me.lblProducerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducerName.Location = New System.Drawing.Point(3, 16)
        Me.lblProducerName.Name = "lblProducerName"
        Me.lblProducerName.Size = New System.Drawing.Size(299, 21)
        Me.lblProducerName.TabIndex = 0
        Me.lblProducerName.Text = "<none>"
        Me.lblProducerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkSelectProducer
        '
        Me.lnkSelectProducer.AutoSize = True
        Me.lnkSelectProducer.Location = New System.Drawing.Point(6, 73)
        Me.lnkSelectProducer.Name = "lnkSelectProducer"
        Me.lnkSelectProducer.Size = New System.Drawing.Size(75, 13)
        Me.lnkSelectProducer.TabIndex = 1
        Me.lnkSelectProducer.TabStop = True
        Me.lnkSelectProducer.Text = "Select from list"
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
        Me.btnCancel.Location = New System.Drawing.Point(428, 255)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 37)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Image = Global.GuitarCenter_UI.My.Resources.Resources.Ok_Gwhite
        Me.btnSave.Location = New System.Drawing.Point(351, 255)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 37)
        Me.btnSave.TabIndex = 7
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'grpPrice
        '
        Me.grpPrice.Controls.Add(Me.Label1)
        Me.grpPrice.Controls.Add(Me.numPrice)
        Me.grpPrice.Location = New System.Drawing.Point(14, 255)
        Me.grpPrice.Name = "grpPrice"
        Me.grpPrice.Size = New System.Drawing.Size(160, 43)
        Me.grpPrice.TabIndex = 5
        Me.grpPrice.TabStop = False
        Me.grpPrice.Text = "Price :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "zł"
        '
        'numPrice
        '
        Me.numPrice.DecimalPlaces = 2
        Me.numPrice.Location = New System.Drawing.Point(34, 17)
        Me.numPrice.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(96, 20)
        Me.numPrice.TabIndex = 0
        Me.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmGuitarDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 304)
        Me.Controls.Add(Me.grpPrice)
        Me.Controls.Add(Me.grpProducer)
        Me.Controls.Add(Me.grpTypeOfGuitar)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.grpNumOfStrings)
        Me.Controls.Add(Me.grpBrand)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmGuitarDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpBrand.ResumeLayout(False)
        Me.grpBrand.PerformLayout()
        Me.grpNumOfStrings.ResumeLayout(False)
        Me.grpColor.ResumeLayout(False)
        Me.grpTypeOfGuitar.ResumeLayout(False)
        Me.grpProducer.ResumeLayout(False)
        Me.grpProducer.PerformLayout()
        Me.grpProducerName.ResumeLayout(False)
        Me.grpPrice.ResumeLayout(False)
        Me.grpPrice.PerformLayout()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents grpBrand As GroupBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents grpNumOfStrings As GroupBox
    Friend WithEvents cmbNumOfStrings As ComboBox
    Friend WithEvents grpColor As GroupBox
    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents grpTypeOfGuitar As GroupBox
    Friend WithEvents cmbTypeOfGuitar As ComboBox
    Friend WithEvents grpProducer As GroupBox
    Friend WithEvents grpProducerName As GroupBox
    Friend WithEvents lblProducerName As Label
    Friend WithEvents lnkSelectProducer As LinkLabel
    Friend WithEvents grpPrice As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents numPrice As NumericUpDown
End Class
