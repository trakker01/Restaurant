using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace ProiectFinalForm.Models
{
    internal class CreareComanda
    {
        public int Id { get; set; }

        public string NumeMeniu { get; set; }

        public int Pret { get; set; }

        public int Cantitate { get; set; }
    }

    class CreareComandaDbContext : DbContext
    {
        public DbSet<CreareComanda> Comenzi { get; set; }
    }
}
