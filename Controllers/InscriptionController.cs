using Prj_Gestion_Evénement_UPF.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Gestion_Evénement_UPF.Controllers
{
    public class InscriptionController
    {
        private readonly InscriptionService _service;

        public InscriptionController(InscriptionService service)
        {
            _service = service;
        }

        public IEnumerable<Inscription> GetAllInscriptions()
        {
            return _service.GetAll();
        }

        public void AjouterInscription(int evenementId, int participantId)
        {
            var inscription = new Inscription
            {
                EvenementId = evenementId,
                ParticipantId = participantId,
                DateInscription = DateTime.Now
            };
            _service.Add(inscription);
        }

        public void ModifierInscription(int inscriptionId, int evenementId, int participantId)
        {
            var inscription = _service.GetById(inscriptionId);
            if (inscription != null)
            {
                inscription.EvenementId = evenementId;
                inscription.ParticipantId = participantId;
                _service.Update(inscription);
            }
            else
            {
                MessageBox.Show("Inscription introuvable !");
            }
        }

        public void SupprimerInscription(int inscriptionId)
        {
            var inscription = _service.GetById(inscriptionId);
            if (inscription != null)
            {
                _service.Remove(inscription);
            }
            else
            {
                MessageBox.Show("Inscription introuvable !");
            }
        }

        public Inscription GetInscriptionById(int inscriptionId)
        {
            return _service.GetById(inscriptionId);
        }
    }
}
