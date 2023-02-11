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
        Dim WindowsUIButtonImageOptions5 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdderItem))
        Dim WindowsUIButtonImageOptions6 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions7 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions8 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.AddGoldItem = New GoldSystem.UCGoldAddItem()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.SuspendLayout()
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"عادى", "ثمين"})
        Me.ComboBox1.Location = New System.Drawing.Point(1509, 465)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 27)
        Me.ComboBox1.TabIndex = 98
        '
        'Label41
        '
        Me.Label41.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(1539, 433)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(61, 19)
        Me.Label41.TabIndex = 59
        Me.Label41.Text = "نوع الفص"
        '
        'AddGoldItem
        '
        Me.AddGoldItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddGoldItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddGoldItem.Location = New System.Drawing.Point(0, 0)
        Me.AddGoldItem.Margin = New System.Windows.Forms.Padding(4)
        Me.AddGoldItem.Name = "AddGoldItem"
        Me.AddGoldItem.Size = New System.Drawing.Size(1350, 369)
        Me.AddGoldItem.TabIndex = 99
        '
        'TxtCode
        '
        Me.TxtCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCode.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TxtCode.Location = New System.Drawing.Point(0, 289)
        Me.TxtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.ReadOnly = True
        Me.TxtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCode.Size = New System.Drawing.Size(48, 27)
        Me.TxtCode.TabIndex = 91
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.AllowGlyphSkinning = False
        Me.WindowsUIButtonPanel1.BackColor = System.Drawing.Color.Transparent
        WindowsUIButtonImageOptions5.SvgImage = CType(resources.GetObject("WindowsUIButtonImageOptions5.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        WindowsUIButtonImageOptions5.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        WindowsUIButtonImageOptions6.Image = CType(resources.GetObject("WindowsUIButtonImageOptions6.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions7.Image = CType(resources.GetObject("WindowsUIButtonImageOptions7.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions8.Image = CType(resources.GetObject("WindowsUIButtonImageOptions8.Image"), System.Drawing.Image)
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("إغلاق", True, WindowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("تعديل", True, WindowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("حفظ", True, WindowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("جديد", True, WindowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(0, 289)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(1350, 71)
        Me.WindowsUIButtonPanel1.TabIndex = 100
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'FrmAdderItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 591)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Controls.Add(Me.AddGoldItem)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label41)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1366, 630)
        Me.MinimumSize = New System.Drawing.Size(962, 630)
        Me.Name = "FrmAdderItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة قطعة للطقم"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OFD As OpenFileDialog
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents AddGoldItem As UCGoldAddItem
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
End Class
