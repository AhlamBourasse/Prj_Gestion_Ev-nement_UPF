using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_Evénement
{
    public partial class frmInscriptions : Form
    {
        public frmInscriptions()
        {
            InitializeComponent();
        }

        private void frmInscriptions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionEvenementsDataSet.Inscriptions'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.inscriptionsTableAdapter.Fill(this.gestionEvenementsDataSet.Inscriptions);
            LoadEvents();
            RemplirComboBox();
            ClearFormFields();
            AutoInc();
            txtIdInscription.ReadOnly = true;
        }
        private void AutoInc()
        {
            int a;
            String path1 = "Data Source=.;Initial Catalog=GestionEvenements;Integrated Security=True";
            SqlConnection con = new SqlConnection(path1);
            con.Open();
            string query = "Select Max(IdInscription) from Inscriptions";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    txtIdInscription.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    txtIdInscription.Text = a.ToString();
                }
            }
        }
        private void LoadEvents()
        {
            var context = new GestionEvenement();
            dgvInscriptions.DataSource = context.Inscriptions.ToList();
        }
        private void RemplirComboBox()
        {

            SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=GestionEvenements;Integrated Security=True");
            connection.Open();


            string sql = "SELECT IdEvenement FROM Evenements";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {

                    string valeur = reader[0].ToString();


                    cmbIdEvenement.Items.Add(valeur);
                }

                reader.Close();
            }
            connection.Close();

            connection.Open ();
            string sqli = "SELECT IdParticipant FROM Participants";
            using (SqlCommand command = new SqlCommand(sqli, connection))
            {
                SqlDataReader read = command.ExecuteReader();


                while (read.Read())
                {

                    string valeur = read[0].ToString();


                    cmbIdParticipant.Items.Add(valeur);
                }

                read.Close();
            }

           

            connection.Close();
        }
        private void ClearFormFields()
        {
            txtIdInscription.Text = "";
            cmbIdParticipant. SelectedIndex = 0;
            cmbIdEvenement.SelectedIndex = 0;
            dtpDateInscription.Value = DateTime.Today;
            
        }
        private int GetSelectedEventId()
        {
            if (dgvInscriptions.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvInscriptions.SelectedRows[0];
                return int.Parse(selectedRow.Cells[0].Value.ToString());
            }
            else
            {
                return -1;
            }
        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
                using (var context = new GestionEvenement())
                {
                    var inscriptionRepository = new InscriptionRepository(context);

                    var idEvenement = int.Parse(cmbIdEvenement.SelectedItem.ToString());
                    var idParticipant = int.Parse(cmbIdEvenement.SelectedItem.ToString());
                    var dateInscription = dtpDateInscription.Value;

                    var nouvelleInscription = new Inscription
                    {
                        IdEvenement = idEvenement,
                        IdParticipant = idParticipant,
                        DateInscription = dateInscription
                    };

                    inscriptionRepository.Add(nouvelleInscription);
                    inscriptionRepository.SaveChanges();
                    RefreshDataGridView();
                    MessageBox.Show("Inscription ajoutée avec succès!");

                    
                    cmbIdEvenement.SelectedIndex = -1;
                    cmbIdParticipant.SelectedIndex = -1;
                    dtpDateInscription.Value = DateTime.Now;
                }
            

            //using (var context = new GestionEvenement())
            //{

            //    if ( string.IsNullOrEmpty(cmbIdEvenement.SelectedItem.ToString()) ||
            //        string.IsNullOrEmpty(cmbIdParticipant.SelectedItem.ToString()))
            //    {
            //        MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }


            //    Inscription inscription = new Inscription 
            //    {
            //        IdEvenement = int.Parse(cmbIdEvenement.SelectedItem.ToString()),
            //        IdParticipant = int.Parse(cmbIdParticipant.SelectedItem.ToString()),
            //        DateInscription =dtpDateInscription.Value
            //    };


            //    context.Inscriptions.Add(inscription);

            //    ClearFormFields();
            //    try
            //    {
            //        context.SaveChanges();
            //        RefreshDataGridView();
            //       // Inscription addevent =context.Inscriptions.OrderByDescending(a => a.IdEvenement).FirstOrDefault();
            //        //dgvInscriptions.Rows.Add(addevent.IdInscription,addevent.IdEvenement,addevent.IdParticipant,addevent.DateInscription);
            //        MessageBox.Show("Inscription ajouté avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //    }
            //    catch (DbUpdateException ex)
            //    {
            //        MessageBox.Show($"Une erreur est survenue lors de l'ajout d'inscription : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
        private void RefreshDataGridView()
        {
            var context = new GestionEvenement();
            dgvInscriptions.DataSource = null;
            dgvInscriptions.DataSource = context.Inscriptions.ToList(); 
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new GestionEvenement())
            {
                var inscriptionRepository = new InscriptionRepository(context);

                var id = int.Parse(txtIdInscription.Text);
                var inscription = inscriptionRepository.GetById(id);
                
                if (inscription != null)
                {
                    inscription.IdEvenement = int.Parse(cmbIdEvenement.SelectedItem.ToString());
                    inscription.IdParticipant = int.Parse(cmbIdEvenement.SelectedItem.ToString());
                    inscription.DateInscription = dtpDateInscription.Value;

                    inscriptionRepository.Update(inscription);
                    
                    inscriptionRepository.SaveChanges();

                    MessageBox.Show("Inscription modifiée avec succès!");
                }
                else
                {
                    MessageBox.Show("Aucune inscription trouvée avec l'ID " + id);
                }
            }
            //using(var context=new GestionEvenement())
            //{

            //    if (string.IsNullOrEmpty(cmbIdEvenement.SelectedItem.ToString()) ||
            //        string.IsNullOrEmpty(cmbIdParticipant.SelectedItem.ToString()))
            //    {
            //        MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }


            //    int selectedEventId = GetSelectedEventId();

            //    Inscription inscription = context.Inscriptions.Find(selectedEventId);

            //    if (inscription == null)
            //    {
            //        MessageBox.Show("Aucun inscription n'est sélectionné pour la modification.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }


            //    inscription.IdEvenement=int.Parse(cmbIdEvenement.SelectedItem.ToString());
            //    inscription.IdParticipant=int.Parse(cmbIdParticipant.SelectedItem.ToString());
            //    inscription.DateInscription=dtpDateInscription.Value;

            //    try
            //    {
            //        context.SaveChanges();
            //        MessageBox.Show("Inscription modifier avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        ClearFormFields();
            //    }
            //    catch (DbUpdateException ex)
            //    {
            //        MessageBox.Show($"Une erreur est survenue lors de la modification d'inscription : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new GestionEvenement())
            {
                var inscriptionRepository = new InscriptionRepository(context);

                var id = int.Parse(txtIdInscription.Text);
                var inscription = inscriptionRepository.GetById(id);

                if (inscription != null)
                {
                    inscriptionRepository.Delete(inscription);
                    inscriptionRepository.SaveChanges();
                    MessageBox.Show("Inscription supprimé avec succès!");
                }
                else
                {
                    MessageBox.Show("Aucune inscription trouvée avec l'ID " + id);
                }
            }
                    //var context = new GestionEvenement();
                    //int selectedEventId = GetSelectedEventId();

                    //Inscription inscription = context.Inscriptions.Find(selectedEventId);

                    //if (inscription == null)
                    //{
                    //    MessageBox.Show("Aucun événement n'est sélectionné pour la suppression.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    //if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet inscription ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    //{
                    //    context.Inscriptions.Remove(inscription);

                    //    try
                    //    {
                    //        context.SaveChanges();
                    //        MessageBox.Show("Inscription supprimé avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //        ClearFormFields();
                    //    }
                    //    catch (DbUpdateException ex)
                    //    {
                    //        MessageBox.Show($"Une erreur est survenue lors de la suppression de l'inscription : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                }

        private void dgvInscriptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new GestionEvenement();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvInscriptions.Rows[e.RowIndex];
                Inscription inscription = selectedRow.DataBoundItem as Inscription;
                if (inscription != null)
                {
                    txtIdInscription.Text=inscription.IdInscription.ToString();
                    cmbIdEvenement.SelectedItem=inscription.IdEvenement.ToString();
                    cmbIdParticipant.SelectedItem=inscription.IdParticipant.ToString();
                    dtpDateInscription.Value=inscription.DateInscription;


                    txtIdInscription.Enabled=false;
                    cmbIdEvenement.Enabled=true;
                    cmbIdParticipant.Enabled=true;
                    dtpDateInscription.Enabled=true;
                }
            }
        }
    }
}
