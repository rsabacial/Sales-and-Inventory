Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmCustomer
    Dim constr As String = "Data Source=DESKTOP-PQDQ9A9\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    

    Private Sub frmCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)
        DisplayRecords()
        txtCustomerID.ResetText()
        txtFirstname.ResetText()
        txtMiddlename.ResetText()
        txtLastname.ResetText()
        txtGender.ResetText()
        txtContact.ResetText()
        txtAddress.ResetText()
        txtEmail.ResetText()
    End Sub

    Private Sub DataGridEmployee_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridEmployee.CellClick

        Dim count As Integer
        count = e.RowIndex
        Dim selectrow As DataGridViewRow
        selectrow = DataGridEmployee.Rows(count)
        txtCustomerID.Text = selectrow.Cells(0).Value.ToString()
        txtFirstname.Text = selectrow.Cells(1).Value.ToString()
        txtMiddlename.Text = selectrow.Cells(2).Value.ToString()
        txtLastname.Text = selectrow.Cells(3).Value.ToString()
        txtGender.Text = selectrow.Cells(4).Value.ToString()
        txtContact.Text = selectrow.Cells(5).Value.ToString()
        txtAddress.Text = selectrow.Cells(6).Value.ToString()
        txtEmail.Text = selectrow.Cells(7).Value.ToString()
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT CustomerID,Lastname,Firstname,Middlename,Gender,Contact,Address,Email FROM Customers ORDER BY CustomerID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridEmployee.Rows.Clear()
            While rd.Read


                If (count = 0) Then
                    txtCustomerID.Text = rd("CustomerID").ToString
                    txtLastname.Text = rd("Lastname").ToString
                    txtFirstname.Text = rd("Firstname").ToString
                    txtMiddlename.Text = rd("Middlename").ToString
                    txtGender.Text = rd("Gender").ToString                   
                    txtContact.Text = rd("Contact").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtEmail.Text = rd("Email").ToString

                End If

                Dim x As Integer = DataGridEmployee.Rows.Add()
                DataGridEmployee.Rows(x).Cells(0).Value = rd("CustomerID").ToString
                DataGridEmployee.Rows(x).Cells(1).Value = rd("Firstname").ToString
                DataGridEmployee.Rows(x).Cells(2).Value = rd("Middlename").ToString
                DataGridEmployee.Rows(x).Cells(3).Value = rd("Lastname").ToString
                DataGridEmployee.Rows(x).Cells(4).Value = rd("Gender").ToString
                DataGridEmployee.Rows(x).Cells(5).Value = rd("Contact").ToString
                DataGridEmployee.Rows(x).Cells(6).Value = rd("Address").ToString
                DataGridEmployee.Rows(x).Cells(7).Value = rd("Email").ToString


                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub datagridEmployee_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtCustomerID.Text = DataGridEmployee.CurrentRow.Cells(0).Value
            txtFirstname.Text = DataGridEmployee.CurrentRow.Cells(1).Value
            txtMiddlename.Text = DataGridEmployee.CurrentRow.Cells(2).Value
            txtLastname.Text = DataGridEmployee.CurrentRow.Cells(3).Value
            txtGender.Text = DataGridEmployee.CurrentRow.Cells(4).Value
            txtContact.Text = DataGridEmployee.CurrentRow.Cells(5).Value
            txtAddress.Text = DataGridEmployee.CurrentRow.Cells(6).Value
            txtEmail.Text = DataGridEmployee.CurrentRow.Cells(7).Value
        Catch ex As Exception
            txtCustomerID.Text = ""
            txtFirstname.Text = ""
            txtMiddlename.Text = ""
            txtLastname.Text = ""
            txtGender.Text = ""
            txtContact.Text = ""
            txtAddress.Text = ""
            txtEmail.Text = ""
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs)
        txtCustomerID.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""
        txtGender.Text = ""
        txtContact.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtFirstname.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs)


        If (txtLastname.Text.Trim().Length = 0) Then
            MsgBox("Lastname is empty!")
            txtLastname.SelectAll()
            txtLastname.Focus()
            Return
        End If

        If (txtFirstname.Text.Trim().Length = 0) Then
            MsgBox("Firstname is empty!")
            txtFirstname.SelectAll()
            txtFirstname.Focus()
            Return
        End If

        If (txtMiddlename.Text.Trim().Length = 0) Then
            MsgBox("Middlename is empty!")
            txtMiddlename.SelectAll()
            txtMiddlename.Focus()
            Return
        End If

        If (txtGender.Text.Trim().Length = 0) Then
            MsgBox("Gender is empty!")
            txtGender.SelectAll()
            txtGender.Focus()
            Return
        End If


        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If


        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If
        If (txtEmail.Text.Trim().Length = 0) Then
            MsgBox("Email is empty!")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return
        End If


        Dim result As DialogResult _
            = MessageBox.Show("Do you want to delete Employee info ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "DELETE FROM Customers WHERE CustomerID='" & txtCustomerID.Text.Trim() & "'"

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

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs)
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs)


        If (txtLastname.Text.Trim().Length = 0) Then
            MsgBox("Lastname is empty!")
            txtLastname.SelectAll()
            txtLastname.Focus()
            Return
        End If

        If (txtFirstname.Text.Trim().Length = 0) Then
            MsgBox("Firstname is empty!")
            txtFirstname.SelectAll()
            txtFirstname.Focus()
            Return
        End If

        If (txtMiddlename.Text.Trim().Length = 0) Then
            MsgBox("Middlename is empty!")
            txtMiddlename.SelectAll()
            txtMiddlename.Focus()
            Return
        End If

        If (txtGender.Text.Trim().Length = 0) Then
            MsgBox("Gender is empty!")
            txtGender.SelectAll()
            txtGender.Focus()
            Return
        End If


        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If


        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If
        If (txtEmail.Text.Trim().Length = 0) Then
            MsgBox("Email is empty!")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return
        End If

        Dim result As DialogResult _
            = MessageBox.Show("Do you want to save new Employee info ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "INSERT  INTO Customers (Lastname,Firstname,Middlename,Gender,Contact,Address,Email) VALUES ('" & txtLastname.Text.Trim() & "','" & txtFirstname.Text.Trim() & "','" & txtMiddlename.Text.Trim() & "','" & txtGender.Text.Trim() & "','" & txtContact.Text.Trim() & "','" & txtAddress.Text.Trim() & "','" & txtEmail.Text.Trim() & "')"

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

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs)





        If (txtLastname.Text.Trim().Length = 0) Then
            MsgBox("Lastname is empty!")
            txtLastname.SelectAll()
            txtLastname.Focus()
            Return
        End If

        If (txtFirstname.Text.Trim().Length = 0) Then
            MsgBox("Firstname is empty!")
            txtFirstname.SelectAll()
            txtFirstname.Focus()
            Return
        End If

        If (txtMiddlename.Text.Trim().Length = 0) Then
            MsgBox("Middlename is empty!")
            txtMiddlename.SelectAll()
            txtMiddlename.Focus()
            Return
        End If

        If (txtGender.Text.Trim().Length = 0) Then
            MsgBox("Gender is empty!")
            txtGender.SelectAll()
            txtGender.Focus()
            Return
        End If


        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If


        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If
        If (txtEmail.Text.Trim().Length = 0) Then
            MsgBox("Email is empty!")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return
        End If


        Dim result As DialogResult _
            = MessageBox.Show("Do you want to update Employee info ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then


            Try
                sql = "UPDATE Customers SET Lastname='" & txtLastname.Text.Trim() & "',Firstname='" & txtFirstname.Text.Trim() & "',Middlename='" & txtMiddlename.Text.Trim() & "',Gender='" & txtGender.Text.Trim() & "',Email='" & txtEmail.Text.Trim() & "',Contact='" & txtContact.Text.Trim() & "',Address='" & txtAddress.Text.Trim() & "' WHERE CustomerID='" & txtCustomerID.Text.Trim() & "'"


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

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            sql = "SELECT CustomerID,Lastname,Firstname,Middlename,Gender,Contact,Address,Email FROM Customers Where Lastname  LIKE '%" & txtSearch.Text.Trim() & "%' or  Firstname LIKE '%" & txtSearch.Text.Trim() & "%' or  Middlename LIKE '%" & txtSearch.Text.Trim() & "%' Order by  Lastname"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridEmployee.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridEmployee.Rows.Add()
                DataGridEmployee.Rows(x).Cells(0).Value = rd("CustomerID").ToString
                DataGridEmployee.Rows(x).Cells(1).Value = rd("Firstname").ToString
                DataGridEmployee.Rows(x).Cells(2).Value = rd("Middlename").ToString
                DataGridEmployee.Rows(x).Cells(3).Value = rd("Lastname").ToString
                DataGridEmployee.Rows(x).Cells(4).Value = rd("Gender").ToString
                DataGridEmployee.Rows(x).Cells(5).Value = rd("Contact").ToString
                DataGridEmployee.Rows(x).Cells(6).Value = rd("Address").ToString
                DataGridEmployee.Rows(x).Cells(7).Value = rd("Email").ToString


            End While
            myConn.Close()
            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        


    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Numbers_only(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub PictureBoxAdd_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxAdd.Click
        txtCustomerID.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""
        txtGender.Text = ""
        txtContact.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtFirstname.Focus()
    End Sub

    Private Sub PictureBoxEdit_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxEdit.Click



        If (txtLastname.Text.Trim().Length = 0) Then
            MsgBox("Lastname is empty!")
            txtLastname.SelectAll()
            txtLastname.Focus()
            Return
        End If

        If (txtFirstname.Text.Trim().Length = 0) Then
            MsgBox("Firstname is empty!")
            txtFirstname.SelectAll()
            txtFirstname.Focus()
            Return
        End If

        If (txtMiddlename.Text.Trim().Length = 0) Then
            MsgBox("Middlename is empty!")
            txtMiddlename.SelectAll()
            txtMiddlename.Focus()
            Return
        End If

        If (txtGender.Text.Trim().Length = 0) Then
            MsgBox("Gender is empty!")
            txtGender.SelectAll()
            txtGender.Focus()
            Return
        End If


        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If


        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If
        If (txtEmail.Text.Trim().Length = 0) Then
            MsgBox("Email is empty!")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return
        End If


        Dim result As DialogResult _
            = MessageBox.Show("Do you want to update Employee info ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then


            Try
                sql = "UPDATE Customers SET Lastname='" & txtLastname.Text.Trim() & "',Firstname='" & txtFirstname.Text.Trim() & "',Middlename='" & txtMiddlename.Text.Trim() & "',Gender='" & txtGender.Text.Trim() & "',Email='" & txtEmail.Text.Trim() & "',Contact='" & txtContact.Text.Trim() & "',Address='" & txtAddress.Text.Trim() & "' WHERE CustomerID='" & txtCustomerID.Text.Trim() & "'"


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

    Private Sub PictureBoxSave_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxSave.Click


        If (txtLastname.Text.Trim().Length = 0) Then
            MsgBox("Lastname is empty!")
            txtLastname.SelectAll()
            txtLastname.Focus()
            Return
        End If

        If (txtFirstname.Text.Trim().Length = 0) Then
            MsgBox("Firstname is empty!")
            txtFirstname.SelectAll()
            txtFirstname.Focus()
            Return
        End If

        If (txtMiddlename.Text.Trim().Length = 0) Then
            MsgBox("Middlename is empty!")
            txtMiddlename.SelectAll()
            txtMiddlename.Focus()
            Return
        End If

        If (txtGender.Text.Trim().Length = 0) Then
            MsgBox("Gender is empty!")
            txtGender.SelectAll()
            txtGender.Focus()
            Return
        End If


        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If


        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If
        If (txtEmail.Text.Trim().Length = 0) Then
            MsgBox("Email is empty!")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return
        End If

        Dim result As DialogResult _
            = MessageBox.Show("Do you want to save new Employee info ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "INSERT  INTO Customers (Lastname,Firstname,Middlename,Gender,Contact,Address,Email) VALUES ('" & txtLastname.Text.Trim() & "','" & txtFirstname.Text.Trim() & "','" & txtMiddlename.Text.Trim() & "','" & txtGender.Text.Trim() & "','" & txtContact.Text.Trim() & "','" & txtAddress.Text.Trim() & "','" & txtEmail.Text.Trim() & "')"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                txtCustomerID.ResetText()
                txtFirstname.ResetText()
                txtMiddlename.ResetText()
                txtLastname.ResetText()
                txtAddress.ResetText()
                txtContact.ResetText()
                txtGender.ResetText()
                txtEmail.ResetText()

                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully saved", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub PictureBoxDelete_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxDelete.Click

        If (txtLastname.Text.Trim().Length = 0) Then
            MsgBox("Lastname is empty!")
            txtLastname.SelectAll()
            txtLastname.Focus()
            Return
        End If

        If (txtFirstname.Text.Trim().Length = 0) Then
            MsgBox("Firstname is empty!")
            txtFirstname.SelectAll()
            txtFirstname.Focus()
            Return
        End If

        If (txtMiddlename.Text.Trim().Length = 0) Then
            MsgBox("Middlename is empty!")
            txtMiddlename.SelectAll()
            txtMiddlename.Focus()
            Return
        End If

        If (txtGender.Text.Trim().Length = 0) Then
            MsgBox("Gender is empty!")
            txtGender.SelectAll()
            txtGender.Focus()
            Return
        End If


        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If


        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If
        If (txtEmail.Text.Trim().Length = 0) Then
            MsgBox("Email is empty!")
            txtEmail.SelectAll()
            txtEmail.Focus()
            Return
        End If


        Dim result As DialogResult _
            = MessageBox.Show("Do you want to delete Employee info ?", _
              "Save", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "DELETE FROM Customers WHERE CustomerID='" & txtCustomerID.Text.Trim() & "'"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                txtCustomerID.ResetText()
                txtFirstname.ResetText()
                txtMiddlename.ResetText()
                txtLastname.ResetText()
                txtAddress.ResetText()
                txtContact.ResetText()
                txtGender.ResetText()
                txtEmail.ResetText()
                

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
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

            sql = "SELECT CustomerID,Lastname,Firstname,Middlename,Gender,Contact,Address,Email FROM Customers "
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridEmployee.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridEmployee.Rows.Add()
                DataGridEmployee.Rows(x).Cells(0).Value = rd("CustomerID").ToString
                DataGridEmployee.Rows(x).Cells(1).Value = rd("Firstname").ToString
                DataGridEmployee.Rows(x).Cells(2).Value = rd("Middlename").ToString
                DataGridEmployee.Rows(x).Cells(3).Value = rd("Lastname").ToString
                DataGridEmployee.Rows(x).Cells(4).Value = rd("Gender").ToString
                DataGridEmployee.Rows(x).Cells(5).Value = rd("Contact").ToString
                DataGridEmployee.Rows(x).Cells(6).Value = rd("Address").ToString
                DataGridEmployee.Rows(x).Cells(7).Value = rd("Email").ToString
               




            End While
            myConn.Close()
            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class