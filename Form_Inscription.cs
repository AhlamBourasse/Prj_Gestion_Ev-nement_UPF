using Prj_Gestion_Evénement_UPF.Controllers;
using Prj_Gestion_Evénement_UPF.DAO.Impl;
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
    public partial class Form_Inscription : Form
    {
        private EvenementController _evenementController;
        private ParticipantController _participantController;
        private InscriptionController _inscriptionController;

        public Form_Inscription()
        {
            InitializeComponent();
            var dbContext = new UPFCONFContext();

            var evenementDao = new Dao<Evenement>(dbContext);
            var evenementService = new EvenementService(evenementDao);
            _evenementController = new EvenementController(evenementService);

            _participantController = new ParticipantController(new ParticipantService(new Dao<Participant>(dbContext)));

            _inscriptionController = new InscriptionController(new InscriptionService(new Dao<Inscription>(dbContext)));

            // Remplir ComboBox avec les noms complets des participants
            comboBox1.DisplayMember = "NomComplet";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = _participantController.GetAllParticipants().ToList();

            // Remplir ComboBox avec les titres des événements
            comboBox2.DisplayMember = "Titre";
            comboBox2.ValueMember = "Id";
            comboBox2.DataSource = _evenementController.GetAllEvenements().ToList();
        }
        private void Form_Inscription_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            // Remplir ComboBox avec les noms complets des participants
            comboBox1.DisplayMember = "NomComplet";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = _participantController.GetAllParticipants().ToList();

            // Remplir ComboBox avec les titres des événements
            comboBox2.DisplayMember = "Titre";
            comboBox2.ValueMember = "Id";
            comboBox2.DataSource = _evenementController.GetAllEvenements().ToList();
        }
        private void FillDataGridView()
        {
            // Récupérer toutes les inscriptions à partir du contrôleur d'inscription
            var inscriptions = _inscriptionController.GetAllInscriptions();

            // Définir la source de données du DataGridView comme la liste des inscriptions
            dataGridView1.DataSource = inscriptions.ToList();
        }


        private void ajouter_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs sélectionnées dans les ComboBox
            int participantId = (int)comboBox1.SelectedValue;
            int evenementId = (int)comboBox2.SelectedValue;

            // Ajouter l'inscription
            _inscriptionController.AjouterInscription(evenementId, participantId);

            // Actualiser la vue
            MessageBox.Show("Inscription ajoutée avec succès.");
            FillDataGridView();
        }

        private void selectionner_Click(object sender, EventArgs e)
        {
            // Vérifier si une inscription est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'inscription sélectionnée
                int inscriptionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Afficher les détails de l'inscription sélectionnée dans le formulaire
                Inscription inscription = _inscriptionController.GetInscriptionById(inscriptionId);
                if (inscription != null)
                {
                    comboBox1.SelectedValue = inscription.ParticipantId;
                    comboBox2.SelectedValue = inscription.EvenementId;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une inscription à afficher.");
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            // Vérifier si une inscription est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'inscription sélectionnée
                int inscriptionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Récupérer les nouvelles valeurs sélectionnées dans les ComboBox
                int participantId = (int)comboBox1.SelectedValue;
                int evenementId = (int)comboBox2.SelectedValue;

                // Modifier l'inscription
                _inscriptionController.ModifierInscription(inscriptionId, evenementId, participantId);

                // Actualiser la vue
                MessageBox.Show("Inscription modifiée avec succès.");
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une inscription à modifier.");
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si une inscription est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'inscription sélectionnée
                int inscriptionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Supprimer l'inscription
                _inscriptionController.SupprimerInscription(inscriptionId);

                // Actualiser la vue
                MessageBox.Show("Inscription supprimée avec succès.");
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une inscription à supprimer.");
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            // Réinitialiser les ComboBox
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
    }
}
