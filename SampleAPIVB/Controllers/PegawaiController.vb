Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class PegawaiController
        Inherits ApiController

        Private lstPegawai As List(Of Pegawai)

        Public Sub New()
            lstPegawai = New List(Of Pegawai)
            lstPegawai.Add(New Pegawai() With {
                          .Kode = "007001",
                          .Nama = "Erick",
                          .Alamat = "Gowongan 46",
                          .Umur = 17
                          })

            lstPegawai.Add(New Pegawai() With {
                           .Kode = "007002",
                           .Nama = "Budi",
                           .Alamat = "Jl Wahidin 12",
                           .Umur = 22})
        End Sub

        ' GET: api/Pegawai
        Public Function GetValues() As IEnumerable(Of Pegawai)
            Return lstPegawai
        End Function

        Public Function GetValues(nama As String) As IEnumerable(Of Pegawai)
            Dim results = From p In lstPegawai
                          Where p.Nama.Contains(nama)
                          Select p

            'Dim results = lstPegawai.Where(Function(p) p.Nama.Contains(nama))

            Return results
        End Function

        ' GET: api/Pegawai/5
        Public Function GetValue(ByVal id As Integer) As Pegawai
            Return New Pegawai With {
                 .Kode = "007002",
                           .Nama = "Budi" & id,
                           .Alamat = "Jl Wahidin 12",
                           .Umur = 22}
        End Function

        ' POST: api/Pegawai
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Pegawai/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Pegawai/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace