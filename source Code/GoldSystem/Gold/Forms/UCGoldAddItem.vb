Imports DevExpress.XtraEditors
Public Class UCGoldAddItem
    ReadOnly ClsGoldItem_ As New ClsGoldItem
    ReadOnly ClsMain_ As New ClsMain
#Region "Initialize"
    Private Sub UCGoldAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillItemName()
        FillKarat()
        FillCountryOfOrigin()
        FillSupplier()
        FillTaxExempt()
        FillItemCondition()
    End Sub
    Private Sub FillItemName()
        Try
            Dim DT As New DataTable
            DT = ClsGoldItem_.ItemName()
            If DT.Rows.Count > 0 Then
                With cmbItemName.Properties
                    .DataSource = DT
                    .NullText = "اختر صنفًا"
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("NameAr").Caption = "اسم الصنف"
                    .Columns("NameEn").Caption = "Item Name"
                    .DisplayMember = "NameAr"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillKarat()
        Try
            Dim DT As New DataTable
            DT = ClsGoldItem_.Karat()
            If DT.Rows.Count > 0 Then
                With cmbKarat.Properties
                    .DataSource = DT
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .DisplayMember = "Name"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillCountryOfOrigin()
        Try
            Dim DT As New DataTable
            DT = ClsMain_.CountryOfOrigin
            If DT.Rows.Count > 0 Then
                With cmbCountryOfOrigin.Properties
                    .DataSource = DT
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("NameAr").Caption = "الدولة"
                    .Columns("NameEn").Caption = "Country"
                    .DisplayMember = "NameAr"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillSupplier()
        Try
            Dim DT As New DataTable
            DT = ClsGoldItem_.Supplier
            If DT.Rows.Count > 0 Then
                With cmbSupplier.Properties
                    .DataSource = DT
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("CompanyId").Visible = False
                    .Columns("Name").Caption = "المورد"
                    .Columns("PhoneNumber").Caption = "الهاتف"
                    .Columns("Address").Caption = "العنوان"
                    .DisplayMember = "Name"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillTaxExempt()
        Try
            Dim DT As New DataTable
            DT = ClsGoldItem_.TaxExempt
            If DT.Rows.Count > 0 Then
                With cmbTaxExempt.Properties
                    .DataSource = DT
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("NameAr").Caption = "الحالة"
                    .Columns("NameEn").Caption = "Status"
                    .DisplayMember = "NameAr"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillItemCondition()
        Try
            Dim DT As New DataTable
            DT = ClsGoldItem_.ItemCondition
            If DT.Rows.Count > 0 Then
                With cmbItemCondition.Properties
                    .DataSource = DT
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("NameAr").Caption = "الحالة"
                    .Columns("NameEn").Caption = "Condition"
                    .DisplayMember = "NameAr"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Stone"
    Private Sub PbAddStone_Click(sender As Object, e As EventArgs) Handles pbAddStone.Click
        Try
            Dim f As New FrmGoldAddStone
            f.ShowDialog()
            If f.IsTrue = True Then
                Dim Dt As New DataTable
                Dt.Clear()
                With Dt.Columns
                    .Add("نوع الفص")
                    .Add("اسم الفص")
                    .Add("وزن الفص")
                    .Add("ق/جم")
                    .Add("لون الفص")
                    .Add("نقاوة الفص")
                    .Add("قصة الفص")
                    .Add("بلد المنشأ للفص")
                    .Add("سعر الفص")
                    .Add("صورة الفص")
                    .Add("شهادة/مستند الفص")
                End With
                Dt.Clear()
                Dt.Rows.Add(f.CmbStoneType.Text, f.CmbStoneName.Text, f.TxtCostForSeller.Text, f.CmbCaratGm.Text, f.CmbStoneColor.Text,
                            f.CmbStoneClarity.Text, f.CmbStoneCut.Text, f.CmbStoneCountryOfOrigin.Text, f.TxtStonePrice.Text,
                            f.TxtImagePath.Text, f.TxtDocumentPath.Text)
                If Dt.Rows.Count > 0 Then
                    DGVStone1.DataSource = Dt
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region
    Private Sub TxtImagePath_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles txtImagePath.ButtonClick
        OFDX.ShowDialog()
        txtImagePath.Text = OFDX.FileName
    End Sub

    Private Sub TxtDocumentPath_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles txtDocumentPath.ButtonClick
        OFDX.ShowDialog()
        txtImagePath.Text = OFDX.FileName
    End Sub

#Region "Validating"
    Private Sub CmbItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbItemName.Validating
        If IsNothing(sender.EditValue) Then
            EPX.SetError(sender, "اختر صنفًا")
        End If
    End Sub

    Private Sub CmbKarat_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmbKarat.Validating
        If IsNothing(sender.EditValue) Then
            EPX.SetError(sender, "اختر عيارًا")
        End If
    End Sub

    Private Sub TxtGoldWeight_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtGoldWeight.Validating
        If IsNothing(sender.EditValue) Then
            EPX.SetError(sender, "اكتب وزنًا")
        End If
    End Sub

    Private Sub TxtMakingCharge_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMakingCharge.Validating
        If IsNothing(sender.EditValue) Then
            EPX.SetError(sender, "اكتب المصنعية")
        End If
    End Sub

    Private Sub TxtCostPerGram_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCostPerGram.Validating
        If IsNothing(sender.EditValue) Then
            EPX.SetError(sender, "اكتب التكلفة")
        End If
    End Sub

    Private Sub CmbItemName_ProcessNewValue(sender As Object, e As Controls.ProcessNewValueEventArgs) Handles cmbItemName.ProcessNewValue
        If CStr(e.DisplayValue) = String.Empty Then
            Return
        End If
        If XtraMessageBox.Show("Do you want to add a new value?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim Id As Integer = ClsGoldItem_.ItemNameAdd(e.DisplayValue.ToString)
            cmbItemName.Properties.DataSource = Nothing
            FillItemName()
            cmbItemName.ItemIndex = Id + 1
        End If
    End Sub
#End Region
End Class
