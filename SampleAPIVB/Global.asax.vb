Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Optimization
Imports Swashbuckle.Application
<Assembly: PreApplicationStartMethod(GetType(SwagConfig), "Register")>

Public Class SwagConfig
    Public Shared Function Register()

        Dim thisAssembly = GetType(SwagConfig).Assembly

        GlobalConfiguration.Configuration.EnableSwagger(
                Function(c)
                    c.SingleApiVersion("v1", "Values Api")
                    c.RootUrl(Function(req)
                                  Dim url = req.RequestUri.GetLeftPart(UriPartial.Authority) + req.GetRequestContext().VirtualPathRoot.TrimEnd("/"c)
                                  Return url
                              End Function)
                End Function).EnableSwaggerUi()


    End Function
End Class

Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()

        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)


    End Sub
End Class

