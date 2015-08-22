Public Class UC_ManagerItems
    Private _Mode As String
    Private _iMaNhom() As String

    Private Sub UC_ManagerItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Mode = ""
        Dim tmp_ClassLoaiMon = New Class_GItems()
        ReDim _iMaNhom(tmp_ClassLoaiMon.DanhSach.Rows.Count - 1)

        ComboBox_GItems.Items.Clear()

        For i As Integer = 0 To tmp_ClassLoaiMon.DanhSach.Rows.Count - 1
            ComboBox_GItems.Items.Add(tmp_ClassLoaiMon.DanhSach.Rows(i).Item("TenNhom"))
            _iMaNhom(i) = tmp_ClassLoaiMon.DanhSach.Rows(i).Item("MaNhom")
        Next

        If ComboBox_GItems.Items.Count > 0 Then ComboBox_GItems.SelectedIndex = 0

        LoadList()
    End Sub

    ' SUBS

    Private Sub LoadList()
        Me.Enabled = 0

        Dim tmp_ClassThucDon = New Class_Items()
        Dim tmp_ClassNhomMon = New Class_GItems()
        Dim DS = tmp_ClassThucDon.DanhSach
        For Each mon As DataRow In DS.Rows
            tmp_ClassNhomMon.TimThongTin(mon.Item("MaNhom"))
            mon.Item("MaNhom") = tmp_ClassNhomMon.TenNhom
        Next
        DataGridView_List.DataSource = DS

        Me.Enabled = 1
    End Sub

    ' BUTTON EVENTS

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        If _Mode = "" Or _Mode = "Sua" Then
            _Mode = "Them"
            TextBox_Name.ReadOnly = False
            TextBox_Price.ReadOnly = False
            TextBox_unit.ReadOnly = False
            TextBox_Name.Text = ""
            TextBox_Price.Text = ""
            TextBox_unit.Text = ""
        End If
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If _Mode = "" Then
            _Mode = "Sua"
            TextBox_Name.ReadOnly = False
            TextBox_Price.ReadOnly = False
            TextBox_unit.ReadOnly = False
        End If
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If DataGridView_List.SelectedRows.Count > 0 Then
            If MsgBox("Bạn có thật sự muốn xóa những món đã chọn?", MsgBoxStyle.YesNo, "Xóa món") = MsgBoxResult.No Then
                Exit Sub
            End If

            For i As Integer = 0 To DataGridView_List.SelectedRows.Count - 1 Step 1
                Dim tmp_ClassThucDon = New Class_Items()
                tmp_ClassThucDon.MaMon = DataGridView_List.SelectedRows(i).Cells("MaMon").Value.ToString

                If Not tmp_ClassThucDon.Xoa() Then
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Xóa món thất bại!", MsgBoxStyle.Critical, "Error XM01")
                    Exit Sub
                End If
            Next

            MsgBox("Xóa món thành công!")
            LoadList()
        Else
            MsgBox("Vui lòng chọn món cần xóa!")
        End If
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If _Mode = "Them" Then
            If ComboBox_GItems.SelectedIndex >= 0 Then
                Dim tmp_ClassThucDon = New Class_Items()
                tmp_ClassThucDon.TenMon = TextBox_Name.Text
                tmp_ClassThucDon.MaNhom = _iMaNhom(ComboBox_GItems.SelectedIndex)
                tmp_ClassThucDon.DonGia = TextBox_Price.Text
                tmp_ClassThucDon.DonVi = TextBox_unit.Text

                If tmp_ClassThucDon.Them() Then
                    MsgBox("Thêm món thành công!")
                    LoadList()
                Else
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Thêm món thất bại!", MsgBoxStyle.Critical, "Error TM01")
                End If

                _Mode = ""
                TextBox_Name.ReadOnly = True
                TextBox_Price.ReadOnly = True
                TextBox_unit.ReadOnly = True
            Else
                MsgBox("Vui lòng chọn loại món!")
            End If
        ElseIf _Mode = "Sua" Then
            If DataGridView_List.SelectedRows.Count = 1 Then
                If ComboBox_GItems.SelectedIndex >= 0 Then
                    Dim tmp_ClassThucDon = New Class_Items()
                    tmp_ClassThucDon.MaMon = DataGridView_List.SelectedRows(0).Cells("MaMon").Value.ToString
                    tmp_ClassThucDon.TenMon = TextBox_Name.Text
                    tmp_ClassThucDon.MaNhom = _iMaNhom(ComboBox_GItems.SelectedIndex)
                    tmp_ClassThucDon.DonGia = TextBox_Price.Text
                    tmp_ClassThucDon.DonVi = TextBox_unit.Text
                    If tmp_ClassThucDon.Them() Then
                        MsgBox("Sửa thông tin món thành công!")
                        LoadList()
                    Else
                        MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Sửa thông tin món thất bại!", MsgBoxStyle.Critical, "Error SM01")
                    End If

                    _Mode = ""
                    TextBox_Name.ReadOnly = True
                    TextBox_Price.ReadOnly = True
                    TextBox_unit.ReadOnly = True
                Else
                    MsgBox("Vui lòng chọn loại món!")
                End If
            Else
                MsgBox("Vui lòng chọn một món cần sửa!")
            End If
        End If
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Enabled = False
        Form_Main.tmp_UCMain.LoadDanhSachMon()
        Form_Main.tmp_UCMain.LoadThongTinBan()
        Form_Main.tmp_UCMain.Visible = True
        Me.Dispose()
    End Sub

    ' DATAGRIDVIEW EVENTS

    Private Sub DataGridView_List_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView_List.SelectionChanged
        If DataGridView_List.SelectedRows.Count > 0 Then
            _Mode = ""
            TextBox_Name.ReadOnly = True
            TextBox_Price.ReadOnly = True
            TextBox_unit.ReadOnly = True

            TextBox_Name.Text = DataGridView_List.SelectedRows(0).Cells("TenMon").Value.ToString
            ComboBox_GItems.SelectedItem = DataGridView_List.SelectedRows(0).Cells("MaNhom").Value.ToString
            TextBox_Price.Text = DataGridView_List.SelectedRows(0).Cells("DonGia").Value.ToString
            TextBox_unit.Text = DataGridView_List.SelectedRows(0).Cells("DonVi").Value.ToString
        End If
    End Sub

    ' COMBOBOX EVENTS

    Private Sub ComboBox_Group_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboBox_GItems.KeyPress
        e.Handled = True
    End Sub

    ' TEXTBOX EVENTS

    Private Sub TextBox_Price_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_Price.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
