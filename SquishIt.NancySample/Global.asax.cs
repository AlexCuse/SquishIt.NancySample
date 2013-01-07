using System;
using SquishIt.Framework;

namespace SquishIt.NancySample
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Bundle.JavaScript()
                .Add("~/Content/js/js1.js")
                .Add("~/Content/js/js2.js")
                .ForceRelease() //need this to avoid serving tags instead of content
                .AsCached("hello", "~/assets/js/hello");
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}