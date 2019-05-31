Imports BO
Imports DAL

Public Class ItemBl
    Public Function GetAllItem() As IEnumerable(Of Item)
        Dim ItemDal As New ItemDAL()
        Return ItemDal.GetAllItem()
    End Function

    Public Function GetItemByID(_ItemID As Integer) As Item
        Dim ItemDal As New ItemDAL()
        Return ItemDal.GetItemByID(_ItemID)
    End Function

    Public Sub AddItem(_Item As Item)
        Dim ItemDal As New ItemDAL()

        If _Item.NamaItem = String.Empty Or IsNothing(_Item.NamaItem) Then
            Throw New Exception("Error: Nama Item harus ada ! ")  
        End If

        Try
            ItemDal.AddItem(_Item)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub UpdateItem(_Item As Item)
        Dim ItemDal As New ItemDAL()
        Try
            ItemDal.UpdateItem(_Item)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DeleteItem(_ItemID As Integer)
        Dim ItemDal As New ItemDAL()
        Try
            ItemDal.DeleteItem(_ItemID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
