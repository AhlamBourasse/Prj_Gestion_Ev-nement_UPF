using Prj_Gestion_Evénement_UPF.Enums;
using Prj_Gestion_Evénement_UPF.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Gestion_Evénement_UPF.Controllers
{
    public class EvenementController
    {
        private readonly EvenementService _service;

        public EvenementController(EvenementService service)
        {
            _service = service;
        }

        public IEnumerable<Evenement> GetAllEvenements()
        {
            return _service.GetAll();
        }

        public void AjouterEvenement(string titre, TypeEvenement type, DateTime dateDebut, DateTime dateFin, string lieu, int intervenantId)
        {
            var evenement = new Evenement
            {
                Titre = titre,
                Type = type,
                DateDebut = dateDebut,
                DateFin = dateFin,
                Lieu = lieu,
                IntervenantId = intervenantId
            };
            _service.Add(evenement);
        }

        public void ModifierEvenement(int evenementId, string titre, TypeEvenement type, DateTime dateDebut, DateTime dateFin, string lieu, int intervenantId)
        {
            var evenement = _service.GetById(evenementId);
            if (evenement != null)
            {
                evenement.Titre = titre;
                evenement.Type = type;
                evenement.DateDebut = dateDebut;
                evenement.DateFin = dateFin;
                evenement.Lieu = lieu;
                evenement.IntervenantId = intervenantId;
                _service.Update(evenement);
            }
            else
            {
                MessageBox.Show("Événement introuvable !");
            }
        }

        public void SupprimerEvenement(int evenementId)
        {
            var evenement = _service.GetById(evenementId);
            if (evenement != null)
            {
                _service.Remove(evenement);
            }
            else
            {
                MessageBox.Show("Événement introuvable !");
            }
        }
        public Evenement GetEvenementById(int evenementId)
        {
            return _service.GetById(evenementId);
        }
    }
}
