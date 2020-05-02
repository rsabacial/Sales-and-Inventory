Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmItemsUser
    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Private Sub frmItemsUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)
        DisplayRecords()

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()

        GroupBox2.Visible = False
        txtItemID.ResetText()
        txtCategories.ResetText()
        txtItemName.ResetText()
        txtExpirationDate.Value = DateString()
        cbFlavor.ResetText()
        txtPrice.ResetText()
        txtDescription.ResetText()
        txtStock.ResetText()

        txtItemName.ReadOnly = True
        txtDescription.ReadOnly = True

        txtStock.ReadOnly = True
        txtPrice.ReadOnly = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True

        txtItemName.Focus()
    End Sub
    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,convert(varchar, ExpirationDate, 101) as ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read


                If (count = 0) Then
                    txtItemID.Text = rd("ItemID").ToString
                    txtCategories.Text = rd("Categories").ToString
                    txtItemName.Text = rd("ItemName").ToString
                    cbFlavor.Text = rd("Flavor").ToString
                    txtDescription.Text = rd("Description").ToString
                    txtExpirationDate.Text = rd("ExpirationDate").ToString
                    txtStock.Text = rd("Stock").ToString
                    txtPrice.Text = rd("Price").ToString


                End If

                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ItemID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("ExpirationDate").ToString()
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Price").ToString


                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtItemID.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtCategories.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtItemName.Text = DataGridView1.CurrentRow.Cells(2).Value
            txtDescription.Text = DataGridView1.CurrentRow.Cells(3).Value
            cbFlavor.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtExpirationDate.Text = DataGridView1.CurrentRow.Cells(5).Value
            txtStock.Text = DataGridView1.CurrentRow.Cells(6).Value
            txtPrice.Text = DataGridView1.CurrentRow.Cells(7).Value

        Catch ex As Exception
            txtItemID.Text = ""
            txtCategories.Text = ""
            txtItemName.Text = ""
            cbFlavor.Text = ""
            txtExpirationDate.Text = ""
            txtDescription.Text = ""
            txtStock.Text = ""
            txtPrice.Text = ""

        End Try
    End Sub

    

   

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,convert(varchar, ExpirationDate, 101) as ExpirationDate,Stock,Price FROM Items Where Categories  LIKE '%" & cbSearch.Text.Trim() & "%' or  ItemName LIKE '%" & cbSearch.Text.Trim() & "%' Order by  ItemName"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ItemID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("ExpirationDate").ToString()
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Price").ToString



            End While
            myConn.Close()
            cbSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,convert(varchar, ExpirationDate, 101) as ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ItemID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("ExpirationDate").ToString()
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Price").ToString


            End While
            myConn.Close()
            cbSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtItemName.ReadOnly = True
        txtDescription.ReadOnly = True

        txtStock.ReadOnly = True
        txtPrice.ReadOnly = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try

            txtItemID.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtCategories.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtItemName.Text = DataGridView1.CurrentRow.Cells(2).Value
            txtDescription.Text = DataGridView1.CurrentRow.Cells(3).Value
            cbFlavor.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtExpirationDate.Text = DataGridView1.CurrentRow.Cells(5).Value
            txtStock.Text = DataGridView1.CurrentRow.Cells(6).Value
            txtPrice.Text = DataGridView1.CurrentRow.Cells(7).Value


        Catch ex As Exception



            txtItemID.Text = ""
            txtCategories.Text = ""
            txtItemName.Text = ""
            txtDescription.Text = ""
            cbFlavor.Text = ""
            txtExpirationDate.Text = ""
            txtStock.Text = ""
            txtPrice.Text = ""

        End Try

        txtItemName.ReadOnly = False
        txtDescription.ReadOnly = False
        GroupBox2.Visible = True
        txtStock.ReadOnly = False
        txtPrice.ReadOnly = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnNew.Enabled = True
        btnSave.Enabled = False
        txtItemName.Focus()
    End Sub

    Private Sub frmItemsUser_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,convert(varchar, ExpirationDate, 101) as ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridView1.Rows.Add()
                DataGridView1.Rows(x).Cells(0).Value = rd("ItemID").ToString
                DataGridView1.Rows(x).Cells(1).Value = rd("Categories").ToString
                DataGridView1.Rows(x).Cells(2).Value = rd("ItemName").ToString
                DataGridView1.Rows(x).Cells(3).Value = rd("Description").ToString
                DataGridView1.Rows(x).Cells(4).Value = rd("Flavor").ToString
                DataGridView1.Rows(x).Cells(5).Value = rd("ExpirationDate").ToString()
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Price").ToString


            End While
            myConn.Close()


          

            txtItemName.ReadOnly = True
            txtDescription.ReadOnly = True

            txtStock.ReadOnly = True
            txtPrice.ReadOnly = True
            btnUpdate.Enabled = False
            btnDelete.Enabled = False
            btnSave.Enabled = False
            btnNew.Enabled = True
            txtItemName.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        txtItemID.Text = ""
        txtCategories.Text = ""
        txtItemName.Text = ""
        cbFlavor.Text = ""
        txtExpirationDate.Text = ""
        txtDescription.Text = ""
        txtStock.Text = ""
        txtPrice.Text = ""

        txtItemName.ReadOnly = False
        txtDescription.ReadOnly = False
        GroupBox2.Visible = False
        txtStock.ReadOnly = False
        txtPrice.ReadOnly = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnNew.Enabled = False
        txtItemName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If (txtCategories.Text.Trim().Length = 0) Then
            MsgBox("Categories is empty!")
            txtCategories.SelectAll()
            txtCategories.Focus()
            Return
        End If

        If (txtItemName.Text.Trim().Length = 0) Then
            MsgBox("ItemName is empty!")
            txtItemName.SelectAll()
            txtItemName.Focus()
            Return
        End If

        If (txtStock.Text.Trim().Length = 0) Then
            MsgBox("Stock is empty!")
            txtStock.SelectAll()
            txtStock.Focus()
            Return
        End If




        If (txtPrice.Text.Trim().Length = 0) Then
            MsgBox("Price is empty!")
            txtPrice.SelectAll()
            txtPrice.Focus()
            Return
        End If


        Dim result As DialogResult _
            = MessageBox.Show("Do you want to save new Items ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "INSERT  INTO Items (Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price) VALUES ('" & txtCategories.Text.Trim() & "','" & txtItemName.Text.Trim() & "','" & txtDescription.Text.Trim() & "','" & cbFlavor.Text.Trim() & "','" & txtExpirationDate.Value() & "','" & txtStock.Text.Trim() & "','" & txtPrice.Text.Trim() & "')"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()

                MsgBox("Successfully saved", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        txtItemName.ReadOnly = True
        txtDescription.ReadOnly = True
        GroupBox2.Visible = False
        txtStock.ReadOnly = True
        txtPrice.ReadOnly = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult _
           = MessageBox.Show("Do you want to update Items ?", _
             "Save", MessageBoxButtons.YesNo, _
             MessageBoxIcon.Question)
        If result = DialogResult.Yes Then


            Try
                sql = "UPDATE Items SET Categories='" & txtCategories.Text.Trim() & "',ItemName='" & txtItemName.Text.Trim() & "',Description='" & txtDescription.Text.Trim() & "',Flavor='" & cbFlavor.Text.Trim() & "',ExpirationDate='" & txtExpirationDate.Value() & "',Stock='" & txtStock.Text.Trim() & "',Price='" & txtPrice.Text.Trim() & "' WHERE ItemID='" & txtItemID.Text.Trim() & "'"


                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully updated", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        End If
        GroupBox2.Visible = False
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click


        Dim result As DialogResult _
            = MessageBox.Show("Do you want to delete Items ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "DELETE FROM Items WHERE ItemId='" & txtItemID.Text.Trim() & "'"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                txtItemID.ResetText()
                txtCategories.ResetText()
                txtItemName.ResetText()
                cbFlavor.ResetText()
                txtPrice.ResetText()
                txtDescription.ResetText()
                txtStock.ResetText()


                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully deleted", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        GroupBox2.Visible = False
    End Sub
    Private Sub Numbers_only(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress, txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSearch.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim expdate = DataGridView1.Rows(i).Cells(5).Value
            If expdate > Now Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White

            Else
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMainUser.Show()
        Me.Hide()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim stock = DataGridView1.Rows(i).Cells(6).Value

            If stock <= 5 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Yellow

            End If
        Next
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim sto = DataGridView1.Rows(i).Cells(6).Value

            If sto <= 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Black

            End If
        Next
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnDamage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDamage.Click

        Try



            sql = "UPDATE Items set Stock= Stock -" & txtDamage.Text & " where ItemID='" & txtItemID.Text.Trim() & "'"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()

            cmd.ExecuteNonQuery()
            myConn.Close()


            InRe()

            DisplayRecords()
            ' MsgBox("Successfull added!", MsgBoxStyle.Information)
        Catch
        End Try
        txtDamage.ResetText()
    End Sub

    Private Sub InRe()
        Try


            sql = "Insert into InventoryReport (Date,Categories,ItemName,Descriptionss,Flavor,StockFrom,Stock,Damage) Values ('" & DateTimePicker1.Value.ToString() & "','" & txtCategories.Text.Trim() & "','" & txtItemName.Text.Trim() & "','" & txtDescription.Text.Trim() & "','" & cbFlavor.Text.Trim() & "','" & txtStock.Text.Trim() & "','" & txtStock2.Text.Trim() & "','" & txtDamage.Text.Trim() & "')"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()

            cmd.ExecuteNonQuery()
            myConn.Close()


            MsgBox("OK!", MsgBoxStyle.Information)
        Catch
        End Try
        GroupBox2.Visible = False
    End Sub

    Private Sub txtStock2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDamage.KeyUp, txtStock.KeyUp
        txtStock2.Text = Val(txtStock.Text) - Val(txtDamage.Text)
    End Sub

    
End Class