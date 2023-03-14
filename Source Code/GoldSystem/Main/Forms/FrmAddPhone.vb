Public Class FrmAddPhone
    Dim ClsMain_ As New ClsMain
    Public CID As String
    Private Sub FrmAddPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGC.DataSource = ClsMain_.GetPhones(CID)
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RIBDelete.ButtonClick
        If MsgBox("هل تريد حذف رقم الهاتف؟", vbYesNo) = vbYes Then
            ClsMain_.DelPhone(DGV.GetFocusedDataRow("CID"), DGV.GetFocusedDataRow("Phone"))
            DGV.DeleteSelectedRows()
        End If
    End Sub

    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        Close()
    End Sub

    Private Sub pbAddStone_Click(sender As Object, e As EventArgs) Handles pbAddStone.Click
        If ClsMain_.SearchPhone(CID, txtPhoneNo.Text.Trim) = False Then
            ClsMain_.SavePhone(CID, txtPhoneNo.Text.Trim)
            DGC.DataSource = ClsMain_.GetPhones(CID)
        Else
            MsgBox("الرقم مسجل من قبل", vbExclamation)
        End If
    End Sub
End Class