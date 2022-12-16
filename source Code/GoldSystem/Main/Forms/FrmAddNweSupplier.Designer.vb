<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddNweSupplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddNweSupplier))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.DGV = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PictureEdit6 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit7 = New DevExpress.XtraEditors.PictureEdit()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button9 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCompany = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(644, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم المورد"
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtCode.Location = New System.Drawing.Point(422, 21)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.ReadOnly = True
        Me.TxtCode.Size = New System.Drawing.Size(216, 27)
        Me.TxtCode.TabIndex = 1
        Me.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(332, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "اسم المورد"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtName.Location = New System.Drawing.Point(12, 21)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(316, 27)
        Me.TxtName.TabIndex = 1
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGV
        '
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV.Location = New System.Drawing.Point(0, 194)
        Me.DGV.MainView = Me.GridView1
        Me.DGV.Name = "DGV"
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.Size = New System.Drawing.Size(735, 260)
        Me.DGV.TabIndex = 2
        Me.DGV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGV
        Me.GridView1.Name = "GridView1"
        '
        'PictureEdit6
        '
        Me.PictureEdit6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit6.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit6.EditValue = CType(resources.GetObject("PictureEdit6.EditValue"), Object)
        Me.PictureEdit6.Location = New System.Drawing.Point(367, 141)
        Me.PictureEdit6.Name = "PictureEdit6"
        Me.PictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PictureEdit6.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.PictureEdit6.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.PictureEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.PictureEdit6.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit6.Properties.Appearance.Options.UseBorderColor = True
        Me.PictureEdit6.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit6.Size = New System.Drawing.Size(49, 37)
        Me.PictureEdit6.TabIndex = 22
        '
        'PictureEdit7
        '
        Me.PictureEdit7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit7.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit7.EditValue = CType(resources.GetObject("PictureEdit7.EditValue"), Object)
        Me.PictureEdit7.Location = New System.Drawing.Point(547, 141)
        Me.PictureEdit7.Name = "PictureEdit7"
        Me.PictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PictureEdit7.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.PictureEdit7.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.PictureEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.PictureEdit7.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit7.Properties.Appearance.Options.UseBorderColor = True
        Me.PictureEdit7.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit7.Size = New System.Drawing.Size(49, 37)
        Me.PictureEdit7.TabIndex = 21
        '
        'Guna2Button8
        '
        Me.Guna2Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button8.BorderRadius = 10
        Me.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button8.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2Button8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button8.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.Location = New System.Drawing.Point(367, 131)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.Size = New System.Drawing.Size(174, 57)
        Me.Guna2Button8.TabIndex = 19
        Me.Guna2Button8.Text = "Edit - تعديل"
        Me.Guna2Button8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Guna2Button9
        '
        Me.Guna2Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button9.BorderRadius = 10
        Me.Guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button9.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2Button9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button9.ForeColor = System.Drawing.Color.White
        Me.Guna2Button9.Location = New System.Drawing.Point(547, 131)
        Me.Guna2Button9.Name = "Guna2Button9"
        Me.Guna2Button9.Size = New System.Drawing.Size(174, 57)
        Me.Guna2Button9.TabIndex = 20
        Me.Guna2Button9.Text = "Save - حفظ"
        Me.Guna2Button9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(644, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "رقم الهاتف"
        '
        'TxtPhoneNumber
        '
        Me.TxtPhoneNumber.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtPhoneNumber.Location = New System.Drawing.Point(422, 54)
        Me.TxtPhoneNumber.Name = "TxtPhoneNumber"
        Me.TxtPhoneNumber.Size = New System.Drawing.Size(216, 27)
        Me.TxtPhoneNumber.TabIndex = 1
        Me.TxtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(336, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "العنوان"
        '
        'TxtAddress
        '
        Me.TxtAddress.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtAddress.Location = New System.Drawing.Point(12, 54)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(318, 27)
        Me.TxtAddress.TabIndex = 1
        Me.TxtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(644, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "رقم الشركة"
        '
        'TxtCompany
        '
        Me.TxtCompany.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtCompany.Location = New System.Drawing.Point(422, 87)
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(216, 27)
        Me.TxtCompany.TabIndex = 1
        Me.TxtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmAddNweSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 454)
        Me.Controls.Add(Me.PictureEdit6)
        Me.Controls.Add(Me.PictureEdit7)
        Me.Controls.Add(Me.Guna2Button8)
        Me.Controls.Add(Me.Guna2Button9)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.TxtCompany)
        Me.Controls.Add(Me.TxtPhoneNumber)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(751, 493)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(751, 493)
        Me.Name = "FrmAddNweSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAddNweSupplier"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents DGV As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureEdit6 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit7 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button9 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPhoneNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCompany As TextBox
End Class
