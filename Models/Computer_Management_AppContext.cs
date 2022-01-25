using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Computer_Management_App.Models
{
    public partial class Computer_Management_AppContext : DbContext
    {
        public Computer_Management_AppContext()
        {
        }

        public Computer_Management_AppContext(DbContextOptions<Computer_Management_AppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Computer> Computers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SUN\\SQLEXPRESS;Initial Catalog=Computer_Management_App;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ComputerGroup)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerIp)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ComputerIP")
                    .IsFixedLength();

                entity.Property(e => e.ComputerLocation)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerMac)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("ComputerMAC")
                    .IsFixedLength();

                entity.Property(e => e.ComputerModel)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
