Imports System.IO
Imports DevExpress.Data.Svg
Imports DevExpress.DataProcessing.InMemoryDataProcessor
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Public Class UCGoldAddItem
    Dim ClsGoldItem_ As New ClsGoldItem
    Dim ClsGoldAddStone_ As New ClsGoldAddStone
    Dim ClsMain_ As New ClsMain
    Public Code, AnotherCode, AnotherCode2 As String
#Region "Initialize"
    Private Sub UCGoldAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClsGoldItem_.FillItemName(cmbItemName)
        ClsGoldItem_.FillKarat(cmbKarat)
        ClsGoldItem_.FillCountryOfOrigin(cmbCountryOfOrigin)
        ClsGoldItem_.FillSupplier(cmbSupplier)
        ClsGoldItem_.FillTaxExempt(cmbTaxExempt)
        ClsGoldItem_.FillItemCondition(cmbItemCondition)
        ClsGoldItem_.FillStoneType(cmbStoneType)
        ClsGoldItem_.FillStoneName(cmbStoneName)
        ClsGoldItem_.FillStoneCaratOrGram(cmbStoneWeightType)
        ClsGoldItem_.FillStoneColor(cmbStoneColor)
        ClsGoldItem_.FillStoneClarity(cmbStoneClarity)
        ClsGoldItem_.FillStoneCut(cmbStoneCut)
        ClsGoldItem_.FillCountryOfOrigin(cmbStoneCountryOfOrigin)
    End Sub
#End Region


#Region "Stone"
    Private Sub pbAddStone_Click(sender As Object, e As EventArgs) Handles pbAddStone.Click
        Try
            FrmGoldAddStone.StoneID = ""
            FrmGoldAddStone.ShowDialog()
            DGCStone.DataSource = dtStone
            'If DgvStone.RowCount > 0 Then
            '    ClsGoldItem_.FillStoneType(cmbStoneType)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

#End Region
    Private Sub btnPhoto_Click(sender As Object, e As EventArgs) Handles btnPhoto.Click
        OFDX.ShowDialog()
        If IsValidImage(OFDX.FileName) Then
            Dim fs As New FileStream(OFDX.FileName, FileMode.Open, FileAccess.Read)
            pbPhoto.Image = Image.FromStream(fs)
            fs.Close()
        End If
    End Sub
    Private Sub btnDocument_Click(sender As Object, e As EventArgs) Handles btnDocument.Click
        OFDX.ShowDialog()
        If IsValidImage(OFDX.FileName) Then
            Dim fs As New FileStream(OFDX.FileName, FileMode.Open, FileAccess.Read)
            pbDocument.Image = Image.FromStream(fs)
            fs.Close()
        End If
    End Sub

    Private Sub pbNewItem_Click(sender As Object, e As EventArgs) Handles pbNewItem.Click
        txtItemID.Text = ""
        ResetControls()
        DGCStone.DataSource = Nothing
    End Sub
    Private Sub ResetControls()
        txtItemID.EditValue = ""
        txtBarCode.EditValue = ""
        txtCostForSeller.EditValue = ""
        txtCostPerGram.EditValue = ""
        txtCostPerPiece.EditValue = ""
        txtGoldWeight.EditValue = ""
        txtCostPerGramPurchase.EditValue = ""
        txtItemNo.EditValue = ""
        txtMakingCharge.EditValue = ""
        txtNote.EditValue = ""
        txtNumberOfPieces.EditValue = ""
        txtSymbol.EditValue = ""
        cmbItemName.EditValue = ""
        cmbKarat.EditValue = ""
        cmbCountryOfOrigin.EditValue = ""
        cmbItemCondition.EditValue = ""
        cmbSupplier.EditValue = ""
        cmbSupplierInvoiceNo.EditValue = ""
        cmbTaxExempt.EditValue = ""
        dtpDateAdded.EditValue = Nothing
        dtpDateOfManufacture.EditValue = Nothing
        pbPhoto.Image = Nothing
        pbDocument.Image = Nothing
        DGCStone.DataSource = Nothing
        FrmGoldItemSingle.DGVItem.OptionsSelection.EnableAppearanceFocusedRow = False
        EPX.ClearErrors()
    End Sub
    Public Sub LoadStoneValues()
        With FrmGoldAddStone
            .cmbStoneType.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneType)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneType).ToString)
            .cmbStoneName.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneName)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneName).ToString)
            .txtWeight.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneWeight)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneWeight).ToString)
            .cmbStoneWeightType.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneWeightType)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneWeightType).ToString)
            .cmbStoneColor.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneColor)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneColor).ToString)
            .cmbStoneClarity.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneClarity)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneClarity).ToString)
            .cmbStoneCut.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneCut)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneCut).ToString)
            .cmbStoneCountryOfOrigin.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneCountryOfOrigin)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneCountryOfOrigin).ToString)
            .txtStonePrice.EditValue = If(IsNothing(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStonePrice)), "", DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStonePrice).ToString)
            .pbStonePhoto.Image = If(IsDBNull(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStonePhoto)), Nothing, ByteToImage(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStonePhoto)))
            .pbStoneDocument.Image = If(IsDBNull(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneDocument)), Nothing, ByteToImage(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneDocument)))
        End With
    End Sub

    Private Sub btnStonePhoto_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles btnStonePhoto.ButtonClick
        Try
            If DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStonePhoto).ToString <> "" Then
                FrmPhoto.pbPhoto.Image = ByteToImage(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStonePhoto))
                FrmPhoto.ShowDialog()
            Else
                MsgBox("لا توجد صورة!" & vbCrLf & "No Photo!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnStoneDocument_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles btnStoneDocument.ButtonClick
        Try
            If DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneDocument).ToString <> "" Then
                FrmPhoto.pbPhoto.Image = ByteToImage(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colStoneDocument))
                FrmPhoto.ShowDialog()
            Else
                MsgBox("لا توجد صورة!" & vbCrLf & "No Photo!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnStoneEdit_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles btnStoneEdit.ButtonClick
        Try
            LoadStoneValues()
            FrmGoldAddStone.StoneID = DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colID).ToString
            FrmGoldAddStone.ShowDialog()
            DGCStone.DataSource = dtStone
            'If DgvStone.RowCount > 0 Then
            '    ClsGoldItem_.FillStoneType(cmbStoneType)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub btnStoneDelete_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles btnStoneDelete.ButtonClick
        If XtraMessageBox.Show("هل تريد حذف الفص؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClsGoldItem_.DeleteGoldStoneByID(DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colID))
            dtStone.Rows.Remove(dtStone.Select("ID = '" & DgvStone.GetRowCellValue(DgvStone.FocusedRowHandle, colID) & "'")(0))
        End If
    End Sub
#Region "Validating"
    Private Sub cmbItemName_ProcessNewValue(sender As Object, e As Controls.ProcessNewValueEventArgs) Handles cmbItemName.ProcessNewValue
        If CStr(e.DisplayValue) = String.Empty Then
            Return
        End If
        If XtraMessageBox.Show("Do you want to add a new value?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim Id As Integer = ClsGoldItem_.ItemNameAdd(e.DisplayValue.ToString)
            cmbItemName.Properties.DataSource = Nothing
            ClsGoldItem_.FillItemName(cmbItemName)
            cmbItemName.ItemIndex = Id + 1
        End If
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        Dim ErrCount As Integer = 0
        EPX.ClearErrors()
        If cmbItemName.Text = String.Empty Then
            EPX.SetError(cmbItemName, "اختر صنفًا")
            ErrCount += 1
        End If
        If cmbKarat.Text = String.Empty Then
            EPX.SetError(cmbKarat, "اختر عيارًا")
            ErrCount += 1
        End If
        If txtGoldWeight.Text = String.Empty Then
            EPX.SetError(txtGoldWeight, "اكتب وزنًا")
            ErrCount += 1
        End If
        If txtMakingCharge.Text = String.Empty Then
            EPX.SetError(txtMakingCharge, "اكتب مصنعية البيع")
            ErrCount += 1
        End If
        If cmbCountryOfOrigin.Text = String.Empty Then
            EPX.SetError(cmbCountryOfOrigin, "اختر بلد المنشأ")
            ErrCount += 1
        End If
        If txtNumberOfPieces.Text = String.Empty Then
            txtNumberOfPieces.Text = "1"
            ErrCount += 1
        End If
        If ClsGoldItem_.CheckDuplicateBarCode(txtBarCode.Text.Trim, txtItemID.Text.Trim) = True Then
            EPX.SetError(txtBarCode, "باركود مكرر")
            ErrCount += 1
        End If
        If ErrCount > 0 Then
            Exit Sub
        End If
        Dim FocusedRowNo As Integer = FrmGoldItemSingle.DGVItem.FocusedRowHandle
        If txtItemID.Text = "" Then
            'AddItem (No ID)
            Dim BarCodeString = cmbItemName.GetSelectedDataRow("BarCodeString").ToString
            ClsGoldItem_.AddItem(ClsMain_.GetItemCode,
                                 0,
                                 0,
                                 If(txtBarCode.Text.Trim = String.Empty, BarCodeString & ClsGoldItem_.GetItemBarCodeSerial(BarCodeString), txtBarCode.Text.Trim),
                                 cmbItemName.EditValue,
                                 cmbKarat.EditValue,
                                 txtGoldWeight.Text.Trim,
                                 txtMakingCharge.Text.Trim,
                                 txtCostPerPiece.Text.Trim,
                                 txtCostPerGram.Text.Trim,
                                 txtCostForSeller.Text.Trim,
                                 txtCostPerGramPurchase.Text.Trim,
                                 cmbCountryOfOrigin.EditValue,
                                 txtNumberOfPieces.Text.Trim,
                                 ImageToByte(pbPhoto.Image),
                                 ImageToByte(pbDocument.Image),
                                 cmbSupplier.EditValue,
                                 txtSymbol.Text.Trim,
                                 cmbItemCondition.EditValue,
                                 txtItemNo.Text.Trim,
                                 1,
                                 dtpDateAdded.EditValue,
                                 dtpDateOfManufacture.EditValue,
                                 cmbTaxExempt.EditValue,
                                 cmbSupplierInvoiceNo.EditValue,
                                 1)
        Else
            'Edit Item (ID Exist)
            Dim BarCodeString = cmbItemName.GetSelectedDataRow("BarCodeString").ToString
            ClsGoldItem_.EditItem(Code,
                                  AnotherCode,
                                  AnotherCode2,
                                  If(txtBarCode.Text.Trim = String.Empty, BarCodeString & ClsGoldItem_.GetItemBarCodeSerial(BarCodeString), txtBarCode.Text.Trim),
                                  cmbItemName.EditValue,
                                  cmbKarat.EditValue,
                                  txtGoldWeight.Text.Trim,
                                  txtMakingCharge.Text.Trim,
                                  txtCostPerPiece.Text.Trim,
                                  txtCostPerGram.Text.Trim,
                                  txtCostForSeller.Text.Trim,
                                  txtCostPerGramPurchase.Text.Trim,
                                  cmbCountryOfOrigin.EditValue,
                                  txtNumberOfPieces.Text.Trim,
                                  ImageToByte(pbPhoto.Image),
                                  ImageToByte(pbDocument.Image),
                                  cmbSupplier.EditValue,
                                  txtSymbol.Text.Trim,
                                  cmbItemCondition.EditValue,
                                  txtItemNo.Text.Trim,
                                  1,
                                  dtpDateAdded.EditValue,
                                  dtpDateOfManufacture.EditValue,
                                  cmbTaxExempt.EditValue,
                                  cmbSupplierInvoiceNo.EditValue,
                                  1)
        End If
        ClsGoldItem_.DeleteGoldStone(Code)
        For i As Integer = 0 To DgvStone.RowCount - 1
            ClsGoldItem_.AddGoldStone(If(IsNothing(DgvStone.GetRowCellValue(i, colStoneName)), "", DgvStone.GetRowCellValue(i, colStoneName).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStoneType)), "", DgvStone.GetRowCellValue(i, colStoneType).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStoneWeight)), "", DgvStone.GetRowCellValue(i, colStoneWeight).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStoneWeightType)), "", DgvStone.GetRowCellValue(i, colStoneWeightType).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStoneColor)), "", DgvStone.GetRowCellValue(i, colStoneColor).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStoneClarity)), "", DgvStone.GetRowCellValue(i, colStoneClarity).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStoneCut)), "", DgvStone.GetRowCellValue(i, colStoneCut).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStoneCountryOfOrigin)), "", DgvStone.GetRowCellValue(i, colStoneCountryOfOrigin).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStonePrice)), "", DgvStone.GetRowCellValue(i, colStonePrice).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStonePhoto)), "", DgvStone.GetRowCellValue(i, colStonePhoto).ToString),
                                      If(IsNothing(DgvStone.GetRowCellValue(i, colStoneDocument)), "", DgvStone.GetRowCellValue(i, colStoneDocument).ToString),
                                      1,
                                      Code,
                                      1)
        Next

        'txtItemID.Text = ""
        'Code = ""
        'AnotherCode = ""
        'AnotherCode2 = ""
        FrmGoldItemSingle.DGCItem.DataSource = ClsGoldItem_.AllItems
        FrmGoldItemSingle.DGVItem.FocusedRowHandle = FocusedRowNo
    End Sub

#End Region

End Class
