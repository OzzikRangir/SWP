using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Swp.Model
{
    public partial class SwpContext : DbContext
    {
        public SwpContext()
        {
        }

        public SwpContext(DbContextOptions<SwpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bron> Bron { get; set; }
        public virtual DbSet<Detalewiadomosci> Detalewiadomosci { get; set; }
        public virtual DbSet<Grupa> Grupa { get; set; }
        public virtual DbSet<Sluzba> Sluzba { get; set; }
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<Wiadomosc> Wiadomosc { get; set; }
        public virtual DbSet<Wniosek> Wniosek { get; set; }
        public virtual DbSet<Wyjazd> Wyjazd { get; set; }
        public virtual DbSet<Wyjscie> Wyjscie { get; set; }
        public virtual DbSet<Zajecie> Zajecie { get; set; }
        public virtual DbSet<Zolnierz> Zolnierz { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:swpdb.database.windows.net,1433;Initial Catalog=SwpDatabase;Persist Security Info=False;User ID=admin_swp;Password=password135!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bron>(entity =>
            {
                entity.Property(e => e.Idbroni).ValueGeneratedNever();

                entity.Property(e => e.Nazwabroni).IsUnicode(false);

                entity.Property(e => e.StanBroni).IsUnicode(false);

                entity.HasOne(d => d.IdzolnierzaNavigation)
                    .WithMany(p => p.Bron)
                    .HasForeignKey(d => d.Idzolnierza)
                    .HasConstraintName("FK_BRON_REFERENCE_ZOLNIERZ");
            });

            modelBuilder.Entity<Detalewiadomosci>(entity =>
            {
                entity.Property(e => e.Idwiadomosci).ValueGeneratedNever();

                entity.HasOne(d => d.IdwiadomosciNavigation)
                    .WithOne(p => p.Detalewiadomosci)
                    .HasForeignKey<Detalewiadomosci>(d => d.Idwiadomosci)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DETALEWI_REFERENCE_WIADOMOS");

                entity.HasOne(d => d.IdzolnierzaNavigation)
                    .WithMany(p => p.Detalewiadomosci)
                    .HasForeignKey(d => d.Idzolnierza)
                    .HasConstraintName("FK_DETALEWI_REFERENCE_ZOLNIERZ");
            });

            modelBuilder.Entity<Grupa>(entity =>
            {
                entity.Property(e => e.Idgrupy)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nazwagrupy).IsUnicode(false);
            });

            modelBuilder.Entity<Sluzba>(entity =>
            {
                entity.Property(e => e.Idsluzby).ValueGeneratedNever();

                entity.Property(e => e.Rodzajsluzby).IsUnicode(false);

                entity.HasOne(d => d.IdzolnierzaNavigation)
                    .WithMany(p => p.Sluzba)
                    .HasForeignKey(d => d.Idzolnierza)
                    .HasConstraintName("FK_SLUZBA_REFERENCE_ZOLNIERZ");
            });

            modelBuilder.Entity<Uzytkownik>(entity =>
            {
                entity.HasKey(e => new { e.Idzolnierza, e.Iduzykownika });

                entity.Property(e => e.Haslo).IsUnicode(false);

                entity.Property(e => e.Login).IsUnicode(false);

                entity.HasOne(d => d.IdzolnierzaNavigation)
                    .WithMany(p => p.Uzytkownik)
                    .HasForeignKey(d => d.Idzolnierza)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UZYTKOWN_REFERENCE_ZOLNIERZ");
            });

            modelBuilder.Entity<Wiadomosc>(entity =>
            {
                entity.Property(e => e.Idwiadomosci).ValueGeneratedNever();

                entity.Property(e => e.Tresc).IsUnicode(false);

                entity.Property(e => e.Tytul).IsUnicode(false);

                entity.HasOne(d => d.IdzolnierzaNavigation)
                    .WithMany(p => p.Wiadomosc)
                    .HasForeignKey(d => d.Idzolnierza)
                    .HasConstraintName("FK_WIADOMOS_REFERENCE_ZOLNIERZ");
            });

            modelBuilder.Entity<Wniosek>(entity =>
            {
                entity.Property(e => e.Idwniosku).ValueGeneratedNever();
            });

            modelBuilder.Entity<Wyjazd>(entity =>
            {
                entity.Property(e => e.Idwyjazdu).ValueGeneratedNever();

                entity.Property(e => e.RodzajWyjazdu).IsUnicode(false);

                entity.HasOne(d => d.IdzolnierzaNavigation)
                    .WithMany(p => p.Wyjazd)
                    .HasForeignKey(d => d.Idzolnierza)
                    .HasConstraintName("FK_WYJAZD_REFERENCE_ZOLNIERZ");
            });

            modelBuilder.Entity<Wyjscie>(entity =>
            {
                entity.Property(e => e.Idwyjscia).ValueGeneratedNever();

                entity.Property(e => e.RodzajWyjscia).IsUnicode(false);

                entity.HasOne(d => d.IdzolnierzaNavigation)
                    .WithMany(p => p.Wyjscie)
                    .HasForeignKey(d => d.Idzolnierza)
                    .HasConstraintName("FK_WYJSCIE_REFERENCE_ZOLNIERZ");
            });

            modelBuilder.Entity<Zajecie>(entity =>
            {
                entity.Property(e => e.Idzajecia).ValueGeneratedNever();

                entity.Property(e => e.Idgrupy).IsUnicode(false);

                entity.HasOne(d => d.IdgrupyNavigation)
                    .WithMany(p => p.Zajecie)
                    .HasForeignKey(d => d.Idgrupy)
                    .HasConstraintName("FK_ZAJECIE_REFERENCE_GRUPA");
            });

            modelBuilder.Entity<Zolnierz>(entity =>
            {
                entity.Property(e => e.Idzolnierza).ValueGeneratedNever();

                entity.Property(e => e.Adres).IsUnicode(false);

                entity.Property(e => e.Idgrupy).IsUnicode(false);

                entity.Property(e => e.Imie).IsUnicode(false);

                entity.Property(e => e.Imiematki).IsUnicode(false);

                entity.Property(e => e.Imieojca).IsUnicode(false);

                entity.Property(e => e.Naziwsko).IsUnicode(false);

                entity.Property(e => e.Pesel).IsUnicode(false);

                entity.Property(e => e.Stopien).IsUnicode(false);

                entity.HasOne(d => d.IdgrupyNavigation)
                    .WithMany(p => p.Zolnierz)
                    .HasForeignKey(d => d.Idgrupy)
                    .HasConstraintName("FK_ZOLNIERZ_REFERENCE_GRUPA");
            });
        }
    }
}
