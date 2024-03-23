namespace Gestion_Evénement
{
    partial class frmEvénement
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
            this.dtpDébut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.txtIdEvenement = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSiteWeb = new System.Windows.Forms.TextBox();
            this.txtOrganisateur = new System.Windows.Forms.TextBox();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvEvenement = new System.Windows.Forms.DataGridView();
            this.gestionEvenementsDataSet = new Gestion_Evénement.GestionEvenementsDataSet();
            this.evenementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evenementsTableAdapter = new Gestion_Evénement.GestionEvenementsDataSetTableAdapters.EvenementsTableAdapter();
            this.idEvenementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteWebDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEvenementsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDébut
            // 
            this.dtpDébut.Location = new System.Drawing.Point(507, 157);
            this.dtpDébut.Name = "dtpDébut";
            this.dtpDébut.Size = new System.Drawing.Size(200, 26);
            this.dtpDébut.TabIndex = 0;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(824, 157);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFin.TabIndex = 1;
            // 
            // txtIdEvenement
            // 
            this.txtIdEvenement.Location = new System.Drawing.Point(105, 96);
            this.txtIdEvenement.Name = "txtIdEvenement";
            this.txtIdEvenement.Size = new System.Drawing.Size(200, 26);
            this.txtIdEvenement.TabIndex = 3;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(507, 96);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(200, 26);
            this.txtLibelle.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(824, 96);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 26);
            this.txtDescription.TabIndex = 5;
            // 
            // txtSiteWeb
            // 
            this.txtSiteWeb.Location = new System.Drawing.Point(824, 218);
            this.txtSiteWeb.Name = "txtSiteWeb";
            this.txtSiteWeb.Size = new System.Drawing.Size(200, 26);
            this.txtSiteWeb.TabIndex = 8;
            // 
            // txtOrganisateur
            // 
            this.txtOrganisateur.Location = new System.Drawing.Point(507, 218);
            this.txtOrganisateur.Name = "txtOrganisateur";
            this.txtOrganisateur.Size = new System.Drawing.Size(200, 26);
            this.txtOrganisateur.TabIndex = 7;
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(105, 218);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(200, 26);
            this.txtLieu.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(171, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(461, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 34);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(746, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(105, 155);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 28);
            this.cbType.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Déscription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date Début";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date Fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lieu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Organisateur";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(729, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Site Web";
            // 
            // dgvEvenement
            // 
            this.dgvEvenement.AutoGenerateColumns = false;
            this.dgvEvenement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvenement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvenementDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDebutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn,
            this.lieuDataGridViewTextBoxColumn,
            this.organisateurDataGridViewTextBoxColumn,
            this.siteWebDataGridViewTextBoxColumn});
            this.dgvEvenement.DataSource = this.evenementsBindingSource;
            this.dgvEvenement.Location = new System.Drawing.Point(25, 367);
            this.dgvEvenement.Name = "dgvEvenement";
            this.dgvEvenement.RowHeadersWidth = 62;
            this.dgvEvenement.RowTemplate.Height = 28;
            this.dgvEvenement.Size = new System.Drawing.Size(1067, 238);
            this.dgvEvenement.TabIndex = 22;
            this.dgvEvenement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvenement_CellClick);
            // 
            // gestionEvenementsDataSet
            // 
            this.gestionEvenementsDataSet.DataSetName = "GestionEvenementsDataSet";
            this.gestionEvenementsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evenementsBindingSource
            // 
            this.evenementsBindingSource.DataMember = "Evenements";
            this.evenementsBindingSource.DataSource = this.gestionEvenementsDataSet;
            // 
            // evenementsTableAdapter
            // 
            this.evenementsTableAdapter.ClearBeforeFill = true;
            // 
            // idEvenementDataGridViewTextBoxColumn
            // 
            this.idEvenementDataGridViewTextBoxColumn.DataPropertyName = "IdEvenement";
            this.idEvenementDataGridViewTextBoxColumn.HeaderText = "IdEvenement";
            this.idEvenementDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idEvenementDataGridViewTextBoxColumn.Name = "idEvenementDataGridViewTextBoxColumn";
            this.idEvenementDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEvenementDataGridViewTextBoxColumn.Width = 150;
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "Libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "Libelle";
            this.libelleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            this.libelleDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDebutDataGridViewTextBoxColumn
            // 
            this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.HeaderText = "DateDebut";
            this.dateDebutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
            this.dateDebutDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "DateFin";
            this.dateFinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            this.dateFinDataGridViewTextBoxColumn.Width = 150;
            // 
            // lieuDataGridViewTextBoxColumn
            // 
            this.lieuDataGridViewTextBoxColumn.DataPropertyName = "Lieu";
            this.lieuDataGridViewTextBoxColumn.HeaderText = "Lieu";
            this.lieuDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lieuDataGridViewTextBoxColumn.Name = "lieuDataGridViewTextBoxColumn";
            this.lieuDataGridViewTextBoxColumn.Width = 150;
            // 
            // organisateurDataGridViewTextBoxColumn
            // 
            this.organisateurDataGridViewTextBoxColumn.DataPropertyName = "Organisateur";
            this.organisateurDataGridViewTextBoxColumn.HeaderText = "Organisateur";
            this.organisateurDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.organisateurDataGridViewTextBoxColumn.Name = "organisateurDataGridViewTextBoxColumn";
            this.organisateurDataGridViewTextBoxColumn.Width = 150;
            // 
            // siteWebDataGridViewTextBoxColumn
            // 
            this.siteWebDataGridViewTextBoxColumn.DataPropertyName = "SiteWeb";
            this.siteWebDataGridViewTextBoxColumn.HeaderText = "SiteWeb";
            this.siteWebDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.siteWebDataGridViewTextBoxColumn.Name = "siteWebDataGridViewTextBoxColumn";
            this.siteWebDataGridViewTextBoxColumn.Width = 150;
            // 
            // Evénement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 657);
            this.Controls.Add(this.dgvEvenement);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSiteWeb);
            this.Controls.Add(this.txtOrganisateur);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.txtIdEvenement);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDébut);
            this.Name = "Evénement";
            this.Text = "Evénement";
            this.Load += new System.EventHandler(this.Evénement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvenement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEvenementsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evenementsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDébut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.TextBox txtIdEvenement;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSiteWeb;
        private System.Windows.Forms.TextBox txtOrganisateur;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvEvenement;
        private GestionEvenementsDataSet gestionEvenementsDataSet;
        private System.Windows.Forms.BindingSource evenementsBindingSource;
        private GestionEvenementsDataSetTableAdapters.EvenementsTableAdapter evenementsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvenementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteWebDataGridViewTextBoxColumn;
    }
}