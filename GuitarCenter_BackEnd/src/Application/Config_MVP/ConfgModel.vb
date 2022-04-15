
Public Class ConfgModel
    Private item As ProviderModel
    Private builder As ProviderBuilder
    Dim errLog As ErrorLog_Singleton
    Public Sub New()
        errLog = ErrorLog_Singleton.Instance
        builder = New ProviderBuilder
        item = builder.Init()
    End Sub

    Public Sub SetData(item As ProviderModel)
        Me.item = item
    End Sub

    Public Function GetData() As ProviderModel
        Return item
    End Function

    Public Function GetFirstStart() As Boolean
        Return item.FirstStart
    End Function

    Public Sub SaveConfig()

        Try

            With builder
                .SetServerName(item.Servername)
                .SetDataBase(item.DataBase)
                .SetUserName(item.UserSql)
                .SetPassword(item.PassSql)
                .SetAuthenticationWin(item.AuthenticWin)
                .SetFirstStart(item.FirstStart)
            End With
            item = builder.Build

        Catch ex As Exception
            errLog.LogError(ex)
        End Try

    End Sub
End Class
