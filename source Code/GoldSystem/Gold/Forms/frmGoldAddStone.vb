
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class FrmGoldAddStone
    ReadOnly ClsGoldAddStone_ As New ClsGoldAddStone
    ReadOnly ClsMain_ As New ClsMain
    Public IsTrue As Boolean = False
    Private Sub FrmGoldAddStone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillStoneType()
            FillStoneName()
            FillCaratOrGram()
            FillStoneColor()
            FillStoneClarity()
            FillStoneCut()
            FillStoneCountry()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillStoneCountry()
        Dim DT As New DataTable
        DT.Clone()
        DT = ClsGoldAddStone_.StoneCountry()
        If DT.Rows.Count > 0 Then
            With CmbStoneCountryOfOrigin.Properties
                .DataSource = DT
                '.NullText = "بلد المنشأ"
                .PopulateColumns()
                .Columns("Id").Visible = False
                .Columns("Code").Visible = False
                .Columns("NameAr").Caption = "نوع الفص"
                .Columns("NameEn").Caption = "Stone Country"
                .DisplayMember = "NameAr"
                .ValueMember = "Code"
            End With
        End If
    End Sub
    Private Sub FillStoneType()
        Try
            Dim DT As New DataTable
            DT.Clone()
            DT = ClsGoldAddStone_.StoneType()
            If DT.Rows.Count > 0 Then
                With CmbStoneType.Properties
                    .DataSource = DT
                    '.NullText = "نوع الفص"
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("NameAr").Caption = "نوع الفص"
                    .Columns("NameEn").Caption = "Stone Type"
                    .DisplayMember = "NameAr"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillStoneName()
        Try
            Dim DT As New DataTable
            DT.Clone()
            DT = ClsGoldAddStone_.StoneName()
            If DT.Rows.Count > 0 Then
                With CmbStoneName.Properties
                    .DataSource = DT
                    '.NullText = "اختر الفص"
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("StoneTypeCode").Visible = False
                    .Columns("NameAr").Caption = "اسم الفص"
                    .Columns("NameEn").Caption = "Stone Name"
                    .DisplayMember = "NameAr"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillCaratOrGram()
        Try
            Dim DT As New DataTable
            DT.Clone()
            DT = ClsGoldAddStone_.CaratOrGram()
            If DT.Rows.Count > 0 Then
                With CmbCaratGm.Properties
                    .DataSource = DT
                    '.NullText = "اختر طريقة الوزن"
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("NameAr").Caption = "طريقة الوزن"
                    .Columns("NameEn").Caption = "Weight Type"
                    .DisplayMember = "NameAr"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillStoneColor()
        Try
            Dim DT As New DataTable
            DT.Clone()
            DT = ClsGoldAddStone_.StoneColor()
            If DT.Rows.Count > 0 Then
                With CmbStoneColor.Properties
                    .DataSource = DT
                    '.NullText = "اختر اللون"
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("IsDiamondColor").Visible = False
                    .Columns("NameAr").Caption = "اللون"
                    .Columns("NameEn").Caption = "Color"
                    .DisplayMember = "NameAr"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillStoneClarity()
        Try
            Dim DT As New DataTable
            DT.Clone()
            DT = ClsGoldAddStone_.StoneClarity()
            If DT.Rows.Count > 0 Then
                With CmbStoneClarity.Properties
                    .DataSource = DT
                    '.NullText = "اختر النقاوة"
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("Name").Caption = "النقاوة/Clarity"
                    .DisplayMember = "Name"
                    .ValueMember = "Code"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillStoneCut()
        Try
            Dim DT As New DataTable
            DT.Clone()
            DT = ClsGoldAddStone_.StoneCut()
            If DT.Rows.Count > 0 Then
                With CmbStoneCut.Properties
                    .DataSource = DT
                    '.NullText = "اختر القصة"
                    .PopulateColumns()
                    .Columns("Id").Visible = False
                    .Columns("Code").Visible = False
                    .Columns("Name").Caption = "القصة/Cut"
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
            DT.Clone()
            DT = ClsMain_.CountryOfOrigin()
            If DT.Rows.Count > 0 Then
                With CmbStoneCountryOfOrigin.Properties
                    .DataSource = DT
                    '.NullText = "اختر الدولة"
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
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim d As Integer = 0
            DEPError.ClearErrors()
            For Each Ctl In Controls
                If Ctl.GetType() Is GetType(LookUpEdit) Then
                    If Ctl.text = String.Empty Then
                        If Ctl.name = "CmbStoneColor" Or Ctl.name = "CmbStoneClarity" Or Ctl.name = "CmbStoneCut" Then
                            Ctl.text = "0"
                        Else
                            DEPError.SetError(Ctl, "بيانات فارغة")
                            d += 1
                        End If
                    End If
                End If
                If Ctl.GetType() Is GetType(TextEdit) Then
                    If Ctl.text = String.Empty Then
                        DEPError.SetError(Ctl, "بيانات فارغة")
                        d += 1
                    End If
                End If
            Next
            If d > 0 Then
                Return
            Else
                d = 0
            End If
            IsTrue = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtImagePath_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtImagePath.ButtonClick
        Try
            OFD.Filter = ""
            If OFD.ShowDialog = DialogResult.OK Then
                TxtImagePath.Text = OFD.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub TxtDocumentPath_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles TxtDocumentPath.ButtonClick
        Try
            OFD.Filter = ""
            If OFD.ShowDialog = DialogResult.OK Then
                TxtDocumentPath.Text = OFD.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class