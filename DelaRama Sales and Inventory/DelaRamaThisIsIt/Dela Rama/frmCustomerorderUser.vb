
Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmCustomerorderUser
    Public id, you, Cat, Ite, Des, Fla, Pri, Quan, tot, Sto, down, Sne, ex As String
    Public getID As Integer
    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Private Sub frmCustomerorderUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        txtSearchSheet.ResetText()
        myConn = New SqlConnection(constr)

        DisplayRecords()
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0
        myConn.Close()

        sql = "Select ReservationID,CustomerName,Categories,ItemName,DateDeadline From Reservation WHERE ReservationID LIKE '%" & txtSearchSheet.Text.Trim() & "%' "

        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        While rd.Read

            id = rd("ReservationID").ToString
            you = rd("CustomerName").ToString
            Cat = rd("Categories").ToString
            Ite = rd("ItemName").ToString
            Ite = rd("DateDeadline").ToString

            Dim x As Integer = DataGridView1.Rows.Add()
            DataGridView1.Rows(x).Cells(0).Value = rd("ReservationID").ToString
            DataGridView1.Rows(x).Cells(1).Value = rd("CustomerName").ToString
            DataGridView1.Rows(x).Cells(2).Value = rd("Categories").ToString
            DataGridView1.Rows(x).Cells(3).Value = rd("ItemName").ToString
            DataGridView1.Rows(x).Cells(4).Value = rd("DateDeadline").ToString

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

        sql = "Select  ReservationID,CustomerName,Address,Contact,DateReserved,DateDeadline,Categories,ItemName,Description,Flavor,Quantity,Price,TotalPrice,Stock,Stocknew From Reservation where ReservationID = '" & txtSearchSheet.Text & "'"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader

        If rd.Read Then
            id = rd("ReservationID").ToString
            Name = rd("CustomerName").ToString
            Ite = rd("ItemName").ToString
            Cat = rd("Categories").ToString
            Des = rd("Description").ToString
            Fla = rd("Flavor").ToString
            Pri = rd("Price").ToString
            Quan = rd("Quantity").ToString
            tot = rd("TotalPrice").ToString
            Sto = rd("Stock").ToString


            Sne = rd("Stocknew").ToString









            frmOrderUser.txtCustomerName.Text = Name
            frmOrderUser.txtItemName.Text = Ite
            frmOrderUser.txtItem2.Text = Ite
            frmOrderUser.txtCategories.Text = Cat
            frmOrderUser.txtDescription.Text = Des
            frmOrderUser.txtFlavor.Text = Fla
            frmOrderUser.txtPrice.Text = Pri
            frmOrderUser.txtQuantity.Text = Quan
            frmOrderUser.txtTotalPrice.Text = tot
            frmOrderUser.txtStock.Text = Sto


            frmOrderUser.txtStockNew.Text = Sne





        End If
        myConn.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridView1.Rows(count)
        txtSearchSheet.Text = selectrow.Cells(0).Value.ToString()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            sql = "Select ReservationID,CustomerName,Categories,ItemName,DateDeadline From Reservation WHERE CustomerName LIKE '%" & txtSearchSheet.Text.Trim() & "%' "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read

                id = rd("ReservationID").ToString
                you = rd("CustomerName").ToString
                Cat = rd("Categories").ToString
                Ite = rd("ItemName").ToString
                Ite = rd("DateDeadline").ToString

                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ReservationID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("CustomerName").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("DateDeadline").ToString

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Try

            sql = "SELECT * From Reservation "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read

                id = rd("ReservationID").ToString
                you = rd("CustomerName").ToString
                Cat = rd("Categories").ToString
                Ite = rd("ItemName").ToString
                Ite = rd("DateDeadline").ToString

                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ReservationID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("CustomerName").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("DateDeadline").ToString

            End While
            myConn.Close()
            txtSearchSheet.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim expdate = DataGridView1.Rows(i).Cells(4).Value
            If expdate > Now Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White

            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub
End Class