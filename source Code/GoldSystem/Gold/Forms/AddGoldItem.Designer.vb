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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbItemData = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.dtDateAdd = New System.Windows.Forms.DateTimePicker()
        Me.lblDateAdd = New System.Windows.Forms.Label()
        Me.cmbItemStatus = New System.Windows.Forms.ComboBox()
        Me.lblItemStatus = New System.Windows.Forms.Label()
        Me.cmbTaxExempt = New System.Windows.Forms.ComboBox()
        Me.lblTaxExempt = New System.Windows.Forms.Label()
        Me.dtDateOfManufacture = New System.Windows.Forms.DateTimePicker()
        Me.txtCostForSeller = New System.Windows.Forms.TextBox()
        Me.lblCostForSeller = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.txtDocumentPath = New DevExpress.XtraEditors.TextEdit()
        Me.txtGoldWeight = New System.Windows.Forms.TextBox()
        Me.txtImagePath = New DevExpress.XtraEditors.TextEdit()
        Me.lblGoldWeight = New System.Windows.Forms.Label()
        Me.lblKarat = New System.Windows.Forms.Label()
        Me.lblDateOfManufacture = New System.Windows.Forms.Label()
        Me.lblBarCode = New System.Windows.Forms.Label()
        Me.txtCostPerGram = New System.Windows.Forms.TextBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.txtCostPerPiece = New System.Windows.Forms.TextBox()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.lblMakingCharge = New System.Windows.Forms.Label()
        Me.lblCostPerGram = New System.Windows.Forms.Label()
        Me.txtMakingCharge = New System.Windows.Forms.TextBox()
        Me.lblCostPerPiece = New System.Windows.Forms.Label()
        Me.lblGramCost = New System.Windows.Forms.Label()
        Me.txtNoOfPieces = New System.Windows.Forms.TextBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.cmbKarat = New System.Windows.Forms.ComboBox()
        Me.lblItemNo = New System.Windows.Forms.Label()
        Me.cmbCountryOfOrigin = New System.Windows.Forms.ComboBox()
        Me.LblSymbol = New System.Windows.Forms.Label()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.lblCountryOfOrigin = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.lblNoOfPieces = New System.Windows.Forms.Label()
        Me.cmbSymbol = New System.Windows.Forms.TextBox()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.lblDocument = New System.Windows.Forms.Label()
        Me.gbStoneData = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.pbAddStone = New DevExpress.XtraEditors.PictureEdit()
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
        Me.gbItemData.SuspendLayout()
        CType(Me.txtDocumentPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImagePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStoneData.SuspendLayout()
        CType(Me.pbAddStone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvStone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbItemData
        '
        Me.gbItemData.BackColor = System.Drawing.Color.White
        Me.gbItemData.BorderColor = System.Drawing.Color.RoyalBlue
        Me.gbItemData.BorderRadius = 5
        Me.gbItemData.BorderThickness = 2
        Me.gbItemData.Controls.Add(Me.lblNote)
        Me.gbItemData.Controls.Add(Me.txtNote)
        Me.gbItemData.Controls.Add(Me.dtDateAdd)
        Me.gbItemData.Controls.Add(Me.lblDateAdd)
        Me.gbItemData.Controls.Add(Me.cmbItemStatus)
        Me.gbItemData.Controls.Add(Me.lblItemStatus)
        Me.gbItemData.Controls.Add(Me.cmbTaxExempt)
        Me.gbItemData.Controls.Add(Me.lblTaxExempt)
        Me.gbItemData.Controls.Add(Me.dtDateOfManufacture)
        Me.gbItemData.Controls.Add(Me.txtCostForSeller)
        Me.gbItemData.Controls.Add(Me.lblCostForSeller)
        Me.gbItemData.Controls.Add(Me.lblItemName)
        Me.gbItemData.Controls.Add(Me.txtDocumentPath)
        Me.gbItemData.Controls.Add(Me.txtGoldWeight)
        Me.gbItemData.Controls.Add(Me.txtImagePath)
        Me.gbItemData.Controls.Add(Me.lblGoldWeight)
        Me.gbItemData.Controls.Add(Me.lblKarat)
        Me.gbItemData.Controls.Add(Me.lblDateOfManufacture)
        Me.gbItemData.Controls.Add(Me.lblBarCode)
        Me.gbItemData.Controls.Add(Me.txtCostPerGram)
        Me.gbItemData.Controls.Add(Me.txtBarCode)
        Me.gbItemData.Controls.Add(Me.txtCostPerPiece)
        Me.gbItemData.Controls.Add(Me.lblSupplier)
        Me.gbItemData.Controls.Add(Me.lblMakingCharge)
        Me.gbItemData.Controls.Add(Me.lblCostPerGram)
        Me.gbItemData.Controls.Add(Me.txtMakingCharge)
        Me.gbItemData.Controls.Add(Me.lblCostPerPiece)
        Me.gbItemData.Controls.Add(Me.lblGramCost)
        Me.gbItemData.Controls.Add(Me.txtNoOfPieces)
        Me.gbItemData.Controls.Add(Me.txt)
        Me.gbItemData.Controls.Add(Me.cmbKarat)
        Me.gbItemData.Controls.Add(Me.lblItemNo)
        Me.gbItemData.Controls.Add(Me.cmbCountryOfOrigin)
        Me.gbItemData.Controls.Add(Me.LblSymbol)
        Me.gbItemData.Controls.Add(Me.cmbName)
        Me.gbItemData.Controls.Add(Me.lblCountryOfOrigin)
        Me.gbItemData.Controls.Add(Me.cmbSupplier)
        Me.gbItemData.Controls.Add(Me.txtItemNo)
        Me.gbItemData.Controls.Add(Me.lblNoOfPieces)
        Me.gbItemData.Controls.Add(Me.cmbSymbol)
        Me.gbItemData.Controls.Add(Me.lblPhoto)
        Me.gbItemData.Controls.Add(Me.lblDocument)
        Me.gbItemData.CustomBorderColor = System.Drawing.Color.CornflowerBlue
        Me.gbItemData.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbItemData.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.gbItemData.ForeColor = System.Drawing.Color.Black
        Me.gbItemData.Location = New System.Drawing.Point(0, 0)
        Me.gbItemData.Name = "gbItemData"
        Me.gbItemData.Size = New System.Drawing.Size(1350, 222)
        Me.gbItemData.TabIndex = 2
        Me.gbItemData.Text = "بيانات القطعة"
        Me.gbItemData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNote
        '
        Me.lblNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.Black
        Me.lblNote.Location = New System.Drawing.Point(180, 160)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(660, 27)
        Me.lblNote.TabIndex = 114
        Me.lblNote.Text = "ملاحظات"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNote.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(180, 187)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNote.Size = New System.Drawing.Size(660, 27)
        Me.txtNote.TabIndex = 115
        Me.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtDateAdd
        '
        Me.dtDateAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDateAdd.CustomFormat = "dd/MM/yyyy"
        Me.dtDateAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateAdd.Location = New System.Drawing.Point(345, 131)
        Me.dtDateAdd.Name = "dtDateAdd"
        Me.dtDateAdd.Size = New System.Drawing.Size(165, 27)
        Me.dtDateAdd.TabIndex = 113
        '
        'lblDateAdd
        '
        Me.lblDateAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblDateAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAdd.ForeColor = System.Drawing.Color.Black
        Me.lblDateAdd.Location = New System.Drawing.Point(345, 100)
        Me.lblDateAdd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateAdd.Name = "lblDateAdd"
        Me.lblDateAdd.Size = New System.Drawing.Size(165, 27)
        Me.lblDateAdd.TabIndex = 112
        Me.lblDateAdd.Text = "تاريخ الإدخال"
        Me.lblDateAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbItemStatus
        '
        Me.cmbItemStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbItemStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemStatus.FormattingEnabled = True
        Me.cmbItemStatus.Items.AddRange(New Object() {"جديد", "مستعمل"})
        Me.cmbItemStatus.Location = New System.Drawing.Point(675, 131)
        Me.cmbItemStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbItemStatus.Name = "cmbItemStatus"
        Me.cmbItemStatus.Size = New System.Drawing.Size(165, 27)
        Me.cmbItemStatus.TabIndex = 111
        '
        'lblItemStatus
        '
        Me.lblItemStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblItemStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemStatus.ForeColor = System.Drawing.Color.Black
        Me.lblItemStatus.Location = New System.Drawing.Point(675, 100)
        Me.lblItemStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemStatus.Name = "lblItemStatus"
        Me.lblItemStatus.Size = New System.Drawing.Size(165, 27)
        Me.lblItemStatus.TabIndex = 110
        Me.lblItemStatus.Text = "حالة القطعة"
        Me.lblItemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTaxExempt
        '
        Me.cmbTaxExempt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTaxExempt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTaxExempt.FormattingEnabled = True
        Me.cmbTaxExempt.Items.AddRange(New Object() {"معفي", "غير معفي"})
        Me.cmbTaxExempt.Location = New System.Drawing.Point(840, 131)
        Me.cmbTaxExempt.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTaxExempt.Name = "cmbTaxExempt"
        Me.cmbTaxExempt.Size = New System.Drawing.Size(165, 27)
        Me.cmbTaxExempt.TabIndex = 109
        '
        'lblTaxExempt
        '
        Me.lblTaxExempt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTaxExempt.BackColor = System.Drawing.Color.Transparent
        Me.lblTaxExempt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxExempt.ForeColor = System.Drawing.Color.Black
        Me.lblTaxExempt.Location = New System.Drawing.Point(840, 100)
        Me.lblTaxExempt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaxExempt.Name = "lblTaxExempt"
        Me.lblTaxExempt.Size = New System.Drawing.Size(165, 27)
        Me.lblTaxExempt.TabIndex = 108
        Me.lblTaxExempt.Text = "حالة الإعفاء الضريبي"
        Me.lblTaxExempt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtDateOfManufacture
        '
        Me.dtDateOfManufacture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDateOfManufacture.CustomFormat = "dd/MM/yyyy"
        Me.dtDateOfManufacture.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateOfManufacture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateOfManufacture.Location = New System.Drawing.Point(510, 131)
        Me.dtDateOfManufacture.Name = "dtDateOfManufacture"
        Me.dtDateOfManufacture.Size = New System.Drawing.Size(165, 27)
        Me.dtDateOfManufacture.TabIndex = 107
        '
        'txtCostForSeller
        '
        Me.txtCostForSeller.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostForSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostForSeller.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostForSeller.Location = New System.Drawing.Point(345, 70)
        Me.txtCostForSeller.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostForSeller.Name = "txtCostForSeller"
        Me.txtCostForSeller.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostForSeller.Size = New System.Drawing.Size(165, 27)
        Me.txtCostForSeller.TabIndex = 106
        Me.txtCostForSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostForSeller
        '
        Me.lblCostForSeller.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCostForSeller.BackColor = System.Drawing.Color.Transparent
        Me.lblCostForSeller.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostForSeller.ForeColor = System.Drawing.Color.Black
        Me.lblCostForSeller.Location = New System.Drawing.Point(345, 39)
        Me.lblCostForSeller.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCostForSeller.Name = "lblCostForSeller"
        Me.lblCostForSeller.Size = New System.Drawing.Size(165, 27)
        Me.lblCostForSeller.TabIndex = 105
        Me.lblCostForSeller.Text = "تكلفة للبائع"
        Me.lblCostForSeller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemName
        '
        Me.lblItemName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemName.BackColor = System.Drawing.Color.Transparent
        Me.lblItemName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.Black
        Me.lblItemName.Location = New System.Drawing.Point(1170, 39)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(165, 27)
        Me.lblItemName.TabIndex = 75
        Me.lblItemName.Text = "اسم الصنف"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDocumentPath
        '
        Me.txtDocumentPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocumentPath.Location = New System.Drawing.Point(15, 187)
        Me.txtDocumentPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDocumentPath.Name = "txtDocumentPath"
        Me.txtDocumentPath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentPath.Properties.Appearance.Options.UseFont = True
        Me.txtDocumentPath.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtDocumentPath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtDocumentPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDocumentPath.Size = New System.Drawing.Size(165, 26)
        Me.txtDocumentPath.TabIndex = 104
        '
        'txtGoldWeight
        '
        Me.txtGoldWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGoldWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGoldWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldWeight.Location = New System.Drawing.Point(840, 70)
        Me.txtGoldWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGoldWeight.Name = "txtGoldWeight"
        Me.txtGoldWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGoldWeight.Size = New System.Drawing.Size(165, 27)
        Me.txtGoldWeight.TabIndex = 92
        Me.txtGoldWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImagePath
        '
        Me.txtImagePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImagePath.Location = New System.Drawing.Point(15, 131)
        Me.txtImagePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagePath.Properties.Appearance.Options.UseFont = True
        Me.txtImagePath.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtImagePath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtImagePath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImagePath.Size = New System.Drawing.Size(165, 26)
        Me.txtImagePath.TabIndex = 103
        '
        'lblGoldWeight
        '
        Me.lblGoldWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGoldWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblGoldWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoldWeight.ForeColor = System.Drawing.Color.Black
        Me.lblGoldWeight.Location = New System.Drawing.Point(840, 39)
        Me.lblGoldWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGoldWeight.Name = "lblGoldWeight"
        Me.lblGoldWeight.Size = New System.Drawing.Size(165, 27)
        Me.lblGoldWeight.TabIndex = 61
        Me.lblGoldWeight.Text = "وزن الذهب"
        Me.lblGoldWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKarat
        '
        Me.lblKarat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKarat.BackColor = System.Drawing.Color.Transparent
        Me.lblKarat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKarat.ForeColor = System.Drawing.Color.Black
        Me.lblKarat.Location = New System.Drawing.Point(1005, 39)
        Me.lblKarat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKarat.Name = "lblKarat"
        Me.lblKarat.Size = New System.Drawing.Size(165, 27)
        Me.lblKarat.TabIndex = 72
        Me.lblKarat.Text = "عيار الذهب"
        Me.lblKarat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateOfManufacture
        '
        Me.lblDateOfManufacture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateOfManufacture.BackColor = System.Drawing.Color.Transparent
        Me.lblDateOfManufacture.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateOfManufacture.ForeColor = System.Drawing.Color.Black
        Me.lblDateOfManufacture.Location = New System.Drawing.Point(510, 100)
        Me.lblDateOfManufacture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateOfManufacture.Name = "lblDateOfManufacture"
        Me.lblDateOfManufacture.Size = New System.Drawing.Size(165, 27)
        Me.lblDateOfManufacture.TabIndex = 77
        Me.lblDateOfManufacture.Text = "تاريخ الصنع"
        Me.lblDateOfManufacture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBarCode
        '
        Me.lblBarCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBarCode.BackColor = System.Drawing.Color.Transparent
        Me.lblBarCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarCode.ForeColor = System.Drawing.Color.Black
        Me.lblBarCode.Location = New System.Drawing.Point(840, 160)
        Me.lblBarCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(165, 27)
        Me.lblBarCode.TabIndex = 77
        Me.lblBarCode.Text = "الباركود"
        Me.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCostPerGram
        '
        Me.txtCostPerGram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPerGram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPerGram.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerGram.Location = New System.Drawing.Point(510, 70)
        Me.txtCostPerGram.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostPerGram.Name = "txtCostPerGram"
        Me.txtCostPerGram.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostPerGram.Size = New System.Drawing.Size(165, 27)
        Me.txtCostPerGram.TabIndex = 87
        Me.txtCostPerGram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBarCode
        '
        Me.txtBarCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(840, 187)
        Me.txtBarCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(165, 27)
        Me.txtBarCode.TabIndex = 83
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostPerPiece
        '
        Me.txtCostPerPiece.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPerPiece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostPerPiece.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostPerPiece.Location = New System.Drawing.Point(15, 70)
        Me.txtCostPerPiece.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCostPerPiece.Name = "txtCostPerPiece"
        Me.txtCostPerPiece.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostPerPiece.Size = New System.Drawing.Size(165, 27)
        Me.txtCostPerPiece.TabIndex = 85
        Me.txtCostPerPiece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSupplier
        '
        Me.lblSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSupplier.BackColor = System.Drawing.Color.Transparent
        Me.lblSupplier.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.ForeColor = System.Drawing.Color.Black
        Me.lblSupplier.Location = New System.Drawing.Point(1005, 100)
        Me.lblSupplier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(165, 27)
        Me.lblSupplier.TabIndex = 60
        Me.lblSupplier.Text = "المورد"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMakingCharge
        '
        Me.lblMakingCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMakingCharge.BackColor = System.Drawing.Color.Transparent
        Me.lblMakingCharge.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMakingCharge.ForeColor = System.Drawing.Color.Black
        Me.lblMakingCharge.Location = New System.Drawing.Point(675, 39)
        Me.lblMakingCharge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMakingCharge.Name = "lblMakingCharge"
        Me.lblMakingCharge.Size = New System.Drawing.Size(165, 27)
        Me.lblMakingCharge.TabIndex = 74
        Me.lblMakingCharge.Text = "مصنعية البيع / جرام"
        Me.lblMakingCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCostPerGram
        '
        Me.lblCostPerGram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCostPerGram.BackColor = System.Drawing.Color.Transparent
        Me.lblCostPerGram.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerGram.ForeColor = System.Drawing.Color.Black
        Me.lblCostPerGram.Location = New System.Drawing.Point(510, 39)
        Me.lblCostPerGram.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCostPerGram.Name = "lblCostPerGram"
        Me.lblCostPerGram.Size = New System.Drawing.Size(165, 27)
        Me.lblCostPerGram.TabIndex = 58
        Me.lblCostPerGram.Text = "تكلفة الشراء للجرام"
        Me.lblCostPerGram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMakingCharge
        '
        Me.txtMakingCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMakingCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMakingCharge.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMakingCharge.Location = New System.Drawing.Point(675, 70)
        Me.txtMakingCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMakingCharge.Name = "txtMakingCharge"
        Me.txtMakingCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMakingCharge.Size = New System.Drawing.Size(165, 27)
        Me.txtMakingCharge.TabIndex = 86
        Me.txtMakingCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostPerPiece
        '
        Me.lblCostPerPiece.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCostPerPiece.BackColor = System.Drawing.Color.Transparent
        Me.lblCostPerPiece.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerPiece.ForeColor = System.Drawing.Color.Black
        Me.lblCostPerPiece.Location = New System.Drawing.Point(15, 39)
        Me.lblCostPerPiece.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCostPerPiece.Name = "lblCostPerPiece"
        Me.lblCostPerPiece.Size = New System.Drawing.Size(165, 27)
        Me.lblCostPerPiece.TabIndex = 68
        Me.lblCostPerPiece.Text = "سعر شراء القطعة"
        Me.lblCostPerPiece.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGramCost
        '
        Me.lblGramCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGramCost.BackColor = System.Drawing.Color.Transparent
        Me.lblGramCost.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGramCost.ForeColor = System.Drawing.Color.Black
        Me.lblGramCost.Location = New System.Drawing.Point(180, 39)
        Me.lblGramCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGramCost.Name = "lblGramCost"
        Me.lblGramCost.Size = New System.Drawing.Size(165, 27)
        Me.lblGramCost.TabIndex = 73
        Me.lblGramCost.Text = "سعر الجرام عند الشراء"
        Me.lblGramCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNoOfPieces
        '
        Me.txtNoOfPieces.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoOfPieces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoOfPieces.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfPieces.Location = New System.Drawing.Point(180, 131)
        Me.txtNoOfPieces.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoOfPieces.Name = "txtNoOfPieces"
        Me.txtNoOfPieces.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoOfPieces.Size = New System.Drawing.Size(165, 27)
        Me.txtNoOfPieces.TabIndex = 79
        Me.txtNoOfPieces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt
        '
        Me.txt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(180, 70)
        Me.txt.Margin = New System.Windows.Forms.Padding(4)
        Me.txt.Name = "txt"
        Me.txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt.Size = New System.Drawing.Size(165, 27)
        Me.txt.TabIndex = 88
        Me.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbKarat
        '
        Me.cmbKarat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKarat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKarat.FormattingEnabled = True
        Me.cmbKarat.Location = New System.Drawing.Point(1005, 70)
        Me.cmbKarat.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbKarat.Name = "cmbKarat"
        Me.cmbKarat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbKarat.Size = New System.Drawing.Size(165, 27)
        Me.cmbKarat.TabIndex = 99
        '
        'lblItemNo
        '
        Me.lblItemNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemNo.BackColor = System.Drawing.Color.Transparent
        Me.lblItemNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemNo.ForeColor = System.Drawing.Color.Black
        Me.lblItemNo.Location = New System.Drawing.Point(1170, 160)
        Me.lblItemNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.Size = New System.Drawing.Size(165, 27)
        Me.lblItemNo.TabIndex = 69
        Me.lblItemNo.Text = "رقم القطعة"
        Me.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCountryOfOrigin
        '
        Me.cmbCountryOfOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCountryOfOrigin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountryOfOrigin.FormattingEnabled = True
        Me.cmbCountryOfOrigin.Location = New System.Drawing.Point(1170, 131)
        Me.cmbCountryOfOrigin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCountryOfOrigin.Name = "cmbCountryOfOrigin"
        Me.cmbCountryOfOrigin.Size = New System.Drawing.Size(165, 27)
        Me.cmbCountryOfOrigin.TabIndex = 94
        '
        'LblSymbol
        '
        Me.LblSymbol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSymbol.BackColor = System.Drawing.Color.Transparent
        Me.LblSymbol.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSymbol.ForeColor = System.Drawing.Color.Black
        Me.LblSymbol.Location = New System.Drawing.Point(1005, 160)
        Me.LblSymbol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSymbol.Name = "LblSymbol"
        Me.LblSymbol.Size = New System.Drawing.Size(165, 27)
        Me.LblSymbol.TabIndex = 76
        Me.LblSymbol.Text = "رمز القطعة"
        Me.LblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbName
        '
        Me.cmbName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(1170, 70)
        Me.cmbName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(165, 27)
        Me.cmbName.TabIndex = 96
        '
        'lblCountryOfOrigin
        '
        Me.lblCountryOfOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCountryOfOrigin.BackColor = System.Drawing.Color.Transparent
        Me.lblCountryOfOrigin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountryOfOrigin.ForeColor = System.Drawing.Color.Black
        Me.lblCountryOfOrigin.Location = New System.Drawing.Point(1170, 100)
        Me.lblCountryOfOrigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountryOfOrigin.Name = "lblCountryOfOrigin"
        Me.lblCountryOfOrigin.Size = New System.Drawing.Size(165, 27)
        Me.lblCountryOfOrigin.TabIndex = 66
        Me.lblCountryOfOrigin.Text = "بلد المنشأ"
        Me.lblCountryOfOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSupplier
        '
        Me.cmbSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSupplier.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(1005, 131)
        Me.cmbSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(165, 27)
        Me.cmbSupplier.TabIndex = 93
        '
        'txtItemNo
        '
        Me.txtItemNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemNo.Location = New System.Drawing.Point(1170, 187)
        Me.txtItemNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(165, 27)
        Me.txtItemNo.TabIndex = 90
        Me.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNoOfPieces
        '
        Me.lblNoOfPieces.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoOfPieces.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfPieces.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfPieces.ForeColor = System.Drawing.Color.Black
        Me.lblNoOfPieces.Location = New System.Drawing.Point(180, 100)
        Me.lblNoOfPieces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoOfPieces.Name = "lblNoOfPieces"
        Me.lblNoOfPieces.Size = New System.Drawing.Size(165, 27)
        Me.lblNoOfPieces.TabIndex = 63
        Me.lblNoOfPieces.Text = "عدد القطع"
        Me.lblNoOfPieces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSymbol
        '
        Me.cmbSymbol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbSymbol.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSymbol.Location = New System.Drawing.Point(1005, 187)
        Me.cmbSymbol.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSymbol.Name = "cmbSymbol"
        Me.cmbSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSymbol.Size = New System.Drawing.Size(165, 27)
        Me.cmbSymbol.TabIndex = 89
        Me.cmbSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPhoto
        '
        Me.lblPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPhoto.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoto.ForeColor = System.Drawing.Color.Black
        Me.lblPhoto.Location = New System.Drawing.Point(15, 100)
        Me.lblPhoto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(165, 27)
        Me.lblPhoto.TabIndex = 64
        Me.lblPhoto.Text = "صورة القطعة"
        Me.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDocument
        '
        Me.lblDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocument.BackColor = System.Drawing.Color.Transparent
        Me.lblDocument.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocument.ForeColor = System.Drawing.Color.Black
        Me.lblDocument.Location = New System.Drawing.Point(15, 160)
        Me.lblDocument.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDocument.Name = "lblDocument"
        Me.lblDocument.Size = New System.Drawing.Size(165, 27)
        Me.lblDocument.TabIndex = 55
        Me.lblDocument.Text = "مستندات / شهادات للقطعة"
        Me.lblDocument.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbStoneData
        '
        Me.gbStoneData.BackColor = System.Drawing.Color.Transparent
        Me.gbStoneData.BorderColor = System.Drawing.Color.RoyalBlue
        Me.gbStoneData.BorderRadius = 5
        Me.gbStoneData.BorderThickness = 2
        Me.gbStoneData.Controls.Add(Me.pbAddStone)
        Me.gbStoneData.Controls.Add(Me.DgvStone)
        Me.gbStoneData.CustomBorderColor = System.Drawing.Color.CornflowerBlue
        Me.gbStoneData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbStoneData.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbStoneData.ForeColor = System.Drawing.Color.Black
        Me.gbStoneData.Location = New System.Drawing.Point(0, 225)
        Me.gbStoneData.Name = "gbStoneData"
        Me.gbStoneData.Size = New System.Drawing.Size(1350, 130)
        Me.gbStoneData.TabIndex = 3
        Me.gbStoneData.Text = "بيانات الاحجار"
        Me.gbStoneData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pbAddStone
        '
        Me.pbAddStone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAddStone.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbAddStone.EditValue = CType(resources.GetObject("pbAddStone.EditValue"), Object)
        Me.pbAddStone.Location = New System.Drawing.Point(1213, 4)
        Me.pbAddStone.Name = "pbAddStone"
        Me.pbAddStone.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbAddStone.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.pbAddStone.Properties.Appearance.Options.UseBackColor = True
        Me.pbAddStone.Properties.Appearance.Options.UseForeColor = True
        Me.pbAddStone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbAddStone.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pbAddStone.Size = New System.Drawing.Size(40, 30)
        ToolTipTitleItem1.Text = "إضافة حجر"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "اضغط إضافة حجر للقطعة"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.pbAddStone.SuperTip = SuperToolTip1
        Me.pbAddStone.TabIndex = 101
        '
        'DgvStone
        '
        Me.DgvStone.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvStone.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvStone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvStone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvStone.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvStone.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvStone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvStone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column9, Me.Column20, Me.Column1, Me.Column2, Me.Column3, Me.Column18, Me.Column19, Me.Column4, Me.Column12})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvStone.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvStone.Location = New System.Drawing.Point(2, 40)
        Me.DgvStone.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvStone.Name = "DgvStone"
        Me.DgvStone.ReadOnly = True
        Me.DgvStone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvStone.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvStone.RowHeadersWidth = 10
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DgvStone.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvStone.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.DgvStone.Size = New System.Drawing.Size(1345, 87)
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
        'AddGoldItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.gbItemData)
        Me.Controls.Add(Me.gbStoneData)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddGoldItem"
        Me.Size = New System.Drawing.Size(1350, 355)
        Me.gbItemData.ResumeLayout(False)
        Me.gbItemData.PerformLayout()
        CType(Me.txtDocumentPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImagePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStoneData.ResumeLayout(False)
        CType(Me.pbAddStone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvStone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbItemData As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cmbItemStatus As ComboBox
    Friend WithEvents lblItemStatus As Label
    Friend WithEvents cmbTaxExempt As ComboBox
    Friend WithEvents lblTaxExempt As Label
    Friend WithEvents dtDateOfManufacture As DateTimePicker
    Friend WithEvents txtCostForSeller As TextBox
    Friend WithEvents lblCostForSeller As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents txtDocumentPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGoldWeight As TextBox
    Friend WithEvents txtImagePath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGoldWeight As Label
    Friend WithEvents lblKarat As Label
    Friend WithEvents lblDateOfManufacture As Label
    Friend WithEvents lblBarCode As Label
    Friend WithEvents txtCostPerGram As TextBox
    Friend WithEvents txtBarCode As TextBox
    Friend WithEvents txtCostPerPiece As TextBox
    Friend WithEvents lblSupplier As Label
    Friend WithEvents lblMakingCharge As Label
    Friend WithEvents lblCostPerGram As Label
    Friend WithEvents txtMakingCharge As TextBox
    Friend WithEvents lblCostPerPiece As Label
    Friend WithEvents lblGramCost As Label
    Friend WithEvents txtNoOfPieces As TextBox
    Friend WithEvents txt As TextBox
    Friend WithEvents cmbKarat As ComboBox
    Friend WithEvents lblItemNo As Label
    Friend WithEvents cmbCountryOfOrigin As ComboBox
    Friend WithEvents LblSymbol As Label
    Friend WithEvents cmbName As ComboBox
    Friend WithEvents lblCountryOfOrigin As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents txtItemNo As TextBox
    Friend WithEvents lblNoOfPieces As Label
    Friend WithEvents cmbSymbol As TextBox
    Friend WithEvents lblPhoto As Label
    Friend WithEvents lblDocument As Label
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
    Private WithEvents pbAddStone As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents dtDateAdd As DateTimePicker
    Friend WithEvents lblDateAdd As Label
    Friend WithEvents lblNote As Label
    Friend WithEvents txtNote As TextBox
End Class
