Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Public Class FrmGoldItemSingle
    Dim ClsGoldItem_ As New ClsGoldItem
    Dim ClsMain_ As New ClsMain
    Private Sub FrmGoldItemSingle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClsGoldItem_.FillItemName(cmbItemName)
        ClsGoldItem_.FillKarat(cmbKarat)
        ClsGoldItem_.FillCountryOfOrigin(cmbCountryOfOrigin)
        ClsGoldItem_.FillSupplier(cmbSupplier)
        ClsGoldItem_.FillTaxExempt(cmbTaxExempt)
        ClsGoldItem_.FillItemCondition(cmbItemCondition)
        DGCItem.DataSource = ClsGoldItem_.AllItems
    End Sub

    Private Sub btnPhoto_ButtonClick(sender As Object, e As EventArgs) Handles btnPhoto.ButtonClick
        Try
            If DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colPhoto).ToString <> "" Then
                FrmPhoto.pbPhoto.Image = ByteToImage(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colPhoto))
                FrmPhoto.ShowDialog()
            Else
                MsgBox("لا توجد صورة!" & vbCrLf & "No Photo!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnDocument_ButtonClick(sender As Object, e As EventArgs) Handles btnDocument.ButtonClick
        Try
            If DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDocument).ToString <> "" Then
                FrmPhoto.pbPhoto.Image = ByteToImage(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDocument))
                FrmPhoto.ShowDialog()
            Else
                MsgBox("لا توجد صورة!" & vbCrLf & "No Photo!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If XtraMessageBox.Show("هل تريد حذف الصنف؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClsGoldItem_.DeleteItem(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colID))
            DGCItem.DataSource = ClsGoldItem_.AllItems
        End If
    End Sub

    Private Sub DGVItem_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles DGVItem.SelectionChanged
        DGVItem.OptionsSelection.EnableAppearanceFocusedRow = True
        Try
            With AddGoldItem
                .txtItemID.Text = DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colID).ToString
                .Code = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCode)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCode).ToString)
                .AnotherCode = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colAnotherCode)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colAnotherCode).ToString)
                .AnotherCode2 = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colAnotherCode2)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colAnotherCode2).ToString)
                .cmbItemName.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colName)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colName).ToString)
                .cmbKarat.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colKarat)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colKarat).ToString)
                .txtGoldWeight.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colGoldWeight)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colGoldWeight).ToString)
                .txtMakingCharge.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colMakingCharge)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colMakingCharge).ToString)
                .cmbCountryOfOrigin.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCountryOfOrigin)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCountryOfOrigin).ToString)
                .cmbSupplier.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colSupplier)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colSupplier).ToString)
                .cmbSupplierInvoiceNo.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colSupplierInvoiceNo)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colSupplierInvoiceNo).ToString)
                .txtNumberOfPieces.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colNumberOfPieces)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colNumberOfPieces).ToString)
                .txtItemNo.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colItemNo)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colItemNo).ToString)
                .txtSymbol.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colSymbol)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colSymbol).ToString)
                .txtCostPerGram.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCostPerGram)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCostPerGram).ToString)
                .txtCostForSeller.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCostForSeller)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCostForSeller).ToString)
                .txtCostPerPiece.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCostPerPiece)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCostPerPiece).ToString)
                .txtCostPerGramPurchase.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCostPerGramPurchase)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCostPerGramPurchase).ToString)
                .cmbItemCondition.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCondition)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colCondition).ToString)
                .cmbTaxExempt.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colTaxExempt)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colTaxExempt).ToString)
                .dtpDateOfManufacture.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDateOfManufacture)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDateOfManufacture).ToString)
                .dtpDateAdded.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDateAdd)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDateAdd).ToString)
                .pbPhoto.Image = If(IsDBNull(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colPhoto)), Nothing, ByteToImage(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colPhoto)))
                .pbDocument.Image = If(IsDBNull(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDocument)), Nothing, ByteToImage(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDocument)))
                .txtBarCode.EditValue = If(IsNothing(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colBarCode)), "", DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colBarCode).ToString)
            End With
            dtStone = ClsGoldItem_.GetGoldStone(AddGoldItem.Code)
            With AddGoldItem.DGCStone
                .DataSource = dtStone
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVItem_CustomRowCellEdit(sender As Object, e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles DGVItem.CustomRowCellEdit
        If e.Column Is colPhoto Then
            If IsNothing(e.CellValue) = True OrElse IsDBNull(e.CellValue) OrElse e.CellValue.ToString = "" Then
                e.RepositoryItem = txtEmpty
            Else
                e.RepositoryItem = btnPhoto
            End If
        End If
        If e.Column Is colDocument Then
            If IsNothing(e.CellValue) = True OrElse IsDBNull(e.CellValue) OrElse e.CellValue.ToString = "" Then
                e.RepositoryItem = txtEmpty

            Else
                e.RepositoryItem = btnDocument
            End If
        End If
    End Sub

    Private Sub DGVItem_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DGVItem.ShowingEditor
        If DGVItem.FocusedColumn Is colPhoto Then
            If IsDBNull(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colPhoto)) = True Then
                e.Cancel = True
            End If
        End If
        If DGVItem.FocusedColumn Is colDocument Then
            If IsDBNull(DGVItem.GetRowCellValue(DGVItem.FocusedRowHandle, colDocument)) = True Then
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub DgvItem_CustomDrawCell(sender As Object, e As Views.Base.RowCellCustomDrawEventArgs) Handles DGVItem.CustomDrawCell
        If e.Column.Name = "colSerial" OrElse e.Column.Name = "colBarCode" OrElse e.Column.Name =
            "colKarat" OrElse e.Column.Name = "colGoldWeight" OrElse e.Column.Name =
            "colMakingCharge" OrElse e.Column.Name = "colCostPerPiece" OrElse e.Column.Name =
            "colCostPerGram" OrElse e.Column.Name = "colCostForSeller" OrElse e.Column.Name =
            "colCostPerGramPurchase" OrElse e.Column.Name = "colNumberOfPieces" OrElse e.Column.Name =
            "colSupplierInvoiceNo" OrElse e.Column.Name = "colSymbol" OrElse e.Column.Name =
            "colItemNo" OrElse e.Column.Name = "colDateAdd" OrElse e.Column.Name = "colDateOfManufacture" Then
            Dim drawFormat As StringFormat = New StringFormat()
            drawFormat.FormatFlags = 2
            drawFormat.Alignment = StringAlignment.Center
            drawFormat.LineAlignment = StringAlignment.Center
            e.Appearance.DrawString(e.Cache, e.DisplayText, e.Bounds, drawFormat)
            e.Handled = True
        End If
    End Sub

    Private Sub FrmGoldItemSingle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        dtStone.Clear()
        Dispose()
    End Sub
End Class