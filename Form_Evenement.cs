using Prj_Gestion_Evénement_UPF.Controllers;
using Prj_Gestion_Evénement_UPF.DAO.Impl;
using Prj_Gestion_Evénement_UPF.Entities;
using Prj_Gestion_Evénement_UPF.Enums;
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
    public partial class Form_Evenement : Form
    {
        private EvenementController _evenementController;
        private IntervenantController _intervenantController;
        public Form_Evenement()
        {
            InitializeComponent();
            // Créer une instance de DbContext appropriée
            var dbContext = new UPFCONFContext(); // Assurez-vous que VotreDbContext est correctement configuré

            var evenementDao = new Dao<Evenement>(dbContext); // Assurez-vous que VotreDbContext est correctement configuré

            var evenementService = new EvenementService(evenementDao);

            _evenementController = new EvenementController(evenementService);

            // Créer une instance de IntervenantDao
            var intervenantDao = new Dao<Intervenant>(dbContext); // Assurez-vous que VotreDbContext est correctement configuré

            // Passer IntervenantDao à IntervenantService lors de son instanciation
            var intervenantService = new IntervenantService(intervenantDao);

            // Passer IntervenantService à IntervenantController lors de son instanciation
            _intervenantController = new IntervenantController(intervenantService);
        }

        private void Form_Evenement_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(TypeEvenement));
            RefreshDataGridView();

            // Récupérer tous les intervenants
            var intervenants = _intervenantController.GetAllIntervenants();

            // Définir la source de données du ComboBox
            comboBox2.DataSource = intervenants;

            // Définir la propriété à afficher dans le ComboBox (ici, Nom et Prenom)
            comboBox2.DisplayMember = "NomComplet"; // NomComplet représente une propriété virtuelle dans l'entité Intervenant qui combine Nom et Prenom

            // Définir la propriété à utiliser pour la valeur sélectionnée (ici, Id)
            comboBox2.ValueMember = "Id";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            // Réinitialiser les champs de saisie
            titre.Text = "";
            comboBox1.SelectedIndex = -1;
            dateDebut.SetDate(DateTime.Today);
            dateFin.SetDate(DateTime.Today);
            lieu.Text = "";
            comboBox2.SelectedIndex = -1;
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des champs de saisie
                string titreEvenement = titre.Text;
                TypeEvenement typeEvenement = (TypeEvenement)comboBox1.SelectedItem;
                DateTime dateDebutEvenement = dateDebut.SelectionStart;
                DateTime dateFinEvenement = dateFin.SelectionStart;
                string lieuEvenement = lieu.Text;
                int intervenantId = (int)comboBox2.SelectedValue; // Récupérer l'ID de l'intervenant sélectionné dans le ComboBox

                // Appeler la méthode AjouterEvenement du contrôleur EvenementController
                _evenementController.AjouterEvenement(titreEvenement, typeEvenement, dateDebutEvenement, dateFinEvenement, lieuEvenement, intervenantId);

                // Vider les champs de saisie après l'ajout
                Cancel_Click(sender, e);

                // Actualiser les données affichées dans le DataGridView
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout de l'événement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si une ligne est sélectionnée dans le DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Récupérer l'ID de l'événement sélectionné
                    int evenementId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    // Récupérer les valeurs des champs de saisie
                    string titreEvenement = titre.Text;
                    TypeEvenement typeEvenement = (TypeEvenement)comboBox1.SelectedItem;
                    DateTime dateDebutEvenement = dateDebut.SelectionStart;
                    DateTime dateFinEvenement = dateFin.SelectionStart;
                    string lieuEvenement = lieu.Text;
                    int intervenantId = (int)comboBox2.SelectedValue; // Récupérer l'ID de l'intervenant sélectionné dans le ComboBox

                    // Appeler la méthode ModifierEvenement du contrôleur EvenementController
                    _evenementController.ModifierEvenement(evenementId, titreEvenement, typeEvenement, dateDebutEvenement, dateFinEvenement, lieuEvenement, intervenantId);

                    // Vider les champs de saisie après la modification
                    Cancel_Click(sender, e);

                    // Actualiser les données affichées dans le DataGridView
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un événement à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la modification de l'événement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si une ligne est sélectionnée dans le DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Récupérer l'ID de l'événement sélectionné
                    int evenementId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    // Appeler la méthode SupprimerEvenement du contrôleur EvenementController
                    _evenementController.SupprimerEvenement(evenementId);

                    // Actualiser les données affichées dans le DataGridView
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un événement à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression de l'événement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectionner_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'événement sélectionné
                int evenementId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Récupérer l'événement correspondant à l'ID sélectionné
                Evenement evenement = _evenementController.GetEvenementById(evenementId);

                // Afficher les détails de l'événement sélectionné dans les champs de saisie
                titre.Text = evenement.Titre;
                comboBox1.SelectedItem = evenement.Type;
                dateDebut.SetDate(evenement.DateDebut);
                dateFin.SetDate(evenement.DateFin);
                lieu.Text = evenement.Lieu;
                comboBox2.SelectedValue = evenement.IntervenantId;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un événement à afficher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            // Charger toutes les données des événements dans le DataGridView
            dataGridView1.DataSource = _evenementController.GetAllEvenements().ToList();
        }

        private void intervenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form_Intervenant().Show();
            
        }

        private void participantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form_Participant();
        }
    }
}
