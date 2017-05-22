﻿using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace DDR2.EHotelBaza.Models
{
    class SobaDbContext: DbContext
    {
        //Svi restorani koji su u tabeli se dobijaju iz ovog seta
        public DbSet<Soba> Sobe { get; set; }
        //Metoda koja će promijeniti konfiguraciju i odrediti gdje se spašava klasa i kako se zove.
        //Ovisno od uređaja spasiti će se na različite lokacije, za desktop se kreira poseban folder
        //u AppData/Local Folderu od korisnika
        //Svaki korisnik koji pokrene aplikaciju će imati kreiranu bazu lokalno kod sebe
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "NovaBaza.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path,
                databaseFilePath);
            }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
            modelBuilder.Entity<Soba>().Property(p => p.Slika).HasColumnType("image");
        }
    }
}
