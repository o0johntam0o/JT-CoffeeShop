Public Class Class_GTables
    Private _MaNhom, _TenNhom As String

    Private _DanhSach As DataTable

    Public Sub New()
        Me.MaNhom = ""
        Me.TenNhom = ""
    End Sub

    ' FUNCTIONS

    Public Function TimThongTin(iMaNhom As String)
        Dim DB = New Class_DB("SELECT MaNhom, TenNhom FROM NhomBan WHERE MaNhom='" & iMaNhom & "'")
        If DB.ChayLenh() Then
            Dim DS = DB.KetQua
            If DS.Rows.Count = 1 Then
                Me.MaNhom = DS.Rows(0).Item("MaNhom")
                Me.TenNhom = DS.Rows(0).Item("TenNhom")

                Return 1
                Exit Function
            End If
        End If

        Me.MaNhom = ""
        Me.TenNhom = ""

        Return 0
    End Function

    Public Function Them() As Boolean
        If Me.TenNhom.Length > 0 Then
            Dim DB = New Class_DB()

            If Me.MaNhom.Length <= 0 Then

                DB.CauLenh = "SELECT LAST(MaNhom) FROM NhomBan"
                If DB.ChayLenh() Then
                    If DB.KetQua.Rows(0).Item(0).ToString.Length > 0 Then
                        Me.MaNhom = "NB" & CInt(DB.KetQua.Rows(0).Item(0).SubString(2)) + 1
                    Else
                        Me.MaNhom = "NB1"
                    End If
                Else
                    Return 0
                End If

                DB.CauLenh = "INSERT INTO NhomBan(MaNhom, TenNhom) VALUES ('" & Me.MaNhom & "', '" & Me.TenNhom & "')"
            Else
                DB.CauLenh = "UPDATE NhomBan SET TenNhom='" & Me.TenNhom & "' WHERE MaNhom='" & Me.MaNhom & "'"
            End If

            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    Public Function Xoa() As Boolean
        If Me.MaNhom.Length > 0 Then
            Dim DB = New Class_DB("DELETE FROM NhomBan WHERE MaNhom='" & Me.MaNhom & "'")
            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    ' PROPERTIES

    Public Property MaNhom() As String
        Set(ByVal value As String)
            _MaNhom = value
        End Set
        Get
            Return _MaNhom
        End Get
    End Property

    Public Property TenNhom() As String
        Set(ByVal value As String)
            _TenNhom = value
        End Set
        Get
            Return _TenNhom
        End Get
    End Property

    ' EXTRA PROPERTIES

    Public ReadOnly Property DanhSach() As DataTable
        Get
            Dim DB = New Class_DB("SELECT MaNhom, TenNhom FROM NhomBan")
            _DanhSach = New DataTable()

            If DB.ChayLenh() Then
                _DanhSach = DB.KetQua
            End If

            Return _DanhSach
        End Get
    End Property
End Class
