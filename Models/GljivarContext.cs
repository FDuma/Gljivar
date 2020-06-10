using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Gljivar.Models
{
    public partial class GljivarContext : DbContext
    {
        public GljivarContext()
        {
        }

        public GljivarContext(DbContextOptions<GljivarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Biljeska> Biljeska { get; set; }
        public virtual DbSet<Dogadaj> Dogadaj { get; set; }
        public virtual DbSet<Drzava> Drzava { get; set; }
        public virtual DbSet<Gljiva> Gljiva { get; set; }
        public virtual DbSet<GljivaUmjestu> GljivaUmjestu { get; set; }
        public virtual DbSet<GljivarDrustvo> GljivarDrustvo { get; set; }
        public virtual DbSet<Komentar> Komentar { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Mjesto> Mjesto { get; set; }
        public virtual DbSet<Objava> Objava { get; set; }
        public virtual DbSet<ProGljivar> ProGljivar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\Gljivar;Database=Gljivar;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Biljeska>(entity =>
            {
                entity.HasKey(e => e.IdBiljeski);

                entity.Property(e => e.IdBiljeski).HasColumnName("idBiljeski");

                entity.Property(e => e.Biljeska1)
                    .IsRequired()
                    .HasColumnName("biljeska")
                    .IsUnicode(false);

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("date");

                entity.Property(e => e.IdKorisnika).HasColumnName("idKorisnika");

                entity.Property(e => e.IsPublic).HasColumnName("isPublic");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdKorisnikaNavigation)
                    .WithMany(p => p.Biljeska)
                    .HasForeignKey(d => d.IdKorisnika)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Biljeska_Korisnik");
            });

            modelBuilder.Entity<Dogadaj>(entity =>
            {
                entity.HasKey(e => e.IdDogadaj);

                entity.Property(e => e.IdDogadaj).HasColumnName("idDogadaj");

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdGljivarDrustvo).HasColumnName("idGljivarDrustvo");

                entity.Property(e => e.IdMjesto).HasColumnName("idMjesto");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasColumnName("opis")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGljivarDrustvoNavigation)
                    .WithMany(p => p.Dogadaj)
                    .HasForeignKey(d => d.IdGljivarDrustvo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dogadaj_gljivarDrustvo");

                entity.HasOne(d => d.IdMjestoNavigation)
                    .WithMany(p => p.Dogadaj)
                    .HasForeignKey(d => d.IdMjesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dogadaj_Mjesto");
            });

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.HasKey(e => e.IdDrzave);

                entity.Property(e => e.IdDrzave).HasColumnName("idDrzave");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gljiva>(entity =>
            {
                entity.HasKey(e => e.IdGljive);

                entity.Property(e => e.IdGljive).HasColumnName("idGljive");

                entity.Property(e => e.Kategorija)
                    .HasColumnName("kategorija")
                    .IsUnicode(false);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasColumnName("naziv")
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasColumnName("opis")
                    .IsUnicode(false);

                entity.Property(e => e.Otrovnica).HasColumnName("otrovnica");
            });

            modelBuilder.Entity<GljivaUmjestu>(entity =>
            {
                entity.HasKey(e => new { e.IdGljiva, e.IdMjesto });

                entity.ToTable("gljivaUMjestu");

                entity.Property(e => e.IdGljiva).HasColumnName("idGljiva");

                entity.Property(e => e.IdMjesto).HasColumnName("idMjesto");

                entity.HasOne(d => d.IdGljivaNavigation)
                    .WithMany(p => p.GljivaUmjestu)
                    .HasForeignKey(d => d.IdGljiva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gljivaUMjestu_Gljiva");

                entity.HasOne(d => d.IdGljiva1)
                    .WithMany(p => p.GljivaUmjestu)
                    .HasForeignKey(d => d.IdGljiva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gljivaUMjestu_Mjesto");
            });

            modelBuilder.Entity<GljivarDrustvo>(entity =>
            {
                entity.HasKey(e => e.IdGljivarDrustvo);

                entity.ToTable("gljivarDrustvo");

                entity.Property(e => e.IdGljivarDrustvo).HasColumnName("idGljivarDrustvo");

                entity.Property(e => e.IdMjesto).HasColumnName("idMjesto");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMjestoNavigation)
                    .WithMany(p => p.GljivarDrustvo)
                    .HasForeignKey(d => d.IdMjesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_gljivarDrustvo_Mjesto");
            });

            modelBuilder.Entity<Komentar>(entity =>
            {
                entity.HasKey(e => e.IdKomentar)
                    .HasName("PK_komentar");

                entity.Property(e => e.IdKomentar).HasColumnName("idKomentar");

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdGljivarDrustvo).HasColumnName("idGljivarDrustvo");

                entity.Property(e => e.IdKorisnik).HasColumnName("idKorisnik");

                entity.Property(e => e.IdObjava).HasColumnName("idObjava");

                entity.Property(e => e.Komentar1)
                    .IsRequired()
                    .HasColumnName("komentar")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGljivarDrustvoNavigation)
                    .WithMany(p => p.Komentar)
                    .HasForeignKey(d => d.IdGljivarDrustvo)
                    .HasConstraintName("FK_Komentar_gljivarDrustvo");

                entity.HasOne(d => d.IdKorisnikNavigation)
                    .WithMany(p => p.Komentar)
                    .HasForeignKey(d => d.IdKorisnik)
                    .HasConstraintName("FK_Komentar_Korisnik");

                entity.HasOne(d => d.IdObjavaNavigation)
                    .WithMany(p => p.Komentar)
                    .HasForeignKey(d => d.IdObjava)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Komentar_Objava");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.HasKey(e => e.IdKorisnik);

                entity.Property(e => e.IdKorisnik).HasColumnName("idKorisnik");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .IsUnicode(false);

                entity.Property(e => e.IdGljivarskoDrustvo).HasColumnName("idGljivarskoDrustvo");

                entity.Property(e => e.IdMjesta).HasColumnName("idMjesta");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasColumnName("ime")
                    .IsUnicode(false);

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.KontaktBroj).HasColumnName("kontaktBroj");

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasColumnName("korisnickoIme")
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasColumnName("prezime")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGljivarskoDrustvoNavigation)
                    .WithMany(p => p.Korisnik)
                    .HasForeignKey(d => d.IdGljivarskoDrustvo)
                    .HasConstraintName("FK_Korisnik_gljivarDrustvo");

                entity.HasOne(d => d.IdMjestaNavigation)
                    .WithMany(p => p.Korisnik)
                    .HasForeignKey(d => d.IdMjesta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Korisnik_Mjesto");
            });

            modelBuilder.Entity<Mjesto>(entity =>
            {
                entity.HasKey(e => e.IdMjesta);

                entity.Property(e => e.IdMjesta).HasColumnName("idMjesta");

                entity.Property(e => e.IdDrzave).HasColumnName("idDrzave");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PostanskiBroj).HasColumnName("postanskiBroj");

                entity.HasOne(d => d.IdDrzaveNavigation)
                    .WithMany(p => p.Mjesto)
                    .HasForeignKey(d => d.IdDrzave)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mjesto_Drzava");
            });

            modelBuilder.Entity<Objava>(entity =>
            {
                entity.HasKey(e => e.IdObjava);

                entity.Property(e => e.IdObjava).HasColumnName("idObjava");

                entity.Property(e => e.Datum)
                    .HasColumnName("datum")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdGljivarDrustvo).HasColumnName("idGljivarDrustvo");

                entity.Property(e => e.IdKorisnika).HasColumnName("idKorisnika");

                entity.Property(e => e.Naziv)
                    .HasColumnName("naziv")
                    .IsUnicode(false);

                entity.Property(e => e.Objava1)
                    .HasColumnName("objava")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGljivarDrustvoNavigation)
                    .WithMany(p => p.Objava)
                    .HasForeignKey(d => d.IdGljivarDrustvo)
                    .HasConstraintName("FK_Objava_gljivarDrustvo");

                entity.HasOne(d => d.IdKorisnikaNavigation)
                    .WithMany(p => p.Objava)
                    .HasForeignKey(d => d.IdKorisnika)
                    .HasConstraintName("FK_Objava_Korisnik");
            });

            modelBuilder.Entity<ProGljivar>(entity =>
            {
                entity.HasKey(e => e.IdProfesionalniGljivar);

                entity.ToTable("proGljivar");

                entity.Property(e => e.IdProfesionalniGljivar).HasColumnName("idProfesionalniGljivar");

                entity.Property(e => e.IdKorisnik).HasColumnName("idKorisnik");

                entity.Property(e => e.Rang).HasColumnName("rang");

                entity.HasOne(d => d.IdKorisnikNavigation)
                    .WithMany(p => p.ProGljivar)
                    .HasForeignKey(d => d.IdKorisnik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_proGljivar_Korisnik");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
