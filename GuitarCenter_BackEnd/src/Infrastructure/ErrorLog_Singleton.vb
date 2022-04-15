Imports System.IO
Imports System.Text

Public Class ErrorLog_Singleton
    Private Shared _instance As ErrorLog_Singleton
    Private Shared ReadOnly _lock As Object = New Object()

    Private Sub New()
        'fs = File.Create(Path)

    End Sub
    Public Shared ReadOnly Property Instance() As ErrorLog_Singleton
        Get
            If _instance Is Nothing Then
                _instance = New ErrorLog_Singleton()
            End If
            Return _instance
        End Get
    End Property

    Public Sub LogError(ex As Exception)

        Dim message As String = String.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        message += Environment.NewLine
        message += "-----------------------------------------------------------"
        message += Environment.NewLine
        message += String.Format("Message: {0}", ex.Message)
        message += Environment.NewLine
        message += String.Format("StackTrace: {0}", ex.StackTrace)
        message += Environment.NewLine
        message += String.Format("Source: {0}", ex.Source)
        message += Environment.NewLine
        message += String.Format("TargetSite: {0}", ex.TargetSite.ToString())
        message += Environment.NewLine
        message += "-----------------------------------------------------------"
        message += Environment.NewLine
        Dim path As String = My.Application.Info.DirectoryPath + "/ErrorLog.txt"
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(message)
            writer.Close()
        End Using
    End Sub
    Public Sub LogError_App(ex As Exception)
        Dim message As String = String.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        message += Environment.NewLine
        My.Application.Log.WriteException(ex, TraceEventType.Error, message)
    End Sub
End Class
