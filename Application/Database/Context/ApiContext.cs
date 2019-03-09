using DataEntities.Core;
using DataEntities.Entities;
using DataEntities.HelperField;
using Microsoft.EntityFrameworkCore;
using SharedObjects;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<ProService> ProServices { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<StartUp> StartUps { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema: ConstantDto.SchemaName);
            modelBuilder.Entity<ProService>();
            modelBuilder.Entity<User>();
            modelBuilder.Entity<StartUp>();

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            Audit();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            Audit();
            return await base.SaveChangesAsync();
        }

        private void Audit()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is HelperFields && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((HelperFields)entry.Entity).CreatedOn = DateTime.UtcNow;
                }
                ((HelperFields)entry.Entity).ModifiedOn = DateTime.UtcNow;
            }
        }
    }
}
