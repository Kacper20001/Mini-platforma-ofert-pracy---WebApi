using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.CommonCrossCutting.Dtos;
using SzkolenieTechniczne.CommonCrossCutting.ValidationAttributes;

namespace SzkolenieTechniczne.Company.CrossCutting.Dtos
{
    public class CompanyDto
    {
        public Guid Id { get; set; }
        [LocalizedStringRequired]
        [LocalizedStringLength(256)]
        public LocalizedString Name { get; set; }

        [MaxLength(8)]
        public string? PhoneDirectional { get; set; }
        public SecureString? PhoneNumber { get; set; }
        [MaxLength(32)]
        public string? NIP { get; set; }
        [MaxLength(16)]
        public string? REGON { get; set; }
        [Required]
        public CompanyAddressDto Address { get; set; }
        public List<JobPositionDto> JobPositions { get; set; } = new();


    }
}
