Public Class frmGoldPurchase1
    Private Sub TabPane1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabPane1.TabIndexChanged
        If TabPane1.SelectedPageIndex = 1 Then
            ucSupplier.gbCompanyData.Text = "بيانات الشركة الموردة"
        End If
    End Sub
End Class