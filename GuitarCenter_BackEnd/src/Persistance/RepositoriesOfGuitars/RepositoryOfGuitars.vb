Imports GuitarCenter_BackEnd

Public Class RepositoryOfGuitars : Implements IDataBase
    Private items As List(Of GuitarModel)
    Private query As String
    Dim errLog As ErrorLog_Singleton
    Public Sub New()
        errLog = ErrorLog_Singleton.Instance
        Me.query = "SELECT [Id],[Brand],[NumberOfString],[Color],[Price],[ProducerId],[TypeOfGuitar] FROM [dbo].[GuitarModel] ORDER BY [Brand];"
        DataService.SetQuery(Me.query, Me)
    End Sub

    Public Function DbReader(rd As IDataReader) As Object Implements IDataBase.DbReader
        Try
            Dim item As GuitarModel
            items = New List(Of GuitarModel)

            While rd.Read()
                item = New GuitarModel()
                item.Id = rd.GetGuid(0)
                item.Brand = rd.GetString(1)
                item.NumberOfStrings = rd.GetInt32(2)
                item.Color = rd.GetValue(3)
                item.Price = rd.GetDecimal(4)
                item.ProducerId = rd.GetGuid(5)
                item.TypeOfGuitar = rd.GetInt32(6)
                Me.items.Add(item)
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
