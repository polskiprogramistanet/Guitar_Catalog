Imports GuitarCenter_BackEnd

Public Class PanelPresenter
    Implements IPanelGuitarPresenter, IPanelProducerPresenter
    Private ReadOnly viewGuitar As IPanelGuitarView
    Private ReadOnly viewProducer As IPanelProducerView
    Private model As PanelModel

    Public ReadOnly Property CountProducer As Integer Implements IPanelProducerPresenter.CountProducer
        Get
            Return model.GetProducers.Count
        End Get

    End Property

    Public ReadOnly Property CountGuitar As Integer Implements IPanelGuitarPresenter.CountGuitar
        Get
            Return model.GetGuitars.Count
        End Get

    End Property

    Public Sub New(view As IPanelGuitarView)
        Me.viewGuitar = view
        Me.model = New PanelModel()
        Me.model.Init()

    End Sub

    Public Sub New(view As IPanelProducerView)
        Me.viewProducer = view
        Me.model = New PanelModel()
        Me.model.Init()
    End Sub
    Public Sub InitCollections() Implements IPanelGuitarPresenter.InitCollections
        Me.viewGuitar.SetGuitarsCollection(model.GetCollection())
    End Sub
    Public Sub InitGuitars() Implements IPanelGuitarPresenter.InitGuitars
        Me.viewGuitar.SetGuitarsCollection(model.GetGuitars())

    End Sub

    Public Sub InitProducers() Implements IPanelProducerPresenter.InitProducers
        Me.viewProducer.SetProducersCollection(model.GetProducers())

    End Sub

    Public Sub AddNewGuitar(item As GuitarModel) Implements IPanelGuitarPresenter.AddNewGuitar
        Dim result As Guid
        result = model.AddNewGuitar(item)
        If result <> Guid.Empty Then
            _CallbackGuitarInformation("A new guitar has been added")
        Else
            _CallbackGuitarInformation("Addition error !")
        End If
        model.Init()
        Me.viewGuitar.SetGuitarsCollection(model.GetCollection())
    End Sub

    Public Sub AddNewProducer(item As ProducerModel) Implements IPanelProducerPresenter.AddNewProducer
        Dim result As Guid
        result = model.AddNewProducer(item)
        If result <> Guid.Empty Then
            _CallbackProducerInformation("A new producer has been added")
            model.Init()
            Me.viewProducer.SetProducersCollection(model.GetProducers())
        Else
            _CallbackProducerInformation("Addition error !")
        End If
    End Sub

    Public Sub UpdateGuitar(item As GuitarModel) Implements IPanelGuitarPresenter.UpdateGuitar
        Dim result As Guid
        result = model.UpdateGuitar(item)
        If result <> Guid.Empty Then
            _CallbackGuitarInformation("Updated correctly")
            model.Init()
            Me.viewProducer.SetProducersCollection(model.GetProducers())
        Else
            _CallbackGuitarInformation("Updated  error !")
        End If
        model.Init()
        Me.viewGuitar.SetGuitarsCollection(model.GetCollection())
    End Sub

    Public Sub UpdateProducer(item As ProducerModel) Implements IPanelProducerPresenter.UpdateProducer
        Dim result As Integer
        result = model.UpdateProducer(item)
        If result <> 0 Then
            _CallbackProducerInformation("Updated correctly")
        Else
            _CallbackProducerInformation("Updated  error !")
        End If
    End Sub

    Public Sub DeleteGuitar(item As GuitarModel) Implements IPanelGuitarPresenter.DeleteGuitar
        Dim result As Integer
        result = model.DeleteGuitar(item)
        If result <> 0 Then
            _CallbackGuitarInformation("Deleted correctly")
            model.Init()
            Me.viewGuitar.SetGuitarsCollection(model.GetCollection())
        Else
            _CallbackGuitarInformation($"Deleted  error !{vbCrLf} check if the guitar has the producer")
        End If
    End Sub

    Public Sub DeleteProducer(item As ProducerModel) Implements IPanelProducerPresenter.DeleteProducer
        Dim result As Integer
        result = model.DeleteProducer(item)
        If result <> 0 Then
            _CallbackProducerInformation("Deleted correctly")
            model.Init()
            Me.viewProducer.SetProducersCollection(model.GetProducers())
        Else
            _CallbackProducerInformation($"Deleted  error !{vbCrLf} check if the producer is not related to the guitar")
        End If
    End Sub

    Public Function GetItem(id As Guid) As GuitarModel Implements IPanelGuitarPresenter.GetItem
        Return model.GetGuitar(id)
    End Function

    Private Sub _CallbackProducerInformation(information As String)
        viewProducer.SetCallBackInformation(information)

    End Sub
    Private Sub _CallbackGuitarInformation(information As String)
        viewGuitar.SetCallBackInformation(information)

    End Sub

    Private Function IPanelProducerPresenter_GetItem(id As Guid) As ProducerModel Implements IPanelProducerPresenter.GetItem
        Return model.GetProducer(id)
    End Function

    Public Function GetItemCollection(id As Guid) As GuitarModel Implements IPanelGuitarPresenter.GetItemCollection
        Return model.GetCollection.Find(Function(i) i.Id = id)
    End Function
End Class
