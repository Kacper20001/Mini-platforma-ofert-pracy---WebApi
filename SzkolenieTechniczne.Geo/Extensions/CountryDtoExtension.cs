using SzkoeleieTechniczne.Geo.Storage.Entities;
using SzkolenieTechniczne.Geo.CrossCutting.Dtos;

namespace SzkolenieTechniczne.Geo.Extensions
{
    public static class CountryDtoExtension
    {
        public static Country ToEntity(this CountryDto dto)
        {
            return new Country
            {
                Id = dto.Id,
                Alpha3Code = dto.Alpha3Code,
                Translations = dto.Name.Select(x =>
                new CountryTranslation
                {
                    Id = System.Guid.NewGuid(),
                    CountryId = dto.Id,
                    LanguageCode = x.Key,
                    Name = x.Value
                }
                ).ToList()
            };
        }
    }
}
