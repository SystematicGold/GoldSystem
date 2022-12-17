Imports System.Data.SqlClient
Imports System.IO
Public Class ClsGoldItem
    Public Function Stone()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM StoneCategory order by Code")
        Return DT
    End Function
    Public Function Kart()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM KartItems order by Code")
        Return DT
    End Function
    Public Function ItemName()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM ItemNames order by Code")
        Return DT
    End Function
    Public Function Supplier()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM Suppliers order by Code")
        Return DT
    End Function
    Public Function MadeIn()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT * FROM MadeCountrys order by Code")
        Return DT
    End Function
    Public Sub AddStonForItem(CategoriesCode As Integer, StoneCode As Integer, Colour As String,
                       Price As Double, Weight As Double, Path_ As String)
        Dim Con As New ClsConnectionString
        Dim FS As New FileStream(Path_, FileMode.Open, FileAccess.Read)
        Dim BR As New BinaryReader(FS)
        Dim FILE() As Byte = BR.ReadBytes(BR.BaseStream.Length)
        Dim Prm(0) As SqlParameter
        Prm(0) = New SqlParameter("@file", SqlDbType.VarBinary) With {.Value = FILE}
        Con.EXECUTECOMMAND("INSERT INTO [dbo].[StoneItemCategory]
           ([CategoriesCode]
           ,[StoneCode]
           ,[Colour]
           ,[Price]
           ,[Weight]
           ,[PhotoOrFile])
     VALUES
           (" & CategoriesCode & ", " & StoneCode & ", '" & Colour & "',
            " & Price & ", " & Weight & ", @file)", Prm)
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
                            FROM Suppliers order by Code")
        Return DT
    End Function
    Public Function ShowAllItems()
        Dim Con As New ClsConnectionString
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("select * from Category order by Code")
        Return DT
    End Function
End Class
