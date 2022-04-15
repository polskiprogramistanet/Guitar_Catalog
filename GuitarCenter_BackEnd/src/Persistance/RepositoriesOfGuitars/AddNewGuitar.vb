Imports System.Data.SqlClient

Friend Class AddNewGuitar
    Inherits OperationsBaseAbstract
    ReadOnly item As GuitarModel
    Dim errLog As ErrorLog_Singleton
    Public Sub New(item As GuitarModel)
        Me.item = item
        Me.procedureName = "AddNewGuitar"
        errLog = ErrorLog_Singleton.Instance
    End Sub
    Protected Friend Overrides Function ExecuteProcedure() As Object
        Dim result As Guid
        Try

            Me.parameters = New List(Of SqlParameter) From
                {
                    New SqlParameter("@Brand", item.Brand),
                    New SqlParameter("@NumberOfString", item.NumberOfStrings),
                    New SqlParameter("@Color", item.Color),
                    New SqlParameter("@Price", item.Price),
                    New SqlParameter("@ProducerId", item.ProducerId),
                    New SqlParameter("@TypeOfGuitar", item.TypeOfGuitar)
                }

            result = Guid.Parse(Me.ExecuteScalar().ToString())

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
        Return result
    End Function
End Class
