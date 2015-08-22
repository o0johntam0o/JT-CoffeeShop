<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Main
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
        Me.GroupBox_ThongTinBan = New System.Windows.Forms.GroupBox()
        Me.DataGridView_TableInfo = New System.Windows.Forms.DataGridView()
        Me.MaMon1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMon1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuong1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonVi1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label_CurrentTable = New System.Windows.Forms.Label()
        Me.Label_CurrentPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Calculate = New System.Windows.Forms.Button()
        Me.Button_PrintBill = New System.Windows.Forms.Button()
        Me.Button_DeleteItem = New System.Windows.Forms.Button()
        Me.Button_AddItem = New System.Windows.Forms.Button()
        Me.GroupBox_DanhSachMon = New System.Windows.Forms.GroupBox()
        Me.DataGridView_ItemsList = New System.Windows.Forms.DataGridView()
        Me.MaMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonVi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox_DanhSachBan = New System.Windows.Forms.GroupBox()
        Me.TreeView_TablesList = New System.Windows.Forms.TreeView()
        Me.GroupBox_ThongTinBan.SuspendLayout()
        CType(Me.DataGridView_TableInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_DanhSachMon.SuspendLayout()
        CType(Me.DataGridView_ItemsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_DanhSachBan.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_ThongTinBan
        '
        Me.GroupBox_ThongTinBan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.DataGridView_TableInfo)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.Label_CurrentTable)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.Label_CurrentPrice)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.Label2)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.Label1)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.Button_Calculate)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.Button_PrintBill)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.Button_DeleteItem)
        Me.GroupBox_ThongTinBan.Controls.Add(Me.Button_AddItem)
        Me.GroupBox_ThongTinBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_ThongTinBan.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox_ThongTinBan.Location = New System.Drawing.Point(214, 228)
        Me.GroupBox_ThongTinBan.Name = "GroupBox_ThongTinBan"
        Me.GroupBox_ThongTinBan.Size = New System.Drawing.Size(529, 270)
        Me.GroupBox_ThongTinBan.TabIndex = 0
        Me.GroupBox_ThongTinBan.TabStop = False
        Me.GroupBox_ThongTinBan.Text = "THÔNG TIN BÀN"
        '
        'DataGridView_TableInfo
        '
        Me.DataGridView_TableInfo.AllowUserToAddRows = False
        Me.DataGridView_TableInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_TableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_TableInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMon1, Me.TenMon1, Me.DonGia1, Me.SoLuong1, Me.DonVi1})
        Me.DataGridView_TableInfo.Location = New System.Drawing.Point(6, 69)
        Me.DataGridView_TableInfo.Name = "DataGridView_TableInfo"
        Me.DataGridView_TableInfo.ReadOnly = True
        Me.DataGridView_TableInfo.RowHeadersVisible = False
        Me.DataGridView_TableInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_TableInfo.Size = New System.Drawing.Size(517, 195)
        Me.DataGridView_TableInfo.TabIndex = 0
        '
        'MaMon1
        '
        Me.MaMon1.DataPropertyName = "MaMon"
        Me.MaMon1.HeaderText = "Mã món"
        Me.MaMon1.Name = "MaMon1"
        Me.MaMon1.ReadOnly = True
        Me.MaMon1.Width = 80
        '
        'TenMon1
        '
        Me.TenMon1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenMon1.DataPropertyName = "TenMon"
        Me.TenMon1.HeaderText = "Tên món"
        Me.TenMon1.Name = "TenMon1"
        Me.TenMon1.ReadOnly = True
        '
        'DonGia1
        '
        Me.DonGia1.DataPropertyName = "DonGia"
        Me.DonGia1.HeaderText = "Đơn giá"
        Me.DonGia1.Name = "DonGia1"
        Me.DonGia1.ReadOnly = True
        '
        'SoLuong1
        '
        Me.SoLuong1.DataPropertyName = "SoLuong"
        Me.SoLuong1.HeaderText = "Số lượng"
        Me.SoLuong1.Name = "SoLuong1"
        Me.SoLuong1.ReadOnly = True
        Me.SoLuong1.Width = 90
        '
        'DonVi1
        '
        Me.DonVi1.DataPropertyName = "DonVi"
        Me.DonVi1.HeaderText = "Đơn vị"
        Me.DonVi1.Name = "DonVi1"
        Me.DonVi1.ReadOnly = True
        '
        'Label_CurrentTable
        '
        Me.Label_CurrentTable.AutoSize = True
        Me.Label_CurrentTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CurrentTable.ForeColor = System.Drawing.Color.Red
        Me.Label_CurrentTable.Location = New System.Drawing.Point(72, 51)
        Me.Label_CurrentTable.Name = "Label_CurrentTable"
        Me.Label_CurrentTable.Size = New System.Drawing.Size(19, 13)
        Me.Label_CurrentTable.TabIndex = 0
        Me.Label_CurrentTable.Text = "---"
        '
        'Label_CurrentPrice
        '
        Me.Label_CurrentPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_CurrentPrice.AutoSize = True
        Me.Label_CurrentPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CurrentPrice.ForeColor = System.Drawing.Color.Red
        Me.Label_CurrentPrice.Location = New System.Drawing.Point(410, 50)
        Me.Label_CurrentPrice.Name = "Label_CurrentPrice"
        Me.Label_CurrentPrice.Size = New System.Drawing.Size(27, 13)
        Me.Label_CurrentPrice.TabIndex = 0
        Me.Label_CurrentPrice.Text = "0 Đ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(3, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Đang chọn:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(321, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Giá tiền hiện tại:"
        '
        'Button_Calculate
        '
        Me.Button_Calculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Calculate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button_Calculate.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Success
        Me.Button_Calculate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Calculate.Location = New System.Drawing.Point(430, 19)
        Me.Button_Calculate.Name = "Button_Calculate"
        Me.Button_Calculate.Size = New System.Drawing.Size(93, 24)
        Me.Button_Calculate.TabIndex = 6
        Me.Button_Calculate.Text = "Tính tiền"
        Me.Button_Calculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Calculate.UseVisualStyleBackColor = True
        '
        'Button_PrintBill
        '
        Me.Button_PrintBill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_PrintBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_PrintBill.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button_PrintBill.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Information
        Me.Button_PrintBill.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_PrintBill.Location = New System.Drawing.Point(324, 19)
        Me.Button_PrintBill.Name = "Button_PrintBill"
        Me.Button_PrintBill.Size = New System.Drawing.Size(100, 24)
        Me.Button_PrintBill.TabIndex = 5
        Me.Button_PrintBill.Text = "In hóa đơn"
        Me.Button_PrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_PrintBill.UseVisualStyleBackColor = True
        '
        'Button_DeleteItem
        '
        Me.Button_DeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DeleteItem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button_DeleteItem.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Error
        Me.Button_DeleteItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_DeleteItem.Location = New System.Drawing.Point(109, 19)
        Me.Button_DeleteItem.Name = "Button_DeleteItem"
        Me.Button_DeleteItem.Size = New System.Drawing.Size(92, 24)
        Me.Button_DeleteItem.TabIndex = 4
        Me.Button_DeleteItem.Text = "Xóa món"
        Me.Button_DeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_DeleteItem.UseVisualStyleBackColor = True
        '
        'Button_AddItem
        '
        Me.Button_AddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_AddItem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button_AddItem.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Add
        Me.Button_AddItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_AddItem.Location = New System.Drawing.Point(6, 19)
        Me.Button_AddItem.Name = "Button_AddItem"
        Me.Button_AddItem.Size = New System.Drawing.Size(97, 24)
        Me.Button_AddItem.TabIndex = 3
        Me.Button_AddItem.Text = "Thêm món"
        Me.Button_AddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_AddItem.UseVisualStyleBackColor = True
        '
        'GroupBox_DanhSachMon
        '
        Me.GroupBox_DanhSachMon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_DanhSachMon.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox_DanhSachMon.Controls.Add(Me.DataGridView_ItemsList)
        Me.GroupBox_DanhSachMon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_DanhSachMon.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox_DanhSachMon.Location = New System.Drawing.Point(214, 3)
        Me.GroupBox_DanhSachMon.Name = "GroupBox_DanhSachMon"
        Me.GroupBox_DanhSachMon.Size = New System.Drawing.Size(529, 220)
        Me.GroupBox_DanhSachMon.TabIndex = 0
        Me.GroupBox_DanhSachMon.TabStop = False
        Me.GroupBox_DanhSachMon.Text = "DANH SÁCH MÓN"
        '
        'DataGridView_ItemsList
        '
        Me.DataGridView_ItemsList.AllowUserToAddRows = False
        Me.DataGridView_ItemsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView_ItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_ItemsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMon, Me.TenMon, Me.DonGia, Me.DonVi})
        Me.DataGridView_ItemsList.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView_ItemsList.Name = "DataGridView_ItemsList"
        Me.DataGridView_ItemsList.ReadOnly = True
        Me.DataGridView_ItemsList.RowHeadersVisible = False
        Me.DataGridView_ItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_ItemsList.Size = New System.Drawing.Size(517, 195)
        Me.DataGridView_ItemsList.TabIndex = 2
        '
        'MaMon
        '
        Me.MaMon.DataPropertyName = "MaMon"
        Me.MaMon.HeaderText = "Mã món"
        Me.MaMon.Name = "MaMon"
        Me.MaMon.ReadOnly = True
        Me.MaMon.Width = 80
        '
        'TenMon
        '
        Me.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenMon.DataPropertyName = "TenMon"
        Me.TenMon.HeaderText = "Tên món"
        Me.TenMon.Name = "TenMon"
        Me.TenMon.ReadOnly = True
        '
        'DonGia
        '
        Me.DonGia.DataPropertyName = "DonGia"
        Me.DonGia.HeaderText = "Đơn giá"
        Me.DonGia.Name = "DonGia"
        Me.DonGia.ReadOnly = True
        '
        'DonVi
        '
        Me.DonVi.DataPropertyName = "DonVi"
        Me.DonVi.HeaderText = "Đơn vị"
        Me.DonVi.Name = "DonVi"
        Me.DonVi.ReadOnly = True
        '
        'GroupBox_DanhSachBan
        '
        Me.GroupBox_DanhSachBan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_DanhSachBan.Controls.Add(Me.TreeView_TablesList)
        Me.GroupBox_DanhSachBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_DanhSachBan.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox_DanhSachBan.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox_DanhSachBan.Name = "GroupBox_DanhSachBan"
        Me.GroupBox_DanhSachBan.Size = New System.Drawing.Size(205, 495)
        Me.GroupBox_DanhSachBan.TabIndex = 0
        Me.GroupBox_DanhSachBan.TabStop = False
        Me.GroupBox_DanhSachBan.Text = "DANH SÁCH BÀN"
        '
        'TreeView_TablesList
        '
        Me.TreeView_TablesList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeView_TablesList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView_TablesList.HideSelection = False
        Me.TreeView_TablesList.Location = New System.Drawing.Point(6, 19)
        Me.TreeView_TablesList.Name = "TreeView_TablesList"
        Me.TreeView_TablesList.Size = New System.Drawing.Size(193, 470)
        Me.TreeView_TablesList.TabIndex = 1
        '
        'UC_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox_ThongTinBan)
        Me.Controls.Add(Me.GroupBox_DanhSachMon)
        Me.Controls.Add(Me.GroupBox_DanhSachBan)
        Me.MinimumSize = New System.Drawing.Size(745, 500)
        Me.Name = "UC_Main"
        Me.Size = New System.Drawing.Size(745, 500)
        Me.GroupBox_ThongTinBan.ResumeLayout(False)
        Me.GroupBox_ThongTinBan.PerformLayout()
        CType(Me.DataGridView_TableInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_DanhSachMon.ResumeLayout(False)
        CType(Me.DataGridView_ItemsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_DanhSachBan.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox_ThongTinBan As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_TableInfo As System.Windows.Forms.DataGridView
    Friend WithEvents MaMon1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenMon1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGia1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoLuong1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonVi1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label_CurrentTable As System.Windows.Forms.Label
    Friend WithEvents Label_CurrentPrice As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Calculate As System.Windows.Forms.Button
    Friend WithEvents Button_PrintBill As System.Windows.Forms.Button
    Friend WithEvents Button_DeleteItem As System.Windows.Forms.Button
    Friend WithEvents Button_AddItem As System.Windows.Forms.Button
    Friend WithEvents GroupBox_DanhSachMon As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_ItemsList As System.Windows.Forms.DataGridView
    Friend WithEvents MaMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenMon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonGia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DonVi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox_DanhSachBan As System.Windows.Forms.GroupBox
    Friend WithEvents TreeView_TablesList As System.Windows.Forms.TreeView

End Class
