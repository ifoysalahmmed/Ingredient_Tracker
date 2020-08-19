namespace IngredientTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChefRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChefRegistrations",
                c => new
                    {
                        ChefID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.ChefID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChefRegistrations");
        }
    }
}
