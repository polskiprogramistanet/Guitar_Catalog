Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports GuitarCenter_BackEnd

<TestClass()> Public Class TestOfErrorLog

    Private errFile As ErrorLog_Singleton

    <TestMethod()> Public Sub WriteToFile()
        'Arrange
        errFile = ErrorLog_Singleton.Instance

        'act
        Dim ex As New Exception("Error tester")

        errFile.LogError(ex)

        'assert
        Assert.AreEqual(1, 1)
    End Sub

End Class