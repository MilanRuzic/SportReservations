using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("SportsField", Schema = "Sports")]
    public class SportsField : BaseEntity
    {
        [Required]
        [ForeignKey(nameof(SportsFacilityID))]
        public int SportsFacilityID { get; set; }

        [Required]
        [ForeignKey(nameof(SurfaceID))]
        public int SurfaceID { get; set; }

        [Required]
        [ForeignKey(nameof(CityID))]
        public int CityID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Adress { get; set; }

        [Precision(9, 6)]
        public decimal Longitude { get; set; }

        [Precision(8, 6)]
        public decimal Latitude { get; set; }

        public SportsFacility SportsFacility { get; set; }
        public SurfaceCodes Surface { get; set; }
        public CityCodes City { get; set; }
        public ICollection<SportsFieldRelation> Sports { get; set; }
        public ICollection<Image>? Images { get; set; }
    }
}
