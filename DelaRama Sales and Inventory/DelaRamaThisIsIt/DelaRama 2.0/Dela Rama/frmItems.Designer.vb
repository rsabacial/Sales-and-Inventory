<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCategories = New System.Windows.Forms.ComboBox()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtFlavor = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.PictureBoxAdd = New System.Windows.Forms.PictureBox()
        Me.PictureBoxSave = New System.Windows.Forms.PictureBox()
        Me.PictureBoxEdit = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDelete = New System.Windows.Forms.PictureBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtExpirationDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4, Me.Column8, Me.Column7, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 443)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1095, 186)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ItemID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Categories"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "ItemName"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "Description"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Flavor"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'Column8
        '
        Me.Column8.HeaderText = "ExpirationDate"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Stock"
        Me.Column7.Name = "Column7"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'txtCategories
        '
        Me.txtCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategories.FormattingEnabled = True
        Me.txtCategories.Items.AddRange(New Object() {"Cake", "Beverages", "Stuffs", "Desserts", "Balloons"})
        Me.txtCategories.Location = New System.Drawing.Point(247, 132)
        Me.txtCategories.Name = "txtCategories"
        Me.txtCategories.Size = New System.Drawing.Size(690, 28)
        Me.txtCategories.TabIndex = 2
        '
        'txtItemID
        '
        Me.txtItemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemID.Location = New System.Drawing.Point(247, 87)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.ReadOnly = True
        Me.txtItemID.Size = New System.Drawing.Size(690, 26)
        Me.txtItemID.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ItemID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ItemName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(115, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Categories"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(111, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Flavor"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(247, 360)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(690, 26)
        Me.txtPrice.TabIndex = 10
        '
        'txtFlavor
        '
        Me.txtFlavor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlavor.Location = New System.Drawing.Point(247, 239)
        Me.txtFlavor.Name = "txtFlavor"
        Me.txtFlavor.Size = New System.Drawing.Size(690, 26)
        Me.txtFlavor.TabIndex = 12
        '
        'txtItemName
        '
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(247, 175)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(690, 26)
        Me.txtItemName.TabIndex = 13
        '
        'PictureBoxAdd
        '
        Me.PictureBoxAdd.BackgroundImage = CType(resources.GetObject("PictureBoxAdd.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxAdd.Location = New System.Drawing.Point(307, 635)
        Me.PictureBoxAdd.Name = "PictureBoxAdd"
        Me.PictureBoxAdd.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxAdd.TabIndex = 14
        Me.PictureBoxAdd.TabStop = False
        '
        'PictureBoxSave
        '
        Me.PictureBoxSave.BackgroundImage = CType(resources.GetObject("PictureBoxSave.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxSave.Location = New System.Drawing.Point(443, 635)
        Me.PictureBoxSave.Name = "PictureBoxSave"
        Me.PictureBoxSave.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxSave.TabIndex = 15
        Me.PictureBoxSave.TabStop = False
        '
        'PictureBoxEdit
        '
        Me.PictureBoxEdit.BackgroundImage = CType(resources.GetObject("PictureBoxEdit.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxEdit.Location = New System.Drawing.Point(568, 635)
        Me.PictureBoxEdit.Name = "PictureBoxEdit"
        Me.PictureBoxEdit.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxEdit.TabIndex = 16
        Me.PictureBoxEdit.TabStop = False
        '
        'PictureBoxDelete
        '
        Me.PictureBoxDelete.BackgroundImage = CType(resources.GetObject("PictureBoxDelete.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxDelete.Location = New System.Drawing.Point(704, 635)
        Me.PictureBoxDelete.Name = "PictureBoxDelete"
        Me.PictureBoxDelete.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxDelete.TabIndex = 17
        Me.PictureBoxDelete.TabStop = False
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.BackgroundImage = CType(resources.GetObject("PictureBoxClose.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxClose.Location = New System.Drawing.Point(837, 635)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxClose.TabIndex = 18
        Me.PictureBoxClose.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(39, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(313, 26)
        Me.txtSearch.TabIndex = 19
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(386, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 41)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(480, 21)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(87, 41)
        Me.btnrefresh.TabIndex = 21
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(337, 688)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 20)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Add"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(600, 688)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 20)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Edit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(864, 688)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 20)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Close"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(470, 688)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 20)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Save"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(726, 688)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 20)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Delete"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(247, 328)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(690, 26)
        Me.txtStock.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Stock"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(247, 207)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(690, 26)
        Me.txtDescription.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(115, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 20)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(111, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 20)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "Expiration Date"
        '
        'txtExpirationDate
        '
        Me.txtExpirationDate.CustomFormat = "MM-dd-yyyy"
        Me.txtExpirationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtExpirationDate.Location = New System.Drawing.Point(247, 284)
        Me.txtExpirationDate.Name = "txtExpirationDate"
        Me.txtExpirationDate.Size = New System.Drawing.Size(327, 26)
        Me.txtExpirationDate.TabIndex = 81
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1131, 724)
        Me.Controls.Add(Me.txtExpirationDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.PictureBoxDelete)
        Me.Controls.Add(Me.PictureBoxEdit)
        Me.Controls.Add(Me.PictureBoxSave)
        Me.Controls.Add(Me.PictureBoxAdd)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtFlavor)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.txtCategories)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmItems"
        Me.Text = "frmItems"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtCategories As System.Windows.Forms.ComboBox
    Friend WithEvents txtItemID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtFlavor As System.Windows.Forms.TextBox
    Friend WithEvents txtItemName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxAdd As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxSave As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxEdit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxDelete As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtExpirationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
