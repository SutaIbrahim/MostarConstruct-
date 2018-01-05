﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MostarConstruct.Data;
using System;

namespace MostarConstruct.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MostarConstruct.Data.Models.Fajl", b =>
                {
                    b.Property<int>("FajlId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumDodavanja");

                    b.Property<string>("Lokacija");

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.HasKey("FajlId");

                    b.ToTable("Fajlovi");
                });

            modelBuilder.Entity("MostarConstruct.Data.Models.ProjektiFajlovi", b =>
                {
                    b.Property<int>("ProjektFajlID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FajlID");

                    b.Property<int>("ProjektID");

                    b.HasKey("ProjektFajlID");

                    b.HasIndex("FajlID");

                    b.HasIndex("ProjektID");

                    b.ToTable("ProjektiFajlovi");
                });

            modelBuilder.Entity("MostarConstruct.Models.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Oznaka")
                        .HasMaxLength(10);

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("MostarConstruct.Models.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PostanskiBroj")
                        .HasMaxLength(12);

                    b.Property<int>("RegijaID");

                    b.HasKey("GradID");

                    b.HasIndex("RegijaID");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("MostarConstruct.Models.Inventar", b =>
                {
                    b.Property<int>("InventarID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DatumKupovine");

                    b.Property<bool>("Ispravno");

                    b.Property<int>("KategorijaID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Opis");

                    b.Property<string>("Pogon")
                        .HasMaxLength(30);

                    b.Property<string>("SerijskiBroj")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Tezina")
                        .HasMaxLength(30);

                    b.Property<bool>("Zauzeto");

                    b.HasKey("InventarID");

                    b.HasIndex("KategorijaID");

                    b.ToTable("Inventar");
                });

            modelBuilder.Entity("MostarConstruct.Models.InventarRadiliste", b =>
                {
                    b.Property<int>("InventarRadilisteID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumZauzimanja");

                    b.Property<int>("InventarID");

                    b.Property<int>("PoslovodjaID");

                    b.Property<int>("RadilisteID");

                    b.Property<int>("RadnikID");

                    b.Property<bool>("Vraceno");

                    b.Property<DateTime?>("ZauzetoDo");

                    b.HasKey("InventarRadilisteID");

                    b.HasIndex("InventarID");

                    b.HasIndex("PoslovodjaID");

                    b.HasIndex("RadilisteID");

                    b.HasIndex("RadnikID");

                    b.ToTable("InventarRadiliste");
                });

            modelBuilder.Entity("MostarConstruct.Models.Izvjestaj", b =>
                {
                    b.Property<int>("IzvjestajID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojProtokola")
                        .IsRequired();

                    b.Property<DateTime>("DatumIzdavanja");

                    b.Property<int>("KorisnikID");

                    b.Property<string>("Napomena");

                    b.Property<int>("ProjektID");

                    b.Property<string>("Svrha")
                        .IsRequired();

                    b.HasKey("IzvjestajID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ProjektID");

                    b.ToTable("Izvjestaji");
                });

            modelBuilder.Entity("MostarConstruct.Models.Kategorija", b =>
                {
                    b.Property<int>("KategorijaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("KategorijaID");

                    b.ToTable("Kategorije");
                });

            modelBuilder.Entity("MostarConstruct.Models.Klijent", b =>
                {
                    b.Property<int>("KlijentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa")
                        .HasMaxLength(100);

                    b.Property<int>("BrojNarucenihProjekata");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Fax")
                        .HasMaxLength(30);

                    b.Property<string>("Kompanija")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("KontaktOsoba")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Telefon")
                        .HasMaxLength(30);

                    b.Property<int>("TipKlijentaID");

                    b.Property<string>("Ziroracun")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("KlijentID");

                    b.HasIndex("TipKlijentaID");

                    b.ToTable("Klijenti");
                });

            modelBuilder.Entity("MostarConstruct.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID");

                    b.Property<bool>("Aktivan");

                    b.Property<DateTime>("DatumRegistracije");

                    b.Property<DateTime?>("DatumZadnjePrijave");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsClanUprave");

                    b.Property<bool>("IsPoslovodja");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LozinkaHash");

                    b.Property<bool>("PromijenioLozinku");

                    b.HasKey("KorisnikID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("MostarConstruct.Models.Log", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Aktivnost")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Browser")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Datum");

                    b.Property<string>("IPAdresa")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("KorisnikID");

                    b.Property<string>("Tabela")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("LogID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Logovi");
                });

            modelBuilder.Entity("MostarConstruct.Models.Osoba", b =>
                {
                    b.Property<int>("OsobaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa")
                        .HasMaxLength(100);

                    b.Property<string>("BracniStatus")
                        .HasMaxLength(30);

                    b.Property<string>("ContentType");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("GradID");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("JMBG")
                        .HasMaxLength(13);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte[]>("Slika");

                    b.Property<string>("Spol")
                        .HasMaxLength(15);

                    b.Property<string>("Telefon")
                        .HasMaxLength(100);

                    b.HasKey("OsobaID");

                    b.HasIndex("GradID");

                    b.ToTable("Osobe");
                });

            modelBuilder.Entity("MostarConstruct.Models.Plata", b =>
                {
                    b.Property<int>("PlataID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BonusIznos");

                    b.Property<decimal>("BrutoIznos");

                    b.Property<DateTime>("DatumKnjizenja");

                    b.Property<int>("Godina");

                    b.Property<int>("Mjesec");

                    b.Property<decimal>("NetoIznos");

                    b.Property<int>("RadnikID");

                    b.HasKey("PlataID");

                    b.HasIndex("RadnikID");

                    b.ToTable("Plate");
                });

            modelBuilder.Entity("MostarConstruct.Models.PlatnaLista", b =>
                {
                    b.Property<int>("PlatnaListaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojMjeseci")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("BrojProtokola")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("ClanUpraveID");

                    b.Property<DateTime>("DatumIzdavanja");

                    b.Property<string>("Napomena");

                    b.Property<int>("RadnikID");

                    b.Property<string>("Svrha")
                        .IsRequired();

                    b.HasKey("PlatnaListaID");

                    b.HasIndex("ClanUpraveID");

                    b.HasIndex("RadnikID");

                    b.ToTable("PlatneListe");
                });

            modelBuilder.Entity("MostarConstruct.Models.Ponuda", b =>
                {
                    b.Property<int>("PonudaID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClanUpraveID");

                    b.Property<DateTime>("DatumIzdavanja");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("PotrebnoVrijeme");

                    b.Property<decimal>("PredlozenaCijena");

                    b.Property<string>("Sadrzaj")
                        .IsRequired();

                    b.HasKey("PonudaID");

                    b.HasIndex("ClanUpraveID");

                    b.ToTable("Ponude");
                });

            modelBuilder.Entity("MostarConstruct.Models.Pozicija", b =>
                {
                    b.Property<int>("PozicijaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<decimal>("Satnica");

                    b.HasKey("PozicijaID");

                    b.ToTable("Pozicije");
                });

            modelBuilder.Entity("MostarConstruct.Models.Projekt", b =>
                {
                    b.Property<int>("ProjektID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojRata");

                    b.Property<decimal>("Cijena");

                    b.Property<int>("ClanUpraveID");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis")
                        .IsRequired();

                    b.Property<DateTime>("PredlozeniPocetak");

                    b.Property<DateTime>("PredlozeniZavrsetak");

                    b.Property<DateTime?>("StvarniPocetak");

                    b.Property<DateTime?>("StvarniZavrsetak");

                    b.Property<bool>("Zavrsen");

                    b.HasKey("ProjektID");

                    b.HasIndex("ClanUpraveID");

                    b.ToTable("Projekti");
                });

            modelBuilder.Entity("MostarConstruct.Models.ProjektDokumenti", b =>
                {
                    b.Property<int>("ProjektDokumentiID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojPreuzimanja");

                    b.Property<DateTime>("DatumKreiranja");

                    b.Property<byte[]>("Dokument");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("PoslovodjaID");

                    b.Property<int>("ProjektID");

                    b.Property<decimal>("Velicina");

                    b.HasKey("ProjektDokumentiID");

                    b.HasIndex("PoslovodjaID");

                    b.HasIndex("ProjektID");

                    b.ToTable("ProjektDokumenti");
                });

            modelBuilder.Entity("MostarConstruct.Models.PutniNalog", b =>
                {
                    b.Property<int>("PutniNalogID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumIzdavanja");

                    b.Property<int>("GradID");

                    b.Property<int>("KorisnikID");

                    b.Property<string>("Napomena");

                    b.Property<int>("RadilisteID");

                    b.Property<int>("RadnikID");

                    b.Property<string>("Svrha")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("TroskoviPutovanja");

                    b.Property<decimal>("UkupnoRadnihSati");

                    b.Property<int>("VoziloID");

                    b.Property<DateTime>("VrijediDo");

                    b.HasKey("PutniNalogID");

                    b.HasIndex("GradID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("RadilisteID");

                    b.HasIndex("RadnikID");

                    b.HasIndex("VoziloID");

                    b.ToTable("PutniNalozi");
                });

            modelBuilder.Entity("MostarConstruct.Models.Radiliste", b =>
                {
                    b.Property<int>("RadilisteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("GradID");

                    b.Property<string>("NadzorniOrgan")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Opis");

                    b.Property<DateTime>("PocetakRadova");

                    b.Property<int>("ProjektID");

                    b.Property<DateTime?>("ZavrsetakRadova");

                    b.HasKey("RadilisteID");

                    b.HasIndex("GradID");

                    b.HasIndex("ProjektID");

                    b.ToTable("Radilista");
                });

            modelBuilder.Entity("MostarConstruct.Models.Radnik", b =>
                {
                    b.Property<int>("RadnikID");

                    b.Property<bool>("Aktivan");

                    b.Property<DateTime>("DatumZaposlenja");

                    b.Property<decimal>("DodatakNaSatnicu");

                    b.Property<int>("PozicijaID");

                    b.Property<decimal>("Staz");

                    b.HasKey("RadnikID");

                    b.HasIndex("PozicijaID");

                    b.ToTable("Radnici");
                });

            modelBuilder.Entity("MostarConstruct.Models.RadniNalog", b =>
                {
                    b.Property<int>("RadniNalogID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumDo");

                    b.Property<DateTime>("DatumDodjele");

                    b.Property<DateTime>("DatumOd");

                    b.Property<string>("Napomena");

                    b.Property<int>("RadilisteID");

                    b.Property<int>("RadnikID");

                    b.Property<string>("Zaduzenje")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("RadniNalogID");

                    b.HasIndex("RadilisteID");

                    b.HasIndex("RadnikID");

                    b.ToTable("RadniNalozi");
                });

            modelBuilder.Entity("MostarConstruct.Models.Regija", b =>
                {
                    b.Property<int>("RegijaID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DrzavaID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Oznaka")
                        .HasMaxLength(10);

                    b.HasKey("RegijaID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Regije");
                });

            modelBuilder.Entity("MostarConstruct.Models.TipKlijenta", b =>
                {
                    b.Property<int>("TipKlijentaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("TipKlijentaID");

                    b.ToTable("TipoviKlijenata");
                });

            modelBuilder.Entity("MostarConstruct.Models.Uplata", b =>
                {
                    b.Property<int>("UplataID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojUplate");

                    b.Property<int>("ClanUpraveID");

                    b.Property<DateTime>("DatumUplate");

                    b.Property<decimal>("Iznos");

                    b.Property<int>("KlijentID");

                    b.Property<int>("ProjektID");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Svrha")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UplataID");

                    b.HasIndex("ClanUpraveID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("ProjektID");

                    b.ToTable("Uplate");
                });

            modelBuilder.Entity("MostarConstruct.Models.Uvjerenje", b =>
                {
                    b.Property<int>("UvjerenjeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojProtokola")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("ClanUpraveID");

                    b.Property<DateTime>("DatumIzdavanja");

                    b.Property<string>("Napomena");

                    b.Property<int>("RadnikID");

                    b.Property<string>("Svrha")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UvjerenjeID");

                    b.HasIndex("ClanUpraveID");

                    b.HasIndex("RadnikID");

                    b.ToTable("Uvjerenja");
                });

            modelBuilder.Entity("MostarConstruct.Models.VozaciKategorije", b =>
                {
                    b.Property<int>("VozacID");

                    b.Property<int>("KategorijaID");

                    b.Property<DateTime>("DatumPolaganja");

                    b.Property<DateTime>("VaziDo");

                    b.HasKey("VozacID", "KategorijaID");

                    b.HasAlternateKey("KategorijaID", "VozacID");

                    b.ToTable("VozaciKategorije");
                });

            modelBuilder.Entity("MostarConstruct.Models.VozackaKategorija", b =>
                {
                    b.Property<int>("VozackaKategorijaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("VozackaKategorijaID");

                    b.ToTable("VozackeKategorije");
                });

            modelBuilder.Entity("MostarConstruct.Models.Vozilo", b =>
                {
                    b.Property<int>("VoziloID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojSasije")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("BrojSjedista");

                    b.Property<decimal?>("CijenaPoSatu");

                    b.Property<DateTime>("DatumKupovine");

                    b.Property<DateTime>("DatumRegistracije");

                    b.Property<DateTime?>("DatumZadnjegServisa");

                    b.Property<int>("GodinaProizvodnje");

                    b.Property<string>("Kubikaza")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Nosivost")
                        .HasMaxLength(20);

                    b.Property<string>("Proizvodjac")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("RegistarskaOznaka")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("VozackaKategorijaID");

                    b.Property<int>("VrstaVozilaID");

                    b.Property<bool>("Zauzeto");

                    b.HasKey("VoziloID");

                    b.HasIndex("VozackaKategorijaID");

                    b.HasIndex("VrstaVozilaID");

                    b.ToTable("Vozila");
                });

            modelBuilder.Entity("MostarConstruct.Models.VrstaVozila", b =>
                {
                    b.Property<int>("VrstaVozilaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("VrstaVozilaID");

                    b.ToTable("VrsteVozila");
                });

            modelBuilder.Entity("MostarConstruct.Data.Models.ProjektiFajlovi", b =>
                {
                    b.HasOne("MostarConstruct.Data.Models.Fajl", "Fajl")
                        .WithMany()
                        .HasForeignKey("FajlID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Projekt", "Projekt")
                        .WithMany()
                        .HasForeignKey("ProjektID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Grad", b =>
                {
                    b.HasOne("MostarConstruct.Models.Regija", "Regija")
                        .WithMany()
                        .HasForeignKey("RegijaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Inventar", b =>
                {
                    b.HasOne("MostarConstruct.Models.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.InventarRadiliste", b =>
                {
                    b.HasOne("MostarConstruct.Models.Inventar", "Inventar")
                        .WithMany()
                        .HasForeignKey("InventarID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Korisnik", "Poslovodja")
                        .WithMany()
                        .HasForeignKey("PoslovodjaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Radiliste", "Radiliste")
                        .WithMany()
                        .HasForeignKey("RadilisteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Izvjestaj", b =>
                {
                    b.HasOne("MostarConstruct.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Projekt", "Projekt")
                        .WithMany()
                        .HasForeignKey("ProjektID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Klijent", b =>
                {
                    b.HasOne("MostarConstruct.Models.TipKlijenta", "TipKlijenta")
                        .WithMany()
                        .HasForeignKey("TipKlijentaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Korisnik", b =>
                {
                    b.HasOne("MostarConstruct.Models.Osoba", "Osoba")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Log", b =>
                {
                    b.HasOne("MostarConstruct.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Osoba", b =>
                {
                    b.HasOne("MostarConstruct.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Plata", b =>
                {
                    b.HasOne("MostarConstruct.Models.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.PlatnaLista", b =>
                {
                    b.HasOne("MostarConstruct.Models.Korisnik", "ClanUprave")
                        .WithMany()
                        .HasForeignKey("ClanUpraveID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Ponuda", b =>
                {
                    b.HasOne("MostarConstruct.Models.Korisnik", "ClanUprave")
                        .WithMany()
                        .HasForeignKey("ClanUpraveID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Projekt", b =>
                {
                    b.HasOne("MostarConstruct.Models.Korisnik", "ClanUprave")
                        .WithMany()
                        .HasForeignKey("ClanUpraveID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.ProjektDokumenti", b =>
                {
                    b.HasOne("MostarConstruct.Models.Korisnik", "Poslovodja")
                        .WithMany()
                        .HasForeignKey("PoslovodjaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Projekt", "Projekt")
                        .WithMany()
                        .HasForeignKey("ProjektID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.PutniNalog", b =>
                {
                    b.HasOne("MostarConstruct.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Korisnik", "Poslovodja")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Radiliste", "Radiliste")
                        .WithMany()
                        .HasForeignKey("RadilisteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Vozilo", "Vozilo")
                        .WithMany()
                        .HasForeignKey("VoziloID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Radiliste", b =>
                {
                    b.HasOne("MostarConstruct.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Projekt", "Projekt")
                        .WithMany()
                        .HasForeignKey("ProjektID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Radnik", b =>
                {
                    b.HasOne("MostarConstruct.Models.Pozicija", "Pozicija")
                        .WithMany()
                        .HasForeignKey("PozicijaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Osoba", "Osoba")
                        .WithMany()
                        .HasForeignKey("RadnikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.RadniNalog", b =>
                {
                    b.HasOne("MostarConstruct.Models.Radiliste", "Radiliste")
                        .WithMany()
                        .HasForeignKey("RadilisteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Regija", b =>
                {
                    b.HasOne("MostarConstruct.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Uplata", b =>
                {
                    b.HasOne("MostarConstruct.Models.Korisnik", "ClanUprave")
                        .WithMany()
                        .HasForeignKey("ClanUpraveID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Projekt", "Projekt")
                        .WithMany()
                        .HasForeignKey("ProjektID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Uvjerenje", b =>
                {
                    b.HasOne("MostarConstruct.Models.Korisnik", "ClanUprave")
                        .WithMany()
                        .HasForeignKey("ClanUpraveID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.VozaciKategorije", b =>
                {
                    b.HasOne("MostarConstruct.Models.VozackaKategorija", "VozackaKategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.Radnik", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MostarConstruct.Models.Vozilo", b =>
                {
                    b.HasOne("MostarConstruct.Models.VozackaKategorija", "VozackaKategorija")
                        .WithMany()
                        .HasForeignKey("VozackaKategorijaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MostarConstruct.Models.VrstaVozila", "VrstaVozila")
                        .WithMany()
                        .HasForeignKey("VrstaVozilaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
