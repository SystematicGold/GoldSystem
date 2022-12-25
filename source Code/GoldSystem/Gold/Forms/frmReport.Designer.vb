<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGoldReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tbSale = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tbBuy = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tbItem = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tbCustomer = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tbExpense = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tbCashMoney = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tbVoucher = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPane1
        '
        Me.TabPane1.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPane1.Appearance.Options.UseFont = True
        Me.TabPane1.AppearanceButton.Hovered.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabPane1.AppearanceButton.Hovered.Options.UseFont = True
        Me.TabPane1.AppearanceButton.Normal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TabPane1.AppearanceButton.Normal.Options.UseFont = True
        Me.TabPane1.AppearanceButton.Pressed.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TabPane1.AppearanceButton.Pressed.Options.UseFont = True
        Me.TabPane1.Controls.Add(Me.tbSale)
        Me.TabPane1.Controls.Add(Me.tbBuy)
        Me.TabPane1.Controls.Add(Me.tbItem)
        Me.TabPane1.Controls.Add(Me.tbCustomer)
        Me.TabPane1.Controls.Add(Me.tbExpense)
        Me.TabPane1.Controls.Add(Me.tbCashMoney)
        Me.TabPane1.Controls.Add(Me.tbVoucher)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tbSale, Me.tbBuy, Me.tbItem, Me.tbCustomer, Me.tbExpense, Me.tbCashMoney, Me.tbVoucher})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1350, 729)
        Me.TabPane1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabPane1.SelectedPage = Me.tbSale
        Me.TabPane1.Size = New System.Drawing.Size(1350, 729)
        Me.TabPane1.TabIndex = 18
        Me.TabPane1.Text = "TabPane1"
        '
        'tbSale
        '
        Me.tbSale.Caption = "تقرير المبيعات"
        Me.tbSale.Name = "tbSale"
        Me.tbSale.Size = New System.Drawing.Size(1332, 674)
        '
        'tbBuy
        '
        Me.tbBuy.Caption = "تقرير المشتريات"
        Me.tbBuy.Name = "tbBuy"
        Me.tbBuy.Size = New System.Drawing.Size(1350, 729)
        '
        'tbItem
        '
        Me.tbItem.Caption = "تقرير الأصناف"
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Size = New System.Drawing.Size(1350, 729)
        '
        'tbCustomer
        '
        Me.tbCustomer.Caption = "تقرير العملاء"
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(1350, 729)
        '
        'tbExpense
        '
        Me.tbExpense.Caption = "تقرير المصروفات"
        Me.tbExpense.Name = "tbExpense"
        Me.tbExpense.Size = New System.Drawing.Size(1350, 729)
        '
        'tbCashMoney
        '
        Me.tbCashMoney.Caption = "تقرير النقدية"
        Me.tbCashMoney.Name = "tbCashMoney"
        Me.tbCashMoney.Size = New System.Drawing.Size(1350, 729)
        '
        'tbVoucher
        '
        Me.tbVoucher.Caption = "تقرير السندات"
        Me.tbVoucher.Name = "tbVoucher"
        Me.tbVoucher.Size = New System.Drawing.Size(1350, 729)
        '
        'frmGoldReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.TabPane1)
        Me.Name = "frmGoldReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقارير الذهب"
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tbSale As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tbBuy As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tbItem As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tbCustomer As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tbExpense As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tbCashMoney As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tbVoucher As DevExpress.XtraBars.Navigation.TabNavigationPage
End Class
