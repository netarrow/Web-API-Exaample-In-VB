Imports BO
Imports DAL

Public Class DivisiBL
    Public Function GetAllDivisi() As IEnumerable(Of Divisi)
        Dim divisiDal As New DivisiDAL()
        Return divisiDal.GetAllDivisi()
    End Function

    Public Function GetDivisiByID(_divisiID As Integer) As Divisi
        Dim divisiDal As New DivisiDAL()
        Return divisiDal.GetDivisiByID(_divisiID)
    End Function

    Public Sub TambahDivisi(_divisi As Divisi)
        Dim divisiDal As New DivisiDAL()
        Try
            divisiDal.TambahDivisi(_divisi)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub UpdateDivisi(_divisi As Divisi)
        Dim divisiDal As New DivisiDAL()
        Try
            divisiDal.UpdateDivisi(_divisi)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub DeleteDivisi(_divisiID As Integer)
        Dim divisiDal As New DivisiDAL()
        Try
            divisiDal.DeleteDivisi(_divisiID)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
