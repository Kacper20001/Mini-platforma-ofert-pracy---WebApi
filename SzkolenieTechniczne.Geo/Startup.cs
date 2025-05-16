using Microsoft.OpenApi.Models;
using SzkolenieTechniczne.Geo.Extensions;

namespace SzkolenieTechniczne.Geo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Dodaje wszystkie potrzebne serwisy do kontenera
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGeoServices();        
            services.AddControllers();        
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SzkolenieTechniczne.Geo", Version = "v1" });
            });
        }

        // Tu konfiguruje pipeline HTTP (kolejność ma znaczenie!)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SzkolenieTechniczne.Geo v1"));
            }

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
