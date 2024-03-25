namespace Prj_Gestion_Evénement_UPF
{
    partial class frm_Menue
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.intervenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervenantToolStripMenuItem,
            this.participantsToolStripMenuItem,
            this.evenementsToolStripMenuItem,
            this.inscriptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // intervenantToolStripMenuItem
            // 
            this.intervenantToolStripMenuItem.Name = "intervenantToolStripMenuItem";
            this.intervenantToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.intervenantToolStripMenuItem.Text = "Intervenant";
            this.intervenantToolStripMenuItem.Click += new System.EventHandler(this.intervenantToolStripMenuItem_Click);
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.participantsToolStripMenuItem.Text = "Participants";
            this.participantsToolStripMenuItem.Click += new System.EventHandler(this.participantsToolStripMenuItem_Click);
            // 
            // evenementsToolStripMenuItem
            // 
            this.evenementsToolStripMenuItem.Name = "evenementsToolStripMenuItem";
            this.evenementsToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.evenementsToolStripMenuItem.Text = "Evenements";
            this.evenementsToolStripMenuItem.Click += new System.EventHandler(this.evenementsToolStripMenuItem_Click);
            // 
            // inscriptionsToolStripMenuItem
            // 
            this.inscriptionsToolStripMenuItem.Name = "inscriptionsToolStripMenuItem";
            this.inscriptionsToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.inscriptionsToolStripMenuItem.Text = "Inscriptions";
            this.inscriptionsToolStripMenuItem.Click += new System.EventHandler(this.inscriptionsToolStripMenuItem_Click);
            // 
            // frm_Menue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Menue";
            this.Text = "frm_Menue";
            this.Load += new System.EventHandler(this.frm_Menue_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem intervenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionsToolStripMenuItem;
    }
}