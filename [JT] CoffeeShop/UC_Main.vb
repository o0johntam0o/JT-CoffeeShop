Public Class UC_Main
    Private DB = New Class_DB()
    Private Resource_ImageList = New ImageList()

    Private Sub UC_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 25)
        Me.Width = Me.ParentForm.Width - 10
        Me.Height = Me.ParentForm.Height - 50
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right

        Resource_ImageList.Images.Add(My.Resources.ResourceManager.GetObject("Chair"))
        Resource_ImageList.Images.Add(My.Resources.ResourceManager.GetObject("Cup_BW"))
        Resource_ImageList.Images.Add(My.Resources.ResourceManager.GetObject("Cup"))

        Call LoadTablesList()
        Call LoadItemsList()
    End Sub

    ' SUBS

    Public Sub LoadItemsList()
        Me.Enabled = 0

        Dim tmp_ClassMon = New Class_Items()
        Dim DS = tmp_ClassMon.DanhSach
        If DS.Columns.Count > 0 Then DS.Columns.Remove("MaNhom")
        DataGridView_ItemsList.DataSource = DS

        Me.Enabled = 1
    End Sub

    Public Sub LoadTablesList()
        Me.Enabled = 0

        Dim parentTable, childTable As DataTable
        Dim parentRow, childRow As DataRow
        Dim parentNode, childNode As TreeNode

        TreeView_TablesList.ImageList = Resource_ImageList

        DB.CauLenh = "SELECT MaNhom, TenNhom FROM NhomBan"
        If DB.ChayLenh() Then
            Dim DS = DB.KetQua
            parentTable = DS

            TreeView_TablesList.Nodes.Clear()
            TreeView_TablesList.ForeColor = Color.Black
            TreeView_TablesList.Font = New Font(TreeView_TablesList.Font, FontStyle.Bold)

            For Each parentRow In parentTable.Rows
                parentNode = New TreeNode(parentRow.Item("TenNhom"))
                parentNode.Name = parentRow.Item("MaNhom")
                parentNode.ImageIndex = 0
                parentNode.SelectedImageIndex = 0
                parentNode.ForeColor = Color.Green
                TreeView_TablesList.Nodes.Add(parentNode)

                DB.CauLenh = "SELECT MaBan, TenBan FROM Ban WHERE MaNhom='" & parentRow.Item("MaNhom") & "'"
                If DB.ChayLenh() Then
                    DS = DB.KetQua
                    childTable = DS
                    For Each childRow In childTable.Rows
                        childNode = New TreeNode(childRow.Item("TenBan"))
                        childNode.Name = childRow.Item("MaBan")
                        childNode.ImageIndex = 1
                        childNode.SelectedImageIndex = 1
                        DB.CauLenh = "SELECT MaBan FROM Phieu WHERE MaBan='" & childRow.Item("MaBan") & "' AND TinhTien=False"
                        If DB.ChayLenh() Then
                            DS = DB.KetQua
                            If DS.Rows.Count = 1 Then
                                childNode.ImageIndex = 2
                                childNode.SelectedImageIndex = 2
                                childNode.ForeColor = Color.Red
                            Else
                                childNode.ForeColor = Color.Black
                                childNode.NodeFont = New Font(TreeView_TablesList.Font, FontStyle.Regular)
                            End If
                            parentNode.Nodes.Add(childNode)
                        Else
                            MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Tải danh sách thực đơn thất bại!", MsgBoxStyle.Critical, "Error DSB03")
                        End If
                    Next
                Else
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Tải danh sách thực đơn thất bại!", MsgBoxStyle.Critical, "Error DSB02")
                End If
            Next

            If TreeView_TablesList.Nodes.Count > 0 Then
                TreeView_TablesList.ExpandAll()
                TreeView_TablesList.SelectedNode = TreeView_TablesList.Nodes(0)
            End If
        Else
            MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Tải danh sách thực đơn thất bại!", MsgBoxStyle.Critical, "Error DSB01")
        End If

        Me.Enabled = 1
    End Sub

    Public Sub LoadTableInfo()
        Me.Enabled = 0

        Dim tmp_GiaTienHienTai As Long = 0
        Dim tmp_ClassBan = New Class_Tables()
        If TreeView_TablesList.Nodes.Count > 0 Then tmp_ClassBan.TimThongTin(TreeView_TablesList.SelectedNode.Name)

        DataGridView_TableInfo.DataSource = tmp_ClassBan.HoaDon

        For Each el As DataRow In tmp_ClassBan.HoaDon.Rows
            tmp_GiaTienHienTai += el("DonGia") * el("SoLuong")
        Next

        Label_CurrentPrice.Text = tmp_GiaTienHienTai.ToString("C0", System.Globalization.CultureInfo.CreateSpecificCulture("vi-VN"))
        If TreeView_TablesList.Nodes.Count > 0 Then Label_CurrentTable.Text = TreeView_TablesList.SelectedNode.Text

        Me.Enabled = 1
    End Sub

    ' TREEVIEW EVENTS

    Private Sub TreeView_TablesList_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_TablesList.AfterSelect
        LoadTableInfo()
    End Sub

    ' BUTTON EVENTS

    Private Sub Button_AddItem_Click(sender As Object, e As EventArgs) Handles Button_AddItem.Click
        If DataGridView_ItemsList.SelectedRows.Count <= 0 Then
            MsgBox("Bạn chưa chọn món cần thêm!")
            Exit Sub
        End If

        If TreeView_TablesList.SelectedNode.Level <> 1 Then
            MsgBox("Bạn chưa chọn bàn!")
            Exit Sub
        End If

        Dim tmp_SoLuong
        Dim tmp_ClassPhieu = New Class_Tickets()
        tmp_ClassPhieu.MaBan = TreeView_TablesList.SelectedNode.Name

        If Not tmp_ClassPhieu.Them() Then
            MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Thêm phiếu thất bại!", MsgBoxStyle.Critical, "Error TP01")
            Exit Sub
        End If

        For i As Integer = 0 To DataGridView_ItemsList.SelectedRows.Count - 1 Step 1
            ' THEM CHI TIET PHIEU
            tmp_SoLuong = InputBox("Vui lòng nhập số lượng '" & DataGridView_ItemsList.SelectedRows(i).Cells("TenMon").Value.ToString() & "'!", "Số lượng", 1)

            If IsNumeric(tmp_SoLuong) Then
                Dim tmp_ClassHoaDon = New Class_Bills()
                tmp_ClassHoaDon.MaPhieu(0) = tmp_ClassPhieu.MaPhieu
                tmp_ClassHoaDon.MaMon(0) = DataGridView_ItemsList.SelectedRows(i).Cells("MaMon").Value.ToString()
                tmp_ClassHoaDon.SoLuong(0) = tmp_SoLuong

                If tmp_ClassHoaDon.Them() Then
                    TreeView_TablesList.SelectedNode.ImageIndex = 2
                    TreeView_TablesList.SelectedNode.SelectedImageIndex = 2
                    TreeView_TablesList.SelectedNode.ForeColor = Color.Red
                    TreeView_TablesList.SelectedNode.NodeFont = New Font(TreeView_TablesList.Font, FontStyle.Bold)
                    ' Tai lai chieu rong
                    TreeView_TablesList.SelectedNode.Text = TreeView_TablesList.SelectedNode.Text
                Else
                    MsgBox("Lỗi kết nối cơ sỡ dữ liệu. Thêm món thất bại!", MsgBoxStyle.Critical, "Error TM01")
                End If
            End If
        Next

        LoadTableInfo()

        If DataGridView_TableInfo.Rows.Count <= 0 Then
            tmp_ClassPhieu.Xoa()
            LoadTablesList()
        End If

        DataGridView_ItemsList.Focus()
    End Sub

    Private Sub Button_DeleteItem_Click(sender As Object, e As EventArgs) Handles Button_DeleteItem.Click
        If DataGridView_TableInfo.Rows.Count <= 0 Then
            Exit Sub
        End If

        If DataGridView_TableInfo.SelectedRows.Count <= 0 Then
            MsgBox("Bạn chưa chọn món cần xóa!")
            Exit Sub
        End If

        If MsgBox("Bạn có thật sự muốn xóa những món đã chọn?", MsgBoxStyle.YesNo, "Xóa món") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim tmp_ClassBan = New Class_Tables()
        tmp_ClassBan.TimThongTin(TreeView_TablesList.SelectedNode.Name)

        For i As Integer = 0 To DataGridView_TableInfo.SelectedRows.Count - 1 Step 1
            If DataGridView_TableInfo.SelectedRows(i).Cells("MaMon1").Value <> "" Then
                Dim tmp_ClassHoaDon = New Class_Bills()
                tmp_ClassHoaDon.MaPhieu(0) = tmp_ClassBan.MaPhieu
                tmp_ClassHoaDon.MaMon(0) = DataGridView_TableInfo.SelectedRows(i).Cells("MaMon1").Value.ToString()

                tmp_ClassHoaDon.Xoa()
            End If
        Next

        LoadTableInfo()

        If DataGridView_TableInfo.Rows.Count <= 0 Then
            Dim tmp_ClassPhieu = New Class_Tickets()
            tmp_ClassPhieu.MaPhieu = tmp_ClassBan.MaPhieu
            tmp_ClassPhieu.Xoa()
            LoadTablesList()
        End If

        DataGridView_TableInfo.Focus()
    End Sub

    Private Sub Button_PrintBill_Click(sender As Object, e As EventArgs) Handles Button_PrintBill.Click
        If TreeView_TablesList.SelectedNode.Level <> 1 Or TreeView_TablesList.SelectedNode.ForeColor = Color.Black Then
            MsgBox("Bạn chưa chọn bàn!")
            Exit Sub
        End If

        If MsgBox("Bạn có thật sự muốn in hóa đơn?", MsgBoxStyle.YesNo, "In hóa đơn") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim tmp_ClassBan = New Class_Tables()
        Dim objWriter As New System.IO.StreamWriter("C:\Coffee Shop.txt")
        Dim TongCong As Long

        tmp_ClassBan.TimThongTin(TreeView_TablesList.SelectedNode.Name)

        objWriter.WriteLine("======================================")
        objWriter.WriteLine("Mã phiếu: " & tmp_ClassBan.MaPhieu)
        objWriter.WriteLine("Ngày tạo phiếu: " & DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"))
        objWriter.WriteLine("Tên bàn: " & tmp_ClassBan.TenBan & " (" & tmp_ClassBan.MaBan & ")")
        objWriter.WriteLine("Mã nhân viên: " & tmp_ClassBan.MaNV)
        objWriter.WriteLine("--------------------------------------")
        objWriter.WriteLine("Các món đã gọi: ")

        For Each el As DataRow In tmp_ClassBan.HoaDon.Rows
            If el("TenMon").Length > 0 Then objWriter.WriteLine(" - " & el("TenMon") & ": " & el("SoLuong") & " x " & el("DonGia") & " (" & el("DonVi") & ")")
            TongCong += el("DonGia") * el("SoLuong")
        Next

        objWriter.WriteLine("--------------------------------------")
        objWriter.WriteLine("Tổng cộng: " & TongCong)
        objWriter.Close()

        ' Print
        Dim printProcess As New Diagnostics.ProcessStartInfo()
        printProcess.FileName = "C:\Coffee Shop.txt"
        printProcess.Verb = "print"
        Process.Start(printProcess)
    End Sub

    Private Sub Button_Calculate_Click(sender As Object, e As EventArgs) Handles Button_Calculate.Click
        If TreeView_TablesList.SelectedNode.Level <> 1 Or TreeView_TablesList.SelectedNode.ForeColor = Color.Black Then
            MsgBox("Bạn chưa chọn bàn!")
            Exit Sub
        End If

        If MsgBox("Bạn có thật sự muốn tính tiền?", MsgBoxStyle.YesNo, "Tính tiền") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim tmp_ClassBan = New Class_Tables()
        tmp_ClassBan.MaBan = TreeView_TablesList.SelectedNode.Name
        If tmp_ClassBan.TinhTien() Then
            TreeView_TablesList.SelectedNode.ImageIndex = 1
            TreeView_TablesList.SelectedNode.SelectedImageIndex = 1
            TreeView_TablesList.SelectedNode.ForeColor = Color.Black
            TreeView_TablesList.SelectedNode.NodeFont = New Font(TreeView_TablesList.Font, FontStyle.Regular)
            LoadTableInfo()
        End If
    End Sub
End Class
