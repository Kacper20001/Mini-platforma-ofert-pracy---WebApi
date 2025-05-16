using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkoeleieTechniczne.Geo.Storage.Entities
{
    [Table("Cities", Schema = "Geo")]
    public class City
    {
        [Required]
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<CityTranslation> Translations { get; set; }
    }
}
