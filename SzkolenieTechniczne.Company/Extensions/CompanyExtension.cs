using SzkolenieTechniczne.Company.CrossCutting.Dtos;
using SzkolenieTechniczne.Company.Storage.Entities;
using SzkolenieTechniczne.CommonCrossCutting.Dtos;
using CompanyEntity = SzkolenieTechniczne.Company.Storage.Entities.Company;



namespace SzkolenieTechniczne.Company.Extensions
{
    public static class CompanyExtension
    {
        public static CompanyDto ToDto(this CompanyEntity entity)
        {
            return new CompanyDto
            {
                Id = entity.Id,
                Name = new LocalizedString{{ "pl", entity.Name }},
                PhoneDirectional = entity.PhoneDirectional,
                PhoneNumber = entity.PhoneNumber,
                NIP = entity.NIP,
                REGON = entity.REGON,
                Address = entity.Address?.ToDto(),
                JobPositions = entity.JobPositions?.Select(j => j.ToDto()).ToList() ?? new()
            };
        }
    }
}
