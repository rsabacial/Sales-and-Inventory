
Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmOrderUser
    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Private Sub frmOrderUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)
        DisplayRecords()
        ro()



        txtOrderID.ResetText()
        txtCustomerName.ResetText()
        txtCategories.ResetText()
        txtItemName.ResetText()
        txtItem2.ResetText()
        txtDescription.ResetText()
        txtFlavor.ResetText()
        txtQuantity.ResetText()
        txtPrice.ResetText()
        txtTotalPrice.ResetText()
        txtStock.ResetText()
        txtStockNew.ResetText()

        txtBalance.ResetText()
        txtPayment.ResetText()
        txtChange.ResetText()
        txtCustomerName.Focus()

    End Sub

    Private Sub ro()

        Dim count As Integer = 0

        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView2.Rows.Clear()
            While rd.Read


                If (count = 0) Then




                    txtItemName.Text = rd("ItemName").ToString
                    txtItem2.Text = rd("ItemName").ToString
                    txtCategories.Text = rd("Categories").ToString
                    txtDescription.Text = rd("Description").ToString
                    txtFlavor.Text = rd("Flavor").ToString
                    txtStock.Text = rd("Stock").ToString
                    txtPrice.Text = rd("Price").ToString


                End If

                Dim x As Integer = DataGridView2.Rows.Add()
                DataGridView2.Rows(x).Cells(0).Value = rd("ItemName").ToString
                DataGridView2.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView2.Rows(x).Cells(2).Value = rd("Description").ToString
                DataGridView2.Rows(x).Cells(3).Value = rd("Flavor").ToString
                DataGridView2.Rows(x).Cells(4).Value = rd("Stock").ToString
                DataGridView2.Rows(x).Cells(5).Value = rd("Price").ToString



                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView2_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtItemName.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtCategories.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtDescription.Text = DataGridView1.CurrentRow.Cells(2).Value
            txtFlavor.Text = DataGridView1.CurrentRow.Cells(3).Value
            txtStock.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtPrice.Text = DataGridView1.CurrentRow.Cells(5).Value



        Catch ex As Exception

            txtItemName.Text = ""
            txtCategories.Text = ""
            txtDescription.Text = ""
            txtFlavor.Text = ""
            txtStock.Text = ""
            txtPrice.Text = ""








        End Try
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT OrderID,CustomerName,ItemName,Categories,Description,Flavor,Quantity,Price,TotalPrice From Orders"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read


                If (count = 0) Then
                    txtOrderID.Text = rd("OrderID").ToString
                    txtCustomerName.Text = rd("CustomerName").ToString
                    txtItemName.Text = rd("ItemName").ToString
                    txtCategories.Text = rd("Categories").ToString
                    txtDescription.Text = rd("Description").ToString
                    txtFlavor.Text = rd("Flavor").ToString
                    txtPrice.Text = rd("Price").ToString
                    txtQuantity.Text = rd("Quantity").ToString
                    txtTotalPrice.Text = rd("TotalPrice").ToString

                End If

                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("OrderID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("CustomerName").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(6).Value = rd("Price").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Quantity").ToString
                DataGridView1.Rows(x).Cells(8).Value = rd("TotalPrice").ToString




                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtOrderID.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtCustomerName.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtItemName.Text = DataGridView1.CurrentRow.Cells(2).Value
            txtCategories.Text = DataGridView1.CurrentRow.Cells(3).Value
            txtDescription.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtFlavor.Text = DataGridView1.CurrentRow.Cells(5).Value
            txtPrice.Text = DataGridView1.CurrentRow.Cells(6).Value
            txtQuantity.Text = DataGridView1.CurrentRow.Cells(7).Value
            txtTotalPrice.Text = DataGridView1.CurrentRow.Cells(8).Value


        Catch ex As Exception

            txtOrderID.Text = ""
            txtCustomerName.Text = ""
            txtItemName.Text = ""
            txtCategories.Text = ""
            txtDescription.Text = ""
            txtFlavor.Text = ""
            txtPrice.Text = ""
            txtQuantity.Text = ""
            txtTotalPrice.Text = ""








        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)



    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If (txtQuantity.Text.Trim().Length = 0) Then
            MsgBox("Must contain a quantity!")
            txtQuantity.SelectAll()
            txtQuantity.Focus()
            Return

        End If

        If txtStockNew.Text = "5" Then
            MessageBox.Show("Time to reorder this Item !", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
        End If
        If txtStockNew.Text = "4" Then
            MessageBox.Show("Time to reorder this Item !", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
        End If
        If txtStockNew.Text = "3" Then
            MessageBox.Show("Time to reorder this Item !", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
        End If
        If txtStockNew.Text = "2" Then
            MessageBox.Show("Time to reorder this Item !", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
        End If
        If txtStockNew.Text = "1" Then
            MessageBox.Show("Time to reorder this Item !", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
        End If
        If txtStockNew.Text = "0" Then
            MessageBox.Show("Time to reorder this Item !", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
        End If


        If txtStock.Text = "0" Then
            MessageBox.Show("Out of Stock ?", _
                   "Save", MessageBoxButtons.OK, _
                   MessageBoxIcon.Warning)
            txtStockNew.SelectAll()
            txtStockNew.Focus()
            txtOrderID.ResetText()
            txtCustomerName.ResetText()
            txtCategories.ResetText()
            txtItemName.ResetText()
            txtItem2.ResetText()
            txtDescription.ResetText()
            txtFlavor.ResetText()
            txtQuantity.ResetText()
            txtPrice.ResetText()
            txtTotalPrice.ResetText()
            txtStock.ResetText()
            txtStockNew.ResetText()
            txtBalance.ResetText()
            txtPayment.ResetText()
            txtChange.ResetText()
            Return

        End If
        If txtStock.Text = "-1" Then
            MessageBox.Show("Out of Stock ?", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
            txtStockNew.SelectAll()
            txtStockNew.Focus()
            txtOrderID.ResetText()
            txtCustomerName.ResetText()
            txtCategories.ResetText()
            txtItemName.ResetText()
            txtItem2.ResetText()
            txtDescription.ResetText()
            txtFlavor.ResetText()
            txtQuantity.ResetText()
            txtPrice.ResetText()
            txtTotalPrice.ResetText()
            txtStock.ResetText()
            txtStockNew.ResetText()
            txtBalance.ResetText()
            txtPayment.ResetText()
            txtChange.ResetText()
            Return

        End If
        If txtStock.Text = "-2" Then
            MessageBox.Show("Out of Stock ?", _
                 "Save", MessageBoxButtons.OK, _
                 MessageBoxIcon.Warning)
            txtStockNew.SelectAll()
            txtStockNew.Focus()
            txtOrderID.ResetText()
            txtCustomerName.ResetText()
            txtCategories.ResetText()
            txtItemName.ResetText()
            txtItem2.ResetText()
            txtDescription.ResetText()
            txtFlavor.ResetText()
            txtQuantity.ResetText()
            txtPrice.ResetText()
            txtTotalPrice.ResetText()
            txtStock.ResetText()
            txtStockNew.ResetText()
            txtBalance.ResetText()
            txtPayment.ResetText()
            txtChange.ResetText()
            Return

        End If
        If txtStock.Text = "-3" Then
            MessageBox.Show("Out of Stock ?", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
            txtStockNew.SelectAll()
            txtStockNew.Focus()
            txtOrderID.ResetText()
            txtCustomerName.ResetText()
            txtCategories.ResetText()
            txtItemName.ResetText()
            txtItem2.ResetText()
            txtDescription.ResetText()
            txtFlavor.ResetText()
            txtQuantity.ResetText()
            txtPrice.ResetText()
            txtTotalPrice.ResetText()
            txtStock.ResetText()
            txtStockNew.ResetText()
            txtBalance.ResetText()
            txtPayment.ResetText()
            txtChange.ResetText()
            Return

        End If
        If txtStock.Text = "-4" Then
            MessageBox.Show("Out of Stock ?", _
                  "Save", MessageBoxButtons.OK, _
                  MessageBoxIcon.Warning)
            txtStockNew.SelectAll()
            txtStockNew.Focus()
            txtOrderID.ResetText()
            txtCustomerName.ResetText()
            txtCategories.ResetText()
            txtItemName.ResetText()
            txtItem2.ResetText()
            txtDescription.ResetText()
            txtFlavor.ResetText()
            txtQuantity.ResetText()
            txtPrice.ResetText()
            txtTotalPrice.ResetText()
            txtStock.ResetText()
            txtStockNew.ResetText()
            txtBalance.ResetText()
            txtPayment.ResetText()
            txtChange.ResetText()
            Return

        End If
        If txtStock.Text = "-5" Then
            MessageBox.Show("Out of Stock ?", _
                   "Save", MessageBoxButtons.OK, _
                   MessageBoxIcon.Warning)
            txtStockNew.SelectAll()
            txtStockNew.Focus()
            txtOrderID.ResetText()
            txtCustomerName.ResetText()
            txtCategories.ResetText()
            txtItemName.ResetText()
            txtItem2.ResetText()
            txtDescription.ResetText()
            txtFlavor.ResetText()
            txtQuantity.ResetText()
            txtPrice.ResetText()
            txtTotalPrice.ResetText()
            txtStock.ResetText()
            txtStockNew.ResetText()
            txtBalance.ResetText()
            txtPayment.ResetText()
            txtChange.ResetText()
            Return

        End If


        Dim result As DialogResult _
         = MessageBox.Show("Do you want to add transaction ?", _
           "Save!", MessageBoxButtons.YesNo, _
           MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try
                'txtTotalPrice.Text = (txtPrice.Text) + (txtPrice.Text)
                sql = "INSERT  INTO Orders (CustomerName,ItemName,Categories,Description,Flavor,Price,Quantity,TotalPrice) VALUES ('" & txtCustomerName.Text.Trim() & "','" & txtItemName.Text.Trim() & "','" & txtCategories.Text.Trim() & "','" & txtDescription.Text.Trim() & "','" & txtFlavor.Text.Trim() & "','" & txtPrice.Text.Trim() & "','" & txtQuantity.Text.Trim() & "','" & txtTotalPrice.Text.Trim() & "')"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()


                cmd.ExecuteNonQuery()
                myConn.Close()


                If (txtQuantity.Text.Trim().Length = 0) Then
                    MsgBox("Must contain a quantity!")
                    txtQuantity.SelectAll()
                    txtQuantity.Focus()
                    Return

                End If


                Try


                    sql = "UPDATE Items SET Categories='" & txtCategories.Text.Trim() & "',ItemName='" & txtItemName.Text.Trim() & "',Description='" & txtDescription.Text.Trim() & "',Flavor='" & txtFlavor.Text.Trim() & "',Stock='" & txtStockNew.Text.Trim() & "' WHERE ItemName='" & txtItemName.Text.Trim() & "'"
                    cmd = New SqlCommand(sql, myConn)
                    myConn.Open()

                    cmd.ExecuteNonQuery()
                    myConn.Close()

                    sales()
                    ref()
                    InRe()
                    reservation()
                    DisplayRecords()
                    ' MsgBox("Successfull added!", MsgBoxStyle.Information)
                Catch
                End Try









                txtStockNew.Focus()
                txtOrderID.ResetText()

                txtCategories.ResetText()
                txtItemName.ResetText()
                txtItem2.ResetText()
                txtFlavor.ResetText()
                txtDescription.ResetText()
                txtQuantity.ResetText()
                txtPrice.ResetText()
                txtTotalPrice.ResetText()
                txtStock.ResetText()
                txtStockNew.ResetText()

                txtPayment.ResetText()
                txtChange.ResetText()
                txtCustomerName.Focus()




                ' Dim total As String = 0



                ' For i As Integer = 0 To DataGridView1.RowCount - 1


                'total += Convert.ToInt32(DataGridView1.Rows(i).Cells(5).Value)
                'Change the number 2 to your column index number (The first column has a 0 index column)
                ''In this example the column index of Price is 2
                ' Next


                Dim max As Integer = DataGridView1.Rows.Count - 1
                Dim total As String = "Total ----------->"
                Dim tot As Integer = 0

                For Each row As DataGridViewRow In DataGridView1.Rows
                    'formula for adding the values in the rows
                    tot += row.Cells(8).Value
                Next
                'DataGridView1.Rows(max).Cells(7).Value += tot
                'DataGridView1.Rows(max).Cells(2).Value = total
                txtBalance.Text = tot
            Catch ex As Exception
                ' MsgBox("You have already added that item")
                'MsgBox("The System encounter some problem, Please contact the PROGRAMMER!!!")

            Finally
                If myConn.State = ConnectionState.Open Then myConn.Close()
            End Try




        End If


    End Sub

    Private Sub ref()
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView2.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView2.Rows.Add()
                DataGridView2.Rows(x).Cells(0).Value = rd("ItemName").ToString
                DataGridView2.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView2.Rows(x).Cells(2).Value = rd("Description").ToString
                DataGridView2.Rows(x).Cells(3).Value = rd("Flavor").ToString
                DataGridView2.Rows(x).Cells(4).Value = rd("Stock").ToString
                DataGridView2.Rows(x).Cells(5).Value = rd("Price").ToString



            End While
            myConn.Close()
            cbSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub reservation()
        Try


            sql = "UPDATE Reservation set Stock= Stock -" & txtQuantity.Text & ", Stocknew=Stocknew -" & txtQuantity.Text & " where ItemName='" & txtItemName.Text.Trim() & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()

            cmd.ExecuteNonQuery()
            myConn.Close()


            ' MsgBox("Successfull added!", MsgBoxStyle.Information)
        Catch
        End Try
    End Sub

    Private Sub sales()
        Try


            sql = "Insert into SalesReport (Date,ItemName,Price,Quantity,TotalPrice) Values ('" & DateTimePicker1.Value.ToString() & "','" & txtItemName.Text.Trim() & "','" & txtPrice.Text.Trim() & "','" & txtQuantity.Text.Trim() & "','" & txtTotalPrice.Text.Trim() & "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()

            cmd.ExecuteNonQuery()
            myConn.Close()


            ' MsgBox("Successfull added!", MsgBoxStyle.Information)
        Catch
        End Try
    End Sub
    Private Sub InRe()
        Try


            sql = "Insert into InventoryReport (Date,Categories,ItemName,Descriptionss,Flavor,StockFrom,Stock,Quantity,TotalPrice) Values ('" & DateTimePicker1.Value.ToString() & "','" & txtCategories.Text.Trim() & "','" & txtItemName.Text.Trim() & "','" & txtDescription.Text.Trim() & "','" & txtFlavor.Text.Trim() & "','" & txtStock.Text.Trim() & "','" & txtStockNew.Text.Trim() & "','" & txtQuantity.Text.Trim() & "','" & txtTotalPrice.Text.Trim() & "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()

            cmd.ExecuteNonQuery()
            myConn.Close()


            MsgBox("Successfull added!", MsgBoxStyle.Information)
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmMainUser.Show()
        Me.Hide()
        ref()
    End Sub


    Private Sub Numbers_only(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress, txtPayment.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtChange_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPayment.KeyUp, txtBalance.KeyUp
        gago()
    End Sub


    Private Sub gago()
        txtChange.Text = Val(txtPayment.Text) - Val(txtBalance.Text)
    End Sub

    Private Sub txtTotalPrice_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyUp, txtPrice.KeyUp
        price()
    End Sub
    Private Sub price()
        txtTotalPrice.Text = Val(txtPrice.Text) * Val(txtQuantity.Text)


    End Sub

    Private Sub txtStockNew_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyUp, txtStock.KeyUp
        rs()
    End Sub
    Private Sub rs()
        txtStockNew.Text = Val(txtStock.Text) - Val(txtQuantity.Text)

    End Sub


    Private Sub btnSearchCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchCustomer.Click
        frmCustomerorderUser.ShowDialog()
        ref()
    End Sub

    Private Sub DataGridView2_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridView2.Rows(count)
        txtItemName.Text = selectrow.Cells(0).Value.ToString()
        txtItem2.Text = selectrow.Cells(0).Value.ToString()
        txtCategories.Text = selectrow.Cells(1).Value.ToString()
        txtDescription.Text = selectrow.Cells(2).Value.ToString()
        txtFlavor.Text = selectrow.Cells(3).Value.ToString()
        txtStock.Text = selectrow.Cells(4).Value.ToString()
        txtPrice.Text = selectrow.Cells(5).Value.ToString()
    End Sub

    Private Sub btnSearchItem_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchItem.Click
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price FROM Items Where Categories  LIKE '%" & cbSearch.Text.Trim() & "%' or  ItemName LIKE '%" & cbSearch.Text.Trim() & "%' Order by  ItemName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView2.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView2.Rows.Add()
                DataGridView2.Rows(x).Cells(0).Value = rd("ItemName").ToString
                DataGridView2.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView2.Rows(x).Cells(2).Value = rd("Description").ToString
                DataGridView2.Rows(x).Cells(3).Value = rd("Flavor").ToString
                DataGridView2.Rows(x).Cells(4).Value = rd("Stock").ToString
                DataGridView2.Rows(x).Cells(5).Value = rd("Price").ToString



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
            DataGridView2.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView2.Rows.Add()
                DataGridView2.Rows(x).Cells(0).Value = rd("ItemName").ToString
                DataGridView2.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView2.Rows(x).Cells(2).Value = rd("Description").ToString
                DataGridView2.Rows(x).Cells(3).Value = rd("Flavor").ToString
                DataGridView2.Rows(x).Cells(4).Value = rd("Stock").ToString
                DataGridView2.Rows(x).Cells(5).Value = rd("Price").ToString



            End While
            myConn.Close()
            cbSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnNewOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnNewOrder.Click
        Dim result As DialogResult _
         = MessageBox.Show("Do you  to proceed to new Order ?", _
           "Save", MessageBoxButtons.YesNo, _
           MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "DELETE FROM Payment "

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()


                txtOrderID.ResetText()
                txtCustomerName.ResetText()
                txtCategories.ResetText()
                txtItemName.ResetText()
                txtItem2.ResetText()
                txtDescription.ResetText()
                txtFlavor.ResetText()
                txtQuantity.ResetText()
                txtPrice.ResetText()
                txtTotalPrice.ResetText()
                txtStock.ResetText()
                txtStockNew.ResetText()
                txtBalance.ResetText()
                txtPayment.ResetText()
                txtChange.ResetText()
                txtdown.ResetText()


                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()
                ' MsgBox("Successfully deleted", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



        End If
        ref()

    End Sub

    Private Sub btnReciept_Click(sender As System.Object, e As System.EventArgs) Handles btnReciept.Click
        If (txtPayment.Text.Trim().Length = 0) Then
            MsgBox("Payment is empty !")
            txtPayment.SelectAll()
            txtPayment.Focus()
            Return

        End If

        Dim result As DialogResult _
          = MessageBox.Show("Receipt is now on process",
            "Save", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            frmPrintPayment.Show()

        End If
        Try

            sql = "INSERT  INTO Payment (Down,Balance,Payment,Change) VALUES ('" & txtdown.Text.Trim() & "','" & txtBalance.Text.Trim() & "','" & txtPayment.Text.Trim() & "','" & txtChange.Text.Trim() & "')"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()

            cmd.ExecuteNonQuery()
            myConn.Close()




        Catch ex As Exception
            MsgBox(ex.ToString)
            myConn.Close()
        End Try
        ref()


    End Sub

    Private Sub btnMinus_Click(sender As System.Object, e As System.EventArgs) Handles btnMinus.Click
        txtBalance.Text = Val(txtBalance.Text) - Val(txtdown.Text)
        ref()
    End Sub

    Private Sub btnView_Click(sender As System.Object, e As System.EventArgs) Handles btnView.Click
        frmOrderUserView.ShowDialog()
        ref()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridView1.Rows(count)
        txtOrderID.Text = selectrow.Cells(0).Value.ToString()
        txtCustomerName.Text = selectrow.Cells(1).Value.ToString()
        txtItemName.Text = selectrow.Cells(2).Value.ToString()
        txtCategories.Text = selectrow.Cells(3).Value.ToString()
        txtDescription.Text = selectrow.Cells(4).Value.ToString()
        txtFlavor.Text = selectrow.Cells(5).Value.ToString()
        txtPrice.Text = selectrow.Cells(6).Value.ToString()
        txtQuantity.Text = selectrow.Cells(7).Value.ToString()
        txtTotalPrice.Text = selectrow.Cells(8).Value.ToString()
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub DataGridView1_CellClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
       

        Try

            txtOrderID.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtCustomerName.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtItemName.Text = DataGridView1.CurrentRow.Cells(2).Value
            txtCategories.Text = DataGridView1.CurrentRow.Cells(3).Value
            txtDescription.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtFlavor.Text = DataGridView1.CurrentRow.Cells(5).Value
            txtPrice.Text = DataGridView1.CurrentRow.Cells(6).Value
            txtQuantity.Text = DataGridView1.CurrentRow.Cells(7).Value
            txtTotalPrice.Text = DataGridView1.CurrentRow.Cells(8).Value

        Catch ex As Exception



            txtOrderID.Text = ""
            txtCustomerName.Text = ""
            txtItemName.Text = ""
            txtCategories.Text = ""
            txtDescription.Text = ""
            txtFlavor.Text = ""
            txtPrice.Text = ""
            txtQuantity.Text = ""
            txtTotalPrice.Text = ""
        End Try
    End Sub


End Class