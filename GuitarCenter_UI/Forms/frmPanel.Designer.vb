<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPanel
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPanel))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.grpProducer = New System.Windows.Forms.GroupBox()
        Me.lblProducerName = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tlsConfiguration = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tlsSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsDictionares = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tlsProducer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsHelper = New System.Windows.Forms.ToolStripDropDownButton()
        Me.picGuitarCenter = New System.Windows.Forms.PictureBox()
        Me.flpDetail = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnExportToXmlFile = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.dgcBrand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcNumberOfStrings = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcColor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        Me.grpProducer.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.picGuitarCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.grpProducer)
        Me.pnlHeader.Controls.Add(Me.ToolStrip1)
        Me.pnlHeader.Controls.Add(Me.picGuitarCenter)
        Me.pnlHeader.Controls.Add(Me.flpDetail)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(670, 113)
        Me.pnlHeader.TabIndex = 0
        '
        'grpProducer
        '
        Me.grpProducer.Controls.Add(Me.lblProducerName)
        Me.grpProducer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpProducer.Location = New System.Drawing.Point(10, 28)
        Me.grpProducer.Name = "grpProducer"
        Me.grpProducer.Size = New System.Drawing.Size(394, 67)
        Me.grpProducer.TabIndex = 7
        Me.grpProducer.TabStop = False
        Me.grpProducer.Text = "Producer :"
        '
        'lblProducerName
        '
        Me.lblProducerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProducerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblProducerName.Location = New System.Drawing.Point(3, 16)
        Me.lblProducerName.Name = "lblProducerName"
        Me.lblProducerName.Size = New System.Drawing.Size(388, 48)
        Me.lblProducerName.TabIndex = 0
        Me.lblProducerName.Text = "<none>"
        Me.lblProducerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsConfiguration, Me.tlsDictionares, Me.tlsHelper})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(537, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlsConfiguration
        '
        Me.tlsConfiguration.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsSettings})
        Me.tlsConfiguration.Image = Global.GuitarCenter_UI.My.Resources.Resources.minmalize_1
        Me.tlsConfiguration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsConfiguration.Name = "tlsConfiguration"
        Me.tlsConfiguration.Size = New System.Drawing.Size(110, 22)
        Me.tlsConfiguration.Text = "Configuration"
        '
        'tlsSettings
        '
        Me.tlsSettings.Name = "tlsSettings"
        Me.tlsSettings.Size = New System.Drawing.Size(180, 22)
        Me.tlsSettings.Text = "Settings"
        '
        'tlsDictionares
        '
        Me.tlsDictionares.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsProducer})
        Me.tlsDictionares.Image = Global.GuitarCenter_UI.My.Resources.Resources.minmalize_1
        Me.tlsDictionares.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsDictionares.Name = "tlsDictionares"
        Me.tlsDictionares.Size = New System.Drawing.Size(95, 22)
        Me.tlsDictionares.Text = "Dictionares"
        '
        'tlsProducer
        '
        Me.tlsProducer.Name = "tlsProducer"
        Me.tlsProducer.Size = New System.Drawing.Size(127, 22)
        Me.tlsProducer.Text = "Producers"
        '
        'tlsHelper
        '
        Me.tlsHelper.Image = Global.GuitarCenter_UI.My.Resources.Resources.minmalize_1
        Me.tlsHelper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsHelper.Name = "tlsHelper"
        Me.tlsHelper.Size = New System.Drawing.Size(61, 22)
        Me.tlsHelper.Text = "Help"
        '
        'picGuitarCenter
        '
        Me.picGuitarCenter.Dock = System.Windows.Forms.DockStyle.Right
        Me.picGuitarCenter.Image = Global.GuitarCenter_UI.My.Resources.Resources.guitars
        Me.picGuitarCenter.Location = New System.Drawing.Point(537, 0)
        Me.picGuitarCenter.Name = "picGuitarCenter"
        Me.picGuitarCenter.Size = New System.Drawing.Size(133, 113)
        Me.picGuitarCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGuitarCenter.TabIndex = 5
        Me.picGuitarCenter.TabStop = False
        '
        'flpDetail
        '
        Me.flpDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpDetail.Location = New System.Drawing.Point(0, 113)
        Me.flpDetail.Name = "flpDetail"
        Me.flpDetail.Size = New System.Drawing.Size(670, 324)
        Me.flpDetail.TabIndex = 3
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.btnExportToXmlFile)
        Me.pnlBottom.Controls.Add(Me.btnRemove)
        Me.pnlBottom.Controls.Add(Me.btnUpdate)
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Controls.Add(Me.btnAdd)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 421)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(670, 56)
        Me.pnlBottom.TabIndex = 2
        '
        'btnExportToXmlFile
        '
        Me.btnExportToXmlFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExportToXmlFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExportToXmlFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportToXmlFile.Location = New System.Drawing.Point(305, 6)
        Me.btnExportToXmlFile.Name = "btnExportToXmlFile"
        Me.btnExportToXmlFile.Size = New System.Drawing.Size(121, 25)
        Me.btnExportToXmlFile.TabIndex = 7
        Me.btnExportToXmlFile.Text = "Export to XML "
        Me.btnExportToXmlFile.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Location = New System.Drawing.Point(138, 5)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(60, 25)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Delete"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(74, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(60, 25)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Edit"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(607, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 40)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(10, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 25)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToAddRows = False
        Me.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcBrand, Me.dgcNumberOfStrings, Me.dgcColor, Me.dgcPrice, Me.dgcId})
        Me.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetail.Location = New System.Drawing.Point(0, 113)
        Me.dgvDetail.MultiSelect = False
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.ReadOnly = True
        Me.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetail.Size = New System.Drawing.Size(670, 308)
        Me.dgvDetail.TabIndex = 3
        '
        'dgcBrand
        '
        Me.dgcBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgcBrand.HeaderText = "Brand"
        Me.dgcBrand.Name = "dgcBrand"
        Me.dgcBrand.ReadOnly = True
        '
        'dgcNumberOfStrings
        '
        Me.dgcNumberOfStrings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgcNumberOfStrings.HeaderText = "Number of strings"
        Me.dgcNumberOfStrings.Name = "dgcNumberOfStrings"
        Me.dgcNumberOfStrings.ReadOnly = True
        Me.dgcNumberOfStrings.Width = 78
        '
        'dgcColor
        '
        Me.dgcColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgcColor.HeaderText = "Color"
        Me.dgcColor.Name = "dgcColor"
        Me.dgcColor.ReadOnly = True
        Me.dgcColor.Width = 56
        '
        'dgcPrice
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgcPrice.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgcPrice.HeaderText = "Price"
        Me.dgcPrice.Name = "dgcPrice"
        Me.dgcPrice.ReadOnly = True
        '
        'dgcId
        '
        Me.dgcId.HeaderText = "id"
        Me.dgcId.Name = "dgcId"
        Me.dgcId.ReadOnly = True
        Me.dgcId.Visible = False
        '
        'frmPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 477)
        Me.Controls.Add(Me.dgvDetail)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBottom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "frmPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guitar Center"
        Me.TopMost = True
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.grpProducer.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.picGuitarCenter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents flpDetail As FlowLayoutPanel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents picGuitarCenter As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tlsConfiguration As ToolStripDropDownButton
    Friend WithEvents tlsSettings As ToolStripMenuItem
    Friend WithEvents grpProducer As GroupBox
    Friend WithEvents tlsDictionares As ToolStripDropDownButton
    Friend WithEvents tlsProducer As ToolStripMenuItem
    Friend WithEvents btnExportToXmlFile As Button
    Friend WithEvents dgcBrand As DataGridViewTextBoxColumn
    Friend WithEvents dgcNumberOfStrings As DataGridViewTextBoxColumn
    Friend WithEvents dgcColor As DataGridViewTextBoxColumn
    Friend WithEvents dgcPrice As DataGridViewTextBoxColumn
    Friend WithEvents dgcId As DataGridViewTextBoxColumn
    Friend WithEvents lblProducerName As Label
    Friend WithEvents tlsHelper As ToolStripDropDownButton
End Class
