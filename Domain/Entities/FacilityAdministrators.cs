using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("FacilityAdministrators", Schema = "Sports")]
    public class FacilityAdministrators : BaseEntity
    {
        [ForeignKey(nameof(SportsFacilityID))]
        public int SportsFacilityID { get; set; }

        [ForeignKey(nameof(UserID))]
        public int UserID { get; set; }
        public User User { get; set; }
        public SportsFacility SportsFacility { get; set; }
    }
}
