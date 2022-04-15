Public Class ProviderBuilder
    Private provider As New ProviderModel

    Public Function Build() As ProviderModel
        My.Settings.Server = provider.Servername
        My.Settings.User = provider.UserSql
        My.Settings.Password = provider.PassSql
        My.Settings.AuthenticWin = provider.AuthenticWin
        My.Settings.Provider = _MakeProvider()
        My.Settings.FirstStart = provider.FirstStart
        My.Settings.Save()
        Return provider
    End Function

    Public Function Init() As ProviderModel
        provider.Servername = My.Settings.Server
        provider.UserSql = My.Settings.User
        provider.PassSql = My.Settings.Password
        provider.DataBase = My.Settings.DataBase
        provider.AuthenticWin = My.Settings.AuthenticWin
        provider.Provider = My.Settings.Provider
        provider.FirstStart = My.Settings.FirstStart
        Return provider
    End Function

    Public Function SetServerName(value As String) As ProviderBuilder
        provider.Servername = value
        Return Me
    End Function

    Public Function SetUserName(value As String) As ProviderBuilder
        provider.UserSql = value
        Return Me
    End Function

    Public Function SetPassword(value As String) As ProviderBuilder
        provider.PassSql = value
        Return Me
    End Function

    Public Function SetAuthenticationWin(value As Boolean) As ProviderBuilder
        provider.AuthenticWin = value
        Return Me
    End Function

    Public Function SetDataBase(value As String) As ProviderBuilder
        provider.DataBase = value
        Return Me
    End Function

    Public Function SetFirstStart(value As Boolean) As ProviderBuilder
        provider.FirstStart = value
        Return Me
    End Function
    Private Function _MakeProvider() As String
        Dim result As String
        If Me.provider.AuthenticWin Then
            result = $"Data Source={provider.Servername};Initial Catalog={provider.DataBase};Integrated Security=True"
        Else
            result = $"Data Source={provider.Servername};Initial Catalog={provider.DataBase};User ID={provider.UserSql};Password={provider.PassSql}"
        End If
        Return result
    End Function
End Class
