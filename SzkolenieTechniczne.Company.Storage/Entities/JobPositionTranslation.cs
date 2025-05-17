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
    [Table("JobPostionTranslations", Schema = "Company")]
    public class JobPositionTranslation : BaseTranslation
    {
        [Required]
        public JobPosition JobPosition { get; set; } = null!;

        [MaxLength(256)]
        [MinLength(2)]
        [Required]
        public string Name { get; set; } = null!;
        [MaxLength(1024)]
        public string? Responisibilities { get; set; }

        [MaxLength(1024)]
        public string Descripion { get; set; }
    }
}
