Public Class FrmGoldItemSet

<<<<<<< Updated upstream
=======
Public Class FrmGoldItemSet
    Private ReadOnly ClsGoldItem_ As New ClsGoldItem
    Private Sub RecentPinItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.RecentItemEventArgs) Handles RecentPinItem2.ItemClick
        Try
            DEP.ClearErrors()
            For Each ctl As Control In Me.Controls
                If ctl.GetType() Is GetType(TextEdit) Then
                    If ctl.Text = String.Empty Then
                        DEP.SetError(ctl, "يجب ملء الحقول المطلوبة")
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub RecentPinItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.RecentItemEventArgs) Handles RecentPinItem3.ItemClick
        Try
            DEP.ClearErrors()
            For Each ctl As Control In Me.Controls
                If ctl.GetType() Is GetType(TextEdit) Then
                    ctl.Text = String.Empty
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub RecentPinItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.RecentItemEventArgs) Handles RecentPinItem1.ItemClick
        Try
            Dim F As New FrmGoldAddItem With {
                .AddSet = 1
            }
            UCGoldAddItem.AddSet = 1
            F.ShowDialog()
            If F.IsYes = True Then
                If dtStone.Columns.Count = 0 Then
                    dtStone.Columns.Add("اسم الصنف", GetType(String))
                    dtStone.Columns.Add("عيار الذهب", GetType(String))
                    dtStone.Columns.Add("وزن الذهب", GetType(String))
                    dtStone.Columns.Add("مصنعية البيع / جرام", GetType(String))
                    dtStone.Columns.Add("بلد المنشأ", GetType(String))
                    dtStone.Columns.Add("المورد", GetType(String))
                    'dtStone.Columns.Add("رقم فاتورة المورد", GetType(String))
                    dtStone.Columns.Add("عدد القطع", GetType(String))
                    dtStone.Columns.Add("رقم القطعة", GetType(String))
                    dtStone.Columns.Add("رمز القطعة", GetType(String))
                    dtStone.Columns.Add("تكلفة الشراء للجرام", GetType(String))
                    dtStone.Columns.Add("تكلفة البائع", GetType(String))
                    dtStone.Columns.Add("سعر الجرام عند الشراء", GetType(String))
                    dtStone.Columns.Add("سعر شراء القطعة", GetType(String))
                    dtStone.Columns.Add("حالة القطعة", GetType(String))
                    dtStone.Columns.Add("حالة الاعفاء الضريبى", GetType(String))
                    dtStone.Columns.Add("تاريخ الصنع", GetType(String))
                    dtStone.Columns.Add("تاريخ الادخال", GetType(String))
                    dtStone.Columns.Add("الباركود", GetType(String))
                    dtStone.Columns.Add("صورة القطعة", GetType(Image))
                    dtStone.Columns.Add("مستندات / شهادات للقطعة", GetType(Image))
                End If
                dtStone.Clear()
                For I As Integer = 0 To F.AddGoldItem.txtNumberOfPieces.Text - 1
                    dtStone.Rows.Add(F.AddGoldItem.cmbItemName.EditValue, F.AddGoldItem.cmbKarat.EditValue, F.AddGoldItem.txtGoldWeight.Text,
                           F.AddGoldItem.txtMakingCharge.EditValue, F.AddGoldItem.cmbCountryOfOrigin.EditValue,
                           F.AddGoldItem.cmbSupplier.EditValue)
                    DGV.DataSource = dtStone
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FrmGoldItemSet_Load() Handles MyBase.Load
        Try
            ClsGoldItem_.FillItemName(cmbItemName)
            ClsGoldItem_.FillKarat(cmbKarat)
            ClsGoldItem_.FillCountryOfOrigin(cmbCountryOfOrigin)
            ClsGoldItem_.FillSupplier(cmbSupplier)
            'ClsGoldItem_.FillTaxExempt(cmbTaxExempt)
            'ClsGoldItem_.FillItemCondition(cmbItemCondition)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
>>>>>>> Stashed changes
End Class