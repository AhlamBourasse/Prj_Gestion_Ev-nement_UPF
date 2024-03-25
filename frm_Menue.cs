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
    public partial class frm_Menue : Form
    {
        public frm_Menue()
        {
            InitializeComponent();
        }

        private void intervenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Intervenant frm = new Form_Intervenant();
            frm.Show();
        }

        private void evenementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Evenement frmevent = new Form_Evenement();
            frmevent.Show();
        }

        private void frm_Menue_Load(object sender, EventArgs e)
        {

        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Participant().Show();
        }

        private void inscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Inscription().Show();
        }
    }
}
