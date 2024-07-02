using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("CityCodes", Schema = "Codes")]
    public class CityCodes : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [ForeignKey(nameof(CountryID))]
        public int CountryID { get; set; }
        public CountryCodes Country { get; set; }
        public ICollection<SportsFacility> Facilities { get; set; }
        public ICollection<SportsField> Fields { get; set; }
    }
}
