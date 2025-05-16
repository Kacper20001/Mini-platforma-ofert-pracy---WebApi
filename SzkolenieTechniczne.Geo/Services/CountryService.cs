using Microsoft.EntityFrameworkCore;
using SzkoeleieTechniczne.Geo.Storage;
using SzkoeleieTechniczne.Geo.Storage.Entities;
using SzkolenieTechniczne.CommonCrossCutting.Dtos;
using SzkolenieTechniczne.Geo.CrossCutting.Dtos;
using SzkolenieTechniczne.Geo.Extensions;

namespace SzkolenieTechniczne.Geo.Services
{
    public class CountryService
    {
        private GeoDbContext _geoDbcontext;
        public CountryService(GeoDbContext geoDbcontext)
        {
            _geoDbcontext = geoDbcontext;
        }
        public async Task<CountryDto> GetById(Guid id)
        {
            var country = await _geoDbcontext
                .Set<Country>()
                .Include(x => x.Translations)
                .AsNoTracking()
                .Where(e => e.Id!.Equals(id))
                .SingleOrDefaultAsync();

            return country.ToDto();
        }
        public async Task<IEnumerable<CountryDto>> Get()
        {
            var cities = await _geoDbcontext
                .Set<Country>()
                .Include(x => x.Translations)
                .AsNoTracking()
                .Select(e => e.ToDto())
                .ToListAsync();
            return cities;
        }

        public async Task<CrudOperationResult<CountryDto>> Create(CountryDto dto)
        {
            var entity = dto.ToEntity();

            _geoDbcontext
                .Set<Country>()
                .Add(entity);

            await _geoDbcontext.SaveChangesAsync();

            var newDto = await GetById(entity.Id);

            return new CrudOperationResult<CountryDto>
            {
                Result = newDto,
                Status = CrudOperationResultStatus.Success
            };
        }
    }
}
