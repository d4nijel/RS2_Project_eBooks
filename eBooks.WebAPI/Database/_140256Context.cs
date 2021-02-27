using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eBooks.WebAPI.Database
{
    public partial class _140256Context : DbContext
    {
        public _140256Context()
        {
        }

        public _140256Context(DbContextOptions<_140256Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Autori> Autori { get; set; }
        public virtual DbSet<AutoriKnjige> AutoriKnjige { get; set; }
        public virtual DbSet<Drzave> Drzave { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<Izdavaci> Izdavaci { get; set; }
        public virtual DbSet<Kategorije> Kategorije { get; set; }
        public virtual DbSet<Knjige> Knjige { get; set; }
        public virtual DbSet<KnjigeKategorije> KnjigeKategorije { get; set; }
        public virtual DbSet<Kolekcije> Kolekcije { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<KreditneKartice> KreditneKartice { get; set; }
        public virtual DbSet<Kupci> Kupci { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public virtual DbSet<Narudzbe> Narudzbe { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Racuni> Racuni { get; set; }
        public virtual DbSet<RacunStavke> RacunStavke { get; set; }
        public virtual DbSet<Ugovori> Ugovori { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=140256;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autori>(entity =>
            {
                entity.HasKey(e => e.AutorId);

                entity.Property(e => e.AutorId).HasColumnName("AutorID");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.DatumSmrti).HasColumnType("date");

                entity.Property(e => e.Ime).HasMaxLength(50);

                entity.Property(e => e.KratkaBiografija)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Prezime).HasMaxLength(50);

                entity.Property(e => e.Pseudonim).HasMaxLength(50);

                entity.HasOne(d => d.MjestoRodjenjaNavigation)
                    .WithMany(p => p.AutoriMjestoRodjenjaNavigation)
                    .HasForeignKey(d => d.MjestoRodjenja)
                    .HasConstraintName("FK_Gradovi_Autori_MjestoRodjenja");

                entity.HasOne(d => d.MjestoSmrtiNavigation)
                    .WithMany(p => p.AutoriMjestoSmrtiNavigation)
                    .HasForeignKey(d => d.MjestoSmrti)
                    .HasConstraintName("FK_Gradovi_Autori_MjestoSmrti");
            });

            modelBuilder.Entity<AutoriKnjige>(entity =>
            {
                entity.HasKey(e => new { e.AutorId, e.KnjigaId });

                entity.Property(e => e.AutorId).HasColumnName("AutorID");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.AutoriKnjige)
                    .HasForeignKey(d => d.AutorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Autori_AutoriKnjige");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.AutoriKnjige)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Knjige_AutoriKnjige");
            });

            modelBuilder.Entity<Drzave>(entity =>
            {
                entity.HasKey(e => e.DrzavaId);

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Iso3166codeA3)
                    .IsRequired()
                    .HasColumnName("ISO3166CodeA3")
                    .HasMaxLength(3);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Gradovi)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Drzave_Gradovi");
            });

            modelBuilder.Entity<Izdavaci>(entity =>
            {
                entity.HasKey(e => e.IzdavacId);

                entity.Property(e => e.IzdavacId).HasColumnName("IzdavacID");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.KontaktEmail)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.KontaktOsoba)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.KontaktTelefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Izdavaci)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gradovi_Izdavaci");
            });

            modelBuilder.Entity<Kategorije>(entity =>
            {
                entity.HasKey(e => e.KategorijaId);

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Knjige>(entity =>
            {
                entity.HasKey(e => e.KnjigaId);

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.Property(e => e.Format)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("ISBN")
                    .HasMaxLength(20);

                entity.Property(e => e.IzdavacId).HasColumnName("IzdavacID");

                entity.Property(e => e.Jezik)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Knjiga).IsRequired();

                entity.Property(e => e.KolekcijaId).HasColumnName("KolekcijaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OriginalniNaziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sadrzaj)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Sifra)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.SlikaNaslovnice).IsRequired();

                entity.Property(e => e.UzorakKnjige).IsRequired();

                entity.HasOne(d => d.Izdavac)
                    .WithMany(p => p.Knjige)
                    .HasForeignKey(d => d.IzdavacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Izdavaci_Knjige");

                entity.HasOne(d => d.Kolekcija)
                    .WithMany(p => p.Knjige)
                    .HasForeignKey(d => d.KolekcijaId)
                    .HasConstraintName("FK_Kolekcije_Knjige");
            });

            modelBuilder.Entity<KnjigeKategorije>(entity =>
            {
                entity.HasKey(e => new { e.KategorijaId, e.KnjigaId });

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.KnjigeKategorije)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kategorije_KnjigeKategorije");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.KnjigeKategorije)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Knjige_KnjigeKategorije");
            });

            modelBuilder.Entity<Kolekcije>(entity =>
            {
                entity.HasKey(e => e.KolekcijaId);

                entity.Property(e => e.KolekcijaId).HasColumnName("KolekcijaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.OriginalniNaziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(20);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId);

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Korisnici_KorisniciUloge");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uloge_KorisniciUloge");
            });

            modelBuilder.Entity<KreditneKartice>(entity =>
            {
                entity.HasKey(e => e.KreditnaKarticaId);

                entity.Property(e => e.KreditnaKarticaId).HasColumnName("KreditnaKarticaID");

                entity.Property(e => e.BrojKartice)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Cvc2).HasColumnName("CVC2");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.Opis).HasMaxLength(255);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.KreditneKartice)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kupci_KreditneKartice");
            });

            modelBuilder.Entity<Kupci>(entity =>
            {
                entity.HasKey(e => e.KupacId);

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.HasKey(e => e.NarudzbaStavkaId);

                entity.Property(e => e.NarudzbaStavkaId).HasColumnName("NarudzbaStavkaID");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Knjige_NarudzbaStavke");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzbe_NarudzbaStavke");
            });

            modelBuilder.Entity<Narudzbe>(entity =>
            {
                entity.HasKey(e => e.NarudzbaId);

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.BrojNarudzbe)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Narudzbe)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kupci_Narudzbe");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.Property(e => e.KupacId).HasColumnName("KupacID");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Knjige_Ocjene");

                entity.HasOne(d => d.Kupac)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KupacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Kupci_Ocjene");
            });

            modelBuilder.Entity<Racuni>(entity =>
            {
                entity.HasKey(e => e.RacunId);

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.Property(e => e.BrojRacuna)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.IznosBezPdv).HasColumnName("IznosBezPDV");

                entity.Property(e => e.IznosSaPdv).HasColumnName("IznosSaPDV");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.Racuni)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Narudzbe_Racuni");
            });

            modelBuilder.Entity<RacunStavke>(entity =>
            {
                entity.Property(e => e.RacunStavkeId).HasColumnName("RacunStavkeID");

                entity.Property(e => e.KnjigaId).HasColumnName("KnjigaID");

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.HasOne(d => d.Knjiga)
                    .WithMany(p => p.RacunStavke)
                    .HasForeignKey(d => d.KnjigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Knjige_RacunStavke");

                entity.HasOne(d => d.Racun)
                    .WithMany(p => p.RacunStavke)
                    .HasForeignKey(d => d.RacunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Racuni_RacunStavke");
            });

            modelBuilder.Entity<Ugovori>(entity =>
            {
                entity.HasKey(e => e.UgovorId);

                entity.Property(e => e.UgovorId).HasColumnName("UgovorID");

                entity.Property(e => e.BrojUgovora)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.DatumPotpisivanja).HasColumnType("date");

                entity.Property(e => e.IzdavacId).HasColumnName("IzdavacID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.ProcenatOdProdaje).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Ugovor).IsRequired();

                entity.HasOne(d => d.Izdavac)
                    .WithMany(p => p.Ugovori)
                    .HasForeignKey(d => d.IzdavacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Izdavaci_Ugovori");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Ugovori)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Korisnici_Ugovori");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });
        }
    }
}
