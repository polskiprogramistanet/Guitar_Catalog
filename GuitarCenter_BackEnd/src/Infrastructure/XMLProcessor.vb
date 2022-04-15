Imports System.Data.SqlClient
Imports GuitarCenter_BackEnd

Public Class XMLProcessor : Implements IDataBase, IXmlOperation
    Dim query As String
    Dim dt As DataTable
    Dim observer As IXmlObserver
    Dim errLog As ErrorLog_Singleton
    Public Sub New(observer As IXmlObserver)
        Me.observer = observer
        errLog = ErrorLog_Singleton.Instance
        query = "SELECT [IdGuitar],[Brand],[NumStrings],[colors],[Type],[price],[IdProducer],[Name],[Country] FROM [dbo].[viewAllData]"
        DataService.SetQuery(query, Me)

    End Sub
    Public Function DbReader(rd As IDataReader) As Object Implements IDataBase.DbReader
        Try
            dt = DataService.CreateTable(rd)


        Catch ex As Exception
            errLog.LogError(ex)
            observer.SetNegativeInformation(ex)
        End Try
        Return rd
    End Function

    Public Sub Generate()
        Try

            Me.dt.WriteXml("guitar_center.xml")

            observer.SetPositiveInformation("The file was generated correctly")

        Catch ex As Exception
            errLog.LogError(ex)
            observer.SetNegativeInformation(ex)
        End Try
    End Sub
End Class
