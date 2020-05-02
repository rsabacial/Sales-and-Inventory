
Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class frmItems
    Dim constr As String = "Data Source=DESKTOP-PQDQ9A9\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String



    Private Sub frmItems_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        myConn = New SqlConnection(constr)
        DisplayRecords()




        txtItemID.ResetText()
        txtCategories.ResetText()
        txtItemName.ResetText()
        txtExpirationDate.Value = DateString()
        txtFlavor.ResetText()
        txtPrice.ResetText()
        txtDescription.ResetText()
        txtStock.ResetText()
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridView1.Rows.Clear()
            While rd.Read


                If (count = 0) Then
                    txtItemID.Text = rd("ItemID").ToString
                    txtCategories.Text = rd("Categories").ToString
                    txtItemName.Text = rd("ItemName").ToString
                    txtFlavor.Text = rd("Flavor").ToString
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
                DataGridView1.Rows(x).Cells(5).Value = rd("ExpirationDate").ToShortDateString()
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
            txtFlavor.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtExpirationDate.Text = DataGridView1.CurrentRow.Cells(5).Value
            txtStock.Text = DataGridView1.CurrentRow.Cells(6).Value
            txtPrice.Text = DataGridView1.CurrentRow.Cells(7).Value
            
        Catch ex As Exception
            txtItemID.Text = ""
            txtCategories.Text = ""
            txtItemName.Text = ""
            txtFlavor.Text = ""
            txtExpirationDate.Text = ""
            txtDescription.Text = ""
            txtStock.Text = ""
            txtPrice.Text = ""
            
        End Try
    End Sub

    Private Sub PictureBoxAdd_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxAdd.Click
        txtItemID.Text = ""
        txtCategories.Text = ""
        txtItemName.Text = ""
        txtFlavor.Text = ""
        txtExpirationDate.Text = ""
        txtDescription.Text = ""
        txtStock.Text = ""
        txtPrice.Text = ""
        txtItemName.Focus()
    End Sub

    Private Sub PictureBoxDelete_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxDelete.Click

    

      
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
                txtFlavor.ResetText()
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
    End Sub

    Private Sub PictureBoxClose_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxClose.Click
        frmMain.Show()
        Me.Close()

    End Sub

    Private Sub PictureBoxSave_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxSave.Click


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

                sql = "INSERT  INTO Items (Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price) VALUES ('" & txtCategories.Text.Trim() & "','" & txtItemName.Text.Trim() & "','" & txtDescription.Text.Trim() & "','" & txtFlavor.Text.Trim() & "','" & txtExpirationDate.Value() & "','" & txtStock.Text.Trim() & "','" & txtPrice.Text.Trim() & "')"

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
    End Sub

    Private Sub PictureBoxEdit_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxEdit.Click

        Dim result As DialogResult _
            = MessageBox.Show("Do you want to update Items ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then


            Try
                sql = "UPDATE Items SET Categories='" & txtCategories.Text.Trim() & "',ItemName='" & txtItemName.Text.Trim() & "',Description='" & txtDescription.Text.Trim() & "',Flavor='" & txtFlavor.Text.Trim() & "',ExpirationDate='" & txtExpirationDate.Value() & "',Stock='" & txtStock.Text.Trim() & "',Price='" & txtPrice.Text.Trim() & "' WHERE ItemID='" & txtItemID.Text.Trim() & "'"


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

    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." Then e.Handled = True
    End Sub

    Private Sub Numbers_only(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress, txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

   
   
    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
       

        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridView1.Rows(count)
        txtItemID.Text = selectrow.Cells(0).Value.ToString()
        txtCategories.Text = selectrow.Cells(1).Value.ToString()
        txtItemName.Text = selectrow.Cells(2).Value.ToString()
        txtDescription.Text = selectrow.Cells(3).Value.ToString()
        txtFlavor.Text = selectrow.Cells(4).Value.ToString()
        txtExpirationDate.Text = selectrow.Cells(5).Value.ToString()
        txtStock.Text = selectrow.Cells(6).Value.ToString()
        txtPrice.Text = selectrow.Cells(7).Value.ToString()
        
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price FROM Items Where Categories  LIKE '%" & txtSearch.Text.Trim() & "%' or  ItemName LIKE '%" & txtSearch.Text.Trim() & "%' Order by  ItemName"
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
                DataGridView1.Rows(x).Cells(5).Value = rd("ExpirationDate").ToShortDateString()
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Price").ToString
                


            End While
            myConn.Close()
            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnrefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnrefresh.Click
        Try

            sql = "SELECT ItemID,Categories,ItemName,Description,Flavor,ExpirationDate,Stock,Price FROM Items ORDER BY ItemID"
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
                DataGridView1.Rows(x).Cells(5).Value = rd("ExpirationDate").ToShortDateString()
                DataGridView1.Rows(x).Cells(6).Value = rd("Stock").ToString
                DataGridView1.Rows(x).Cells(7).Value = rd("Price").ToString


            End While
            myConn.Close()

            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

   

    

   

  
   
   
    
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DisplayRecords()
    End Sub
End Class