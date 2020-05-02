<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtFlavor = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCotanct = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.dtpDaRe = New System.Windows.Forms.DateTimePicker()
        Me.dtpDade = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtReservationID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtCategories = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PicSave = New System.Windows.Forms.PictureBox()
        Me.picNew = New System.Windows.Forms.PictureBox()
        Me.PictureBox3Edit = New System.Windows.Forms.PictureBox()
        Me.PictureBox4Delete = New System.Windows.Forms.PictureBox()
        Me.PictureBox5Close = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataGridViewre = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnRefreshItem = New System.Windows.Forms.Button()
        Me.btnSearchItem = New System.Windows.Forms.Button()
        Me.txtSearchItems = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3Edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ReservationID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TotalPrice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DateReserved"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ItemName"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Categories"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "DateDeadline"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Contact"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Price"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(45, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Flavor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Address"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(149, 265)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(283, 26)
        Me.txtTotalPrice.TabIndex = 17
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(149, 186)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(283, 26)
        Me.txtPrice.TabIndex = 18
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(149, 226)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(283, 26)
        Me.txtQuantity.TabIndex = 19
        '
        'txtFlavor
        '
        Me.txtFlavor.Location = New System.Drawing.Point(149, 149)
        Me.txtFlavor.Name = "txtFlavor"
        Me.txtFlavor.ReadOnly = True
        Me.txtFlavor.Size = New System.Drawing.Size(283, 26)
        Me.txtFlavor.TabIndex = 20
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(149, 109)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(283, 26)
        Me.txtDescription.TabIndex = 21
        '
        'txtCotanct
        '
        Me.txtCotanct.Location = New System.Drawing.Point(159, 149)
        Me.txtCotanct.Name = "txtCotanct"
        Me.txtCotanct.ReadOnly = True
        Me.txtCotanct.Size = New System.Drawing.Size(291, 26)
        Me.txtCotanct.TabIndex = 23
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(159, 107)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(291, 26)
        Me.txtAddress.TabIndex = 24
        '
        'dtpDaRe
        '
        Me.dtpDaRe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDaRe.Location = New System.Drawing.Point(159, 189)
        Me.dtpDaRe.Name = "dtpDaRe"
        Me.dtpDaRe.Size = New System.Drawing.Size(291, 26)
        Me.dtpDaRe.TabIndex = 28
        '
        'dtpDade
        '
        Me.dtpDade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDade.Location = New System.Drawing.Point(159, 236)
        Me.dtpDade.Name = "dtpDade"
        Me.dtpDade.Size = New System.Drawing.Size(291, 26)
        Me.dtpDade.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchCustomer)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtReservationID)
        Me.GroupBox1.Controls.Add(Me.dtpDade)
        Me.GroupBox1.Controls.Add(Me.dtpDaRe)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtCotanct)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 299)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(452, 67)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(79, 30)
        Me.btnSearchCustomer.TabIndex = 50
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(159, 75)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(291, 26)
        Me.txtCustomerName.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Customer Name"
        '
        'txtReservationID
        '
        Me.txtReservationID.Location = New System.Drawing.Point(159, 37)
        Me.txtReservationID.Name = "txtReservationID"
        Me.txtReservationID.ReadOnly = True
        Me.txtReservationID.Size = New System.Drawing.Size(291, 26)
        Me.txtReservationID.TabIndex = 30
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtItemName)
        Me.GroupBox2.Controls.Add(Me.txtCategories)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtFlavor)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtTotalPrice)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(562, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(494, 299)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(149, 39)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(283, 26)
        Me.txtItemName.TabIndex = 48
        '
        'txtCategories
        '
        Me.txtCategories.Location = New System.Drawing.Point(149, 75)
        Me.txtCategories.Name = "txtCategories"
        Me.txtCategories.ReadOnly = True
        Me.txtCategories.Size = New System.Drawing.Size(283, 26)
        Me.txtCategories.TabIndex = 47
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 56)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(191, 26)
        Me.txtSearch.TabIndex = 33
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Location = New System.Drawing.Point(203, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(72, 43)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(281, 44)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(78, 43)
        Me.btnRefresh.TabIndex = 35
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PicSave
        '
        Me.PicSave.BackgroundImage = CType(resources.GetObject("PicSave.BackgroundImage"), System.Drawing.Image)
        Me.PicSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicSave.Location = New System.Drawing.Point(541, 625)
        Me.PicSave.Name = "PicSave"
        Me.PicSave.Size = New System.Drawing.Size(100, 69)
        Me.PicSave.TabIndex = 36
        Me.PicSave.TabStop = False
        '
        'picNew
        '
        Me.picNew.BackgroundImage = CType(resources.GetObject("picNew.BackgroundImage"), System.Drawing.Image)
        Me.picNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNew.Location = New System.Drawing.Point(423, 625)
        Me.picNew.Name = "picNew"
        Me.picNew.Size = New System.Drawing.Size(100, 69)
        Me.picNew.TabIndex = 37
        Me.picNew.TabStop = False
        '
        'PictureBox3Edit
        '
        Me.PictureBox3Edit.BackgroundImage = CType(resources.GetObject("PictureBox3Edit.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3Edit.Location = New System.Drawing.Point(661, 625)
        Me.PictureBox3Edit.Name = "PictureBox3Edit"
        Me.PictureBox3Edit.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox3Edit.TabIndex = 38
        Me.PictureBox3Edit.TabStop = False
        '
        'PictureBox4Delete
        '
        Me.PictureBox4Delete.BackgroundImage = CType(resources.GetObject("PictureBox4Delete.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4Delete.Location = New System.Drawing.Point(779, 625)
        Me.PictureBox4Delete.Name = "PictureBox4Delete"
        Me.PictureBox4Delete.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox4Delete.TabIndex = 39
        Me.PictureBox4Delete.TabStop = False
        '
        'PictureBox5Close
        '
        Me.PictureBox5Close.BackgroundImage = CType(resources.GetObject("PictureBox5Close.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5Close.Location = New System.Drawing.Point(894, 625)
        Me.PictureBox5Close.Name = "PictureBox5Close"
        Me.PictureBox5Close.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox5Close.TabIndex = 40
        Me.PictureBox5Close.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(452, 704)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 20)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "New"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(564, 704)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 20)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Save"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(689, 704)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 20)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Edit"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(811, 704)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 20)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Delete"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(926, 704)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 20)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Close"
        '
        'DataGridViewre
        '
        Me.DataGridViewre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
        Me.DataGridViewre.Location = New System.Drawing.Point(12, 310)
        Me.DataGridViewre.Name = "DataGridViewre"
        Me.DataGridViewre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewre.Size = New System.Drawing.Size(1044, 301)
        Me.DataGridViewre.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.HeaderText = "ReservationID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "CustomerName"
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Address"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Contact"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "DateReserved"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "DateDeadline"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Categories"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "ItemName"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Description"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Flavor"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Quantity"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Price"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.HeaderText = "TotalPrice"
        Me.Column15.Name = "Column15"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column16, Me.Column17, Me.Column18, Me.Column19})
        Me.DataGridView1.Location = New System.Drawing.Point(29, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(244, 538)
        Me.DataGridView1.TabIndex = 46
        '
        'Column4
        '
        Me.Column4.HeaderText = "ItemName"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Column16
        '
        Me.Column16.HeaderText = "Categories"
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 5
        '
        'Column17
        '
        Me.Column17.HeaderText = "Description"
        Me.Column17.Name = "Column17"
        Me.Column17.Width = 5
        '
        'Column18
        '
        Me.Column18.HeaderText = "Flavor"
        Me.Column18.Name = "Column18"
        Me.Column18.Width = 5
        '
        'Column19
        '
        Me.Column19.HeaderText = "Price"
        Me.Column19.Name = "Column19"
        Me.Column19.Width = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnRefreshItem)
        Me.GroupBox3.Controls.Add(Me.btnSearchItem)
        Me.GroupBox3.Controls.Add(Me.txtSearchItems)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(1062, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 719)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        '
        'btnRefreshItem
        '
        Me.btnRefreshItem.Location = New System.Drawing.Point(167, 656)
        Me.btnRefreshItem.Name = "btnRefreshItem"
        Me.btnRefreshItem.Size = New System.Drawing.Size(75, 52)
        Me.btnRefreshItem.TabIndex = 50
        Me.btnRefreshItem.Text = "Refresh"
        Me.btnRefreshItem.UseVisualStyleBackColor = True
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Location = New System.Drawing.Point(55, 656)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(75, 52)
        Me.btnSearchItem.TabIndex = 49
        Me.btnSearchItem.Text = "Search"
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'txtSearchItems
        '
        Me.txtSearchItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchItems.Location = New System.Drawing.Point(21, 620)
        Me.txtSearchItems.Name = "txtSearchItems"
        Me.txtSearchItems.Size = New System.Drawing.Size(266, 30)
        Me.txtSearchItems.TabIndex = 48
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(97, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 49)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Items"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSearch)
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Controls.Add(Me.btnRefresh)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 617)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(379, 107)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        '
        'frmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox5Close)
        Me.Controls.Add(Me.PictureBox4Delete)
        Me.Controls.Add(Me.PictureBox3Edit)
        Me.Controls.Add(Me.picNew)
        Me.Controls.Add(Me.PicSave)
        Me.Controls.Add(Me.DataGridViewre)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReservation"
        Me.Text = "frmReservation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3Edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtFlavor As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtCotanct As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents dtpDaRe As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDade As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents PicSave As System.Windows.Forms.PictureBox
    Friend WithEvents picNew As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3Edit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4Delete As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5Close As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtReservationID As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewre As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCategories As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchCustomer As System.Windows.Forms.Button
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRefreshItem As System.Windows.Forms.Button
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents txtSearchItems As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
