Public Class UC_ManagerTables
    Private _Mode As String
    Private _iMaNhom() As String

    Private Sub UC_ManagerTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Mode = ""
        Dim tmp_ClassNhomBan = New Class_GTables()
        ReDim _iMaNhom(tmp_ClassNhomBan.DanhSach.Rows.Count - 1)

        ComboBox_GTables.Items.Clear()

        For i As Integer = 0 To tmp_ClassNhomBan.DanhSach.Rows.Count - 1
            ComboBox_GTables.Items.Add(tmp_ClassNhomBan.DanhSach.Rows(i).Item("TenNhom"))
            _iMaNhom(i) = tmp_ClassNhomBan.DanhSach.Rows(i).Item("MaNhom")
        Next

        If ComboBox_GTables.Items.Count > 0 Then ComboBox_GTables.SelectedIndex = 0

        LoadList()
    End Sub

    ' SUBS

    Private Sub LoadList()
        Me.Enabled = 0

        Dim tmp_ClassBan = New Class_Tables()
        Dim tmp_ClassNhomBan = New Class_GTables()
        Dim DS = tmp_ClassBan.DanhSach
        For Each ban As DataRow In DS.Rows
            tmp_ClassNhomBan.TimThongTin(ban.Item("MaNhom"))
            ban.Item("MaNhom") = tmp_ClassNhomBan.TenNhom
        Next
        DataGridView_List.DataSource = DS

        Me.Enabled = 1
    End Sub

    ' BUTTON EVENTS

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        If _Mode = "" Or _Mode = "Sua" Then
            _Mode = "Them"
            TextBox_Name.ReadOnly = False
            TextBox_Name.Text = ""
        End If
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        If _Mode = "" Then
            _Mode = "Sua"
            TextBox_Name.ReadOnly = False
        End If
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If DataGridView_List.SelectedRows.Count > 0 Then
            If MsgBox("Bạn có thật sự muốn xóa những bàn đã chọn?" & vbCrLf & "LƯU Ý: TẤT CẢ CÁC 'HÓA ĐƠN' CỦA BÀN NÀY SẼ BỊ XÓA HẾT!", MsgBoxStyle.YesNo, "Xóa bàn") = MsgBoxResult.No Then
                Exit Sub
            End If

            If MsgBox("Bạn có thật sự muốn tiếp tục?" & vbCrLf & "NHẮC LẠI: TẤT CẢ CÁC 'HÓA ĐƠN' CỦA BÀN NÀY SẼ BỊ XÓA HẾT!", MsgBoxStyle.YesNo, "Xóa bàn") = MsgBoxResult.No Then
                Exit Sub
            End If

            For i As Integer = 0 To DataGridView_List.SelectedRows.Count - 1 Step 1
                Dim tmp_ClassBan = New Class_Tables()
                tmp_ClassBan.MaBan = DataGridView_List.SelectedRows(i).Cells("MaBan").Value.ToString

                If Not tmp_ClassBan.Xoa() Then
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Xóa bàn thất bại!", MsgBoxStyle.Critical, "Error XB01")
                    Exit Sub
                End If
            Next

            MsgBox("Xóa bàn thành công!")
            LoadList()
        Else
            MsgBox("Vui lòng chọn bàn cần xóa!")
        End If
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If _Mode = "Them" Then
            If ComboBox_GTables.SelectedIndex >= 0 Then
                Dim tmp_ClassBan = New Class_Tables()
                tmp_ClassBan.TenBan = TextBox_Name.Text
                tmp_ClassBan.MaNhom = _iMaNhom(ComboBox_GTables.SelectedIndex)

                If tmp_ClassBan.Them() Then
                    MsgBox("Thêm bàn thành công!")
                    LoadList()
                Else
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Thêm bàn thất bại!", MsgBoxStyle.Critical, "Error TB01")
                End If

                _Mode = ""
                TextBox_Name.ReadOnly = True
            Else
                MsgBox("Vui lòng chọn nhóm!")
            End If
        ElseIf _Mode = "Sua" Then
            If DataGridView_List.SelectedRows.Count = 1 Then
                If ComboBox_GTables.SelectedIndex >= 0 Then
                    Dim tmp_ClassBan = New Class_Tables()
                    tmp_ClassBan.MaBan = DataGridView_List.SelectedRows(0).Cells("MaBan").Value.ToString
                    tmp_ClassBan.TenBan = TextBox_Name.Text
                    tmp_ClassBan.MaNhom = _iMaNhom(ComboBox_GTables.SelectedIndex)
                    If tmp_ClassBan.Them() Then
                        MsgBox("Sửa thông tin bàn thành công!")
                        LoadList()
                    Else
                        MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Sửa thông tin bàn thất bại!", MsgBoxStyle.Critical, "Error SB01")
                    End If

                    _Mode = ""
                    TextBox_Name.ReadOnly = True
                Else
                    MsgBox("Vui lòng chọn nhóm!")
                End If
            Else
                MsgBox("Vui lòng chọn một bàn cần sửa!")
            End If
        End If
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Enabled = False
        Form_Main.tmp_UCMain.LoadDanhSachBan()
        Form_Main.tmp_UCMain.LoadThongTinBan()
        Form_Main.tmp_UCMain.Visible = True
        Me.Dispose()
    End Sub

    ' DATAGRIDVIEW EVENTS

    Private Sub DataGridView_List_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView_List.SelectionChanged
        If DataGridView_List.SelectedRows.Count > 0 Then
            _Mode = ""
            TextBox_Name.ReadOnly = True

            TextBox_Name.Text = DataGridView_List.SelectedRows(0).Cells("TenBan").Value.ToString
            ComboBox_GTables.SelectedItem = DataGridView_List.SelectedRows(0).Cells("MaNhom").Value.ToString
        End If
    End Sub

    ' COMBOBOX EVENTS

    Private Sub ComboBox_GTables_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboBox_GTables.KeyPress
        e.Handled = True
    End Sub
End Class
