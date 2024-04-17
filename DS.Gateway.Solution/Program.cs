using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.ServiceDiscovery.Providers;
using Ocelot.Values;

namespace DS.Gateway.Solution
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            
            //To Add ocelot.json file if not required then comment
           // builder.Configuration.AddJsonFile("ocelot.json");
           
            

            // app.MapGet("/", () => "Hello World!");
            builder.Services.AddAuthentication("Bearer")
              .AddJwtBearer("Bearer", options =>
              {

                  options.Authority = "https://localhost:44365/";
                  options.TokenValidationParameters = new TokenValidationParameters
                  {
                      ValidateAudience = false
                  };

              });
            builder.Services.AddOcelot(); //Added Ocelot
            var app = builder.Build();
            app.UseOcelot().Wait(); //Start Ocelot
            app.Run();

        }


    }
}