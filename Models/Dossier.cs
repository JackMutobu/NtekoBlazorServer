using System;

namespace BlazorAppServer.Models
{
    public class Dossier
    {
        public string Code { get; set; }

        public int Numero { get; set; }

        public string Nom { get; set; }

        public DateTime DateEnregistrement { get; set; }
    }
}
