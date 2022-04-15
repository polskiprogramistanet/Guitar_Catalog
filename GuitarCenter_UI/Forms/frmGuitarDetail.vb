Imports GuitarCenter_BackEnd
Public Class frmGuitarDetail
    Dim errLog As ErrorLog_Singleton
    Dim item As GuitarModel

    Public ReadOnly Property Guitar As GuitarModel
        Get
            Return item
        End Get

    End Property

    Public Sub New(item As GuitarModel)
        InitializeComponent()
        errLog = ErrorLog_Singleton.Instance
        Me.item = item
        Me.lblHeaderTitle.Text = "Edit guitar"

    End Sub

    Public Sub New()
        InitializeComponent()
        errLog = ErrorLog_Singleton.Instance
        Me.item = New GuitarModel
        Me.lblHeaderTitle.Text = "Add new guitar"

    End Sub

    Private Sub lnkSelectProducer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSelectProducer.LinkClicked
        Try

            Dim frm As New frmProducersList()
            If (frm.ShowDialog(Me) = DialogResult.Yes) Then
                item.Producer = frm.Producer
                item.ProducerId = frm.Producer.Id
                Me.lblProducerName.Text = frm.Producer.Name

            End If

            Validation()
        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub Validation()
        If Me.txtBrand.Text.Length > 0 And Me.item.Producer.Name IsNot Nothing Then
            Me.btnSave.Enabled = True
        Else
            Me.btnSave.Enabled = False
        End If
    End Sub

    Private Sub frmGuitarDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.txtBrand.Text = item.Brand
            Me.cmbColor.SelectedIndex = item.Color
            Me.cmbNumOfStrings.Text = item.NumberOfStrings
            Me.cmbTypeOfGuitar.SelectedIndex = item.TypeOfGuitar
            Me.numPrice.Value = item.Price
            Me.lblProducerName.Text = item.Producer.Name
        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            item.Brand = Me.txtBrand.Text
            item.Color = Me.cmbColor.SelectedIndex
            item.NumberOfStrings = Me.cmbNumOfStrings.Text
            item.Price = Me.numPrice.Value
            item.TypeOfGuitar = Me.cmbTypeOfGuitar.SelectedIndex

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub txtBrand_Validated(sender As Object, e As EventArgs) Handles txtBrand.Validated
        Validation()
    End Sub
End Class