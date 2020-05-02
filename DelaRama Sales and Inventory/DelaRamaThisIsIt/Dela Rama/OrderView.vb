Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class OrderView
    Public id, you As String
    Public getID As Integer
    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String

    Private Sub OrderView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtSearch.ResetText()
        myConn = New SqlConnection(constr)

        DisplayRecords()
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0
        myConn.Close()

        sql = "Select CustomerName,Max(Down) as Down from reservation WHERE CustomerName LIKE '%" & txtSearch.Text.Trim() & "%' group by CustomerName "


        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        While rd.Read

            id = rd("CustomerName").ToString
            you = rd("Down").ToString
           


            Dim x As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(x).Cells(0).Value = rd("CustomerName").ToString
            DataGridView1.Rows(x).Cells(1).Value = rd("Down").ToString
           


            count = count + 1

        End While
        myConn.Close()
    End Sub

    

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            Dim studID = txtSearch.Text



        Catch ex As Exception

        End Try

        If (txtSearch.Text.Trim().Length = 0) Then
            MsgBox("Search Box is empty!")
            txtSearch.SelectAll()
            txtSearch.Focus()
            Return

        Else
            save()
            del()
            Me.Close()

        End If

    End Sub
    Public Sub save()

        sql = "Select CustomerName,Max(Down) as Down from reservation where CustomerName = '" & txtSearch.Text & "' group by CustomerName "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        If rd.Read Then
            id = rd("CustomerName").ToString
            Name = rd("Down").ToString
           

           









            frmOrders.txtdown.Text = Name
            




        End If
        myConn.Close()

    End Sub

    Private Sub del()
        Try

            sql = "DELETE FROM Reservation WHERE CustomerName='" & txtSearch.Text.Trim() & "'"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()



            cmd.ExecuteNonQuery()
            myConn.Close()

            'MsgBox("Successfully deleted", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridView1.Rows(count)
        txtSearch.Text = selectrow.Cells(0).Value.ToString()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            sql = "Select CustomerName,Max(Down) as Down from reservation  WHERE CustomerName LIKE '%" & txtSearch.Text.Trim() & "%' group by CustomerName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read

                id = rd("CustomerName").ToString
                you = rd("Down").ToString
               
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("CustomerName").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Down").ToString
               

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Try

            sql = "Select CustomerName,Max(Down) as Down from reservation WHERE CustomerName LIKE '%" & txtSearch.Text.Trim() & "%' group by CustomerName "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read

                id = rd("CustomerName").ToString
                you = rd("Down").ToString
               


                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("CustomerName").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Down").ToString
               

            End While
            myConn.Close()
            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

   
   
    
End Class