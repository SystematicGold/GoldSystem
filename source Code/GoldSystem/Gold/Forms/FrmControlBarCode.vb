Public Class FrmControlBarCode
    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles PictureEdit1.Click
        Try
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public up As Integer = 0
    Public down As Integer = 0
    Public right_ As Single = 0
    Public left_ As Single = 0
    Private Sub PictureEdit2_Click(sender As Object, e As EventArgs) Handles PictureEdit2.Click
        Try
            right_ = right_ + 1
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class