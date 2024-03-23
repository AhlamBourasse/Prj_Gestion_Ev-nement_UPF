using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Evénement
{
    public partial class frmParticipant : Form
    {
        public frmParticipant()
        {
            InitializeComponent();
        }

        private void frmParticipant_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionEvenementsDataSet.Participants'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.participantsTableAdapter.Fill(this.gestionEvenementsDataSet.Participants);
            ClearFormFields();
            LoadEvents();

            AutoInc();
        }
        private void AutoInc()
        {
            int a;
            String path1 = "Data Source=.;Initial Catalog=GestionEvenements;Integrated Security=True";
            SqlConnection con = new SqlConnection(path1);
            con.Open();
            string query = "Select Max(IdParticipant) from Participants";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtID.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtID.Text = a.ToString();
                }
            }
            txtID.ReadOnly = true;
        }
        private void ClearFormFields()
        {
            txtID.Text = "";
            txtNom.Text = "";
            txtPrénom.Text = "";
            txtMail.Text = "";
            txtAffiliation.Text = "";
        }
        private int GetSelectedEventId()
        {
            if (dgvParticipant.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvParticipant.SelectedRows[0];
                return int.Parse(selectedRow.Cells[0].Value.ToString());
            }
            else
            {
                return -1;
            }
        }
        private void LoadEvents()
        {
            var context = new GestionEvenement();
            dgvParticipant.DataSource = context.Participants.ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (var context = new GestionEvenement())
            {

                if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrénom.Text) ||
                    string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtAffiliation.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Participant participant = new Participant 
                {
                    Nom = txtNom.Text,
                    Prenom=txtPrénom.Text,
                    Email=txtMail.Text,
                    Affiliation=txtAffiliation.Text
                };


                context.Participants.Add(participant);

                ClearFormFields();

                
                try
                {
                    context.SaveChanges();
                    // Participant addedEvent = context.Participants.OrderByDescending(a => a.IdParticipant).FirstOrDefault(); 
                    //dgvParticipant.Rows.Add(addedEvent.IdParticipant, addedEvent.Nom, addedEvent.Prenom, addedEvent.Email, addedEvent.Affiliation);
                    RefreshDataGridView();
                    MessageBox.Show("Participant ajouté avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de l'ajout d'un participant : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RefreshDataGridView()
        {
            var context = new GestionEvenement();
            dgvParticipant.DataSource = null;
            dgvParticipant.DataSource = context.Participants.ToList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new GestionEvenement())
            {
                if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrénom.Text) ||
                    string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtAffiliation.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int selectedEventId = GetSelectedEventId();

                Participant participant = context.Participants.Find(selectedEventId);

                if (participant == null)
                {
                    MessageBox.Show("Aucun participant n'est sélectionné pour la modification.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                participant.Nom=txtNom.Text;
                participant.Prenom=txtPrénom.Text;
                participant.Email=txtMail.Text;
                participant.Affiliation=txtAffiliation.Text;


                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Participant modifié avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    ClearFormFields();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de la modification de particiipant : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var context = new GestionEvenement();
            int selectedEventId = GetSelectedEventId();

            Participant participant = context.Participants.Find(selectedEventId);

            if (participant == null)
            {
                MessageBox.Show("Aucun participant n'est sélectionné pour la suppression.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet participant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                context.Participants.Remove(participant);

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Participant supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    ClearFormFields();

                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"Une erreur est survenue lors de la suppression d'un participant : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvParticipant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new GestionEvenement();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvParticipant.Rows[e.RowIndex];
                Participant participant = selectedRow.DataBoundItem as Participant;
                if (participant != null)
                {
                    txtID.Text = participant.IdParticipant.ToString();
                    txtNom.Text= participant.Nom.ToString();
                    txtPrénom.Text=participant.Prenom.ToString();
                    txtMail.Text=participant.Email.ToString();
                    txtAffiliation.Text=participant.Affiliation.ToString();

                    txtID.Enabled = false;
                    txtNom.Enabled = true;
                    txtPrénom.Enabled = true;
                    txtMail.Enabled = true;
                    txtAffiliation.Enabled = true;
                }
            }
        }
    }
}
