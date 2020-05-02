Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmCustomerReservationUser
    Public id, you, add, con, las As String
    Public getID As Integer

    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Private Sub frmCustomerReservationUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtSearchSheet.ResetText()
        myConn = New SqlConnection(constr)

        DisplayRecords()
    End Sub
    Private Sub DisplayRecords()

        Dim count As Integer = 0
        myConn.Close()

        sql = "SELECT * FROM Customers WHERE Firstname LIKE '%" & txtSearchSheet.Text.Trim() & "%' "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        While rd.Read

            id = rd("CustomerID").ToString
            you = rd("Firstname").ToString
            las = rd("Lastname").ToString


            Dim x As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(x).Cells(0).Value = rd("CustomerID").ToString
            DataGridView1.Rows(x).Cells(1).Value = rd("Firstname").ToString
            DataGridView1.Rows(x).Cells(2).Value = rd("Lastname").ToString


            count = count + 1

        End While
        myConn.Close()

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            Dim studID = txtSearchSheet.Text



        Catch ex As Exception

        End Try

        If (txtSearchSheet.Text.Trim().Length = 0) Then
            MsgBox("Search Box is empty!")
            txtSearchSheet.SelectAll()
            txtSearchSheet.Focus()
            Return

        Else
            save()
            Me.Close()
        End If

    End Sub

    Public Sub save()

        sql = "Select CustomerID,Address,Contact,   Lastname + ','   + Firstname as  Name FROM Customers where Firstname = '" & txtSearchSheet.Text & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        If rd.Read Then
            id = rd("CustomerID").ToString
            Name = rd("Name").ToString
            add = rd("Address").ToString
            con = rd("Contact").ToString

            frmReservationUser.txtCustomerName.Text = Name
            frmReservationUser.txtAddress.Text = add
            frmReservationUser.txtCotanct.Text = con



        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridView1.Rows(count)
        txtSearchSheet.Text = selectrow.Cells(0).Value.ToString()
        txtSearchSheet.Text = selectrow.Cells(1).Value.ToString()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            sql = "SELECT CustomerID,Lastname,Firstname,Middlename,Gender,Contact,Address,Email FROM Customers Where Lastname  LIKE '%" & txtSearchSheet.Text.Trim() & "%' or  Firstname LIKE '%" & txtSearchSheet.Text.Trim() & "%'  Order by  Firstname"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read

                id = rd("CustomerID").ToString
                you = rd("Firstname").ToString
                las = rd("Lastname").ToString


                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("CustomerID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Firstname").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("Lastname").ToString


            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Try

            sql = "SELECT CustomerID,Lastname,Firstname,Middlename,Gender,Contact,Address,Email FROM Customers "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read

                id = rd("CustomerID").ToString
                you = rd("Firstname").ToString
                las = rd("Lastname").ToString


                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("CustomerID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Firstname").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("Lastname").ToString


            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class