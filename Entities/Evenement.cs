using Prj_Gestion_Evénement_UPF.Entities;
using Prj_Gestion_Evénement_UPF.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF
{
    public class Evenement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titre { get; set; }

        [Required]
        public TypeEvenement Type { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public string Lieu { get; set; }

        [Required]
        public int IntervenantId { get; set; }

        [ForeignKey("IntervenantId")]
        public Intervenant Intervenant { get; set; }

    }
}
