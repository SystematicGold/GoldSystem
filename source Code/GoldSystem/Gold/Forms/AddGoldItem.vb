Public Class AddGoldItem
    Private Sub gbStoneData_Click(sender As Object, e As EventArgs) Handles gbStoneData.Click

    End Sub

    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles pbAddStone.Click
        Try
            FrmAddStone.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Class
