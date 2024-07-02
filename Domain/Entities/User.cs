using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("User", Schema = "Auth")]
public class User : BaseEntity
{
    [Required]
    [StringLength(255)]
    public string UserName { get; set; } = string.Empty;

    [Required]
    [StringLength(255)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(255)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [StringLength(255)]
    public string Email { get; set; } = string.Empty;

    [JsonIgnore]
    [StringLength(255)]
    public string Password { get; set; } = string.Empty;

    [StringLength(255)]
    public string PhoneNumber { get; set; }

    [StringLength(255)]
    public string Adress { get; set; }

    [NotMapped]
    [JsonIgnore]
    [InverseProperty(nameof(FacilityAdministrators.User))]
    public virtual ICollection<FacilityAdministrators> Facilities { get; set; }

    [InverseProperty(nameof(UserRoles.User))]
    public virtual ICollection<UserRoles> Roles { get; set; }

    #region CityCodes
    [InverseProperty(nameof(CityCodes.CreatedBy))]
    public virtual ICollection<CityCodes> CityCodesCreatedBy { get; set; }

    [InverseProperty(nameof(CityCodes.DeletedBy))]
    public virtual ICollection<CityCodes> CityCodesDeletedBy { get; set; }

    [InverseProperty(nameof(CityCodes.ModifiedBy))]
    public virtual ICollection<CityCodes> CityCodesModifiedBy { get; set; }
    #endregion
    #region CountryCodes
    [InverseProperty(nameof(CountryCodes.CreatedBy))]
    public virtual ICollection<CountryCodes> CountryCodesCreatedBy { get; set; }

    [InverseProperty(nameof(CountryCodes.DeletedBy))]
    public virtual ICollection<CountryCodes> CountryCodesDeletedBy { get; set; }

    [InverseProperty(nameof(CountryCodes.ModifiedBy))]
    public virtual ICollection<CountryCodes> CountryCodesModifiedBy { get; set; }
    #endregion
    #region FacilityAdministrators
    [InverseProperty(nameof(FacilityAdministrators.CreatedBy))]
    public virtual ICollection<FacilityAdministrators> FacilityAdministratorsCreatedBy { get; set; }

    [InverseProperty(nameof(FacilityAdministrators.DeletedBy))]
    public virtual ICollection<FacilityAdministrators> FacilityAdministratorsDeletedBy { get; set; }

    [InverseProperty(nameof(FacilityAdministrators.ModifiedBy))]
    public virtual ICollection<FacilityAdministrators> FacilityAdministratorsModifiedBy { get; set; }
    #endregion
    #region FieldSports
    [InverseProperty(nameof(SportsFieldRelation.CreatedBy))]
    public virtual ICollection<SportsFieldRelation> FieldSportsCreatedBy { get; set; }

    [InverseProperty(nameof(SportsFieldRelation.DeletedBy))]
    public virtual ICollection<SportsFieldRelation> FieldSportsDeletedBy { get; set; }

    [InverseProperty(nameof(SportsFieldRelation.ModifiedBy))]
    public virtual ICollection<SportsFieldRelation> FieldSportsModifiedBy { get; set; }
    #endregion
    #region Image
    [InverseProperty(nameof(Image.CreatedBy))]
    public virtual ICollection<Image> ImageCreatedBy { get; set; }

    [InverseProperty(nameof(Image.DeletedBy))]
    public virtual ICollection<Image> ImageDeletedBy { get; set; }

    [InverseProperty(nameof(Image.ModifiedBy))]
    public virtual ICollection<Image> ImageModifiedBy { get; set; }
    #endregion
    #region Role
    [InverseProperty(nameof(Role.CreatedBy))]
    public virtual ICollection<Role> RoleCreatedBy { get; set; }

    [InverseProperty(nameof(Role.DeletedBy))]
    public virtual ICollection<Role> RoleDeletedBy { get; set; }

    [InverseProperty(nameof(Role.ModifiedBy))]
    public virtual ICollection<Role> RoleModifiedBy { get; set; }
    #endregion
    #region SportCodes
    [InverseProperty(nameof(SportCodes.CreatedBy))]
    public virtual ICollection<SportCodes> SportCodesCreatedBy { get; set; }

    [InverseProperty(nameof(SportCodes.DeletedBy))]
    public virtual ICollection<SportCodes> SportCodesDeletedBy { get; set; }

    [InverseProperty(nameof(SportCodes.ModifiedBy))]
    public virtual ICollection<SportCodes> SportCodesModifiedBy { get; set; }
    #endregion
    #region SportsFacility
    [InverseProperty(nameof(SportsFacility.CreatedBy))]
    public virtual ICollection<SportsFacility> SportsFacilityCreatedBy { get; set; }

    [InverseProperty(nameof(SportsFacility.DeletedBy))]
    public virtual ICollection<SportsFacility> SportsFacilityDeletedBy { get; set; }

    [InverseProperty(nameof(SportsFacility.ModifiedBy))]
    public virtual ICollection<SportsFacility> SportsFacilityModifiedBy { get; set; }
    #endregion
    #region SportsField
    [InverseProperty(nameof(SportsField.CreatedBy))]
    public virtual ICollection<SportsField> SportsFieldCreatedBy { get; set; }

    [InverseProperty(nameof(SportsField.DeletedBy))]
    public virtual ICollection<SportsField> SportsFieldDeletedBy { get; set; }

    [InverseProperty(nameof(SportsField.ModifiedBy))]
    public virtual ICollection<SportsField> SportsFieldModifiedBy { get; set; }
    #endregion
    #region SurfaceCodes
    [InverseProperty(nameof(SurfaceCodes.CreatedBy))]
    public virtual ICollection<SurfaceCodes> SurfaceCodesCreatedBy { get; set; }

    [InverseProperty(nameof(SurfaceCodes.DeletedBy))]
    public virtual ICollection<SurfaceCodes> SurfaceCodesDeletedBy { get; set; }

    [InverseProperty(nameof(SurfaceCodes.ModifiedBy))]
    public virtual ICollection<SurfaceCodes> SurfaceCodesModifiedBy { get; set; }
    #endregion
    #region User
    [InverseProperty(nameof(User.CreatedBy))]
    public virtual ICollection<User> UserCreatedBy { get; set; }

    [InverseProperty(nameof(User.DeletedBy))]
    public virtual ICollection<User> UserDeletedBy { get; set; }

    [InverseProperty(nameof(User.ModifiedBy))]
    public virtual ICollection<User> UserModifiedBy { get; set; }
    #endregion
    #region UserRoles
    [InverseProperty(nameof(UserRoles.CreatedBy))]
    public virtual ICollection<UserRoles> UserRolesCreatedBy { get; set; }

    [InverseProperty(nameof(UserRoles.DeletedBy))]
    public virtual ICollection<UserRoles> UserRolesDeletedBy { get; set; }

    [InverseProperty(nameof(UserRoles.ModifiedBy))]
    public virtual ICollection<UserRoles> UserRolesModifiedBy { get; set; }
    #endregion
}
