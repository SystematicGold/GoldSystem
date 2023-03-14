Imports System.Buffers
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DevExpress.Data.Svg
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Camera
Imports PACICardLibrary

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

    Private Sub pbAll_DoubleClick(sender As Object, e As EventArgs) Handles pbCIDFront.DoubleClick, pbCIDBack.DoubleClick, pbMIDFront.DoubleClick, pbMIDBack.DoubleClick, pbPassportFront.DoubleClick, pbPassportBack.DoubleClick, pbDLicenseFront.DoubleClick, pbDLicenseBack.DoubleClick, pbDSignatureFront.DoubleClick, pbDSignatureBack.DoubleClick
        Try
            If IsNothing(CType(sender, PictureEdit).Image) = False Then
                FrmPhoto.pbPhoto.Image = CType(sender, PictureEdit).Image
                FrmPhoto.ShowDialog()
            Else
                MsgBox("لا توجد صورة!" & vbCrLf & "No Photo!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "PACI"
    Dim PACMAN_ As PACMAN
    Private Sub UCCivilID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PACMAN_ = New PACMAN()
        AddHandler PACMAN_.CardConnectionEvent, New PACMAN.CardConnectionHandler(AddressOf Paci_ConnectionEvent)
        AddHandler PACMAN_.ReadersEvent, New PACMAN.ReadersStateChanged(AddressOf Paci_ReadersEvent)
        AddHandler PACMAN_.CardDisconnectionEvent, New PACMAN.CardDisconnectionHandler(AddressOf Paci_DisconnectionEvent)
        Try
            Dim readers = PACMAN_.GetReaders(True)

            If readers IsNot Nothing Then
                For i = 0 To readers.Length - 1
                    'comboBox1.Items.Add(readers(i))
                Next

                'comboBox1.SelectedIndex = 0
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub Paci_ReadersEvent()
        'Reader inserted or removed
        BeginInvoke(CType(Sub() listReaders(), MethodInvoker))
    End Sub
    Private Sub Paci_DisconnectionEvent(ByVal ReaderIndex As Integer)
        'Card in reader index: " & ReaderIndex & " is disconnected
        BeginInvoke(CType(Sub() ClearFields(), MethodInvoker))
    End Sub
    Private Sub Paci_ConnectionEvent(ByVal ReaderIndex As Integer)
        'Card in reader index: " & ReaderIndex & " is connected
    End Sub
    Public Sub MyCardRemovalHandler(ByVal ReaderIndex As Integer)
        'Console.WriteLine("A card was removed from reader with index: " & ReaderIndex & " at time:" & Date.Now.ToString("h:mm:ss tt"))
    End Sub
    Private Sub listReaders()
        Try
            'comboBox1.Items.Clear()
            'comboBox1.Text = ""
            Dim readers = PACMAN_.GetReaders(True)
            If readers IsNot Nothing AndAlso readers.Length <> 0 Then
                For i = 0 To readers.Length - 1
                    'comboBox1.Items.Add(readers(i))
                Next

                'comboBox1.SelectedIndex = 0
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub ClearFields()
        Try
            'textBox1.Text = ""
            'textBox2.Text = ""
            'textBox3.Text = ""
            'textBox4.Text = ""
            'textBox5.Text = ""
            'textBox6.Text = ""
            'textBox7.Text = ""
            'textBox8.Text = ""
            'textBox9.Text = ""
            'textBox10.Text = ""
            'textBox11.Text = ""
            'textBox12.Text = ""
            'textBox13.Text = ""
            'textBox14.Text = ""
            'textBox15.Text = ""
            'textBox16.Text = ""
            'textBox17.Text = ""
            'textBox18.Text = ""
            'textBox19.Text = ""
            'textBox20.Text = ""
            'textBox21.Text = ""
            'textBox22.Text = ""
            'textBox23.Text = ""
            'textBox24.Text = ""
            'textBox26.Text = ""
            'textBox25.Text = ""
            'textBox27.Text = ""
            'textBox28.Text = ""
            'textBox29.Text = ""
            'textBox30.Text = ""
            'pictureBox1.Visible = False
            'label29.Visible = False
            'label33.Visible = False
            'label34.Visible = False
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub ReadCivilID()
        Try
            'If comboBox1.Items.Count = 0 Then
            '    MessageBox.Show("No connected Reader")
            '    Return
            'End If
            ClearFields()
            'Dim index = comboBox1.SelectedIndex

            txtCID.Text = PACMAN_.Civil_ID(0)
            txtCustomerNameAr.Text = PACMAN_.Arabic_Name_Full(0)
            txtCustomerNameEn.Text = PACMAN_.English_Name_Full(0)
            txtNationality.Text = PACMAN_.Nationality_Arabic(0)
            cmbPhone.Text = PACMAN_.Telephone_1(0)
            txtPassportNo.Text = PACMAN_.Passport(0)
            txtAddress.Text = PACMAN_.District(0) & Space(1) & "ق" & Space(1) & PACMAN_.Block_Number(0) & Space(1) & PACMAN_.Street_Name(0)
            'Dim p As New Image = PACMAN_.Photo(0)
            'txtSexAr.Text = PACMAN_.Sex_Arabic(0)
            'txtSexEn.Text = PACMAN_.Sex_English(0)
            'txtNationalityEn.Text = PACMAN_.Nationality_English(0)
            'txtBirthDate.Text = PACMAN_.Birthdate(0)
            'txtCarIssueDate.Text = PACMAN_.Card_Issue_Date(0)
            'txtCardExpiryDate.Text = PACMAN_.Card_Expiry_Date(0)
            'txtDocumentNo.Text = PACMAN_.Document_Number(0)
            'txtCarSerialNo.Text = PACMAN_.Card_Serial_Number(0)
            'txtMOIReference.Text = PACMAN_.MOI_Reference(0)
            'txtDistrict.Text = PACMAN_.District(0)
            'txtBlockNo.Text = PACMAN_.Block_Number(0)
            'txtStreetName.Text = PACMAN_.Street_Name(0)
            'txtBuildingPlotNo.Text = PACMAN_.Building_Plot_Number(0)
            'txtUnitType.Text = PACMAN_.Unit_Type(0)
            'txtUnitNo.Text = PACMAN_.Unit_Number(0)
            'txtFloorNo.Text = PACMAN_.Floor_Number(0)
            'txtBloodType.Text = PACMAN_.Blood_Type(0)
            'txtGuardianCID.Text = PACMAN_.Guardian_Civil_ID(0)
            'txtEmail.Text = PACMAN_.E_Mail_Address(0)
            'txtAdditionalF1.Text = PACMAN_.Additional_F_1(0)
            'txtAdditionalF2.Text = PACMAN_.Additional_F_2(0)
            'txtGetATR.Text = PACMAN_.GetATR(0)
            'txtApplicationVer.Text = PACMAN_.Application_Version(0)
            'txtMOIRef.Text = PACMAN_.MOI_Reference_Indic(0)
            'label29.Visible = True
            Dim properties = PACMAN_.GetCardProperties(0)
            'Dim cardCertValidity = False
            'Try
            '    cardCertValidity = PACMAN_.ValidateCardCertificateWithOCSP(0)
            'Catch __unusedException1__ As Exception
            '    There Is something wrong with OCSP server so we try last resort CRL validation
            '    cardCertValidity = PACMAN_.ValidateCardCertificateWithCRL(0, False)
            'End Try
            'If cardCertValidity Then
            '    label33.Text = "Card is valid"
            '    label33.ForeColor = Color.DarkGreen
            '    label33.Visible = True
            'Else
            '    label33.Text = "Card is not valid"
            '    label33.ForeColor = Color.DarkRed
            '    label33.Visible = True
            'End If
            'If properties.IsDigitalSignatureAvailable Then
            '    If properties.IsCardLocked Then
            '        label34.Text = "Digital signature is locked"
            '        label34.ForeColor = Color.DarkRed
            '        label34.Visible = True
            '    Else
            '        Dim digitalCertValidity = False
            '        Try
            '            digitalCertValidity = PACMAN_.ValidateDigitalSignatureCertificateWithOCSP(0)
            '        Catch __unusedException1__ As Exception
            '            There Is something wrong with OCSP server so we try last resort CRL validation
            '            digitalCertValidity = PACMAN_.ValidateDigitalSignatureCertificateWithCRL(0, False)
            '        End Try
            '        If digitalCertValidity Then
            '            label34.Text = "Digital certificate is valid"
            '            label34.ForeColor = Color.DarkGreen
            '            label34.Visible = True
            '        Else
            '            label34.Text = "Digital certificate is not valid"
            '            label34.ForeColor = Color.DarkRed
            '            label34.Visible = True
            '        End If
            '    End If
            'Else
            '    label34.Text = "No digital signature is available"
            '    label34.ForeColor = Color.DarkRed
            '    label34.Visible = True
            'End If
        Catch e1 As Exception
            MessageBox.Show(e1.Message)
        Finally
            'button1.Enabled = True
        End Try
    End Sub

    Private Sub pbPACI_Click(sender As Object, e As EventArgs) Handles pbPACI.Click
        ReadCivilID()
    End Sub
#End Region

End Class
