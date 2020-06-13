﻿using System;
using System.Collections.Generic;
using System.Text;
using CostManagementAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CostManagementAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<User> User {get; set; }
        public DbSet<EditionType> EditionTypes { get; set; }
        // public DbSet<Material> Materials { get; set; }
        // public DbSet<RoyaltyType> RoyaltyTypes { get; set; }
        // public DbSet<SalesType> SalesTypes { get; set; }
        // public DbSet<Imprint> Imprints { get; set; }
        // public DbSet<RoyaltyTemplate> RoyaltyTemplates { get; set; }
    }
}
