<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ManagerWaiters
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
        Me.DataGridView_List = New System.Windows.Forms.DataGridView()
        Me.MaNV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNhom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DienThoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Luong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTuyen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaTruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox_Address = New System.Windows.Forms.TextBox()
        Me.TextBox_Phone = New System.Windows.Forms.TextBox()
        Me.TextBox_Salary = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_Birth = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_RecruitmentDate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_Gender = New System.Windows.Forms.ComboBox()
        Me.ComboBox_GTables = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Shift = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        CType(Me.DataGridView_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_List
        '
        Me.DataGridView_List.AllowUserToAddRows = False
        Me.DataGridView_List.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNV, Me.MaNhom, Me.HoTen, Me.GioiTinh, Me.NgaySinh, Me.DiaChi, Me.DienThoai, Me.Luong, Me.NgayTuyen, Me.CaTruc})
        Me.DataGridView_List.Location = New System.Drawing.Point(3, 137)
        Me.DataGridView_List.Name = "DataGridView_List"
        Me.DataGridView_List.RowHeadersVisible = False
        Me.DataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_List.Size = New System.Drawing.Size(740, 276)
        Me.DataGridView_List.TabIndex = 14
        '
        'MaNV
        '
        Me.MaNV.DataPropertyName = "MaNV"
        Me.MaNV.HeaderText = "Mã NV"
        Me.MaNV.MinimumWidth = 50
        Me.MaNV.Name = "MaNV"
        Me.MaNV.ReadOnly = True
        Me.MaNV.Width = 50
        '
        'MaNhom
        '
        Me.MaNhom.DataPropertyName = "MaNhom"
        Me.MaNhom.HeaderText = "Nhóm bàn"
        Me.MaNhom.MinimumWidth = 60
        Me.MaNhom.Name = "MaNhom"
        Me.MaNhom.ReadOnly = True
        Me.MaNhom.Width = 60
        '
        'HoTen
        '
        Me.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoTen.DataPropertyName = "HoTen"
        Me.HoTen.HeaderText = "Họ tên"
        Me.HoTen.MinimumWidth = 100
        Me.HoTen.Name = "HoTen"
        Me.HoTen.ReadOnly = True
        '
        'GioiTinh
        '
        Me.GioiTinh.DataPropertyName = "GioiTinh"
        Me.GioiTinh.HeaderText = "Phái nữ"
        Me.GioiTinh.MinimumWidth = 40
        Me.GioiTinh.Name = "GioiTinh"
        Me.GioiTinh.ReadOnly = True
        Me.GioiTinh.Width = 40
        '
        'NgaySinh
        '
        Me.NgaySinh.DataPropertyName = "NgaySinh"
        Me.NgaySinh.HeaderText = "Ngày sinh"
        Me.NgaySinh.MinimumWidth = 80
        Me.NgaySinh.Name = "NgaySinh"
        Me.NgaySinh.ReadOnly = True
        Me.NgaySinh.Width = 80
        '
        'DiaChi
        '
        Me.DiaChi.DataPropertyName = "DiaChi"
        Me.DiaChi.HeaderText = "Địa chỉ"
        Me.DiaChi.MinimumWidth = 100
        Me.DiaChi.Name = "DiaChi"
        Me.DiaChi.ReadOnly = True
        '
        'DienThoai
        '
        Me.DienThoai.DataPropertyName = "DienThoai"
        Me.DienThoai.HeaderText = "Điện thoại"
        Me.DienThoai.MinimumWidth = 70
        Me.DienThoai.Name = "DienThoai"
        Me.DienThoai.ReadOnly = True
        Me.DienThoai.Width = 70
        '
        'Luong
        '
        Me.Luong.DataPropertyName = "Luong"
        Me.Luong.HeaderText = "Lương"
        Me.Luong.MinimumWidth = 80
        Me.Luong.Name = "Luong"
        Me.Luong.ReadOnly = True
        Me.Luong.Width = 80
        '
        'NgayTuyen
        '
        Me.NgayTuyen.DataPropertyName = "NgayTuyen"
        Me.NgayTuyen.HeaderText = "Ngày tuyển"
        Me.NgayTuyen.MinimumWidth = 80
        Me.NgayTuyen.Name = "NgayTuyen"
        Me.NgayTuyen.ReadOnly = True
        Me.NgayTuyen.Width = 80
        '
        'CaTruc
        '
        Me.CaTruc.DataPropertyName = "CaTruc"
        Me.CaTruc.HeaderText = "Ca trực"
        Me.CaTruc.MinimumWidth = 70
        Me.CaTruc.Name = "CaTruc"
        Me.CaTruc.ReadOnly = True
        Me.CaTruc.Width = 70
        '
        'TextBox_Address
        '
        Me.TextBox_Address.Location = New System.Drawing.Point(306, 3)
        Me.TextBox_Address.MaxLength = 50
        Me.TextBox_Address.Name = "TextBox_Address"
        Me.TextBox_Address.ReadOnly = True
        Me.TextBox_Address.Size = New System.Drawing.Size(188, 20)
        Me.TextBox_Address.TabIndex = 4
        '
        'TextBox_Phone
        '
        Me.TextBox_Phone.Location = New System.Drawing.Point(306, 35)
        Me.TextBox_Phone.MaxLength = 11
        Me.TextBox_Phone.Name = "TextBox_Phone"
        Me.TextBox_Phone.ReadOnly = True
        Me.TextBox_Phone.Size = New System.Drawing.Size(188, 20)
        Me.TextBox_Phone.TabIndex = 5
        '
        'TextBox_Salary
        '
        Me.TextBox_Salary.Location = New System.Drawing.Point(306, 68)
        Me.TextBox_Salary.MaxLength = 20
        Me.TextBox_Salary.Name = "TextBox_Salary"
        Me.TextBox_Salary.ReadOnly = True
        Me.TextBox_Salary.Size = New System.Drawing.Size(188, 20)
        Me.TextBox_Salary.TabIndex = 6
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(76, 3)
        Me.TextBox_Name.MaxLength = 30
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.ReadOnly = True
        Me.TextBox_Name.Size = New System.Drawing.Size(160, 20)
        Me.TextBox_Name.TabIndex = 1
        '
        'DateTimePicker_Birth
        '
        Me.DateTimePicker_Birth.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_Birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Birth.Location = New System.Drawing.Point(76, 35)
        Me.DateTimePicker_Birth.Name = "DateTimePicker_Birth"
        Me.DateTimePicker_Birth.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker_Birth.TabIndex = 2
        '
        'DateTimePicker_RecruitmentDate
        '
        Me.DateTimePicker_RecruitmentDate.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_RecruitmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_RecruitmentDate.Location = New System.Drawing.Point(570, 4)
        Me.DateTimePicker_RecruitmentDate.Name = "DateTimePicker_RecruitmentDate"
        Me.DateTimePicker_RecruitmentDate.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker_RecruitmentDate.TabIndex = 7
        '
        'ComboBox_Gender
        '
        Me.ComboBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Gender.FormattingEnabled = True
        Me.ComboBox_Gender.Items.AddRange(New Object() {"True", "False"})
        Me.ComboBox_Gender.Location = New System.Drawing.Point(76, 66)
        Me.ComboBox_Gender.Name = "ComboBox_Gender"
        Me.ComboBox_Gender.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox_Gender.TabIndex = 3
        '
        'ComboBox_GTables
        '
        Me.ComboBox_GTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_GTables.FormattingEnabled = True
        Me.ComboBox_GTables.Location = New System.Drawing.Point(570, 66)
        Me.ComboBox_GTables.Name = "ComboBox_GTables"
        Me.ComboBox_GTables.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox_GTables.TabIndex = 9
        '
        'ComboBox_Shift
        '
        Me.ComboBox_Shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Shift.FormattingEnabled = True
        Me.ComboBox_Shift.Items.AddRange(New Object() {"Sáng + Chiều", "Sáng", "Chiều"})
        Me.ComboBox_Shift.Location = New System.Drawing.Point(570, 35)
        Me.ComboBox_Shift.Name = "ComboBox_Shift"
        Me.ComboBox_Shift.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox_Shift.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(500, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Nhóm bàn:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(500, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Ngày tuyển:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(500, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Ca trực:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Lương:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Điện thoại:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Địa chỉ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Ngày sinh:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Phái nữ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Họ tên:"
        '
        'Button_Save
        '
        Me.Button_Save.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Success
        Me.Button_Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Save.Location = New System.Drawing.Point(204, 102)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(54, 23)
        Me.Button_Save.TabIndex = 13
        Me.Button_Save.Text = "Lưu"
        Me.Button_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Error
        Me.Button_Delete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Delete.Location = New System.Drawing.Point(144, 102)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(54, 23)
        Me.Button_Delete.TabIndex = 12
        Me.Button_Delete.Text = "Xóa"
        Me.Button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Information
        Me.Button_Edit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Edit.Location = New System.Drawing.Point(84, 102)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(54, 23)
        Me.Button_Edit.TabIndex = 11
        Me.Button_Edit.Text = "Sửa"
        Me.Button_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Add
        Me.Button_Add.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Add.Location = New System.Drawing.Point(16, 102)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(62, 23)
        Me.Button_Add.TabIndex = 10
        Me.Button_Add.Text = "Thêm"
        Me.Button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(636, 102)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(94, 23)
        Me.Button_Close.TabIndex = 15
        Me.Button_Close.Text = "Đóng"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'UC_ManagerWaiters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.DataGridView_List)
        Me.Controls.Add(Me.TextBox_Address)
        Me.Controls.Add(Me.TextBox_Phone)
        Me.Controls.Add(Me.TextBox_Salary)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.DateTimePicker_Birth)
        Me.Controls.Add(Me.DateTimePicker_RecruitmentDate)
        Me.Controls.Add(Me.ComboBox_Gender)
        Me.Controls.Add(Me.ComboBox_GTables)
        Me.Controls.Add(Me.ComboBox_Shift)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Add)
        Me.Name = "UC_ManagerWaiters"
        Me.Size = New System.Drawing.Size(746, 416)
        CType(Me.DataGridView_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_List As System.Windows.Forms.DataGridView
    Friend WithEvents MaNV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaNhom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoTen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GioiTinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgaySinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DienThoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Luong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayTuyen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaTruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox_Address As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Phone As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Salary As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker_Birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker_RecruitmentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox_Gender As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_GTables As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Shift As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Button_Edit As System.Windows.Forms.Button
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button

End Class
