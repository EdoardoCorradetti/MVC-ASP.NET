using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamCollection.Models
{
    public class Mostra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Technique { get; set; }
        public string Dimension { get; set; }
        public string Image { get; set; }
        public Autore Autore { get; set; }
        public Datazione Datazione { get; set; }
    }
}