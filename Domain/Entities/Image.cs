using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Image", Schema = "Sports")]
    public class Image : BaseEntity
    {
        [ForeignKey(nameof(SportsFacilityID))]
        public int? SportsFacilityID { get; set; }

        [ForeignKey(nameof(SportsFieldID))]
        public int? SportsFieldID { get; set; }

        [Required]
        [StringLength(500)]
        public string Path { get; set; }
        public SportsFacility SportsFacility { get; set; }
        public SportsField SportsField { get; set; }
    }
}
