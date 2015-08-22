Public Class UC_ManagerWaiters
    Private _Mode As String
    Private _iMaNhom() As String

    Private Sub UC_ManagerWaiters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Mode = ""
        Dim tmp_ClassNhomBan = New Class_GTables()
        ReDim _iMaNhom(tmp_ClassNhomBan.DanhSach.Rows.Count - 1)

        ComboBox_GTables.Items.Clear()

        For i As Integer = 0 To tmp_ClassNhomBan.DanhSach.Rows.Count - 1
            ComboBox_GTables.Items.Add(tmp_ClassNhomBan.DanhSach.Rows(i).Item("TenNhom"))
            _iMaNhom(i) = tmp_ClassNhomBan.DanhSach.Rows(i).Item("MaNhom")
        Next

        If ComboBox_GTables.Items.Count > 0 Then ComboBox_GTables.SelectedIndex = 0
        If ComboBox_Gender.Items.Count > 0 Then ComboBox_Gender.SelectedIndex = 0
        If ComboBox_Shift.Items.Count > 0 Then ComboBox_Shift.SelectedIndex = 0

        LoadList()
    End Sub

    ' SUBS

    Private Sub LoadList()
        Me.Enabled = 0

        Dim tmp_ClassNhanVien = New Class_Waiters()
        Dim tmp_ClassNhomBan = New Class_GTables()
        Dim DS = tmp_ClassNhanVien.DanhSach
        For Each kv As DataRow In DS.Rows
            tmp_ClassNhomBan.TimThongTin(kv.Item("MaNhom"))
            kv.Item("MaNhom") = tmp_ClassNhomBan.TenNhom
        Next
        DataGridView_List.DataSource = DS

        Me.Enabled = 1
    End Sub

    ' BUTTON EVENTS

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        If _Mode = "" Or _Mode = "Sua" Then
            _Mode = "Them"
            TextBox_Name.ReadOnly = False
            TextBox_Address.ReadOnly = False
            TextBox_Phone.ReadOnly = False
            TextBox_Salary.ReadOnly = False

            TextBox_Name.Text = ""
            TextBox_Address.Text = ""
            TextBox_Phone.Text = ""
            TextBox_Salary.Text = ""

            DateTimePicker_Birth.Value = New DateTime(1990, 8, 12)
            DateTimePicker_RecruitmentDate.Value = DateTime.Now.Date.ToString
        End If
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If _Mode = "" Then
            _Mode = "Sua"
            TextBox_Name.ReadOnly = False
            TextBox_Address.ReadOnly = False
            TextBox_Phone.ReadOnly = False
            TextBox_Salary.ReadOnly = False
        End If
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If DataGridView_List.SelectedRows.Count > 0 Then
            If MsgBox("Bạn có thật sự muốn xóa những nhân viên đã chọn?", MsgBoxStyle.YesNo, "Xóa nhân viên") = MsgBoxResult.No Then
                Exit Sub
            End If

            For i As Integer = 0 To DataGridView_List.SelectedRows.Count - 1 Step 1
                Dim tmp_ClassNhanVien = New Class_Waiters()
                tmp_ClassNhanVien.MaNV = DataGridView_List.SelectedRows(i).Cells("MaNV").Value.ToString

                If Not tmp_ClassNhanVien.Xoa() Then
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Xóa nhân viên thất bại!", MsgBoxStyle.Critical, "Error XN01")
                    Exit Sub
                End If
            Next

            MsgBox("Xóa nhân viên thành công!")
            LoadList()
        Else
            MsgBox("Vui lòng chọn nhân viên cần xóa!")
        End If
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If _Mode = "Them" Then
            If TextBox_Name.Text.Length > 0 Then
                If ComboBox_GTables.SelectedIndex >= 0 Then
                    Dim tmp_ClassNhanVien = New Class_Waiters()
                    tmp_ClassNhanVien.MaNhom = _iMaNhom(ComboBox_GTables.SelectedIndex)
                    tmp_ClassNhanVien.HoTen = TextBox_Name.Text
                    tmp_ClassNhanVien.GioiTinh = ComboBox_Gender.SelectedItem.ToString
                    tmp_ClassNhanVien.NgaySinh = DateTimePicker_Birth.Value
                    tmp_ClassNhanVien.DiaChi = TextBox_Address.Text
                    If IsNumeric(TextBox_Phone.Text) Then tmp_ClassNhanVien.DienThoai = TextBox_Phone.Text
                    tmp_ClassNhanVien.NgayTuyen = DateTimePicker_RecruitmentDate.Value
                    If IsNumeric(TextBox_Salary.Text) Then tmp_ClassNhanVien.Luong = TextBox_Salary.Text
                    tmp_ClassNhanVien.CaTruc = ComboBox_Shift.SelectedItem.ToString

                    If tmp_ClassNhanVien.Them() Then
                        MsgBox("Thêm nhân viên thành công!")
                        LoadList()
                    Else
                        MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Thêm nhân viên thất bại!", MsgBoxStyle.Critical, "Error TN01")
                    End If

                    _Mode = ""
                    TextBox_Name.ReadOnly = True
                    TextBox_Address.ReadOnly = True
                    TextBox_Phone.ReadOnly = True
                    TextBox_Salary.ReadOnly = True
                Else
                    MsgBox("Vui lòng chọn khu vực!")
                End If
            Else
                MsgBox("Vui lòng nhập họ tên!")
            End If
        ElseIf _Mode = "Sua" Then
            If DataGridView_List.SelectedRows.Count = 1 Then
                If TextBox_Name.Text.Length > 0 Then
                    If ComboBox_GTables.SelectedIndex >= 0 Then
                        Dim tmp_ClassNhanVien = New Class_Waiters()
                        tmp_ClassNhanVien.MaNV = DataGridView_List.SelectedRows(0).Cells(0).Value.ToString
                        tmp_ClassNhanVien.MaNhom = _iMaNhom(ComboBox_GTables.SelectedIndex)
                        tmp_ClassNhanVien.HoTen = TextBox_Name.Text
                        tmp_ClassNhanVien.GioiTinh = ComboBox_Gender.SelectedItem.ToString
                        tmp_ClassNhanVien.NgaySinh = DateTimePicker_Birth.Value
                        tmp_ClassNhanVien.DiaChi = TextBox_Address.Text
                        tmp_ClassNhanVien.DienThoai = TextBox_Phone.Text
                        tmp_ClassNhanVien.NgayTuyen = DateTimePicker_RecruitmentDate.Value
                        tmp_ClassNhanVien.Luong = TextBox_Salary.Text
                        tmp_ClassNhanVien.CaTruc = ComboBox_Shift.SelectedItem.ToString

                        If tmp_ClassNhanVien.Them() Then
                            MsgBox("Sửa thông tin nhân viên thành công!")
                            LoadList()
                        Else
                            MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Sửa thông tin nhân viên thất bại!", MsgBoxStyle.Critical, "Error SN01")
                        End If

                        _Mode = ""
                        TextBox_Name.ReadOnly = True
                        TextBox_Address.ReadOnly = True
                        TextBox_Phone.ReadOnly = True
                        TextBox_Salary.ReadOnly = True
                    Else
                        MsgBox("Vui lòng chọn khu vực!")
                    End If
                Else
                    MsgBox("Vui lòng nhập họ tên!")
                End If
            Else
                MsgBox("Vui lòng chọn một nhân viên cần sửa!")
            End If
        End If
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Form_Main.tmp_UCMain.Visible = True
        Me.Dispose()
    End Sub

    ' DATAGRIDVIEW EVENTS

    Private Sub DataGridView_List_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView_List.SelectionChanged
        If DataGridView_List.SelectedRows.Count > 0 Then
            _Mode = ""
            TextBox_Name.ReadOnly = True
            TextBox_Address.ReadOnly = True
            TextBox_Phone.ReadOnly = True
            TextBox_Salary.ReadOnly = True

            TextBox_Name.Text = DataGridView_List.SelectedRows(0).Cells("HoTen").Value.ToString
            TextBox_Address.Text = DataGridView_List.SelectedRows(0).Cells("DiaChi").Value.ToString
            TextBox_Phone.Text = DataGridView_List.SelectedRows(0).Cells("DienThoai").Value.ToString
            TextBox_Salary.Text = DataGridView_List.SelectedRows(0).Cells("Luong").Value.ToString

            ComboBox_Gender.SelectedItem = DataGridView_List.SelectedRows(0).Cells("GioiTinh").Value.ToString
            ComboBox_GTables.SelectedItem = DataGridView_List.SelectedRows(0).Cells("MaNhom").Value.ToString
            ComboBox_Shift.SelectedItem = DataGridView_List.SelectedRows(0).Cells("CaTruc").Value.ToString

            DateTimePicker_Birth.Value = DataGridView_List.SelectedRows(0).Cells("NgaySinh").Value.ToString
            DateTimePicker_RecruitmentDate.Value = DataGridView_List.SelectedRows(0).Cells("NgayTuyen").Value.ToString
        End If
    End Sub

    ' TEXTBOX EVENTS

    Private Sub TextBox_Phone_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_Phone.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_Salary_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_Salary.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    ' COMBOBOX EVENTS

    Private Sub ComboBox_Gender_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboBox_Gender.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox_GTables_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboBox_GTables.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox_Shift_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboBox_Shift.KeyPress
        e.Handled = True
    End Sub
End Class
