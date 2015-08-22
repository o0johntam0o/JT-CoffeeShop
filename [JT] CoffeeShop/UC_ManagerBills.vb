Public Class UC_ManagerBills

    Private Sub UC_ManagerBills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox_Expression.Items.Count > 0 Then ComboBox_Expression.SelectedIndex = 0
        LoadList()
    End Sub

    ' SUBS

    Private Sub LoadList()
        Me.Enabled = 0

        Dim tmp_ClassPhieu = New Class_Tickets()
        Dim DS = tmp_ClassPhieu.DanhSach
        If DS.Columns.Count > 0 Then DS.Columns.Remove("TinhTien")
        DataGridView_List.DataSource = DS

        Me.Enabled = 1
    End Sub

    ' BUTTON EVENTS

    Private Sub Button_Find_Click(sender As Object, e As EventArgs) Handles Button_Find.Click
        Me.Enabled = 0

        Dim dk(2) As String
        dk(0) = "MaPhieu"
        dk(1) = "MaBan"
        dk(2) = "NgayTao"
        Dim tmp_ClassPhieu = New Class_Tickets()
        Dim DS = tmp_ClassPhieu.TimKiem(dk(ComboBox_Expression.SelectedIndex), TextBox_Expression.Text)
        If DS.Columns.Count > 0 Then DS.Columns.Remove("TinhTien")
        DataGridView_List.DataSource = DS

        Me.Enabled = 1
    End Sub

    Private Sub Button_View_Click(sender As Object, e As EventArgs) Handles Button_View.Click
        If DataGridView_List.SelectedRows.Count <> 1 Then
            MsgBox("Vui lòng chọn một phiếu cần xem!")
            Exit Sub
        End If

        Dim tmp_ClassBan = New Class_Tables()
        Dim strMsg As String = ""
        Dim TongCong As Long

        tmp_ClassBan.TimThongTin(DataGridView_List.SelectedRows(0).Cells("MaBan").Value.ToString)

        strMsg &= "======================================" & vbCrLf
        strMsg &= "Mã phiếu: " & DataGridView_List.SelectedRows(0).Cells("MaPhieu").Value.ToString & vbCrLf
        strMsg &= "Ngày tạo phiếu: " & DataGridView_List.SelectedRows(0).Cells("NgayTao").Value.ToString & vbCrLf
        strMsg &= "Tên bàn: " & tmp_ClassBan.TenBan & " (" & DataGridView_List.SelectedRows(0).Cells("MaBan").Value.ToString & ")" & vbCrLf
        strMsg &= "Mã nhân viên: " & tmp_ClassBan.MaNV & vbCrLf
        strMsg &= "--------------------------------------" & vbCrLf
        strMsg &= "Các món đã gọi: " & vbCrLf

        Dim tmp_ClassHoaDon = New Class_Bills()
        tmp_ClassHoaDon.TimThongTin(DataGridView_List.SelectedRows(0).Cells("MaPhieu").Value.ToString)
        For i As Integer = 0 To tmp_ClassHoaDon.MaPhieu.Length - 1 Step 1
            Dim tmp_ClassMon = New Class_Items()
            tmp_ClassMon.TimThongTin(tmp_ClassHoaDon.MaMon(i))

            If tmp_ClassMon.TenMon.Length > 0 Then strMsg &= " - " & tmp_ClassMon.TenMon & ": " & tmp_ClassHoaDon.SoLuong(i) & " x " & tmp_ClassMon.DonGia & " (" & tmp_ClassMon.DonVi & ")" & vbCrLf
            TongCong += tmp_ClassMon.DonGia * tmp_ClassHoaDon.SoLuong(i)
        Next

        strMsg &= "--------------------------------------" & vbCrLf
        strMsg &= "Tổng cộng: " & TongCong

        MsgBox(strMsg, MsgBoxStyle.Information, "Xem hóa đơn")
    End Sub

    Private Sub Button_Print_Click(sender As Object, e As EventArgs) Handles Button_Print.Click
        If DataGridView_List.SelectedRows.Count <> 1 Then
            MsgBox("Vui lòng chọn một phiếu cần in!")
            Exit Sub
        End If

        If MsgBox("Bạn có thật sự muốn in hóa đơn?", MsgBoxStyle.YesNo, "In hóa đơn") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim tmp_ClassBan = New Class_Tables()
        Dim objWriter As New System.IO.StreamWriter("C:\JT CoffeeShop.txt")
        Dim TongCong As Long

        tmp_ClassBan.TimThongTin(DataGridView_List.SelectedRows(0).Cells("MaBan").Value.ToString)

        objWriter.WriteLine("======================================")
        objWriter.WriteLine("Mã phiếu: " & DataGridView_List.SelectedRows(0).Cells("MaPhieu").Value.ToString)
        objWriter.WriteLine("Ngày tạo phiếu: " & DataGridView_List.SelectedRows(0).Cells("NgayTao").Value.ToString)
        objWriter.WriteLine("Tên bàn: " & tmp_ClassBan.TenBan & " (" & DataGridView_List.SelectedRows(0).Cells("MaBan").Value.ToString & ")")
        objWriter.WriteLine("Mã nhân viên: " & tmp_ClassBan.MaNV)
        objWriter.WriteLine("--------------------------------------")
        objWriter.WriteLine("Các món đã gọi: ")

        Dim tmp_ClassHoaDon = New Class_Bills()
        tmp_ClassHoaDon.TimThongTin(DataGridView_List.SelectedRows(0).Cells("MaPhieu").Value.ToString)
        For i As Integer = 0 To tmp_ClassHoaDon.MaPhieu.Length - 1 Step 1
            Dim tmp_ClassMon = New Class_Items()
            tmp_ClassMon.TimThongTin(tmp_ClassHoaDon.MaMon(i))

            If tmp_ClassMon.TenMon.Length > 0 Then objWriter.WriteLine(" - " & tmp_ClassMon.TenMon & ": " & tmp_ClassHoaDon.SoLuong(i) & " x " & tmp_ClassMon.DonGia & " (" & tmp_ClassMon.DonVi & ")")
            TongCong += tmp_ClassMon.DonGia * tmp_ClassHoaDon.SoLuong(i)
        Next

        objWriter.WriteLine("--------------------------------------")
        objWriter.WriteLine("Tổng cộng: " & TongCong)
        objWriter.Close()

        ' Print
        Dim printProcess As New Diagnostics.ProcessStartInfo()
        printProcess.FileName = "C:\JT CoffeeShop.txt"
        printProcess.Verb = "print"
        Process.Start(printProcess)
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        If DataGridView_List.SelectedRows.Count > 0 Then
            If MsgBox("Bạn có thật sự muốn xóa những phiếu đã chọn?", MsgBoxStyle.YesNo, "Xóa phiếu") = MsgBoxResult.No Then
                Exit Sub
            End If

            For i As Integer = 0 To DataGridView_List.SelectedRows.Count - 1 Step 1
                Dim tmp_ClassPhieu = New Class_Tickets()
                tmp_ClassPhieu.MaPhieu = DataGridView_List.SelectedRows(i).Cells("MaPhieu").Value.ToString

                If Not tmp_ClassPhieu.Xoa() Then
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Xóa phiếu thất bại!", MsgBoxStyle.Critical, "Error XP01")
                    Exit Sub
                End If
            Next

            MsgBox("Xóa phiếu thành công!")
            LoadList()
        Else
            MsgBox("Vui lòng chọn phiếu cần xóa!")
        End If
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Form_Main.tmp_UCMain.Visible = True
        Me.Dispose()
    End Sub

    ' COMBOBOX EVENTS

    Private Sub ComboBox_Expression_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles ComboBox_Expression.KeyPress
        e.Handled = True
    End Sub
End Class
