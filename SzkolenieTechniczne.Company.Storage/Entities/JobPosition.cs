using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Common.Storage.Entitites;

namespace SzkolenieTechniczne.Company.Storage.Entities
{
    [Table("JobPositions", Schema = "Company")]
    public class JobPosition : BaseEntity
    {
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        [MaxLength(256)]
        public short? WorkingHours { get; set; }
        [Required]
        public decimal GrossSalary { get; set; }
        [Required]
        public short WorkingWeekHours { get; set; }
    }
}
