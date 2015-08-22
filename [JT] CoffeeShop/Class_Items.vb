Public Class Class_Items
    Private _MaMon, _TenMon, _MaNhom, _DonVi As String
    Private _DonGia As Long

    Private _DanhSach As DataTable

    Public Sub New()
        Me.MaMon = ""
        Me.MaNhom = ""
        Me.TenMon = ""
        Me.DonGia = 0
        Me.DonVi = ""
    End Sub

    ' FUNCTIONS

    Public Function TimThongTin(iMaMon As String)
        Dim DB = New Class_DB("SELECT MaMon, MaNhom, TenMon, DonGia, DonVi FROM Mon WHERE MaMon='" & iMaMon & "'")
        If DB.ChayLenh() Then
            Dim DS = DB.KetQua
            If DS.Rows.Count = 1 Then
                Me.MaMon = DS.Rows(0).Item("MaMon")
                Me.MaNhom = DS.Rows(0).Item("MaNhom")
                Me.TenMon = DS.Rows(0).Item("TenMon")
                Me.DonGia = DS.Rows(0).Item("DonGia")
                Me.DonVi = DS.Rows(0).Item("DonVi")

                Return 1
                Exit Function
            End If
        End If

        Me.MaMon = ""
        Me.MaNhom = ""
        Me.TenMon = ""
        Me.DonGia = 0
        Me.DonVi = ""

        Return 0
    End Function

    Public Function Them() As Boolean
        If Me.TenMon.Length > 0 And Me.MaNhom.Length > 0 And Me.DonGia > 0 And Me.DonVi.Length > 0 Then
            Dim DB = New Class_DB()
            Dim DS = New DataTable()

            DB.CauLenh = "SELECT MaNhom FROM NhomMon WHERE MaNhom='" & Me.MaNhom & "'"
            If DB.ChayLenh() Then
                DS = DB.KetQua
                If DS.Rows.Count <= 0 Then
                    Return 0
                End If
            End If

            If Me.MaMon.Length <= 0 Then

                DB.CauLenh = "SELECT LAST(MaMon) FROM Mon"
                If DB.ChayLenh() Then
                    If DB.KetQua.Rows(0).Item(0).ToString.Length > 0 Then
                        Me.MaMon = "M" & CInt(DB.KetQua.Rows(0).Item(0).SubString(1)) + 1
                    Else
                        Me.MaMon = "M1"
                    End If
                Else
                    Return 0
                End If

                DB.CauLenh = "INSERT INTO Mon VALUES ('" & Me.MaMon & "', '" & Me.MaNhom & "', '" & Me.TenMon & "', " & Me.DonGia & ", '" & Me.DonVi & "')"
            Else
                DB.CauLenh = "UPDATE Mon SET MaNhom='" & Me.MaNhom & "', TenMon='" & Me.TenMon & "', DonGia=" & Me.DonGia & ", DonVi='" & Me.DonVi & "' WHERE MaMon='" & Me.MaMon & "'"
            End If

            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    Public Function Xoa() As Boolean
        If Me.MaMon.Length > 0 Then
            Dim DB = New Class_DB()

            DB.CauLenh = "DELETE FROM Mon WHERE MaMon='" & Me.MaMon & "'"
            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    ' PROPERTIES

    Public Property MaMon() As String
        Set(ByVal value As String)
            _MaMon = value
        End Set
        Get
            Return _MaMon
        End Get
    End Property

    Public Property TenMon() As String
        Set(ByVal value As String)
            _TenMon = value
        End Set
        Get
            Return _TenMon
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

    Public Property DonVi() As String
        Set(ByVal value As String)
            _DonVi = value
        End Set
        Get
            Return _DonVi
        End Get
    End Property

    Public Property DonGia() As Long
        Set(ByVal value As Long)
            _DonGia = value
        End Set
        Get
            Return _DonGia
        End Get
    End Property

    ' EXTRA PROPERTIES

    Public ReadOnly Property DanhSach() As DataTable
        Get
            Dim DB = New Class_DB("SELECT MaMon, MaNhom, TenMon, DonGia, DonVi FROM Mon")
            _DanhSach = New DataTable()

            If DB.ChayLenh() Then
                _DanhSach = DB.KetQua
            End If

            Return _DanhSach
        End Get
    End Property
End Class
