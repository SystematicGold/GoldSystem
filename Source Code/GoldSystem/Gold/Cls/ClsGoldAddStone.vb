Public Class ClsGoldAddStone

    Dim Con As New ClsConnectionString

    Public Function StoneType() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn] FROM [DeffStoneType] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Function StoneName() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn] , [StoneTypeCode] FROM [DeffStoneName] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Function CaratOrGram() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn]  FROM [DeffCaratOrGm] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Function StoneColor() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn] , [IsDiamondColor] FROM [DeffStoneColor] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Function StoneClarity() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [Name] FROM [DeffStoneClarity] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Function StoneCut() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [Name] FROM [DeffStoneCut] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function

End Class
