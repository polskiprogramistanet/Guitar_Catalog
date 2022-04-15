Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports GuitarCenter_BackEnd

<TestClass()> Public Class TestOfDataService

    Private OperationBase As OperationsBaseAbstract

    Dim expect As Guid
    Dim actual As Guid
    Dim iActual As Integer
    Dim iExpect As Integer

    <TestMethod()> Public Sub AddNewProducer()
        'Arrange
        Dim producer As New ProducerModel()
        With producer
            .Id = Guid.NewGuid()
            .Name = "BC Reach ltd"
            .Country = "U.S.A"
        End With

        'Act
        OperationBase = New AddNewProducer(producer)
        actual = OperationBase.ExecuteProcedure()

        'Assert
        Assert.AreNotEqual(expect, actual)

    End Sub
    <TestMethod()> Public Sub UpdateProducer()
        'Arrange
        Dim producer As New ProducerModel()
        With producer
            .Id = Guid.Parse("9E0081F0-42EC-4767-AF9B-61871ECF08C6")
            .Name = "ESP"
            .Country = "U.S.A"
        End With

        'Act
        OperationBase = New UpdateProducer(producer)
        iActual = OperationBase.ExecuteProcedure()
        iExpect = 1
        'Assert
        Assert.AreNotEqual(iExpect, iActual)

    End Sub
    <TestMethod()> Public Sub DeleteProducer()
        'Arrange
        Dim producer As New ProducerModel()
        With producer
            .Id = Guid.Parse("2197cdc3-cad7-4f1b-960d-3b5940401625")
            .Name = "ESP"
            .Country = "U.S.A"
        End With

        'Act
        OperationBase = New DeleteProducer(producer)
        iActual = OperationBase.ExecuteProcedure()
        iExpect = 1
        'Assert
        Assert.AreEqual(iExpect, iActual)

    End Sub
    <TestMethod()> Public Sub LoadProducersCollection()
        'Arrange
        Dim count = 0
        Dim repository As New RepositoryOfProducers


        'Act
        count = repository.GetItems().Count
        Console.WriteLine($"count: {count}")
        'Assert
        Assert.AreNotEqual(0, count)

    End Sub
    <TestMethod()> Public Sub LoadGuitarsCollection()
        'Arrange
        Dim count = 0
        Dim repository As New RepositoryOfGuitars()


        'Act
        count = repository.GetItems().Count
        Console.WriteLine($"count: {count}")

        'Assert
        Assert.AreNotEqual(0, count)
    End Sub
    <TestMethod()> Public Sub AddNewGuitar()
        'Arrange
        Dim guitar As New GuitarModel()
        With guitar
            .Brand = "Precision Bass"
            .Color = ColorGuitarEnum.Black
            .NumberOfStrings = 5
            .Price = 17000
            .TypeOfGuitar = TypeOfGuitarEnum.ElectricGuitar
            .ProducerId = Guid.Parse("2197CDC3-CAD7-4F1B-960D-3B5940401625")
        End With

        'Act
        OperationBase = New AddNewGuitar(guitar)
        actual = OperationBase.ExecuteProcedure()

        'Assert
        Assert.AreNotEqual(expect, actual)
    End Sub
    <TestMethod()> Public Sub UpdateGuitar()
        'Arrange
        Dim guitar As New GuitarModel()
        With guitar
            .Id = Guid.Parse("cc648f84-949b-4d53-85e7-93e06850ba5d")
            .Brand = "Jolana"
            .Color = ColorGuitarEnum.Withe
            .NumberOfStrings = 5
            .Price = 2550.5
            .ProducerId = Guid.Parse("2197CDC3-CAD7-4F1B-960D-3B5940401625")
            .TypeOfGuitar = TypeOfGuitarEnum.AccusticGuitar
        End With

        'Act
        OperationBase = New UpdateGuitar(guitar)
        iActual = OperationBase.ExecuteProcedure()
        iExpect = 1

        'Assert
        Assert.AreNotEqual(iExpect, iActual)

    End Sub
End Class