Public Class FrmGoldSale
    Dim ClsGoldSale_ As New ClsGoldSale
    Private Sub frmGoldSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ClsGoldSale_.PayMethod.Rows.Count > 0 Then
            For i As Integer = 0 To ClsGoldSale_.PayMethod.Rows.Count - 1
                DGVCustomerPayMethod.Rows.Add()
                DGVCustomerPayMethod.Rows(i).Cells("colCustomerPayMethod").Value = ClsGoldSale_.PayMethod.Rows(i)(0).ToString
                DGVCustomerPayMethod.Rows(i).Cells("colCustomerPayValue").Value = "0.000"
            Next

        End If
    End Sub
End Class