﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NGTI.Models;

namespace NGTI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        // tabllen die hij gaat aanmaken in de database dbset pakt de models
        //public DbSet<Seat> Seats { get; set; }
        public DbSet<GroupReservation> GroupReservations { get; set; }
        public DbSet<SoloReservation> SoloReservations { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<GroupReservation>().HasOne(groupreservation => groupreservation.Seat).WithMany(table => table.GroupReservations);
            //modelBuilder.Entity<SoloReservation>().HasOne(soloreservation => soloreservation.Seat).WithMany(table => table.SoloReservations);
        }
        public DbSet<NGTI.Models.Team> Team { get; set; }

        // dit is voor de zekerheid dat de verbinding vast staat
    }
}
