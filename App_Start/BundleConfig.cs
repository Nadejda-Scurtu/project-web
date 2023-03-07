using System.Web;
using System.Web.Optimization;

namespace WebAplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Styles
            bundles.Add(
                new StyleBundle("~/Content/bootstrap.min.css").Include("~/Content/style/bootstrap.min.css", new CssRewriteUrlTransform())
            );
            bundles.Add(
                new StyleBundle("~/Content/font-awesome.css").Include("~/Content/style/font-awesome.css",new CssRewriteUrlTransform())
            );
            bundles.Add(
                new StyleBundle("~/Content/font-awesome.min.css").Include("~/Content/style/font-awesome.min.css",new CssRewriteUrlTransform())
            );

            bundles.Add(new StyleBundle("~/Content/hamburgers.min.css").Include(
                     "~/Content/style/hamburgers.min.css",
            new CssRewriteUrlTransform()
                ));

            bundles.Add(new StyleBundle("~/Content/jquery-ui.min.css").Include(
                     "~/Content/style/jquery-ui.min.css",
            new CssRewriteUrlTransform()
                ));

            bundles.Add(new StyleBundle("~/Content/main.css").Include(
                     "~/Content/style/main.css",
            new CssRewriteUrlTransform()
                ));

            bundles.Add(new StyleBundle("~/Content/util.css").Include(
                     "~/Content/style/util.css",
            new CssRewriteUrlTransform()
                ));

            bundles.Add(new StyleBundle("~/Content/animsition.min.css").Include(
                      "~/Content/style/animsition.min.css",
            new CssRewriteUrlTransform()
                ));

            bundles.Add(new StyleBundle("~/Content/material-design-iconic-font.min.css").Include(
                     "~/Content/style/material-design-iconic-font.min.css",
           new CssRewriteUrlTransform()
               ));

            bundles.Add(new StyleBundle("~/Content/icon-font.min.css").Include(
                     "~/Content/style/icon-font.min.css",
           new CssRewriteUrlTransform()
               ));

            bundles.Add(new StyleBundle("~/Content/magnific-popup.css").Include(
                     "~/Content/style/magnific-popup.css",
           new CssRewriteUrlTransform()
               ));

            bundles.Add(new StyleBundle("~/Content/slick-theme.css").Include(
                  "~/Content/style/slick-theme.css",
        new CssRewriteUrlTransform()
            ));

            bundles.Add(new StyleBundle("~/Content/slick.css").Include(
                     "~/Content/style/slick.css",
           new CssRewriteUrlTransform()
               ));

            bundles.Add(new StyleBundle("~/Content/select2.min.css").Include(
                     "~/Content/style/select2.min.css",
           new CssRewriteUrlTransform()
               ));

            //Scripts

            bundles.Add(new Bundle("~/Scripts/bootstrap.min.js").Include(
                      "~/Scripts/scr/bootstrap.min.js"));

            bundles.Add(new Bundle("~/Scripts/jquery-3.2.1.min.js").Include(
                    "~/Scripts/scr/jquery-3.2.1.min.js"));

            bundles.Add(new Bundle("~/Scripts/jquery-ui.min.js").Include(
                    "~/Scripts/scr/jquery-ui.min.js"));

            bundles.Add(new Bundle("~/Scripts/main.js").Include(
                    "~/Scripts/scr/main.js"));

            bundles.Add(new Bundle("~/Scripts/popper.min.js").Include(
                    "~/Scripts/scr/popper.min.js"));

            bundles.Add(new Bundle("~/Scripts/animsition.min.js").Include(
                     "~/Scripts/scr/animsition.min.js"));

            bundles.Add(new Bundle("~/Scripts/slick-custom.js").Include(
                    "~/Scripts/scr/slick-custom.js"));

            bundles.Add(new Bundle("~/Scripts/slick.js").Include(
                    "~/Scripts/scr/slick.js"));

            bundles.Add(new Bundle("~/Scripts/isotope.pkgd.min.js").Include(
                    "~/Scripts/scr/isotope.pkgd.min.js"));

            bundles.Add(new Bundle("~/Scripts/sweetalert.min.js").Include(
                   "~/Scripts/scr/sweetalert.min.js"));

            bundles.Add(new Bundle("~/Scripts/select2.min.js").Include(
                    "~/Scripts/scr/select2.min.js"));

            bundles.Add(new Bundle("~/Scriptsjquery.magnific-popup.min.js").Include(
                    "~/Scripts/scr/jquery.magnific-popup.min.js"));
        }
    }
}
