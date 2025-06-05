using SzkolenieTechniczne.Company.CrossCutting.Dtos;
using CompanyEntity = SzkolenieTechniczne.Company.Storage.Entities.Company;

namespace SzkolenieTechniczne.Company.Extensions
{
    public static class CompanyDtoExtension
    {
        public static CompanyEntity ToEntity(this CompanyDto dto)
        {
            return new CompanyEntity
            {
                Id = dto.Id,
                Name = dto.Name["pl"], 
                PhoneDirectional = dto.PhoneDirectional,
                PhoneNumber = dto.PhoneNumber,
                NIP = dto.NIP,
                REGON = dto.REGON,
                Address = dto.Address.ToEntity(),
                JobPositions = dto.JobPositions.Select(j => j.ToEntity()).ToList()
            };
        }
    }
}
