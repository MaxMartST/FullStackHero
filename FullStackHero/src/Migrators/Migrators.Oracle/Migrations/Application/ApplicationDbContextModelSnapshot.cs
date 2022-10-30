﻿// <auto-generated />
using FullStackHero.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using System;

#nullable disable

namespace Migrators.Oracle.Migrations.Application;
[DbContext(typeof(ApplicationDbContext))]
partial class ApplicationDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasDefaultSchema("CATALOG")
            .HasAnnotation("ProductVersion", "6.0.1")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

        modelBuilder.Entity("FullStackHero.Domain.Catalog.Brand", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("RAW(16)");

                b.Property<Guid>("CreatedBy")
                    .HasColumnType("RAW(16)");

                b.Property<DateTime>("CreatedOn")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<Guid?>("DeletedBy")
                    .HasColumnType("RAW(16)");

                b.Property<DateTime?>("DeletedOn")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<string>("Description")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<Guid>("LastModifiedBy")
                    .HasColumnType("RAW(16)");

                b.Property<DateTime?>("LastModifiedOn")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnType("NVARCHAR2(256)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.HasKey("Id");

                b.ToTable("Brands", "CATALOG");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("FullStackHero.Domain.Catalog.Product", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("RAW(16)");

                b.Property<Guid>("BrandId")
                    .HasColumnType("RAW(16)");

                b.Property<Guid>("CreatedBy")
                    .HasColumnType("RAW(16)");

                b.Property<DateTime>("CreatedOn")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<Guid?>("DeletedBy")
                    .HasColumnType("RAW(16)");

                b.Property<DateTime?>("DeletedOn")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<string>("Description")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("ImagePath")
                    .HasMaxLength(2048)
                    .HasColumnType("NCLOB");

                b.Property<Guid>("LastModifiedBy")
                    .HasColumnType("RAW(16)");

                b.Property<DateTime?>("LastModifiedOn")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasColumnType("NVARCHAR2(1024)");

                b.Property<decimal>("Rate")
                    .HasColumnType("DECIMAL(18, 2)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.HasKey("Id");

                b.HasIndex("BrandId");

                b.ToTable("Products", "CATALOG");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("FullStackHero.Infrastructure.Auditing.Trail", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("RAW(16)");

                b.Property<string>("AffectedColumns")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<DateTime>("DateTime")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<string>("NewValues")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("OldValues")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("PrimaryKey")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("TableName")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.Property<string>("Type")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<Guid>("UserId")
                    .HasColumnType("RAW(16)");

                b.HasKey("Id");

                b.ToTable("AuditTrails", "AUDITING");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("FullStackHero.Infrastructure.Identity.ApplicationRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("Description")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("Name")
                    .HasMaxLength(256)
                    .HasColumnType("NVARCHAR2(256)");

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("NVARCHAR2(256)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.HasKey("Id");

                b.HasIndex("NormalizedName", "TenantId")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex")
                    .HasFilter("\"NormalizedName\" IS NOT NULL");

                b.ToTable("Roles", "IDENTITY");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("FullStackHero.Infrastructure.Identity.ApplicationRoleClaim", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("NUMBER(10)");

                OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("ClaimType")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("CreatedBy")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<DateTime>("CreatedOn")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<string>("Description")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("Group")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("LastModifiedBy")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<DateTime?>("LastModifiedOn")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("RoleClaims", "IDENTITY");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("FullStackHero.Infrastructure.Identity.ApplicationUser", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("NUMBER(10)");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("NVARCHAR2(256)");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("NUMBER(1)");

                b.Property<string>("FirstName")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("ImageUrl")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<bool>("IsActive")
                    .HasColumnType("NUMBER(1)");

                b.Property<string>("LastName")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("NUMBER(1)");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("TIMESTAMP(7) WITH TIME ZONE");

                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("NVARCHAR2(256)");

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("NVARCHAR2(256)");

                b.Property<string>("ObjectId")
                    .HasMaxLength(256)
                    .HasColumnType("NVARCHAR2(256)");

                b.Property<string>("PasswordHash")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("NUMBER(1)");

                b.Property<string>("RefreshToken")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<DateTime>("RefreshTokenExpiryTime")
                    .HasColumnType("TIMESTAMP(7)");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("NUMBER(1)");

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("NVARCHAR2(256)");

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName", "TenantId")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex")
                    .HasFilter("\"NormalizedUserName\" IS NOT NULL");

                b.ToTable("Users", "IDENTITY");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("NUMBER(10)");

                OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                b.Property<string>("ClaimType")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("ClaimValue")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("NVARCHAR2(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("UserClaims", "IDENTITY");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("LoginProvider")
                    .IsRequired()
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("ProviderKey")
                    .IsRequired()
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("NVARCHAR2(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("LoginProvider", "ProviderKey", "TenantId")
                    .IsUnique();

                b.ToTable("UserLogins", "IDENTITY");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("RoleId")
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("UserRoles", "IDENTITY");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("LoginProvider")
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("Name")
                    .HasColumnType("NVARCHAR2(450)");

                b.Property<string>("TenantId")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("NVARCHAR2(64)");

                b.Property<string>("Value")
                    .HasColumnType("NVARCHAR2(2000)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("UserTokens", "IDENTITY");

                b.HasAnnotation("Finbuckle:MultiTenant", true);
            });

        modelBuilder.Entity("FullStackHero.Domain.Catalog.Product", b =>
            {
                b.HasOne("FullStackHero.Domain.Catalog.Brand", "Brand")
                    .WithMany()
                    .HasForeignKey("BrandId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Brand");
            });

        modelBuilder.Entity("FullStackHero.Infrastructure.Identity.ApplicationRoleClaim", b =>
            {
                b.HasOne("FullStackHero.Infrastructure.Identity.ApplicationRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.HasOne("FullStackHero.Infrastructure.Identity.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("FullStackHero.Infrastructure.Identity.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.HasOne("FullStackHero.Infrastructure.Identity.ApplicationRole", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FullStackHero.Infrastructure.Identity.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("FullStackHero.Infrastructure.Identity.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });
#pragma warning restore 612, 618
    }
}
