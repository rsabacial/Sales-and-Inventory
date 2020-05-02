Public Class frmMainUser

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

        Dim result As DialogResult _
            = MessageBox.Show("Do you really want to log out ?",
              "Save", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

  
   

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        frmItemsUser.Show()
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        frmOrderUser.Show()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        frmCustomerUser.Show()
        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        frmReservationUser.Show()
        Me.Close()
    End Sub

  

    Private Sub frmMainUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

   
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
End Class