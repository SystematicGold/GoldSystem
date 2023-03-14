Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Drawing.Imaging
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab

Public Class ClsMain
    Dim Con As New ClsConnectionString
    Public PhotoSize As Size = New Size(400, 250)
    Public Function GetItemCode() As String
        Dim Con As New ClsConnectionString
        Dim dt As New DataTable
        dt.Clear()
        dt = Con.SELECT_TXT("SELECT ISNULL(MAX(Code)+1, 1) FROM [GoldStock]")
        Return dt(0)(0).ToString
    End Function


    Public Sub AddNewSupplier(Code As Integer, Name As String, PhoneNumber As String, Address As String,
                              CompanyId As String)
        Dim con As New ClsConnectionString
        con.EXECUTE_TXT("INSERT INTO [DeffSupplier]
           ([Code]
           ,[Name]
           ,[PhoneNumber]
           ,[Address]
           ,[CompanyId])
     VALUES
           (" & Code & ", '" & Name & "', '" & PhoneNumber & "', '" & Address & "', '" & CompanyId & "')")
    End Sub
    Sub UpdateSupplier(Code As Integer, Name As String, PhoneNumber As String, Address As String,
                       CompanyId As String)
        Dim con As New ClsConnectionString
        con.EXECUTE_TXT("UPDATE [DeffSupplier] SET  
                        Name = '" & Name & "',
                        PhoneNumber = '" & PhoneNumber & "',
                        Address = '" & Address & "',
                        CompanyId = '" & CompanyId & "',
                        WHERE Code = " & Code & "")
    End Sub
    Public Function CountryOfOrigin() As DataTable
        Dim DT As New DataTable
        DT.Clear()
        DT = Con.SELECT_TXT("SELECT [Id] , [Code] , [NameAr] , [NameEn] FROM [DeffCountryOfOrigin] WHERE [Enabled] = 1 ORDER BY [Code]")
        Return DT
    End Function
    Public Function GetCustomer(CID As String) As DataTable
        Dim Con As New ClsConnectionString
        Return Con.SELECT_TXT("SELECT PassPortNo, NameAr, NameEn, Address, Nationality, Phone, CIDFront, CIDBack, MIDFront, MIDBack, PassportFront, PassportBack, DLicenseFront, DLicenseBack, DSignatureFront, DSignatureBack FROM DeffCustomer WHERE [CID] = N'" & CID & "'")
    End Function
    Public Sub SaveCustomer(CID As String, PassPortNo As String, NameAr As String, NameEn As String, Address As String,
                            Phone As String, Nationality As String,
                            CIDFront As Byte(), CIDBack As Byte(),
                            MIDFront As Byte(), MIDBack As Byte(),
                            PassportFront As Byte(), PassportBack As Byte(),
                            DLicenseFront As Byte(), DLicenseBack As Byte(),
                            DSignatureFront As Byte(), DSignatureBack As Byte())
        Dim Prm(9) As SqlParameter
        Prm(0) = New SqlParameter("@CIDFront", SqlDbType.VarBinary) With {.Value = If(IsNothing(CIDFront), DBNull.Value, CIDFront)}
        Prm(1) = New SqlParameter("@CIDBack", SqlDbType.VarBinary) With {.Value = If(IsNothing(CIDBack), DBNull.Value, CIDBack)}
        Prm(2) = New SqlParameter("@MIDFront", SqlDbType.VarBinary) With {.Value = If(IsNothing(MIDFront), DBNull.Value, MIDFront)}
        Prm(3) = New SqlParameter("@MIDBack", SqlDbType.VarBinary) With {.Value = If(IsNothing(MIDBack), DBNull.Value, MIDBack)}
        Prm(4) = New SqlParameter("@PassportFront", SqlDbType.VarBinary) With {.Value = If(IsNothing(PassportFront), DBNull.Value, PassportFront)}
        Prm(5) = New SqlParameter("@PassportBack", SqlDbType.VarBinary) With {.Value = If(IsNothing(PassportBack), DBNull.Value, PassportBack)}
        Prm(6) = New SqlParameter("@DLicenseFront", SqlDbType.VarBinary) With {.Value = If(IsNothing(DLicenseFront), DBNull.Value, DLicenseFront)}
        Prm(7) = New SqlParameter("@DLicenseBack", SqlDbType.VarBinary) With {.Value = If(IsNothing(DLicenseBack), DBNull.Value, DLicenseBack)}
        Prm(8) = New SqlParameter("@DSignatureFront", SqlDbType.VarBinary) With {.Value = If(IsNothing(DSignatureFront), DBNull.Value, DSignatureFront)}
        Prm(9) = New SqlParameter("@DSignatureBack", SqlDbType.VarBinary) With {.Value = If(IsNothing(DSignatureBack), DBNull.Value, DSignatureBack)}
        Dim Con As New ClsConnectionString
        Dim dt As DataTable = Con.SELECT_TXT("SELECT CID FROM DeffCustomer WHERE [CID] = N'" & CID & "'")
        If dt.Rows.Count > 0 Then
            'Update
            Con.EXECUTECOMMAND("UPDATE DeffCustomer SET 
                                CID = '" & CID & "',PassPortNo = '" & PassPortNo & "',NameAr = '" & NameAr & "',NameEn = '" & NameEn & "',Address = '" & Address & "',
                                Nationality = '" & Nationality & "',Phone = '" & Phone &
                                "',CIDFront=@CIDFront,
                                CIDBack=@CIDBack,
                                MIDFront=@MIDFront,MIDBack=@MIDBack,
                                PassportFront=@PassportFront,PassportBack=@PassportBack
                                ,DLicenseFront=@DLicenseFront,DLicenseBack=@DLicenseBack
                                ,DSignatureFront=@DSignatureFront,DSignatureBack=@DSignatureBack
                                WHERE  CID =N'" & CID & "'", Prm)
        Else
            'Insert
            Con.EXECUTECOMMAND("INSERT INTO DeffCustomer (
                                CID,PassPortNo,NameAr,NameEn,Address,
                                Nationality,Phone,
                                CIDFront,CIDBack,
                                MIDFront,MIDBack,
                                PassportFront,PassportBack,
                                DLicenseFront,DLicenseBack,
                                DSignatureFront,DSignatureBack) 
                                VALUES 
                                (
                                '" & CID & "','" & PassPortNo & "','" & NameAr & "','" & NameEn & "','" & Address & "',
                                '" & Nationality & "','" & Phone &
                                "',@CIDFront,@CIDBack,
                                @MIDFront,@MIDBack,
                                @PassportFront,@PassportBack,
                                @DLicenseFront,@DLicenseBack,
                                @DSignatureFront,@DSignatureBack)", Prm)
        End If

    End Sub
    Public Function SaveImage(CID As String, Img As Image) As String
        If Img Is Nothing Then Return ""
        If IO.File.Exists("Img\" & CID) = True Then IO.File.Delete("Img\" & CID)
        Dim ResizedImage As New Bitmap(Img, PhotoSize)
        ResizedImage.Save("Img\" & CID, ImageFormat.Jpeg)
        Return CID
    End Function
    Public Sub SavePhone(CID As String, Phone As String)
        Dim Con As New ClsConnectionString
        Con.EXECUTE_TXT("INSERT INTO DeffCustomerPhone (
                         CID, Phone) 
                         Values 
                         ('" & CID & "','" & Phone & "')")
    End Sub
    Public Function GetPhones(CID As String) As DataTable
        Dim Con As New ClsConnectionString
        Return Con.SELECT_TXT("SELECT [CID], [Phone] FROM [DeffCustomerPhone] WHERE [CID] = N'" & CID & "'")
    End Function
    Public Sub DelPhone(CID As String, PhoneNo As String)
        Dim Con As New ClsConnectionString
        Con.EXECUTE_TXT("DELETE FROM [DeffCustomerPhone] WHERE [CID] = N'" & CID & "' AND [Phone] = N'" & PhoneNo & "'")
    End Sub
    Public Sub DelPhonesAll(CID As String)
        Dim Con As New ClsConnectionString
        Con.EXECUTE_TXT("DELETE FROM [DeffCustomerPhone] WHERE [CID] = N'" & CID & "'")
    End Sub

    Public Function SearchPhone(CID As String, PhoneNo As String) As Boolean
        Dim Con As New ClsConnectionString
        Dim dt As DataTable = Con.SELECT_TXT("SELECT [CID], [Phone] FROM [DeffCustomerPhone] WHERE [CID] = N'" & CID & "' AND [Phone] = N'" & PhoneNo & "'")
        If dt.Rows.Count > 1 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
