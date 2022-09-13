﻿// <auto-generated />
using CaseStudy3_FoodDonationManagement.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CaseStudy3_FoodDonationManagement.Migrations
{
    [DbContext(typeof(FoodDonarContext))]
    partial class FoodDonarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CaseStudy3_FoodDonationManagement.Model.SchoolModel", b =>
                {
                    b.Property<int>("StudentDonarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentDonarAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentDonarCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentDonarName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentDonarId");

                    b.ToTable("schoolDonarModels");

                    b.HasData(
                        new
                        {
                            StudentDonarId = 1,
                            StudentDonarAddress = "Najafgarh",
                            StudentDonarCity = "Delhi",
                            StudentDonarName = "hareet"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
