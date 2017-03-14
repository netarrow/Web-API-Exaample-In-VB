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
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Divisi
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Divisi/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Divisi/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace