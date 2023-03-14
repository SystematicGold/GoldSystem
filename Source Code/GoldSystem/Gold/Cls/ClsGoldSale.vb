Imports DevExpress.XtraRichEdit.Model

Public Class ClsGoldSale
    Dim Con As New ClsConnectionString

    Public Function PayMethod() As DataTable
        Dim Dt As New DataTable
        Dt.Clear()
        Dt = Con.SELECT_TXT("SELECT [PayMethodAr] AS [طريقة الدفع] , '0.000' AS [المبلغ] FROM [DeffPayMethod] WHERE [Enabled] = N'1'")
        Return Dt
    End Function
End Class
