Public Class UCGoldAddItem
    Private Sub gbStoneData_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles pbAddStone.Click
        Try
            frmGoldAddStone.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Class
