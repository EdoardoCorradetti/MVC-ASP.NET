using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GamCollection.Models
{
    [Table("Autori")]
    public class Autore
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}