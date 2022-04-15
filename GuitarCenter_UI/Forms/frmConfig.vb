Imports GuitarCenter_BackEnd

Public Class frmConfig : Implements IConfigView

    Private presenter As IConfigPresenter
    Private model As ProviderModel
    Dim errLog As ErrorLog_Singleton
    Public Sub New()

        InitializeComponent()
        presenter = New ConfigPresenter(Me)
        errLog = ErrorLog_Singleton.Instance
    End Sub

    Public Sub SetProviderInformation() Implements IConfigView.SetProviderInformation

    End Sub

    Private Sub chkAuthenticationWin_CheckedChanged(sender As Object, e As EventArgs) Handles chkAuthenticationWin.CheckedChanged
        Try
            If Me.chkAuthenticationWin.Checked Then
                Me.grpSqlUser.Enabled = False
                Me.grpSqlPassword.Enabled = False
            Else
                Me.grpSqlUser.Enabled = True
                Me.grpSqlPassword.Enabled = True
            End If

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            presenter.Init()
            model = presenter.GetConfig

            Me.txtName.Text = model.Servername
            Me.txtSqlUser.Text = model.UserSql
            Me.txtSqlPassword.Text = model.PassSql
            Me.chkAuthenticationWin.Checked = model.AuthenticWin
            Me.cmbSqlDataBaseName.Text = model.DataBase
            Me.lblProvider.Text = model.Provider

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            model = New ProviderModel With {
                .Servername = Me.txtName.Text,
                .DataBase = Me.cmbSqlDataBaseName.Text,
                .UserSql = Me.txtSqlUser.Text,
                .AuthenticWin = Me.chkAuthenticationWin.Checked,
                .PassSql = Me.txtSqlPassword.Text
            }

            presenter.SaveConfig(model)

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub
End Class