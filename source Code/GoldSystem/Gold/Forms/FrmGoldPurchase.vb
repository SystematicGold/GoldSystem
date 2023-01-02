Public Class FrmGoldPurchase
    Private Sub TabPane1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabPane1.TabIndexChanged
        If TabPane1.SelectedPageIndex = 1 Then
            UcSupplier1.gbCompanyData.Text = "بيانات الشركة الموردة"
        End If
    End Sub
End Class