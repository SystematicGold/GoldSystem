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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.pbAddStone = New DevExpress.XtraEditors.PictureEdit()
        Me.gbItemData = New DevExpress.XtraEditors.GroupControl()
        Me.btnSave = New DevExpress.XtraEditors.DropDownButton()
        Me.mnubtnSave = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.btnSaveItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSaveMulti = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txtItemID = New DevExpress.XtraEditors.TextEdit()
        Me.pbNewItem = New DevExpress.XtraEditors.PictureEdit()
        Me.btnDocument = New DevExpress.XtraEditors.SimpleButton()
        Me.btnPhoto = New DevExpress.XtraEditors.SimpleButton()
        Me.pbDocument = New DevExpress.XtraEditors.PictureEdit()
        Me.pbPhoto = New DevExpress.XtraEditors.PictureEdit()
        Me.gbStoneData = New DevExpress.XtraEditors.GroupControl()
        Me.DGCStone = New DevExpress.XtraGrid.GridControl()
        Me.DgvStone = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneSerial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbStoneType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colStoneName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbStoneName = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colStoneWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneWeightType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbStoneWeightType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colStoneColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbStoneColor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colStoneClarity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbStoneClarity = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colStoneCut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbStoneCut = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colStoneCountryOfOrigin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbStoneCountryOfOrigin = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colStonePrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStonePhoto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneDocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoneEdit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnStoneEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colStoneDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnStoneDelete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnStonePhoto = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnStoneDocument = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.txtStoneEmpty = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cmbKarat = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbItemCondition = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbTaxExempt = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbSupplierInvoiceNo = New DevExpress.XtraEditors.LookUpEdit()
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
        Me.txtNumberOfPieces = New DevExpress.XtraEditors.TextEdit()
        Me.txtCostPerGramPurchase = New DevExpress.XtraEditors.TextEdit()
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
        Me.OFDX = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.EPX = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.pbAddStone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbItemData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItemData.SuspendLayout()
        CType(Me.mnubtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDocument.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbStoneData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStoneData.SuspendLayout()
        CType(Me.DGCStone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvStone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneWeightType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneClarity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneCut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneCountryOfOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStoneEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStoneDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStonePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStoneDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStoneEmpty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbKarat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbItemCondition.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTaxExempt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupplierInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtNumberOfPieces.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostPerGramPurchase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostForSeller.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostPerGram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMakingCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGoldWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EPX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAddStone
        '
        Me.pbAddStone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAddStone.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbAddStone.EditValue = CType(resources.GetObject("pbAddStone.EditValue"), Object)
        Me.pbAddStone.Location = New System.Drawing.Point(432, 1)
        Me.pbAddStone.Name = "pbAddStone"
        Me.pbAddStone.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbAddStone.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.pbAddStone.Properties.Appearance.Options.UseBackColor = True
        Me.pbAddStone.Properties.Appearance.Options.UseForeColor = True
        Me.pbAddStone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbAddStone.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pbAddStone.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbAddStone.Size = New System.Drawing.Size(20, 20)
        Me.pbAddStone.TabIndex = 101
        '
        'gbItemData
        '
        Me.gbItemData.Controls.Add(Me.btnSave)
        Me.gbItemData.Controls.Add(Me.txtItemID)
        Me.gbItemData.Controls.Add(Me.pbNewItem)
        Me.gbItemData.Controls.Add(Me.btnDocument)
        Me.gbItemData.Controls.Add(Me.btnPhoto)
        Me.gbItemData.Controls.Add(Me.pbDocument)
        Me.gbItemData.Controls.Add(Me.pbPhoto)
        Me.gbItemData.Controls.Add(Me.gbStoneData)
        Me.gbItemData.Controls.Add(Me.cmbKarat)
        Me.gbItemData.Controls.Add(Me.cmbItemCondition)
        Me.gbItemData.Controls.Add(Me.cmbTaxExempt)
        Me.gbItemData.Controls.Add(Me.cmbSupplierInvoiceNo)
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
        Me.gbItemData.Controls.Add(Me.txtNumberOfPieces)
        Me.gbItemData.Controls.Add(Me.txtCostPerGramPurchase)
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
        Me.gbItemData.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbItemData.Location = New System.Drawing.Point(0, 0)
        Me.gbItemData.Name = "gbItemData"
        Me.gbItemData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbItemData.Size = New System.Drawing.Size(1350, 183)
        Me.gbItemData.TabIndex = 0
        Me.gbItemData.Text = "بيانات القطعة"
        '
        'btnSave
        '
        Me.btnSave.DropDownControl = Me.mnubtnSave
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(6, 145)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 29)
        Me.btnSave.TabIndex = 108
        Me.btnSave.Text = "حفظ"
        '
        'mnubtnSave
        '
        Me.mnubtnSave.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveItem), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveMulti)})
        Me.mnubtnSave.Manager = Me.BarManager1
        Me.mnubtnSave.Name = "mnubtnSave"
        '
        'btnSaveItem
        '
        Me.btnSaveItem.Caption = "حفظ"
        Me.btnSaveItem.Id = 0
        Me.btnSaveItem.ImageOptions.Image = CType(resources.GetObject("btnSaveItem.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaveItem.ImageOptions.LargeImage = CType(resources.GetObject("btnSaveItem.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Tag = "SaveItem"
        '
        'btnSaveMulti
        '
        Me.btnSaveMulti.Caption = "حفظ متكرر"
        Me.btnSaveMulti.Id = 1
        Me.btnSaveMulti.ImageOptions.Image = CType(resources.GetObject("btnSaveMulti.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSaveMulti.ImageOptions.LargeImage = CType(resources.GetObject("btnSaveMulti.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSaveMulti.Name = "btnSaveMulti"
        Me.btnSaveMulti.Tag = "SaveMulti"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnSaveItem, Me.btnSaveMulti})
        Me.BarManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1350, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 183)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1350, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 183)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1350, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 183)
        '
        'txtItemID
        '
        Me.txtItemID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemID.Location = New System.Drawing.Point(1050, 26)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtItemID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtItemID.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtItemID.Properties.MaskSettings.Set("mask", "d")
        Me.txtItemID.Properties.MaskSettings.Set("culture", Nothing)
        Me.txtItemID.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null)
        Me.txtItemID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtItemID.Size = New System.Drawing.Size(5, 20)
        Me.txtItemID.TabIndex = 107
        Me.txtItemID.Visible = False
        '
        'pbNewItem
        '
        Me.pbNewItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbNewItem.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbNewItem.EditValue = CType(resources.GetObject("pbNewItem.EditValue"), Object)
        Me.pbNewItem.Location = New System.Drawing.Point(1239, 1)
        Me.pbNewItem.Name = "pbNewItem"
        Me.pbNewItem.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbNewItem.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.pbNewItem.Properties.Appearance.Options.UseBackColor = True
        Me.pbNewItem.Properties.Appearance.Options.UseForeColor = True
        Me.pbNewItem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbNewItem.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pbNewItem.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbNewItem.Size = New System.Drawing.Size(20, 20)
        Me.pbNewItem.TabIndex = 106
        '
        'btnDocument
        '
        Me.btnDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDocument.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.btnDocument.Appearance.Options.UseBorderColor = True
        Me.btnDocument.ImageOptions.Image = CType(resources.GetObject("btnDocument.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDocument.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnDocument.Location = New System.Drawing.Point(672, 146)
        Me.btnDocument.Name = "btnDocument"
        Me.btnDocument.Size = New System.Drawing.Size(20, 20)
        Me.btnDocument.TabIndex = 105
        '
        'btnPhoto
        '
        Me.btnPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPhoto.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.btnPhoto.Appearance.Options.UseBorderColor = True
        Me.btnPhoto.ImageOptions.Image = CType(resources.GetObject("btnPhoto.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPhoto.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnPhoto.Location = New System.Drawing.Point(672, 126)
        Me.btnPhoto.Name = "btnPhoto"
        Me.btnPhoto.Size = New System.Drawing.Size(20, 20)
        Me.btnPhoto.TabIndex = 105
        '
        'pbDocument
        '
        Me.pbDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbDocument.Location = New System.Drawing.Point(565, 146)
        Me.pbDocument.Name = "pbDocument"
        Me.pbDocument.Properties.NullText = "-"
        Me.pbDocument.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.pbDocument.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbDocument.Size = New System.Drawing.Size(108, 20)
        Me.pbDocument.TabIndex = 104
        '
        'pbPhoto
        '
        Me.pbPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPhoto.Location = New System.Drawing.Point(565, 126)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Properties.NullText = "-"
        Me.pbPhoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.pbPhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbPhoto.Size = New System.Drawing.Size(108, 20)
        Me.pbPhoto.TabIndex = 104
        '
        'gbStoneData
        '
        Me.gbStoneData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbStoneData.Controls.Add(Me.DGCStone)
        Me.gbStoneData.Controls.Add(Me.pbAddStone)
        Me.gbStoneData.Location = New System.Drawing.Point(6, 26)
        Me.gbStoneData.Name = "gbStoneData"
        Me.gbStoneData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbStoneData.Size = New System.Drawing.Size(553, 115)
        Me.gbStoneData.TabIndex = 1
        Me.gbStoneData.Text = "بيانات الفصوص"
        '
        'DGCStone
        '
        Me.DGCStone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGCStone.Location = New System.Drawing.Point(2, 23)
        Me.DGCStone.MainView = Me.DgvStone
        Me.DGCStone.Name = "DGCStone"
        Me.DGCStone.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbStoneName, Me.cmbStoneType, Me.cmbStoneWeightType, Me.cmbStoneColor, Me.cmbStoneClarity, Me.cmbStoneCut, Me.cmbStoneCountryOfOrigin, Me.btnStonePhoto, Me.btnStoneDocument, Me.btnStoneDelete, Me.btnStoneEdit, Me.txtStoneEmpty})
        Me.DGCStone.Size = New System.Drawing.Size(549, 90)
        Me.DGCStone.TabIndex = 102
        Me.DGCStone.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DgvStone})
        '
        'DgvStone
        '
        Me.DgvStone.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colStoneSerial, Me.colStoneType, Me.colStoneName, Me.colStoneWeight, Me.colStoneWeightType, Me.colStoneColor, Me.colStoneClarity, Me.colStoneCut, Me.colStoneCountryOfOrigin, Me.colStonePrice, Me.colStonePhoto, Me.colStoneDocument, Me.colStoneEdit, Me.colStoneDelete})
        Me.DgvStone.GridControl = Me.DGCStone
        Me.DgvStone.Name = "DgvStone"
        Me.DgvStone.OptionsView.ColumnAutoWidth = False
        Me.DgvStone.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.AppearanceCell.Options.UseTextOptions = True
        Me.colID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colID.AppearanceHeader.Options.UseTextOptions = True
        Me.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colStoneSerial
        '
        Me.colStoneSerial.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneSerial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneSerial.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneSerial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneSerial.Caption = "م"
        Me.colStoneSerial.FieldName = "StoneSerial"
        Me.colStoneSerial.Name = "colStoneSerial"
        Me.colStoneSerial.OptionsColumn.AllowEdit = False
        '
        'colStoneType
        '
        Me.colStoneType.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneType.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneType.Caption = "النوع"
        Me.colStoneType.ColumnEdit = Me.cmbStoneType
        Me.colStoneType.FieldName = "StoneTypeCode"
        Me.colStoneType.Name = "colStoneType"
        Me.colStoneType.OptionsColumn.AllowEdit = False
        Me.colStoneType.Visible = True
        Me.colStoneType.VisibleIndex = 0
        '
        'cmbStoneType
        '
        Me.cmbStoneType.AutoHeight = False
        Me.cmbStoneType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneType.Name = "cmbStoneType"
        Me.cmbStoneType.NullText = ""
        '
        'colStoneName
        '
        Me.colStoneName.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneName.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneName.Caption = "الاسم"
        Me.colStoneName.ColumnEdit = Me.cmbStoneName
        Me.colStoneName.FieldName = "StoneNameCode"
        Me.colStoneName.Name = "colStoneName"
        Me.colStoneName.OptionsColumn.AllowEdit = False
        Me.colStoneName.Visible = True
        Me.colStoneName.VisibleIndex = 1
        '
        'cmbStoneName
        '
        Me.cmbStoneName.AutoHeight = False
        Me.cmbStoneName.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneName.Name = "cmbStoneName"
        Me.cmbStoneName.NullText = ""
        '
        'colStoneWeight
        '
        Me.colStoneWeight.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneWeight.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneWeight.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneWeight.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneWeight.Caption = "الوزن"
        Me.colStoneWeight.FieldName = "StoneWeight"
        Me.colStoneWeight.Name = "colStoneWeight"
        Me.colStoneWeight.OptionsColumn.AllowEdit = False
        Me.colStoneWeight.Visible = True
        Me.colStoneWeight.VisibleIndex = 2
        '
        'colStoneWeightType
        '
        Me.colStoneWeightType.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneWeightType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneWeightType.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneWeightType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneWeightType.Caption = "ق/جم"
        Me.colStoneWeightType.ColumnEdit = Me.cmbStoneWeightType
        Me.colStoneWeightType.FieldName = "StoneWeightType"
        Me.colStoneWeightType.Name = "colStoneWeightType"
        Me.colStoneWeightType.OptionsColumn.AllowEdit = False
        Me.colStoneWeightType.Visible = True
        Me.colStoneWeightType.VisibleIndex = 3
        '
        'cmbStoneWeightType
        '
        Me.cmbStoneWeightType.AutoHeight = False
        Me.cmbStoneWeightType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneWeightType.Name = "cmbStoneWeightType"
        Me.cmbStoneWeightType.NullText = ""
        '
        'colStoneColor
        '
        Me.colStoneColor.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneColor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneColor.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneColor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneColor.Caption = "اللون"
        Me.colStoneColor.ColumnEdit = Me.cmbStoneColor
        Me.colStoneColor.FieldName = "StoneColor"
        Me.colStoneColor.Name = "colStoneColor"
        Me.colStoneColor.OptionsColumn.AllowEdit = False
        Me.colStoneColor.Visible = True
        Me.colStoneColor.VisibleIndex = 4
        '
        'cmbStoneColor
        '
        Me.cmbStoneColor.AutoHeight = False
        Me.cmbStoneColor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneColor.Name = "cmbStoneColor"
        Me.cmbStoneColor.NullText = ""
        '
        'colStoneClarity
        '
        Me.colStoneClarity.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneClarity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneClarity.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneClarity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneClarity.Caption = "النقاوة"
        Me.colStoneClarity.ColumnEdit = Me.cmbStoneClarity
        Me.colStoneClarity.FieldName = "StoneClarity"
        Me.colStoneClarity.Name = "colStoneClarity"
        Me.colStoneClarity.OptionsColumn.AllowEdit = False
        Me.colStoneClarity.Visible = True
        Me.colStoneClarity.VisibleIndex = 5
        '
        'cmbStoneClarity
        '
        Me.cmbStoneClarity.AutoHeight = False
        Me.cmbStoneClarity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneClarity.Name = "cmbStoneClarity"
        Me.cmbStoneClarity.NullText = ""
        '
        'colStoneCut
        '
        Me.colStoneCut.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneCut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneCut.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneCut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneCut.Caption = "القصة"
        Me.colStoneCut.ColumnEdit = Me.cmbStoneCut
        Me.colStoneCut.FieldName = "StoneCut"
        Me.colStoneCut.Name = "colStoneCut"
        Me.colStoneCut.OptionsColumn.AllowEdit = False
        Me.colStoneCut.Visible = True
        Me.colStoneCut.VisibleIndex = 6
        '
        'cmbStoneCut
        '
        Me.cmbStoneCut.AutoHeight = False
        Me.cmbStoneCut.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneCut.Name = "cmbStoneCut"
        Me.cmbStoneCut.NullText = ""
        '
        'colStoneCountryOfOrigin
        '
        Me.colStoneCountryOfOrigin.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneCountryOfOrigin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneCountryOfOrigin.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneCountryOfOrigin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneCountryOfOrigin.Caption = "البلد"
        Me.colStoneCountryOfOrigin.ColumnEdit = Me.cmbStoneCountryOfOrigin
        Me.colStoneCountryOfOrigin.FieldName = "StoneCountryOfOrigin"
        Me.colStoneCountryOfOrigin.Name = "colStoneCountryOfOrigin"
        Me.colStoneCountryOfOrigin.OptionsColumn.AllowEdit = False
        Me.colStoneCountryOfOrigin.Visible = True
        Me.colStoneCountryOfOrigin.VisibleIndex = 7
        '
        'cmbStoneCountryOfOrigin
        '
        Me.cmbStoneCountryOfOrigin.AutoHeight = False
        Me.cmbStoneCountryOfOrigin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneCountryOfOrigin.Name = "cmbStoneCountryOfOrigin"
        Me.cmbStoneCountryOfOrigin.NullText = ""
        '
        'colStonePrice
        '
        Me.colStonePrice.AppearanceCell.Options.UseTextOptions = True
        Me.colStonePrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStonePrice.AppearanceHeader.Options.UseTextOptions = True
        Me.colStonePrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStonePrice.Caption = "السعر"
        Me.colStonePrice.FieldName = "StonePrice"
        Me.colStonePrice.Name = "colStonePrice"
        Me.colStonePrice.OptionsColumn.AllowEdit = False
        Me.colStonePrice.Visible = True
        Me.colStonePrice.VisibleIndex = 8
        '
        'colStonePhoto
        '
        Me.colStonePhoto.AppearanceCell.Options.UseTextOptions = True
        Me.colStonePhoto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStonePhoto.AppearanceHeader.Options.UseTextOptions = True
        Me.colStonePhoto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStonePhoto.Caption = "صورة"
        Me.colStonePhoto.FieldName = "StonePhoto"
        Me.colStonePhoto.Name = "colStonePhoto"
        Me.colStonePhoto.Visible = True
        Me.colStonePhoto.VisibleIndex = 9
        '
        'colStoneDocument
        '
        Me.colStoneDocument.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneDocument.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneDocument.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneDocument.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneDocument.Caption = "مستند"
        Me.colStoneDocument.FieldName = "StoneDocument"
        Me.colStoneDocument.Name = "colStoneDocument"
        Me.colStoneDocument.Visible = True
        Me.colStoneDocument.VisibleIndex = 10
        '
        'colStoneEdit
        '
        Me.colStoneEdit.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneEdit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneEdit.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneEdit.Caption = "تعديل"
        Me.colStoneEdit.ColumnEdit = Me.btnStoneEdit
        Me.colStoneEdit.Name = "colStoneEdit"
        Me.colStoneEdit.Visible = True
        Me.colStoneEdit.VisibleIndex = 11
        '
        'btnStoneEdit
        '
        Me.btnStoneEdit.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnStoneEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnStoneEdit.Name = "btnStoneEdit"
        Me.btnStoneEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colStoneDelete
        '
        Me.colStoneDelete.AppearanceCell.Options.UseTextOptions = True
        Me.colStoneDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneDelete.AppearanceHeader.Options.UseTextOptions = True
        Me.colStoneDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colStoneDelete.Caption = "حذف"
        Me.colStoneDelete.ColumnEdit = Me.btnStoneDelete
        Me.colStoneDelete.Name = "colStoneDelete"
        Me.colStoneDelete.Visible = True
        Me.colStoneDelete.VisibleIndex = 12
        '
        'btnStoneDelete
        '
        Me.btnStoneDelete.AutoHeight = False
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.btnStoneDelete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btnStoneDelete.Name = "btnStoneDelete"
        Me.btnStoneDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnStonePhoto
        '
        Me.btnStonePhoto.AutoHeight = False
        Me.btnStonePhoto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.btnStonePhoto.Name = "btnStonePhoto"
        Me.btnStonePhoto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnStoneDocument
        '
        Me.btnStoneDocument.AutoHeight = False
        Me.btnStoneDocument.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.btnStoneDocument.Name = "btnStoneDocument"
        Me.btnStoneDocument.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'txtStoneEmpty
        '
        Me.txtStoneEmpty.AutoHeight = False
        Me.txtStoneEmpty.Name = "txtStoneEmpty"
        '
        'cmbKarat
        '
        Me.cmbKarat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKarat.Location = New System.Drawing.Point(1056, 46)
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
        Me.cmbItemCondition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbItemCondition.Location = New System.Drawing.Point(565, 26)
        Me.cmbItemCondition.Name = "cmbItemCondition"
        Me.cmbItemCondition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbItemCondition.Properties.NullText = "اختر الحالة"
        Me.cmbItemCondition.Properties.ShowFooter = False
        Me.cmbItemCondition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbItemCondition.Size = New System.Drawing.Size(127, 20)
        Me.cmbItemCondition.TabIndex = 12
        '
        'cmbTaxExempt
        '
        Me.cmbTaxExempt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTaxExempt.Location = New System.Drawing.Point(565, 46)
        Me.cmbTaxExempt.Name = "cmbTaxExempt"
        Me.cmbTaxExempt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTaxExempt.Properties.NullText = "اختر الحالة"
        Me.cmbTaxExempt.Properties.ShowFooter = False
        Me.cmbTaxExempt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTaxExempt.Size = New System.Drawing.Size(127, 20)
        Me.cmbTaxExempt.TabIndex = 11
        '
        'cmbSupplierInvoiceNo
        '
        Me.cmbSupplierInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSupplierInvoiceNo.Location = New System.Drawing.Point(1056, 146)
        Me.cmbSupplierInvoiceNo.Name = "cmbSupplierInvoiceNo"
        Me.cmbSupplierInvoiceNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSupplierInvoiceNo.Properties.NullText = "اختر رقم الفاتورة"
        Me.cmbSupplierInvoiceNo.Properties.ShowFooter = False
        Me.cmbSupplierInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbSupplierInvoiceNo.Size = New System.Drawing.Size(165, 20)
        Me.cmbSupplierInvoiceNo.TabIndex = 10
        '
        'cmbSupplier
        '
        Me.cmbSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSupplier.Location = New System.Drawing.Point(1056, 126)
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
        Me.cmbCountryOfOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCountryOfOrigin.Location = New System.Drawing.Point(1056, 106)
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
        Me.cmbItemName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbItemName.Location = New System.Drawing.Point(1056, 26)
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
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.Location = New System.Drawing.Point(112, 145)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(346, 29)
        Me.txtNote.TabIndex = 20
        '
        'dtpDateAdded
        '
        Me.dtpDateAdded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateAdded.EditValue = Nothing
        Me.dtpDateAdded.Location = New System.Drawing.Point(565, 86)
        Me.dtpDateAdded.Name = "dtpDateAdded"
        Me.dtpDateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateAdded.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateAdded.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpDateAdded.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpDateAdded.Size = New System.Drawing.Size(127, 20)
        Me.dtpDateAdded.TabIndex = 14
        '
        'lblDocument
        '
        Me.lblDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDocument.Appearance.Options.UseTextOptions = True
        Me.lblDocument.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblDocument.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblDocument.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDocument.Location = New System.Drawing.Point(698, 146)
        Me.lblDocument.Name = "lblDocument"
        Me.lblDocument.Size = New System.Drawing.Size(127, 19)
        Me.lblDocument.TabIndex = 102
        Me.lblDocument.Text = "مستندات / شهادات للقطعة"
        '
        'dtpDateOfManufacture
        '
        Me.dtpDateOfManufacture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateOfManufacture.EditValue = Nothing
        Me.dtpDateOfManufacture.Location = New System.Drawing.Point(565, 66)
        Me.dtpDateOfManufacture.Name = "dtpDateOfManufacture"
        Me.dtpDateOfManufacture.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateOfManufacture.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateOfManufacture.Properties.MaskSettings.Set("culture", "")
        Me.dtpDateOfManufacture.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpDateOfManufacture.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpDateOfManufacture.Size = New System.Drawing.Size(127, 20)
        Me.dtpDateOfManufacture.TabIndex = 13
        '
        'txtBarCode
        '
        Me.txtBarCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarCode.Location = New System.Drawing.Point(565, 106)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBarCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtBarCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBarCode.Size = New System.Drawing.Size(127, 20)
        Me.txtBarCode.TabIndex = 19
        '
        'txtCostPerPiece
        '
        Me.txtCostPerPiece.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPerPiece.Location = New System.Drawing.Point(831, 146)
        Me.txtCostPerPiece.Name = "txtCostPerPiece"
        Me.txtCostPerPiece.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtCostPerPiece.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostPerPiece.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCostPerPiece.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCostPerPiece.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostPerPiece.Size = New System.Drawing.Size(86, 20)
        Me.txtCostPerPiece.TabIndex = 7
        '
        'txtSymbol
        '
        Me.txtSymbol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSymbol.Location = New System.Drawing.Point(831, 66)
        Me.txtSymbol.Name = "txtSymbol"
        Me.txtSymbol.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtSymbol.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSymbol.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSymbol.Size = New System.Drawing.Size(86, 20)
        Me.txtSymbol.TabIndex = 18
        '
        'txtItemNo
        '
        Me.txtItemNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemNo.Location = New System.Drawing.Point(831, 46)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtItemNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtItemNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtItemNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtItemNo.Size = New System.Drawing.Size(86, 20)
        Me.txtItemNo.TabIndex = 17
        '
        'lblPhoto
        '
        Me.lblPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPhoto.Appearance.Options.UseTextOptions = True
        Me.lblPhoto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblPhoto.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblPhoto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPhoto.Location = New System.Drawing.Point(698, 127)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(127, 19)
        Me.lblPhoto.TabIndex = 102
        Me.lblPhoto.Text = "صورة القطعة"
        '
        'txtNumberOfPieces
        '
        Me.txtNumberOfPieces.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumberOfPieces.Location = New System.Drawing.Point(831, 26)
        Me.txtNumberOfPieces.Name = "txtNumberOfPieces"
        Me.txtNumberOfPieces.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtNumberOfPieces.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumberOfPieces.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNumberOfPieces.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtNumberOfPieces.Properties.MaskSettings.Set("mask", "d")
        Me.txtNumberOfPieces.Properties.MaskSettings.Set("culture", Nothing)
        Me.txtNumberOfPieces.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.Null)
        Me.txtNumberOfPieces.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumberOfPieces.Size = New System.Drawing.Size(86, 20)
        Me.txtNumberOfPieces.TabIndex = 16
        '
        'txtCostPerGramPurchase
        '
        Me.txtCostPerGramPurchase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPerGramPurchase.Location = New System.Drawing.Point(831, 126)
        Me.txtCostPerGramPurchase.Name = "txtCostPerGramPurchase"
        Me.txtCostPerGramPurchase.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtCostPerGramPurchase.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostPerGramPurchase.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCostPerGramPurchase.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCostPerGramPurchase.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostPerGramPurchase.Size = New System.Drawing.Size(86, 20)
        Me.txtCostPerGramPurchase.TabIndex = 6
        '
        'lblCostPerPiece
        '
        Me.lblCostPerPiece.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCostPerPiece.Appearance.Options.UseTextOptions = True
        Me.lblCostPerPiece.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCostPerPiece.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCostPerPiece.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCostPerPiece.Location = New System.Drawing.Point(923, 147)
        Me.lblCostPerPiece.Name = "lblCostPerPiece"
        Me.lblCostPerPiece.Size = New System.Drawing.Size(127, 19)
        Me.lblCostPerPiece.TabIndex = 102
        Me.lblCostPerPiece.Text = "سعر شراء القطعة"
        '
        'txtCostForSeller
        '
        Me.txtCostForSeller.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostForSeller.Location = New System.Drawing.Point(831, 106)
        Me.txtCostForSeller.Name = "txtCostForSeller"
        Me.txtCostForSeller.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtCostForSeller.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostForSeller.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCostForSeller.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCostForSeller.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostForSeller.Size = New System.Drawing.Size(86, 20)
        Me.txtCostForSeller.TabIndex = 5
        '
        'lblDateAdded
        '
        Me.lblDateAdded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateAdded.Appearance.Options.UseTextOptions = True
        Me.lblDateAdded.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblDateAdded.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblDateAdded.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDateAdded.Location = New System.Drawing.Point(698, 87)
        Me.lblDateAdded.Name = "lblDateAdded"
        Me.lblDateAdded.Size = New System.Drawing.Size(127, 19)
        Me.lblDateAdded.TabIndex = 102
        Me.lblDateAdded.Text = "تاريخ الإدخال"
        '
        'txtCostPerGram
        '
        Me.txtCostPerGram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCostPerGram.Location = New System.Drawing.Point(831, 86)
        Me.txtCostPerGram.Name = "txtCostPerGram"
        Me.txtCostPerGram.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtCostPerGram.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCostPerGram.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCostPerGram.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCostPerGram.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCostPerGram.Size = New System.Drawing.Size(86, 20)
        Me.txtCostPerGram.TabIndex = 4
        '
        'lblGramCost
        '
        Me.lblGramCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGramCost.Appearance.Options.UseTextOptions = True
        Me.lblGramCost.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblGramCost.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblGramCost.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblGramCost.Location = New System.Drawing.Point(923, 127)
        Me.lblGramCost.Name = "lblGramCost"
        Me.lblGramCost.Size = New System.Drawing.Size(127, 19)
        Me.lblGramCost.TabIndex = 102
        Me.lblGramCost.Text = "سعر الجرام عند الشراء"
        '
        'txtMakingCharge
        '
        Me.txtMakingCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMakingCharge.Location = New System.Drawing.Point(1056, 86)
        Me.txtMakingCharge.Name = "txtMakingCharge"
        Me.txtMakingCharge.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtMakingCharge.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMakingCharge.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMakingCharge.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtMakingCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMakingCharge.Size = New System.Drawing.Size(165, 20)
        Me.txtMakingCharge.TabIndex = 3
        '
        'lblDateOfManufacture
        '
        Me.lblDateOfManufacture.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateOfManufacture.Appearance.Options.UseTextOptions = True
        Me.lblDateOfManufacture.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblDateOfManufacture.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblDateOfManufacture.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDateOfManufacture.Location = New System.Drawing.Point(698, 67)
        Me.lblDateOfManufacture.Name = "lblDateOfManufacture"
        Me.lblDateOfManufacture.Size = New System.Drawing.Size(127, 19)
        Me.lblDateOfManufacture.TabIndex = 102
        Me.lblDateOfManufacture.Text = "تاريخ الصنع"
        '
        'txtGoldWeight
        '
        Me.txtGoldWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGoldWeight.Location = New System.Drawing.Point(1056, 66)
        Me.txtGoldWeight.Name = "txtGoldWeight"
        Me.txtGoldWeight.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtGoldWeight.Properties.Appearance.Options.UseTextOptions = True
        Me.txtGoldWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtGoldWeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtGoldWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGoldWeight.Size = New System.Drawing.Size(165, 20)
        Me.txtGoldWeight.TabIndex = 2
        '
        'lblCostForSeller
        '
        Me.lblCostForSeller.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCostForSeller.Appearance.Options.UseTextOptions = True
        Me.lblCostForSeller.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCostForSeller.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCostForSeller.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCostForSeller.Location = New System.Drawing.Point(923, 107)
        Me.lblCostForSeller.Name = "lblCostForSeller"
        Me.lblCostForSeller.Size = New System.Drawing.Size(127, 19)
        Me.lblCostForSeller.TabIndex = 102
        Me.lblCostForSeller.Text = "تكلفة للبائع"
        '
        'lblNote
        '
        Me.lblNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNote.Appearance.Options.UseTextOptions = True
        Me.lblNote.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNote.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNote.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNote.Location = New System.Drawing.Point(456, 150)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(95, 19)
        Me.lblNote.TabIndex = 102
        Me.lblNote.Text = "ملاحظات"
        '
        'lblItemCondition
        '
        Me.lblItemCondition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemCondition.Appearance.Options.UseTextOptions = True
        Me.lblItemCondition.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblItemCondition.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblItemCondition.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblItemCondition.Location = New System.Drawing.Point(698, 27)
        Me.lblItemCondition.Name = "lblItemCondition"
        Me.lblItemCondition.Size = New System.Drawing.Size(127, 19)
        Me.lblItemCondition.TabIndex = 102
        Me.lblItemCondition.Text = "حالة القطعة"
        '
        'lblCostPerGram
        '
        Me.lblCostPerGram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCostPerGram.Appearance.Options.UseTextOptions = True
        Me.lblCostPerGram.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCostPerGram.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCostPerGram.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCostPerGram.Location = New System.Drawing.Point(923, 87)
        Me.lblCostPerGram.Name = "lblCostPerGram"
        Me.lblCostPerGram.Size = New System.Drawing.Size(127, 19)
        Me.lblCostPerGram.TabIndex = 102
        Me.lblCostPerGram.Text = "تكلفة الشراء للجرام"
        '
        'lblBarCode
        '
        Me.lblBarCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBarCode.Appearance.Options.UseTextOptions = True
        Me.lblBarCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblBarCode.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblBarCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblBarCode.Location = New System.Drawing.Point(698, 109)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(127, 19)
        Me.lblBarCode.TabIndex = 102
        Me.lblBarCode.Text = "الباركود"
        '
        'lblTaxExempt
        '
        Me.lblTaxExempt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTaxExempt.Appearance.Options.UseTextOptions = True
        Me.lblTaxExempt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTaxExempt.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblTaxExempt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTaxExempt.Location = New System.Drawing.Point(698, 47)
        Me.lblTaxExempt.Name = "lblTaxExempt"
        Me.lblTaxExempt.Size = New System.Drawing.Size(127, 19)
        Me.lblTaxExempt.TabIndex = 102
        Me.lblTaxExempt.Text = "حالة الإعفاء الضريبي"
        '
        'lblMakingCharge
        '
        Me.lblMakingCharge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMakingCharge.Appearance.Options.UseTextOptions = True
        Me.lblMakingCharge.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblMakingCharge.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblMakingCharge.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblMakingCharge.Location = New System.Drawing.Point(1218, 87)
        Me.lblMakingCharge.Name = "lblMakingCharge"
        Me.lblMakingCharge.Size = New System.Drawing.Size(127, 19)
        Me.lblMakingCharge.TabIndex = 102
        Me.lblMakingCharge.Text = "مصنعية البيع / جرام"
        '
        'lblSymbol
        '
        Me.lblSymbol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSymbol.Appearance.Options.UseTextOptions = True
        Me.lblSymbol.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblSymbol.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblSymbol.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSymbol.Location = New System.Drawing.Point(923, 67)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(127, 19)
        Me.lblSymbol.TabIndex = 102
        Me.lblSymbol.Text = "رمز القطعة"
        '
        'lblSupplierInvoiceNo
        '
        Me.lblSupplierInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSupplierInvoiceNo.Appearance.Options.UseTextOptions = True
        Me.lblSupplierInvoiceNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblSupplierInvoiceNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblSupplierInvoiceNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSupplierInvoiceNo.Location = New System.Drawing.Point(1218, 147)
        Me.lblSupplierInvoiceNo.Name = "lblSupplierInvoiceNo"
        Me.lblSupplierInvoiceNo.Size = New System.Drawing.Size(127, 19)
        Me.lblSupplierInvoiceNo.TabIndex = 102
        Me.lblSupplierInvoiceNo.Text = "رقم فاتورة المورد"
        '
        'lblGoldWeight
        '
        Me.lblGoldWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGoldWeight.Appearance.Options.UseTextOptions = True
        Me.lblGoldWeight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblGoldWeight.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblGoldWeight.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblGoldWeight.Location = New System.Drawing.Point(1218, 67)
        Me.lblGoldWeight.Name = "lblGoldWeight"
        Me.lblGoldWeight.Size = New System.Drawing.Size(127, 19)
        Me.lblGoldWeight.TabIndex = 102
        Me.lblGoldWeight.Text = "وزن الذهب"
        '
        'lblItemNo
        '
        Me.lblItemNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemNo.Appearance.Options.UseTextOptions = True
        Me.lblItemNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblItemNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblItemNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblItemNo.Location = New System.Drawing.Point(923, 47)
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.Size = New System.Drawing.Size(127, 19)
        Me.lblItemNo.TabIndex = 102
        Me.lblItemNo.Text = "رقم القطعة"
        '
        'lblSupplier
        '
        Me.lblSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSupplier.Appearance.Options.UseTextOptions = True
        Me.lblSupplier.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblSupplier.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblSupplier.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSupplier.Location = New System.Drawing.Point(1218, 127)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(127, 19)
        Me.lblSupplier.TabIndex = 102
        Me.lblSupplier.Text = "المورد"
        '
        'lblKarat
        '
        Me.lblKarat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKarat.Appearance.Options.UseTextOptions = True
        Me.lblKarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblKarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblKarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblKarat.Location = New System.Drawing.Point(1218, 47)
        Me.lblKarat.Name = "lblKarat"
        Me.lblKarat.Size = New System.Drawing.Size(127, 19)
        Me.lblKarat.TabIndex = 102
        Me.lblKarat.Text = "عيار الذهب"
        '
        'lblNoOfPieces
        '
        Me.lblNoOfPieces.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoOfPieces.Appearance.Options.UseTextOptions = True
        Me.lblNoOfPieces.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblNoOfPieces.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblNoOfPieces.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNoOfPieces.Location = New System.Drawing.Point(923, 27)
        Me.lblNoOfPieces.Name = "lblNoOfPieces"
        Me.lblNoOfPieces.Size = New System.Drawing.Size(127, 19)
        Me.lblNoOfPieces.TabIndex = 102
        Me.lblNoOfPieces.Text = "عدد القطع"
        '
        'lblCountryOfOrigin
        '
        Me.lblCountryOfOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCountryOfOrigin.Appearance.Options.UseTextOptions = True
        Me.lblCountryOfOrigin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblCountryOfOrigin.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblCountryOfOrigin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCountryOfOrigin.Location = New System.Drawing.Point(1218, 107)
        Me.lblCountryOfOrigin.Name = "lblCountryOfOrigin"
        Me.lblCountryOfOrigin.Size = New System.Drawing.Size(127, 19)
        Me.lblCountryOfOrigin.TabIndex = 102
        Me.lblCountryOfOrigin.Text = "بلد المنشأ"
        '
        'lblItemName
        '
        Me.lblItemName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemName.Appearance.Options.UseTextOptions = True
        Me.lblItemName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblItemName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblItemName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblItemName.Location = New System.Drawing.Point(1218, 27)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(127, 19)
        Me.lblItemName.TabIndex = 102
        Me.lblItemName.Text = "اسم الصنف"
        '
        'OFDX
        '
        Me.OFDX.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG"
        Me.OFDX.RestoreDirectory = True
        '
        'EPX
        '
        Me.EPX.ContainerControl = Me
        '
        'UCGoldAddItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.gbItemData)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "UCGoldAddItem"
        Me.Size = New System.Drawing.Size(1350, 183)
        CType(Me.pbAddStone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbItemData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItemData.ResumeLayout(False)
        CType(Me.mnubtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDocument.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbStoneData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStoneData.ResumeLayout(False)
        CType(Me.DGCStone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvStone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneWeightType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneClarity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneCut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneCountryOfOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStoneEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStoneDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStonePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStoneDocument, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStoneEmpty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbKarat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbItemCondition.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTaxExempt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupplierInvoiceNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtNumberOfPieces.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostPerGramPurchase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostForSeller.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostPerGram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMakingCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGoldWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EPX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents DGCStone As DevExpress.XtraGrid.GridControl
    Friend WithEvents DgvStone As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStoneSerial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneClarity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneCut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStonePrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneDocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCostPerPiece As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCostPerGramPurchase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCostForSeller As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCostPerGram As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMakingCharge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtGoldWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpDateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpDateOfManufacture As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumberOfPieces As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents cmbSupplierInvoiceNo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents OFDX As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents EPX As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents colStonePhoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneWeightType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneCountryOfOrigin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbStoneName As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStoneType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStoneWeightType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStoneColor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStoneClarity As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStoneCut As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStoneCountryOfOrigin As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnStonePhoto As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnStoneDocument As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents pbDocument As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pbPhoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnPhoto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDocument As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pbNewItem As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtItemID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoneDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnStoneDelete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnStoneEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colStoneEdit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtStoneEmpty As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnSaveItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveMulti As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnubtnSave As DevExpress.XtraBars.PopupMenu
End Class
