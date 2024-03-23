using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.Entities
{
    public class Intervenant : Personne
    {
        [Required]
        public string Specialite { get; set; }
    }
}
