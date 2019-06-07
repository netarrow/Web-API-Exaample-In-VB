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

End Class
