namespace Fitnesspro.Models.DbContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FitnessproDbContext : DbContext
    {
        public FitnessproDbContext()
            : base("name=FitnessproDbContext")
        {
        }

        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceType>()
                .HasMany(e => e.Entities)
                .WithOptional(e => e.ServiceType)
                .HasForeignKey(e => e.ServiceType_ServiceTypeId);
        }
    }
}
