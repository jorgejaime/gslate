using System;
using Jorge.Gslate.Model.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Jorge.Gslate.Model.Context
{
    public partial class ProjectContext : DbContext
    {

        public virtual DbSet<Project> Project { get; set; }
     

        public ProjectContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           


            modelBuilder.Entity<Project>(entity =>
            {

                entity.Property(e => e.AppointmentDate)
                    .IsRequired()
                    .HasColumnType("datetime");

            });

           
        }
    }
}
