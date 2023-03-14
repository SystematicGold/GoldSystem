Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Public Class ClsGoldItem
    Dim Con As New ClsConnectionString
    Dim ClsMain_ As New ClsMain
    Dim ClsGoldAddStone_ As New ClsGoldAddStone
    Public Function CheckDuplicateBarCode(BarCode As String, ID As String) As Boolean
        Dim Con As New ClsConnectionString
        Dim dt As New DataTable
        dt.Clear()
        dt = Con.SELECT_TXT("SELECT [BarCode] FROM [GoldStock] WHERE BarCode = N'" & BarCode & "' AND ID <> N'" & ID & "'")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetItemBarCodeSerial(BarCodeString As String) As String
        Dim Con As New ClsConnectionString
        Dim dt As New DataTable
        dt.Clear()
        dt = Con.SELECT_TXT("SELECT FORMAT((SELECT ISNULL((SELECT SUBSTRING(MAX(BarCode),4,9) FROM [GoldStock] WHERE BarCode LIKE '" & BarCodeString & "%')+1, 1)),'000000')")
        Return dt(0)(0).ToString
    End Function
    Public Function StoneName() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn] FROM [DeffStoneName] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Function Karat() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [Name] FROM [DeffKarat] WHERE [Enabled] = 1 ORDER BY Code")
        Return DT
    End Function
    Public Function ItemName() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn] , [BarCodeString] FROM [GoldDeffItemName] ORDER BY Code")
        Return DT
    End Function
    Public Function ItemNameAdd(NewItem As String) As Integer
        Dim DT As New DataTable
        DT = Con.SELECT_TXT("SELECT MAX([Id]) FROM [GoldDeffItemName]")
        Con.EXECUTE_TXT("INSERT INTO [GoldDeffItemName] VALUES (N'" & Val(DT(0)(0).ToString) + 1 & "', N'" & NewItem & "', N'" & NewItem & "')")
        Return Int(DT(0)(0).ToString)
    End Function
    Public Function Supplier() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [Name] , [PhoneNumber] , [Address] , [CompanyId]  FROM [DeffSupplier] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function

    Public Function TaxExempt() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn] FROM [DeffTaxExempt] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Function ItemCondition() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn] FROM [DeffItemCondition] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Sub AddStoneToItem(CategoriesCode As Integer, StoneCode As Integer, Weight As Decimal, WeightType As Integer,
                              Color As String, Clarity As String, Cut As String, CountryOfOrigin As String, Price As Double,
                              PhotoPath_ As String, DocumentPath_ As String)
        Dim FSPhoto As New FileStream(PhotoPath_, FileMode.Open, FileAccess.Read)
        Dim BRPhoto As New BinaryReader(FSPhoto)
        Dim FILEPhoto() As Byte = BRPhoto.ReadBytes(BRPhoto.BaseStream.Length)
        Dim PrmPhoto(0) As SqlParameter
        PrmPhoto(0) = New SqlParameter("@file", SqlDbType.VarBinary) With {.Value = FILEPhoto}
        Dim FSDocument As New FileStream(DocumentPath_, FileMode.Open, FileAccess.Read)
        Dim BRDocument As New BinaryReader(FSDocument)
        Dim FILEDocument() As Byte = BRDocument.ReadBytes(BRDocument.BaseStream.Length)
        Dim PrmDocument(0) As SqlParameter
        PrmDocument(0) = New SqlParameter("@file", SqlDbType.VarBinary) With {.Value = FILEDocument}
        Con.EXECUTECOMMAND("INSERT INTO [GoldStone]
                           ([CategoriesCode]
                           ,[StoneCode]
                           ,[Weight]
                           ,[WeightType]
                           ,[Color]
                           ,[Clarity]
                           ,[Cut]
                           ,[CountryOfOrigin]
                           ,[Price]
                           ,[Photo]
                           ,[Document]
                           ,[UserID])
        VALUES (" & CategoriesCode & "," & StoneCode & ",'" & Weight & "','" & WeightType & "','" & Color & "','" & Clarity & "','" & Cut & "','" & CountryOfOrigin & "','" & Price & "', @file)", PrmPhoto)

    End Sub
    'Public Sub AddItem(Code As Integer, AnotherCode As Integer, AnotherCode2 As Integer, BarCode As String, Name As String,
    '                    Karat As String, GoldWeight As Double, MakingCharge As Double, CostPerPiece As Double, CostPerGram As Double,
    '                    CostForSeller As Double, CountryOfOrigin As String, NumberOfPieces As Integer, Photo As String, Document As String,
    '                    Supplier As Integer, SupplierInvoiceNo As String, Symbol As String, Condition As Integer, ItemNo As Integer, UserCode As Integer,
    '                    DateAdd As Date, DateOfManufacture As Date, TaxExempt As Integer, Enabled As Boolean)
    '    Dim Con As New ClsConnectionString
    '    Dim Prm(1) As SqlParameter
    '    Prm(0) = New SqlParameter("@DateAdd", SqlDbType.Date) With {.Value = If(DateAdd = "#1/1/0001 12:00:00 AM#", Date.Now, DateAdd)}
    '    Prm(1) = New SqlParameter("@DateOfManufacture", SqlDbType.Date) With {.Value = If(DateOfManufacture = "#1/1/0001 12:00:00 AM#", DBNull.Value, DateOfManufacture)}

    '    Con.EXECUTECOMMAND("INSERT INTO GoldStock (Code,AnotherCode,AnotherCode2,BarCode,Name,
    '                        Karat,GoldWeight,MakingCharge,CostPerPiece,CostPerGram,
    '                        CostForSeller,CountryOfOrigin,NumberOfPieces,Photo,Document,
    '                        Supplier,SupplierInvoiceNo,Symbol,Condition,ItemNo,UserCode,
    '                        DateAdd,DateOfManufacture,TaxExempt,Enabled) 
    '                         Values 
    '                         (
    '                        '" & Code & "','" & AnotherCode & "','" & AnotherCode2 & "','" & BarCode & "','" & Name & "',
    '                        '" & Karat & "','" & GoldWeight & "','" & MakingCharge & "','" & CostPerPiece & "','" & CostPerGram & "',
    '                        '" & CostForSeller & "','" & CountryOfOrigin & "','" & NumberOfPieces & "','" & Photo & "','" & Document & "',
    '                        '" & Supplier & "','" & SupplierInvoiceNo & "','" & Symbol & "','" & Condition & "','" & ItemNo & "','" & UserCode & "',@DateAdd,@DateOfManufacture,'" & TaxExempt & "'" & Enabled & "')", Prm)

    'End Sub
    Public Sub AddItem(Code As Integer, AnotherCode As Integer, AnotherCode2 As Integer, BarCode As String, Name As String,
                       Karat As String, GoldWeight As Double, MakingCharge As Double, CostPerPiece As Double, CostPerGram As Double,
                       CostForSeller As Double, CostPerGramPurchase As Double, CountryOfOrigin As String, NumberOfPieces As Integer, Photo As Byte(), Document As Byte(),
                       Supplier As Integer, Symbol As String, Condition As Integer, ItemNo As Integer, UserCode As Integer,
                       DateAdd As Object, DateOfManufacture As Object, TaxExempt As Integer, SupplierInvoiceNo As String, Enabled As Boolean)
        Dim Con As New ClsConnectionString
        Dim Prm(3) As SqlParameter
        Prm(0) = New SqlParameter("@Photo", SqlDbType.VarBinary) With {.Value = If(IsNothing(Photo), DBNull.Value, Photo)}
        Prm(1) = New SqlParameter("@Document", SqlDbType.VarBinary) With {.Value = If(IsNothing(Document), DBNull.Value, Document)}
        Prm(2) = New SqlParameter("@DateAdd", SqlDbType.Date) With {.Value = If(IsNothing(DateAdd), DBNull.Value, Convert.ToDateTime(DateAdd))}
        Prm(3) = New SqlParameter("@DateOfManufacture", SqlDbType.Date) With {.Value = If(IsNothing(DateOfManufacture), DBNull.Value, Convert.ToDateTime(DateOfManufacture))}

        Con.EXECUTECOMMAND("INSERT INTO GoldStock (
                            Code,AnotherCode,AnotherCode2,BarCode,Name,
                            Karat,GoldWeight,MakingCharge,CostPerPiece,CostPerGram,
                            CostForSeller,CostPerGramPurchase,CountryOfOrigin,NumberOfPieces,Photo,Document,
                            Supplier,Symbol,Condition,ItemNo,UserCode,
                            DateAdd,DateOfManufacture,TaxExempt,SupplierInvoiceNo,Enabled) 
                             VALUES 
                             (
                            '" & Code & "','" & AnotherCode & "','" & AnotherCode2 & "','" & BarCode & "','" & Name & "',
                            '" & Karat & "','" & GoldWeight & "','" & MakingCharge & "','" & CostPerPiece & "','" & CostPerGram & "',
                            '" & CostForSeller & "','" & CostPerGramPurchase & "','" & CountryOfOrigin & "','" & NumberOfPieces & "',@Photo,@Document,
                            '" & Supplier & "','" & Symbol & "','" & Condition & "','" & ItemNo & "','" & UserCode & "',@DateAdd,@DateOfManufacture,'" & TaxExempt & "','" & SupplierInvoiceNo & "','" & Enabled & "')", Prm)
    End Sub
    'Public Sub EditItem(Code As Integer, AnotherCode As Integer, AnotherCode2 As Integer, BarCode As String, Name As String,
    '                    Karat As String, GoldWeight As Double, MakingCharge As Double, CostPerPiece As Double, CostPerGram As Double,
    '                    CostForSeller As Double, CountryOfOrigin As String, NumberOfPieces As Integer, Photo As String, Document As String,
    '                    Supplier As Integer, Symbol As String, Condition As Integer, ItemNo As Integer, UserCode As Integer,
    '                    DateAdd As Date, DateOfManufacture As Date, TaxExempt As Integer, SupplierInvoiceNo As String, Enabled As Boolean)
    '    Dim Con As New ClsConnectionString
    '    Dim Prm(1) As SqlParameter
    '    Prm(0) = New SqlParameter("@DateAdd", SqlDbType.Date) With {.Value = DateAdd}
    '    Prm(1) = New SqlParameter("@DateOfManufacture", SqlDbType.Date) With {.Value = DateOfManufacture}

    '    Con.EXECUTECOMMAND("UPDATE GoldStock SET 
    '                        Code = '" & Code & "',AnotherCode = '" & AnotherCode & "',AnotherCode2 = '" & AnotherCode2 & "',BarCode = '" & BarCode & "',Name = '" & Name & "',
    '                        Karat = '" & Karat & "',GoldWeight = '" & GoldWeight & "',MakingCharge = '" & MakingCharge & "',CostPerPiece = '" & CostPerPiece & "',CostPerGram = '" & CostPerGram & "',
    '                        CostForSeller = '" & CostForSeller & "',CountryOfOrigin = '" & CountryOfOrigin & "',NumberOfPieces = '" & NumberOfPieces & "',Photo = '" & Photo & "',Document = '" & Document & "',
    '                        Supplier = '" & Supplier & "',Symbol = '" & Symbol & "',Condition = '" & Condition & "',ItemNo = '" & ItemNo & "',UserCode = '" & UserCode & "',DateAdd=@DateAdd,DateOfManufacture=@DateOfManufacture,TaxExempt = '" & TaxExempt & "',SupplierInvoiceNo = '" & SupplierInvoiceNo & "',Enabled = '" & Enabled & "'  WHERE Code =  '" & Code & "'", Prm)

    'End Sub
    Public Sub EditItem(Code As Integer, AnotherCode As Integer, AnotherCode2 As Integer, BarCode As String, Name As String,
                        Karat As String, GoldWeight As Double, MakingCharge As Double, CostPerPiece As Double, CostPerGram As Double,
                        CostForSeller As Double, CostPerGramPurchase As Double, CountryOfOrigin As String, NumberOfPieces As Integer, Photo As Byte(), Document As Byte(),
                        Supplier As Integer, Symbol As String, Condition As Integer, ItemNo As Integer, UserCode As Integer,
                        DateAdd As Date, DateOfManufacture As Date, TaxExempt As Integer, SupplierInvoiceNo As String, Enabled As Boolean)
        Dim Con As New ClsConnectionString
        Dim Prm(3) As SqlParameter
        Prm(0) = New SqlParameter("@Photo", SqlDbType.VarBinary) With {.Value = If(IsNothing(Photo), DBNull.Value, Photo)}
        Prm(1) = New SqlParameter("@Document", SqlDbType.VarBinary) With {.Value = If(IsNothing(Document), DBNull.Value, Document)}
        Prm(2) = New SqlParameter("@DateAdd", SqlDbType.Date) With {.Value = DateAdd}
        Prm(3) = New SqlParameter("@DateOfManufacture", SqlDbType.Date) With {.Value = DateOfManufacture}

        Con.EXECUTECOMMAND("UPDATE GoldStock SET 
                            Code = '" & Code & "',AnotherCode = '" & AnotherCode & "',AnotherCode2 = '" & AnotherCode2 & "',BarCode = '" & BarCode & "',Name = '" & Name & "',
                            Karat = '" & Karat & "',GoldWeight = '" & GoldWeight & "',MakingCharge = '" & MakingCharge & "',CostPerPiece = '" & CostPerPiece & "',CostPerGram = '" & CostPerGram & "',
                            CostForSeller = '" & CostForSeller & "',CostPerGramPurchase = '" & CostPerGramPurchase & "',CountryOfOrigin = '" & CountryOfOrigin & "',NumberOfPieces = '" & NumberOfPieces & "',Photo=@Photo,Document=@Document,
                            Supplier = '" & Supplier & "',Symbol = '" & Symbol & "',Condition = '" & Condition & "',ItemNo = '" & ItemNo & "',UserCode = '" & UserCode & "',DateAdd=@DateAdd,
                            DateOfManufacture=@DateOfManufacture,TaxExempt = '" & TaxExempt & "',SupplierInvoiceNo = '" & SupplierInvoiceNo & "',Enabled = '" & Enabled & "' WHERE Code =  '" & Code & "'", Prm)

    End Sub
    Public Sub DeleteItem(Id As Integer)
        Dim Con As New ClsConnectionString
        Con.EXECUTE_TXT("UPDATE GoldStock SET Enabled = '0' WHERE  ID =N'" & Id & "'")
    End Sub

    Public Function MaxSupplier() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT ISNULL(Max(Code) + 1, 1) FROM Suppliers")
        Return DT
    End Function
    Public Function AllSupplier() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT Code AS [رقم المورد],
                            Name AS [اسم المورد],
                            PhoneNumber AS [رقم الهاتف],
                            Address AS [العنوان],
                            CompanyId AS [رقم الشركة]
                            FROM Suppliers ORDER BY Code")
        Return DT
    End Function
    Public Function AllItems() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS number,
                             ID ,
                             Code AS [Code],
                             AnotherCode AS [AnotherCode],
                             AnotherCode2 AS [AnotherCode2],
                             BarCode AS [BarCode],
                             Name AS [Name],
                             Karat AS [Karat],
                             GoldWeight AS [GoldWeight],
                             MakingCharge AS [MakingCharge],
                             CostPerPiece AS [CostPerPiece],
                             CostPerGram AS [CostPerGram],
                             CostForSeller AS [CostForSeller],
                             CostPerGramPurchase AS [CostPerGramPurchase],
                             CountryOfOrigin AS [CountryOfOrigin],
                             NumberOfPieces AS [NumberOfPieces],
                             [Photo] AS [Photo],
                             [Document] AS [Document],
                             Supplier AS [Supplier],
                             SupplierInvoiceNo AS [SupplierInvoiceNo],
                             Symbol AS [Symbol],
                             Condition AS [Condition],
                             ItemNo AS [ItemNo],
                             UserCode AS [UserCode],
                             DateAdd AS [DateAdd],
                             DateOfManufacture AS [DateOfManufacture],
                             TaxExempt AS [TaxExempt]
                             FROM GoldStock 
                             WHERE Enabled = '1' 
                             ORDER BY [Code]")
        Return DT
    End Function
    Public Sub FillItemName(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ItemName()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
                        .DataSource = DT
                        .NullText = "اختر صنفًا"
                        .PopulateColumns()
                        .Columns("Id").Visible = False
                        .Columns("Code").Visible =
                        .Columns("BarCodeString").Visible = False
                        .Columns("NameAr").Caption = "اسم الصنف"
                        .Columns("NameEn").Caption = "Item Name"
                        .DisplayMember = "NameAr"
                        .ValueMember = "Code"
                    End With
                End If
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
                        .DataSource = DT
                        .NullText = "اختر صنفًا"
                        .PopulateColumns()
                        .Columns("Id").Visible = False
                        .Columns("Code").Visible = False
                        .Columns("BarCodeString").Visible = False
                        .Columns("NameAr").Caption = "اسم الصنف"
                        .Columns("NameEn").Caption = "Item Name"
                        .DisplayMember = "NameAr"
                        .ValueMember = "Code"
                    End With
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillKarat(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = Karat()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
                        .DataSource = DT
                        .PopulateColumns()
                        .Columns("Id").Visible = False
                        .Columns("Code").Visible = False
                        .DisplayMember = "Name"
                        .ValueMember = "Code"
                    End With
                End If
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
                        .DataSource = DT
                        .PopulateColumns()
                        .Columns("Id").Visible = False
                        .Columns("Code").Visible = False
                        .DisplayMember = "Name"
                        .ValueMember = "Code"
                    End With
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillCountryOfOrigin(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ClsMain_.CountryOfOrigin
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
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
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillSupplier(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = Supplier()

            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillTaxExempt(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = TaxExempt()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillItemCondition(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ItemCondition()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillStoneType(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ClsGoldAddStone_.StoneType()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillStoneName(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ClsGoldAddStone_.StoneName()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillStoneCaratOrGram(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ClsGoldAddStone_.CaratOrGram()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillStoneColor(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ClsGoldAddStone_.StoneColor()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
                If TypeOf (LookUpEditName) Is LookUpEdit Then
                    With CType(LookUpEditName, LookUpEdit).Properties
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub FillStoneClarity(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ClsGoldAddStone_.StoneClarity()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
            End If
            If TypeOf (LookUpEditName) Is LookUpEdit Then
                With CType(LookUpEditName, LookUpEdit).Properties
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
    Public Sub FillStoneCut(LookUpEditName As Object)
        Try
            Dim DT As New DataTable
            DT = ClsGoldAddStone_.StoneCut()
            If DT.Rows.Count > 0 Then
                If TypeOf (LookUpEditName) Is RepositoryItemLookUpEdit Then
                    With CType(LookUpEditName, RepositoryItemLookUpEdit)
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
            End If
            If TypeOf (LookUpEditName) Is LookUpEdit Then
                With CType(LookUpEditName, LookUpEdit).Properties
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
    Public Sub DeleteGoldStone(CodeItem As String)
        Dim Con As New ClsConnectionString
        Con.EXECUTE_TXT("DELETE FROM GoldStone WHERE CodeItem = N'" & CodeItem & "'")
    End Sub
    Public Sub DeleteGoldStoneByID(ID As String)
        Dim Con As New ClsConnectionString
        Con.EXECUTE_TXT("UPDATE GoldStone SET Enabled = N'0' WHERE ID = N'" & ID & "'")
    End Sub
    Public Sub AddGoldStone(StoneNameCode As Integer, StoneTypeCode As Integer, StoneWeight As Integer, StoneWeightType As Integer, StoneColor As String,
                            StoneClarity As String, StoneCut As String, StoneCountryOfOrigin As String, StonePrice As Double, StonePhoto As Byte(),
                            StoneDocument As Byte(), UserCode As Integer, CodeItem As String, Enabled As Boolean)
        Dim Con As New ClsConnectionString
        Dim Prm(1) As SqlParameter
        Prm(0) = New SqlParameter("@StonePhoto", SqlDbType.VarBinary) With {.Value = If(IsNothing(StonePhoto), DBNull.Value, StonePhoto)}
        Prm(1) = New SqlParameter("@StoneDocument", SqlDbType.VarBinary) With {.Value = If(IsNothing(StoneDocument), DBNull.Value, StoneDocument)}

        Con.EXECUTECOMMAND("INSERT INTO GoldStone (                                                                                                                                                            
                            StoneNameCode,StoneTypeCode,StoneWeight,StoneWeightType,StoneColor,
                            StoneClarity,StoneCut,StoneCountryOfOrigin,StonePrice,StonePhoto,
                            StoneDocument,UserCode,CodeItem,Enabled) 
                             VALUES 
                             (
                            '" & StoneNameCode & "','" & StoneTypeCode & "','" & StoneWeight & "','" & StoneWeightType & "','" & StoneColor & "',
                            '" & StoneClarity & "','" & StoneCut & "','" & StoneCountryOfOrigin & "','" & StonePrice & "',@StonePhoto,
                            @StoneDocument,'" & UserCode & "','" & CodeItem & "','" & Enabled & "')", Prm)
    End Sub
    Public Function GetGoldStone(CodeItem As String) As DataTable
        Dim Con As New ClsConnectionString
        Dim dt As New DataTable
        dt.Clear()
        dt = Con.SELECT_TXT("SELECT ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS StoneSerial
                             ,[ID]
                             ,[StoneNameCode]
                             ,[StoneTypeCode]
                             ,[StoneWeight]
                             ,[StoneWeightType]
                             ,[StoneColor]
                             ,[StoneClarity]
                             ,[StoneCut]
                             ,[StoneCountryOfOrigin]
                             ,[StonePrice]
                             ,[StonePhoto]
                             ,[StoneDocument]
                             ,[UserCode]
                             ,[CodeItem]
                             FROM [GoldStone]
                             WHERE CodeItem = N'" & CodeItem & "' AND Enabled = N'1'")

        Return dt
    End Function
End Class
