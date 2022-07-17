using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GamCollection.Models
{
    public class CollezioniContext:DbContext
    {
        public DbSet<Autore> Autori { get; set; }
        public DbSet<Datazione> Datazioni { get; set; }
        public DbSet<Mostra> Mostre { get; set; }
    }
}