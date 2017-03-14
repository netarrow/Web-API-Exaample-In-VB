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
End Class
