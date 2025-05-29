using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using System.IO;
using Labs3NetUniversityApi;

namespace Labs3Net
{
    public class CustomWebApplicationFactory<TEntryPoint> : WebApplicationFactory<TEntryPoint>
        where TEntryPoint : class
    {
        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.UseSolutionRelativeContentRoot(@"..\..\..\..\..\Labs3NetUniversityApi");
            return base.CreateHost(builder);
        }
    }
}
