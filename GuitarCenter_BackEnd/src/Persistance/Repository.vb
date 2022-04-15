
Imports GuitarCenter_BackEnd

Public Class Repository : Implements IDataBase
    Dim query As String
    Dim items As List(Of GuitarModel)
    Dim item As GuitarModel
    Dim errLog As ErrorLog_Singleton
    Public Sub New()
        errLog = ErrorLog_Singleton.Instance
        query = "SELECT [IdGuitar],[Brand],[NumStrings],[colors],[Type],[price],[IdProducer],[Name],[Country] FROM [dbo].[viewAllData]"
        DataService.SetQuery(query, Me)
    End Sub
    Public Function DbReader(rd As IDataReader) As Object Implements IDataBase.DbReader
        Try
            items = New List(Of GuitarModel)


            While rd.Read()
                item = New GuitarModel()
                item.Id = rd.GetGuid(0)
                item.Brand = rd.GetString(1)
                item.NumberOfStrings = rd.GetInt32(2)
                item.Color = rd.GetValue(3)
                item.TypeOfGuitar = rd.GetInt32(4)
                item.Price = rd.GetDecimal(5)
                item.ProducerId = rd.GetGuid(6)
                item.Producer.Id = rd.GetGuid(6)
                item.Producer.Name = rd.GetString(7)
                item.Producer.Country = rd.GetString(8)
                items.Add(item)
            End While

        Catch ex As Exception
            errLog.LogError(ex)
        End Try

        Return Nothing
    End Function

    Public Function GetItems() As List(Of GuitarModel)
        Return items
    End Function

    Public Function GetItems(idProducer As Guid) As List(Of GuitarModel)
        Return items.FindAll(Function(p) p.ProducerId = idProducer)
    End Function

    Public Function GetItem(id As Guid) As GuitarModel
        Return items.Find(Function(i) i.Id = id)
    End Function

End Class
