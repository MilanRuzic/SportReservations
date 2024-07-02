using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("SportsFacility", Schema = "Sports")]
    public class SportsFacility : BaseEntity
    {
        [Required]
        [ForeignKey(nameof(CityID))]
        public int CityID { get; set; }

        [Required]
        [StringLength(255)]
        public string Adress { get; set; } = string.Empty;

        [StringLength(255)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Precision(9, 6)]
        public decimal? Longitude { get; set; }

        [Precision(8, 6)]
        public decimal? Latitude { get; set; }

        [StringLength(255)]
        public string Email { get; set; } = string.Empty;
        public CityCodes City { get; set; }
        public ICollection<SportsField>? SportsFields { get; set; }
        public ICollection<Image>? Images { get; set; }
        public ICollection<FacilityAdministrators>? Administrators { get; set; }
    }
}
