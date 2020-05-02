
Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMain

    Dim constr As String = "Data Source=DESKTOP-PQDQ9A9\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand()
    Dim sql As String

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try


            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()

            cmd.ExecuteNonQuery()
            myConn.Close()


            MsgBox("Successfull added!", MsgBoxStyle.Information)
        Catch
        End Try
    End Sub


    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

        Dim result As DialogResult _
            = MessageBox.Show("Do you really want to log out ?",
              "Save", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If

    End Sub



   



    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        'frmItems.ShowDialog()

        'frmItems.Dispose()
      

        frmItems.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        frmReservation.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        frmOrders.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        frmSalesReport.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmCustomer.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmEmployee.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class