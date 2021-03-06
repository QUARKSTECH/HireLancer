﻿using DataEntities.ERPEntities;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        #region ERP
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        #endregion ERP
    }
}
