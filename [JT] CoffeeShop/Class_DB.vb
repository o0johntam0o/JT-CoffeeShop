Public Class Class_DB
    Private _CauLenh As String
    Private _KetQua As DataTable

    Private _DbSource As String = "Database.mdb"
    Private _DbUsername As String = "Admin"
    Private _DbPassword As String = "Admin"

    Public Sub New()
        Me.CauLenh = ""
        Me.KetQua = New DataTable()
    End Sub

    Public Sub New(ByVal iCauLenh As String)
        Me.CauLenh = iCauLenh
        Me.KetQua = New DataTable()
    End Sub

    Public Function ChayLenh() As Boolean
        If Me.CauLenh.Length > 0 Then
            Dim _KetNoi As System.Data.OleDb.OleDbConnection
            Dim _Adap As System.Data.OleDb.OleDbDataAdapter
            Dim _BoNhoTam As DataSet

            _BoNhoTam = New DataSet()

            Try
                _KetNoi = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data source=" & Me.DbSource & "; Jet OLEDB:Database Password=" & Me.DbPassword & ";")
                _KetNoi.Open()
                _Adap = New System.Data.OleDb.OleDbDataAdapter(Me.CauLenh, _KetNoi)
                _Adap.Fill(_BoNhoTam, "Result")
                Me.KetQua = _BoNhoTam.Tables("Result")
                _KetNoi.Close()
                Return 1
            Catch
                Return 0
            End Try
        Else
            Return 0
        End If
    End Function

    Public Property CauLenh() As String
        Set(ByVal value As String)
            _CauLenh = value
        End Set
        Get
            Return _CauLenh
        End Get
    End Property

    Public ReadOnly Property DbSource() As String
        Get
            Return _DbSource
        End Get
    End Property

    Public ReadOnly Property DbUsername() As String
        Get
            Return _DbUsername
        End Get
    End Property

    Public ReadOnly Property DbPassword() As String
        Get
            Return _DbPassword
        End Get
    End Property

    Public Property KetQua() As DataTable
        Set(ByVal value As DataTable)
            _KetQua = value
        End Set

        Get
            Return _KetQua
        End Get
    End Property
End Class
