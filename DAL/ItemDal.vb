Imports BO
Imports System.Configuration
Imports Oracle.ManagedDataAccess.Client
Imports Dapper

Public Class ItemDal
    Implements IDisposable

    Private Shared items As List(Of Item)

    Public Sub New()
        If items Is Nothing Then
            items = New List(Of Item)
            items.Add(New Item() With {.NamaItem = "Test", .ItemID = 1})
            items.Add(New Item() With {.NamaItem = "Prova", .ItemID = 2})
        End If
    End Sub

    Public Function GetAllItem() As IEnumerable(Of Item)
        Return items
    End Function

    Public Function GetItemByID(_ItemID As Integer) As Item
        Dim item = items.SingleOrDefault(Function(x) x.ItemID = _ItemID)
        If item Is Nothing Then Throw New InvalidOperationException($"Item with {item.ItemID} not found")

        Return item
    End Function

    Public Sub AddItem(_Item As Item)
        If items.Any(Function(n) n.ItemID = _Item.ItemID) Then
            Throw New InvalidOperationException($"Item ID already in use!")
        End If
        items.Add(_Item)
    End Sub

    Public Sub UpdateItem(_Item As Item)
        Dim itemToEdit = items.SingleOrDefault(Function(x) x.ItemID = _Item.ItemID)
        If itemToEdit Is Nothing Then Throw New InvalidOperationException($"Item with {_Item.ItemID} not found")
        itemToEdit.NamaItem = _Item.NamaItem

    End Sub

    Public Sub DeleteItem(_ItemID As Integer)
        Dim itemToDelete = items.SingleOrDefault(Function(x) x.ItemID = _ItemID)
        If itemToDelete Is Nothing Then Throw New InvalidOperationException($"Item with {_ItemID} not found")

        items.Remove(itemToDelete)

    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        GC.SuppressFinalize(Me)
    End Sub
End Class