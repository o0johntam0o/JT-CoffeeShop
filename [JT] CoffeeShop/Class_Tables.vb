Public Class Class_Tables
    Private _MaBan, _MaNhom, _TenBan As String

    Private _MaPhieu, _MaNV As String
    Private _HoaDon, _DanhSach As DataTable

    Public Sub New()
        Me.MaBan = ""
        Me.MaNhom = ""
        Me.TenBan = ""
    End Sub

    ' FUNCTIONS

    Public Function TimThongTin(iMaBan As String)
        Dim DB = New Class_DB()
        Dim DS = New DataTable()

        DB.CauLenh = "SELECT MaBan, MaNhom, TenBan FROM Ban WHERE MaBan='" & iMaBan & "'"
        If DB.ChayLenh() Then
            DS = DB.KetQua
            If DS.Rows.Count = 1 Then
                Me.MaBan = DS.Rows(0).Item("MaBan")
                Me.MaNhom = DS.Rows(0).Item("MaNhom")
                Me.TenBan = DS.Rows(0).Item("TenBan")

                Return 1
                Exit Function
            End If
        End If

        Me.MaBan = ""
        Me.MaNhom = ""
        Me.TenBan = ""

        Return 0
    End Function

    Public Function Them() As Boolean
        If Me.TenBan.Length > 0 And Me.MaNhom.Length > 0 Then
            Dim DB = New Class_DB()
            Dim DS = New DataTable()

            DB.CauLenh = "SELECT MaNhom FROM NhomBan WHERE MaNhom='" & Me.MaNhom & "'"
            If DB.ChayLenh() Then
                DS = DB.KetQua
                If DS.Rows.Count <= 0 Then
                    Return 0
                End If
            End If

            If Me.MaBan.Length <= 0 Then

                DB.CauLenh = "SELECT LAST(MaBan) FROM Ban"
                If DB.ChayLenh() Then
                    If DB.KetQua.Rows(0).Item(0).ToString.Length > 0 Then
                        Me.MaBan = "B" & CInt(DB.KetQua.Rows(0).Item(0).SubString(1)) + 1
                    Else
                        Me.MaBan = "B1"
                    End If
                Else
                    Return 0
                End If

                DB.CauLenh = "INSERT INTO Ban(MaBan, MaNhom, TenBan) VALUES ('" & Me.MaBan & "', '" & Me.MaNhom & "', '" & Me.TenBan & "')"
            Else
                DB.CauLenh = "UPDATE Ban SET MaNhom='" & Me.MaNhom & "', TenBan='" & Me.TenBan & "' WHERE MaBan='" & Me.MaBan & "'"
            End If

            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    Public Function Xoa() As Boolean
        If Me.MaBan.Length > 0 Then
            Dim DB = New Class_DB()

            DB.CauLenh = "DELETE FROM Ban WHERE MaBan='" & Me.MaBan & "'"
            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    Public Function TinhTien() As Boolean
        If Me.MaBan.Length > 0 And Me.MaPhieu.Length > 0 Then
            Dim DB = New Class_DB()
            DB.CauLenh = "UPDATE Phieu SET TinhTien=True WHERE MaPhieu='" & Me.MaPhieu & "' AND MaBan='" & Me.MaBan & "'"

            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    ' PROPERTIES

    Public Property TenBan() As String
        Set(ByVal value As String)
            _TenBan = value
        End Set
        Get
            Return _TenBan
        End Get
    End Property

    Public Property MaBan() As String
        Set(ByVal value As String)
            _MaBan = value
        End Set
        Get
            Return _MaBan
        End Get
    End Property

    Public Property MaNhom() As String
        Set(ByVal value As String)
            _MaNhom = value
        End Set
        Get
            Return _MaNhom
        End Get
    End Property

    ' EXTRA PROPERTIES

    Public ReadOnly Property DanhSach() As DataTable
        Get
            Dim DB = New Class_DB("SELECT MaBan, MaNhom, TenBan FROM Ban")
            _DanhSach = New DataTable()

            If DB.ChayLenh() Then
                _DanhSach = DB.KetQua
            End If

            Return _DanhSach
        End Get
    End Property

    Public ReadOnly Property MaPhieu() As String
        Get
            If Me.MaBan <> "" Then
                Dim DB = New Class_DB()
                Dim DS = New DataTable()

                DB.CauLenh = "SELECT MaPhieu FROM Phieu WHERE MaBan='" & Me.MaBan & "' AND TinhTien=False"
                If DB.ChayLenh() Then
                    DS = DB.KetQua
                    If DS.Rows.Count = 1 Then
                        Return DS.Rows(0).Item("MaPhieu")
                    End If
                End If
            End If

            Return ""
        End Get
    End Property

    Public ReadOnly Property MaNV() As String
        Get
            If Me.MaNhom <> "" Then
                Dim DB = New Class_DB()
                Dim DS = New DataTable()

                DB.CauLenh = "SELECT MaNV FROM NhanVien WHERE MaNhom='" & Me.MaNhom & "'"
                If DB.ChayLenh() Then
                    DS = DB.KetQua
                    If DS.Rows.Count = 1 Then
                        Return DS.Rows(0).Item("MaNV")
                    End If
                End If
            End If

            Return ""
        End Get
    End Property

    Public ReadOnly Property HoaDon() As DataTable
        Get
            _HoaDon = New DataTable()
            _HoaDon.Columns.Add("MaMon")
            _HoaDon.Columns.Add("TenMon")
            _HoaDon.Columns.Add("SoLuong")
            _HoaDon.Columns.Add("DonGia")
            _HoaDon.Columns.Add("DonVi")

            If Me.MaPhieu <> "" Then
                Dim DB = New Class_DB()

                DB.CauLenh = "SELECT MaMon, SoLuong FROM HoaDon WHERE MaPhieu='" & Me.MaPhieu & "'"
                If DB.ChayLenh() Then
                    Dim DS = DB.KetQua
                    If DS.Rows.Count > 0 Then

                        For i As Integer = 0 To DS.Rows.Count - 1 Step 1

                            DB.CauLenh = "SELECT TenMon, DonGia, DonVi FROM Mon WHERE MaMon='" & DS.Rows(i).Item("MaMon") & "'"
                            If DB.ChayLenh() Then
                                Dim DS2 = DB.KetQua
                                If DS2.Rows.Count > 0 Then

                                    If DS2.Rows(0).Item("TenMon") <> "" Then
                                        _HoaDon.Rows.Add(DS.Rows(i).Item("MaMon"), DS2.Rows(0).Item("TenMon"), DS.Rows(i).Item("SoLuong"), DS2.Rows(0).Item("DonGia"), DS2.Rows(0).Item("DonVi"))
                                    End If

                                End If
                            End If

                        Next

                    End If
                End If

            End If

            Return _HoaDon
        End Get
    End Property
End Class
