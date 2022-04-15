Public Class GuitarModel
    Public Sub New()
        Me.Producer = New ProducerModel
    End Sub
    Public Property Id As Guid
    Public Property Brand As String
    Public Property NumberOfStrings As Integer
    Public Property Color As ColorGuitarEnum
    Public Property Price As Decimal
    Public Property ProducerId As Guid
    Public Property TypeOfGuitar As TypeOfGuitarEnum
    Public Property Producer As ProducerModel

End Class
