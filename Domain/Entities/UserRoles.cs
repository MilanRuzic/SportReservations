using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("UserRoles", Schema = "Auth")]
    public class UserRoles : BaseEntity
    {
        [ForeignKey(nameof(UserID))]
        public int UserID { get; set; }

        [ForeignKey(nameof(RoleID))]
        public int RoleID { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
