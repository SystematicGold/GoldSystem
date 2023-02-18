Public Class FrmGoldAddStone
    Dim ClsGoldAddStone_ As New ClsGoldAddStone
    Dim ClsMain_ As New ClsMain
    Private Sub FrmGoldAddStone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillStoneType()
        FillStoneName()
        FillCaratOrGram()
        FillStoneColor()
        FillStoneClarity()
        FillStoneCut()
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
                With cmbCaratGm.Properties
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
    Private Sub FillCountryOfOrigin()
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
End Class