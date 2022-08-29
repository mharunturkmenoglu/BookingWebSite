using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookingWebSite.Models
{
    public partial class booking1661514677722bnfhkxzqhfmuxqllContext : DbContext
    {
        public booking1661514677722bnfhkxzqhfmuxqllContext()
        {
        }

        public booking1661514677722bnfhkxzqhfmuxqllContext(DbContextOptions<booking1661514677722bnfhkxzqhfmuxqllContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appartment> Appartments { get; set; } = null!;
        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=psql-mock-database-cloud.postgres.database.azure.com;Username=ichniddrvjfqjakraxxctqsz@psql-mock-database-cloud;Database=booking1661514677722bnfhkxzqhfmuxqll;Port=5432;Password=hkeiffpnkdddvozygspjlasu;SSLMode=Prefer");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appartment>(entity =>
            {
                entity.ToTable("appartments");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Address2).HasColumnName("address2");

                entity.Property(e => e.Booked).HasColumnName("booked");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ZipCode).HasColumnName("zip_code");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bookings");

                entity.Property(e => e.ApartmentId).HasColumnName("apartment_id");

                entity.Property(e => e.BookedAt).HasColumnName("booked_at");

                entity.Property(e => e.BookedFor).HasColumnName("booked_for");

                entity.Property(e => e.Confirmed).HasColumnName("confirmed");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StartsAt).HasColumnName("starts_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address")
                    .IsFixedLength();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Country).HasColumnName("country");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName).HasColumnName("first_name");

                entity.Property(e => e.FullName).HasColumnName("full_name");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.JobTitle).HasColumnName("job_title");

                entity.Property(e => e.JobType).HasColumnName("job_type");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.OnboardingCompletion).HasColumnName("onboarding_completion");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
