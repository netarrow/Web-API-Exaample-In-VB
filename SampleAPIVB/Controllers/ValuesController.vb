Imports System.Net
Imports System.Web.Http
Imports BO

Namespace Controllers
    Public Class ValuesController
        Inherits ApiController

        Shared dati As List(Of Item)

        Public Sub New()
            If dati Is Nothing Then
                dati = New List(Of Item)
                dati.Add(New Item() With {.NamaItem = "Test", .ItemID = 1})
                dati.Add(New Item() With {.NamaItem = "Prova", .ItemID = 2})
            End If
        End Sub

        ' GET: api/Values
        Public Function GetValues() As IHttpActionResult

            Return Ok(dati)

        End Function

        <Route("api/values/{id}/{isAltered}")>
        <HttpPut()>
        Public Function PutValue(ByVal id As Integer, ByVal isAltered As Boolean) As IHttpActionResult

            Dim itemToEdit = dati.SingleOrDefault(Function(item) item.ItemID = id)

            If (itemToEdit Is Nothing) Then
                Return NotFound()
            End If

            itemToEdit.IsAltered = isAltered

            Return Ok(dati)
        End Function

        ' GET: api/Values/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Values
        Public Function PostValue(<FromBody()> ByVal param As Item) As IHttpActionResult


            Return Ok(param)

        End Function


        ' DELETE: api/Values/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace