Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports GuitarCenter_BackEnd

<TestClass()> Public Class TestOfPanelModel

    <TestMethod()> Public Sub CountGuitars()
        'Arrange
        Dim model As New PanelModel
        model.Init()

        'Act
        Dim count As Integer = model.GetGuitars.Count

        'Assert
        Assert.AreEqual(0, count)
    End Sub

End Class