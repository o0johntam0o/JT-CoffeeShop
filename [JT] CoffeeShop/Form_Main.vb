Public Class Form_Main
    Public tmp_UCMain, tmp_UCManage
    Public LoggedIn = False

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tmp_UCLogin As New UC_Login
        tmp_UCLogin.Visible = True
        Me.Controls.Add(tmp_UCLogin)
    End Sub

    ' MENU EVENTS

    Private Sub ManagerGTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyNhomBanToolStripMenuItem.Click
        If Not LoggedIn Then Exit Sub

        tmp_UCMain.Visible = False

        Try
            tmp_UCManage.Dispose()
        Catch ex As Exception

        End Try

        tmp_UCManage = New UC_ManagerGTables
        tmp_UCManage.Location = New Point(0, 25)
        tmp_UCManage.Width = Me.Width - 10
        tmp_UCManage.Height = Me.Height - 50
        tmp_UCManage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right

        Me.Controls.Add(tmp_UCManage)
    End Sub

    Private Sub ManagerTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyBanToolStripMenuItem.Click
        If Not LoggedIn Then Exit Sub

        tmp_UCMain.Visible = False

        Try
            tmp_UCManage.Dispose()
        Catch ex As Exception

        End Try

        tmp_UCManage = New UC_ManagerTables
        tmp_UCManage.Location = New Point(0, 25)
        tmp_UCManage.Width = Me.Width - 10
        tmp_UCManage.Height = Me.Height - 50
        tmp_UCManage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right

        Me.Controls.Add(tmp_UCManage)
    End Sub

    Private Sub ManagerGItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyNhomMonToolStripMenuItem.Click
        If Not LoggedIn Then Exit Sub

        tmp_UCMain.Visible = False

        Try
            tmp_UCManage.Dispose()
        Catch ex As Exception

        End Try

        tmp_UCManage = New UC_ManagerGItems
        tmp_UCManage.Location = New Point(0, 25)
        tmp_UCManage.Width = Me.Width - 10
        tmp_UCManage.Height = Me.Height - 50
        tmp_UCManage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right

        Me.Controls.Add(tmp_UCManage)
    End Sub

    Private Sub ManagerItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyMonToolStripMenuItem.Click
        If Not LoggedIn Then Exit Sub

        tmp_UCMain.Visible = False

        Try
            tmp_UCManage.Dispose()
        Catch ex As Exception

        End Try

        tmp_UCManage = New UC_ManagerItems
        tmp_UCManage.Location = New Point(0, 25)
        tmp_UCManage.Width = Me.Width - 10
        tmp_UCManage.Height = Me.Height - 50
        tmp_UCManage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right

        Me.Controls.Add(tmp_UCManage)
    End Sub

    Private Sub ManagerWaitersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyNhanVienToolStripMenuItem.Click
        If Not LoggedIn Then Exit Sub

        tmp_UCMain.Visible = False

        Try
            tmp_UCManage.Dispose()
        Catch ex As Exception

        End Try

        tmp_UCManage = New UC_ManagerWaiters
        tmp_UCManage.Location = New Point(0, 25)
        tmp_UCManage.Width = Me.Width - 10
        tmp_UCManage.Height = Me.Height - 50
        tmp_UCManage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right

        Me.Controls.Add(tmp_UCManage)
    End Sub

    Private Sub ManagerBillsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuanLyHoaDonToolStripMenuItem.Click
        If Not LoggedIn Then Exit Sub

        tmp_UCMain.Visible = False

        Try
            tmp_UCManage.Dispose()
        Catch ex As Exception

        End Try

        tmp_UCManage = New UC_ManagerBills
        tmp_UCManage.Location = New Point(0, 25)
        tmp_UCManage.Width = Me.Width - 10
        tmp_UCManage.Height = Me.Height - 50
        tmp_UCManage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right

        Me.Controls.Add(tmp_UCManage)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DangXuatToolStripMenuItem.Click
        If Not LoggedIn Then Exit Sub

        If MsgBox("Bạn có thật sự muốn đăng xuất?", MsgBoxStyle.YesNo, "Đăng xuất") = MsgBoxResult.Yes Then
            LoggedIn = False

            Me.Controls.Remove(tmp_UCMain)
            Me.Controls.Remove(tmp_UCManage)

            Dim tmp_UCLogin = New UC_Login
            Me.Controls.Add(tmp_UCLogin)
        End If
    End Sub

    Private Sub SoftwareInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThongTinPhanMemToolStripMenuItem.Click
        Dim strAuthor = "[JT] CoffeeShop" & vbCrLf & vbCrLf & _
            "TÁC GIẢ:" & vbCrLf & _
            "+ Huỳnh Bửu Tâm" & vbCrLf & vbCrLf & _
            "PHIÊN BẢN:" & vbCrLf & _
            "+ Phiên bản: 1.0.0 Alpha" & vbCrLf & _
            "+ Ngày phát hành: 01/08/2014"
        MsgBox(strAuthor, MsgBoxStyle.Information, "Thông tin phần mềm")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CachSuDungToolStripMenuItem.Click
        Dim strManual = "SỬ DỤNG:" & vbCrLf & _
            "- Bắt đầu một hóa đơn mới:" & vbCrLf & _
            "+ Nháy 1 bàn bất kỳ (biểu tượng không màu) trong danh sách bàn" & vbCrLf & _
            "+ Chọn các món mà khách gọi" & vbCrLf & _
            "+ Nháy nút 'Thêm món' và nhập số lượng" & vbCrLf & _
            "+ Để xóa món đã gọi, chọn các món cần xóa và nháy nút 'Xóa món'" & vbCrLf & _
            "- Tính tiền:" & vbCrLf & _
            "+ Nháy 1 bàn bất kỳ (biểu tượng có màu) trong danh sách bàn" & vbCrLf & _
            "+ Nháy nút 'In hóa đơn' để xuất hóa đơn (nếu cần thiết)" & vbCrLf & _
            "+ Nháy nút 'Tính tiền'" & vbCrLf & vbCrLf & _
            "QUẢN LÝ:" & vbCrLf & _
            "+ Quản lý nhóm bàn" & vbCrLf & _
            "+ Quản lý bàn" & vbCrLf & _
            "+ Quản lý nhóm món" & vbCrLf & _
            "+ Quản lý món" & vbCrLf & _
            "+ Quản lý nhân viên" & vbCrLf & _
            "+ Quản lý hóa đơn"
        MsgBox(strManual, MsgBoxStyle.Information, "Hướng dẫn sử dụng")
    End Sub

    ' CLOSING EVENT

    Private Sub Form_Main_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Bạn có thật sự muốn đóng hoàn toàn chương trình?", MsgBoxStyle.YesNo, "Thoát") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class