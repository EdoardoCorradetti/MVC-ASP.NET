using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GamCollection.Models
{
    public class CollezioniContext:DbContext
    {
        public CollezioniContext()
        {
            this.Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["CollezioniConnection"].ConnectionString;
        }

        public DbSet<Autore> Autori { get; set; }
        public DbSet<Datazione> Datazioni { get; set; }
        public DbSet<Mostra> Mostre { get; set; }
    }
}