Imports System.Text

Public Class FrmMain
    Dim ClsMain_ As New ClsMain
    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            End
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PanelAll.Visible = True
            PanalGold.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            PanalGold.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim f As New XtraReport1

    End Sub
    Private Sub PictureEdit1_Click_1(sender As Object, e As EventArgs) Handles PictureEdit1.Click
        Try
            PanalGold.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Try
            Toggle = Not Toggle
            Timer1.Start()
            SettingMenu.Visible = True
            If Toggle = False Then
                SettingMenu.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Dim pl As Integer = 0
    Dim Toggle As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Toggle = True Then
                If pl > 202 Then
                    Timer1.Stop()
                Else
                    SettingMenu.Size = New Size(SettingMenu.Size.Width, pl)
                    pl += 10
                End If
            Else
                If pl <= 0 Then
                    Timer1.Stop()
                Else
                    SettingMenu.Size = New Size(SettingMenu.Size.Width, pl)
                    pl -= 10
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2GradientPanel1_Click(sender As Object, e As EventArgs) Handles Guna2GradientPanel1.Click
        Try
            Dim f As New FrmMaxmizeGold
            f.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Guna2GradientButton16_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton16.Click
        Try
            Dim F As New FrmAddCat
            Dim dt As New DataTable
            dt.Clear()
            dt = ClsMain_.GetItemCode()
            If dt.Rows.Count > 0 Then
                F.TxtCode.Text = dt.Rows(0)(0)
                F.TxtCodeBlock.Text = dt.Rows(0)(0)
                Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghigklmnopqrstuvxyz"
                Dim r As New Random
                Dim sb As New StringBuilder
                For i As Integer = 1 To 8
                    Dim idx As Integer = r.Next(0, 35)
                    sb.Append(s.Substring(idx, 1))
                Next
                F.TxtBarCode.Text = sb.ToString()
                F.TxtBarCodeBlock.Text = sb.ToString()
            End If
            F.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class
