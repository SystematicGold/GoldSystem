<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddStone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddStone))
        Me.txtStoneDocPath = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStoneImagePath = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStoneWeight = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtStoneColor = New System.Windows.Forms.TextBox()
        Me.txtStonePrice = New System.Windows.Forms.TextBox()
        Me.txtStoneClarity = New System.Windows.Forms.TextBox()
        Me.txtStoneCut = New System.Windows.Forms.TextBox()
        Me.cmbStoneCaratOrGram = New System.Windows.Forms.ComboBox()
        Me.cmbStoneCountryOfOrigin = New System.Windows.Forms.ComboBox()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbStone = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        CType(Me.txtStoneDocPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStoneImagePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStoneDocPath
        '
        Me.txtStoneDocPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneDocPath.Location = New System.Drawing.Point(285, 100)
        Me.txtStoneDocPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneDocPath.Name = "txtStoneDocPath"
        Me.txtStoneDocPath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoneDocPath.Properties.Appearance.Options.UseFont = True
        Me.txtStoneDocPath.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtStoneDocPath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtStoneDocPath.Size = New System.Drawing.Size(261, 26)
        Me.txtStoneDocPath.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(711, 7)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 27)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "اسم الفص"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(604, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 27)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "وزن الفص"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStoneImagePath
        '
        Me.txtStoneImagePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneImagePath.Location = New System.Drawing.Point(554, 100)
        Me.txtStoneImagePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneImagePath.Name = "txtStoneImagePath"
        Me.txtStoneImagePath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoneImagePath.Properties.Appearance.Options.UseFont = True
        Me.txtStoneImagePath.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtStoneImagePath.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtStoneImagePath.Size = New System.Drawing.Size(261, 26)
        Me.txtStoneImagePath.TabIndex = 124
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(432, 7)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 27)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "لون الفص"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStoneWeight
        '
        Me.txtStoneWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStoneWeight.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStoneWeight.Location = New System.Drawing.Point(604, 38)
        Me.txtStoneWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneWeight.Name = "txtStoneWeight"
        Me.txtStoneWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoneWeight.Size = New System.Drawing.Size(107, 27)
        Me.txtStoneWeight.TabIndex = 119
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(4, 7)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 27)
        Me.Label15.TabIndex = 110
        Me.Label15.Text = "سعر الفص"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label38.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.Location = New System.Drawing.Point(325, 7)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(107, 27)
        Me.Label38.TabIndex = 106
        Me.Label38.Text = "نقاوة الفص"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label39.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.Location = New System.Drawing.Point(218, 7)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(107, 27)
        Me.Label39.TabIndex = 107
        Me.Label39.Text = "قصة الفص"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStoneColor
        '
        Me.txtStoneColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStoneColor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStoneColor.Location = New System.Drawing.Point(432, 38)
        Me.txtStoneColor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneColor.Name = "txtStoneColor"
        Me.txtStoneColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoneColor.Size = New System.Drawing.Size(107, 27)
        Me.txtStoneColor.TabIndex = 115
        '
        'txtStonePrice
        '
        Me.txtStonePrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStonePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStonePrice.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStonePrice.Location = New System.Drawing.Point(4, 38)
        Me.txtStonePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStonePrice.Name = "txtStonePrice"
        Me.txtStonePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStonePrice.Size = New System.Drawing.Size(107, 27)
        Me.txtStonePrice.TabIndex = 116
        '
        'txtStoneClarity
        '
        Me.txtStoneClarity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneClarity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStoneClarity.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStoneClarity.Location = New System.Drawing.Point(325, 38)
        Me.txtStoneClarity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneClarity.Name = "txtStoneClarity"
        Me.txtStoneClarity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoneClarity.Size = New System.Drawing.Size(107, 27)
        Me.txtStoneClarity.TabIndex = 117
        '
        'txtStoneCut
        '
        Me.txtStoneCut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStoneCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStoneCut.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtStoneCut.Location = New System.Drawing.Point(218, 38)
        Me.txtStoneCut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStoneCut.Name = "txtStoneCut"
        Me.txtStoneCut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoneCut.Size = New System.Drawing.Size(107, 27)
        Me.txtStoneCut.TabIndex = 118
        '
        'cmbStoneCaratOrGram
        '
        Me.cmbStoneCaratOrGram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStoneCaratOrGram.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cmbStoneCaratOrGram.FormattingEnabled = True
        Me.cmbStoneCaratOrGram.Items.AddRange(New Object() {"قيراط", "جرام"})
        Me.cmbStoneCaratOrGram.Location = New System.Drawing.Point(539, 38)
        Me.cmbStoneCaratOrGram.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStoneCaratOrGram.Name = "cmbStoneCaratOrGram"
        Me.cmbStoneCaratOrGram.Size = New System.Drawing.Size(65, 27)
        Me.cmbStoneCaratOrGram.TabIndex = 120
        '
        'cmbStoneCountryOfOrigin
        '
        Me.cmbStoneCountryOfOrigin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStoneCountryOfOrigin.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cmbStoneCountryOfOrigin.FormattingEnabled = True
        Me.cmbStoneCountryOfOrigin.Location = New System.Drawing.Point(111, 38)
        Me.cmbStoneCountryOfOrigin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStoneCountryOfOrigin.Name = "cmbStoneCountryOfOrigin"
        Me.cmbStoneCountryOfOrigin.Size = New System.Drawing.Size(107, 27)
        Me.cmbStoneCountryOfOrigin.TabIndex = 121
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
        Me.Guna2Button5.Location = New System.Drawing.Point(154, 95)
        Me.Guna2Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(129, 35)
        Me.Guna2Button5.TabIndex = 123
        Me.Guna2Button5.Text = "حفظ"
        '
        'cmbStone
        '
        Me.cmbStone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbStone.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cmbStone.FormattingEnabled = True
        Me.cmbStone.Location = New System.Drawing.Point(711, 38)
        Me.cmbStone.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStone.Name = "cmbStone"
        Me.cmbStone.Size = New System.Drawing.Size(107, 27)
        Me.cmbStone.TabIndex = 122
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(554, 69)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(261, 27)
        Me.Label16.TabIndex = 109
        Me.Label16.Text = "صورة الحجر"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(539, 7)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 27)
        Me.Label18.TabIndex = 112
        Me.Label18.Text = "ق/جم"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(285, 69)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(261, 27)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "مستندات / شهادات للحجر"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label40.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(111, 7)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(107, 27)
        Me.Label40.TabIndex = 111
        Me.Label40.Text = "بلد المنشأ للفص"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmAddStone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 140)
        Me.Controls.Add(Me.txtStoneDocPath)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtStoneImagePath)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtStoneWeight)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.txtStoneColor)
        Me.Controls.Add(Me.txtStonePrice)
        Me.Controls.Add(Me.txtStoneClarity)
        Me.Controls.Add(Me.txtStoneCut)
        Me.Controls.Add(Me.cmbStoneCaratOrGram)
        Me.Controls.Add(Me.cmbStoneCountryOfOrigin)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.cmbStone)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label40)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddStone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة حجر"
        CType(Me.txtStoneDocPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStoneImagePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStoneDocPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtStoneImagePath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As Label
    Friend WithEvents txtStoneWeight As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents txtStoneColor As TextBox
    Friend WithEvents txtStonePrice As TextBox
    Friend WithEvents txtStoneClarity As TextBox
    Friend WithEvents txtStoneCut As TextBox
    Friend WithEvents cmbStoneCaratOrGram As ComboBox
    Friend WithEvents cmbStoneCountryOfOrigin As ComboBox
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbStone As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label40 As Label
End Class
