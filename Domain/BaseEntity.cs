using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Domain.Entities;

namespace Domain;

public class BaseEntity : IDelete
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    [Column("ID", Order = 1)]
    public int ID { get; set; }
    public int? CreatedByID { get; set; }
    public int? DeletedByID { get; set; }
    public int? ModifiedByID { get; set; }

    [JsonIgnore]
    public DateTime? CreatedDate { get; set; }

    [JsonIgnore]
    public DateTime? ModifiedDate { get; set; }

    [JsonIgnore]
    public DateTime? DeletedDate { get; set; }

    [Required]
    public bool Active { get; set; }

    [ForeignKey(nameof(CreatedByID))]
    public User? CreatedBy { get; set; }

    [ForeignKey(nameof(DeletedByID))]
    public User? DeletedBy { get; set; }

    [ForeignKey(nameof(ModifiedByID))]
    public User? ModifiedBy { get; set; }
}

public interface IDelete
{
    public DateTime? DeletedDate { get; set; }

    public bool Active { get; set; }
}
