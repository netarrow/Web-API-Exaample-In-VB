Imports BO
Imports DAL

Public Class DivisiBL
    Public Function GetAllDivisi() As IEnumerable(Of Divisi)
        Dim divisiDal As New DivisiDAL()
        Return divisiDal.GetAllDivisi()
    End Function
End Class
