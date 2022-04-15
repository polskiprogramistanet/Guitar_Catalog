Imports System.Data.SqlClient

Friend Class AddNewProducer
    Inherits OperationsBaseAbstract
    Dim errLog As ErrorLog_Singleton
    ReadOnly item As ProducerModel
    Public Sub New(item As ProducerModel)
        Me.item = item
        errLog = ErrorLog_Singleton.Instance
        Me.procedureName = "AddNewProducer"
    End Sub

    Protected Friend Overrides Function ExecuteProcedure() As Object
        Dim result As Guid
        Try

            Me.parameters = New List(Of SqlParameter) From
                {
                    New SqlParameter("@Name", item.Name),
                    New SqlParameter("@Country", item.Country),
                    New SqlParameter("@ProducerId", item.Id)
                }

            result = Me.ExecuteScalar

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
        Return result
    End Function

End Class
