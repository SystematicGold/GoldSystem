<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddPhone
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddPhone))
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.pbAddStone = New DevExpress.XtraEditors.PictureEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGC = New DevExpress.XtraGrid.GridControl()
        Me.DGV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RIBDelete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.pbClose = New DevExpress.XtraEditors.PictureEdit()
        Me.txtPhoneNo = New DevExpress.XtraEditors.TextEdit()
        CType(Me.pbAddStone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIBDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbClose.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhoneNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbAddStone
        '
        Me.pbAddStone.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbAddStone.EditValue = CType(resources.GetObject("pbAddStone.EditValue"), Object)
        Me.pbAddStone.Location = New System.Drawing.Point(197, 6)
        Me.pbAddStone.Name = "pbAddStone"
        Me.pbAddStone.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbAddStone.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.pbAddStone.Properties.Appearance.Options.UseBackColor = True
        Me.pbAddStone.Properties.Appearance.Options.UseForeColor = True
        Me.pbAddStone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbAddStone.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pbAddStone.Size = New System.Drawing.Size(40, 30)
        Me.pbAddStone.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(420, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "رقم الهاتف"
        '
        'DGC
        '
        Me.DGC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGC.Location = New System.Drawing.Point(0, 46)
        Me.DGC.MainView = Me.DGV
        Me.DGC.Name = "DGC"
        Me.DGC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RIBDelete})
        Me.DGC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DGC.Size = New System.Drawing.Size(598, 122)
        Me.DGC.TabIndex = 104
        Me.DGC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DGV})
        '
        'DGV
        '
        Me.DGV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCID, Me.colPhone, Me.colDelete})
        Me.DGV.GridControl = Me.DGC
        Me.DGV.Name = "DGV"
        Me.DGV.OptionsView.ShowGroupPanel = False
        '
        'colCID
        '
        Me.colCID.AppearanceCell.Options.UseTextOptions = True
        Me.colCID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCID.AppearanceHeader.Options.UseTextOptions = True
        Me.colCID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCID.Caption = "CID"
        Me.colCID.FieldName = "CID"
        Me.colCID.Name = "colCID"
        '
        'colPhone
        '
        Me.colPhone.AppearanceCell.Options.UseTextOptions = True
        Me.colPhone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPhone.AppearanceHeader.Options.UseTextOptions = True
        Me.colPhone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPhone.Caption = "الهاتف"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 1
        '
        'colDelete
        '
        Me.colDelete.AppearanceCell.Options.UseTextOptions = True
        Me.colDelete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDelete.AppearanceHeader.Options.UseTextOptions = True
        Me.colDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDelete.Caption = "حذف"
        Me.colDelete.ColumnEdit = Me.RIBDelete
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colDelete.Visible = True
        Me.colDelete.VisibleIndex = 0
        '
        'RIBDelete
        '
        Me.RIBDelete.AutoHeight = False
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.RIBDelete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RIBDelete.Name = "RIBDelete"
        Me.RIBDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'pbClose
        '
        Me.pbClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbClose.EditValue = CType(resources.GetObject("pbClose.EditValue"), Object)
        Me.pbClose.Location = New System.Drawing.Point(147, 6)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbClose.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.pbClose.Properties.Appearance.Options.UseBackColor = True
        Me.pbClose.Properties.Appearance.Options.UseForeColor = True
        Me.pbClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pbClose.Size = New System.Drawing.Size(40, 30)
        ToolTipTitleItem2.Text = "إضافة فص"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "اضغط لإضافة فص للقطعة"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.pbClose.SuperTip = SuperToolTip2
        Me.pbClose.TabIndex = 106
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(243, 12)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPhoneNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPhoneNo.Size = New System.Drawing.Size(172, 20)
        Me.txtPhoneNo.TabIndex = 107
        '
        'FrmAddPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 168)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.pbClose)
        Me.Controls.Add(Me.pbAddStone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGC)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddPhone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة رقم هاتف"
        CType(Me.pbAddStone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIBDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbClose.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhoneNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pbAddStone As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents DGC As DevExpress.XtraGrid.GridControl
    Friend WithEvents DGV As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents pbClose As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtPhoneNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RIBDelete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
