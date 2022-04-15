
Imports GuitarCenter_BackEnd

Public Class ConfigPresenter
    Implements IConfigPresenter
    Private view As IConfigView
    Private presenter As IConfigPresenter
    Private model As ConfgModel

    Public Sub New(view As IConfigView)
        Me.view = view
        Me.model = New ConfgModel()


    End Sub
    Public Sub Init() Implements IConfigPresenter.Init
    End Sub

    Public Sub SaveConfig(item As ProviderModel) Implements IConfigPresenter.SaveConfig
        Me.model.SetData(item)
        Me.model.SaveConfig()
    End Sub

    Public Function GetConfig() As ProviderModel Implements IConfigPresenter.GetConfig

        Return model.GetData()

    End Function
End Class
