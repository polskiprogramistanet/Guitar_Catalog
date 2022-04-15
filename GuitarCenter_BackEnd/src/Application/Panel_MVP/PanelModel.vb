Imports GuitarCenter_BackEnd.RepositoryOfGuitars

Friend Class PanelModel
    Private repGuitars As RepositoryOfGuitars
    Private repProducers As RepositoryOfProducers
    Private rep As Repository
    Private operation As OperationsBaseAbstract
    Dim errLog As ErrorLog_Singleton

    Public Sub New()
        errLog = ErrorLog_Singleton.Instance
    End Sub

    Public Sub Init()

        Try
            repGuitars = New RepositoryOfGuitars
            repProducers = New RepositoryOfProducers
            rep = New Repository

        Catch ex As Exception

            errLog.LogError(ex)
        End Try
    End Sub

    Public Function GetProducers() As List(Of ProducerModel)
        Return repProducers.GetItems()
    End Function

    Public Function GetProducer(id As Guid) As ProducerModel
        Return repProducers.GetItem(id)
    End Function

    Public Function GetGuitars() As List(Of GuitarModel)
        Return repGuitars.GetItems()
    End Function
    Public Function GetCollection() As List(Of GuitarModel)
        Return rep.GetItems()
    End Function
    Public Function GetGuitar(id As Guid) As GuitarModel
        Return repGuitars.GetItem(id)
    End Function

    Public Function AddNewGuitar(item As GuitarModel)
        Dim result As Guid

        Try
            operation = New AddNewGuitar(item)
            result = operation.ExecuteProcedure()

        Catch ex As Exception

            errLog.LogError(ex)
        End Try
        Return result
    End Function

    Public Function AddNewProducer(item As ProducerModel)
        Dim result As Guid

        Try
            operation = New AddNewProducer(item)
            result = operation.ExecuteProcedure()

        Catch ex As Exception

            errLog.LogError(ex)
        End Try
        Return result
    End Function

    Public Function UpdateGuitar(item As GuitarModel)
        Dim result As Guid

        Try
            operation = New UpdateGuitar(item)
            result = operation.ExecuteProcedure()

        Catch ex As Exception

            errLog.LogError(ex)
        End Try
        Return result
    End Function

    Public Function UpdateProducer(item As ProducerModel) As Integer
        Dim result As Integer

        Try
            operation = New UpdateProducer(item)
            result = operation.ExecuteProcedure()

        Catch ex As Exception

            errLog.LogError(ex)
        End Try
        Return result
    End Function

    Public Function DeleteGuitar(item As GuitarModel) As Integer
        Dim result As Integer

        Try
            operation = New DeleteGuitar(item)
            result = operation.ExecuteProcedure()

        Catch ex As Exception

            errLog.LogError(ex)
        End Try
        Return result
    End Function

    Public Function DeleteProducer(item As ProducerModel) As Integer
        Dim result As Integer

        Try
            operation = New DeleteProducer(item)
            result = operation.ExecuteProcedure()

        Catch ex As Exception

            errLog.LogError(ex)
        End Try
        Return result
    End Function

End Class
