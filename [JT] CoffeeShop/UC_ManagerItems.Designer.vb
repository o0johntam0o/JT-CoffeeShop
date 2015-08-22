<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ManagerItems
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DonVi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox_GItems = New System.Windows.Forms.ComboBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.MaNhom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_List = New System.Windows.Forms.DataGridView()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.TextBox_unit = New System.Windows.Forms.TextBox()
        Me.TextBox_Price = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Close = New System.Windows.Forms.Button()
        CType(Me.DataGridView_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DonVi
        '
        Me.DonVi.DataPropertyName = "DonVi"
        Me.DonVi.HeaderText = "Đơn vị"
        Me.DonVi.MinimumWidth = 100
        Me.DonVi.Name = "DonVi"
        Me.DonVi.ReadOnly = True
        '
        'TenMon
        '
        Me.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenMon.DataPropertyName = "TenMon"
        Me.TenMon.HeaderText = "Tên món"
        Me.TenMon.MinimumWidth = 100
        Me.TenMon.Name = "TenMon"
        Me.TenMon.ReadOnly = True
        '
        'ComboBox_GItems
        '
        Me.ComboBox_GItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_GItems.FormattingEnabled = True
        Me.ComboBox_GItems.Location = New System.Drawing.Point(79, 35)
        Me.ComboBox_GItems.Name = "ComboBox_GItems"
        Me.ComboBox_GItems.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_GItems.TabIndex = 2
        '
        'Button_Add
        '
        Me.Button_Add.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Add
        Me.Button_Add.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Add.Location = New System.Drawing.Point(384, 4)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(61, 23)
        Me.Button_Add.TabIndex = 5
        Me.Button_Add.Text = "Thêm"
        Me.Button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'MaNhom
        '
        Me.MaNhom.DataPropertyName = "MaNhom"
        Me.MaNhom.HeaderText = "Nhóm món"
        Me.MaNhom.MinimumWidth = 90
        Me.MaNhom.Name = "MaNhom"
        Me.MaNhom.ReadOnly = True
        Me.MaNhom.Width = 90
        '
        'MaMon
        '
        Me.MaMon.DataPropertyName = "MaMon"
        Me.MaMon.HeaderText = "Mã món"
        Me.MaMon.MinimumWidth = 90
        Me.MaMon.Name = "MaMon"
        Me.MaMon.ReadOnly = True
        Me.MaMon.Width = 90
        '
        'DataGridView_List
        '
        Me.DataGridView_List.AllowUserToAddRows = False
        Me.DataGridView_List.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMon, Me.MaNhom, Me.TenMon, Me.DonGia, Me.DonVi})
        Me.DataGridView_List.Location = New System.Drawing.Point(3, 62)
        Me.DataGridView_List.Name = "DataGridView_List"
        Me.DataGridView_List.RowHeadersVisible = False
        Me.DataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_List.Size = New System.Drawing.Size(579, 259)
        Me.DataGridView_List.TabIndex = 9
        '
        'DonGia
        '
        Me.DonGia.DataPropertyName = "DonGia"
        Me.DonGia.HeaderText = "Đơn giá"
        Me.DonGia.MinimumWidth = 100
        Me.DonGia.Name = "DonGia"
        Me.DonGia.ReadOnly = True
        '
        'Button_Save
        '
        Me.Button_Save.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Success
        Me.Button_Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Save.Location = New System.Drawing.Point(451, 33)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(54, 23)
        Me.Button_Save.TabIndex = 8
        Me.Button_Save.Text = "Lưu"
        Me.Button_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Error
        Me.Button_Delete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Delete.Location = New System.Drawing.Point(451, 4)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button_Delete.Size = New System.Drawing.Size(54, 23)
        Me.Button_Delete.TabIndex = 7
        Me.Button_Delete.Text = "Xóa"
        Me.Button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Information
        Me.Button_Edit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Edit.Location = New System.Drawing.Point(384, 33)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(61, 23)
        Me.Button_Edit.TabIndex = 6
        Me.Button_Edit.Text = "Sửa"
        Me.Button_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'TextBox_unit
        '
        Me.TextBox_unit.Location = New System.Drawing.Point(260, 35)
        Me.TextBox_unit.MaxLength = 20
        Me.TextBox_unit.Name = "TextBox_unit"
        Me.TextBox_unit.ReadOnly = True
        Me.TextBox_unit.Size = New System.Drawing.Size(118, 20)
        Me.TextBox_unit.TabIndex = 4
        '
        'TextBox_Price
        '
        Me.TextBox_Price.Location = New System.Drawing.Point(260, 6)
        Me.TextBox_Price.MaxLength = 20
        Me.TextBox_Price.Name = "TextBox_Price"
        Me.TextBox_Price.ReadOnly = True
        Me.TextBox_Price.Size = New System.Drawing.Size(118, 20)
        Me.TextBox_Price.TabIndex = 3
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(79, 6)
        Me.TextBox_Name.MaxLength = 30
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.ReadOnly = True
        Me.TextBox_Name.Size = New System.Drawing.Size(122, 20)
        Me.TextBox_Name.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Đơn vị:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Đơn giá:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nhóm món:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tên món:"
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(512, 4)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(54, 52)
        Me.Button_Close.TabIndex = 10
        Me.Button_Close.Text = "Đóng"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'UC_ManagerItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.ComboBox_GItems)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.DataGridView_List)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.TextBox_unit)
        Me.Controls.Add(Me.TextBox_Price)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UC_ManagerItems"
        Me.Size = New System.Drawing.Size(585, 324)
        CType(Me.DataGridView_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DonVi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox_GItems As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents MaNhom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView_List As System.Windows.Forms.DataGridView
    Friend WithEvents DonGia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Button_Edit As System.Windows.Forms.Button
    Friend WithEvents TextBox_unit As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Price As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Close As System.Windows.Forms.Button

End Class
