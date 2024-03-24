namespace Prj_Gestion_Evénement_UPF
{
    partial class Form_Intervenant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Spécialié = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sexe = new System.Windows.Forms.ComboBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Selectionner = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(570, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(691, 514);
            this.dataGridView1.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(329, 96);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(200, 26);
            this.Nom.TabIndex = 1;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(329, 150);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(200, 26);
            this.Prenom.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(329, 277);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(200, 26);
            this.Email.TabIndex = 3;
            // 
            // Spécialié
            // 
            this.Spécialié.Location = new System.Drawing.Point(329, 341);
            this.Spécialié.Name = "Spécialié";
            this.Spécialié.Size = new System.Drawing.Size(200, 26);
            this.Spécialié.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gestion des Intervenants";
            // 
            // Sexe
            // 
            this.Sexe.FormattingEnabled = true;
            this.Sexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.Sexe.Location = new System.Drawing.Point(329, 212);
            this.Sexe.Name = "Sexe";
            this.Sexe.Size = new System.Drawing.Size(200, 28);
            this.Sexe.TabIndex = 7;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(62, 424);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(131, 40);
            this.Ajouter.TabIndex = 8;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(239, 424);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(114, 39);
            this.Supprimer.TabIndex = 9;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(406, 424);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(123, 39);
            this.Annuler.TabIndex = 10;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sexe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Spécilité";
            // 
            // Selectionner
            // 
            this.Selectionner.Location = new System.Drawing.Point(329, 498);
            this.Selectionner.Name = "Selectionner";
            this.Selectionner.Size = new System.Drawing.Size(117, 41);
            this.Selectionner.TabIndex = 17;
            this.Selectionner.Text = "Selectionner";
            this.Selectionner.UseVisualStyleBackColor = true;
            this.Selectionner.Click += new System.EventHandler(this.Selectionner_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(152, 498);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(117, 41);
            this.Modifier.TabIndex = 18;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Form_Intervenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1273, 615);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Selectionner);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Sexe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Spécialié);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Intervenant";
            this.Text = "Form_Participant";
            this.Load += new System.EventHandler(this.Form_Intervenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Spécialié;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sexe;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Selectionner;
        private System.Windows.Forms.Button Modifier;
    }
}