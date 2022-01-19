using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace ProiectFinalForm.Models
{
    internal class Utilizator
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Denumirea trebuie sa fie mai mica de 30 de caractere")]
        public string Nume { get; set; }

        [MaxLength(30, ErrorMessage = "Numele utilizatrului trebuie sa fie mai mica de 30 de caractere")]
        public string Prenume { get; set; }

        [MaxLength(30, ErrorMessage = "Prenumele utilizatrului trebuie sa fie mai mica de 30 de caractere")]
        public string Username { get; set; }

        [MaxLength(30, ErrorMessage = "Username-ul trebuie sa fie mai mica de 30 de caractere")]
        public string Parola { get; set; }

    }

    class UtilizatorDbContext : DbContext
    {
        public DbSet<Utilizator> Utilizatori { get; set; }
    }
}
