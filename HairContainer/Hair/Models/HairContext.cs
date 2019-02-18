﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hair.Models
{
    public partial class HairContext : DbContext
    {
        public HairContext()
        {
        }

        public HairContext(DbContextOptions<HairContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentDetail> AppointmentDetail { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Hair;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("appointment");

                entity.Property(e => e.AppointmentId).HasColumnName("appointmentId");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("appointmentDate")
                    .HasColumnType("date");

                entity.Property(e => e.Completed).HasColumnName("completed");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.FinalTotal).HasColumnName("finalTotal");

                entity.Property(e => e.ProcedureMinutes).HasColumnName("procedureMinutes");

                entity.Property(e => e.ScheduledEndTime).HasColumnName("scheduledEndTime");

                entity.Property(e => e.ScheduledStartTime).HasColumnName("scheduledStartTime");

                entity.Property(e => e.StaffId).HasColumnName("staffId");

                entity.Property(e => e.TaxRate).HasColumnName("taxRate");

                entity.Property(e => e.TotalBeforeTax).HasColumnName("totalBeforeTax");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_appointment_customer");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_appointment_staff");
            });

            modelBuilder.Entity<AppointmentDetail>(entity =>
            {
                entity.ToTable("appointmentDetail");

                entity.Property(e => e.AppointmentDetailId).HasColumnName("appointmentDetailId");

                entity.Property(e => e.AppointmentId).HasColumnName("appointmentId");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.ProcedureMinutes).HasColumnName("procedureMinutes");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RetailPrice).HasColumnName("retailPrice");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentDetail)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_appointmentDetail_appointment");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.AppointmentDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_appointmentDetail_product");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.CanAdvertiseOnline).HasColumnName("canAdvertiseOnline");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postalCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreferredStylist)
                    .HasColumnName("preferredStylist")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasColumnName("streetAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.IsProcedure).HasColumnName("isProcedure");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureMinutes).HasColumnName("procedureMinutes");

                entity.Property(e => e.RetailPrice).HasColumnName("retailPrice");

                entity.Property(e => e.WholesalePrice).HasColumnName("wholesalePrice");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("staff");

                entity.Property(e => e.StaffId).HasColumnName("staffId");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.DateHired)
                    .HasColumnName("dateHired")
                    .HasColumnType("date");

                entity.Property(e => e.DateTerminated)
                    .HasColumnName("dateTerminated")
                    .HasColumnType("date");

                entity.Property(e => e.HourlyChargeoutRate).HasColumnName("hourlyChargeoutRate");

                entity.Property(e => e.HourlySalary).HasColumnName("hourlySalary");

                entity.Property(e => e.IsStylist).HasColumnName("isStylist");

                entity.Property(e => e.ReasonForTermination)
                    .HasColumnName("reasonForTermination")
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_staff_customer");
            });
        }
    }
}
