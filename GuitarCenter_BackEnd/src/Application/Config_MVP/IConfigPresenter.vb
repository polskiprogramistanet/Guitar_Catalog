Public Interface IConfigPresenter
    Sub Init()
    Function GetConfig() As ProviderModel
    Sub SaveConfig(item As ProviderModel)

End Interface
