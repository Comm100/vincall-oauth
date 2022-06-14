﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Vincall.Infrastructure
{
    public partial class VincallDBContext : DbContext, IDataProtectionKeyContext
    {
       
        public VincallDBContext(DbContextOptions<VincallDBContext> options)
            : base(options)
        {
        }
      
        public virtual DbSet<User> Users { get; set; }
        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
               
                entity.Property(e => e.Account).HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.IsAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<DataProtectionKey>(entity =>
            {
                entity.ToTable("DataProtectionKeys");

                entity.Property(e => e.Id).ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                entity.Property(e => e.FriendlyName)
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.Xml)
                .HasColumnType("nvarchar(max)");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}