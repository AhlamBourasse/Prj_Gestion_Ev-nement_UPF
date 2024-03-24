namespace Prj_Gestion_Evénement_UPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Personnes", "DateNaissance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personnes", "DateNaissance", c => c.DateTime(nullable: false));
        }
    }
}
