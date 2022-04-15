Imports GuitarCenter_BackEnd

Public Class frmProducerDetail
    Dim item As ProducerModel
    Dim errLog As ErrorLog_Singleton

    Public ReadOnly Property Producer() As ProducerModel
        Get
            Return item
        End Get

    End Property
    Public Sub New(item As ProducerModel)
        InitializeComponent()
        errLog = ErrorLog_Singleton.Instance
        Me.item = item
        Me.Text = "Edit producer"

    End Sub
    Public Sub New()
        InitializeComponent()
        errLog = ErrorLog_Singleton.Instance
        item = New ProducerModel()
        Me.Text = "Add new producer"

    End Sub
    Private Sub frmProducerDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.txtName.Text = item.Name
            Me.txtCountry.Text = item.Country

        Catch ex As Exception
            errLog.LogError(ex)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            item.Name = txtName.Text.Trim()
            item.Country = txtCountry.Text.Trim()
            Me.DialogResult = DialogResult.Yes

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub
End Class