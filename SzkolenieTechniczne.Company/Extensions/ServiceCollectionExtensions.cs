using SzkolenieTechniczne.Company.Services;
using SzkolenieTechniczne.Company.Storage;

namespace SzkolenieTechniczne.Company.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCompanyServices(this IServiceCollection services)
        {
            services.AddTransient<CompanyService>();
            services.AddTransient<JobPositionService>();
            services.AddDbContext<CompanyDbContext, CompanyDbContext>();
            return services;
        }
    }
}
