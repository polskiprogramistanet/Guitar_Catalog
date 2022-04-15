Imports System.Data.SqlClient

Friend Class DeleteGuitar
    Inherits OperationsBaseAbstract
    ReadOnly item As GuitarModel
    Dim errLog As ErrorLog_Singleton
    Public Sub New(item As GuitarModel)
        Me.item = item
        errLog = ErrorLog_Singleton.Instance
        Me.procedureName = "DeleteGuitar"
    End Sub

    Protected Friend Overrides Function ExecuteProcedure() As Object

        Dim result As Integer
        Try

            Me.parameters = New List(Of SqlParameter) From
                {
                    New SqlParameter("@GuitarId", item.Id)
                }

            result = Me.ExecuteNonQuery

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
        Return result
    End Function
End Class

