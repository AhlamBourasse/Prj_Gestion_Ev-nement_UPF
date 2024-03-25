namespace Prj_Gestion_Evénement_UPF
{
    partial class Form_Evenement
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
            this.intervenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateDebut = new System.Windows.Forms.MonthCalendar();
            this.dateFin = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.lieu = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.selectionner = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervenantToolStripMenuItem,
            this.participantToolStripMenuItem,
            this.evenementToolStripMenuItem,
            this.inscriptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // intervenantToolStripMenuItem
            // 
            this.intervenantToolStripMenuItem.Name = "intervenantToolStripMenuItem";
            this.intervenantToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.intervenantToolStripMenuItem.Text = "Intervenants";
            this.intervenantToolStripMenuItem.Click += new System.EventHandler(this.intervenantToolStripMenuItem_Click);
            // 
            // participantToolStripMenuItem
            // 
            this.participantToolStripMenuItem.Name = "participantToolStripMenuItem";
            this.participantToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.participantToolStripMenuItem.Text = "Participants";
            this.participantToolStripMenuItem.Click += new System.EventHandler(this.participantToolStripMenuItem_Click);
            // 
            // evenementToolStripMenuItem
            // 
            this.evenementToolStripMenuItem.Name = "evenementToolStripMenuItem";
            this.evenementToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.evenementToolStripMenuItem.Text = "Evenements";
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(550, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(710, 612);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type d\'événement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date début";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date fin";
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(188, 98);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(312, 26);
            this.titre.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(188, 189);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.TabIndex = 9;
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(188, 460);
            this.dateFin.Name = "dateFin";
            this.dateFin.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 746);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lieu";
            // 
            // lieu
            // 
            this.lieu.Location = new System.Drawing.Point(188, 740);
            this.lieu.Name = "lieu";
            this.lieu.Size = new System.Drawing.Size(312, 26);
            this.lieu.TabIndex = 12;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(550, 725);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(133, 44);
            this.ajouter.TabIndex = 14;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // selectionner
            // 
            this.selectionner.Location = new System.Drawing.Point(689, 725);
            this.selectionner.Name = "selectionner";
            this.selectionner.Size = new System.Drawing.Size(139, 44);
            this.selectionner.TabIndex = 15;
            this.selectionner.Text = "Selectionner";
            this.selectionner.UseVisualStyleBackColor = true;
            this.selectionner.Click += new System.EventHandler(this.selectionner_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(834, 725);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(140, 44);
            this.modifier.TabIndex = 16;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(1131, 725);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(129, 44);
            this.supprimer.TabIndex = 17;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(985, 725);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(140, 44);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(188, 781);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(312, 28);
            this.comboBox2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 784);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Intervenant";
            // 
            // Form_Evenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1292, 821);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.selectionner);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.lieu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Evenement";
            this.Text = "Form_Evenement";
            this.Load += new System.EventHandler(this.Form_Evenement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem intervenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar dateDebut;
        private System.Windows.Forms.MonthCalendar dateFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lieu;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button selectionner;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
    }
}