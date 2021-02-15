using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppServer.Models
{
    public class Section
    {
        [Key]
        public string Code { get; set; }

        public string Nom { get; set; }

        public ICollection<Classe> Classes { get; set; }
    }
}
