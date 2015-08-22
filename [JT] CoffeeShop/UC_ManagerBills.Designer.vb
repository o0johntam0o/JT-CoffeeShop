<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ManagerBills
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
        Me.MaPhieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayTao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Print = New System.Windows.Forms.Button()
        Me.ComboBox_Expression = New System.Windows.Forms.ComboBox()
        Me.TextBox_Expression = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Find = New System.Windows.Forms.Button()
        Me.Button_View = New System.Windows.Forms.Button()
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
        Me.DataGridView_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhieu, Me.MaBan, Me.NgayTao})
        Me.DataGridView_List.Location = New System.Drawing.Point(3, 61)
        Me.DataGridView_List.Name = "DataGridView_List"
        Me.DataGridView_List.RowHeadersVisible = False
        Me.DataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_List.Size = New System.Drawing.Size(456, 420)
        Me.DataGridView_List.TabIndex = 7
        '
        'MaPhieu
        '
        Me.MaPhieu.DataPropertyName = "MaPhieu"
        Me.MaPhieu.HeaderText = "Mã phiếu"
        Me.MaPhieu.MinimumWidth = 120
        Me.MaPhieu.Name = "MaPhieu"
        Me.MaPhieu.ReadOnly = True
        Me.MaPhieu.Width = 120
        '
        'MaBan
        '
        Me.MaBan.DataPropertyName = "MaBan"
        Me.MaBan.HeaderText = "Mã bàn"
        Me.MaBan.MinimumWidth = 120
        Me.MaBan.Name = "MaBan"
        Me.MaBan.ReadOnly = True
        Me.MaBan.Width = 120
        '
        'NgayTao
        '
        Me.NgayTao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NgayTao.DataPropertyName = "NgayTao"
        Me.NgayTao.HeaderText = "Ngày tạo phiếu"
        Me.NgayTao.MinimumWidth = 120
        Me.NgayTao.Name = "NgayTao"
        Me.NgayTao.ReadOnly = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Error
        Me.Button_Delete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Delete.Location = New System.Drawing.Point(238, 31)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(113, 23)
        Me.Button_Delete.TabIndex = 6
        Me.Button_Delete.Text = "Xóa hóa đơn"
        Me.Button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Print
        '
        Me.Button_Print.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Success
        Me.Button_Print.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Print.Location = New System.Drawing.Point(129, 32)
        Me.Button_Print.Name = "Button_Print"
        Me.Button_Print.Size = New System.Drawing.Size(103, 23)
        Me.Button_Print.TabIndex = 5
        Me.Button_Print.Text = "In hóa đơn"
        Me.Button_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Print.UseVisualStyleBackColor = True
        '
        'ComboBox_Expression
        '
        Me.ComboBox_Expression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Expression.FormattingEnabled = True
        Me.ComboBox_Expression.Items.AddRange(New Object() {"Mã phiếu", "Mã bàn", "Ngày tạo phiếu"})
        Me.ComboBox_Expression.Location = New System.Drawing.Point(230, 3)
        Me.ComboBox_Expression.Name = "ComboBox_Expression"
        Me.ComboBox_Expression.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Expression.TabIndex = 2
        '
        'TextBox_Expression
        '
        Me.TextBox_Expression.Location = New System.Drawing.Point(66, 5)
        Me.TextBox_Expression.Name = "TextBox_Expression"
        Me.TextBox_Expression.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Expression.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Điều kiện"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tìm kiếm"
        '
        'Button_Find
        '
        Me.Button_Find.Location = New System.Drawing.Point(357, 3)
        Me.Button_Find.Name = "Button_Find"
        Me.Button_Find.Size = New System.Drawing.Size(90, 22)
        Me.Button_Find.TabIndex = 3
        Me.Button_Find.Text = "Tìm kiếm"
        Me.Button_Find.UseVisualStyleBackColor = True
        '
        'Button_View
        '
        Me.Button_View.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Information
        Me.Button_View.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_View.Location = New System.Drawing.Point(14, 32)
        Me.Button_View.Name = "Button_View"
        Me.Button_View.Size = New System.Drawing.Size(109, 23)
        Me.Button_View.TabIndex = 4
        Me.Button_View.Text = "Xem hóa đơn"
        Me.Button_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_View.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(357, 31)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(90, 23)
        Me.Button_Close.TabIndex = 8
        Me.Button_Close.Text = "Đóng"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'UC_ManagerBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.DataGridView_List)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Print)
        Me.Controls.Add(Me.ComboBox_Expression)
        Me.Controls.Add(Me.TextBox_Expression)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Find)
        Me.Controls.Add(Me.Button_View)
        Me.Name = "UC_ManagerBills"
        Me.Size = New System.Drawing.Size(462, 484)
        CType(Me.DataGridView_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_List As System.Windows.Forms.DataGridView
    Friend WithEvents MaPhieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaBan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NgayTao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Button_Print As System.Windows.Forms.Button
    Friend WithEvents ComboBox_Expression As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox_Expression As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Find As System.Windows.Forms.Button
    Friend WithEvents Button_View As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button

End Class
