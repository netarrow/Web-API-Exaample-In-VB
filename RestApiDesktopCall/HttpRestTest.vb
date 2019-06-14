Imports System.Net.Http

Module HttpRestTest

    Sub Main()
        Dim t As Task = New Task(AddressOf SendRequest)
        t.Start()
        Console.WriteLine("Inizio richiesta")
        Console.ReadLine()
    End Sub

    Async Sub SendRequest()
        Dim uri As New Uri("http://localhost:25275/api/item")
        Using client As HttpClient = New HttpClient
            Using response As HttpResponseMessage = Await client.GetAsync(uri)
                Using content As HttpContent = response.Content
                    Dim result As String = Await content.ReadAsStringAsync()
                    If result IsNot Nothing Then
                        Console.WriteLine(result.ToString())
                    End If
                End Using
            End Using
        End Using
    End Sub

End Module
