namespace Prj_Gestion_Evénement_UPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personnes", "Sexe", c => c.String(nullable: false));
            AddColumn("dbo.Personnes", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Personnes", "EstPresent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personnes", "EstPresent", c => c.Boolean());
            DropColumn("dbo.Personnes", "Email");
            DropColumn("dbo.Personnes", "Sexe");
        }
    }
}
