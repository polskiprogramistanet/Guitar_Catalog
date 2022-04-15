Imports GuitarCenter_BackEnd
Public Class frmProducersList : Implements IPanelProducerView

    Private presenter As IPanelProducerPresenter
    Private currentItem As ProducerModel
    Dim errLog As ErrorLog_Singleton

    Public ReadOnly Property Producer() As ProducerModel
        Get
            Return currentItem
        End Get

    End Property
    Public Sub New()

        InitializeComponent()
        errLog = ErrorLog_Singleton.Instance
        presenter = New PanelPresenter(Me)


    End Sub
    Public Sub SetProducersCollection(items As List(Of ProducerModel)) Implements IPanelProducerView.SetProducersCollection

        Try
            Me.dgvProducers.Rows.Clear()

            For Each item As ProducerModel In items
                Me.dgvProducers.Rows.Add(item.Name, item.Country, item.Id)
            Next
        Catch ex As Exception
            errLog.LogError(ex)
        End Try

    End Sub

    Public Sub SetCallBackInformation(value As String) Implements IPanelProducerView.SetCallBackInformation

        MessageBox.Show(Me, value, "Producers")

    End Sub

    Private Sub frmProducersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            presenter.InitProducers()

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub lnkAddProducer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAddProducer.LinkClicked
        Try

            Dim frm As New frmProducerDetail()
            If (frm.ShowDialog(Me) = DialogResult.Yes) Then

                presenter.AddNewProducer(frm.Producer)


            End If

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

    End Sub

    Private Sub dgvProducers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProducers.SelectionChanged
        Try
            Dim id As Guid
            id = Me.dgvProducers.Item(2, dgvProducers.CurrentRow.Index).Value

            currentItem = presenter.GetItem(id)

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub lnkEditProducer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEditProducer.LinkClicked
        Try

            Dim frm As New frmProducerDetail(currentItem)
            presenter.InitProducers()

            If presenter.CountProducer > 0 Then
                If (frm.ShowDialog(Me) = DialogResult.Yes) Then

                    presenter.UpdateProducer(frm.Producer)

                End If
            Else
                MessageBox.Show(Me, "No data", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub

    Private Sub lnkDeleteProducer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDeleteProducer.LinkClicked
        Try
            

            If presenter.CountProducer > 0 Then
                If MessageBox.Show(Me, "do you want to delete the producer?", "Removing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    presenter.DeleteProducer(currentItem)
                End If
            Else
                MessageBox.Show(Me, "No data", "delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            errLog.LogError(ex)
        End Try
    End Sub
End Class