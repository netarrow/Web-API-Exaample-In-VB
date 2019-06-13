Imports System.Net
Imports System.Web.Http
Imports BO
Imports BL

Namespace Controllers
    Public Class ItemController
        Inherits ApiController

        ' GET: api/Item
        Public Function GetValues() As IEnumerable(Of Item)
            Dim ItemBL = New ItemBL()
            Return ItemBL.GetAllItem()
        End Function

        ' GET: api/Item/5
        Public Function GetValue(id As Integer) As Item
            Dim ItemBL = New ItemBL()
            Return ItemBL.GetItemByID(id)
        End Function

        ' POST: api/Item
        Public Function PostValue(_Item As Item) As IHttpActionResult
            Dim ItemBL = New ItemBL()
            Try
                ItemBL.AddItem(_Item)
                Return Ok(_Item)
            Catch ex As Exception
                Return BadRequest(ex.Message)
            End Try
        End Function

        ' PUT: api/Item/5
        Public Function PutValue(_Item As Item) As IHttpActionResult
            Dim ItemBL = New ItemBL()
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
    End Class
End Namespace