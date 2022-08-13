using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MovieStore.Models
{
    public partial class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext()
        {
        }

        public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BankTransaction> Banks { get; set; } = null!;
        public virtual DbSet<UserDatum> UserData { get; set; } = null!;
        public virtual DbSet<UserMovie> UserMovies { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = (LocalDb)\\MSSQLLocalDB; Integrated Security = SSPI;Initial Catalog=MovieDatabase;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankTransaction>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Bank__1788CC4C96BF2CF6");

                entity.ToTable("Bank");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.TransactionAmount)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewWalletAmount).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<UserDatum>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserData__1788CC4CB78E14A1");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMovie>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserMovi__1788CC4C57EE41B8");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImdbId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImdbID");

                entity.Property(e => e.MovieDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MovieTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoviesDbId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MoviesDbID");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
