﻿// <auto-generated />
using System;
using Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Database.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20190306163444_UserStartUPLinked")]
    partial class UserStartUPLinked
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("MoinPersonal")
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataEntities.Core.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("Country");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Currency");

                    b.Property<string>("Email");

                    b.Property<Guid>("ExternalID");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDraft");

                    b.Property<string>("LastName");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("State");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataEntities.Entities.ProService", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<Guid>("ExternalID");

                    b.Property<string>("ImagePath");

                    b.Property<bool>("IsDraft");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<double>("Rating");

                    b.HasKey("Id");

                    b.ToTable("ProServices");
                });

            modelBuilder.Entity("DataEntities.Entities.StartUp", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("CurrentStage");

                    b.Property<Guid>("ExternalID");

                    b.Property<string>("ExtraMessage");

                    b.Property<int>("GetToKnow");

                    b.Property<string>("InvestmentRequired");

                    b.Property<bool>("IsDraft");

                    b.Property<int?>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Sector");

                    b.Property<string>("SubSector");

                    b.Property<long?>("UserId");

                    b.Property<string>("VentureName");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("StartUps");
                });

            modelBuilder.Entity("DataEntities.Entities.StartUp", b =>
                {
                    b.HasOne("DataEntities.Core.User", "User")
                        .WithMany("StartUps")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
