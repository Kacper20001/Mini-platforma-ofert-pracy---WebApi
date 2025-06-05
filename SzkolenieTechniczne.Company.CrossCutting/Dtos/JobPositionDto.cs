using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.Company.CrossCutting.Dtos
{
    public class JobPositionDto
    {
        public Guid Id { get; set; }

        [Required]
        public Guid CompanyId { get; set; }

        public short? WorkingHours { get; set; }

        [Required]
        public decimal GrossSalary { get; set; }

        [Required]
        public short WorkingWeekHours { get; set; }
    }
}
