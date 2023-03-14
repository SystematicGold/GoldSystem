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
        Me.pbStar = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.pbStar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbStar
        '
        Me.pbStar.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbStar.EditValue = CType(resources.GetObject("pbStar.EditValue"), Object)
        Me.pbStar.Location = New System.Drawing.Point(0, 0)
        Me.pbStar.Name = "pbStar"
        Me.pbStar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pbStar.Properties.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.pbStar.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.pbStar.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.pbStar.Properties.Appearance.Options.UseBackColor = True
        Me.pbStar.Properties.Appearance.Options.UseBorderColor = True
        Me.pbStar.Properties.Appearance.Options.UseForeColor = True
        Me.pbStar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pbStar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pbStar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.pbStar.Size = New System.Drawing.Size(30, 30)
        Me.pbStar.TabIndex = 56
        '
        'UCFavorite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pbStar)
        Me.Name = "UCFavorite"
        Me.Size = New System.Drawing.Size(30, 30)
        CType(Me.pbStar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pbStar As DevExpress.XtraEditors.PictureEdit
End Class
