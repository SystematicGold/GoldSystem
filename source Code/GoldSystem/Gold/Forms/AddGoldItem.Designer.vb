<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddGoldItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddGoldItem))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbItemData = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cmbItemStatus = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbTaxExempt = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtDateOfManufacture = New System.Windows.Forms.DateTimePicker()
        Me.txtCostForSeller = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDocumentPath = New DevExpress.XtraEditors.TextEdit()
        Me.txtGoldWeight = New System.Windows.Forms.TextBox()
        Me.txtImagePath = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCostPerGram = New System.Windows.Forms.TextBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.txtCostPerPiece = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMakingCharge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoOfPieces = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.cmbKarat = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbCountryOfOrigin = New System.Windows.Forms.ComboBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbSymbol = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.gbStoneData = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DgvStone = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.gbItemData.SuspendLayout()
        CType(Me.txtDocumentPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImagePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStoneData.SuspendLayout()
        CType(Me.DgvStone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbItemData
        '
        Me.gbItemData.BorderColor = System.Drawing.Color.RoyalBlue
        Me.gbItemData.BorderRadius = 5
        Me.gbItemData.BorderThickness = 2
        Me.gbItemData.Controls.Add(Me.cmbItemStatus)
        Me.gbItemData.Controls.Add(Me.Label22)
        Me.gbItemData.Controls.Add(Me.cmbTaxExempt)
        Me.gbItemData.Controls.Add(Me.Label21)
        Me.gbItemData.Controls.Add(Me.dtDateOfManufacture)
        Me.gbItemData.Controls.Add(Me.txtCostForSeller)
        Me.gbItemData.Controls.Add(Me.Label19)
        Me.gbItemData.Controls.Add(Me.Label3)
        Me.gbItemData.Controls.Add(Me.txtDocumentPath)
        Me.gbItemData.Controls.Add(Me.txtGoldWeight)
        Me.gbItemData.Controls.Add(Me.txtImagePath)
        Me.gbItemData.Controls.Add(Me.Label5)
        Me.gbItemData.Controls.Add(Me.Label4)
        Me.gbItemData.Controls.Add(Me.Label20)
        Me.gbItemData.Controls.Add(Me.Label2)
        Me.gbItemData.Controls.Add(Me.txtCostPerGram)
        Me.gbItemData.Controls.Add(Me.txtBarCode)
        Me.gbItemData.Controls.Add(Me.txtCostPerPiece)
        Me.gbItemData.Controls.Add(Me.Label10)
        Me.gbItemData.Controls.Add(Me.Label6)
        Me.gbItemData.Controls.Add(Me.Label8)
        Me.gbItemData.Controls.Add(Me.txtMakingCharge)
        Me.gbItemData.Controls.Add(Me.Label1)
        Me.gbItemData.Controls.Add(Me.Label7)
        Me.gbItemData.Controls.Add(Me.txtNoOfPieces)
        Me.gbItemData.Controls.Add(Me.txt)
        Me.gbItemData.Controls.Add(Me.cmbKarat)
        Me.gbItemData.Controls.Add(Me.Label34)
        Me.gbItemData.Controls.Add(Me.cmbCountryOfOrigin)
        Me.gbItemData.Controls.Add(Me.Lbl)
        Me.gbItemData.Controls.Add(Me.cmbName)
        Me.gbItemData.Controls.Add(Me.Label9)
        Me.gbItemData.Controls.Add(Me.cmbSupplier)
        Me.gbItemData.Controls.Add(Me.txtItemNo)
        Me.gbItemData.Controls.Add(Me.Label11)
        Me.gbItemData.Controls.Add(Me.cmbSymbol)
        Me.gbItemData.Controls.Add(Me.Label36)
        Me.gbItemData.Controls.Add(Me.Label42)
        Me.gbItemData.CustomBorderColor = System.Drawing.Color.CornflowerBlue
        Me.gbItemData.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbItemData.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.gbItemData.ForeColor = System.Drawing.Color.Black
        Me.gbItemData.Location = New System.Drawing.Point(0, 0)
        Me.gbItemData.Name = "gbItemData"
        Me.gbItemData.Size = New System.Drawing.Size(966, 219)
        Me.gbItemData.TabIndex = 2
        Me.gbItemData.Text = "بيانات القطعة"
        Me.gbItemData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbItemStatus
        '
        Me.cmbItemStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbItemStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemStatus.FormattingEnabled = True
        Me.cmbItemStatus.Items.AddRange(New Object() {"جديد", "مستعمل"})
        Me.cmbItemStatus.Location = New System.Drawing.Point(400, 188)
        Me.cmbItemStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbItemStatus.Name = "cmbItemStatus"
        Me.cmbItemStatus.Size = New System.Drawing.Size(124, 27)
        Me.cmbItemStatus.TabIndex = 111
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(400, 158)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 27)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "حالة القطعة"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTaxExempt
        '
        Me.cmbTaxExempt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTaxExempt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTaxExempt.FormattingEnabled = True
        Me.cmbTaxExempt.Items.AddRange(New Object() {"معفي", "غير معفي"})
        Me.cmbTaxExempt.Location = New System.Drawing.Point(528, 188)
        Me.cmbTaxExempt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTaxExempt.Name = "cmbTaxExempt"
        Me.cmbTaxExempt.Size = New System.Drawing.Size(124, 27)
        Me.cmbTaxExempt.TabIndex = 109
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(528, 158)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 27)
        Me.Label21.TabIndex = 108
        Me.Label21.Text = "حالة الإعفاء الضريبي"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtDateOfManufacture
        '
        Me.dtDateOfManufacture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDateOfManufacture.CustomFormat = "dd/MM/yyyy"
        Me.dtDateOfManufacture.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateOfManufacture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateOfManufacture.Location = New System.Drawing.Point(654, 188)
        Me.dtDateOfManufacture.Name = "dtDateOfManufacture"
        Me.dtDateOfManufacture.Size = New System.Drawing.Size(124, 27)
        Me.dtDateOfManufacture.TabIndex = 107
        '
        'txtCostForSeller
        '
        Me.txtCostForSeller.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostForSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostForSeller.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostForSeller.Location = New System.Drawing.Point(156, 70)
        Me.txtCostForSeller.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostForSeller.Name = "txtCostForSeller"
        Me.txtCostForSeller.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostForSeller.Size = New System.Drawing.Size(124, 27)
        Me.txtCostForSeller.TabIndex = 106
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(156, 40)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 27)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "تكلفة للبائع"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(776, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 27)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "اسم الصنف"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDocumentPath
        '
        Me.txtDocumentPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocumentPath.Location = New System.Drawing.Point(34, 188)
        Me.txtDocumentPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDocumentPath.Name = "txtDocumentPath"
        Me.txtDocumentPath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentPath.Properties.Appearance.Options.UseFont = True
        Me.txtDocumentPath.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtDocumentPath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtDocumentPath.Size = New System.Drawing.Size(181, 26)
        Me.txtDocumentPath.TabIndex = 104
        '
        'txtGoldWeight
        '
        Me.txtGoldWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGoldWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGoldWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldWeight.Location = New System.Drawing.Point(528, 70)
        Me.txtGoldWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGoldWeight.Name = "txtGoldWeight"
        Me.txtGoldWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGoldWeight.Size = New System.Drawing.Size(124, 27)
        Me.txtGoldWeight.TabIndex = 92
        '
        'txtImagePath
        '
        Me.txtImagePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImagePath.Location = New System.Drawing.Point(215, 188)
        Me.txtImagePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagePath.Properties.Appearance.Options.UseFont = True
        Me.txtImagePath.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtImagePath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtImagePath.Size = New System.Drawing.Size(181, 26)
        Me.txtImagePath.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(528, 40)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 27)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "وزن الذهب"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(652, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 27)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "عيار الذهب"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(652, 158)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 27)
        Me.Label20.TabIndex = 77
        Me.Label20.Text = "تاريخ الصنع"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(776, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 27)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "الباركود"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCostPerGram
        '
        Me.txtCostPerGram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPerGram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPerGram.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerGram.Location = New System.Drawing.Point(404, 70)
        Me.txtCostPerGram.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostPerGram.Name = "txtCostPerGram"
        Me.txtCostPerGram.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostPerGram.Size = New System.Drawing.Size(124, 27)
        Me.txtCostPerGram.TabIndex = 87
        '
        'txtBarCode
        '
        Me.txtBarCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(776, 188)
        Me.txtBarCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBarCode.Size = New System.Drawing.Size(181, 27)
        Me.txtBarCode.TabIndex = 83
        '
        'txtCostPerPiece
        '
        Me.txtCostPerPiece.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPerPiece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPerPiece.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerPiece.Location = New System.Drawing.Point(280, 70)
        Me.txtCostPerPiece.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostPerPiece.Name = "txtCostPerPiece"
        Me.txtCostPerPiece.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostPerPiece.Size = New System.Drawing.Size(124, 27)
        Me.txtCostPerPiece.TabIndex = 85
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(342, 99)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 27)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "المورد"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(652, 99)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 27)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "مصنعية البيع / جرام"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(404, 40)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 27)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "تكلفة الشراء للجرام"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMakingCharge
        '
        Me.txtMakingCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMakingCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMakingCharge.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMakingCharge.Location = New System.Drawing.Point(652, 127)
        Me.txtMakingCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMakingCharge.Name = "txtMakingCharge"
        Me.txtMakingCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMakingCharge.Size = New System.Drawing.Size(124, 27)
        Me.txtMakingCharge.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(280, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 27)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "سعر شراء القطعة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(32, 40)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 27)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "سعر الجرام عند الشراء"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNoOfPieces
        '
        Me.txtNoOfPieces.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoOfPieces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoOfPieces.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfPieces.Location = New System.Drawing.Point(32, 127)
        Me.txtNoOfPieces.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoOfPieces.Name = "txtNoOfPieces"
        Me.txtNoOfPieces.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNoOfPieces.Size = New System.Drawing.Size(124, 27)
        Me.txtNoOfPieces.TabIndex = 79
        '
        'txt
        '
        Me.txt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(32, 70)
        Me.txt.Margin = New System.Windows.Forms.Padding(4)
        Me.txt.Name = "txt"
        Me.txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt.Size = New System.Drawing.Size(124, 27)
        Me.txt.TabIndex = 88
        '
        'cmbKarat
        '
        Me.cmbKarat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKarat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKarat.FormattingEnabled = True
        Me.cmbKarat.Location = New System.Drawing.Point(652, 70)
        Me.cmbKarat.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbKarat.Name = "cmbKarat"
        Me.cmbKarat.Size = New System.Drawing.Size(124, 27)
        Me.cmbKarat.TabIndex = 99
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(776, 99)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(181, 27)
        Me.Label34.TabIndex = 69
        Me.Label34.Text = "رقم القطعة"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCountryOfOrigin
        '
        Me.cmbCountryOfOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCountryOfOrigin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountryOfOrigin.FormattingEnabled = True
        Me.cmbCountryOfOrigin.Location = New System.Drawing.Point(528, 127)
        Me.cmbCountryOfOrigin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCountryOfOrigin.Name = "cmbCountryOfOrigin"
        Me.cmbCountryOfOrigin.Size = New System.Drawing.Size(124, 27)
        Me.cmbCountryOfOrigin.TabIndex = 94
        '
        'Lbl
        '
        Me.Lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl.BackColor = System.Drawing.Color.Transparent
        Me.Lbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.ForeColor = System.Drawing.Color.Black
        Me.Lbl.Location = New System.Drawing.Point(156, 99)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(186, 27)
        Me.Lbl.TabIndex = 76
        Me.Lbl.Text = "رمز القطعة"
        Me.Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbName
        '
        Me.cmbName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(776, 70)
        Me.cmbName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(181, 27)
        Me.cmbName.TabIndex = 96
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(528, 99)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 27)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "بلد المنشأ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSupplier
        '
        Me.cmbSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSupplier.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(342, 127)
        Me.cmbSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(186, 27)
        Me.cmbSupplier.TabIndex = 93
        '
        'txtItemNo
        '
        Me.txtItemNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemNo.Location = New System.Drawing.Point(776, 127)
        Me.txtItemNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtItemNo.Size = New System.Drawing.Size(181, 27)
        Me.txtItemNo.TabIndex = 90
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(32, 96)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 27)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "عدد القطع"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSymbol
        '
        Me.cmbSymbol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbSymbol.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSymbol.Location = New System.Drawing.Point(156, 127)
        Me.cmbSymbol.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSymbol.Name = "cmbSymbol"
        Me.cmbSymbol.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbSymbol.Size = New System.Drawing.Size(186, 27)
        Me.cmbSymbol.TabIndex = 89
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(215, 157)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(181, 27)
        Me.Label36.TabIndex = 64
        Me.Label36.Text = "صورة القطعة"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(34, 157)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(181, 27)
        Me.Label42.TabIndex = 55
        Me.Label42.Text = "مستندات / شهادات للقطعة"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbStoneData
        '
        Me.gbStoneData.BackColor = System.Drawing.Color.Transparent
        Me.gbStoneData.BorderColor = System.Drawing.Color.RoyalBlue
        Me.gbStoneData.BorderRadius = 5
        Me.gbStoneData.BorderThickness = 2
        Me.gbStoneData.Controls.Add(Me.PictureEdit1)
        Me.gbStoneData.Controls.Add(Me.DgvStone)
        Me.gbStoneData.CustomBorderColor = System.Drawing.Color.CornflowerBlue
        Me.gbStoneData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbStoneData.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbStoneData.ForeColor = System.Drawing.Color.Black
        Me.gbStoneData.Location = New System.Drawing.Point(0, 221)
        Me.gbStoneData.Name = "gbStoneData"
        Me.gbStoneData.Size = New System.Drawing.Size(966, 169)
        Me.gbStoneData.TabIndex = 3
        Me.gbStoneData.Text = "بيانات الاحجار"
        Me.gbStoneData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DgvStone
        '
        Me.DgvStone.AllowUserToAddRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvStone.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvStone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvStone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvStone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvStone.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvStone.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvStone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column9, Me.Column20, Me.Column1, Me.Column2, Me.Column3, Me.Column18, Me.Column19, Me.Column4, Me.Column12})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvStone.DefaultCellStyle = DataGridViewCellStyle8
        Me.DgvStone.Location = New System.Drawing.Point(4, 41)
        Me.DgvStone.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvStone.Name = "DgvStone"
        Me.DgvStone.ReadOnly = True
        Me.DgvStone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvStone.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvStone.RowHeadersWidth = 10
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DgvStone.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvStone.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.DgvStone.Size = New System.Drawing.Size(959, 124)
        Me.DgvStone.TabIndex = 100
        '
        'Column5
        '
        Me.Column5.HeaderText = "StoneCode"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column9
        '
        Me.Column9.FillWeight = 40.0!
        Me.Column9.HeaderText = "م"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column20
        '
        Me.Column20.HeaderText = "نوع الفص"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 88.85164!
        Me.Column1.HeaderText = "اسم الفص"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 88.85164!
        Me.Column2.HeaderText = "وزن الفص"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 88.85164!
        Me.Column3.HeaderText = "لون الفص"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column18
        '
        Me.Column18.FillWeight = 88.85164!
        Me.Column18.HeaderText = "نقاوة الفص"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        '
        'Column19
        '
        Me.Column19.FillWeight = 88.85164!
        Me.Column19.HeaderText = "قصة الفص"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 88.85164!
        Me.Column4.HeaderText = "السعر"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "عرض المرفق"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(829, 4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Size = New System.Drawing.Size(40, 30)
        Me.PictureEdit1.TabIndex = 101
        '
        'AddGoldItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.gbItemData)
        Me.Controls.Add(Me.gbStoneData)
        Me.Name = "AddGoldItem"
        Me.Size = New System.Drawing.Size(966, 390)
        Me.gbItemData.ResumeLayout(False)
        Me.gbItemData.PerformLayout()
        CType(Me.txtDocumentPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImagePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStoneData.ResumeLayout(False)
        CType(Me.DgvStone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbItemData As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cmbItemStatus As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbTaxExempt As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents dtDateOfManufacture As DateTimePicker
    Friend WithEvents txtCostForSeller As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDocumentPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGoldWeight As TextBox
    Friend WithEvents txtImagePath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCostPerGram As TextBox
    Friend WithEvents txtBarCode As TextBox
    Friend WithEvents txtCostPerPiece As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMakingCharge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNoOfPieces As TextBox
    Friend WithEvents txt As TextBox
    Friend WithEvents cmbKarat As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents cmbCountryOfOrigin As ComboBox
    Friend WithEvents Lbl As Label
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents txtItemNo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbSymbol As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents gbStoneData As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents DgvStone As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Private WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
