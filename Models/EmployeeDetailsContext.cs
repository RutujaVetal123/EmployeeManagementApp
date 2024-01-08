using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeManagementApp.Models
{
    public partial class EmployeeDetailsContext : DbContext
    {
        public EmployeeDetailsContext()
        {
        }

        public EmployeeDetailsContext(DbContextOptions<EmployeeDetailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Doj)
                    .HasColumnName("DOJ")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Department_Employee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
