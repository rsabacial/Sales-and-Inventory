﻿Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmEmployeeUser
    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=DelaRama;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand()
    Dim sql As String
    Private Sub frmEmployeeUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        myConn = New SqlConnection(constr)
        DisplayRecords()


        txtBirthdate.Value = DateString()
        txtDateHired.Value = DateString()
        txtEmployeeID.ResetText()
        txtFirstname.ResetText()
        txtMiddlename.ResetText()
        txtLastname.ResetText()
        txtAddress.ResetText()
        txtContact.ResetText()
        txtGender.ResetText()
        txtEmail.ResetText()


        txtFirstname.ReadOnly = True
        txtMiddlename.ReadOnly = True
        txtLastname.ReadOnly = True
        txtContact.ReadOnly = True
        txtAddress.ReadOnly = True

        txtEmail.ReadOnly = True

        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True

        txtFirstname.Focus()
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT EmployeeID,Lastname,Firstname,Middlename,Gender,convert(varchar, BirthDate, 101) as BirthDate,convert(varchar, DateHired, 101) as DateHired,Contact,Address,Email FROM Employee ORDER BY EmployeeID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridEmployee.Rows.Clear()
            While rd.Read


                If (count = 0) Then
                    txtEmployeeID.Text = rd("EmployeeID").ToString
                    txtLastname.Text = rd("Lastname").ToString
                    txtFirstname.Text = rd("Firstname").ToString
                    txtMiddlename.Text = rd("Middlename").ToString
                    txtGender.Text = rd("Gender").ToString
                    txtBirthdate.Text = rd("BirthDate").ToString
                    txtDateHired.Text = rd("DateHired").ToString
                    txtContact.Text = rd("Contact").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtEmail.Text = rd("Email").ToString

                End If

                Dim x As Integer = DataGridEmployee.Rows.Add()
                DataGridEmployee.Rows(x).Cells(0).Value = rd("EmployeeID").ToString
                DataGridEmployee.Rows(x).Cells(1).Value = rd("Firstname").ToString
                DataGridEmployee.Rows(x).Cells(2).Value = rd("Middlename").ToString
                DataGridEmployee.Rows(x).Cells(3).Value = rd("Lastname").ToString
                DataGridEmployee.Rows(x).Cells(4).Value = rd("Gender").ToString
                DataGridEmployee.Rows(x).Cells(5).Value = rd("Contact").ToString
                DataGridEmployee.Rows(x).Cells(6).Value = rd("Birthdate").ToString
                DataGridEmployee.Rows(x).Cells(7).Value = rd("DateHired").ToString
                DataGridEmployee.Rows(x).Cells(8).Value = rd("Address").ToString
                DataGridEmployee.Rows(x).Cells(9).Value = rd("Email").ToString


                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

   

    Private Sub datagridEmployee_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtEmployeeID.Text = DataGridEmployee.CurrentRow.Cells(0).Value
            txtFirstname.Text = DataGridEmployee.CurrentRow.Cells(1).Value
            txtMiddlename.Text = DataGridEmployee.CurrentRow.Cells(2).Value
            txtLastname.Text = DataGridEmployee.CurrentRow.Cells(3).Value
            txtGender.Text = DataGridEmployee.CurrentRow.Cells(4).Value
            txtContact.Text = DataGridEmployee.CurrentRow.Cells(5).Value
            txtBirthdate.Text = DataGridEmployee.CurrentRow.Cells(6).Value
            txtDateHired.Text = DataGridEmployee.CurrentRow.Cells(7).Value
            txtAddress.Text = DataGridEmployee.CurrentRow.Cells(8).Value
            txtEmail.Text = DataGridEmployee.CurrentRow.Cells(9).Value
        Catch ex As Exception
            txtEmployeeID.Text = ""
            txtFirstname.Text = ""
            txtMiddlename.Text = ""
            txtLastname.Text = ""
            txtGender.Text = ""
            txtContact.Text = ""
            txtBirthdate.Text = ""
            txtDateHired.Text = ""
            txtAddress.Text = ""
            txtEmail.Text = ""
        End Try
    End Sub

   


    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try

            sql = "SELECT EmployeeID,Lastname,Firstname,Middlename,Gender,convert(varchar, BirthDate, 101) as BirthDate,convert(varchar, DateHired, 101) as DateHired,Contact,Address,Email FROM Employee Where Lastname  LIKE '%" & txtSearch.Text.Trim() & "%' or  Firstname LIKE '%" & txtSearch.Text.Trim() & "%'  Order by  Lastname"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridEmployee.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridEmployee.Rows.Add()
                DataGridEmployee.Rows(x).Cells(0).Value = rd("EmployeeId").ToString
                DataGridEmployee.Rows(x).Cells(1).Value = rd("Firstname").ToString
                DataGridEmployee.Rows(x).Cells(2).Value = rd("Middlename").ToString
                DataGridEmployee.Rows(x).Cells(3).Value = rd("Lastname").ToString
                DataGridEmployee.Rows(x).Cells(4).Value = rd("Gender").ToString
                DataGridEmployee.Rows(x).Cells(5).Value = rd("Contact").ToString
                DataGridEmployee.Rows(x).Cells(6).Value = rd("Birthdate").ToString
                DataGridEmployee.Rows(x).Cells(7).Value = rd("DateHired").ToString
                DataGridEmployee.Rows(x).Cells(8).Value = rd("Address").ToString
                DataGridEmployee.Rows(x).Cells(9).Value = rd("Email").ToString


            End While
            myConn.Close()
            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
   

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

            sql = "SELECT EmployeeID,Lastname,Firstname,Middlename,Gender,convert(varchar, BirthDate, 101) as BirthDate,convert(varchar, DateHired, 101) as DateHired,Contact,Address,Email FROM Employee ORDER BY EmployeeID"
            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridEmployee.Rows.Clear()
            While rd.Read
                Dim x As Integer = DataGridEmployee.Rows.Add()
                DataGridEmployee.Rows(x).Cells(0).Value = rd("EmployeeID").ToString
                DataGridEmployee.Rows(x).Cells(1).Value = rd("Firstname").ToString
                DataGridEmployee.Rows(x).Cells(2).Value = rd("Middlename").ToString
                DataGridEmployee.Rows(x).Cells(3).Value = rd("Lastname").ToString
                DataGridEmployee.Rows(x).Cells(4).Value = rd("Gender").ToString
                DataGridEmployee.Rows(x).Cells(5).Value = rd("Contact").ToString
                DataGridEmployee.Rows(x).Cells(6).Value = rd("BirthDate").ToString
                DataGridEmployee.Rows(x).Cells(7).Value = rd("DateHired").ToString
                DataGridEmployee.Rows(x).Cells(8).Value = rd("Address").ToString
                DataGridEmployee.Rows(x).Cells(9).Value = rd("Email").ToString




            End While
            myConn.Close()
            txtSearch.ResetText()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtFirstname.ReadOnly = True
        txtMiddlename.ReadOnly = True
        txtLastname.ReadOnly = True
        txtContact.ReadOnly = True
        txtAddress.ReadOnly = True

        txtEmail.ReadOnly = True

        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True

    End Sub

    Private Sub DataGridEmployee_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridEmployee.CellClick
        Try

            txtEmployeeID.Text = DataGridEmployee.CurrentRow.Cells(0).Value
            txtFirstname.Text = DataGridEmployee.CurrentRow.Cells(1).Value
            txtMiddlename.Text = DataGridEmployee.CurrentRow.Cells(2).Value
            txtLastname.Text = DataGridEmployee.CurrentRow.Cells(3).Value
            txtGender.Text = DataGridEmployee.CurrentRow.Cells(4).Value
            txtContact.Text = DataGridEmployee.CurrentRow.Cells(5).Value
            txtBirthdate.Text = DataGridEmployee.CurrentRow.Cells(6).Value
            txtDateHired.Text = DataGridEmployee.CurrentRow.Cells(7).Value
            txtAddress.Text = DataGridEmployee.CurrentRow.Cells(8).Value
            txtEmail.Text = DataGridEmployee.CurrentRow.Cells(9).Value

        Catch ex As Exception

            txtEmployeeID.Text = ""
            txtFirstname.Text = ""
            txtMiddlename.Text = ""
            txtLastname.Text = ""
            txtGender.Text = ""
            txtContact.Text = ""
            txtBirthdate.Text = ""
            txtDateHired.Text = ""
            txtAddress.Text = ""
            txtEmail.Text = ""
        End Try


        txtFirstname.ReadOnly = False
        txtMiddlename.ReadOnly = False
        txtLastname.ReadOnly = False
        txtContact.ReadOnly = False
        txtAddress.ReadOnly = False
        txtEmail.ReadOnly = False

        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnNew.Enabled = True
        btnSave.Enabled = False
        txtFirstname.Focus()
    End Sub

    Private Sub frmEmployeeUser_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
      


        txtFirstname.ReadOnly = True
        txtMiddlename.ReadOnly = True
        txtLastname.ReadOnly = True
        txtContact.ReadOnly = True
        txtAddress.ReadOnly = True

        txtEmail.ReadOnly = True

        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True

        txtFirstname.Focus()
    End Sub

   
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        txtEmployeeID.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""
        txtGender.Text = ""
        txtContact.Text = ""
        txtBirthdate.Text = ""
        txtDateHired.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""

        txtFirstname.ReadOnly = False
        txtMiddlename.ReadOnly = False
        txtLastname.ReadOnly = False
        txtContact.ReadOnly = False
        txtAddress.ReadOnly = False

        txtEmail.ReadOnly = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnNew.Enabled = False
        txtFirstname.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

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

        If (txtBirthdate.Text.Trim().Length = 0) Then
            MsgBox("BirthDate is empty!")

            txtBirthdate.Focus()
            Return
        End If

        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If

        If (txtDateHired.Text.Trim().Length = 0) Then
            MsgBox("DateHired is empty!")

            txtDateHired.Focus()
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

                sql = "INSERT  INTO Employee (Lastname,Firstname,Middlename,Gender,BirthDate,DateHired,Contact,Address,Email) VALUES (@Lastname,@Firstname,@Middlename,@Gender,@Birthdate,@DateHired,@Contact,@Address,@Email)"

                cmd = New SqlCommand(sql, myConn)

                cmd.Parameters.AddWithValue("@Lastname", txtLastname.Text)
                cmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
                cmd.Parameters.AddWithValue("@Middlename", txtMiddlename.Text)
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text)
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@BirthDate", DateTime.Parse(txtBirthdate.Text))
                cmd.Parameters.AddWithValue("@DateHired", DateTime.Parse(txtDateHired.Text))

                myConn.Open()


                cmd.ExecuteNonQuery()
                myConn.Close()
                DisplayRecords()


                MsgBox("Successfully saved", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        txtFirstname.ReadOnly = True
        txtMiddlename.ReadOnly = True
        txtLastname.ReadOnly = True
        txtContact.ReadOnly = True
        txtAddress.ReadOnly = True
        txtEmail.ReadOnly = True

        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
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

        If (txtBirthdate.Text.Trim().Length = 0) Then
            MsgBox("BirthDate is empty!")

            txtBirthdate.Focus()
            Return
        End If

        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If

        If (txtDateHired.Text.Trim().Length = 0) Then
            MsgBox("Date Hired is empty!")
            txtContact.SelectAll()
            txtDateHired.Focus()
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

                sql = "UPDATE Employee SET Lastname='" & txtLastname.Text.Trim() & "',Firstname='" & txtFirstname.Text.Trim() & "',Middlename='" & txtMiddlename.Text.Trim() & "',Gender='" & txtGender.Text.Trim() & "',Email='" & txtEmail.Text.Trim() & "',BirthDate='" & txtBirthdate.Text.Trim() & "',DateHired='" & txtDateHired.Text.Trim() & "',Contact='" & txtContact.Text.Trim() & "',Address='" & txtAddress.Text.Trim() & "'WHERE EmployeeID='" & txtEmployeeID.Text.Trim() & "' "


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

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
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

        If (txtBirthdate.Text.Trim().Length = 0) Then
            MsgBox("BirthDate is empty!")

            txtBirthdate.Focus()
            Return
        End If

        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If

        If (txtDateHired.Text.Trim().Length = 0) Then
            MsgBox("Date Hired is empty!")

            txtDateHired.Focus()
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

                sql = "DELETE FROM Employee WHERE EmployeeID='" & txtEmployeeID.Text.Trim() & "'"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()
                txtEmployeeID.ResetText()
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
    Private Sub Numbers_only(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        frmMainUser.Show()
        Me.Close()
    End Sub

    Private Sub DataGridEmployee_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridEmployee.CellContentClick

    End Sub
End Class