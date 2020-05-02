<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployee))
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.DataGridEmployee = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridVEmployee = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txtDateHired = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDelete = New System.Windows.Forms.PictureBox()
        Me.PictureBoxEdit = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSave = New System.Windows.Forms.PictureBox()
        Me.PictureBoxAdd = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridVEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(204, 50)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(709, 26)
        Me.txtFirstname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Middlename"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lastname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(541, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Contact#"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(113, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Birthdate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(533, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "DateHired"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(115, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(132, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Email"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(616, 144)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(297, 26)
        Me.txtContact.TabIndex = 16
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(204, 84)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(709, 26)
        Me.txtMiddlename.TabIndex = 17
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(204, 114)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(709, 26)
        Me.txtLastname.TabIndex = 19
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(204, 208)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(709, 26)
        Me.txtAddress.TabIndex = 20
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(204, 240)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(709, 26)
        Me.txtEmail.TabIndex = 24
        '
        'DataGridEmployee
        '
        Me.DataGridEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridEmployee.EnableHeadersVisualStyles = False
        Me.DataGridEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridEmployee.Location = New System.Drawing.Point(12, 377)
        Me.DataGridEmployee.Name = "DataGridEmployee"
        Me.DataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridEmployee.Size = New System.Drawing.Size(1034, 207)
        Me.DataGridEmployee.TabIndex = 26
        '
        'Column1
        '
        Me.Column1.HeaderText = "EmployeeID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Firstname"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Middlename"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Lastname"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Gender"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Contact#"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Birthdate"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "DateHired"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Address"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Email"
        Me.Column10.Name = "Column10"
        '
        'DataGridVEmployee
        '
        Me.DataGridVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVEmployee.Location = New System.Drawing.Point(36, 282)
        Me.DataGridVEmployee.Name = "DataGridVEmployee"
        Me.DataGridVEmployee.Size = New System.Drawing.Size(981, 210)
        Me.DataGridVEmployee.TabIndex = 26
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(390, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 50)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeID.Location = New System.Drawing.Point(136, 19)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(200, 26)
        Me.txtEmployeeID.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "EmloyeeID"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(54, 31)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(297, 26)
        Me.txtSearch.TabIndex = 35
        '
        'txtBirthdate
        '
        Me.txtBirthdate.CustomFormat = ""
        Me.txtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtBirthdate.Location = New System.Drawing.Point(204, 174)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Size = New System.Drawing.Size(309, 26)
        Me.txtBirthdate.TabIndex = 36
        Me.txtBirthdate.Value = New Date(2017, 9, 1, 0, 0, 0, 0)
        '
        'txtDateHired
        '
        Me.txtDateHired.CustomFormat = "yyyy-MM-dd "
        Me.txtDateHired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDateHired.Location = New System.Drawing.Point(616, 176)
        Me.txtDateHired.Name = "txtDateHired"
        Me.txtDateHired.Size = New System.Drawing.Size(297, 26)
        Me.txtDateHired.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.txtMiddlename)
        Me.GroupBox1.Controls.Add(Me.txtDateHired)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtBirthdate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1034, 272)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'txtGender
        '
        Me.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txtGender.Location = New System.Drawing.Point(204, 144)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(309, 28)
        Me.txtGender.TabIndex = 38
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1034, 81)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(505, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 50)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(239, 666)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 20)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Add"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(500, 666)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 20)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Edit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(766, 666)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 20)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Close"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(372, 666)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 20)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Save"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(628, 666)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Delete"
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.BackgroundImage = CType(resources.GetObject("PictureBoxClose.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxClose.Location = New System.Drawing.Point(738, 613)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxClose.TabIndex = 76
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxDelete
        '
        Me.PictureBoxDelete.BackgroundImage = CType(resources.GetObject("PictureBoxDelete.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxDelete.Location = New System.Drawing.Point(606, 613)
        Me.PictureBoxDelete.Name = "PictureBoxDelete"
        Me.PictureBoxDelete.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxDelete.TabIndex = 75
        Me.PictureBoxDelete.TabStop = False
        '
        'PictureBoxEdit
        '
        Me.PictureBoxEdit.BackgroundImage = CType(resources.GetObject("PictureBoxEdit.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxEdit.Location = New System.Drawing.Point(473, 613)
        Me.PictureBoxEdit.Name = "PictureBoxEdit"
        Me.PictureBoxEdit.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxEdit.TabIndex = 74
        Me.PictureBoxEdit.TabStop = False
        '
        'PictureBoxSave
        '
        Me.PictureBoxSave.BackgroundImage = CType(resources.GetObject("PictureBoxSave.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxSave.Location = New System.Drawing.Point(341, 613)
        Me.PictureBoxSave.Name = "PictureBoxSave"
        Me.PictureBoxSave.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxSave.TabIndex = 73
        Me.PictureBoxSave.TabStop = False
        '
        'PictureBoxAdd
        '
        Me.PictureBoxAdd.BackgroundImage = CType(resources.GetObject("PictureBoxAdd.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxAdd.Location = New System.Drawing.Point(207, 613)
        Me.PictureBoxAdd.Name = "PictureBoxAdd"
        Me.PictureBoxAdd.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxAdd.TabIndex = 71
        Me.PictureBoxAdd.TabStop = False
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1058, 711)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.PictureBoxDelete)
        Me.Controls.Add(Me.PictureBoxEdit)
        Me.Controls.Add(Me.PictureBoxSave)
        Me.Controls.Add(Me.PictureBoxAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridEmployee)
        Me.Name = "frmEmployee"
        Me.Text = "frmEmployee"
        CType(Me.DataGridEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridVEmployee, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridVEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateHired As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGender As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxDelete As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxSave As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxAdd As System.Windows.Forms.PictureBox
End Class
