Public Interface IPanelProducerPresenter
    ReadOnly Property CountProducer As Integer
    Sub InitProducers()
    Sub AddNewProducer(item As ProducerModel)
    Sub UpdateProducer(item As ProducerModel)
    Sub DeleteProducer(item As ProducerModel)
    Function GetItem(id As Guid) As ProducerModel

End Interface
