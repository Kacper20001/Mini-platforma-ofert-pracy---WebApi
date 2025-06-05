using SzkolenieTechniczne.Company.CrossCutting.Dtos;
using SzkolenieTechniczne.Company.Storage.Entities;

namespace SzkolenieTechniczne.Company.Extensions
{
    public static class JobPositionDtoExtension
    {
        public static JobPosition ToEntity(this JobPositionDto dto)
        {
            return new JobPosition
            {
                Id = dto.Id,
                CompanyId = dto.CompanyId,
                GrossSalary = dto.GrossSalary,
                WorkingWeekHours = dto.WorkingWeekHours,
                WorkingHours = dto.WorkingHours
            };
        }
    }
}
