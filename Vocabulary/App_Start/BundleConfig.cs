using System.Web.Optimization;

namespace Vocabulary
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery/jquery-{version}.js",
                "~/Scripts/jquery/jquery-migrate-{version}.js",
                 "~/Scripts/bootstrap/bootstrap.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/SignalR").Include(
                "~/Scripts/jquery.signalR-0.5.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery/jquery.unobtrusive*",
                "~/Scripts/jquery/jquery.validate*"));
            
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery/jquery-ui-{version}.js"));
            
            bundles.Add(new StyleBundle("~/content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/body.css",
                "~/Content/bootstrap-responsive.css",
                "~/Content/bootstrap-mvc-validation.css"
                ));
        }
    }
}

