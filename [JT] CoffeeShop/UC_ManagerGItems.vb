﻿Public Class UC_ManagerGItems
    Private _Mode As String

    Private Sub UC_ManagerGItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Mode = ""
        LoadList()
    End Sub

    ' SUBS

    Private Sub LoadList()
        Me.Enabled = 0

        Dim tmp_ClassLoaiMon = New Class_GItems()
        Dim DS = tmp_ClassLoaiMon.DanhSach
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
            If MsgBox("Bạn có thật sự muốn xóa những nhóm đã chọn?" & vbCrLf & "LƯU Ý: TẤT CẢ CÁC 'MÓN' CÓ TRONG NHÓM NÀY SẼ BỊ XÓA HẾT!", MsgBoxStyle.YesNo, "Xóa nhóm") = MsgBoxResult.No Then
                Exit Sub
            End If

            If MsgBox("Bạn có thật sự muốn tiếp tục?" & vbCrLf & "NHẮC LẠI: TẤT CẢ CÁC 'MÓN' CÓ TRONG NHÓM NÀY SẼ BỊ XÓA HẾT!", MsgBoxStyle.YesNo, "Xóa nhóm") = MsgBoxResult.No Then
                Exit Sub
            End If

            For i As Integer = 0 To DataGridView_List.SelectedRows.Count - 1 Step 1
                Dim tmp_ClassNhomMon = New Class_GItems()
                tmp_ClassNhomMon.MaNhom = DataGridView_List.SelectedRows(i).Cells("MaNhom").Value.ToString

                If Not tmp_ClassNhomMon.Xoa() Then
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Xóa nhóm thất bại!", MsgBoxStyle.Critical, "Error XNM01")
                    Exit Sub
                End If
            Next

            MsgBox("Xóa nhóm thành công!")
            LoadList()
        Else
            MsgBox("Vui lòng chọn nhóm cần xóa!")
        End If
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If _Mode = "Them" Then
            Dim tmp_ClassNhomMon = New Class_GItems()
            tmp_ClassNhomMon.TenNhom = TextBox_Name.Text

            If tmp_ClassNhomMon.Them() Then
                MsgBox("Thêm nhóm thành công!")
                LoadList()
            Else
                MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Thêm nhóm thất bại!", MsgBoxStyle.Critical, "Error TNM01")
            End If

            _Mode = ""
            TextBox_Name.ReadOnly = True
        ElseIf _Mode = "Sua" Then
            If DataGridView_List.SelectedRows.Count = 1 Then
                Dim tmp_ClassNhomMon = New Class_GItems()
                tmp_ClassNhomMon.MaNhom = DataGridView_List.SelectedRows(0).Cells("MaNhom").Value.ToString
                tmp_ClassNhomMon.TenNhom = TextBox_Name.Text

                If tmp_ClassNhomMon.Them() Then
                    MsgBox("Sửa thông tin nhóm thành công!")
                    LoadList()
                Else
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Sửa thông tin nhóm thất bại!", MsgBoxStyle.Critical, "Error SNM01")
                End If

                _Mode = ""
                TextBox_Name.ReadOnly = True
            Else
                MsgBox("Vui lòng chọn một nhóm cần sửa!")
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
            TextBox_Name.Text = DataGridView_List.SelectedRows(0).Cells(1).Value.ToString
        End If
    End Sub
End Class
