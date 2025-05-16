using SzkoeleieTechniczne.Geo.Storage.Entities;
using SzkolenieTechniczne.CommonCrossCutting.Dtos;
using SzkolenieTechniczne.Geo.CrossCutting.Dtos;

namespace SzkolenieTechniczne.Geo.Extensions
{
    public static class CityExtension
    {
        public static CityDto ToDto(this City entity)
        {
            var result = new CityDto
            {
                Id = entity.Id,
                Name = new LocalizedString(entity.Translations.Select(t => new KeyValuePair<string, string>(t.LanguageCode, t.Name))),
                CountryId = entity.CountryId
            };

            return result;
        }
    }
}
