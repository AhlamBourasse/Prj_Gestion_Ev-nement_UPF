using Prj_Gestion_Evénement_UPF.Controllers;
using Prj_Gestion_Evénement_UPF.DAO.Impl;
using Prj_Gestion_Evénement_UPF.Entities;
using Prj_Gestion_Evénement_UPF.Services.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Gestion_Evénement_UPF
{
    public partial class Form_Intervenant : Form
    {
        private IntervenantController _intervenantController;

        public Form_Intervenant()
        {
            InitializeComponent();

            // Créer une instance de DbContext appropriée
            var dbContext = new UPFCONFContext(); // Assurez-vous que VotreDbContext est correctement configuré

            // Créer une instance de IntervenantDao
            var intervenantDao = new Dao<Intervenant>(dbContext); // Assurez-vous que VotreDbContext est correctement configuré

            // Passer IntervenantDao à IntervenantService lors de son instanciation
            var intervenantService = new IntervenantService(intervenantDao);

            // Passer IntervenantService à IntervenantController lors de son instanciation
            _intervenantController = new IntervenantController(intervenantService);
        }

        private void Form_Intervenant_Load(object sender, EventArgs e)
        {
            // Charger les données dans le DataGridView lors du chargement du formulaire
            RefreshDataGridView();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des contrôles de saisie
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            DateTime dateNaissance = DateTime.Today; // Assurez-vous que le contrôle est correctement nommé
            string specialite = Spécialié.Text;
            string sexe = Sexe.Text;
            string email = Email.Text;

            try
            {
                // Appeler la méthode AjouterIntervenant du contrôleur
                _intervenantController.AjouterIntervenant(nom, prenom, dateNaissance, specialite, sexe, email);

                // Actualiser les données affichées dans le DataGridView
                RefreshDataGridView();

                MessageBox.Show("Intervenant ajouté avec succès.");
                Nom.Text = "";
                Prenom.Text = "";
                Spécialié.Text = "";
                Email.Text = "";
                Sexe.SelectedIndex = -1; // Réinitialiser la sélection du sexe
                // Réinitialiser la date de naissance
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'intervenant : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Supprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'intervenant sélectionné
                int intervenantId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Appeler la méthode SupprimerIntervenant du contrôleur
                _intervenantController.SupprimerIntervenant(intervenantId);

                // Actualiser les données affichées dans le DataGridView
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un intervenant à supprimer.");
            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            // Réinitialiser les valeurs des contrôles de saisie
            Nom.Text = "";
            Prenom.Text = "";
            Spécialié.Text = "";
            Email.Text = "";
            Sexe.SelectedIndex = -1; // Réinitialiser la sélection du sexe
            dateNaissance.Value = DateTime.Today; // Réinitialiser la date de naissance
        }

        private void RefreshDataGridView()
        {
            // Charger toutes les données des intervenants dans le DataGridView
            dataGridView1.DataSource = _intervenantController.GetAllIntervenants().ToList();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer les données de la ligne sélectionnée
                int intervenantId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string nom = Nom.Text;
                string prenom = Prenom.Text;
                string specialite = Spécialié.Text;
                string sexe = Sexe.Text;
                string email = Email.Text;

                // Appeler la méthode ModifierIntervenant du contrôleur
                _intervenantController.ModifierIntervenant(intervenantId, nom, prenom, specialite, sexe, email);

                // Actualiser les données affichées dans le DataGridView
                RefreshDataGridView();

                MessageBox.Show("Intervenant modifié avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un intervenant à modifier.");
            }
        }

        private void Selectionner_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer les données de la ligne sélectionnée
                int intervenantId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Appeler une méthode pour récupérer l'intervenant sélectionné et afficher ses détails
                var intervenant = _intervenantController.GetIntervenantById(intervenantId);

                // Afficher les détails de l'intervenant dans les contrôles de saisie
                Nom.Text = intervenant.Nom;
                Prenom.Text = intervenant.Prenom;
                dateNaissance.Value = intervenant.DateNaissance;
                Spécialié.Text = intervenant.Specialite;
                Sexe.Text = intervenant.Sexe;
                Email.Text = intervenant.Email;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un intervenant.");
            }
        }

    }

}
