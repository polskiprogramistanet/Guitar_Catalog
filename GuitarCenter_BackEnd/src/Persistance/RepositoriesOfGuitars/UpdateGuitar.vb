Imports System.Data.SqlClient

Friend Class UpdateGuitar
    Inherits OperationsBaseAbstract
    Dim errLog As ErrorLog_Singleton
    ReadOnly item As GuitarModel
    Public Sub New(item As GuitarModel)
        Me.item = item
        errLog = ErrorLog_Singleton.Instance
        Me.procedureName = "UpdateGuitar"
    End Sub

    Protected Friend Overrides Function ExecuteProcedure() As Object
        Dim result As Integer
        Try

            Me.parameters = New List(Of SqlParameter) From
                {
                    New SqlParameter("@Brand", item.Brand),
                    New SqlParameter("@NumberOfString", item.NumberOfStrings),
                    New SqlParameter("@Color", item.Color),
                    New SqlParameter("@Price", item.Price),
                    New SqlParameter("@ProducerId", item.ProducerId),
                    New SqlParameter("@TypeOfGuitar", item.TypeOfGuitar),
                    New SqlParameter("@Id", item.Id)
                }

            result = Me.ExecuteNonQuery

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
        Return result
    End Function
End Class
