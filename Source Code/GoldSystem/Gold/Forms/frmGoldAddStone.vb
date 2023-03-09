Imports System.ComponentModel
Imports System.IO
Imports DevExpress.Charts.Native
Imports DevExpress.DataAccess.Native.ExpressionEditor
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp

Public Class FrmGoldAddStone
    Dim ClsGoldAddStone_ As New ClsGoldAddStone
    Dim ClsMain_ As New ClsMain
    Public StoneID As String
    Private Sub FrmGoldAddStone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillStoneType()
        FillStoneName()
        FillCaratOrGram()
        FillStoneColor()
        FillStoneClarity()
        FillStoneCut()
        FillStoneCountryOfOrigin()
    End Sub
    Private Sub FillStoneType()
        Try
            Dim DT As New DataTable
            DT = ClsGoldAddStone_.StoneType()
            If DT.Rows.Count > 0 Then
                With cmbStoneType.Properties
                    .DataSource = DT
                    .NullText = "اختر النوع"
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
            DT = ClsGoldAddStone_.StoneName()
            If DT.Rows.Count > 0 Then
                With cmbStoneName.Properties
                    .DataSource = DT
                    .NullText = "اختر الفص"
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
            DT = ClsGoldAddStone_.CaratOrGram()
            If DT.Rows.Count > 0 Then
                With cmbStoneWeightType.Properties
                    .DataSource = DT
                    .NullText = "اختر طريقة الوزن"
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
            DT = ClsGoldAddStone_.StoneColor()
            If DT.Rows.Count > 0 Then
                With cmbStoneColor.Properties
                    .DataSource = DT
                    .NullText = "اختر اللون"
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
            DT = ClsGoldAddStone_.StoneClarity()
            If DT.Rows.Count > 0 Then
                With cmbStoneClarity.Properties
                    .DataSource = DT
                    .NullText = "اختر النقاوة"
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
            DT = ClsGoldAddStone_.StoneCut()
            If DT.Rows.Count > 0 Then
                With cmbStoneCut.Properties
                    .DataSource = DT
                    .NullText = "اختر القصة"
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
    Private Sub FillStoneCountryOfOrigin()
        Try
            Dim DT As New DataTable
            DT = ClsMain_.CountryOfOrigin()
            If DT.Rows.Count > 0 Then
                With cmbStoneCountryOfOrigin.Properties
                    .DataSource = DT
                    .NullText = "اختر الدولة"
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dtStone.Columns.Count = 0 Then
            dtStone.Columns.Add("Serial", GetType(String))
            dtStone.Columns.Add("ID", GetType(String))
            dtStone.Columns.Add("StoneTypeCode", GetType(String))
            dtStone.Columns.Add("StoneNameCode", GetType(String))
            dtStone.Columns.Add("StoneWeight", GetType(String))
            dtStone.Columns.Add("StoneWeightType", GetType(String))
            dtStone.Columns.Add("StoneColor", GetType(String))
            dtStone.Columns.Add("StoneClarity", GetType(String))
            dtStone.Columns.Add("StoneCut", GetType(String))
            dtStone.Columns.Add("StoneCountryOfOrigin", GetType(String))
            dtStone.Columns.Add("StonePrice", GetType(String))
            dtStone.Columns.Add("StonePhoto", GetType(Byte()))
            dtStone.Columns.Add("StoneDocument", GetType(Byte()))
        End If
        If StoneID <> "" Then
            Dim RowNo As Integer = 0
            For i As Integer = 0 To dtStone.Rows.Count - 1
                If dtStone.Rows(i)("ID") = StoneID Then
                    RowNo = i
                    Exit For
                End If
            Next
            dtStone.Rows(RowNo)("StoneTypeCode") = cmbStoneType.EditValue
            dtStone.Rows(RowNo)("StoneNameCode") = cmbStoneName.EditValue
            dtStone.Rows(RowNo)("StoneWeight") = txtWeight.Text.Trim
            dtStone.Rows(RowNo)("StoneWeightType") = cmbStoneWeightType.EditValue
            dtStone.Rows(RowNo)("StoneColor") = cmbStoneColor.EditValue
            dtStone.Rows(RowNo)("StoneClarity") = cmbStoneClarity.EditValue
            dtStone.Rows(RowNo)("StoneCut") = cmbStoneCut.EditValue
            dtStone.Rows(RowNo)("StoneCountryOfOrigin") = cmbStoneCountryOfOrigin.EditValue
            dtStone.Rows(RowNo)("StonePrice") = txtStonePrice.Text.Trim
            dtStone.Rows(RowNo)("StonePhoto") = If(IsNothing(pbStonePhoto.Image), Nothing, ImageToByte(pbStonePhoto.Image))
            dtStone.Rows(RowNo)("StoneDocument") = If(IsNothing(pbStoneDocument.Image), Nothing, ImageToByte(pbStoneDocument.Image))
        Else
            dtStone.Rows.Add(dtStone.Rows.Count + 1,
                                     0,
                                     cmbStoneType.EditValue,
                                     cmbStoneName.EditValue,
                                     txtWeight.Text.Trim,
                                     cmbStoneWeightType.EditValue,
                                     cmbStoneColor.EditValue,
                                     cmbStoneClarity.EditValue,
                                     cmbStoneCut.EditValue,
                                     cmbStoneCountryOfOrigin.EditValue,
                                     txtStonePrice.Text.Trim,
                                     If(IsNothing(pbStonePhoto.Image), Nothing, ImageToByte(pbStonePhoto.Image)),
                                     If(IsNothing(pbStoneDocument.Image), Nothing, ImageToByte(pbStoneDocument.Image)))
        End If



        Close()
    End Sub

    Private Sub FrmGoldAddStone_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
    End Sub

    Private Sub txtPhotoPath_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnStonePhoto.Click
        OFDX.ShowDialog()
        If IsValidImage(OFDX.FileName) Then
            pbStonePhoto.Image = Image.FromFile(OFDX.FileName)
        End If
    End Sub
    Private Sub txtDocumentPath_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnStoneDocument.Click
        OFDX.ShowDialog()
        If IsValidImage(OFDX.FileName) Then
            pbStoneDocument.Image = Image.FromFile(OFDX.FileName)
        End If
    End Sub
End Class