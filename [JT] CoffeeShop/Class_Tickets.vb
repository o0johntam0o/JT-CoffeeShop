Public Class Class_Tickets
    Private _MaPhieu, _MaBan As String
    Private _TinhTien As Boolean
    Private _NgayTao As DateTime

    Private _DanhSach As DataTable

    Public Sub New()
        Me.MaPhieu = ""
        Me.MaBan = ""
        Me.TinhTien = True
        Me.NgayTao = DateTime.Now.Date
    End Sub

    ' FUNCTIONS

    Public Function TimThongTin(iMaPhieu As String)
        Dim DB = New Class_DB("SELECT MaPhieu, MaBan, TinhTien, NgayTao FROM Phieu WHERE MaPhieu='" & iMaPhieu & "'")

        If DB.ChayLenh() Then
            Dim DS = DB.KetQua
            If DS.Rows.Count = 1 Then
                Me.MaPhieu = DS.Rows(0).Item("MaPhieu")
                Me.MaBan = DS.Rows(0).Item("MaBan")
                Me.TinhTien = DS.Rows(0).Item("TinhTien")
                Me.NgayTao = DS.Rows(0).Item("NgayTao")

                Return 1
                Exit Function
            End If
        End If

        Me.MaPhieu = ""
        Me.MaBan = ""
        Me.TinhTien = True
        Me.NgayTao = DateTime.Now.Date

        Return 0
    End Function

    Public Function Them() As Boolean
        If Me.MaBan.Length > 0 Then
            Dim DB = New Class_DB()
            Dim DS = New DataTable()

            DB.CauLenh = "SELECT LAST(MaPhieu) FROM Phieu"
            If DB.ChayLenh() Then
                If DB.KetQua.Rows(0).Item(0).ToString.Length > 0 Then
                    Me.MaPhieu = "P" & CInt(DB.KetQua.Rows(0).Item(0).SubString(1)) + 1
                Else
                    Me.MaPhieu = "P1"
                End If
            Else
                Return 0
            End If

            Me.NgayTao = DateTime.Now.Date
            Me.TinhTien = False

            DB.CauLenh = "SELECT MaPhieu, NgayTao FROM Phieu WHERE MaBan='" & Me.MaBan & "' AND TinhTien=False"
            If DB.ChayLenh() Then
                DS = DB.KetQua
                If DS.Rows.Count > 0 Then
                    Me.MaPhieu = DS.Rows(0).Item("MaPhieu")
                    Me.NgayTao = DS.Rows(0).Item("NgayTao")
                    Return 1
                End If
            Else
                Return 0
            End If

            DB.CauLenh = "INSERT INTO Phieu VALUES ('" & Me.MaPhieu & "', '" & Me.MaBan & "', " & Me.TinhTien & ", '" & Me.NgayTao & "')"
            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    Public Function Xoa() As Boolean
        If Me.MaPhieu.Length > 0 Then
            Dim DB = New Class_DB()

            DB.CauLenh = "DELETE FROM Phieu WHERE MaPhieu='" & Me.MaPhieu & "'"
            If DB.ChayLenh() Then
                Return 1
            End If
        End If

        Return 0
    End Function

    ' PROPERTIES

    Public Property MaPhieu() As String
        Set(ByVal value As String)
            _MaPhieu = value
        End Set
        Get
            Return _MaPhieu
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

    Public Property TinhTien() As Boolean
        Set(ByVal value As Boolean)
            _TinhTien = value
        End Set
        Get
            Return _TinhTien
        End Get
    End Property

    Public Property NgayTao() As DateTime
        Set(ByVal value As DateTime)
            _NgayTao = value
        End Set
        Get
            Return _NgayTao
        End Get
    End Property

    ' EXTRA PROPERTIES

    Public ReadOnly Property DanhSach() As DataTable
        Get
            Dim DB = New Class_DB("SELECT MaPhieu, MaBan, TinhTien, NgayTao FROM Phieu WHERE TinhTien=True")
            _DanhSach = New DataTable()

            If DB.ChayLenh() Then
                _DanhSach = DB.KetQua
            End If

            Return _DanhSach
        End Get
    End Property

    Public ReadOnly Property TimKiem(iCon As String, iKey As String) As DataTable
        Get
            Dim DB = New Class_DB("SELECT MaPhieu, MaBan, TinhTien, NgayTao FROM Phieu WHERE TinhTien=True And " & iCon & " LIKE '%" & iKey & "%'")
            _DanhSach = New DataTable()

            If DB.ChayLenh() Then
                _DanhSach = DB.KetQua
            End If

            Return _DanhSach
        End Get
    End Property
End Class
