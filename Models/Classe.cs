using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppServer.Models
{
    public class Classe
    {
        [Key]
        public string Numero { get; set; }

        public string Nom { get; set; }

        [ForeignKey(nameof(Section))]
        public string SectionId { get; set; }

        public Section Section { get; set; }

        public ICollection<Eleve> Eleves { get; set; }
    }
}
