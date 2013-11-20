using System.Web;
using System.Web.Optimization;

namespace MyAwesomeMvcProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-1.10.2.intellisense.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //
            // jQuery UI

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                      "~/Scripts/jquery-ui-1.10.3.custom.js",
                      "~/Scripts/jquery.form.js"));

            bundles.Add(new StyleBundle("~/Content/jquery-ui-style").Include(
                      "~/Content/jquery-ui-1.10.3.custom.css"));

            //
            // Awesome MVC

            bundles.Add(new ScriptBundle("~/bundles/awesome-js").Include(
                      "~/Scripts/awesome.js"));

            bundles.Add(new StyleBundle("~/Content/awesome-css").Include(
                      "~/Content/Awesome.css"));

            //
            // Json 2

            bundles.Add(new ScriptBundle("~/bundles/json2").Include(
                      "~/Scripts/json2.js"));
        }
    }
}
