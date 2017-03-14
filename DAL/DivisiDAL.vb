Imports BO
Imports System.Configuration
Imports Oracle.ManagedDataAccess.Client
Imports Dapper

Public Class DivisiDAL
    Implements IDisposable

    Private Function GetConnStr() As String
        Return ConfigurationManager.ConnectionStrings("OraConnectionString").ConnectionString
    End Function

    Public Function GetAllDivisi() As IEnumerable(Of Divisi)
        Using conn As New OracleConnection(GetConnStr())
            Dim strSql = "select * from Erick.Divisi order by NamaDivisi"
            Return conn.Query(Of Divisi)(strSql)
        End Using
    End Function

    Public Function GetDivisiByID(_divisiID As Integer) As Divisi
        Using conn As New OracleConnection(GetConnStr())
            Dim strSql = "select * from Erick.Divisi where DivisiID=:DivisiID"
            Dim param = New With {.DivisiID = _divisiID}
            Dim result = conn.Query(Of Divisi)(strSql, param).SingleOrDefault()
            Return result
        End Using
    End Function

    Public Sub TambahDivisi(_divisi As Divisi)
        Using conn As New OracleConnection(GetConnStr())
            Dim strSql = "insert into Erick.Divisi(NamaDivisi) values(:NamaDivisi)"
            Dim param = New With {.NamaDivisi = _divisi.NamaDivisi}
            Try
                conn.Execute(strSql, param)
            Catch oraEx As OracleException
                Throw New Exception("Error " & oraEx.Message)
            End Try
        End Using
    End Sub

    Public Sub UpdateDivisi(_divisi As Divisi)
        Using conn As New OracleConnection(GetConnStr())
            Dim strSql = "update Erick.Divisi set NamaDivisi=:NamaDivisi where DivisiID=:DivisiID"
            Dim param = New With {.NamaDivisi = _divisi.NamaDivisi, .DivisiID = _divisi.DivisiID}
            Try
                conn.Execute(strSql, param)
            Catch oraEx As OracleException
                Throw New Exception("Error " & oraEx.Message)
            End Try
        End Using
    End Sub

    Public Sub DeleteDivisi(_divisiID As Integer)
        Using conn As New OracleConnection(GetConnStr())
            Dim strSql = "delete Erick.Divisi where DivisiID=:DivisiID"
            Dim param = New With {.DivisiID = _divisiID}
            Try
                conn.Execute(strSql, param)
            Catch oraEx As OracleException
                Throw New Exception("Error " & oraEx.Message)
            End Try
        End Using
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        GC.SuppressFinalize(Me)
    End Sub
End Class




'Dim lstDivisi As New List(Of Divisi)
'Using conn As New OracleConnection(GetConnStr())
'    Dim strSql = "select * from Erick.Divisi order by NamaDivisi"
'    Dim cmd As New OracleCommand(strSql, conn)
'    conn.Open()

'    Dim dr As OracleDataReader = cmd.ExecuteReader()
'    If dr.HasRows Then
'        While dr.Read
'            lstDivisi.Add(New Divisi With {
'                          .DivisiID = CInt(dr("DivisiID")),
'                          .NamaDivisi = dr("NamaDivisi")
'                          })
'        End While
'    End If
'    dr.Close()
'    cmd.Dispose()
'    conn.Close()
'End Using

'Return lstDivisi