Public Class FrmAccountingTree
    Private Sub FrmAccountingTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim f As New FrmSelectAccount
            f.ShowDialog()
            If f.IsYes = True Then

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class