<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStone))
        Me.txtStoneDocPath = New DevExpress.XtraEditors.TextEdit()
        Me.txtStoneImagePath = New DevExpress.XtraEditors.TextEdit()
        Me.txtStoneWeight = New System.Windows.Forms.TextBox()
        Me.txtStoneColor = New System.Windows.Forms.TextBox()
        Me.txtStonePrice = New System.Windows.Forms.TextBox()
        Me.txtStoneClarity = New System.Windows.Forms.TextBox()
        Me.txtStoneCut = New System.Windows.Forms.TextBox()
        Me.cmbStoneCaratOrGram = New System.Windows.Forms.ComboBox()
        Me.cmbStoneCountryOfOrigin = New System.Windows.Forms.ComboBox()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbStone = New System.Windows.Forms.ComboBox()
        Me.lblStoneName = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblStoneCountryOfOrigin = New System.Windows.Forms.Label()
        Me.lblStoneWeightKorGm = New System.Windows.Forms.Label()
        Me.lblStoneCut = New System.Windows.Forms.Label()
        Me.lblStoneClarity = New System.Windows.Forms.Label()
        Me.lblStonePrice = New System.Windows.Forms.Label()
        Me.lblStoneColor = New System.Windows.Forms.Label()
        Me.lblStoneWeight = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.txtStoneDocPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStoneImagePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStoneDocPath
        '
        Me.txtStoneDocPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneDocPath.Location = New System.Drawing.Point(291, 102)
        Me.txtStoneDocPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneDocPath.Name = "txtStoneDocPath"
        Me.txtStoneDocPath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoneDocPath.Properties.Appearance.Options.UseFont = True
        Me.txtStoneDocPath.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtStoneDocPath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtStoneDocPath.Size = New System.Drawing.Size(261, 26)
        Me.txtStoneDocPath.TabIndex = 146
        '
        'txtStoneImagePath
        '
        Me.txtStoneImagePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneImagePath.Location = New System.Drawing.Point(563, 102)
        Me.txtStoneImagePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneImagePath.Name = "txtStoneImagePath"
        Me.txtStoneImagePath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoneImagePath.Properties.Appearance.Options.UseFont = True
        Me.txtStoneImagePath.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtStoneImagePath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtStoneImagePath.Size = New System.Drawing.Size(261, 26)
        Me.txtStoneImagePath.TabIndex = 145
        '
        'txtStoneWeight
        '
        Me.txtStoneWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStoneWeight.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStoneWeight.Location = New System.Drawing.Point(610, 40)
        Me.txtStoneWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneWeight.Name = "txtStoneWeight"
        Me.txtStoneWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoneWeight.Size = New System.Drawing.Size(107, 27)
        Me.txtStoneWeight.TabIndex = 140
        '
        'txtStoneColor
        '
        Me.txtStoneColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStoneColor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStoneColor.Location = New System.Drawing.Point(438, 40)
        Me.txtStoneColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneColor.Name = "txtStoneColor"
        Me.txtStoneColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoneColor.Size = New System.Drawing.Size(107, 27)
        Me.txtStoneColor.TabIndex = 136
        '
        'txtStonePrice
        '
        Me.txtStonePrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStonePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStonePrice.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStonePrice.Location = New System.Drawing.Point(10, 40)
        Me.txtStonePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStonePrice.Name = "txtStonePrice"
        Me.txtStonePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStonePrice.Size = New System.Drawing.Size(107, 27)
        Me.txtStonePrice.TabIndex = 137
        '
        'txtStoneClarity
        '
        Me.txtStoneClarity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneClarity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStoneClarity.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStoneClarity.Location = New System.Drawing.Point(331, 40)
        Me.txtStoneClarity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneClarity.Name = "txtStoneClarity"
        Me.txtStoneClarity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoneClarity.Size = New System.Drawing.Size(107, 27)
        Me.txtStoneClarity.TabIndex = 138
        '
        'txtStoneCut
        '
        Me.txtStoneCut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStoneCut.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStoneCut.Location = New System.Drawing.Point(224, 40)
        Me.txtStoneCut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneCut.Name = "txtStoneCut"
        Me.txtStoneCut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoneCut.Size = New System.Drawing.Size(107, 27)
        Me.txtStoneCut.TabIndex = 139
        '
        'cmbStoneCaratOrGram
        '
        Me.cmbStoneCaratOrGram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStoneCaratOrGram.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cmbStoneCaratOrGram.FormattingEnabled = True
        Me.cmbStoneCaratOrGram.Items.AddRange(New Object() {"قيراط", "جرام"})
        Me.cmbStoneCaratOrGram.Location = New System.Drawing.Point(545, 40)
        Me.cmbStoneCaratOrGram.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStoneCaratOrGram.Name = "cmbStoneCaratOrGram"
        Me.cmbStoneCaratOrGram.Size = New System.Drawing.Size(65, 27)
        Me.cmbStoneCaratOrGram.TabIndex = 141
        '
        'cmbStoneCountryOfOrigin
        '
        Me.cmbStoneCountryOfOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStoneCountryOfOrigin.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cmbStoneCountryOfOrigin.FormattingEnabled = True
        Me.cmbStoneCountryOfOrigin.Location = New System.Drawing.Point(117, 40)
        Me.cmbStoneCountryOfOrigin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStoneCountryOfOrigin.Name = "cmbStoneCountryOfOrigin"
        Me.cmbStoneCountryOfOrigin.Size = New System.Drawing.Size(107, 27)
        Me.cmbStoneCountryOfOrigin.TabIndex = 142
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button5.BorderRadius = 10
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2Button5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Location = New System.Drawing.Point(160, 97)
        Me.Guna2Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(129, 35)
        Me.Guna2Button5.TabIndex = 144
        Me.Guna2Button5.Text = "حفظ"
        '
        'cmbStone
        '
        Me.cmbStone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStone.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cmbStone.FormattingEnabled = True
        Me.cmbStone.Location = New System.Drawing.Point(717, 40)
        Me.cmbStone.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStone.Name = "cmbStone"
        Me.cmbStone.Size = New System.Drawing.Size(107, 27)
        Me.cmbStone.TabIndex = 143
        '
        'lblStoneName
        '
        Me.lblStoneName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStoneName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneName.Location = New System.Drawing.Point(717, 9)
        Me.lblStoneName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoneName.Name = "lblStoneName"
        Me.lblStoneName.Size = New System.Drawing.Size(107, 27)
        Me.lblStoneName.TabIndex = 135
        Me.lblStoneName.Text = "اسم الفص"
        Me.lblStoneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(291, 71)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(261, 27)
        Me.Label17.TabIndex = 126
        Me.Label17.Text = "مستندات / شهادات للفص"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneCountryOfOrigin
        '
        Me.lblStoneCountryOfOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStoneCountryOfOrigin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneCountryOfOrigin.Location = New System.Drawing.Point(117, 9)
        Me.lblStoneCountryOfOrigin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoneCountryOfOrigin.Name = "lblStoneCountryOfOrigin"
        Me.lblStoneCountryOfOrigin.Size = New System.Drawing.Size(107, 27)
        Me.lblStoneCountryOfOrigin.TabIndex = 132
        Me.lblStoneCountryOfOrigin.Text = "بلد المنشأ للفص"
        Me.lblStoneCountryOfOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneWeightKorGm
        '
        Me.lblStoneWeightKorGm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStoneWeightKorGm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneWeightKorGm.Location = New System.Drawing.Point(545, 9)
        Me.lblStoneWeightKorGm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoneWeightKorGm.Name = "lblStoneWeightKorGm"
        Me.lblStoneWeightKorGm.Size = New System.Drawing.Size(65, 27)
        Me.lblStoneWeightKorGm.TabIndex = 133
        Me.lblStoneWeightKorGm.Text = "ق/جم"
        Me.lblStoneWeightKorGm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneCut
        '
        Me.lblStoneCut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStoneCut.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneCut.Location = New System.Drawing.Point(224, 9)
        Me.lblStoneCut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoneCut.Name = "lblStoneCut"
        Me.lblStoneCut.Size = New System.Drawing.Size(107, 27)
        Me.lblStoneCut.TabIndex = 128
        Me.lblStoneCut.Text = "قصة الفص"
        Me.lblStoneCut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneClarity
        '
        Me.lblStoneClarity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStoneClarity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneClarity.Location = New System.Drawing.Point(331, 9)
        Me.lblStoneClarity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoneClarity.Name = "lblStoneClarity"
        Me.lblStoneClarity.Size = New System.Drawing.Size(107, 27)
        Me.lblStoneClarity.TabIndex = 127
        Me.lblStoneClarity.Text = "نقاوة الفص"
        Me.lblStoneClarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStonePrice
        '
        Me.lblStonePrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStonePrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStonePrice.Location = New System.Drawing.Point(10, 9)
        Me.lblStonePrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStonePrice.Name = "lblStonePrice"
        Me.lblStonePrice.Size = New System.Drawing.Size(107, 27)
        Me.lblStonePrice.TabIndex = 131
        Me.lblStonePrice.Text = "سعر الفص"
        Me.lblStonePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneColor
        '
        Me.lblStoneColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStoneColor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneColor.Location = New System.Drawing.Point(438, 9)
        Me.lblStoneColor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoneColor.Name = "lblStoneColor"
        Me.lblStoneColor.Size = New System.Drawing.Size(107, 27)
        Me.lblStoneColor.TabIndex = 129
        Me.lblStoneColor.Text = "لون الفص"
        Me.lblStoneColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneWeight
        '
        Me.lblStoneWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStoneWeight.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneWeight.Location = New System.Drawing.Point(610, 9)
        Me.lblStoneWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStoneWeight.Name = "lblStoneWeight"
        Me.lblStoneWeight.Size = New System.Drawing.Size(107, 27)
        Me.lblStoneWeight.TabIndex = 134
        Me.lblStoneWeight.Text = "وزن الفص"
        Me.lblStoneWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(563, 71)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(261, 27)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "صورة الفص"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAddStone
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 141)
        Me.Controls.Add(Me.txtStoneDocPath)
        Me.Controls.Add(Me.lblStoneName)
        Me.Controls.Add(Me.lblStoneWeight)
        Me.Controls.Add(Me.txtStoneImagePath)
        Me.Controls.Add(Me.lblStoneColor)
        Me.Controls.Add(Me.txtStoneWeight)
        Me.Controls.Add(Me.lblStonePrice)
        Me.Controls.Add(Me.lblStoneClarity)
        Me.Controls.Add(Me.lblStoneCut)
        Me.Controls.Add(Me.txtStoneColor)
        Me.Controls.Add(Me.txtStonePrice)
        Me.Controls.Add(Me.txtStoneClarity)
        Me.Controls.Add(Me.txtStoneCut)
        Me.Controls.Add(Me.cmbStoneCaratOrGram)
        Me.Controls.Add(Me.cmbStoneCountryOfOrigin)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.cmbStone)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblStoneWeightKorGm)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblStoneCountryOfOrigin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddStone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة فص"
        CType(Me.txtStoneDocPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStoneImagePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtStoneDocPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStoneImagePath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStoneWeight As TextBox
    Friend WithEvents txtStoneColor As TextBox
    Friend WithEvents txtStonePrice As TextBox
    Friend WithEvents txtStoneClarity As TextBox
    Friend WithEvents txtStoneCut As TextBox
    Friend WithEvents cmbStoneCaratOrGram As ComboBox
    Friend WithEvents cmbStoneCountryOfOrigin As ComboBox
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbStone As ComboBox
    Friend WithEvents lblStoneName As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblStoneCountryOfOrigin As Label
    Friend WithEvents lblStoneWeightKorGm As Label
    Friend WithEvents lblStoneCut As Label
    Friend WithEvents lblStoneClarity As Label
    Friend WithEvents lblStonePrice As Label
    Friend WithEvents lblStoneColor As Label
    Friend WithEvents lblStoneWeight As Label
    Friend WithEvents Label16 As Label
End Class
