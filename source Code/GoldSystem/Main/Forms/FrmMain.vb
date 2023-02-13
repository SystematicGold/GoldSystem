Imports System.Text
Public Class FrmMain
    Dim ClsMain_ As New ClsMain
    Private Sub btnGoldSale_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGoldSale.ItemClick
        Try
            FrmGoldSale.MdiParent = Me
            FrmGoldSale.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGoldPurchase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGoldPurchase.ItemClick
        Try
            FrmGoldPurchase.MdiParent = Me
            FrmGoldPurchase.Show()
            ActivateMdiChild(FrmGoldPurchase)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGoldItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGoldItem.ItemClick
        Try
            Dim dt As New DataTable

            dt.Clear()
            dt = ClsMain_.GetItemCode()
            'If dt.Rows.Count > 0 Then
            '    F.TxtCode.Text = dt.Rows(0)(0)
            FrmGoldItem.txtSetCode.Text = dt.Rows(0)(0)
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To 3
                Dim idx As Integer = r.Next(0, 35)
                sb.Append(s.Substring(idx, 1))
            Next
            'FrmGoldItem.TxtBarCode.Text = sb.ToString()
            'frmGoldItem.TxtBarCodeBlock.Text = sb.ToString()
            'End If
            frmGoldItem.MdiParent = Me
            FrmGoldItem.Show()
            ActivateMdiChild(FrmGoldItem)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class