﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("SurfaceCodes", Schema = "Codes")]
    public class SurfaceCodes : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<SportsField> Fields { get; set; }
    }
}
