Public Class Class_Waiters
    Private _MaNV, _MaNhom, _HoTen, _DiaChi, _CaTruc As String
    Private _NgaySinh, _NgayTuyen As DateTime
    Private _GioiTinh As Boolean
    Private _DienThoai, _Luong As Long

    Private _DanhSach As DataTable

    Public Sub New()
        Me.MaNV = ""
        Me.MaNhom = ""
        Me.HoTen = ""
        Me.GioiTinh = True
        Me.NgaySinh = DateTime.Now.Date
        Me.DiaChi = ""
        Me.DienThoai = 0
        Me.NgayTuyen = DateTime.Now.Date
        Me.Luong = 0
        Me.CaTruc = ""
    End Sub

    ' FUNCTIONS

    Public Function TimThongTin(iMaNV As String)
        Dim DB = New Class_DB("SELECT MaNV, MaNhom, HoTen, GioiTinh, NgaySinh, DiaChi, DienThoai, NgayTuyen, Luong, CaTruc FROM NhanVien WHERE MaNV='" & iMaNV & "'")
        If DB.ChayLenh() Then
            Dim DS = DB.KetQua
            If DS.Rows.Count = 1 Then
                Me.MaNV = DS.Rows(0).Item("MaNV")
                Me.MaNV = DS.Rows(0).Item("MaNhom")
                Me.HoTen = DS.Rows(0).Item("HoTen")
                Me.GioiTinh = DS.Rows(0).Item("GioiTinh")
                Me.NgaySinh = DS.Rows(0).Item("NgaySinh")
                Me.DiaChi = DS.Rows(0).Item("DiaChi")
                Me.DienThoai = DS.Rows(0).Item("DienThoai")
                Me.NgayTuyen = DS.Rows(0).Item("NgayTuyen")
                Me.Luong = DS.Rows(0).Item("Luong")
                Me.CaTruc = DS.Rows(0).Item("CaTruc")

                Return 1
                Exit Function
            End If
        End If

        Me.MaNV = ""
        Me.MaNhom = ""
        Me.HoTen = ""
        Me.GioiTinh = True
        Me.NgaySinh = DateTime.Now.Date
        Me.DiaChi = ""
        Me.DienThoai = 0
        Me.NgayTuyen = DateTime.Now.Date
        Me.Luong = 0
        Me.CaTruc = ""

        Return 0
    End Function

    Public Function Them() As Boolean
        If Me.HoTen.Length > 0 Then
            Dim DB = New Class_DB()
            Dim DS = New DataTable()

            DB.CauLenh = "SELECT MaNhom FROM NhomBan WHERE MaNhom='" & Me.MaNhom & "'"
            If DB.ChayLenh() Then
                DS = DB.KetQua
                If DS.Rows.Count <= 0 Then
                    Return 0
                End If
            End If

            If Me.MaNV.Length <= 0 Then

                DB.CauLenh = "SELECT LAST(MaNV) FROM NhanVien"
                If DB.ChayLenh() Then
                    If DB.KetQua.Rows(0).Item(0).ToString.Length > 0 Then
                        Me.MaNV = "NV" & CInt(DB.KetQua.Rows(0).Item(0).SubString(2)) + 1
                    Else
                        Me.MaNV = "NV1"
                    End If
                Else
                    Return 0
                End If

                DB.CauLenh = "INSERT INTO NhanVien VALUES ('" & Me.MaNV & "', '" & Me.MaNhom & "', '" & Me.HoTen & "', " & Me.GioiTinh & ", '" & Me.NgaySinh & "', '" & Me.DiaChi & "', " & Me.DienThoai & ", '" & Me.NgayTuyen & "', " & Me.Luong & ", '" & Me.CaTruc & "')"
            Else
                DB.CauLenh = "UPDATE NhanVien SET MaNhom='" & Me.MaNhom & "', HoTen='" & Me.HoTen & "', GioiTinh=" & Me.GioiTinh & ", NgaySinh='" & Me.NgaySinh & "', DiaChi='" & Me.DiaChi & "', DienThoai=" & Me.DienThoai & ", NgayTuyen='" & Me.NgayTuyen & "', Luong=" & Me.Luong & ", CaTruc='" & Me.CaTruc & "' WHERE MaNV='" & Me.MaNV & "'"
            End If

            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    Public Function Xoa() As Boolean
        If Me.MaNV.Length > 0 Then
            Dim DB = New Class_DB("DELETE FROM NhanVien WHERE MaNV='" & Me.MaNV & "'")
            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    ' PROPERTIES

    Public Property MaNV() As String
        Set(ByVal value As String)
            _MaNV = value
        End Set
        Get
            Return _MaNV
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

    Public Property HoTen() As String
        Set(ByVal value As String)
            _HoTen = value
        End Set
        Get
            Return _HoTen
        End Get
    End Property

    Public Property DiaChi() As String
        Set(ByVal value As String)
            _DiaChi = value
        End Set
        Get
            Return _DiaChi
        End Get
    End Property

    Public Property DienThoai() As Long
        Set(ByVal value As Long)
            _DienThoai = value
        End Set
        Get
            Return _DienThoai
        End Get
    End Property

    Public Property NgayTuyen() As DateTime
        Set(ByVal value As DateTime)
            _NgayTuyen = value
        End Set
        Get
            Return _NgayTuyen
        End Get
    End Property

    Public Property Luong() As Long
        Set(ByVal value As Long)
            _Luong = value
        End Set
        Get
            Return _Luong
        End Get
    End Property

    Public Property GioiTinh() As Boolean
        Set(ByVal value As Boolean)
            _GioiTinh = value
        End Set
        Get
            Return _GioiTinh
        End Get
    End Property

    Public Property NgaySinh() As DateTime
        Set(ByVal value As DateTime)
            _NgaySinh = value
        End Set
        Get
            Return _NgaySinh
        End Get
    End Property

    Public Property CaTruc() As String
        Set(ByVal value As String)
            _CaTruc = value
        End Set
        Get
            Return _CaTruc
        End Get
    End Property

    ' EXTRA PROPERTIES

    Public ReadOnly Property DanhSach() As DataTable
        Get
            Dim DB = New Class_DB("SELECT MaNV, MaNhom, HoTen, DiaChi, DienThoai, NgayTuyen, Luong, GioiTinh, NgaySinh, CaTruc FROM NhanVien")
            _DanhSach = New DataTable()

            If DB.ChayLenh() Then
                _DanhSach = DB.KetQua
            End If

            Return _DanhSach
        End Get
    End Property
End Class
