using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using SzkolenieTechniczne.CommonCrossCutting.Interfaces;


namespace SzkolenieTechniczne.Common.Storage.Entitites
{
    [Index(nameof(LanguageCode), IsUnique = false)]
    public class BaseTranslation : BaseEntity, IEntityTranslation

    {
        [MaxLength(16)]
        [Required]
        public string LanguageCode { get; set; }
    }
}
