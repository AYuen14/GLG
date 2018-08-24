namespace GLGWorkSample
{
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region ASP.Net MVC Script Bundles

            bundles.Add(new ScriptBundle("~/bundles/layoutmain.js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            #endregion

            #region ASP.Net MVC Style Bundles

            bundles.Add(new StyleBundle("~/bundles/layoutmain.css").Include(
                "~/Content/main.css"));

            #endregion
        }
    }
}
