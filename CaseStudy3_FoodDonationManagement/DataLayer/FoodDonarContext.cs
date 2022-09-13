using CaseStudy3_FoodDonationManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy3_FoodDonationManagement.DataLayer
{
    public class FoodDonarContext : DbContext
    {
        public FoodDonarContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SchoolModel> schoolDonarModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolModel>().HasData(
                new SchoolModel
                {
                   StudentDonarId = 1,
                   StudentDonarName= "hareet",
                   StudentDonarCity = "Delhi",
                    StudentDonarAddress = "Najafgarh"
                }
                );
        }
    }
}
