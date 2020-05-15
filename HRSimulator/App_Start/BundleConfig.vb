Imports System.Web
Imports System.Web.Optimization

Public Module BundleConfig
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New StyleBundle("~/Content/css").Include(
                    "~/Content/System/image/favicon.ico", "~/Content/System/css/morris.css", "~/Content/System/css/bootstrap.min.css",
                    "~/Content/Custom/css/icons.css", "~/Content/Custom/css/style.css"))

        bundles.Add(New ScriptBundle("~/Content/js").Include(
                    "~/Content/System/js/jquery.min.js", "~/Content/System/js/popper.min.js", "~/Content/System/js/bootstrap.min.js",
                    "~/Content/System/js/modernizr.min.js", "~/Content/System/js/detect.js", "~/Content/System/js/fastclick.js", "~/Content/System/js/jquery.slimscroll.js",
                    "~/Content/System/js/jquery.blockUI.js", "~/Content/System/js/waves.js", "~/Content/System/js/jquery.nicescroll.js",
                    "~/Content/System/js/jquery.scrollTo.min.js", "~/Content/Custom/js/app.js"))
    End Sub
End Module