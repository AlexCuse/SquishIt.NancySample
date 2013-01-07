using System.IO;
using System.Text;
using Nancy;
using SquishIt.Framework;

namespace SquishIt.NancySample.Modules
{
    public class AssetsModule : NancyModule
    {
        public AssetsModule()
            : base("/assets")
        {
            Get["/js/{name}"] = parameters => CreateResponse(Bundle.JavaScript().RenderCached((string)parameters.name), "text/javascript");
            Get["/css/{name}"] = parameters => CreateResponse(Bundle.Css().RenderCached((string)parameters.name), "text/css");
        }

        Response CreateResponse(string content, string contentType)
        {
            return Response
                .FromStream(() => new MemoryStream(Encoding.UTF8.GetBytes(content)), contentType)
                .WithHeader("Cache-Control", "max-age=45");
        }
    }
}