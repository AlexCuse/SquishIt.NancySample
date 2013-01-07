using Nancy;
using SquishIt.Framework;

namespace SquishIt.NancySample.Modules
{
    public class AssetsModule : NancyModule
    {
        public AssetsModule()
            : base("/assets")
        {
            Get["/js/{name}"] = parameters => Bundle.JavaScript().RenderCached((string)parameters.name);
            Get["/css/{name}"] = parameters => Bundle.Css().RenderCached((string)parameters.name);
        }
    }
}