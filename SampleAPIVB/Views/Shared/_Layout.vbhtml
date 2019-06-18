<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.8/styles/default.min.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.15.8/highlight.min.js"></script>

    <script>hljs.initHighlightingOnLoad();</script>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")

    <script src="~/Scripts/serviceReader.js"></script>

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav menu">
                    <li>@Html.ActionLink("Html Semantico", "ZenGarden", "Home", New With {.area = ""}, Nothing)</li>
                    <li>@Html.ActionLink("CSS - Specificy", "Specificy", "Home", New With {.area = ""}, Nothing)</li>
                    <li>@Html.ActionLink("CSS - Display", "Index", "Home", New With {.area = ""}, Nothing)</li>
                    <li>@Html.ActionLink("CSS - Position", "Position", "Home", New With {.area = ""}, Nothing)</li>
                    <li>@Html.ActionLink("CSS - Flex", "Flex", "Home", New With {.area = ""}, Nothing)</li>
                    <li>@Html.ActionLink("Javascript", "Javascript", "Home", New With {.area = ""}, Nothing)</li>
                    <li>@Html.ActionLink("Form", "Form", "Home", New With {.area = ""}, Nothing)</li>
                    <li><a href="http://bootstrapstudio.io" target="_blank">Bootstrap</a></li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @RenderSection("scripts", required:=False)
</body>
</html>
