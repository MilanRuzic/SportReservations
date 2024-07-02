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
    [Table("CountryCodes", Schema = "Codes")]
    public class CountryCodes : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [DeleteBehavior(DeleteBehavior.Cascade)]
        public ICollection<CityCodes> Cities { get; set; }
    }
}
