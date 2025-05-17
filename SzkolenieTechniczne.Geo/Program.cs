using Microsoft.OpenApi.Models;
using SzkolenieTechniczne.Geo.Extensions;

namespace SzkolenieTechniczne.Geo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Konfiguracja serwisów (ConfigureServices)
            builder.Services.AddGeoServices(); // ← Twoje rozszerzenie
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "SzkolenieTechniczne.Geo",
                    Version = "v1"
                });
            });

            var app = builder.Build();

            // Konfiguracja middleware (Configure)
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SzkolenieTechniczne.Geo v1");
                });
            }

            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
