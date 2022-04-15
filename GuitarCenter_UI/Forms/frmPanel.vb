Imports GuitarCenter_BackEnd

Public Class frmPanel : Implements IPanelGuitarView, IXmlObserver

    Dim presenter As IPanelGuitarPresenter
    Dim currentGuitar As GuitarModel
    Dim xmlGenerator As XMLProcessor
    Dim errLog As ErrorLog_Singleton
    Public Sub New()

        InitializeComponent()
        presenter = New PanelPresenter(Me)
        errLog = ErrorLog_Singleton.Instance
    End Sub

    Public Sub SetGuitarsCollection(items As List(Of GuitarModel)) Implements IPanelGuitarView.SetGuitarsCollection

        Try
            Me.dgvDetail.Rows.Clear()
            If presenter.CountGuitar = 0 Then Throw New Exception("No data")

            For Each item As GuitarModel In items

                Me.dgvDetail.Rows.Add(item.Brand, item.NumberOfStrings, item.Color.ToString, item.Price, item.Id)

            Next
        Catch ex As Exception
            errLog.LogError(ex)
            Me.lblProducerName.Text = "<none>"
        End Try

    End Sub

    Public Sub SetCallBackInformation(value As String) Implements IPanelGuitarView.SetCallBackInformation

    End Sub

    Public Sub SetPositiveInformation(info As String) Implements IXmlObserver.SetPositiveInformation
        MessageBox.Show(Me, info, "xml generator", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Sub SetNegativeInformation(info As Exception) Implements IXmlObserver.SetNegativeInformation
        MessageBox.Show(Me, info.Message, "xml generator", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub frmPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            presenter.InitCollections()


        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            Dim frm As New frmGuitarDetail()

            If (frm.ShowDialog(Me) = DialogResult.Yes) Then

                presenter.AddNewGuitar(frm.Guitar)
                presenter.InitCollections()

            End If

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            Dim frm As New frmGuitarDetail(currentGuitar)
            If presenter.CountGuitar > 0 Then
                If (frm.ShowDialog(Me) = DialogResult.Yes) Then

                    presenter.UpdateGuitar(frm.Guitar)
                    presenter.InitCollections()

                End If
            Else
                MessageBox.Show(Me, "No data", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception
            errLog.LogError(ex)

        End Try
    End Sub

    Private Sub dgvDetail_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDetail.SelectionChanged
        Try

            Dim id As Guid
            id = Me.dgvDetail.Item(4, dgvDetail.CurrentRow.Index).Value
            Me.currentGuitar = presenter.GetItemCollection(id)
            Me.lblProducerName.Text = Me.currentGuitar.Producer.Name

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            If presenter.CountGuitar > 0 Then

                If MessageBox.Show(Me, "Do you want to remove the guitar?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    presenter.DeleteGuitar(Me.currentGuitar)
                    presenter.InitCollections()
                End If
            Else
                MessageBox.Show(Me, "No data", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show(Me, "Do you want to close the application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub tlsProducer_Click(sender As Object, e As EventArgs) Handles tlsProducer.Click
        Try

            Dim frm As New frmProducersList()

            If (frm.ShowDialog(Me) = DialogResult.Yes) Then



            End If

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub tlsSettings_Click(sender As Object, e As EventArgs) Handles tlsSettings.Click
        Try
            Dim frm As New frmConfig()

            If (frm.ShowDialog(Me) = DialogResult.Yes) Then



            End If

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub btnExportToXmlFile_Click(sender As Object, e As EventArgs) Handles btnExportToXmlFile.Click
        Try
            If presenter.CountGuitar > 0 Then
                If MessageBox.Show(Me, "do you want to generate a file xml ?", "xml generator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    xmlGenerator = New XMLProcessor(Me)
                    xmlGenerator.Generate()

                End If
            Else
                MessageBox.Show(Me, "No data", "xml generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub
End Class
