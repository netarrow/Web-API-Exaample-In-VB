Imports BO
Imports SampleAPIVB.Models

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Display"

        Return View()
    End Function

    Function Specificy() As ActionResult
        ViewData("Title") = "Specificy"

        Return View()
    End Function

    Function Position() As ActionResult
        ViewData("Title") = "Position"

        Return View()
    End Function
    Function Flex() As ActionResult
        ViewData("Title") = "Flex"

        Return View()
    End Function

    Function ZenGarden() As ActionResult
        ViewData("Title") = "ZenGarden"

        Return View()
    End Function

    Function Javascript() As ActionResult
        ViewData("Title") = "Javascript"

        Return View()
    End Function

    Function Form() As ActionResult
        Return View()
    End Function

    <HttpPost>
    Function PostData(model As MyModel) As ActionResult
        ViewData("Title") = "Javascript"

        Dim m = New MyModel()
        m.Name = model.Name
        m.MyList = New List(Of Item)
        m.IsAltered = model.IsAltered
        m.MyList.Add(New Item() With {.ItemID = 1, .NamaItem = "Test"})
        m.MyList.Add(New Item() With {.ItemID = 2, .NamaItem = "Prova"})

        Return View("Form", m)
    End Function

End Class
