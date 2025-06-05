using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne.Common.Storage.Entitites;

namespace SzkolenieTechniczne.Company.Storage.Entities
{
    [Table("CompanyTranslations", Schema = "Company")]
    public class CompanyTranslation : BaseTranslation
    {
        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
