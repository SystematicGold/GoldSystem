<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCGoldAddItem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCGoldAddItem))
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.pbAddStone = New DevExpress.XtraEditors.PictureEdit()
        Me.gbItemData = New DevExpress.XtraEditors.GroupControl()
        Me.cmbKarat = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbItemCondition = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbTaxExempt = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbSupplierReceiptNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbSupplier = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbCountryOfOrigin = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbItemName = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNote = New DevExpress.XtraEditors.MemoEdit()
        Me.dtpDateAdded = New DevExpress.XtraEditors.DateEdit()
        Me.lblDocument = New DevExpress.XtraEditors.LabelControl()
        Me.dtpDateOfManufacture = New DevExpress.XtraEditors.DateEdit()
        Me.txtBarCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtCostPerPiece = New DevExpress.XtraEditors.TextEdit()
        Me.txtSymbol = New DevExpress.XtraEditors.TextEdit()
        Me.txtItemNo = New DevExpress.XtraEditors.TextEdit()
        Me.lblPhoto = New DevExpress.XtraEditors.LabelControl()
        Me.txtNoOfPieces = New DevExpress.XtraEditors.TextEdit()
        Me.txtGramCost = New DevExpress.XtraEditors.TextEdit()
        Me.lblCostPerPiece = New DevExpress.XtraEditors.LabelControl()
        Me.txtCostForSeller = New DevExpress.XtraEditors.TextEdit()
        Me.lblDateAdded = New DevExpress.XtraEditors.LabelControl()
        Me.txtCostPerGram = New DevExpress.XtraEditors.TextEdit()
        Me.lblGramCost = New DevExpress.XtraEditors.LabelControl()
        Me.txtMakingCharge = New DevExpress.XtraEditors.TextEdit()
        Me.lblDateOfManufacture = New DevExpress.XtraEditors.LabelControl()
        Me.txtGoldWeight = New DevExpress.XtraEditors.TextEdit()
        Me.lblCostForSeller = New DevExpress.XtraEditors.LabelControl()
        Me.lblNote = New DevExpress.XtraEditors.LabelControl()
        Me.lblItemCondition = New DevExpress.XtraEditors.LabelControl()
        Me.lblCostPerGram = New DevExpress.XtraEditors.LabelControl()
        Me.lblBarCode = New DevExpress.XtraEditors.LabelControl()
        Me.lblTaxExempt = New DevExpress.XtraEditors.LabelControl()
        Me.lblMakingCharge = New DevExpress.XtraEditors.LabelControl()
        Me.lblSymbol = New DevExpress.XtraEditors.LabelControl()
        Me.lblSupplierInvoiceNo = New DevExpress.XtraEditors.LabelControl()
        Me.lblGoldWeight = New DevExpress.XtraEditors.LabelControl()
        Me.lblItemNo = New DevExpress.XtraEditors.LabelControl()
        Me.lblSupplier = New DevExpress.XtraEditors.LabelControl()
        Me.lblKarat = New DevExpress.XtraEditors.LabelControl()
        Me.lblNoOfPieces = New DevExpress.XtraEditors.LabelControl()
        Me.lblCountryOfOrigin = New DevExpress.XtraEditors.LabelControl()
        Me.lblItemName = New DevExpress.XtraEditors.LabelControl()
        Me.txtDocumentPath = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtImagePath = New DevExpress.XtraEditors.ButtonEdit()
        Me.gbStoneData = New DevExpress.XtraEditors.GroupControl()
        Me.DGVStone1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DgvStone = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colStoneCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneSerial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneClarity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneCut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStonePrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneView = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OFDX = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.EPX = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.pbAddStone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbItemData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItemData.SuspendLayout()
        CType(Me.cmbKarat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbItemCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTaxExempt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupplierReceiptNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountryOfOrigin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateAdded.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateOfManufacture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateOfManufacture.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostPerPiece.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSymbol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoOfPieces.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGramCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostForSeller.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostPerGram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMakingCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGoldWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumentPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImagePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbStoneData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStoneData.SuspendLayout()
        CType(Me.DGVStone1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvStone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAddStone
        '
        Me.pbAddStone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAddStone.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbAddStone.EditValue = CType(resources.GetObject("pbAddStone.EditValue"), Object)
        Me.pbAddStone.Location = New System.Drawing.Point(1214, 1)
        Me.pbAddStone.Name = "pbAddStone"
        Me.pbAddStone.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbAddStone.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.pbAddStone.Properties.Appearance.Options.UseBackColor = True
        Me.pbAddStone.Properties.Appearance.Options.UseForeColor = True
        Me.pbAddStone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbAddStone.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pbAddStone.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbAddStone.Size = New System.Drawing.Size(20, 20)
        ToolTipTitleItem2.Text = "إضافة فص"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "اضغط لإضافة فص للقطعة"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.pbAddStone.SuperTip = SuperToolTip2
        Me.pbAddStone.TabIndex = 101
        '
        'gbItemData
        '
        Me.gbItemData.Controls.Add(Me.cmbKarat)
        Me.gbItemData.Controls.Add(Me.cmbItemCondition)
        Me.gbItemData.Controls.Add(Me.cmbTaxExempt)
        Me.gbItemData.Controls.Add(Me.cmbSupplierReceiptNo)
        Me.gbItemData.Controls.Add(Me.cmbSupplier)
        Me.gbItemData.Controls.Add(Me.cmbCountryOfOrigin)
        Me.gbItemData.Controls.Add(Me.cmbItemName)
        Me.gbItemData.Controls.Add(Me.txtNote)
        Me.gbItemData.Controls.Add(Me.dtpDateAdded)
        Me.gbItemData.Controls.Add(Me.lblDocument)
        Me.gbItemData.Controls.Add(Me.dtpDateOfManufacture)
        Me.gbItemData.Controls.Add(Me.txtBarCode)
        Me.gbItemData.Controls.Add(Me.txtCostPerPiece)
        Me.gbItemData.Controls.Add(Me.txtSymbol)
        Me.gbItemData.Controls.Add(Me.txtItemNo)
        Me.gbItemData.Controls.Add(Me.lblPhoto)
        Me.gbItemData.Controls.Add(Me.txtNoOfPieces)
        Me.gbItemData.Controls.Add(Me.txtGramCost)
        Me.gbItemData.Controls.Add(Me.lblCostPerPiece)
        Me.gbItemData.Controls.Add(Me.txtCostForSeller)
        Me.gbItemData.Controls.Add(Me.lblDateAdded)
        Me.gbItemData.Controls.Add(Me.txtCostPerGram)
        Me.gbItemData.Controls.Add(Me.lblGramCost)
        Me.gbItemData.Controls.Add(Me.txtMakingCharge)
        Me.gbItemData.Controls.Add(Me.lblDateOfManufacture)
        Me.gbItemData.Controls.Add(Me.txtGoldWeight)
        Me.gbItemData.Controls.Add(Me.lblCostForSeller)
        Me.gbItemData.Controls.Add(Me.lblNote)
        Me.gbItemData.Controls.Add(Me.lblItemCondition)
        Me.gbItemData.Controls.Add(Me.lblCostPerGram)
        Me.gbItemData.Controls.Add(Me.lblBarCode)
        Me.gbItemData.Controls.Add(Me.lblTaxExempt)
        Me.gbItemData.Controls.Add(Me.lblMakingCharge)
        Me.gbItemData.Controls.Add(Me.lblSymbol)
        Me.gbItemData.Controls.Add(Me.lblSupplierInvoiceNo)
        Me.gbItemData.Controls.Add(Me.lblGoldWeight)
        Me.gbItemData.Controls.Add(Me.lblItemNo)
        Me.gbItemData.Controls.Add(Me.lblSupplier)
        Me.gbItemData.Controls.Add(Me.lblKarat)
        Me.gbItemData.Controls.Add(Me.lblNoOfPieces)
        Me.gbItemData.Controls.Add(Me.lblCountryOfOrigin)
        Me.gbItemData.Controls.Add(Me.lblItemName)
        Me.gbItemData.Controls.Add(Me.txtDocumentPath)
        Me.gbItemData.Controls.Add(Me.txtImagePath)
        Me.gbItemData.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbItemData.Location = New System.Drawing.Point(0, 0)
        Me.gbItemData.Name = "gbItemData"
        Me.gbItemData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbItemData.Size = New System.Drawing.Size(1350, 166)
        Me.gbItemData.TabIndex = 0
        Me.gbItemData.Text = "بيانات القطعة"
        '
        'cmbKarat
        '
        Me.cmbKarat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbKarat.Location = New System.Drawing.Point(1004, 45)
        Me.cmbKarat.Name = "cmbKarat"
        Me.cmbKarat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbKarat.Properties.NullText = "اختر عيارًا"
        Me.cmbKarat.Properties.ShowFooter = False
        Me.cmbKarat.Properties.ShowHeader = False
        Me.cmbKarat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbKarat.Size = New System.Drawing.Size(165, 20)
        Me.cmbKarat.TabIndex = 1
        '
        'cmbItemCondition
        '
        Me.cmbItemCondition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbItemCondition.Location = New System.Drawing.Point(509, 91)
        Me.cmbItemCondition.Name = "cmbItemCondition"
        Me.cmbItemCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbItemCondition.Properties.NullText = "اختر الحالة"
        Me.cmbItemCondition.Properties.ShowFooter = False
        Me.cmbItemCondition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbItemCondition.Size = New System.Drawing.Size(165, 20)
        Me.cmbItemCondition.TabIndex = 12
        '
        'cmbTaxExempt
        '
        Me.cmbTaxExempt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbTaxExempt.Location = New System.Drawing.Point(674, 91)
        Me.cmbTaxExempt.Name = "cmbTaxExempt"
        Me.cmbTaxExempt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTaxExempt.Properties.NullText = "اختر الحالة"
        Me.cmbTaxExempt.Properties.ShowFooter = False
        Me.cmbTaxExempt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTaxExempt.Size = New System.Drawing.Size(165, 20)
        Me.cmbTaxExempt.TabIndex = 11
        '
        'cmbSupplierReceiptNo
        '
        Me.cmbSupplierReceiptNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSupplierReceiptNo.Location = New System.Drawing.Point(839, 91)
        Me.cmbSupplierReceiptNo.Name = "cmbSupplierReceiptNo"
        Me.cmbSupplierReceiptNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSupplierReceiptNo.Properties.NullText = "اختر رقم الفاتورة"
        Me.cmbSupplierReceiptNo.Properties.ShowFooter = False
        Me.cmbSupplierReceiptNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSupplierReceiptNo.Size = New System.Drawing.Size(165, 20)
        Me.cmbSupplierReceiptNo.TabIndex = 10
        '
        'cmbSupplier
        '
        Me.cmbSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSupplier.Location = New System.Drawing.Point(1004, 91)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSupplier.Properties.NullText = "اختر المورد"
        Me.cmbSupplier.Properties.ShowFooter = False
        Me.cmbSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSupplier.Size = New System.Drawing.Size(165, 20)
        Me.cmbSupplier.TabIndex = 9
        '
        'cmbCountryOfOrigin
        '
        Me.cmbCountryOfOrigin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbCountryOfOrigin.Location = New System.Drawing.Point(1169, 91)
        Me.cmbCountryOfOrigin.Name = "cmbCountryOfOrigin"
        Me.cmbCountryOfOrigin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCountryOfOrigin.Properties.NullText = "اختر بلد المنشأ"
        Me.cmbCountryOfOrigin.Properties.ShowFooter = False
        Me.cmbCountryOfOrigin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCountryOfOrigin.Size = New System.Drawing.Size(165, 20)
        Me.cmbCountryOfOrigin.TabIndex = 8
        '
        'cmbItemName
        '
        Me.cmbItemName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbItemName.Location = New System.Drawing.Point(1169, 45)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.[True]
        Me.cmbItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbItemName.Properties.NullText = ""
        Me.cmbItemName.Properties.ShowFooter = False
        Me.cmbItemName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbItemName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbItemName.Size = New System.Drawing.Size(165, 20)
        Me.cmbItemName.TabIndex = 0
        '
        'txtNote
        '
        Me.txtNote.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNote.Location = New System.Drawing.Point(179, 139)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(495, 20)
        Me.txtNote.TabIndex = 20
        '
        'dtpDateAdded
        '
        Me.dtpDateAdded.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDateAdded.EditValue = New Date(2023, 2, 18, 0, 0, 0, 0)
        Me.dtpDateAdded.Location = New System.Drawing.Point(179, 91)
        Me.dtpDateAdded.Name = "dtpDateAdded"
        Me.dtpDateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateAdded.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateAdded.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpDateAdded.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpDateAdded.Size = New System.Drawing.Size(165, 20)
        Me.dtpDateAdded.TabIndex = 14
        '
        'lblDocument
        '
        Me.lblDocument.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDocument.Appearance.Options.UseTextOptions = True
        Me.lblDocument.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblDocument.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblDocument.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDocument.Location = New System.Drawing.Point(14, 117)
        Me.lblDocument.Name = "lblDocument"
        Me.lblDocument.Size = New System.Drawing.Size(165, 19)
        Me.lblDocument.TabIndex = 102
        Me.lblDocument.Text = "مستندات / شهادات للقطعة"
        '
        'dtpDateOfManufacture
        '
        Me.dtpDateOfManufacture.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDateOfManufacture.EditValue = New Date(2023, 2, 18, 0, 0, 0, 0)
        Me.dtpDateOfManufacture.Location = New System.Drawing.Point(344, 91)
        Me.dtpDateOfManufacture.Name = "dtpDateOfManufacture"
        Me.dtpDateOfManufacture.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateOfManufacture.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateOfManufacture.Properties.MaskSettings.Set("culture", "")
        Me.dtpDateOfManufacture.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpDateOfManufacture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpDateOfManufacture.Size = New System.Drawing.Size(165, 20)
        Me.dtpDateOfManufacture.TabIndex = 13
        '
        'txtBarCode
        '
        Me.txtBarCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtBarCode.Location = New System.Drawing.Point(674, 139)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBarCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtBarCode.Size = New System.Drawing.Size(165, 20)
        Me.txtBarCode.TabIndex = 19
        '
        'txtCostPerPiece
        '
        Me.txtCostPerPiece.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCostPerPiece.Location = New System.Drawing.Point(14, 45)
        Me.txtCostPerPiece.Name = "txtCostPerPiece"
        Me.txtCostPerPiece.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostPerPiece.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCostPerPiece.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCostPerPiece.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostPerPiece.Size = New System.Drawing.Size(165, 20)
        Me.txtCostPerPiece.TabIndex = 7
        '
        'txtSymbol
        '
        Me.txtSymbol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSymbol.Location = New System.Drawing.Point(839, 139)
        Me.txtSymbol.Name = "txtSymbol"
        Me.txtSymbol.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSymbol.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSymbol.Size = New System.Drawing.Size(165, 20)
        Me.txtSymbol.TabIndex = 18
        '
        'txtItemNo
        '
        Me.txtItemNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtItemNo.Location = New System.Drawing.Point(1004, 139)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtItemNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtItemNo.Size = New System.Drawing.Size(165, 20)
        Me.txtItemNo.TabIndex = 17
        '
        'lblPhoto
        '
        Me.lblPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPhoto.Appearance.Options.UseTextOptions = True
        Me.lblPhoto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblPhoto.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblPhoto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPhoto.Location = New System.Drawing.Point(14, 71)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(165, 19)
        Me.lblPhoto.TabIndex = 102
        Me.lblPhoto.Text = "صورة القطعة"
        '
        'txtNoOfPieces
        '
        Me.txtNoOfPieces.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNoOfPieces.Location = New System.Drawing.Point(1169, 139)
        Me.txtNoOfPieces.Name = "txtNoOfPieces"
        Me.txtNoOfPieces.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNoOfPieces.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNoOfPieces.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtNoOfPieces.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoOfPieces.Size = New System.Drawing.Size(165, 20)
        Me.txtNoOfPieces.TabIndex = 16
        '
        'txtGramCost
        '
        Me.txtGramCost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtGramCost.Location = New System.Drawing.Point(179, 45)
        Me.txtGramCost.Name = "txtGramCost"
        Me.txtGramCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGramCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtGramCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtGramCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGramCost.Size = New System.Drawing.Size(165, 20)
        Me.txtGramCost.TabIndex = 6
        '
        'lblCostPerPiece
        '
        Me.lblCostPerPiece.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCostPerPiece.Appearance.Options.UseTextOptions = True
        Me.lblCostPerPiece.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCostPerPiece.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCostPerPiece.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCostPerPiece.Location = New System.Drawing.Point(14, 26)
        Me.lblCostPerPiece.Name = "lblCostPerPiece"
        Me.lblCostPerPiece.Size = New System.Drawing.Size(165, 19)
        Me.lblCostPerPiece.TabIndex = 102
        Me.lblCostPerPiece.Text = "سعر شراء القطعة"
        '
        'txtCostForSeller
        '
        Me.txtCostForSeller.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCostForSeller.Location = New System.Drawing.Point(344, 45)
        Me.txtCostForSeller.Name = "txtCostForSeller"
        Me.txtCostForSeller.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostForSeller.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCostForSeller.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCostForSeller.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostForSeller.Size = New System.Drawing.Size(165, 20)
        Me.txtCostForSeller.TabIndex = 5
        '
        'lblDateAdded
        '
        Me.lblDateAdded.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDateAdded.Appearance.Options.UseTextOptions = True
        Me.lblDateAdded.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblDateAdded.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblDateAdded.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDateAdded.Location = New System.Drawing.Point(179, 71)
        Me.lblDateAdded.Name = "lblDateAdded"
        Me.lblDateAdded.Size = New System.Drawing.Size(165, 19)
        Me.lblDateAdded.TabIndex = 102
        Me.lblDateAdded.Text = "تاريخ الإدخال"
        '
        'txtCostPerGram
        '
        Me.txtCostPerGram.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCostPerGram.Location = New System.Drawing.Point(509, 45)
        Me.txtCostPerGram.Name = "txtCostPerGram"
        Me.txtCostPerGram.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostPerGram.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCostPerGram.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCostPerGram.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostPerGram.Size = New System.Drawing.Size(165, 20)
        Me.txtCostPerGram.TabIndex = 4
        '
        'lblGramCost
        '
        Me.lblGramCost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblGramCost.Appearance.Options.UseTextOptions = True
        Me.lblGramCost.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblGramCost.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblGramCost.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblGramCost.Location = New System.Drawing.Point(179, 26)
        Me.lblGramCost.Name = "lblGramCost"
        Me.lblGramCost.Size = New System.Drawing.Size(165, 19)
        Me.lblGramCost.TabIndex = 102
        Me.lblGramCost.Text = "سعر الجرام عند الشراء"
        '
        'txtMakingCharge
        '
        Me.txtMakingCharge.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMakingCharge.Location = New System.Drawing.Point(674, 45)
        Me.txtMakingCharge.Name = "txtMakingCharge"
        Me.txtMakingCharge.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMakingCharge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMakingCharge.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtMakingCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMakingCharge.Size = New System.Drawing.Size(165, 20)
        Me.txtMakingCharge.TabIndex = 3
        '
        'lblDateOfManufacture
        '
        Me.lblDateOfManufacture.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDateOfManufacture.Appearance.Options.UseTextOptions = True
        Me.lblDateOfManufacture.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblDateOfManufacture.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblDateOfManufacture.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDateOfManufacture.Location = New System.Drawing.Point(344, 71)
        Me.lblDateOfManufacture.Name = "lblDateOfManufacture"
        Me.lblDateOfManufacture.Size = New System.Drawing.Size(165, 19)
        Me.lblDateOfManufacture.TabIndex = 102
        Me.lblDateOfManufacture.Text = "تاريخ الصنع"
        '
        'txtGoldWeight
        '
        Me.txtGoldWeight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtGoldWeight.Location = New System.Drawing.Point(839, 45)
        Me.txtGoldWeight.Name = "txtGoldWeight"
        Me.txtGoldWeight.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGoldWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtGoldWeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtGoldWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGoldWeight.Size = New System.Drawing.Size(165, 20)
        Me.txtGoldWeight.TabIndex = 2
        '
        'lblCostForSeller
        '
        Me.lblCostForSeller.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCostForSeller.Appearance.Options.UseTextOptions = True
        Me.lblCostForSeller.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCostForSeller.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCostForSeller.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCostForSeller.Location = New System.Drawing.Point(344, 26)
        Me.lblCostForSeller.Name = "lblCostForSeller"
        Me.lblCostForSeller.Size = New System.Drawing.Size(165, 19)
        Me.lblCostForSeller.TabIndex = 102
        Me.lblCostForSeller.Text = "تكلفة للبائع"
        '
        'lblNote
        '
        Me.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNote.Appearance.Options.UseTextOptions = True
        Me.lblNote.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNote.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNote.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNote.Location = New System.Drawing.Point(179, 117)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(495, 19)
        Me.lblNote.TabIndex = 102
        Me.lblNote.Text = "ملاحظات"
        '
        'lblItemCondition
        '
        Me.lblItemCondition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblItemCondition.Appearance.Options.UseTextOptions = True
        Me.lblItemCondition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblItemCondition.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblItemCondition.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblItemCondition.Location = New System.Drawing.Point(509, 71)
        Me.lblItemCondition.Name = "lblItemCondition"
        Me.lblItemCondition.Size = New System.Drawing.Size(165, 19)
        Me.lblItemCondition.TabIndex = 102
        Me.lblItemCondition.Text = "حالة القطعة"
        '
        'lblCostPerGram
        '
        Me.lblCostPerGram.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCostPerGram.Appearance.Options.UseTextOptions = True
        Me.lblCostPerGram.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCostPerGram.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCostPerGram.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCostPerGram.Location = New System.Drawing.Point(509, 26)
        Me.lblCostPerGram.Name = "lblCostPerGram"
        Me.lblCostPerGram.Size = New System.Drawing.Size(165, 19)
        Me.lblCostPerGram.TabIndex = 102
        Me.lblCostPerGram.Text = "تكلفة الشراء للجرام"
        '
        'lblBarCode
        '
        Me.lblBarCode.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBarCode.Appearance.Options.UseTextOptions = True
        Me.lblBarCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblBarCode.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblBarCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblBarCode.Location = New System.Drawing.Point(674, 117)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(165, 19)
        Me.lblBarCode.TabIndex = 102
        Me.lblBarCode.Text = "الباركود"
        '
        'lblTaxExempt
        '
        Me.lblTaxExempt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTaxExempt.Appearance.Options.UseTextOptions = True
        Me.lblTaxExempt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTaxExempt.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblTaxExempt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTaxExempt.Location = New System.Drawing.Point(674, 71)
        Me.lblTaxExempt.Name = "lblTaxExempt"
        Me.lblTaxExempt.Size = New System.Drawing.Size(165, 19)
        Me.lblTaxExempt.TabIndex = 102
        Me.lblTaxExempt.Text = "حالة الإعفاء الضريبي"
        '
        'lblMakingCharge
        '
        Me.lblMakingCharge.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMakingCharge.Appearance.Options.UseTextOptions = True
        Me.lblMakingCharge.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblMakingCharge.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblMakingCharge.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMakingCharge.Location = New System.Drawing.Point(674, 26)
        Me.lblMakingCharge.Name = "lblMakingCharge"
        Me.lblMakingCharge.Size = New System.Drawing.Size(165, 19)
        Me.lblMakingCharge.TabIndex = 102
        Me.lblMakingCharge.Text = "مصنعية البيع / جرام"
        '
        'lblSymbol
        '
        Me.lblSymbol.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSymbol.Appearance.Options.UseTextOptions = True
        Me.lblSymbol.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblSymbol.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblSymbol.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSymbol.Location = New System.Drawing.Point(839, 117)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(165, 19)
        Me.lblSymbol.TabIndex = 102
        Me.lblSymbol.Text = "رمز القطعة"
        '
        'lblSupplierInvoiceNo
        '
        Me.lblSupplierInvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSupplierInvoiceNo.Appearance.Options.UseTextOptions = True
        Me.lblSupplierInvoiceNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblSupplierInvoiceNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblSupplierInvoiceNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSupplierInvoiceNo.Location = New System.Drawing.Point(839, 71)
        Me.lblSupplierInvoiceNo.Name = "lblSupplierInvoiceNo"
        Me.lblSupplierInvoiceNo.Size = New System.Drawing.Size(165, 19)
        Me.lblSupplierInvoiceNo.TabIndex = 102
        Me.lblSupplierInvoiceNo.Text = "رقم فاتورة المورد"
        '
        'lblGoldWeight
        '
        Me.lblGoldWeight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblGoldWeight.Appearance.Options.UseTextOptions = True
        Me.lblGoldWeight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblGoldWeight.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblGoldWeight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblGoldWeight.Location = New System.Drawing.Point(839, 26)
        Me.lblGoldWeight.Name = "lblGoldWeight"
        Me.lblGoldWeight.Size = New System.Drawing.Size(165, 19)
        Me.lblGoldWeight.TabIndex = 102
        Me.lblGoldWeight.Text = "وزن الذهب"
        '
        'lblItemNo
        '
        Me.lblItemNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblItemNo.Appearance.Options.UseTextOptions = True
        Me.lblItemNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblItemNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblItemNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblItemNo.Location = New System.Drawing.Point(1004, 117)
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.Size = New System.Drawing.Size(165, 19)
        Me.lblItemNo.TabIndex = 102
        Me.lblItemNo.Text = "رقم القطعة"
        '
        'lblSupplier
        '
        Me.lblSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSupplier.Appearance.Options.UseTextOptions = True
        Me.lblSupplier.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblSupplier.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblSupplier.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSupplier.Location = New System.Drawing.Point(1004, 71)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(165, 19)
        Me.lblSupplier.TabIndex = 102
        Me.lblSupplier.Text = "المورد"
        '
        'lblKarat
        '
        Me.lblKarat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblKarat.Appearance.Options.UseTextOptions = True
        Me.lblKarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblKarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblKarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblKarat.Location = New System.Drawing.Point(1004, 26)
        Me.lblKarat.Name = "lblKarat"
        Me.lblKarat.Size = New System.Drawing.Size(165, 19)
        Me.lblKarat.TabIndex = 102
        Me.lblKarat.Text = "عيار الذهب"
        '
        'lblNoOfPieces
        '
        Me.lblNoOfPieces.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNoOfPieces.Appearance.Options.UseTextOptions = True
        Me.lblNoOfPieces.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNoOfPieces.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNoOfPieces.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNoOfPieces.Location = New System.Drawing.Point(1169, 117)
        Me.lblNoOfPieces.Name = "lblNoOfPieces"
        Me.lblNoOfPieces.Size = New System.Drawing.Size(165, 19)
        Me.lblNoOfPieces.TabIndex = 102
        Me.lblNoOfPieces.Text = "عدد القطع"
        '
        'lblCountryOfOrigin
        '
        Me.lblCountryOfOrigin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCountryOfOrigin.Appearance.Options.UseTextOptions = True
        Me.lblCountryOfOrigin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCountryOfOrigin.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCountryOfOrigin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCountryOfOrigin.Location = New System.Drawing.Point(1169, 71)
        Me.lblCountryOfOrigin.Name = "lblCountryOfOrigin"
        Me.lblCountryOfOrigin.Size = New System.Drawing.Size(165, 19)
        Me.lblCountryOfOrigin.TabIndex = 102
        Me.lblCountryOfOrigin.Text = "بلد المنشأ"
        '
        'lblItemName
        '
        Me.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblItemName.Appearance.Options.UseTextOptions = True
        Me.lblItemName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblItemName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblItemName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblItemName.Location = New System.Drawing.Point(1169, 26)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(165, 19)
        Me.lblItemName.TabIndex = 102
        Me.lblItemName.Text = "اسم الصنف"
        '
        'txtDocumentPath
        '
        Me.txtDocumentPath.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDocumentPath.Location = New System.Drawing.Point(14, 137)
        Me.txtDocumentPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDocumentPath.Name = "txtDocumentPath"
        Me.txtDocumentPath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentPath.Properties.Appearance.Options.UseFont = True
        Me.txtDocumentPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDocumentPath.Size = New System.Drawing.Size(165, 22)
        Me.txtDocumentPath.TabIndex = 15
        '
        'txtImagePath
        '
        Me.txtImagePath.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtImagePath.Location = New System.Drawing.Point(14, 90)
        Me.txtImagePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagePath.Properties.Appearance.Options.UseFont = True
        Me.txtImagePath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImagePath.Size = New System.Drawing.Size(165, 22)
        Me.txtImagePath.TabIndex = 15
        '
        'gbStoneData
        '
        Me.gbStoneData.Controls.Add(Me.DGVStone1)
        Me.gbStoneData.Controls.Add(Me.pbAddStone)
        Me.gbStoneData.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbStoneData.Location = New System.Drawing.Point(0, 166)
        Me.gbStoneData.Name = "gbStoneData"
        Me.gbStoneData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbStoneData.Size = New System.Drawing.Size(1350, 115)
        Me.gbStoneData.TabIndex = 1
        Me.gbStoneData.Text = "بيانات الفصوص"
        '
        'DGVStone1
        '
        Me.DGVStone1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVStone1.Location = New System.Drawing.Point(2, 23)
        Me.DGVStone1.MainView = Me.GridView1
        Me.DGVStone1.Name = "DGVStone1"
        Me.DGVStone1.Size = New System.Drawing.Size(1346, 90)
        Me.DGVStone1.TabIndex = 102
        Me.DGVStone1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGVStone1
        Me.GridView1.Name = "GridView1"
        '
        'DgvStone
        '
        Me.DgvStone.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStoneCode, Me.colStoneSerial, Me.colStoneType, Me.colStoneName, Me.colStoneWeight, Me.colStoneColor, Me.colStoneClarity, Me.colStoneCut, Me.colStonePrice, Me.colStoneView})
        Me.DgvStone.Name = "DgvStone"
        Me.DgvStone.OptionsView.ShowGroupPanel = False
        '
        'colStoneCode
        '
        Me.colStoneCode.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneCode.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneCode.Caption = "StoneCode"
        Me.colStoneCode.Name = "colStoneCode"
        '
        'colStoneSerial
        '
        Me.colStoneSerial.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneSerial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneSerial.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneSerial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneSerial.Caption = "م"
        Me.colStoneSerial.Name = "colStoneSerial"
        Me.colStoneSerial.Visible = True
        Me.colStoneSerial.VisibleIndex = 0
        '
        'colStoneType
        '
        Me.colStoneType.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneType.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneType.Caption = "نوع الفص"
        Me.colStoneType.Name = "colStoneType"
        Me.colStoneType.Visible = True
        Me.colStoneType.VisibleIndex = 1
        '
        'colStoneName
        '
        Me.colStoneName.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneName.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneName.Caption = "اسم الفص"
        Me.colStoneName.Name = "colStoneName"
        Me.colStoneName.Visible = True
        Me.colStoneName.VisibleIndex = 2
        '
        'colStoneWeight
        '
        Me.colStoneWeight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneWeight.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneWeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneWeight.Caption = "وزن الفص"
        Me.colStoneWeight.Name = "colStoneWeight"
        Me.colStoneWeight.Visible = True
        Me.colStoneWeight.VisibleIndex = 3
        '
        'colStoneColor
        '
        Me.colStoneColor.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneColor.Caption = "لون الفص"
        Me.colStoneColor.Name = "colStoneColor"
        Me.colStoneColor.Visible = True
        Me.colStoneColor.VisibleIndex = 4
        '
        'colStoneClarity
        '
        Me.colStoneClarity.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneClarity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneClarity.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneClarity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneClarity.Caption = "نقاوة الفص"
        Me.colStoneClarity.Name = "colStoneClarity"
        Me.colStoneClarity.Visible = True
        Me.colStoneClarity.VisibleIndex = 5
        '
        'colStoneCut
        '
        Me.colStoneCut.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneCut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneCut.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneCut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneCut.Caption = "قصة الفص"
        Me.colStoneCut.Name = "colStoneCut"
        Me.colStoneCut.Visible = True
        Me.colStoneCut.VisibleIndex = 6
        '
        'colStonePrice
        '
        Me.colStonePrice.AppearanceCell.Options.UseTextOptions = True
        Me.colStonePrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStonePrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colStonePrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStonePrice.Caption = "السعر"
        Me.colStonePrice.Name = "colStonePrice"
        Me.colStonePrice.Visible = True
        Me.colStonePrice.VisibleIndex = 7
        '
        'colStoneView
        '
        Me.colStoneView.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneView.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneView.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneView.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneView.Caption = "عرض المرفق"
        Me.colStoneView.Name = "colStoneView"
        Me.colStoneView.Visible = True
        Me.colStoneView.VisibleIndex = 8
        '
        'OFDX
        '
        Me.OFDX.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png, *.gif)|*.bmp, *.jpg, *.jpeg, *.png, *.g" &
    "if"
        Me.OFDX.RestoreDirectory = True
        '
        'EPX
        '
        Me.EPX.ContainerControl = Me
        '
        'UCGoldAddItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.gbStoneData)
        Me.Controls.Add(Me.gbItemData)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UCGoldAddItem"
        Me.Size = New System.Drawing.Size(1350, 283)
        CType(Me.pbAddStone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbItemData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItemData.ResumeLayout(False)
        CType(Me.cmbKarat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbItemCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTaxExempt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupplierReceiptNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountryOfOrigin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateAdded.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateOfManufacture.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateOfManufacture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBarCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostPerPiece.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSymbol.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoOfPieces.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGramCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostForSeller.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostPerGram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMakingCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGoldWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumentPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImagePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbStoneData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStoneData.ResumeLayout(False)
        CType(Me.DGVStone1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvStone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pbAddStone As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents gbItemData As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gbStoneData As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblItemName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCostPerPiece As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGramCost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCostForSeller As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCostPerGram As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMakingCharge As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGoldWeight As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblKarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPhoto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateAdded As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateOfManufacture As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblItemCondition As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTaxExempt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSupplierInvoiceNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSupplier As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCountryOfOrigin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDocument As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNote As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBarCode As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSymbol As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblItemNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNoOfPieces As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridStone As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvStone As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStoneCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneSerial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneClarity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneCut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStonePrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneView As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCostPerPiece As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGramCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCostForSeller As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCostPerGram As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMakingCharge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGoldWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpDateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDateOfManufacture As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNoOfPieces As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtItemNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSymbol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBarCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNote As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmbItemName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbKarat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbSupplier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbCountryOfOrigin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbItemCondition As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbTaxExempt As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbSupplierReceiptNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtImagePath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDocumentPath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents OFDX As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents EPX As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents DGVStone1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
