Public Class FrmLanguage
    Dim ClsMain_ As New ClsMain
    Dim ClsGoldItem_ As New ClsGoldItem
    'Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
    '    Try
    '        If String.IsNullOrWhiteSpace(TxtName.Text) Then
    '            MessageBox.Show("يرجى ادخال اسم المورد")
    '            Return
    '        End If
    '        ClsMain_.AddNewSupplier(TxtCode.Text, TxtName.Text, TxtPhoneNumber.Text,
    '                                TxtAddress.Text, TxtCompany.Text)
    '        AllSuppliers()
    '        MessageBox.Show("تم الحفظ")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Sub AllSuppliers()
    '    Dim DtAll As New DataTable
    '    DtAll.Clear()
    '    DtAll = ClsGoldItem_.AllSupplier()
    '    If DtAll.Rows.Count > 0 Then
    '        DGV.DataSource = DtAll
    '    End If
    'End Sub
    'Sub Max()
    '    Dim DT As New DataTable
    '    DT.Clear()
    '    DT = ClsGoldItem_.MaxSupplier()
    '    If DT.Rows.Count > 0 Then
    '        TxtCode.Text = DT.Rows(0)(0)
    '    End If
    'End Sub
    'Private Sub GridView1_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
    '    Try
    '        TxtCode.Text = GridView1.GetFocusedDataRow("رقم المورد")
    '        TxtName.Text = GridView1.GetFocusedDataRow("اسم المورد")
    '        TxtPhoneNumber.Text = GridView1.GetFocusedDataRow("رقم الهاتف")
    '        TxtAddress.Text = GridView1.GetFocusedDataRow("العنوان")
    '        TxtCompany.Text = GridView1.GetFocusedDataRow("رقم الشركة")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
    '    Try
    '        If String.IsNullOrWhiteSpace(TxtName.Text) Then
    '            MessageBox.Show("يرجى ادخال اسم المورد")
    '            Return
    '        End If
    '        ClsMain_.UpdateSupplier(TxtCode.Text, TxtName.Text, TxtPhoneNumber.Text,
    '                                TxtAddress.Text, TxtCompany.Text)
    '        AllSuppliers()
    '        MessageBox.Show("تم التعديل")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
End Class