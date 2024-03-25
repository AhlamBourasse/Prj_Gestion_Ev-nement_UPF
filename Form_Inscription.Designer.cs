namespace Prj_Gestion_Evénement_UPF
{
    partial class Form_Inscription
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
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.inscriptionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1574, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // intervenantsToolStripMenuItem
            // 
            this.intervenantsToolStripMenuItem.Name = "intervenantsToolStripMenuItem";
            this.intervenantsToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.intervenantsToolStripMenuItem.Text = "Intervenants";
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
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.inscriptionToolStripMenuItem.Text = "Inscription";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(539, 391);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des inscriptions aux événements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Participant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Evénement";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(773, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(773, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(227, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(592, 319);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(153, 52);
            this.ajouter.TabIndex = 8;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // selectionner
            // 
            this.selectionner.Location = new System.Drawing.Point(847, 319);
            this.selectionner.Name = "selectionner";
            this.selectionner.Size = new System.Drawing.Size(153, 52);
            this.selectionner.TabIndex = 9;
            this.selectionner.Text = "Selectionner";
            this.selectionner.UseVisualStyleBackColor = true;
            this.selectionner.Click += new System.EventHandler(this.selectionner_Click);
            // 
            // modifier
            // 
            this.modifier.Location = new System.Drawing.Point(592, 397);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(153, 52);
            this.modifier.TabIndex = 10;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Location = new System.Drawing.Point(847, 397);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(153, 52);
            this.supprimer.TabIndex = 11;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(725, 467);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(153, 52);
            this.annuler.TabIndex = 12;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // Form_Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 546);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.selectionner);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Inscription";
            this.Text = "Form_Inscription";
            this.Load += new System.EventHandler(this.Form_Inscription_Load);
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
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button selectionner;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button annuler;
    }
}