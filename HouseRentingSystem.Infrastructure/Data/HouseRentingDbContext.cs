﻿using HouseRentingSystem.Infrastructure.Data.Models;
using HouseRentingSystem.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data
{
    public class HouseRentingDbContext : IdentityDbContext
    {
        public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<House>()
              .HasOne(h => h.Category)
              .WithMany(c => c.Houses)
              .HasForeignKey(h => h.CategoryId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<House>()
              .HasOne(h => h.Agent)
              .WithMany(a => a.Houses)
              .HasForeignKey(h => h.AgentId)
              .OnDelete(DeleteBehavior.Restrict);





            //builder.ApplyConfiguration(new UserConfiguration());
            //builder.ApplyConfiguration(new CategoryConfiguration());
            //builder.ApplyConfiguration(new AgentConfiguration());
            //builder.ApplyConfiguration(new HouseConfiguration());


            base.OnModelCreating(builder);
        }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<House> Houses { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
