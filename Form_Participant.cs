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
    public partial class Form_Participant : Form
    {
        ParticipantController _participantController;

        public Form_Participant()
        {
            InitializeComponent();

            // Initialiser le contrôleur du participant
            _participantController = new ParticipantController(new ParticipantService(new Dao<Participant>(new UPFCONFContext())));
        }

        private void intervenantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Intervenant().Show();
        }

        private void Form_Participant_Load(object sender, EventArgs e)
        {
            // Charger les données dans le DataGridView lors du chargement du formulaire
            LoadParticipants();
        }

        private void LoadParticipants()
        {
            // Charger les participants depuis la base de données et les afficher dans le DataGridView
            dataGridView1.DataSource = _participantController.GetAllParticipants().ToList();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            // Récupérer les informations du formulaire
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            string email = Email.Text;
            string sexe = Sexe.SelectedItem.ToString();

            // Ajouter le participant
            _participantController.AjouterParticipant(nom, prenom, sexe, email);

            // Recharger les participants dans le DataGridView
            LoadParticipants();

            // Vider les champs du formulaire
            ClearFields();
        }

        private void selectionner_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du participant sélectionné
                int participantId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Afficher les détails du participant sélectionné dans le formulaire
                Participant participant = _participantController.GetParticipantById(participantId);
                if (participant != null)
                {
                    Nom.Text = participant.Nom;
                    Prenom.Text = participant.Prenom;
                    Email.Text = participant.Email;
                    Sexe.SelectedItem = participant.Sexe;
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un participant à afficher.");
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du participant sélectionné
                int participantId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Récupérer les nouvelles informations du formulaire
                string nom = Nom.Text;
                string prenom = Prenom.Text;
                string email = Email.Text;
                string sexe = Sexe.SelectedItem.ToString();

                // Mettre à jour le participant
                _participantController.ModifierParticipant(participantId, nom, prenom, sexe, email);

                // Recharger les participants dans le DataGridView
                LoadParticipants();

                // Vider les champs du formulaire
                ClearFields();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un participant à modifier.");
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Demander confirmation à l'utilisateur avant de supprimer le participant
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce participant ?", "Confirmation de suppression", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Récupérer l'ID du participant sélectionné
                    int participantId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    // Supprimer le participant
                    _participantController.SupprimerParticipant(participantId);

                    // Recharger les participants dans le DataGridView
                    LoadParticipants();

                    // Vider les champs du formulaire
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un participant à supprimer.");
            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            // Vider les champs du formulaire
            ClearFields();
        }

        private void ClearFields()
        {
            Nom.Text = "";
            Prenom.Text = "";
            Email.Text = "";
            Sexe.SelectedIndex = -1;
        }
    }
}
