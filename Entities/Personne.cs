using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.Entities
{
    public class Personne
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public string Sexe { get; set; }

        [Required]
        public string Email { get; set; }

        public string NomComplet => $"{Nom} {Prenom}";

    }
}
