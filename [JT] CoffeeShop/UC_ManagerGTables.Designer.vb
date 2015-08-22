<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ManagerGTables
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
        Me.MaNhom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenNhom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.DataGridView_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNhom, Me.TenNhom})
        Me.DataGridView_List.Location = New System.Drawing.Point(3, 61)
        Me.DataGridView_List.Name = "DataGridView_List"
        Me.DataGridView_List.RowHeadersVisible = False
        Me.DataGridView_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_List.Size = New System.Drawing.Size(429, 211)
        Me.DataGridView_List.TabIndex = 6
        '
        'MaNhom
        '
        Me.MaNhom.DataPropertyName = "MaNhom"
        Me.MaNhom.HeaderText = "Mã nhóm"
        Me.MaNhom.MinimumWidth = 120
        Me.MaNhom.Name = "MaNhom"
        Me.MaNhom.ReadOnly = True
        Me.MaNhom.Width = 120
        '
        'TenNhom
        '
        Me.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenNhom.DataPropertyName = "TenNhom"
        Me.TenNhom.HeaderText = "Tên nhóm"
        Me.TenNhom.MinimumWidth = 150
        Me.TenNhom.Name = "TenNhom"
        Me.TenNhom.ReadOnly = True
        '
        'Button_Save
        '
        Me.Button_Save.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Success
        Me.Button_Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Save.Location = New System.Drawing.Point(198, 30)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(53, 23)
        Me.Button_Save.TabIndex = 5
        Me.Button_Save.Text = "Lưu"
        Me.Button_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Error
        Me.Button_Delete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Delete.Location = New System.Drawing.Point(139, 30)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(53, 23)
        Me.Button_Delete.TabIndex = 4
        Me.Button_Delete.Text = "Xóa"
        Me.Button_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Information
        Me.Button_Edit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Edit.Location = New System.Drawing.Point(81, 30)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(52, 23)
        Me.Button_Edit.TabIndex = 3
        Me.Button_Edit.Text = "Sửa"
        Me.Button_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Image = Global.JT_CoffeeShop.My.Resources.Resources.Icon_Add
        Me.Button_Add.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button_Add.Location = New System.Drawing.Point(16, 30)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(59, 23)
        Me.Button_Add.TabIndex = 2
        Me.Button_Add.Text = "Thêm"
        Me.Button_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Location = New System.Drawing.Point(117, 3)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.ReadOnly = True
        Me.TextBox_Name.Size = New System.Drawing.Size(302, 20)
        Me.TextBox_Name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tên nhóm:"
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(344, 30)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(75, 23)
        Me.Button_Close.TabIndex = 7
        Me.Button_Close.Text = "Đóng"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'UC_ManagerGTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.DataGridView_List)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(435, 275)
        Me.Name = "UC_ManagerGTables"
        Me.Size = New System.Drawing.Size(435, 275)
        CType(Me.DataGridView_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_List As System.Windows.Forms.DataGridView
    Friend WithEvents MaNhom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenNhom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Button_Delete As System.Windows.Forms.Button
    Friend WithEvents Button_Edit As System.Windows.Forms.Button
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Close As System.Windows.Forms.Button

End Class
