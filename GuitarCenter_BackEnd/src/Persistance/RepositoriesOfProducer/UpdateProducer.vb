Imports System.Data.SqlClient

Friend Class UpdateProducer
    Inherits OperationsBaseAbstract
    Dim errLog As ErrorLog_Singleton
    ReadOnly item As ProducerModel
    Public Sub New(item As ProducerModel)
        Me.item = item
        errLog = ErrorLog_Singleton.Instance
        Me.procedureName = "UpdateProducer"
    End Sub

    Protected Friend Overrides Function ExecuteProcedure() As Object
        Dim result As Integer
        Try

            Me.parameters = New List(Of SqlParameter) From
                {
                    New SqlParameter("@Name", item.Name),
                    New SqlParameter("@Country", item.Country),
                    New SqlParameter("@ProducerId", item.Id)
                }

            result = Me.ExecuteNonQuery

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
        Return result
    End Function
End Class
