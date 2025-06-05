﻿using SzkolenieTechniczne.Company.CrossCutting.Dtos;
using SzkolenieTechniczne.Company.Storage.Entities;

namespace SzkolenieTechniczne.Company.Extensions
{
    public static class JobPositionExtension
    {
        public static JobPositionDto ToDto(this JobPosition entity)
        {
            return new JobPositionDto
            {
                Id = entity.Id,
                CompanyId = entity.CompanyId,
                WorkingHours = entity.WorkingHours,
                GrossSalary = entity.GrossSalary,
                WorkingWeekHours = entity.WorkingWeekHours
            };
        }
    }
}
