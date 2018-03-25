using System.Web;
using System.Web.Optimization;

namespace CodeBeaBlog
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/adem").Include(
                        "~/Admin/bower_components/jquery-ui/jquery-ui.min.js",
                        "~/Admin/bower_components/bootstrap/dist/js/bootstrap.min.js",
                        "~/Admin/bower_components/datatables.net/js/jquery.dataTables.min.js" ,
                        "~/Admin/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js",
                        "~/Admin/bower_components/ckeditor/ckeditor.js",
                        "~/Admin/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                        "~/Admin/dist/js/adminlte.min.js",
                        "~/Admin/dist/js/pages/dashboard.js",
                        "~/Admin/dist/js/demo.js")  
                        //.IncludeDirectory("~/Scripts/Controllers","*.js")
                        //.IncludeDirectory("~/Scripts/Factories","*.js")
                        //.Include("~/Scripts/codeBlogMainApp.js")
                     
                        )
                        ;
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
