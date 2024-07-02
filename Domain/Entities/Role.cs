using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    [Table("Role", Schema = "Auth")]
    public class Role : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; } = string.Empty;

        [InverseProperty(nameof(UserRoles.Role))]
        public ICollection<UserRoles> Users { get; set; }
    }
}
