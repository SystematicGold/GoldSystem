Imports System.Data.OleDb
Imports System.Text
Public Class frmGoldItem
    Dim ClsGoldItem_ As New ClsGoldItem
    Dim ClsMain_ As New ClsMain
    Dim counter As Integer = 0
    Dim btnAddStoneLeft As Integer

    Private Sub TxtStoneWeight_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("ارقام فقط")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtStonePrice_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("ارقام فقط")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComStone_DropDown(sender As Object, e As EventArgs)
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.StoneName()
            If DT.Rows.Count > 0 Then
                'ComStone.DataSource = DT
                'ComStone.DisplayMember = "Name"
                'ComStone.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComStoneBlock_DropDown(sender As Object, e As EventArgs)
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.StoneName()
            If DT.Rows.Count > 0 Then
                'ComStoneBlock.DataSource = DT
                'ComStoneBlock.DisplayMember = "Name"
                'ComStoneBlock.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs)
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.Karat()
            If DT.Rows.Count > 0 Then
                'ComKart.DataSource = DT
                'ComKart.DisplayMember = "Name"
                'ComKart.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ShowRadial()
        RadialMenu1.ShowPopup(New Point(95, 140))
    End Sub
    Private Sub PictureEdit9_Click(sender As Object, e As EventArgs)
        Try
            ShowRadial()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub PictureEdit10_Click(sender As Object, e As EventArgs)
        Try
            ShowRadial()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub PictureEdit11_Click(sender As Object, e As EventArgs)
        Try
            ShowRadial()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        Try
            Max()
            'ClsGoldItem_.AddItem(TxtCode.Text, 0, 0, TxtBarCode.Text, ComName.Text, ComKart.SelectedValue,
            '                TxtWeight.Text, TxtMakingCharge.Text, TxtTotalCost.Text, TxtCostGram.Text,
            '                ComMadIN.SelectedValue, ComSupplier.SelectedValue, TxtPath2.Text, TxtNumberPieses.Text,
            '                TxtNumber.Text, TxtRamz.Text)
            AddStone()
            MessageBox.Show("تم حفظ الصنف")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Max()
        Dim dt As New DataTable
        dt.Clear()
        dt = ClsMain_.GetItemCode()
        If dt.Rows.Count > 0 Then
            'TxtCode.Text = dt.Rows(0)(0)
            'TxtCodeBlock.Text = dt.Rows(0)(0)
        End If
    End Sub
    Sub AddStone()
        'If DgvStone.Rows.Count > 0 Then
        '    For i As Integer = 0 To DgvStone.Rows.Count - 1
        '        ClsGoldItem_.AddStonForItem(TxtCode.Text, DgvStone.Rows(i).Cells(0).Value,
        '                        DgvStone.Rows(i).Cells(4).Value,
        '                        DgvStone.Rows(i).Cells(5).Value,
        '                        DgvStone.Rows(i).Cells(3).Value,
        '                        DgvStone.Rows(i).Cells(6).Value)
        'Next
        'End If
    End Sub
    Sub AddStoneBlock()
        'If DgvStoneBlock.Rows.Count > 0 Then
        '    For i As Integer = 0 To DgvStoneBlock.Rows.Count - 1
        '        ClsGoldItem_.AddStonForItem(TxtCodeBlock.Text, DgvStoneBlock.Rows(i).Cells(0).Value,
        '                        DgvStoneBlock.Rows(i).Cells(4).Value,
        '                        DgvStoneBlock.Rows(i).Cells(5).Value,
        '                        DgvStoneBlock.Rows(i).Cells(3).Value,
        ''                        DgvStoneBlock.Rows(i).Cells(6).Value)
        'Next
        'End If
    End Sub
    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs)
        Try
            Dim OFD As New OpenFileDialog
            If OFD.ShowDialog = DialogResult.OK Then
                Dim path As String = OFD.FileName
                'LblFileExtentions.Text = path
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub PictureEdit13_Click(sender As Object, e As EventArgs)
        Try
            Dim OFD As New OpenFileDialog
            If OFD.ShowDialog = DialogResult.OK Then
                Dim path As String = OFD.FileName
                'TxtPathBlock.Text = path
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)
        Try
            Dim OFD As New OpenFileDialog
            If OFD.ShowDialog = DialogResult.OK Then
                Dim path As String = OFD.FileName
                'LblFileExtentionsBlock.Text = path
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs)
        Try
            'If ComStoneBlock.Text = String.Empty Then
            '    MessageBox.Show("يجب اختيار الفصوص")
            '    Return
            'End If
            'If TxtStoneWeightBlock.Text = String.Empty Or TxtStoneWeightBlock.Text = 0 Then
            '    MessageBox.Show("يجب ادخال الوزن")
            '    Return
            'End If
            'If TxtStonePriceBlock.Text = String.Empty Or TxtStonePriceBlock.Text = 0 Then
            '    MessageBox.Show("يجب ادخال السعر")
            '    Return
            'End If
            'counter += 1
            'Dim row As String() = New String() {ComStoneBlock.SelectedValue, counter,
            '                                      ComStoneBlock.Text,
            '                                      TxtStoneWeightBlock.Text,
            '                                      TxtStoneColorBlock.Text, TxtStonePriceBlock.Text,
            '                                      LblFileExtentionsBlock.Text}
            'DgvStoneBlock.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs)
        Try
            Max()
            'ClsGoldItem_.AddItem(TxtCodeBlock.Text, 0, 0, TxtBarCodeBlock.Text, ComNameBlock.Text, ComKartBlock.SelectedValue,
            '                TxtWeightBlock.Text, TxtMakingChargeBlock.Text, TxtTotalCostBlock.Text, TxtCostGramBlock.Text,
            '                ComMadINBlock.SelectedValue, ComSupplierBlock.SelectedValue, TxtPathBlock.Text, TxtNumberPiesesBlock.Text,
            '                TxtNumberBlock.Text, TxtRamzBlock.Text)
            AddStoneBlock()
            AddAnotherItem()
            MessageBox.Show("تم حفظ الصنف")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub AddAnotherItem()
        '        If dgvSetItem.Rows.Count > 0 Then
        '            For i As Integer = 0 To Me.dgvSetItem.Rows.Count - 1
        '                ClsGoldItem_.AddItem(Me.dgvSetItem.Rows(i).Cells(0).Value, txtSetCode.Text, 0, Me.dgvSetItem.Rows(i).Cells(1).Value,
        'Me.dgvSetItem.Rows(i).Cells(2).Value, Me.dgvSetItem.Rows(i).Cells(3).Value,
        'Me.dgvSetItem.Rows(i).Cells(4).Value, Me.dgvSetItem.Rows(i).Cells(5).Value, Me.dgvSetItem.Rows(i).Cells(6).Value,
        'Me.dgvSetItem.Rows(i).Cells(7).Value,
        'Me.dgvSetItem.Rows(i).Cells(8).Value, Me.dgvSetItem.Rows(i).Cells(12).Value,
        'Me.dgvSetItem.Rows(i).Cells(13).Value, Me.dgvSetItem.Rows(i).Cells(9).Value,
        'Me.dgvSetItem.Rows(i).Cells(11).Value, Me.dgvSetItem.Rows(i).Cells(10).Value)
        '            Next
        '        End If
    End Sub


    Private Sub Guna2Button12_Click_1(sender As Object, e As EventArgs)
        Try
            Dim OFD As New OpenFileDialog
            OFD.Filter = "Excel 2013|*.xlsx|Excel 2003|*.xls"
            If OFD.ShowDialog = DialogResult.OK Then
                DgvAddItems.DataSource = Nothing
                Dim path As String = OFD.FileName
                Dim CONN As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & path & ";Extended Properties='Excel 12.0 Xml;HDR=YES';")
                Dim DT As New DataTable
                DT.Clear()
                CONN.Open()
                Dim DT0 As New DataTable
                DT0.Clear()
                DT0 = CONN.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                'ComboBox1.DataSource = DT0
                'ComboBox1.DisplayMember = "TABLE_NAME"
                'ComboBox1.ValueMember = "TABLE_NAME"
                Dim CMD As New OleDbCommand("SELECT * FROM [Sheet1$]", CONN)
                DT.Load(CMD.ExecuteReader)
                CONN.Close()
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            'If tabMain.SelectedIndex = 2 Then
            '    Dim DT As New DataTable
            '    DT.Clear()
            '    DT = ClsGoldItem_.ShowAllItems()
            '    If DT.Rows.Count > 0 Then
            '        DGVSelectAll.DataSource = DT
            '    Else
            '    End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub FrmAddCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btnAddStoneLeft = btnAddStone.Left
        'tabMain.SelectedIndex = tabMain.TabPages.Count - 1
    End Sub

    Private Sub pbAddSetItem_Click(sender As Object, e As EventArgs) Handles pbAddSetItem.Click
        Try
            Dim f As New FrmGoldAddStone
            Dim dt As New DataTable
            dt.Clear()
            dt = ClsMain_.GetItemCode()
            If dt.Rows.Count > 0 Then
                'frmGoldAddStone.TxtCode.Text = dt.Rows(0)(0)
                Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghigklmnopqrstuvxyz"
                Dim r As New Random
                Dim sb As New System.Text.StringBuilder
                For i As Integer = 1 To 8
                    Dim idx As Integer = r.Next(0, 35)
                    sb.Append(s.Substring(idx, 1))
                Next
                'f.txtBarCode.Text = sb.ToString()
            End If
            frmGoldAddStone.ShowDialog()
            'If frmGoldAddStone.IsYes = True Then
            'Dim row As String() = New String() {
            '                                 f.TxtCode.Text,
            '                                 f.TxtBarCode.Text,
            '                                 f.ComNameBlock.Text,
            '                                 f.ComKart.SelectedValue,
            '                                 f.TxtWeight.Text,
            '                                 f.TxtMade.Text,
            '                                 f.TxtCost.Text,
            '                                 f.TxtCostGram.Text,
            '                                 f.ComMadINBlock.SelectedValue,
            '                                 f.TxtPeace.Text,
            '                                 f.TxtRamzBlock.Text,
            '                                 f.TxtNumberBlock.Text,
            '                                 f.ComSupplierBlock.SelectedValue,
            '                                 f.TxtPath.Text}
            'DgvAdderItem.Rows.Add(row)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class