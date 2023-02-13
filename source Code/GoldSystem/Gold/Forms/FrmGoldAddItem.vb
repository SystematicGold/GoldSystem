Public Class FrmGoldAddItem
    Dim ClsItem As New ClsGoldItem
    Public IsYes = False


    'Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs)
    '    Try
    '        Dim DT As New DataTable
    '        DT.Clear()
    '        DT = ClsItem.Kart()
    '        If DT.Rows.Count > 0 Then
    '            ComKart.DataSource = DT
    '            ComKart.DisplayMember = "Name"
    '            ComKart.ValueMember = "Code"
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    Try
    '        IsYes = True
    '        Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    Try
    '        NumberOnly(sender, e)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TextBox5_Enter(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxEnter(TxtWeight)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TextBox5_Leave(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxLeave(TxtWeight)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TxtMade_Enter(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxEnter(TxtMade)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TxtMade_Leave(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxLeave(TxtMade)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TxtCost_Enter(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxEnter(TxtCost)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TxtCost_Leave(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxLeave(TxtCost)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TxtCostGram_Enter(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxEnter(TxtCostGram)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TxtCostGram_Leave(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxLeave(TxtCostGram)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TxtPeace_Enter(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxEnter(TxtPeace)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub TxtPeace_Leave(sender As Object, e As EventArgs)
    '    Try
    '        TextBoxLeave(TxtPeace)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub PictureEdit12_Click(sender As Object, e As EventArgs)
    '    Try
    '        If OFD.ShowDialog = DialogResult.OK Then
    '            Dim path As String = OFD.FileName
    '            TxtPath.Text = path
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub ComSupplierBlock_DropDown(sender As Object, e As EventArgs)
    '    Try
    '        Dim DT As New DataTable
    '        DT.Clear()
    '        DT = ClsItem.Supplier()
    '        If DT.Rows.Count > 0 Then
    '            ComSupplierBlock.DataSource = DT
    '            ComSupplierBlock.DisplayMember = "Name"
    '            ComSupplierBlock.ValueMember = "Code"
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub ComNameBlock_DropDown(sender As Object, e As EventArgs)
    '    Try
    '        Dim DT As New DataTable
    '        DT.Clear()
    '        DT = ClsItem.ItemName()
    '        If DT.Rows.Count > 0 Then
    '            ComNameBlock.DataSource = DT
    '            ComNameBlock.DisplayMember = "Name"
    '            ComNameBlock.ValueMember = "Code"
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
    'Private Sub ComMadINBlock_DropDown(sender As Object, e As EventArgs)
    '    Try
    '        Dim DT As New DataTable
    '        DT.Clear()
    '        DT = ClsItem.MadeIn()
    '        If DT.Rows.Count > 0 Then
    '            ComMadINBlock.DataSource = DT
    '            ComMadINBlock.DisplayMember = "Name"
    '            ComMadINBlock.ValueMember = "Code"
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub
End Class