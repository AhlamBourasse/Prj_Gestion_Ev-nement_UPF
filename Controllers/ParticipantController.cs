using Prj_Gestion_Evénement_UPF.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Gestion_Evénement_UPF.Controllers
{
    public class ParticipantController
    {
        private readonly ParticipantService _service;

        public ParticipantController(ParticipantService service)
        {
            _service = service;
        }

        public IEnumerable<Participant> GetAllParticipants()
        {
            return _service.GetAll();
        }

        public void AjouterParticipant(string nom, string prenom,string sexe, string email)
        {
            var participant = new Participant
            {
                Nom = nom,
                Prenom = prenom,
                Sexe = sexe,
                Email = email,
                
            };
            _service.Add(participant);
        }

        public void ModifierParticipant(int participantId, string nom, string prenom, string email , string sexe)
        {
            var participant = _service.GetById(participantId);
            if (participant != null)
            {
                participant.Nom = nom;
                participant.Prenom = prenom;
                participant.Email = email;
                participant.Sexe = sexe;
                _service.Update(participant);
            }
            else
            {
                MessageBox.Show("Participant introuvable !");
            }
        }

        public void SupprimerParticipant(int participantId)
        {
            var participant = _service.GetById(participantId);
            if (participant != null)
            {
                _service.Remove(participant);
            }
            else
            {
                MessageBox.Show("Participant introuvable !");
            }
        }
    }
}
