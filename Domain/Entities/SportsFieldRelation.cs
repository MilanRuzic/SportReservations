using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("SportsFieldRelation", Schema = "Sports")]
    public class SportsFieldRelation : BaseEntity
    {
        [ForeignKey(nameof(SportsFieldID))]
        public int SportsFieldID { get; set; }

        [ForeignKey(nameof(SportID))]
        public int SportID { get; set; }
        public SportsField SportsField { get; set; }
        public SportCodes SportCodes { get; set; }
    }
}
