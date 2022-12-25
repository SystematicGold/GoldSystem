<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGoldPrintBarCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGoldPrintBarCode))
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.gbItem = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.PictureEdit4 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit5 = New DevExpress.XtraEditors.PictureEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        Me.TabNavigationPage2.SuspendLayout()
        Me.TabNavigationPage3.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItem.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage3)
        Me.TabPane1.Location = New System.Drawing.Point(256, 71)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2, Me.TabNavigationPage3})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1091, 659)
        Me.TabPane1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1091, 659)
        Me.TabPane1.TabIndex = 1
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "نموذج1"
        Me.TabNavigationPage1.Controls.Add(Me.PictureEdit1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1073, 614)
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "نموذج2"
        Me.TabNavigationPage2.Controls.Add(Me.PictureEdit2)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(1074, 678)
        '
        'TabNavigationPage3
        '
        Me.TabNavigationPage3.Caption = "نموذج3"
        Me.TabNavigationPage3.Controls.Add(Me.PictureEdit3)
        Me.TabNavigationPage3.Name = "TabNavigationPage3"
        Me.TabNavigationPage3.Size = New System.Drawing.Size(1074, 678)
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = Global.GoldSystem.My.Resources.Resources.BarCode1
        Me.PictureEdit1.Location = New System.Drawing.Point(463, 3)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(400, 400)
        Me.PictureEdit1.TabIndex = 1
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit2.EditValue = Global.GoldSystem.My.Resources.Resources.BarCode2
        Me.PictureEdit2.Location = New System.Drawing.Point(463, 3)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(400, 400)
        Me.PictureEdit2.TabIndex = 1
        '
        'PictureEdit3
        '
        Me.PictureEdit3.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit3.EditValue = Global.GoldSystem.My.Resources.Resources.BarCode3
        Me.PictureEdit3.Location = New System.Drawing.Point(463, 3)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit3.Size = New System.Drawing.Size(400, 400)
        Me.PictureEdit3.TabIndex = 1
        '
        'gbItem
        '
        Me.gbItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gbItem.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.gbItem.BorderRadius = 5
        Me.gbItem.BorderThickness = 2
        Me.gbItem.Controls.Add(Me.Label7)
        Me.gbItem.Controls.Add(Me.Label6)
        Me.gbItem.Controls.Add(Me.Label5)
        Me.gbItem.Controls.Add(Me.Label4)
        Me.gbItem.Controls.Add(Me.Label3)
        Me.gbItem.Controls.Add(Me.Label2)
        Me.gbItem.Controls.Add(Me.Label1)
        Me.gbItem.CustomBorderColor = System.Drawing.Color.DarkSlateBlue
        Me.gbItem.CustomBorderThickness = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.gbItem.FillColor = System.Drawing.Color.WhiteSmoke
        Me.gbItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.gbItem.Location = New System.Drawing.Point(1, 71)
        Me.gbItem.Name = "gbItem"
        Me.gbItem.Size = New System.Drawing.Size(249, 651)
        Me.gbItem.TabIndex = 21
        Me.gbItem.Text = "الأدوات"
        Me.gbItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.PictureEdit5)
        Me.Guna2GroupBox1.Controls.Add(Me.PictureEdit4)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1347, 70)
        Me.Guna2GroupBox1.TabIndex = 21
        Me.Guna2GroupBox1.Text = "الأدوات"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureEdit4
        '
        Me.PictureEdit4.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit4.EditValue = CType(resources.GetObject("PictureEdit4.EditValue"), Object)
        Me.PictureEdit4.Location = New System.Drawing.Point(1276, 4)
        Me.PictureEdit4.Name = "PictureEdit4"
        Me.PictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit4.Size = New System.Drawing.Size(63, 60)
        Me.PictureEdit4.TabIndex = 0
        '
        'PictureEdit5
        '
        Me.PictureEdit5.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit5.EditValue = CType(resources.GetObject("PictureEdit5.EditValue"), Object)
        Me.PictureEdit5.Location = New System.Drawing.Point(1207, 4)
        Me.PictureEdit5.Name = "PictureEdit5"
        Me.PictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit5.Size = New System.Drawing.Size(63, 60)
        Me.PictureEdit5.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الرمز"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(56, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "الفصوص"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(56, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "المصنعية"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(56, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "العيار"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(56, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "الوزن"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(56, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "اسم الصنف"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(56, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "باركود"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmGoldPrintBarCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.gbItem)
        Me.Controls.Add(Me.TabPane1)
        Me.MinimumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "FrmGoldPrintBarCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "طباعة باركود الذهب"
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage2.ResumeLayout(False)
        Me.TabNavigationPage3.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItem.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents TabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents gbItem As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents PictureEdit5 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
