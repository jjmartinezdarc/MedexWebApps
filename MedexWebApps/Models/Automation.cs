namespace MedexWebApps.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Automation : DbContext
    {
        public Automation()
            : base("name=Automation")
        {
        }

        public virtual DbSet<IT_Staff> IT_Staff { get; set; }
        public virtual DbSet<IT_Weekly_Shift> IT_Weekly_Shift { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Week> Weeks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IT_Staff>()
                .Property(e => e.IT_Name)
                .IsUnicode(false);

            modelBuilder.Entity<IT_Staff>()
                .Property(e => e.Mobile_No)
                .IsUnicode(false);

            modelBuilder.Entity<IT_Staff>()
                .Property(e => e.Sort_No)
                .HasPrecision(3, 3);

            modelBuilder.Entity<IT_Staff>()
                .HasMany(e => e.IT_Weekly_Shift)
                .WithRequired(e => e.IT_Staff)
                .HasForeignKey(e => e.IT_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IT_Weekly_Shift>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Shift>()
                .Property(e => e.Shift1)
                .IsUnicode(false);

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.IT_Weekly_Shift)
                .WithRequired(e => e.Shift)
                .HasForeignKey(e => e.Shift_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Week>()
                .Property(e => e.Week_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Week>()
                .HasMany(e => e.IT_Weekly_Shift)
                .WithRequired(e => e.Week)
                .HasForeignKey(e => e.Week_ID)
                .WillCascadeOnDelete(false);
        }
    }
}
