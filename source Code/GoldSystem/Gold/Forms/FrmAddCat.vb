﻿Imports System.Text

Public Class FrmAddCat
    Dim ClsGoldItem_ As New ClsGoldItem
    Dim ClsMain_ As New ClsMain
    Dim counter As Integer = 0
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If ComStone.Text = String.Empty Then
                MessageBox.Show("يجب اختيار الفصوص")
                Return
            End If
            If TxtStoneWeight.Text = String.Empty Or TxtStoneWeight.Text = 0 Then
                MessageBox.Show("يجب ادخال الوزن")
                Return
            End If
            If TxtStonePrice.Text = String.Empty Or TxtStonePrice.Text = 0 Then
                MessageBox.Show("يجب ادخال السعر")
                Return
            End If
            counter += 1
            Dim row As String() = New String() {ComStone.SelectedValue, counter,
                                                  ComStone.Text,
                                                  TxtStoneWeight.Text,
                                                  TxtStoneColor.Text, TxtStonePrice.Text,
                                                  LblFileExtentions.Text,
                                                  TxtClarity.Text, TxtCut.Text}
            DgvStone.Rows.Add(row)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtStoneWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStoneWeight.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("ارقام فقط")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtStonePrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStonePrice.KeyPress
        Try
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
                MessageBox.Show("ارقام فقط")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComStone_DropDown(sender As Object, e As EventArgs) Handles ComStone.DropDown, ComboBox1.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.Stone()
            If DT.Rows.Count > 0 Then
                ComStone.DataSource = DT
                ComStone.DisplayMember = "Name"
                ComStone.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComStoneBlock_DropDown(sender As Object, e As EventArgs)
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.Stone()
            If DT.Rows.Count > 0 Then
                'ComStoneBlock.DataSource = DT
                'ComStoneBlock.DisplayMember = "Name"
                'ComStoneBlock.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            Dim f As New FrmAdderItem
            Dim dt As New DataTable
            dt.Clear()
            dt = ClsMain_.GetItemCode()
            If dt.Rows.Count > 0 Then
                f.TxtCode.Text = dt.Rows(0)(0)
                Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghigklmnopqrstuvxyz"
                Dim r As New Random
                Dim sb As New StringBuilder
                For i As Integer = 1 To 8
                    Dim idx As Integer = r.Next(0, 35)
                    sb.Append(s.Substring(idx, 1))
                Next
                f.TxtBarCode.Text = sb.ToString()
            End If
            f.ShowDialog()
            If f.IsYes = True Then
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComKart.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.Kart()
            If DT.Rows.Count > 0 Then
                ComKart.DataSource = DT
                ComKart.DisplayMember = "Name"
                ComKart.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub ShowRadial()
        RadialMenu1.ShowPopup(New Point(95, 140))
    End Sub
    Private Sub PictureEdit9_Click(sender As Object, e As EventArgs) Handles PictureEdit9.Click
        Try
            ShowRadial()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub PictureEdit10_Click(sender As Object, e As EventArgs) Handles PictureEdit10.Click
        Try
            ShowRadial()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub PictureEdit11_Click(sender As Object, e As EventArgs) Handles PictureEdit11.Click
        Try
            ShowRadial()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Try
            Max()
            ClsGoldItem_.AddItem(TxtCode.Text, 0, 0, TxtBarCode.Text, ComName.Text, ComKart.SelectedValue,
                            TxtWeight.Text, TxtMakingCharge.Text, TxtTotalCost.Text, TxtCostGram.Text,
                            ComMadIN.SelectedValue, ComSupplier.SelectedValue, TxtPath2.Text, TxtNumberPieses.Text,
                            TxtNumber.Text, TxtRamz.Text)
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
            TxtCode.Text = dt.Rows(0)(0)
            TxtCodeBlock.Text = dt.Rows(0)(0)
        End If
    End Sub
    Sub AddStone()
        If DgvStone.Rows.Count > 0 Then
            For i As Integer = 0 To DgvStone.Rows.Count - 1
                ClsGoldItem_.AddStonForItem(TxtCode.Text, DgvStone.Rows(i).Cells(0).Value,
                                DgvStone.Rows(i).Cells(4).Value,
                                DgvStone.Rows(i).Cells(5).Value,
                                DgvStone.Rows(i).Cells(3).Value,
                                DgvStone.Rows(i).Cells(6).Value)
            Next
        End If
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
    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Guna2Button13.Click
        Try
            If OFD.ShowDialog = DialogResult.OK Then
                Dim path As String = OFD.FileName
                LblFileExtentions.Text = path
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub PictureEdit13_Click(sender As Object, e As EventArgs) Handles PictureEdit13.Click
        Try
            If OFD.ShowDialog = DialogResult.OK Then
                Dim path As String = OFD.FileName
                TxtPathBlock.Text = path
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)
        Try
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
    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Try
            Max()
            ClsGoldItem_.AddItem(TxtCodeBlock.Text, 0, 0, TxtBarCodeBlock.Text, ComNameBlock.Text, ComKartBlock.SelectedValue,
                            TxtWeightBlock.Text, TxtMakingChargeBlock.Text, TxtTotalCostBlock.Text, TxtCostGramBlock.Text,
                            ComMadINBlock.SelectedValue, ComSupplierBlock.SelectedValue, TxtPathBlock.Text, TxtNumberPiesesBlock.Text,
                            TxtNumberBlock.Text, TxtRamzBlock.Text)
            AddStoneBlock()
            AddAnotherItem()
            MessageBox.Show("تم حفظ الصنف")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub AddAnotherItem()
        If DgvAdderItem.Rows.Count > 0 Then
            For i As Integer = 0 To DgvAdderItem.Rows.Count - 1
                ClsGoldItem_.AddItem(DgvAdderItem.Rows(i).Cells(0).Value, TxtCodeBlock.Text, 0, DgvAdderItem.Rows(i).Cells(1).Value,
DgvAdderItem.Rows(i).Cells(2).Value, DgvAdderItem.Rows(i).Cells(3).Value,
DgvAdderItem.Rows(i).Cells(4).Value, DgvAdderItem.Rows(i).Cells(5).Value, DgvAdderItem.Rows(i).Cells(6).Value,
DgvAdderItem.Rows(i).Cells(7).Value,
DgvAdderItem.Rows(i).Cells(8).Value, DgvAdderItem.Rows(i).Cells(12).Value,
DgvAdderItem.Rows(i).Cells(13).Value, DgvAdderItem.Rows(i).Cells(9).Value,
DgvAdderItem.Rows(i).Cells(11).Value, DgvAdderItem.Rows(i).Cells(10).Value)
            Next
        End If
    End Sub
    Private Sub ComKartBlock_DropDown(sender As Object, e As EventArgs) Handles ComKartBlock.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.Kart()
            If DT.Rows.Count > 0 Then
                ComKartBlock.DataSource = DT
                ComKartBlock.DisplayMember = "Name"
                ComKartBlock.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComName_DropDown(sender As Object, e As EventArgs) Handles ComName.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.ItemName()
            If DT.Rows.Count > 0 Then
                ComName.DataSource = DT
                ComName.DisplayMember = "Name"
                ComName.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComSupplier_DropDown(sender As Object, e As EventArgs) Handles ComSupplier.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.Supplier()
            If DT.Rows.Count > 0 Then
                ComSupplier.DataSource = DT
                ComSupplier.DisplayMember = "Name"
                ComSupplier.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComMadIN_DropDown(sender As Object, e As EventArgs) Handles ComMadIN.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.MadeIn()
            If DT.Rows.Count > 0 Then
                ComMadIN.DataSource = DT
                ComMadIN.DisplayMember = "Name"
                ComMadIN.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BarLargeButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem1.ItemClick
        Dim F As New FrmAddNweSupplier
        Dim DT As New DataTable
        DT.Clear()
        DT = ClsGoldItem_.MaxSupplier()
        If DT.Rows.Count > 0 Then
            F.TxtCode.Text = DT.Rows(0)(0)
        End If
        Dim DtAll As New DataTable
        DtAll.Clear()
        DtAll = ClsGoldItem_.AllSupplier()
        If DtAll.Rows.Count > 0 Then
            F.DGV.DataSource = DtAll
        End If
        F.Show()
    End Sub
    Private Sub ComSupplierBlock_DropDown(sender As Object, e As EventArgs) Handles ComSupplierBlock.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.Supplier()
            If DT.Rows.Count > 0 Then
                ComSupplierBlock.DataSource = DT
                ComSupplierBlock.DisplayMember = "Name"
                ComSupplierBlock.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComNameBlock_DropDown(sender As Object, e As EventArgs) Handles ComNameBlock.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.ItemName()
            If DT.Rows.Count > 0 Then
                ComNameBlock.DataSource = DT
                ComNameBlock.DisplayMember = "Name"
                ComNameBlock.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComMadINBlock_DropDown(sender As Object, e As EventArgs) Handles ComMadINBlock.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.MadeIn()
            If DT.Rows.Count > 0 Then
                ComMadINBlock.DataSource = DT
                ComMadINBlock.DisplayMember = "Name"
                ComMadINBlock.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComMadeInStone.DropDown
        Try
            Dim DT As New DataTable
            DT.Clear()
            DT = ClsGoldItem_.MadeIn()
            If DT.Rows.Count > 0 Then
                ComMadeInStone.DataSource = DT
                ComMadeInStone.DisplayMember = "Name"
                ComMadeInStone.ValueMember = "Code"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub gl_Click(sender As Object, e As EventArgs) Handles TxtPath.Click
        Try
            If OFD.ShowDialog = DialogResult.OK Then
                Dim path As String = OFD.FileName
                TxtPath.Text = path
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtDoc_Click(sender As Object, e As EventArgs) Handles TxtDoc.Click
        Try
            If OFD.ShowDialog = DialogResult.OK Then
                Dim path As String = OFD.FileName
                TxtDoc.Text = path
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class