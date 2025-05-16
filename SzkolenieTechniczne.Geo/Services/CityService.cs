using Microsoft.EntityFrameworkCore;
using SzkoeleieTechniczne.Geo.Storage;
using SzkoeleieTechniczne.Geo.Storage.Entities;
using SzkolenieTechniczne.CommonCrossCutting.Dtos;
using SzkolenieTechniczne.Geo.CrossCutting.Dtos;
using SzkolenieTechniczne.Geo.Extensions;

namespace SzkolenieTechniczne.Geo.Services
{
    public class CityService
    {
        private GeoDbContext _geoDbcontext;
        public CityService(GeoDbContext geoDbcontext)
        {
            _geoDbcontext = geoDbcontext;
        }

        public async Task<CityDto> GetById(Guid id)
        {
            var city = await _geoDbcontext
                .Set<City>()
                .Include(x => x.Translations)
                .AsNoTracking()
                .Where(e => e.Id!.Equals(id))
                .SingleOrDefaultAsync();
            
            return city.ToDto();
        }
        
        public async Task<IEnumerable<CityDto>> Get()
        {
            var cities = await _geoDbcontext
                .Set<City>()
                .Include(x => x.Translations)
                .AsNoTracking()
                .Select(e => e.ToDto())
                .ToListAsync();
            
            return cities;
        }
        public async Task<CrudOperationResult<CityDto>>Create(CityDto dto)
        {
            var entity = dto.ToEntity();

            _geoDbcontext
                .Set<City>()
                .Add(entity);

            await _geoDbcontext.SaveChangesAsync();
            var newDto = await GetById(entity.Id);

            return new CrudOperationResult<CityDto>
            {
                Result = newDto,
                Status = CrudOperationResultStatus.Success
            };
        }
    }
}
