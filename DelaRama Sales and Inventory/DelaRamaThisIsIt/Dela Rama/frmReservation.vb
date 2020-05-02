Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class frmReservation
    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Public getID As Integer

    Private Sub frmReservation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()



            myConn = New SqlConnection(constr)
            DisplayRecords()

            ItemRecord()



            dtpDaRe.Value = DateString()
            dtpDade.Value = DateString()
            txtReservationID.ResetText()
            txtCustomerName.ResetText()
            txtAddress.ResetText()
            txtCotanct.ResetText()
            txtCategories.ResetText()
            txtItemName.ResetText()
            txtStock.ResetText()
            txtDescription.ResetText()
            txtFlavor.ResetText()
            txtTotal.ResetText()
            txtDown.ResetText()
            txtDown.ResetText()
            txtQuantity.ResetText()
            txtstocknew.ResetText()
            txtPrice.ResetText()
            txtTotalPrice.ResetText()

           
    End Sub




    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT ReservationID,CustomerName,Address,Contact,DateReserved,DateDeadline,Categories,ItemName,Description,Flavor,Quantity,Price,TotalPrice,Down,Stock,Stocknew From Reservation order by CustomerName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridViewre.Rows.Clear()
            While rd.Read


                If (count = 0) Then

                    txtReservationID.Text = rd("ReservationID").ToString
                    txtCustomerName.Text = rd("CustomerName").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtCotanct.Text = rd("Contact").ToString
                    dtpDaRe.Text = rd("DateReserved").ToString
                    dtpDade.Text = rd("DateDeadline").ToString
                    txtItemName.Text = rd("ItemName").ToString
                    txtCategories.Text = rd("Categories").ToString
                    txtDescription.Text = rd("Description").ToString
                    txtFlavor.Text = rd("Flavor").ToString
                    txtQuantity.Text = rd("Quantity").ToString
                    txtPrice.Text = rd("Price").ToString
                    txtTotalPrice.Text = rd("TotalPrice").ToString
                    txtDown.Text = rd("Down").ToString                   
                    txtStock.Text = rd("Stock").ToString
                    txtstocknew.Text = rd("Stocknew").ToString


                End If

                Dim x As Integer = DataGridViewre.Rows.Add()
                DataGridViewre.Rows(x).Cells(0).Value = rd("ReservationID").ToString
                DataGridViewre.Rows(x).Cells(1).Value = rd("CustomerName").ToString
                DataGridViewre.Rows(x).Cells(2).Value = rd("Address").ToString
                DataGridViewre.Rows(x).Cells(3).Value = rd("Contact").ToString
                DataGridViewre.Rows(x).Cells(4).Value = rd("DateReserved").ToString
                DataGridViewre.Rows(x).Cells(5).Value = rd("DateDeadline").ToString
                DataGridViewre.Rows(x).Cells(6).Value = rd("Categories").ToString
                DataGridViewre.Rows(x).Cells(7).Value = rd("ItemName").ToString
                DataGridViewre.Rows(x).Cells(8).Value = rd("Description").ToString
                DataGridViewre.Rows(x).Cells(9).Value = rd("Flavor").ToString
                DataGridViewre.Rows(x).Cells(10).Value = rd("Quantity").ToString
                DataGridViewre.Rows(x).Cells(11).Value = rd("Price").ToString
                DataGridViewre.Rows(x).Cells(12).Value = rd("TotalPrice").ToString
                DataGridViewre.Rows(x).Cells(13).Value = rd("Down").ToString

                DataGridViewre.Rows(x).Cells(14).Value = rd("Stock").ToString
                DataGridViewre.Rows(x).Cells(15).Value = rd("Stocknew").ToString


                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridViewre_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtReservationID.Text = DataGridViewre.CurrentRow.Cells(0).Value
            txtCustomerName.Text = DataGridViewre.CurrentRow.Cells(1).Value
            txtAddress.Text = DataGridViewre.CurrentRow.Cells(2).Value
            txtCotanct.Text = DataGridViewre.CurrentRow.Cells(3).Value
            dtpDaRe.Text = DataGridViewre.CurrentRow.Cells(4).Value
            dtpDade.Text = DataGridViewre.CurrentRow.Cells(5).Value
            txtCategories.Text = DataGridViewre.CurrentRow.Cells(6).Value
            txtItemName.Text = DataGridViewre.CurrentRow.Cells(7).Value
            txtDescription.Text = DataGridViewre.CurrentRow.Cells(8).Value
            txtFlavor.Text = DataGridViewre.CurrentRow.Cells(9).Value
            txtQuantity.Text = DataGridViewre.CurrentRow.Cells(10).Value
            txtPrice.Text = DataGridViewre.CurrentRow.Cells(11).Value
            txtTotalPrice.Text = DataGridViewre.CurrentRow.Cells(12).Value
            txtDown.Text = DataGridViewre.CurrentRow.Cells(13).Value

            txtStock.Text = DataGridViewre.CurrentRow.Cells(14).Value
            txtstocknew.Text = DataGridViewre.CurrentRow.Cells(15).Value
        Catch ex As Exception
            txtReservationID.Text = ""
            txtCustomerName.Text = ""
            txtAddress.Text = ""
            txtCotanct.Text = ""
            dtpDaRe.Text = ""
            dtpDade.Text = ""
            txtItemName.Text = ""
            txtCategories.Text = ""
            txtDescription.Text = ""
            txtFlavor.Text = ""
            txtQuantity.Text = ""
            txtPrice.Text = ""
            txtTotalPrice.Text = ""
            txtDown.Text = ""


            txtStock.Text = ""
            txtstocknew.Text = ""







        End Try
    End Sub


    Private Sub ItemRecord()

        Dim count As Integer = 0

        Try

            sql = "SELECT  * FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read


                If (count = 0) Then




                    txtItemName.Text = rd("ItemName").ToString
                    txtCategories.Text = rd("Categories").ToString
                    txtDescription.Text = rd("Description").ToString
                    txtFlavor.Text = rd("Flavor").ToString
                    txtPrice.Text = rd("Price").ToString
                    txtStock.Text = rd("Stock").ToString


                End If

                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Price").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("Stock").ToString



                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtItemName.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtCategories.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtDescription.Text = DataGridView1.CurrentRow.Cells(2).Value
            txtFlavor.Text = DataGridView1.CurrentRow.Cells(3).Value
            txtPrice.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtStock.Text = DataGridView1.CurrentRow.Cells(5).Value



        Catch ex As Exception

            txtItemName.Text = ""
            txtCategories.Text = ""
            txtDescription.Text = ""
            txtFlavor.Text = ""
            txtPrice.Text = ""
            txtStock.Text = ""








        End Try
    End Sub

    

    Private Sub PictureBox4Delete_Click(sender As System.Object, e As System.EventArgs)
        Dim result As DialogResult _
            = MessageBox.Show("Do you want to delete Reservation?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "DELETE FROM Reservation WHERE ReservationID='" & txtReservationID.Text.Trim() & "'"

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

   

  
    Private Sub ref()
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Price").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("Stock").ToString



            End While
            myConn.Close()
            cbSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

   

  

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            sql = "SELECT ReservationID,CustomerName,Address,Contact,DateReserved,DateDeadline,Categories,ItemName,Description,Flavor,Quantity,Price,TotalPrice,Down,Stock,Stocknew FROM Reservation Where CustomerName  LIKE '%" & txtSearch.Text.Trim() & "%'  Order by  CustomerName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridViewre.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridViewre.Rows.Add()
                DataGridViewre.Rows(x).Cells(0).Value = rd("ReservationID").ToString
                DataGridViewre.Rows(x).Cells(1).Value = rd("CustomerName").ToString
                DataGridViewre.Rows(x).Cells(2).Value = rd("Address").ToString
                DataGridViewre.Rows(x).Cells(3).Value = rd("Contact").ToString
                DataGridViewre.Rows(x).Cells(4).Value = rd("DateReserved").ToString
                DataGridViewre.Rows(x).Cells(5).Value = rd("DateDeadline").ToString
                DataGridViewre.Rows(x).Cells(6).Value = rd("Categories").ToString
                DataGridViewre.Rows(x).Cells(7).Value = rd("ItemName").ToString
                DataGridViewre.Rows(x).Cells(8).Value = rd("Description").ToString
                DataGridViewre.Rows(x).Cells(9).Value = rd("Flavor").ToString
                DataGridViewre.Rows(x).Cells(10).Value = rd("Quantity").ToString
                DataGridViewre.Rows(x).Cells(11).Value = rd("Price").ToString
                DataGridViewre.Rows(x).Cells(12).Value = rd("TotalPrice").ToString
                DataGridViewre.Rows(x).Cells(13).Value = rd("Down").ToString

                DataGridViewre.Rows(x).Cells(14).Value = rd("Stock").ToString
                DataGridViewre.Rows(x).Cells(15).Value = rd("Stocknew").ToString


            End While
            myConn.Close()
            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Try

            sql = "SELECT ReservationID,CustomerName,Address,Contact,DateReserved,DateDeadline,Categories,ItemName,Description,Flavor,Quantity,Price,TotalPrice,Down,Stock,Stocknew From Reservation order by CustomerName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridViewre.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridViewre.Rows.Add()
                DataGridViewre.Rows(x).Cells(0).Value = rd("ReservationID").ToString
                DataGridViewre.Rows(x).Cells(1).Value = rd("CustomerName").ToString
                DataGridViewre.Rows(x).Cells(2).Value = rd("Address").ToString
                DataGridViewre.Rows(x).Cells(3).Value = rd("Contact").ToString
                DataGridViewre.Rows(x).Cells(4).Value = rd("DateReserved").ToString
                DataGridViewre.Rows(x).Cells(5).Value = rd("DateDeadline").ToString
                DataGridViewre.Rows(x).Cells(6).Value = rd("Categories").ToString
                DataGridViewre.Rows(x).Cells(7).Value = rd("ItemName").ToString
                DataGridViewre.Rows(x).Cells(8).Value = rd("Description").ToString
                DataGridViewre.Rows(x).Cells(9).Value = rd("Flavor").ToString
                DataGridViewre.Rows(x).Cells(10).Value = rd("Quantity").ToString
                DataGridViewre.Rows(x).Cells(11).Value = rd("Price").ToString
                DataGridViewre.Rows(x).Cells(12).Value = rd("TotalPrice").ToString
                DataGridViewre.Rows(x).Cells(13).Value = rd("Down").ToString

                DataGridViewre.Rows(x).Cells(14).Value = rd("Stock").ToString
                DataGridViewre.Rows(x).Cells(15).Value = rd("Stocknew").ToString


            End While
            myConn.Close()
            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        
    End Sub

    Private Sub txtTotalPrice_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyUp, txtPrice.KeyUp
        price()
    End Sub
    Private Sub price()
        txtTotalPrice.Text = Val(txtPrice.Text) * Val(txtQuantity.Text)

    End Sub

    Private Sub DataGridViewre_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewre.CellClick
        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridViewre.Rows(count)
        txtReservationID.Text = selectrow.Cells(0).Value.ToString()
        txtCustomerName.Text = selectrow.Cells(1).Value.ToString()
        txtAddress.Text = selectrow.Cells(2).Value.ToString()
        txtCotanct.Text = selectrow.Cells(3).Value.ToString()
        dtpDaRe.Text = selectrow.Cells(4).Value.ToString()
        dtpDade.Text = selectrow.Cells(5).Value.ToString()
        txtCategories.Text = selectrow.Cells(6).Value.ToString()
        txtItemName.Text = selectrow.Cells(7).Value.ToString()
        txtDescription.Text = selectrow.Cells(8).Value.ToString()
        txtFlavor.Text = selectrow.Cells(9).Value.ToString()
        txtQuantity.Text = selectrow.Cells(10).Value.ToString()
        txtPrice.Text = selectrow.Cells(11).Value.ToString()
        txtTotalPrice.Text = selectrow.Cells(12).Value.ToString()
        'txtDown.Text = selectrow.Cells(13).Value.ToString()

        txtStock.Text = selectrow.Cells(14).Value.ToString()
        txtstocknew.Text = selectrow.Cells(15).Value.ToString()

       


    End Sub

    Private Sub Numbers_only(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCotanct.KeyPress, txtQuantity.KeyPress, txtPrice.KeyPress, txtTotalPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub btnSearchCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchCustomer.Click
        viewCustomerReservation.ShowDialog()
        ref()
    End Sub





    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridView1.Rows(count)      
        txtItemName.Text = selectrow.Cells(0).Value.ToString()    
        txtCategories.Text = selectrow.Cells(1).Value.ToString()
        txtDescription.Text = selectrow.Cells(2).Value.ToString()
        txtFlavor.Text = selectrow.Cells(3).Value.ToString()
        txtPrice.Text = selectrow.Cells(4).Value.ToString()
        txtStock.Text = selectrow.Cells(5).Value.ToString()

    End Sub

  

    Private Sub btnSearchItem_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchItem.Click
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price,Stock FROM Items Where Categories  LIKE '%" & cbSearch.Text.Trim() & "%' or  ItemName LIKE '%" & cbSearch.Text.Trim() & "%' Order by  ItemName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Price").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("Stock").ToString



            End While
            myConn.Close()
            cbSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnRefreshItem_Click(sender As System.Object, e As System.EventArgs) Handles btnRefreshItem.Click
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Price").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("Stock").ToString



            End While
            myConn.Close()
            cbSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtstocknew_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyUp, txtStock.KeyUp
        rs()
    End Sub

    Private Sub rs()
        txtstocknew.Text = Val(txtStock.Text) - Val(txtQuantity.Text)

    End Sub
   
    Private Sub frmReservation_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Try

            sql = "SELECT ReservationID,CustomerName,Address,Contact,DateReserved,DateDeadline,Categories,ItemName,Description,Flavor,Quantity,Price,TotalPrice,Down,Stock,Stocknew From Reservation order by CustomerName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridViewre.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridViewre.Rows.Add()
                DataGridViewre.Rows(x).Cells(0).Value = rd("ReservationID").ToString
                DataGridViewre.Rows(x).Cells(1).Value = rd("CustomerName").ToString
                DataGridViewre.Rows(x).Cells(2).Value = rd("Address").ToString
                DataGridViewre.Rows(x).Cells(3).Value = rd("Contact").ToString
                DataGridViewre.Rows(x).Cells(4).Value = rd("DateReserved").ToString
                DataGridViewre.Rows(x).Cells(5).Value = rd("DateDeadline").ToString
                DataGridViewre.Rows(x).Cells(6).Value = rd("Categories").ToString
                DataGridViewre.Rows(x).Cells(7).Value = rd("ItemName").ToString
                DataGridViewre.Rows(x).Cells(8).Value = rd("Description").ToString
                DataGridViewre.Rows(x).Cells(9).Value = rd("Flavor").ToString
                DataGridViewre.Rows(x).Cells(10).Value = rd("Quantity").ToString
                DataGridViewre.Rows(x).Cells(11).Value = rd("Price").ToString
                DataGridViewre.Rows(x).Cells(12).Value = rd("TotalPrice").ToString
                DataGridViewre.Rows(x).Cells(13).Value = rd("Down").ToString

                DataGridViewre.Rows(x).Cells(14).Value = rd("Stock").ToString
                DataGridViewre.Rows(x).Cells(15).Value = rd("Stocknew").ToString


            End While
            myConn.Close()

            txtSearch.ResetText()



            txtCustomerName.Focus()

         
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub DataGridView1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = Keys.Enter Then
            ref()
        End If
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

   

  

    
   
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

        Try
            sql = "UPDATE Reservation SET CustomerName='" & txtCustomerName.Text.Trim() & "',Address='" & txtAddress.Text.Trim() & "',Contact='" & txtCotanct.Text.Trim() & "',DateReserved='" & dtpDaRe.Value.ToShortDateString & "',DateDeadline='" & dtpDade.Value.ToShortDateString & "',ItemName='" & txtItemName.Text.Trim() & "',Categories='" & txtCategories.Text.Trim() & "',Description='" & txtDescription.Text.Trim() & "',Flavor='" & txtFlavor.Text.Trim() & "',Quantity='" & txtQuantity.Text.Trim() & "',Price='" & txtPrice.Text.Trim() & "',TotalPrice='" & txtTotalPrice.Text.Trim() & "',Down='" & txtDown.Text.Trim() & "',Stock='" & txtStock.Text.Trim() & "',Stocknew='" & txtstocknew.Text.Trim() & "'   WHERE   CustomerName='" & txtCustomerName.Text.Trim() & "' AND Categories='" & txtCategories.Text.Trim() & "'"


            cmd = New SqlCommand(sql, myConn)
            myConn.Open()

            cmd.ExecuteNonQuery()
            myConn.Close()
            txtTotal.ResetText()
            txtDown.ResetText()
            DisplayRecords()
            MsgBox("OK", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub txtTotal_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyUp, txtTotalPrice.KeyUp
        txtTotal.Text = Val(txtTotalPrice.Text) + Val(txtTotal.Text)
    End Sub

  
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtDown.ResetText()
        txtTotal.ResetText()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        txtReservationID.Text = ""
        txtCustomerName.Text = ""
        txtAddress.Text = ""
        txtCotanct.Text = ""
        dtpDaRe.Text = ""
        dtpDade.Text = ""
        txtCategories.Text = ""
        txtItemName.Text = ""
        txtDescription.Text = ""
        txtFlavor.Text = ""
        txtQuantity.Text = ""
        txtPrice.Text = ""
        txtTotalPrice.Text = ""
        txtStock.Text = ""
        txtDown.Text = ""
       
        txtCustomerName.Focus()
        ref()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click


        If (txtCustomerName.Text.Trim().Length = 0) Then
            MsgBox("CustomerName is empty!")
            txtCustomerName.SelectAll()
            txtCustomerName.Focus()
            Return
        End If
        If (txtItemName.Text.Trim().Length = 0) Then
            MsgBox("ItemName is empty!")
            txtItemName.SelectAll()
            txtItemName.Focus()
            Return
        End If


        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If


        If (txtCotanct.Text.Trim().Length = 0) Then
            MsgBox("Cotanct is empty!")
            txtCotanct.SelectAll()
            txtCotanct.Focus()
            Return
        End If


        If (dtpDaRe.Text.Trim().Length = 0) Then
            MsgBox("DateReserved is empty!")

            dtpDaRe.Focus()
            Return
        End If
        If (dtpDade.Text.Trim().Length = 0) Then
            MsgBox("DateDeadline is empty!")

            dtpDade.Focus()
            Return
        End If

        If (txtCategories.Text.Trim().Length = 0) Then
            MsgBox("Categories is empty!")
            txtCategories.SelectAll()
            txtCategories.Focus()
            Return
        End If





        If (txtQuantity.Text.Trim().Length = 0) Then
            MsgBox("Quantity is empty!")
            txtQuantity.SelectAll()
            txtQuantity.Focus()
            Return
        End If

        If (txtPrice.Text.Trim().Length = 0) Then
            MsgBox("Price is empty!")
            txtPrice.SelectAll()
            txtPrice.Focus()
            Return
        End If

        If (txtTotalPrice.Text.Trim().Length = 0) Then
            MsgBox("TotalPrice is empty!")
            txtTotalPrice.SelectAll()
            txtTotalPrice.Focus()
            Return
        End If

        Dim result As DialogResult _
            = MessageBox.Show("Do you want to save new Reservation ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try
                txtTotal.Text = Val(txtTotalPrice.Text) + Val(txtTotal.Text)
                sql = "INSERT  INTO Reservation (CustomerName,Address,Contact,DateReserved,DateDeadline,ItemName,Categories,Description,Flavor,Quantity,Price,TotalPrice,Down,Stock,Stocknew) VALUES ('" & txtCustomerName.Text.Trim() & "','" & txtAddress.Text.Trim() & "','" & txtCotanct.Text.Trim() & "','" & dtpDaRe.Value.ToShortDateString() & "','" & dtpDade.Value.ToShortDateString() & "','" & txtItemName.Text.Trim() & "','" & txtCategories.Text.Trim() & "','" & txtDescription.Text.Trim() & "','" & txtFlavor.Text.Trim() & "','" & txtQuantity.Text.Trim() & "','" & txtPrice.Text.Trim() & "','" & txtTotalPrice.Text.Trim() & "','" & txtDown.Text.Trim() & "','" & txtStock.Text.Trim() & "','" & txtstocknew.Text.Trim() & "')"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()
                ref()

                MsgBox("Successfully saved", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

       
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult _
                 = MessageBox.Show("Do you want to update Reservation ?", _
                   "Save", MessageBoxButtons.YesNo, _
                   MessageBoxIcon.Question)
        If result = DialogResult.Yes Then


            Try
                sql = "UPDATE Reservation SET CustomerName='" & txtCustomerName.Text.Trim() & "',Address='" & txtAddress.Text.Trim() & "',Contact='" & txtCotanct.Text.Trim() & "',DateReserved='" & dtpDaRe.Value.ToShortDateString & "',DateDeadline='" & dtpDade.Value.ToShortDateString & "',ItemName='" & txtItemName.Text.Trim() & "',Categories='" & txtCategories.Text.Trim() & "',Description='" & txtDescription.Text.Trim() & "',Flavor='" & txtFlavor.Text.Trim() & "',Quantity='" & txtQuantity.Text.Trim() & "',Price='" & txtPrice.Text.Trim() & "',TotalPrice='" & txtTotalPrice.Text.Trim() & "',Down='" & txtDown.Text.Trim() & "',Stock='" & txtStock.Text.Trim() & "',Stocknew='" & txtstocknew.Text.Trim() & "' WHERE ReservationID='" & txtReservationID.Text.Trim() & "'"


                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()
                ref()
                MsgBox("Successfully updated", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        End If
    End Sub

   
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim result As DialogResult _
        = MessageBox.Show("Do you want to delete Reservation?", _
          "Save", MessageBoxButtons.YesNo, _
          MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "DELETE FROM Reservation WHERE ReservationID='" & txtReservationID.Text.Trim() & "'"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()
                ref()
                MsgBox("Successfully deleted", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i = 0 To DataGridViewre.Rows.Count - 1
            Dim expdate = DataGridViewre.Rows(i).Cells(5).Value
            If expdate > Now Then
                DataGridViewre.Rows(i).DefaultCellStyle.BackColor = Color.White

            Else
                DataGridViewre.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMain.Show()
        Me.Hide()
        ref()
    End Sub

  
End Class