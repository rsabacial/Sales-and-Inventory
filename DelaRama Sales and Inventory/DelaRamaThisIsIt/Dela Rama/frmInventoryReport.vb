
Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmInventoryReport
    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Private Sub frmInventoryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)
        DisplayRecord()
        dtpFrom.Value = DateString()
        dtpTo.Value = DateString()
    End Sub

    Private Sub DisplayRecord()

        Dim count As Integer = 0

        Try


            sql = "Select Date,Categories,ItemName,Descriptionss,Flavor,Damage, Max(StockFrom) as TotalStock, Min(Stock) as Stock, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from InventoryReport   Group By Date,Categories,ItemName,Descriptionss,Flavor,Damage"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read


                ' If (count = 0) Then

                ' txtReservationID.Text = rd("ReservationID").ToString
                '  txtCustomerName.Text = rd("CustomerName").ToString
                ' txtAddress.Text = rd("Address").ToString
                'txtCotanct.Text = rd("Contact").ToString
                'dtpDaRe.Text = rd("DateReserved").ToString
                'dtpDade.Text = rd("DateDeadline").ToString
                'txtItemName.Text = rd("ItemName").ToString
                'txtCategories.Text = rd("Categories").ToString
                'txtDescription.Text = rd("Description").ToString
                'txtFlavor.Text = rd("Flavor").ToString
                ' txtQuantity.Text = rd("Quantity").ToString
                ' txtPrice.Text = rd("Price").ToString
                'txtTotalPrice.Text = rd("TotalPrice").ToString


                ' End If

                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("Date").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Descriptionss").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("TotalStock").ToString
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Quantity").ToString
                DataGridView1.Rows(x).Cells(8).Value = rd("Damage").ToString
                DataGridView1.Rows(x).Cells(9).Value = rd("TotalPrice").ToString



                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub BtnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGo.Click
        Try

            sql = "Select  Date,Categories,ItemName,Descriptionss,Flavor,Damage, Max(StockFrom) as TotalStock, Min(Stock) as Stock, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from InventoryReport WHERE Date between '" & dtpFrom.Value.Date & "' and '" & dtpTo.Value.Date & "'   Group By Date,Categories,ItemName,Descriptionss,Flavor,Damage"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("Date").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Descriptionss").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("TotalStock").ToString
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Quantity").ToString
                DataGridView1.Rows(x).Cells(8).Value = rd("Damage").ToString
                DataGridView1.Rows(x).Cells(9).Value = rd("TotalPrice").ToString


            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Try

            sql = "Select Date,Categories,ItemName,Descriptionss,Flavor,Damage, Max(StockFrom) as TotalStock, Min(Stock) as Stock, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from InventoryReport   Group By Date,Categories,ItemName,Descriptionss,Flavor,Damage"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("Date").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Descriptionss").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("TotalStock").ToString
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Quantity").ToString
                DataGridView1.Rows(x).Cells(8).Value = rd("Damage").ToString
                DataGridView1.Rows(x).Cells(9).Value = rd("TotalPrice").ToString


            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

   

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmInventoryReport_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try

            sql = "Select  Date,Categories,ItemName,Descriptionss,Flavor,Damage, Max(StockFrom) as TotalStock, Min(Stock) as Stock, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from InventoryReport   Group By Date,Categories,ItemName,Descriptionss,Flavor,Damage"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("Date").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Descriptionss").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("TotalStock").ToString
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Quantity").ToString
                DataGridView1.Rows(x).Cells(8).Value = rd("Damage").ToString
                DataGridView1.Rows(x).Cells(9).Value = rd("TotalPrice").ToString


            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmPrintInventory.Show()
    End Sub
End Class