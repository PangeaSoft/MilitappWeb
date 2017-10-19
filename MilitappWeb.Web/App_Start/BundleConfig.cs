using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MilitappWeb.Web.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //SCRIPTS
            //jquery
            //bundles.Add(new ScriptBundle("~/mdb/js/jquery")
            //    .Include("~/Mdb/js/jquery-{version}.min.js"));

            bundles.Add(new ScriptBundle("~/Mdb/js/jquery")
                .Include("~/Mdb/js/jquery-3.1.1.min.js"));

            //Bootstrap tooltips
            bundles.Add(new ScriptBundle("~/Mdb/js/popper")
                .Include("~/Mdb/js/popper.min.js"));

            //Bootstrap core javascript
            bundles.Add(new ScriptBundle("~/Mdb/js/bootstrap")
                .Include("~/Mdb/js/bootstrap.min.js"));

            //MDB core JavaScript
            bundles.Add(new ScriptBundle("~/Mdb/js/mdbMin")
                .Include("~/Mdb/js/mdb.min.js"));

            //STYLES
            //Font Awesome
            bundles.Add(new StyleBundle("~/Mdb/css/font-awesome.min.css")
                .Include("~/Mdb/css/font-awesome.min.css"));

            //Bootstrap core CSS
            bundles.Add(new StyleBundle("~/Mdb/css/bootstrap.min.css")
                .Include("~/Mdb/css/bootstrap.min.css"));

            //Material Design Bootstrap
            bundles.Add(new StyleBundle("~/Mdb/css/mdb.min.css")
                .Include("~/Mdb/css/mdb.min.css"));

            //Custom styles (es opcional esta caca)
            bundles.Add(new StyleBundle("~/Mdb/css/style.css")
                .Include("~/Mdb/css/style.css"));

        }
    }
}