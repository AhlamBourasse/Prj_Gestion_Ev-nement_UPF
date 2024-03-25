namespace Prj_Gestion_Evénement_UPF
{
    partial class Form_Participant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.intervenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.ComboBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ajouter = new System.Windows.Forms.Button();
            this.selectionner = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervenantsToolStripMenuItem,
            this.participantsToolStripMenuItem,
            this.evenementsToolStripMenuItem,
            this.inscriptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // intervenantsToolStripMenuItem
            // 
            this.intervenantsToolStripMenuItem.Name = "intervenantsToolStripMenuItem";
            this.intervenantsToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.intervenantsToolStripMenuItem.Text = "Intervenants";
            this.intervenantsToolStripMenuItem.Click += new System.EventHandler(this.intervenantsToolStripMenuItem_Click);
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.participantsToolStripMenuItem.Text = "Participants";
            // 
            // evenementsToolStripMenuItem
            // 
            this.evenementsToolStripMenuItem.Name = "evenementsToolStripMenuItem";
            this.evenementsToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.evenementsToolStripMenuItem.Text = "Evenements";
            // 
            // inscriptionsToolStripMenuItem
            // 
            this.inscriptionsToolStripMenuItem.Name = "inscriptionsToolStripMenuItem";
            this.inscriptionsToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.inscriptionsToolStripMenuItem.Text = "Inscriptions";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(856, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nom";
            // 
            // Sexe
            // 
            this.Sexe.FormattingEnabled = true;
            this.Sexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.Sexe.Location = new System.Drawing.Point(641, 94);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(200, 28);
            this.Sexe.TabIndex = 19;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(911, 97);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(200, 26);
            this.Email.TabIndex = 18;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(353, 97);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(200, 26);
            this.Prenom.TabIndex = 17;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(60, 97);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(200, 26);
            this.Nom.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 323);
            this.dataGridView1.TabIndex = 24;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(16, 492);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(204, 52);
            this.ajouter.TabIndex = 25;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // selectionner
            // 
            this.selectionner.Location = new System.Drawing.Point(235, 492);
            this.selectionner.Name = "selectionner";
            this.selectionner.Size = new System.Drawing.Size(204, 52);
            this.selectionner.TabIndex = 26;
            this.selectionner.Text = "Selectionner";
            this.selectionner.UseVisualStyleBackColor = true;
            this.selectionner.Click += new System.EventHandler(this.selectionner_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(455, 492);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(204, 52);
            this.modifier.TabIndex = 27;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(675, 492);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(204, 52);
            this.supprimer.TabIndex = 28;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(895, 492);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(204, 52);
            this.annuler.TabIndex = 29;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // Form_Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1123, 560);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.selectionner);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sexe);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Participant";
            this.Text = "Form_Participant";
            this.Load += new System.EventHandler(this.Form_Participant_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem intervenantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Sexe;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button selectionner;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button annuler;
    }
}