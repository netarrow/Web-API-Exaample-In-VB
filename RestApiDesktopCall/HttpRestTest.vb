Imports System.Net.Http
Imports System.Text
Imports System.Web.Script.Serialization
Imports BO

Module HttpRestTest

    Dim serializer As New JavaScriptSerializer()

    Sub Main()
        Dim t As Task = New Task(AddressOf SendRequest)
        t.Start()
        t.Wait()

        Console.WriteLine("Premi un tasto per uscire")
        Console.ReadLine()
    End Sub

    Async Sub SendRequest()
        Dim uri As New Uri("http://localhost:25275/api/item")
        Using client As HttpClient = New HttpClient

            Console.WriteLine("Letto con richiesta Get tutti gli oggetti")
            Console.WriteLine()
            Dim firstGetAndPrint As Task = GetAndPrintItems(client, uri)
            firstGetAndPrint.Wait()

            Console.WriteLine()
            Console.WriteLine("Mando con Post un nuovo oggetto")
            Console.WriteLine()
            Dim newItem As Task = SendNewItem(client, uri)
            newItem.Wait()

            Console.WriteLine("Rileggo di nuovo gli oggetti con una get ottengo anche il Nuovo Item")
            Console.WriteLine()
            Dim printItems = GetAndPrintItems(client, uri)
            printItems.Wait()

            Task.WaitAll(firstGetAndPrint, newItem, printItems)

        End Using
    End Sub

    Private Async Function SendNewItem(client As HttpClient, uri As Uri) As Task
        Dim newItem As Item = New Item() With {.NamaItem = "NuovoItem", .ItemID = DateTime.Now.Millisecond}
        Dim data = New StringContent(serializer.Serialize(newItem), Encoding.UTF8, "application/json")
        Using response As HttpResponseMessage = Await client.PostAsync("http://localhost:25275/api/item", data)
            response.EnsureSuccessStatusCode()
        End Using
    End Function

    Private Async Function GetAndPrintItems(client As HttpClient, uri As Uri) As Task
        Using response As HttpResponseMessage = Await client.GetAsync(uri)
            Using content As HttpContent = response.Content
                Dim result As String = Await content.ReadAsStringAsync()
                If result IsNot Nothing Then
                    Dim json = result.ToString()
                    Dim deserializer As New JavaScriptSerializer()
                    Dim items As List(Of Item) = deserializer.Deserialize(Of List(Of Item))(json)
                    For Each item As Item In items
                        Console.WriteLine(item.NamaItem & " - " & item.ItemID)
                    Next
                End If
            End Using
        End Using
    End Function
End Module
