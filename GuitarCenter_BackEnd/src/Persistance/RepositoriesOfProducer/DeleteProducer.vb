Imports System.Data.SqlClient

Friend Class DeleteProducer
    Inherits OperationsBaseAbstract
    ReadOnly item As ProducerModel
    Dim errLog As ErrorLog_Singleton
    Public Sub New(item As ProducerModel)
        Me.item = item
        errLog = ErrorLog_Singleton.Instance
        Me.procedureName = "DeleteProducer"
    End Sub

    Protected Friend Overrides Function ExecuteProcedure() As Object
        Dim result As Integer
        Try

            Me.parameters = New List(Of SqlParameter) From
                {
                    New SqlParameter("@ProducerId", item.Id)
                }

            result = Me.ExecuteNonQuery

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
        Return result
    End Function
End Class
