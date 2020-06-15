using System;
using System.Collections.Generic;
using System.Text;
using CostManagementAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<EditionType> EditionTypes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<RoyaltyType> RoyaltyTypes { get; set; }
        public DbSet<SalesType> SalesTypes { get; set; }
        public DbSet<Imprint> Imprint { get; set; }
        public DbSet<RoyaltyTemplate> RoyaltyTemplates { get; set; }
        public DbSet<SalesTemplates> SalesTemplates { get; set; }
        public DbSet<CostTemplete> CostTempletes { get; set; }

    }
}
