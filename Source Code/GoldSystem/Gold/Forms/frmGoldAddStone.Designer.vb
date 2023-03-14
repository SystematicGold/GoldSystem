<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGoldAddStone
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGoldAddStone))
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lblStoneCountryOfOrigin = New DevExpress.XtraEditors.LabelControl()
        Me.lblStoneCut = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblStoneType = New DevExpress.XtraEditors.LabelControl()
        Me.lblStoneName = New DevExpress.XtraEditors.LabelControl()
        Me.txtWeight = New DevExpress.XtraEditors.TextEdit()
        Me.txtStonePrice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbStoneType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbStoneName = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbStoneWeightType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbStoneColor = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbStoneClarity = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbStoneCut = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbStoneCountryOfOrigin = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.OFDX = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.btnStonePhoto = New DevExpress.XtraEditors.SimpleButton()
        Me.pbStonePhoto = New DevExpress.XtraEditors.PictureEdit()
        Me.pbStoneDocument = New DevExpress.XtraEditors.PictureEdit()
        Me.btnStoneDocument = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStonePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneWeightType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneClarity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneCut.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStoneCountryOfOrigin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStonePhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStoneDocument.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(315, 60)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(101, 20)
        Me.LabelControl7.TabIndex = 151
        Me.LabelControl7.Text = "سعر الفص"
        '
        'lblStoneCountryOfOrigin
        '
        Me.lblStoneCountryOfOrigin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStoneCountryOfOrigin.Appearance.Options.UseTextOptions = True
        Me.lblStoneCountryOfOrigin.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblStoneCountryOfOrigin.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblStoneCountryOfOrigin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStoneCountryOfOrigin.Location = New System.Drawing.Point(416, 60)
        Me.lblStoneCountryOfOrigin.Name = "lblStoneCountryOfOrigin"
        Me.lblStoneCountryOfOrigin.Size = New System.Drawing.Size(101, 20)
        Me.lblStoneCountryOfOrigin.TabIndex = 152
        Me.lblStoneCountryOfOrigin.Text = "بلد المنشأ للفص"
        '
        'lblStoneCut
        '
        Me.lblStoneCut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStoneCut.Appearance.Options.UseTextOptions = True
        Me.lblStoneCut.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblStoneCut.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblStoneCut.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStoneCut.Location = New System.Drawing.Point(517, 60)
        Me.lblStoneCut.Name = "lblStoneCut"
        Me.lblStoneCut.Size = New System.Drawing.Size(101, 20)
        Me.lblStoneCut.TabIndex = 153
        Me.lblStoneCut.Text = "قصة الفص"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(10, 7)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 20)
        Me.LabelControl4.TabIndex = 154
        Me.LabelControl4.Text = "نقاوة الفص"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(111, 7)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 20)
        Me.LabelControl3.TabIndex = 155
        Me.LabelControl3.Text = "لون الفص"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(212, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(100, 20)
        Me.LabelControl2.TabIndex = 156
        Me.LabelControl2.Text = "ق/جم"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(315, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 20)
        Me.LabelControl1.TabIndex = 157
        Me.LabelControl1.Text = "وزن الفص"
        '
        'lblStoneType
        '
        Me.lblStoneType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStoneType.Appearance.Options.UseTextOptions = True
        Me.lblStoneType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblStoneType.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblStoneType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStoneType.Location = New System.Drawing.Point(517, 7)
        Me.lblStoneType.Name = "lblStoneType"
        Me.lblStoneType.Size = New System.Drawing.Size(100, 20)
        Me.lblStoneType.TabIndex = 158
        Me.lblStoneType.Text = "نوع الفص"
        '
        'lblStoneName
        '
        Me.lblStoneName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblStoneName.Appearance.Options.UseTextOptions = True
        Me.lblStoneName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblStoneName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lblStoneName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblStoneName.Location = New System.Drawing.Point(416, 7)
        Me.lblStoneName.Name = "lblStoneName"
        Me.lblStoneName.Size = New System.Drawing.Size(100, 20)
        Me.lblStoneName.TabIndex = 159
        Me.lblStoneName.Text = "اسم الفص"
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtWeight.Location = New System.Drawing.Point(315, 33)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Properties.Appearance.Options.UseTextOptions = True
        Me.txtWeight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtWeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtWeight.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.txtWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWeight.Size = New System.Drawing.Size(101, 20)
        Me.txtWeight.TabIndex = 2
        '
        'txtStonePrice
        '
        Me.txtStonePrice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStonePrice.Location = New System.Drawing.Point(315, 82)
        Me.txtStonePrice.Name = "txtStonePrice"
        Me.txtStonePrice.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStonePrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtStonePrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtStonePrice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.txtStonePrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtStonePrice.Size = New System.Drawing.Size(101, 20)
        Me.txtStonePrice.TabIndex = 8
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(157, 60)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(140, 20)
        Me.LabelControl9.TabIndex = 151
        Me.LabelControl9.Text = "صورة الفص"
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(10, 60)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(140, 20)
        Me.LabelControl10.TabIndex = 151
        Me.LabelControl10.Text = "شهادة/مستند للفص"
        '
        'cmbStoneType
        '
        Me.cmbStoneType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStoneType.Location = New System.Drawing.Point(517, 33)
        Me.cmbStoneType.Name = "cmbStoneType"
        Me.cmbStoneType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneType.Properties.NullText = ""
        Me.cmbStoneType.Properties.PopupSizeable = False
        Me.cmbStoneType.Properties.ShowFooter = False
        Me.cmbStoneType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStoneType.Size = New System.Drawing.Size(101, 20)
        Me.cmbStoneType.TabIndex = 0
        '
        'cmbStoneName
        '
        Me.cmbStoneName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStoneName.Location = New System.Drawing.Point(416, 33)
        Me.cmbStoneName.Name = "cmbStoneName"
        Me.cmbStoneName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneName.Properties.NullText = ""
        Me.cmbStoneName.Properties.PopupSizeable = False
        Me.cmbStoneName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStoneName.Size = New System.Drawing.Size(101, 20)
        Me.cmbStoneName.TabIndex = 1
        '
        'cmbStoneWeightType
        '
        Me.cmbStoneWeightType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStoneWeightType.Location = New System.Drawing.Point(214, 33)
        Me.cmbStoneWeightType.Name = "cmbStoneWeightType"
        Me.cmbStoneWeightType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneWeightType.Properties.NullText = ""
        Me.cmbStoneWeightType.Properties.PopupSizeable = False
        Me.cmbStoneWeightType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStoneWeightType.Size = New System.Drawing.Size(101, 20)
        Me.cmbStoneWeightType.TabIndex = 3
        '
        'cmbStoneColor
        '
        Me.cmbStoneColor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStoneColor.Location = New System.Drawing.Point(113, 33)
        Me.cmbStoneColor.Name = "cmbStoneColor"
        Me.cmbStoneColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneColor.Properties.NullText = ""
        Me.cmbStoneColor.Properties.PopupSizeable = False
        Me.cmbStoneColor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStoneColor.Size = New System.Drawing.Size(101, 20)
        Me.cmbStoneColor.TabIndex = 4
        '
        'cmbStoneClarity
        '
        Me.cmbStoneClarity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStoneClarity.Location = New System.Drawing.Point(12, 33)
        Me.cmbStoneClarity.Name = "cmbStoneClarity"
        Me.cmbStoneClarity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneClarity.Properties.NullText = ""
        Me.cmbStoneClarity.Properties.PopupSizeable = False
        Me.cmbStoneClarity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStoneClarity.Size = New System.Drawing.Size(101, 20)
        Me.cmbStoneClarity.TabIndex = 5
        '
        'cmbStoneCut
        '
        Me.cmbStoneCut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStoneCut.Location = New System.Drawing.Point(517, 82)
        Me.cmbStoneCut.Name = "cmbStoneCut"
        Me.cmbStoneCut.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneCut.Properties.NullText = ""
        Me.cmbStoneCut.Properties.PopupSizeable = False
        Me.cmbStoneCut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStoneCut.Size = New System.Drawing.Size(101, 20)
        Me.cmbStoneCut.TabIndex = 6
        '
        'cmbStoneCountryOfOrigin
        '
        Me.cmbStoneCountryOfOrigin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbStoneCountryOfOrigin.Location = New System.Drawing.Point(416, 82)
        Me.cmbStoneCountryOfOrigin.Name = "cmbStoneCountryOfOrigin"
        Me.cmbStoneCountryOfOrigin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStoneCountryOfOrigin.Properties.NullText = ""
        Me.cmbStoneCountryOfOrigin.Properties.PopupSizeable = False
        Me.cmbStoneCountryOfOrigin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStoneCountryOfOrigin.Size = New System.Drawing.Size(101, 20)
        Me.cmbStoneCountryOfOrigin.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(348, 111)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "حفظ"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.ImageOptions.Image = CType(resources.GetObject("btnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(203, 111)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "إغلاق"
        '
        'OFDX
        '
        Me.OFDX.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG"
        Me.OFDX.RestoreDirectory = True
        '
        'btnStonePhoto
        '
        Me.btnStonePhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStonePhoto.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.btnStonePhoto.Appearance.Options.UseBorderColor = True
        Me.btnStonePhoto.ImageOptions.Image = CType(resources.GetObject("btnPhoto.ImageOptions.Image"), System.Drawing.Image)
        Me.btnStonePhoto.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnStonePhoto.Location = New System.Drawing.Point(277, 82)
        Me.btnStonePhoto.Name = "btnStonePhoto"
        Me.btnStonePhoto.Size = New System.Drawing.Size(20, 20)
        Me.btnStonePhoto.TabIndex = 161
        '
        'pbStonePhoto
        '
        Me.pbStonePhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbStonePhoto.Location = New System.Drawing.Point(157, 82)
        Me.pbStonePhoto.Name = "pbStonePhoto"
        Me.pbStonePhoto.Properties.NullText = "-"
        Me.pbStonePhoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.pbStonePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbStonePhoto.Size = New System.Drawing.Size(121, 20)
        Me.pbStonePhoto.TabIndex = 160
        '
        'pbStoneDocument
        '
        Me.pbStoneDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbStoneDocument.Location = New System.Drawing.Point(10, 82)
        Me.pbStoneDocument.Name = "pbStoneDocument"
        Me.pbStoneDocument.Properties.NullText = "-"
        Me.pbStoneDocument.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.pbStoneDocument.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pbStoneDocument.Size = New System.Drawing.Size(121, 20)
        Me.pbStoneDocument.TabIndex = 160
        '
        'btnStoneDocument
        '
        Me.btnStoneDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStoneDocument.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.btnStoneDocument.Appearance.Options.UseBorderColor = True
        Me.btnStoneDocument.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.btnStoneDocument.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btnStoneDocument.Location = New System.Drawing.Point(130, 82)
        Me.btnStoneDocument.Name = "btnStoneDocument"
        Me.btnStoneDocument.Size = New System.Drawing.Size(20, 20)
        Me.btnStoneDocument.TabIndex = 161
        '
        'FrmGoldAddStone
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(627, 141)
        Me.Controls.Add(Me.btnStoneDocument)
        Me.Controls.Add(Me.btnStonePhoto)
        Me.Controls.Add(Me.pbStoneDocument)
        Me.Controls.Add(Me.pbStonePhoto)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtStonePrice)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.lblStoneCountryOfOrigin)
        Me.Controls.Add(Me.lblStoneCut)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lblStoneType)
        Me.Controls.Add(Me.lblStoneName)
        Me.Controls.Add(Me.cmbStoneType)
        Me.Controls.Add(Me.cmbStoneName)
        Me.Controls.Add(Me.cmbStoneWeightType)
        Me.Controls.Add(Me.cmbStoneColor)
        Me.Controls.Add(Me.cmbStoneClarity)
        Me.Controls.Add(Me.cmbStoneCut)
        Me.Controls.Add(Me.cmbStoneCountryOfOrigin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmGoldAddStone"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة فص"
        CType(Me.txtWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStonePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneWeightType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneClarity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneCut.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStoneCountryOfOrigin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStonePhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStoneDocument.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStoneCountryOfOrigin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStoneCut As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStoneType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStoneName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStonePrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbStoneType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStoneName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStoneWeightType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStoneColor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStoneClarity As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStoneCut As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbStoneCountryOfOrigin As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OFDX As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents btnStonePhoto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pbStonePhoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents pbStoneDocument As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnStoneDocument As DevExpress.XtraEditors.SimpleButton
End Class
