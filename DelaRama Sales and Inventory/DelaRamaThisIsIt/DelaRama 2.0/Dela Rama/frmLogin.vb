Imports System.Data.SqlClient

Public Class frmLogin

  

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusername.ResetText()
        txtpassword.ResetText()
    End Sub


  
    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        Dim Myconn As New SqlConnection
        Dim cmd As New SqlCommand

        Myconn.ConnectionString = "Data Source=DESKTOP-PQDQ9A9\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
        Dim sql As String = "SELECT Username, Password FROM Userss"

        Dim da As New SqlDataAdapter(sql, Myconn)
        Dim ds As DataSet
        ds = New DataSet()
        da.Fill(ds)
        Dim dv As DataView
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = "Username = '" & txtusername.Text & "' AND Password = '" & (txtpassword.Text.Trim()) & "'"

        If dv.Count > 0 Then
            MessageBox.Show("Logged in Successfully")
            Me.Hide()
            frmMain.Show()


        Else
            MessageBox.Show("You have entered the wrong Username/Password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        txtpassword.ResetText()
        txtusername.ResetText()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then Application.Exit()
    End Sub
End Class
