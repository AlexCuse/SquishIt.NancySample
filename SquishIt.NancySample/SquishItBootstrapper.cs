using Nancy;
using SquishIt.Framework;

namespace SquishIt.NancySample
{
    public class SquishItBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            Bundle.JavaScript()
                .Add("~/Content/js/js1.js")
                .Add("~/Content/js/js2.js")
                .AsCached("hello", "~/assets/js/hello");
        }
    }
}