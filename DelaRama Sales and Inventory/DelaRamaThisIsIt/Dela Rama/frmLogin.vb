

Public Class frmLogin

  

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusername.ResetText()
        txtpassword.ResetText()

    End Sub


  
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

       

        If txtusername.Text = "admin" And txtpassword.Text = "admin" Then

            MsgBox("Login Succesfully")
            frmMain.Show()
            Me.Hide()
        ElseIf txtusername.Text = "user" And txtpassword.Text = "user" Then
            MsgBox("Login Succesfully")
            frmMainUser.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Password/Username", MessageBoxIcon.Error)





        End If

        txtpassword.ResetText()
        txtusername.ResetText()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Dim result As DialogResult _
            = MessageBox.Show("Do you really want to Exit ?",
              "Save", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Me.Close()
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    

   

    Private Sub txtpassword_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub cbselect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
