namespace IngredientTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManagerRegistration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ManagerRegistrations",
                c => new
                    {
                        ManagerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 14),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 25),
                        RepeatPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ManagerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ManagerRegistrations");
        }
    }
}
