using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BlazorAppServer.Models
{
    public class Eleve
    {
         [Key]
         public string Matricule { get; set; }

         public string Nom { get; set; }

        public string Postnom { get; set; }

        public string LieuDeNaissance { get; set; }

        public Sexe Sexe { get; set; }

        public double Age
        {
            get { return DateTime.Now.Year - DateDeNaissance.GetValueOrDefault().Year; }
        }

        public DateTime? DateDeNaissance { get; set; } = new DateTime(2000, 01, 01);

        public string ClasseId { get; set; }

        public Classe Classe { get; set; }
    }
}
