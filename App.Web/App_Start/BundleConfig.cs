using System.Web;
using System.Web.Optimization;

namespace App.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                     "~/Content/Template/fashe/vendor/bootstrap/css/bootstrap.min.css",
                     //"~/Content/Template/fashe/fonts/font-awesome-4.7.0/css/font-awesome.min.css",
                     //"~/Content/Template/fashe//fonts/themify/themify-icons.css",
                     // "~/Content/Template/fashe/fonts/Linearicons-Free-v1.0.0/icon-font.min.css",
                     //  "~/Content/Template/fashe/fonts/elegant-font/html-css/style.css",
                        "~/Content/Template/fashe/vendor/animate/animate.css",
                         "~/Content/Template/fashe/vendor/css-hamburgers/hamburgers.min.css",
                          "~/Content/Template/fashe/vendor/animsition/css/animsition.min.css",
                          "~/Content/Template/fashe/vendor/select2/select2.min.css",
                           "~/Content/Template/fashe/vendor/daterangepicker/daterangepicker.css",
                            "~/Content/Template/fashe/vendor/slick/slick.css",
                             "~/Content/Template/fashe/vendor/lightbox2/css/lightbox.min.css",
                              "~/Content/Template/fashe/css/util.css",
                              "~/Content/Template/fashe/css/main.css"));
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Content/Template/fashe/vendor/jquery/jquery-3.2.1.min.js",
                      "~/Content/Template/fashe/vendor/animsition/js/animsition.min.js",
                      "~/Content/Template/fashe/vendor/bootstrap/js/popper.js",
                      "~/Content/Template/fashe/vendor/bootstrap/js/bootstrap.min.js",
                      "~/Content/Template/fashe/vendor/select2/select2.min.js",
                      "~/Content/Template/fashe/vendor/slick/slick.min.js",
                      "~/Content/Template/fashe/js/slick-custom.js",
                      "~/Content/Template/fashe/vendor/countdowntime/countdowntime.js",
                      "~/Content/Template/fashe/vendor/lightbox2/js/lightbox.min.js",
                      "~/Content/Template/fashe/vendor/sweetalert/sweetalert.min.js",
                      "~/Content/Template/fashe/vendor/parallax100/parallax100.js",
                      "~/Content/Template/fashe/js/main.js"));

           
        }
    }
}
