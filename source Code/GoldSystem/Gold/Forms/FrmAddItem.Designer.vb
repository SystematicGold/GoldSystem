<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdderItem
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
        Me.btnNew = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnModify = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.AddGoldItem1 = New GoldSystem.AddGoldItem()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BorderRadius = 10
        Me.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(744, 526)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(143, 51)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = "جديد"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BorderRadius = 10
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(497, 526)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 51)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "حفظ"
        '
        'btnModify
        '
        Me.btnModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModify.BorderRadius = 10
        Me.btnModify.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnModify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnModify.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnModify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnModify.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.ForeColor = System.Drawing.Color.White
        Me.btnModify.Location = New System.Drawing.Point(250, 526)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(143, 51)
        Me.btnModify.TabIndex = 25
        Me.btnModify.Text = "تعديل"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BorderRadius = 10
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(3, 526)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 51)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "إغلاق"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'TxtCode
        '
        Me.TxtCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCode.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtCode.Location = New System.Drawing.Point(-404, 289)
        Me.TxtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.ReadOnly = True
        Me.TxtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCode.Size = New System.Drawing.Size(48, 27)
        Me.TxtCode.TabIndex = 91
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"عادى", "ثمين"})
        Me.ComboBox1.Location = New System.Drawing.Point(1105, 465)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 27)
        Me.ComboBox1.TabIndex = 98
        '
        'Label41
        '
        Me.Label41.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(1135, 433)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(61, 19)
        Me.Label41.TabIndex = 59
        Me.Label41.Text = "نوع الفص"
        '
        'AddGoldItem1
        '
        Me.AddGoldItem1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddGoldItem1.Location = New System.Drawing.Point(0, 0)
        Me.AddGoldItem1.Margin = New System.Windows.Forms.Padding(4)
        Me.AddGoldItem1.Name = "AddGoldItem1"
        Me.AddGoldItem1.Size = New System.Drawing.Size(946, 505)
        Me.AddGoldItem1.TabIndex = 99
        '
        'FrmAdderItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 591)
        Me.Controls.Add(Me.AddGoldItem1)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(962, 630)
        Me.MinimumSize = New System.Drawing.Size(962, 630)
        Me.Name = "FrmAdderItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة قطعة الى الطقم - Add a piece to the kit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnModify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents AddGoldItem1 As AddGoldItem
End Class
