namespace wt.web
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/lib/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/lib/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/lib/knockout-{version}.js",
                "~/Scripts/lib/knockout.mapping.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                "~/Scripts/app/docCookies.js",
                "~/Scripts/app/common.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.css",
                "~/Content/site.css"));
        }
    }
}