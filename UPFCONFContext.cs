using Prj_Gestion_Evénement_UPF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prj_Gestion_Evénement_UPF
{
    public class UPFCONFContext : DbContext
    {
        public UPFCONFContext() : base("name=mappingUPFCONF")
        {
        }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Intervenant> Intervenants { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<Evenement> Evenements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscription>()
                .HasKey(i => new { i.EvenementId, i.ParticipantId });

            modelBuilder.Entity<Inscription>()
                .HasRequired(i => i.Evenement)
                .WithMany()
                .HasForeignKey(i => i.EvenementId);

            modelBuilder.Entity<Inscription>()
                .HasRequired(i => i.Participant)
                .WithMany()
                .HasForeignKey(i => i.ParticipantId);

            modelBuilder.Entity<Intervenant>()
                .HasMany(i => i.Evenements) // Indiquez que l'Intervenant a plusieurs événements
                .WithRequired(e => e.Intervenant) // Chaque événement a un seul Intervenant
                .HasForeignKey(e => e.IntervenantId) // Clé étrangère dans Evenement
                .WillCascadeOnDelete(false); // Désactiver la suppression en cascade

        }
    }
}
