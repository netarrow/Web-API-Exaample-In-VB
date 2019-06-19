Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports Swashbuckle.Application

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )

        config.Formatters.Remove(config.Formatters.XmlFormatter) ' rimuoviamo Xml formatter per far lavorare le api in json  

    End Sub
End Module
