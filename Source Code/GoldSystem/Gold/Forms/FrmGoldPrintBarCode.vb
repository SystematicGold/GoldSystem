Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class FrmGoldPrintBarCode
    Private Sub PictureEdit5_Click(sender As Object, e As EventArgs) Handles PictureEdit8.Click, PictureEdit12.Click, PictureEdit10.Click
        Try
            Dim ADAPTER As New SqlDataAdapter
            Dim F As New PrintBarCode
            F.DataSource = Nothing
            F.DataAdapter = ADAPTER
            F.DataMember = "23"
            Dim TOOL As IReportPrintTool = New ReportPrintTool(F)
            F.LoadLayout("PrintBarCode.repx")
            F.CreateDocument()
            F.ShowPreview

            'Dim f As New Form1
            'f.Show()
        Catch ex As Exception

        End Try
    End Sub


End Class