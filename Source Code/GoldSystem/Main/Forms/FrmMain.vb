Imports System.IO
Imports System.Text
Imports DevExpress.XtraBars.Ribbon

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
            frmGoldPurchase.MdiParent = Me
            frmGoldPurchase.Show()
            ActivateMdiChild(frmGoldPurchase)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGoldItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGoldItemSingle.ItemClick
        Try
            Dim dt As New DataTable

            dt.Clear()
            'dt = ClsMain_.GetItemCode()
            'If dt.Rows.Count > 0 Then
            '    F.TxtCode.Text = dt.Rows(0)(0)
            'frmGoldItem.txtSetCode.Text = dt.Rows(0)(0)
            'Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            'Dim r As New Random
            'Dim sb As New StringBuilder
            'For i As Integer = 1 To 3
            '    Dim idx As Integer = r.Next(0, 35)
            '    sb.Append(s.Substring(idx, 1))
            'Next
            'FrmGoldItem.TxtBarCode.Text = sb.ToString()
            'frmGoldItem.TxtBarCodeBlock.Text = sb.ToString()
            'End If
            FrmGoldItemSingle.MdiParent = Me
            FrmGoldItemSingle.Show()
            ActivateMdiChild(FrmGoldItemSingle)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim FS As New FileStream(Application.StartupPath & "\QuickAccessBar.xml", FileMode.Create)
            RibbonControl1.Toolbar.SaveLayoutToStream(FS)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim FSPath As String = Application.StartupPath & "\QuickAccessBar.xml"
            If File.Exists(FSPath) Then
                Dim FS As New FileStream(FSPath, FileMode.Open)
                RibbonControl1.Toolbar.RestoreLayoutFromStream(FS)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class