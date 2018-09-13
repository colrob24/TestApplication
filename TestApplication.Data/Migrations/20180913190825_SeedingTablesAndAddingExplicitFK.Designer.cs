﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApplication.Data;

namespace TestApplication.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180913190825_SeedingTablesAndAddingExplicitFK")]
    partial class SeedingTablesAndAddingExplicitFK
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestApplication.Data.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("HouseName");

                    b.Property<string>("HouseNumber");

                    b.Property<string>("Postcode");

                    b.Property<string>("StreetName");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new { Id = 1, City = "Glasgow", DateCreated = new DateTime(2018, 9, 13, 20, 8, 24, 360, DateTimeKind.Local), DateUpdated = new DateTime(2018, 9, 13, 20, 8, 24, 364, DateTimeKind.Local), HouseNumber = "16", Postcode = "G53 7HJ", StreetName = "Main Road" }
                    );
                });

            modelBuilder.Entity("TestApplication.Data.Entities.Enrolment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<int>("Status");

                    b.Property<int>("SupplyAddress_Id");

                    b.HasKey("Id");

                    b.HasIndex("SupplyAddress_Id");

                    b.ToTable("Enrolments");

                    b.HasData(
                        new { Id = 1, DateCreated = new DateTime(2018, 9, 13, 20, 8, 24, 369, DateTimeKind.Local), DateUpdated = new DateTime(2018, 9, 13, 20, 8, 24, 369, DateTimeKind.Local), Status = 0, SupplyAddress_Id = 1 }
                    );
                });

            modelBuilder.Entity("TestApplication.Data.Entities.Enrolment", b =>
                {
                    b.HasOne("TestApplication.Data.Entities.Address", "SupplyAddress")
                        .WithMany()
                        .HasForeignKey("SupplyAddress_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}