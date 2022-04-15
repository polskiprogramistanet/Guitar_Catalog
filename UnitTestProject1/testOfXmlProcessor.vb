Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports GuitarCenter_BackEnd

<TestClass()> Public Class testOfXmlProcessor
    Dim rpo As Repository

    <TestMethod()> Public Sub Createtable()
        'arrange


        'act

        'assert

    End Sub
    <TestMethod()> Public Sub Generate()
        'arrange
        Dim processor As New XMLProcessor(Nothing)

        'act
        processor.Generate()

        'assert
        Assert.AreEqual(1, 1)

    End Sub
End Class