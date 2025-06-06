﻿using SzkoeleieTechniczne.Geo.Storage;
using SzkolenieTechniczne.Geo.Services;

namespace SzkolenieTechniczne.Geo.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddGeoServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<CountryService>();
            serviceCollection.AddTransient<CityService>();
            serviceCollection.AddDbContext<GeoDbContext, GeoDbContext>();
            return serviceCollection;
            
        }
    }
}
