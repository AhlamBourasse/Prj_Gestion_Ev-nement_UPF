namespace Prj_Gestion_Evénement_UPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evenements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titre = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Lieu = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Inscriptions",
                c => new
                    {
                        EvenementId = c.Int(nullable: false),
                        ParticipantId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        DateInscription = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.EvenementId, t.ParticipantId })
                .ForeignKey("dbo.Evenements", t => t.EvenementId, cascadeDelete: true)
                .ForeignKey("dbo.Personnes", t => t.ParticipantId, cascadeDelete: true)
                .Index(t => t.EvenementId)
                .Index(t => t.ParticipantId);
            
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        DateNaissance = c.DateTime(nullable: false),
                        EstPresent = c.Boolean(),
                        Specialite = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inscriptions", "ParticipantId", "dbo.Personnes");
            DropForeignKey("dbo.Inscriptions", "EvenementId", "dbo.Evenements");
            DropIndex("dbo.Inscriptions", new[] { "ParticipantId" });
            DropIndex("dbo.Inscriptions", new[] { "EvenementId" });
            DropTable("dbo.Personnes");
            DropTable("dbo.Inscriptions");
            DropTable("dbo.Evenements");
        }
    }
}
