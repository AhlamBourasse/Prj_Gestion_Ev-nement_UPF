using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF
{
    public class Inscription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EvenementId { get; set; }

        [Required]
        public int ParticipantId { get; set; }

        [ForeignKey("EvenementId")]
        public Evenement Evenement { get; set; }

        [ForeignKey("ParticipantId")]
        public Participant Participant { get; set; }

        public DateTime DateInscription { get; set; }
    }
}
