Public Class Class_Bills
    Private _MaPhieu(0), _MaMon(0) As String
    Private _SoLuong(0) As Integer

    Private _DanhSach(0) As DataTable

    Public Sub New()
        Me.MaPhieu(0) = ""
        Me.MaMon(0) = ""
        Me.SoLuong(0) = 0
    End Sub

    ' FUNCTIONS

    Public Function TimThongTin(iMaPhieu As String) As Boolean
        Dim DB = New Class_DB()
        DB.CauLenh = "SELECT MaPhieu, MaMon, SoLuong FROM HoaDon WHERE MaPhieu='" & iMaPhieu & "'"

        If DB.ChayLenh() Then
            Dim DS = DB.KetQua
            If DS.Rows.Count > 0 Then
                ReDim _MaPhieu(DS.Rows.Count - 1), _MaMon(DS.Rows.Count - 1), _SoLuong(DS.Rows.Count - 1)
                For i As Integer = 0 To DS.Rows.Count - 1 Step 1
                    Me.MaPhieu(i) = DS.Rows(i).Item("MaPhieu")
                    Me.MaMon(i) = DS.Rows(i).Item("MaMon")
                    Me.SoLuong(i) = DS.Rows(i).Item("SoLuong")
                Next

                Return 1
                Exit Function
            End If
        End If

        Me.MaPhieu(0) = ""
        Me.MaMon(0) = ""
        Me.SoLuong(0) = 0

        Return 0
    End Function

    Public Function Them() As Boolean
        If Me.MaPhieu(0).Length > 0 And Me.MaMon(0).Length > 0 And Me.SoLuong(0) > 0 Then
            Dim DB = New Class_DB()
            Dim DS = New DataTable()

            DB.CauLenh = "SELECT MaPhieu FROM HoaDon WHERE MaPhieu='" & Me.MaPhieu(0) & "' AND MaMon='" & Me.MaMon(0) & "'"
            If DB.ChayLenh() Then
                DS = DB.KetQua
                If DS.Rows.Count > 0 Then
                    ' UPDATE
                    DB.CauLenh = "UPDATE HoaDon SET SoLuong=SoLuong+" & Me.SoLuong(0) & " WHERE MaPhieu='" & Me.MaPhieu(0) & "' AND MaMon='" & Me.MaMon(0) & "'"
                    If DB.ChayLenh() Then
                        Return 1
                    End If
                End If
            Else
                Return 0
            End If

            ' ADD NEW
            DB.CauLenh = "INSERT INTO HoaDon(MaPhieu, MaMon, SoLuong) VALUES ('" & Me.MaPhieu(0) & "', '" & Me.MaMon(0) & "', " & Me.SoLuong(0) & ")"
            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    Public Function Xoa() As Boolean
        If Me.MaPhieu(0).Length > 0 And Me.MaMon(0).Length > 0 Then
            Dim DB = New Class_DB()

            DB.CauLenh = "DELETE FROM HoaDon WHERE MaPhieu='" & Me.MaPhieu(0) & "' AND MaMon='" & Me.MaMon(0) & "'"
            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    ' PROPERTIES

    Public Property MaPhieu() As String()
        Set(ByVal value As String())
            _MaPhieu = value
        End Set
        Get
            Return _MaPhieu
        End Get
    End Property

    Public Property MaMon() As String()
        Set(ByVal value As String())
            _MaMon = value
        End Set
        Get
            Return _MaMon
        End Get
    End Property

    Public Property SoLuong() As Integer()
        Set(ByVal value As Integer())
            _SoLuong = value
        End Set
        Get
            Return _SoLuong
        End Get
    End Property

    ' EXTRA PROPERTIES

    Public ReadOnly Property DanhSach() As DataTable()
        Get
            Dim DB = New Class_DB()
            _DanhSach(0) = New DataTable()

            DB.CauLenh = "SELECT MaPhieu FROM Phieu"
            If DB.ChayLenh() Then
                Dim DS = DB.KetQua
                If DS.Rows.Count > 0 Then
                    ReDim _DanhSach(DS.Rows.Count - 1)
                    For i As Integer = 0 To DS.Rows.Count - 1 Step 1
                        DB.CauLenh = "SELECT MaPhieu, MaMon, SoLuong FROM HoaDon WHERE MaPhieu='" & DS.Rows(i).Item("MaPhieu") & "'"
                        If DB.ChayLenh() Then
                            _DanhSach(i) = DB.KetQua
                        End If
                    Next
                End If
            End If

            Return _DanhSach
        End Get
    End Property
End Class
