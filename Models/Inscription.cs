using System;

namespace BlazorAppServer.Models
{
    public class Inscription
    {
        public int Id { get; set; }

        public string Matricule { get; set; }

        public string NumClasse { get; set; }

        public DateTime DateInscription { get; set; }

        public string AnneeScolaire { get; set; }
    }
}
