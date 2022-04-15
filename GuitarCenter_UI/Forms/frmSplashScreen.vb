Imports GuitarCenter_BackEnd

Public NotInheritable Class frmSplashScreen
    Dim frm As Form
    Dim config As New ConfgModel
    Dim cfgBuilder As New ProviderBuilder
    Dim firstStart As Boolean
    Dim errLog As ErrorLog_Singleton

    Public Sub New()

        InitializeComponent()
        errLog = ErrorLog_Singleton.Instance


    End Sub
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Copyright.Text = My.Application.Info.Copyright
        firstStart = config.GetFirstStart()



    End Sub
    Private Sub frmSplashScreen_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try


            If firstStart Then
                frm = New frmConfig()
                If frm.ShowDialog(Me) = DialogResult.Yes Then
                    Application.Restart()

                Else
                    Application.Exit()

                End If
            Else
                frm = New frmPanel()
                frm.Show()
                Me.Close()
            End If

        Catch ex As Exception
            errLog.LogError(ex)
        End Try

    End Sub
End Class
