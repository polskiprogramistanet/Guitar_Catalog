Imports GuitarCenter_BackEnd
Imports GuitarCenter_BackEnd.ProducerModel

Friend Class RepositoryOfProducers : Implements IDataBase
    Dim query As String
    Dim items As List(Of ProducerModel)
    Dim item As ProducerModel
    Dim errLog As ErrorLog_Singleton
    Public Sub New()
        errLog = ErrorLog_Singleton.Instance
        Me.query = "SELECT [Id], [Name], [Country] FROM [dbo].[Producer] ORDER BY [Name];"
        DataService.SetQuery(Me.query, Me)
    End Sub

    Public Sub New(ProducerId As Guid)
        errLog = ErrorLog_Singleton.Instance
        Me.query = $"SELECT [Id], [Name], [Country] FROM [dbo].[Producer] WHERE [Id] = '{ProducerId}' ORDER BY [Name];"
        DataService.SetQuery(Me.query, Me)
    End Sub

    Public Function DbReader(rd As IDataReader) As Object Implements IDataBase.DbReader

        Try
            Me.items = New List(Of ProducerModel)

            While rd.Read()
                item = New ProducerModel()
                item.Id = rd.GetGuid(0)
                item.Name = rd.GetString(1)
                item.Country = rd.GetString(2)

                Me.items.Add(item)
            End While

        Catch ex As Exception
            errLog.LogError(ex)
        End Try

        Return Nothing
    End Function

    Public Function GetItems() As List(Of ProducerModel)
        Return Me.items
    End Function

    Public Function GetItems(country As String) As List(Of ProducerModel)
        Return Me.items.FindAll(Function(c) c.Country = country)
    End Function

    Public Function GetItem(id As Guid) As ProducerModel
        Return Me.items.Find(Function(i) i.Id = id)
    End Function

End Class
