Imports BO

Namespace Models
    Public Class MyModel

        Public Property WebApiUrl() As String

        Private _ClassToUseForTable As String
        Public Property Name() As String

        Public Property MyList As List(Of Item)

        Public Property IsAltered As Boolean

        ReadOnly Property ClassToUseForTable() As String
            Get
                Return If(IsAltered, "alteredTable", "")
            End Get
        End Property
    End Class
End Namespace