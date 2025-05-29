using SzkoeleieTechniczne.Geo.Storage.Entities;
using SzkolenieTechniczne.Geo.CrossCutting.Dtos;

namespace SzkolenieTechniczne.Geo.Extensions
{
    public static class CityDtoExtension
    {
        public static City ToEntity(this CityDto dto)
        {
            return new City
            {
                Id = dto.Id,
                CountryId = dto.CountryId,
                Translations = dto.Name.Select(x =>
                new CityTranslation
                {
                    Id = System.Guid.NewGuid(),
                    CityId = dto.Id,
                    LanguageCode = x.Key,
                    Name = x.Value
                }
                ).ToList()
            };
        }
    }
}
