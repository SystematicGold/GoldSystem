Imports System.Data.SqlClient
Imports System.IO
Public Class ClsGoldItem
    Public Function StoneName()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM [DeffStoneName] ORDER BY Code")
        Return DT
    End Function
    Public Function Karat()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM [DeffKarat] ORDER BY Code")
        Return DT
    End Function
    Public Function ItemName()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM [GoldDeffItemName] ORDER BY Code")
        Return DT
    End Function
    Public Function Supplier()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM [DeffSupplier] ORDER BY Code")
        Return DT
    End Function
    Public Function MadeIn()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM [DeffCountryOfOrigin] ORDER BY Code")
        Return DT
    End Function
    Public Sub AddStonForItem(CategoriesCode As Integer, StoneCode As Integer, Weight As Decimal, WeightType As Integer,
                              Color As String, Clarity As String, Cut As String, CountryOfOrigin As String, Price As Double,
                              PhotoPath_ As String, DocumentPath_ As String)
        Dim Con As New ClsConnectionString
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
    Public Sub AddItem(Code As Integer, AnotherCode As Integer, AnotherCode2 As Integer, BarCode As String, Name As String,
                       Kart As Integer, Weight As Double, MakingCharge As Double, Cost As Double,
                       CostPerGram As Double, MadeIn As Integer, Supplier As Integer, Path_ As String,
                       NumberOfPieces As Integer, NumberPiece As Integer, Ramz As String)
        Dim Con As New ClsConnectionString
        Dim FS As New FileStream(Path_, FileMode.Open, FileAccess.Read)
        Dim BR As New BinaryReader(FS)
        Dim FILE() As Byte = BR.ReadBytes(BR.BaseStream.Length)
        Dim Prm(1) As SqlParameter
        Prm(0) = New SqlParameter("@file", SqlDbType.VarBinary) With {.Value = FILE}
        Prm(1) = New SqlParameter("@Dtp", SqlDbType.VarBinary) With {.Value = Today.Date}
        Con.EXECUTECOMMAND("INSERT INTO [dbo].[Category]
           ([Code]
           ,[AnotherCode]
           ,[AnotherCode2]
           ,[BarCode]
           ,[Name]
           ,[Kart]
           ,[Weight]
           ,[MakingCharge]
           ,[Cost]
           ,[CostPerGram]
           ,[MadeIn]
           ,[Supplier]
           ,[PhotoOrFile]
           ,[NumberOfPieces]
           ,[NumberPiece]
           ,[Ramz]
           ,[UserCode]
           ,[DateAdd])
     VALUES
           (" & Code & "," & AnotherCode & "," & AnotherCode2 & ",'" & BarCode & "','" & Name & "',
            " & Kart & "," & Weight & "," & MakingCharge & "," & Cost & "," & CostPerGram & "," & MadeIn & ",
            '" & Supplier & "',@file," & NumberOfPieces & "," & NumberPiece & ",'" & Ramz & "', " & My.Settings.Usercode & ",
            @Dtp)", Prm)
    End Sub
    Public Function MaxSupplier()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT ISNULL(Max(Code) + 1, 1) FROM Suppliers")
        Return DT
    End Function
    Public Function AllSupplier()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT Code as [رقم المورد],
                            Name as [اسم المورد],
                            PhoneNumber as [رقم الهاتف],
                            Address as [العنوان],
                            CompanyId as [رقم الشركة]
                            FROM Suppliers ORDER BY Code")
        Return DT
    End Function
    Public Function ShowAllItems()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM Category ORDER BY Code")
        Return DT
    End Function
End Class
