<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducersList
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
        Me.dgvProducers = New System.Windows.Forms.DataGridView()
        Me.dgcName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lnkAddProducer = New System.Windows.Forms.LinkLabel()
        Me.lnkEditProducer = New System.Windows.Forms.LinkLabel()
        Me.lnkDeleteProducer = New System.Windows.Forms.LinkLabel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvProducers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(473, 42)
        Me.pnlHeader.TabIndex = 5
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(87, 18)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Producers"
        '
        'dgvProducers
        '
        Me.dgvProducers.AllowUserToAddRows = False
        Me.dgvProducers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcName, Me.dgcCountry, Me.dgcId})
        Me.dgvProducers.Location = New System.Drawing.Point(12, 48)
        Me.dgvProducers.MultiSelect = False
        Me.dgvProducers.Name = "dgvProducers"
        Me.dgvProducers.ReadOnly = True
        Me.dgvProducers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducers.Size = New System.Drawing.Size(449, 148)
        Me.dgvProducers.TabIndex = 8
        '
        'dgcName
        '
        Me.dgcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgcName.HeaderText = "Name"
        Me.dgcName.Name = "dgcName"
        Me.dgcName.ReadOnly = True
        '
        'dgcCountry
        '
        Me.dgcCountry.HeaderText = "Country"
        Me.dgcCountry.Name = "dgcCountry"
        Me.dgcCountry.ReadOnly = True
        '
        'dgcId
        '
        Me.dgcId.HeaderText = "Id"
        Me.dgcId.Name = "dgcId"
        Me.dgcId.ReadOnly = True
        Me.dgcId.Visible = False
        '
        'lnkAddProducer
        '
        Me.lnkAddProducer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkAddProducer.AutoSize = True
        Me.lnkAddProducer.Location = New System.Drawing.Point(12, 209)
        Me.lnkAddProducer.Name = "lnkAddProducer"
        Me.lnkAddProducer.Size = New System.Drawing.Size(26, 13)
        Me.lnkAddProducer.TabIndex = 10
        Me.lnkAddProducer.TabStop = True
        Me.lnkAddProducer.Text = "Add"
        Me.lnkAddProducer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lnkEditProducer
        '
        Me.lnkEditProducer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkEditProducer.AutoSize = True
        Me.lnkEditProducer.Location = New System.Drawing.Point(59, 209)
        Me.lnkEditProducer.Name = "lnkEditProducer"
        Me.lnkEditProducer.Size = New System.Drawing.Size(25, 13)
        Me.lnkEditProducer.TabIndex = 11
        Me.lnkEditProducer.TabStop = True
        Me.lnkEditProducer.Text = "Edit"
        Me.lnkEditProducer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lnkDeleteProducer
        '
        Me.lnkDeleteProducer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkDeleteProducer.AutoSize = True
        Me.lnkDeleteProducer.Location = New System.Drawing.Point(106, 209)
        Me.lnkDeleteProducer.Name = "lnkDeleteProducer"
        Me.lnkDeleteProducer.Size = New System.Drawing.Size(38, 13)
        Me.lnkDeleteProducer.TabIndex = 12
        Me.lnkDeleteProducer.TabStop = True
        Me.lnkDeleteProducer.Text = "Delete"
        Me.lnkDeleteProducer.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.btnCancel.Location = New System.Drawing.Point(390, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 37)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelect.BackColor = System.Drawing.Color.Green
        Me.btnSelect.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Image = Global.GuitarCenter_UI.My.Resources.Resources.Ok_Gwhite
        Me.btnSelect.Location = New System.Drawing.Point(313, 205)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(71, 37)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'frmProducersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 254)
        Me.Controls.Add(Me.lnkDeleteProducer)
        Me.Controls.Add(Me.lnkEditProducer)
        Me.Controls.Add(Me.lnkAddProducer)
        Me.Controls.Add(Me.dgvProducers)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmProducersList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvProducers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents dgvProducers As DataGridView
    Friend WithEvents lnkAddProducer As LinkLabel
    Friend WithEvents lnkEditProducer As LinkLabel
    Friend WithEvents lnkDeleteProducer As LinkLabel
    Friend WithEvents dgcName As DataGridViewTextBoxColumn
    Friend WithEvents dgcCountry As DataGridViewTextBoxColumn
    Friend WithEvents dgcId As DataGridViewTextBoxColumn
End Class
