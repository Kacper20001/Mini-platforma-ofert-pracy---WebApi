using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Company.CrossCutting.Dtos
{
    public class CompanyAddressDto
    {
        [Required]
        public Guid CountryId { get; set; }

        [MaxLength(256)]
        public string? Post { get; set; }

        [MaxLength(256)]
        public string? Province { get; set; }

        [MaxLength(256)]
        public string? District { get; set; }

        [MaxLength(256)]
        public string? Community { get; set; }

        [Required]
        [MaxLength(256)]
        public string City { get; set; }

        [Required]
        [MaxLength(256)]
        public string Street { get; set; }

        [MaxLength(16)]
        public string FlatNumber { get; set; }

        [MaxLength(16)]
        public string HouseNumber { get; set; }

    }
}
