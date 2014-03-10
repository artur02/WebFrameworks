using System;
using System;
using Owin;

namespace HeliosSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            // Requires Windows 8 or Windows Server 2012
            app.Run(async context =>
            {
                context.Response.ContentType = "text/plain";

                await context.Response.WriteAsync("Assemblies in AppDomain:" + Environment.NewLine);
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    await context.Response.WriteAsync(asm.FullName + Environment.NewLine);
                }
                await context.Response.WriteAsync(Environment.NewLine);

                await context.Response.WriteAsync("Stack trace:" + Environment.NewLine);
                await context.Response.WriteAsync(Environment.StackTrace);
            });
        }
    }
}