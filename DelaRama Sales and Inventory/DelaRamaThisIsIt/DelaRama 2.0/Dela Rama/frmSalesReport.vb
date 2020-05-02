
Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmSalesReport
    Dim constr As String = "Data Source=DESKTOP-PQDQ9A9\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
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

            sql = "Select convert(varchar, Date, 101) as Date,ItemName,Price, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from SalesReport Group By convert(varchar, Date, 101),ItemName,Price"
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

    Private Sub btnGo_Click(sender As System.Object, e As System.EventArgs) Handles btnGo.Click
        Try

            sql = "Select convert(varchar, Date, 101) as Date,ItemName,Price, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from SalesReport  WHERE Date between '" & dtpFrom.Value.Date & "' and '" & dtpTo.Value.Date & "' Group By convert(varchar, Date, 101),ItemName,Price"
          

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

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Try

            sql = "Select convert(varchar, Date, 101) as Date,ItemName,Price, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from SalesReport Group By convert(varchar, Date, 101),ItemName,Price"
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

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        Dim result As DialogResult _
         = MessageBox.Show("Do you want to Delete History ?", _
           "Save", MessageBoxButtons.YesNo, _
           MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "DELETE FROM SalesReport "

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()


               

                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully deleted", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

  

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        frmMain.Show()
        Me.Hide()
    End Sub

   


   

   

    
   

    
  
    Private Sub DataGridViewreport_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewreport.CellContentClick
        Try

            sql = "Select convert(varchar, Date, 101) as Date,ItemName,Price, Sum(Quantity) as Quantity, Sum(TotalPrice) as TotalPrice from SalesReport Group By convert(varchar, Date, 101),ItemName,Price"
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



   
   
   
    
End Class