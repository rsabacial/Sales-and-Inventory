<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.DataGridEmployee = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDelete = New System.Windows.Forms.PictureBox()
        Me.PictureBoxEdit = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSave = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAdd = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DataGridEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(324, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 45)
        Me.btnSearch.TabIndex = 55
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(107, 15)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(200, 26)
        Me.txtCustomerID.TabIndex = 53
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(107, 53)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(388, 26)
        Me.txtFirstname.TabIndex = 52
        '
        'DataGridEmployee
        '
        Me.DataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column9, Me.Column10})
        Me.DataGridEmployee.EnableHeadersVisualStyles = False
        Me.DataGridEmployee.Location = New System.Drawing.Point(12, 319)
        Me.DataGridEmployee.Name = "DataGridEmployee"
        Me.DataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridEmployee.Size = New System.Drawing.Size(1034, 309)
        Me.DataGridEmployee.TabIndex = 50
        '
        'Column1
        '
        Me.Column1.FillWeight = 120.0!
        Me.Column1.HeaderText = "CustomerID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.FillWeight = 120.0!
        Me.Column2.HeaderText = "Firstname"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.FillWeight = 120.0!
        Me.Column3.HeaderText = "Middlename"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.FillWeight = 120.0!
        Me.Column4.HeaderText = "Lastname"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "Gender"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.FillWeight = 120.0!
        Me.Column6.HeaderText = "Contact#"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column9
        '
        Me.Column9.FillWeight = 120.0!
        Me.Column9.HeaderText = "Address"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 130
        '
        'Column10
        '
        Me.Column10.FillWeight = 150.0!
        Me.Column10.HeaderText = "Email"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 150
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(648, 87)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(376, 26)
        Me.txtEmail.TabIndex = 49
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Location = New System.Drawing.Point(107, 87)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(388, 26)
        Me.txtMiddlename.TabIndex = 46
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(107, 119)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(388, 26)
        Me.txtLastname.TabIndex = 45
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(648, 127)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(376, 26)
        Me.txtContact.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 20)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Lastname"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Middlename"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Firstname"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "CustomerID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(563, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(563, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Contact"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(648, 53)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(376, 26)
        Me.txtAddress.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(563, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtMiddlename)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1034, 215)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'txtGender
        '
        Me.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtGender.Location = New System.Drawing.Point(107, 153)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(200, 28)
        Me.txtGender.TabIndex = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1034, 70)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(431, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 45)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(32, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 26)
        Me.txtSearch.TabIndex = 56
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.BackgroundImage = CType(resources.GetObject("PictureBoxClose.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxClose.Location = New System.Drawing.Point(729, 652)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxClose.TabIndex = 65
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxDelete
        '
        Me.PictureBoxDelete.BackgroundImage = CType(resources.GetObject("PictureBoxDelete.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxDelete.Location = New System.Drawing.Point(623, 652)
        Me.PictureBoxDelete.Name = "PictureBoxDelete"
        Me.PictureBoxDelete.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxDelete.TabIndex = 64
        Me.PictureBoxDelete.TabStop = False
        '
        'PictureBoxEdit
        '
        Me.PictureBoxEdit.BackgroundImage = CType(resources.GetObject("PictureBoxEdit.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxEdit.Location = New System.Drawing.Point(517, 652)
        Me.PictureBoxEdit.Name = "PictureBoxEdit"
        Me.PictureBoxEdit.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxEdit.TabIndex = 63
        Me.PictureBoxEdit.TabStop = False
        '
        'PictureBoxSave
        '
        Me.PictureBoxSave.BackgroundImage = CType(resources.GetObject("PictureBoxSave.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxSave.Location = New System.Drawing.Point(411, 652)
        Me.PictureBoxSave.Name = "PictureBoxSave"
        Me.PictureBoxSave.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxSave.TabIndex = 62
        Me.PictureBoxSave.TabStop = False
        '
        'PictureBoxAdd
        '
        Me.PictureBoxAdd.BackgroundImage = CType(resources.GetObject("PictureBoxAdd.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxAdd.Location = New System.Drawing.Point(305, 652)
        Me.PictureBoxAdd.Name = "PictureBoxAdd"
        Me.PictureBoxAdd.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxAdd.TabIndex = 61
        Me.PictureBoxAdd.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(648, 705)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Delete"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(439, 705)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 20)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Save"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(754, 705)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 20)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Close"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(552, 705)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 20)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Edit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(332, 705)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 20)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Add"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1059, 729)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.PictureBoxDelete)
        Me.Controls.Add(Me.PictureBoxEdit)
        Me.Controls.Add(Me.PictureBoxSave)
        Me.Controls.Add(Me.PictureBoxAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridEmployee)
        Me.Name = "frmCustomer"
        Me.Text = "frmCustomer"
        CType(Me.DataGridEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents DataGridEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtGender As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxDelete As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxSave As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxAdd As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
