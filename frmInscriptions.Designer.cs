namespace Gestion_Evénement
{
    partial class frmInscriptions
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
            this.cmbIdEvenement = new System.Windows.Forms.ComboBox();
            this.cmbIdParticipant = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvInscriptions = new System.Windows.Forms.DataGridView();
            this.idInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvenementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParticipantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionEvenementsDataSet = new Gestion_Evénement.GestionEvenementsDataSet();
            this.dtpDateInscription = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inscriptionsTableAdapter = new Gestion_Evénement.GestionEvenementsDataSetTableAdapters.InscriptionsTableAdapter();
            this.txtIdInscription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEvenementsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIdEvenement
            // 
            this.cmbIdEvenement.FormattingEnabled = true;
            this.cmbIdEvenement.Location = new System.Drawing.Point(461, 58);
            this.cmbIdEvenement.Name = "cmbIdEvenement";
            this.cmbIdEvenement.Size = new System.Drawing.Size(199, 28);
            this.cmbIdEvenement.TabIndex = 1;
            // 
            // cmbIdParticipant
            // 
            this.cmbIdParticipant.FormattingEnabled = true;
            this.cmbIdParticipant.Location = new System.Drawing.Point(118, 121);
            this.cmbIdParticipant.Name = "cmbIdParticipant";
            this.cmbIdParticipant.Size = new System.Drawing.Size(199, 28);
            this.cmbIdParticipant.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(478, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 29);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(300, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 29);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvInscriptions
            // 
            this.dgvInscriptions.AutoGenerateColumns = false;
            this.dgvInscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInscriptionDataGridViewTextBoxColumn,
            this.idEvenementDataGridViewTextBoxColumn,
            this.idParticipantDataGridViewTextBoxColumn,
            this.dateInscriptionDataGridViewTextBoxColumn});
            this.dgvInscriptions.DataSource = this.inscriptionsBindingSource;
            this.dgvInscriptions.Location = new System.Drawing.Point(55, 241);
            this.dgvInscriptions.Name = "dgvInscriptions";
            this.dgvInscriptions.RowHeadersWidth = 62;
            this.dgvInscriptions.RowTemplate.Height = 28;
            this.dgvInscriptions.Size = new System.Drawing.Size(664, 167);
            this.dgvInscriptions.TabIndex = 17;
            this.dgvInscriptions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscriptions_CellClick);
            // 
            // idInscriptionDataGridViewTextBoxColumn
            // 
            this.idInscriptionDataGridViewTextBoxColumn.DataPropertyName = "IdInscription";
            this.idInscriptionDataGridViewTextBoxColumn.HeaderText = "IdInscription";
            this.idInscriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idInscriptionDataGridViewTextBoxColumn.Name = "idInscriptionDataGridViewTextBoxColumn";
            this.idInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idInscriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // idEvenementDataGridViewTextBoxColumn
            // 
            this.idEvenementDataGridViewTextBoxColumn.DataPropertyName = "IdEvenement";
            this.idEvenementDataGridViewTextBoxColumn.HeaderText = "IdEvenement";
            this.idEvenementDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idEvenementDataGridViewTextBoxColumn.Name = "idEvenementDataGridViewTextBoxColumn";
            this.idEvenementDataGridViewTextBoxColumn.Width = 150;
            // 
            // idParticipantDataGridViewTextBoxColumn
            // 
            this.idParticipantDataGridViewTextBoxColumn.DataPropertyName = "IdParticipant";
            this.idParticipantDataGridViewTextBoxColumn.HeaderText = "IdParticipant";
            this.idParticipantDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idParticipantDataGridViewTextBoxColumn.Name = "idParticipantDataGridViewTextBoxColumn";
            this.idParticipantDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateInscriptionDataGridViewTextBoxColumn
            // 
            this.dateInscriptionDataGridViewTextBoxColumn.DataPropertyName = "DateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.HeaderText = "DateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateInscriptionDataGridViewTextBoxColumn.Name = "dateInscriptionDataGridViewTextBoxColumn";
            this.dateInscriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // inscriptionsBindingSource
            // 
            this.inscriptionsBindingSource.DataMember = "Inscriptions";
            this.inscriptionsBindingSource.DataSource = this.gestionEvenementsDataSet;
            // 
            // gestionEvenementsDataSet
            // 
            this.gestionEvenementsDataSet.DataSetName = "GestionEvenementsDataSet";
            this.gestionEvenementsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDateInscription
            // 
            this.dtpDateInscription.Location = new System.Drawing.Point(460, 119);
            this.dtpDateInscription.Name = "dtpDateInscription";
            this.dtpDateInscription.Size = new System.Drawing.Size(200, 26);
            this.dtpDateInscription.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id Inscription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id Evénement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Id Participant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date Inscription";
            // 
            // inscriptionsTableAdapter
            // 
            this.inscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // txtIdInscription
            // 
            this.txtIdInscription.Location = new System.Drawing.Point(118, 58);
            this.txtIdInscription.Name = "txtIdInscription";
            this.txtIdInscription.Size = new System.Drawing.Size(199, 26);
            this.txtIdInscription.TabIndex = 23;
            // 
            // frmInscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdInscription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateInscription);
            this.Controls.Add(this.dgvInscriptions);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbIdParticipant);
            this.Controls.Add(this.cmbIdEvenement);
            this.Name = "frmInscriptions";
            this.Text = "Inscriptions";
            this.Load += new System.EventHandler(this.frmInscriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionEvenementsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbIdEvenement;
        private System.Windows.Forms.ComboBox cmbIdParticipant;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvInscriptions;
        private System.Windows.Forms.DateTimePicker dtpDateInscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GestionEvenementsDataSet gestionEvenementsDataSet;
        private System.Windows.Forms.BindingSource inscriptionsBindingSource;
        private GestionEvenementsDataSetTableAdapters.InscriptionsTableAdapter inscriptionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvenementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParticipantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtIdInscription;
    }
}