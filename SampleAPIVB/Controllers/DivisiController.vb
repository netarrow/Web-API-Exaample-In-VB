Imports System.Net
Imports System.Web.Http
Imports BO
Imports BL

Namespace Controllers
    Public Class DivisiController
        Inherits ApiController

        ' GET: api/Divisi
        Public Function GetValues() As IEnumerable(Of Divisi)
            Dim divisiBL = New DivisiBL()
            Return divisiBL.GetAllDivisi()
        End Function

        ' GET: api/Divisi/5
        Public Function GetValue(id As Integer) As Divisi
            Dim divisiBL = New DivisiBL()
            Return divisiBL.GetDivisiByID(id)
        End Function

        ' POST: api/Divisi
        Public Function PostValue(_divisi As Divisi) As IHttpActionResult
            Dim divisiBL = New DivisiBL()
            Try
                divisiBL.TambahDivisi(_divisi)
                Return Ok()
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

        ' PUT: api/Divisi/5
        Public Function PutValue(_divisi As Divisi) As IHttpActionResult
            Dim divisiBL = New DivisiBL()
            Try
                divisiBL.UpdateDivisi(_divisi)
                Return Ok()
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

        ' DELETE: api/Divisi/5
        Public Function DeleteValue(ByVal id As Integer) As IHttpActionResult
            Dim divisiBL = New DivisiBL()
            Try
                divisiBL.DeleteDivisi(id)
                Return Ok()
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function
    End Class
End Namespace