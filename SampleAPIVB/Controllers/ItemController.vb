Imports System.Web.Http
Imports BO
Imports BL

Namespace Controllers

    Public Class ItemController
        Inherits ApiController

        ' GET: api/Item

        Public Function GetValues() As IEnumerable(Of Item)
            Dim ItemBL = New ItemBl()
            Return ItemBL.GetAllItem()
        End Function

        ' GET: api/Item/5
        Public Function GetValue(id As Integer) As Item
            Dim ItemBL = New ItemBl()
            Return ItemBL.GetItemByID(id)
        End Function

        ' POST: api/Item
        Public Function PostValue(_Item As Item) As IHttpActionResult
            Dim ItemBL = New ItemBl()
            Try
                ItemBL.AddItem(_Item)
                Return Ok(_Item)
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

        ' PUT: api/Item/5
        Public Function PutValue(_Item As Item) As IHttpActionResult
            Dim ItemBL = New ItemBl()
            Try
                ItemBL.UpdateItem(_Item)
                Return Ok(_Item)
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

        ' DELETE: api/Item/5
        Public Function DeleteValue(ByVal id As Integer) As IHttpActionResult
            Dim ItemBL = New ItemBl()
            Try
                ItemBL.DeleteItem(id)
                Return Ok(True)
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

        <Route("custom/test")>
        <HttpGet()>
        Public Function CustomMethod() As IHttpActionResult
            Try
                Return Ok("Chiamato il metodo custom Method con verbo Get")
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

        <Route("custom/test")>
        <HttpPost()>
        Public Function PostCustomMethod() As IHttpActionResult
            Try
                Return Ok("Chiamato il metodo custom Method con verbo Post")
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

        <Route("custom/qq")>
        <HttpGet()>
        Public Function AnotherGetCustomMethod() As IHttpActionResult
            Try
                Return Ok("Chiamato il secondo metodo custom Method con verbo Get")
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

    End Class
End Namespace