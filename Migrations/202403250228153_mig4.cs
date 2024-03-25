namespace Prj_Gestion_Evénement_UPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Evenements", "IntervenantId", c => c.Int(nullable: false));
            CreateIndex("dbo.Evenements", "IntervenantId");
            AddForeignKey("dbo.Evenements", "IntervenantId", "dbo.Personnes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evenements", "IntervenantId", "dbo.Personnes");
            DropIndex("dbo.Evenements", new[] { "IntervenantId" });
            DropColumn("dbo.Evenements", "IntervenantId");
        }
    }
}
