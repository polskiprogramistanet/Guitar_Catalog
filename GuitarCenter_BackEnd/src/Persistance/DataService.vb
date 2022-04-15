Imports System.Data.SqlClient

Module DataService
    Dim errLog As ErrorLog_Singleton
    Function CreateConnection() As SqlConnection
        Dim c As New SqlConnection()
        errLog = ErrorLog_Singleton.Instance
        c.ConnectionString = Configuration.Provider

        Return c
    End Function

    Public Function SetQuery(ByVal sql As String, ByVal db As IDataBase)

        Dim r As SqlDataReader = Nothing

        Using conn As SqlConnection = CreateConnection()
            Try
                conn.Open()
                Dim cmd As SqlCommand = New SqlCommand(sql, conn)
                r = cmd.ExecuteReader()
            Catch ex As Exception
                errLog.LogError(ex)
            End Try
            Return db.DbReader(r)
        End Using

    End Function

    Public Function SetProcedureExecuteScalar(param As List(Of SqlParameter), procedureName As String) As Guid
        Dim result As Object = Nothing
        Using conn As SqlConnection = CreateConnection()

            Try
                conn.Open()
                Dim cmd As SqlCommand = New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = procedureName
                cmd.Connection = conn
                cmd.Parameters.AddRange(param.ToArray())
                result = cmd.ExecuteScalar()

            Catch ex As Exception
                errLog.LogError(ex)
            End Try
            Return Guid.Parse(result.ToString)
        End Using
    End Function

    Public Function SetProcedureExecuteNonQuery(param As List(Of SqlParameter), procedureName As String) As Integer
        Dim result As Integer
        Using conn As SqlConnection = CreateConnection()

            Try
                conn.Open()
                Dim cmd As SqlCommand = New SqlCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = procedureName
                cmd.Connection = conn
                cmd.Parameters.AddRange(param.ToArray())
                result = cmd.ExecuteNonQuery()

            Catch ex As Exception
                errLog.LogError(ex)
            End Try
            Return result
        End Using
    End Function

    Public Function CreateTable(rd As IDataReader) As Object
        Dim table As New DataTable("guitar_center")

        For i As Integer = 0 To rd.FieldCount-1
            table.Columns.Add(rd.GetName(i), rd.GetFieldType(i))
        Next

        While rd.Read()
            Dim r As DataRow = table.NewRow()
            For a As Integer = 0 To rd.FieldCount-1
                r(a) = rd.GetValue(a)

            Next
            table.Rows.Add(r)
        End While
        Return table
    End Function

End Module
