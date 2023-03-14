Imports System.Drawing.Imaging
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab

Module ModGold
    Public dtStone As New DataTable
    Public Function IsValidImage(filename As String) As Boolean
        Try
            If filename.Trim = "" Then Return False
            Dim fs As New IO.FileStream(filename, IO.FileMode.Open, IO.FileAccess.Read)
            Dim img As Image = Image.FromStream(fs)
            fs.Close()
        Catch generatedExceptionName As OutOfMemoryException
            Return False
        End Try
        Return True
    End Function
    Public Function SaveImageAsFile(Img As Image) As String
        Dim NewWidth As Single, NewHeight As Single, Ratio As Single
        Dim WidthOriginalImage As Single = Img.Width
        Dim ImageName As String = Format(Date.Now, "yyyyMMddHHmmssffff")
        If WidthOriginalImage > 480 Then
            Ratio = WidthOriginalImage / 480
            NewWidth = 480
            NewHeight = Img.Height / Ratio
        Else
            NewWidth = Img.Width
            NewHeight = Img.Height
        End If
        Dim photoSize As New Size(NewWidth, NewHeight)
        Dim ResizedImage As New Bitmap(Img, photoSize)
        ResizedImage.Save("Img\" & ImageName, ImageFormat.Jpeg)
        Return ImageName
    End Function
    Public Function SaveImageAsByte(Img As Image) As Byte()
        Dim NewWidth As Single, NewHeight As Single, Ratio As Single
        Dim WidthOriginalImage As Single = Img.Width
        If WidthOriginalImage > 480 Then
            Ratio = WidthOriginalImage / 480
            NewWidth = 480
            NewHeight = Img.Height / Ratio
        Else
            NewWidth = Img.Width
            NewHeight = Img.Height
        End If
        Dim photoSize As New Size(NewWidth, NewHeight)
        Dim ResizedImage As New Bitmap(Img, photoSize)
        Dim ms As New IO.MemoryStream
        ResizedImage.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Public Function ImageToByte(Img As Image) As Byte()
        If IsNothing(Img) Then Return Nothing
        Dim ImgFunc As New Bitmap(Img)
        Dim ms As New MemoryStream
        If ImageFormat.Jpeg.Equals(Img.RawFormat) Then
            ImgFunc.Save(ms, ImageFormat.Jpeg)
        ElseIf ImageFormat.Png.Equals(Img.RawFormat) Then
            ImgFunc.Save(ms, ImageFormat.Png)
        ElseIf ImageFormat.Bmp.Equals(Img.RawFormat) Then
            ImgFunc.Save(ms, ImageFormat.Bmp)
        End If
        Return ms.ToArray()
    End Function
    Public Function ByteToImage(byt As Byte()) As Image
        If IsNothing(byt) Then Return Nothing
        Dim ms As New MemoryStream(byt)
        Dim Img As Image = Image.FromStream(ms)
        Return Img
    End Function
    Public Sub ClearControls(cntr As Control)
        For Each c As Control In cntr.Controls
            If TypeOf (c) Is ButtonEdit Then CType(c, ButtonEdit).EditValue = ""
            If TypeOf (c) Is LookUpEdit Then CType(c, LookUpEdit).Properties.DataSource = Nothing
            If TypeOf (c) Is XtraTabControl Then
                For Each cc As Control In c.Controls
                    If TypeOf (cc) Is XtraTabPage Then
                        For Each ccc As Control In cc.Controls
                            If TypeOf (ccc) Is PictureEdit Then CType(ccc, PictureEdit).Image = Nothing
                        Next
                    End If
                Next
            End If
        Next
    End Sub
    Public Function ArabicNo(Num As String) As String
        Dim romanNumber = From c In Num Select Char.GetNumericValue(c)
        Return Decimal.Parse(String.Concat(romanNumber))
    End Function
End Module
