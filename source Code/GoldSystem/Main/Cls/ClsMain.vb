Public Class ClsMain
    Public Function GetItemCode()
        Dim Con As New ClsConnectionString
        Dim dt As New DataTable
        dt.Clear()
        dt = Con.SELECT_TXT("select ISNULL(max(Code)+1, 1) from Category")
        Return dt
    End Function
    Public Sub AddNewSupplier(Code As Integer, Name As String, PhoneNumber As String, Address As String,
                              CompanyId As String)
        Dim con As New ClsConnectionString
        con.EXECUTE_TXT("INSERT INTO [dbo].[Suppliers]
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
        con.EXECUTE_TXT("Update Suppliers set  
                        Name = '" & Name & "',
                        PhoneNumber = '" & PhoneNumber & "',
                        Address = '" & Address & "',
                        CompanyId = '" & CompanyId & "',
                        WHERE Code = " & Code & "")
    End Sub
End Class
