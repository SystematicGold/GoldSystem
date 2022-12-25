<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCFavorite
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCFavorite))
        Me.PictureEdit13 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.PictureEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit13
        '
        Me.PictureEdit13.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit13.EditValue = CType(resources.GetObject("PictureEdit13.EditValue"), Object)
        Me.PictureEdit13.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit13.Name = "PictureEdit13"
        Me.PictureEdit13.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit13.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.PictureEdit13.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.PictureEdit13.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.PictureEdit13.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit13.Properties.Appearance.Options.UseBorderColor = True
        Me.PictureEdit13.Properties.Appearance.Options.UseForeColor = True
        Me.PictureEdit13.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit13.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit13.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit13.Size = New System.Drawing.Size(30, 30)
        Me.PictureEdit13.TabIndex = 56
        '
        'Favorite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PictureEdit13)
        Me.Name = "Favorite"
        Me.Size = New System.Drawing.Size(30, 30)
        CType(Me.PictureEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PictureEdit13 As DevExpress.XtraEditors.PictureEdit
End Class
