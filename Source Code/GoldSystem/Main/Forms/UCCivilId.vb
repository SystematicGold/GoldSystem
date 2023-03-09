Imports System.IO
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Camera

Public Class UCCivilID
    Dim ClsMain_ As New ClsMain

    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        If ValidateTextBox() = True Then
            ClsMain_.SaveCustomer(txtCID.Text.Trim, txtPassportNo.Text.Trim, txtCustomerNameAr.Text.Trim,
                                  txtCustomerNameEn.Text.Trim, txtAddress.Text.Trim, cmbPhone.EditValue,
                                  txtNationality.Text.Trim,
                                  ImageToByte(pbCIDFront.Image),
                                  ImageToByte(pbCIDBack.Image),
                                  ImageToByte(pbMIDFront.Image),
                                  ImageToByte(pbMIDBack.Image),
                                  ImageToByte(pbPassportFront.Image),
                                  ImageToByte(pbPassportBack.Image),
                                  ImageToByte(pbDLicenseFront.Image),
                                  ImageToByte(pbDLicenseBack.Image),
                                  ImageToByte(pbDSignatureFront.Image),
                                  ImageToByte(pbDSignatureBack.Image))

        End If
    End Sub
    Private Function ValidateTextBox() As Boolean
        If txtCID.Text = "" Then
            EPX.SetError(txtCID, "أدخل رقم مدني صحيح")
            Return False
        Else
            EPX.SetError(txtCID, String.Empty)
            Return True
        End If
        If txtCustomerNameAr.Text = "" Then
            EPX.SetError(txtCustomerNameAr, "أدخل اسم مستخدم صحيح")
            Return False
        Else
            EPX.SetError(txtCustomerNameAr, String.Empty)
            Return True
        End If
    End Function
    Private Sub UCCivilID_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        With txtCustomerNameEn
            .Left = txtCID.Left
            .Width = (txtCID.Width / 2) - 1
        End With
        With txtCustomerNameAr
            .Width = (txtCID.Width / 2) - 1
            .Left = txtCustomerNameEn.Left + txtCustomerNameEn.Width + 1
        End With
    End Sub
#Region "Picture Load From File"
    Private Sub btnCIDFileFront_Click(sender As Object, e As EventArgs) Handles btnCIDFileFront.Click
        Try
            pbCIDFront.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnCIDFileBack_Click(sender As Object, e As EventArgs) Handles btnCIDFileBack.Click
        Try
            pbCIDBack.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnMIDFileFront_Click(sender As Object, e As EventArgs) Handles btnMIDFileFront.Click
        Try
            pbMIDFront.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnMIDFileBack_Click(sender As Object, e As EventArgs) Handles btnMIDFileBack.Click
        Try
            pbMIDBack.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnPassportFileFront_Click(sender As Object, e As EventArgs) Handles btnPassportFileFront.Click
        Try
            pbPassportFront.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnPassportFileBack_Click(sender As Object, e As EventArgs) Handles btnPassportFileBack.Click
        Try
            pbPassportBack.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnDLicenseFileFront_Click(sender As Object, e As EventArgs) Handles btnDLicenseFileFront.Click
        Try
            pbDLicenseFront.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnDLicenseFileBack_Click(sender As Object, e As EventArgs) Handles btnDLicenseFileBack.Click
        Try
            pbDLicenseBack.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub btnDSignatureFileFront_Click(sender As Object, e As EventArgs) Handles btnDSignatureFileFront.Click
        Try
            pbDSignatureFront.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnDSignatureFileBack_Click(sender As Object, e As EventArgs) Handles btnDSignatureFileBack.Click
        Try
            pbDSignatureBack.LoadImage()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
#End Region
#Region "Pictute From Camera"
    Private Sub btnCIDCameraFront_Click(sender As Object, e As EventArgs) Handles btnCIDCameraFront.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbCIDFront.Image = tpd.Image
        End If
    End Sub

    Private Sub btnCIDCameraBack_Click(sender As Object, e As EventArgs) Handles btnCIDCameraBack.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbCIDBack.Image = tpd.Image
        End If
    End Sub
    Private Sub btnMIDCameraFront_Click(sender As Object, e As EventArgs) Handles btnMIDCameraFront.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbMIDFront.Image = tpd.Image
        End If
    End Sub

    Private Sub btnMIDCameraBack_Click(sender As Object, e As EventArgs) Handles btnMIDCameraBack.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbMIDBack.Image = tpd.Image
        End If
    End Sub
    Private Sub btnPassportCameraFront_Click(sender As Object, e As EventArgs) Handles btnPassportCameraFront.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbPassportFront.Image = tpd.Image
        End If
    End Sub

    Private Sub btnPassportCameraBack_Click(sender As Object, e As EventArgs) Handles btnPassportCameraBack.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbPassportBack.Image = tpd.Image
        End If
    End Sub
    Private Sub btnDLicenseCameraFront_Click(sender As Object, e As EventArgs) Handles btnDLicenseCameraFront.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbDLicenseFront.Image = tpd.Image
        End If
    End Sub

    Private Sub btnDLicenseCameraBack_Click(sender As Object, e As EventArgs) Handles btnDLicenseCameraBack.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbDLicenseBack.Image = tpd.Image
        End If
    End Sub
    Private Sub btnDSignatureCameraFront_Click(sender As Object, e As EventArgs) Handles btnDSignatureCameraFront.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbDSignatureFront.Image = tpd.Image
        End If
    End Sub

    Private Sub btnDSignatureCameraBack_Click(sender As Object, e As EventArgs) Handles btnDSignatureCameraBack.Click
        Dim tpd As New TakePictureDialog()
        tpd.ManualResolution = ClsMain_.PhotoSize
        If tpd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pbDSignatureBack.Image = tpd.Image
        End If
    End Sub


#End Region
    Private Sub pbAddPhone_Click(sender As Object, e As EventArgs) Handles pbAddPhone.Click
        If txtCID.Text.Trim <> "" Then
            FrmAddPhone.CID = txtCID.Text.Trim
            FrmAddPhone.ShowDialog()
        End If
    End Sub

    Private Sub txtCID_EditValueChanged(sender As Object, e As EventArgs) Handles txtCID.EditValueChanged
        If txtCID.Text.Length = 12 Then
            Dim dt As New DataTable
            dt.Clear()
            dt = ClsMain_.GetCustomer(txtCID.Text.Trim)
            If dt.Rows.Count > 0 Then
                txtPassportNo.Text = dt.Rows(0)("PassportNo").ToString
                txtCustomerNameAr.Text = dt.Rows(0)("NameAr").ToString
                txtCustomerNameEn.Text = dt.Rows(0)("NameEn").ToString
                txtNationality.Text = dt.Rows(0)("Nationality").ToString
                txtAddress.Text = dt.Rows(0)("Address").ToString
                With cmbPhone.Properties
                    .DataSource = ClsMain_.GetPhones(txtCID.Text.Trim)
                    .PopulateColumns()
                    .Columns("CID").Visible = False
                    .Columns("Phone").Caption = "الهاتف"
                    .DisplayMember = "Phone"
                    .ValueMember = "Phone"
                End With
                cmbPhone.EditValue = dt.Rows(0)("Phone").ToString
                pbCIDFront.Image = If(IsDBNull(dt.Rows(0)("CIDFront")), Nothing, ByteToImage(dt.Rows(0)("CIDFront")))
                pbCIDBack.Image = If(IsDBNull(dt.Rows(0)("CIDBack")), Nothing, ByteToImage(dt.Rows(0)("CIDBack")))
                pbMIDFront.Image = If(IsDBNull(dt.Rows(0)("MIDFront")), Nothing, ByteToImage(dt.Rows(0)("MIDFront")))
                pbMIDBack.Image = If(IsDBNull(dt.Rows(0)("MIDBack")), Nothing, ByteToImage(dt.Rows(0)("MIDBack")))
                pbPassportFront.Image = If(IsDBNull(dt.Rows(0)("PassportFront")), Nothing, ByteToImage(dt.Rows(0)("PassportFront")))
                pbPassportBack.Image = If(IsDBNull(dt.Rows(0)("PassportBack")), Nothing, ByteToImage(dt.Rows(0)("PassportBack")))
                pbDLicenseFront.Image = If(IsDBNull(dt.Rows(0)("DLicenseFront")), Nothing, ByteToImage(dt.Rows(0)("DLicenseFront")))
                pbDLicenseBack.Image = If(IsDBNull(dt.Rows(0)("DLicenseBack")), Nothing, ByteToImage(dt.Rows(0)("DLicenseBack")))
                pbDSignatureFront.Image = If(IsDBNull(dt.Rows(0)("DSignatureFront")), Nothing, ByteToImage(dt.Rows(0)("DSignatureFront")))
                pbDSignatureBack.Image = If(IsDBNull(dt.Rows(0)("DSignatureBack")), Nothing, ByteToImage(dt.Rows(0)("DSignatureBack")))
            End If
        Else
            ClearControls(gbItemData)
        End If
    End Sub
End Class
