using System;
using System.Collections.Generic;
using Application.Common.Interfaces;
using Domain;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Persistence.Helpers;

namespace Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserRoles> UserRoles { get; set; }
        DbSet<CityCodes> CityCodes { get; set; }
        DbSet<CountryCodes> CountryCodes { get; set; }
        DbSet<SportCodes> SportCodes { get; set; }
        DbSet<SurfaceCodes> SurfaceCodes { get; set; }
        DbSet<SportsFacility> SportsFacility { get; set; }
        DbSet<SportsField> SportsField { get; set; }
        DbSet<SportsFieldRelation> FieldSports { get; set; }
        DbSet<Image> Image { get; set; }
        DbSet<FacilityAdministrators> FacilityAdministrators { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker
                .Entries()
                .Where(x =>
                    x.Entity is BaseEntity
                    && (
                        x.State == EntityState.Added
                        || x.State == EntityState.Modified
                        || x.State == EntityState.Deleted
                    )
                );

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedDate = DateTime.UtcNow;
                }
                if (entity.State == EntityState.Modified)
                {
                    ((BaseEntity)entity.Entity).ModifiedDate = DateTime.UtcNow;
                }
                if (entity.State == EntityState.Deleted && entity.Entity is IDelete delete)
                {
                    delete.DeletedDate = DateTime.UtcNow;
                    delete.Active = false;
                    entity.State = EntityState.Modified;
                }
            }
        }
    }
}
