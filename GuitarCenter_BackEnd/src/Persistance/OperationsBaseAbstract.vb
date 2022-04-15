Imports System.Data.SqlClient

Friend MustInherit Class OperationsBaseAbstract
    Protected procedureName As String
    Protected Property parameters As List(Of SqlParameter)
    Protected Friend MustOverride Function ExecuteProcedure() As Object

    Protected Function ExecuteScalar() As Guid

        Return DataService.SetProcedureExecuteScalar(parameters, procedureName)
    End Function

    Protected Function ExecuteNonQuery() As Integer

        Return DataService.SetProcedureExecuteNonQuery(parameters, procedureName)
    End Function

End Class
