﻿using System.Web;
using System.Web.Optimization;

namespace Tp8.Web.MVC.StarsWars
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Plugin/css").Include(
                      "~/Content/DataTable/CSS/jquery.dataTables.min.css",
                      "~/Content/fontawesome-free/css/all.css",
                      "~/Content/DataTable/CSS/buttons.dataTables.min.css"));

            bundles.Add(new StyleBundle("~/Content/Plugin/js").Include(
                      "~/Content/DataTable/JS/jquery.dataTables.min.js",
                      "~/Content/fontawesome-free/js/all.js",
                      "~/Content/DataTable/JS/dataTables.buttons.js"));
        }
    }
}
