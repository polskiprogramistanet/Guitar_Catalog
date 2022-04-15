Public Interface IPanelGuitarPresenter

    ReadOnly Property CountGuitar As Integer
    Sub InitGuitars()
    Sub InitCollections()
    Sub AddNewGuitar(item As GuitarModel)
    Sub UpdateGuitar(item As GuitarModel)
    Sub DeleteGuitar(item As GuitarModel)
    Function GetItem(id As Guid) As GuitarModel
    Function GetItemCollection(id As Guid) As GuitarModel
End Interface
