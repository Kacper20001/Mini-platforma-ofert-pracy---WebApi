using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.CommonCrossCutting.Dtos;
using SzkolenieTechniczne.CommonCrossCutting.ValidationAttributes;

namespace SzkolenieTechniczne.Geo.CrossCutting.Dtos
{
    public class CityDto
    {
        public Guid Id { get; set; }

        [LocalizedStringRequired]
        [LocalizedStringLength(64)]
        public LocalizedString Name { get; set; }

        [Required]
        public Guid CountryId { get; set; }

    }
}
