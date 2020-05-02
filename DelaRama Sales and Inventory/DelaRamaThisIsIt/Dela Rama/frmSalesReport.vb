
Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmSalesReport
    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String


    Private Sub frmSalesReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)
        DisplayRecords()

        
       
        dtpFrom.Value = DateString()
        dtpTo.Value = DateString()
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "Select  Date,ItemName,Price, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from SalesReport Group By Date,ItemName,Price"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridViewreport.Rows.Clear()
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

                Dim x As Integer = DataGridViewreport.Rows.Add()
                DataGridViewreport.Rows(x).Cells(0).Value = rd("Date").ToString
                DataGridViewreport.Rows(x).Cells(1).Value = rd("ItemName").ToString
                DataGridViewreport.Rows(x).Cells(2).Value = rd("Price").ToString
                DataGridViewreport.Rows(x).Cells(3).Value = rd("Quantity").ToString
                DataGridViewreport.Rows(x).Cells(4).Value = rd("TotalPrice").ToString




                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        
    End Sub


    Private Sub frmSalesReport_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Try

            sql = "Select  Date,ItemName,Price, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from SalesReport Group By Date,ItemName,Price"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridViewreport.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridViewreport.Rows.Add()
                DataGridViewreport.Rows(x).Cells(0).Value = rd("Date").ToString
                DataGridViewreport.Rows(x).Cells(1).Value = rd("ItemName").ToString
                DataGridViewreport.Rows(x).Cells(2).Value = rd("Price").ToString
                DataGridViewreport.Rows(x).Cells(3).Value = rd("Quantity").ToString
                DataGridViewreport.Rows(x).Cells(4).Value = rd("TotalPrice").ToString



            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

   

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            sql = "Select  Date,ItemName,Price, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from SalesReport  WHERE Date between '" & dtpFrom.Value.Date & "' and '" & dtpTo.Value.Date & "' Group By Date,ItemName,Price"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridViewreport.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridViewreport.Rows.Add()
                DataGridViewreport.Rows(x).Cells(0).Value = rd("Date").ToString
                DataGridViewreport.Rows(x).Cells(1).Value = rd("ItemName").ToString
                DataGridViewreport.Rows(x).Cells(2).Value = rd("Price").ToString
                DataGridViewreport.Rows(x).Cells(3).Value = rd("Quantity").ToString
                DataGridViewreport.Rows(x).Cells(4).Value = rd("TotalPrice").ToString



            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            sql = "Select Date,ItemName,Price, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from SalesReport Group By Date,ItemName,Price"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridViewreport.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridViewreport.Rows.Add()
                DataGridViewreport.Rows(x).Cells(0).Value = rd("Date").ToString
                DataGridViewreport.Rows(x).Cells(1).Value = rd("ItemName").ToString
                DataGridViewreport.Rows(x).Cells(2).Value = rd("Price").ToString
                DataGridViewreport.Rows(x).Cells(3).Value = rd("Quantity").ToString
                DataGridViewreport.Rows(x).Cells(4).Value = rd("TotalPrice").ToString



            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmPrintSales.Show()
    End Sub
End Class