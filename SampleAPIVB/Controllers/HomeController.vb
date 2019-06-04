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
End Class
