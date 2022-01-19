using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ProiectFinalForm.Models
{
    internal class Meniuri
    {
        public int Id { get; set; }

        public string NumeMeniu { get; set; }

        public int Pret { get; set; }

        public string Continut { get; set; }
    }

    class MeniuriDbContext : DbContext
    {
        public DbSet<Meniuri> Meniu { get; set; }
    }
}
