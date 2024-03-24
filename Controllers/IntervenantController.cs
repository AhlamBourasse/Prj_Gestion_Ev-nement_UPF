using Prj_Gestion_Evénement_UPF.Entities;
using Prj_Gestion_Evénement_UPF.Services.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Gestion_Evénement_UPF.Controllers
{
    public class IntervenantController
    {
        private readonly IntervenantService _service;

        public IntervenantController(IntervenantService service)
        {
            _service = service;
        }

        public IEnumerable<Intervenant> GetAllIntervenants()
        {
            return _service.GetAll();
        }

        public void AjouterIntervenant(string nom, string prenom, string specialite, string sexe, string email)
        {
            var intervenant = new Intervenant
            {
                Nom = nom,
                Prenom = prenom,
                Specialite = specialite,
                Sexe = sexe,
                Email = email
            };
            _service.Add(intervenant);
        }

        public void ModifierIntervenant(int intervenantId, string nom, string prenom,  string specialite, string sexe, string email)
        {
            var intervenant = _service.GetById(intervenantId);
            if (intervenant != null)
            {
                intervenant.Nom = nom;
                intervenant.Prenom = prenom;
                intervenant.Specialite = specialite;
                intervenant.Email = email;
                intervenant.Sexe = sexe;
                _service.Update(intervenant);
            }
            else
            {
                MessageBox.Show("Intervenant introuvable !");
            }
        }

        public void SupprimerIntervenant(int intervenantId)
        {
            var intervenant = _service.GetById(intervenantId);
            if (intervenant != null)
            {
                _service.Remove(intervenant);
            }
            else
            {
                MessageBox.Show("Intervenant introuvable !");
            }
        }
        public Intervenant GetIntervenantById(int intervenantId)
        {
            return _service.GetById(intervenantId);
        }

    }
}
