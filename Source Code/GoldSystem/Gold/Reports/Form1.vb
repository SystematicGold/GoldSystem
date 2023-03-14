Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportDesigner1.OpenReport(New PrintBarCode)
    End Sub
End Class