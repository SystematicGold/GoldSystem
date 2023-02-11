Public Class PrintBarCode
    Private Sub XrLabel1_PreviewClick(sender As Object, e As DevExpress.XtraReports.UI.PreviewMouseEventArgs) Handles XrLabel1.PreviewClick
        Try
            'Dim F As New FrmControlBarCode
            'F.ShowDialog()
            'XrLabel1.RightF = 50

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class