using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.Entities
{
    public class Intervenant : Personne
    {
        [Required]
        public string Specialite { get; set; }

        public ICollection<Evenement> Evenements { get; set; }

        public Intervenant()
        {
            Evenements = new List<Evenement>(); // Initialisation de la collection dans le constructeur
        }


    }
}
