Public Class FrmSelectAccount
    Public IsYes As Boolean = False
    Private Sub FrmSelectAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Try
            If GridView1.GetFocusedDataRow("رقم الحساب") > 0 Then
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class