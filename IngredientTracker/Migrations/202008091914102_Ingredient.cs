namespace IngredientTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ingredient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientId = c.Int(nullable: false, identity: true),
                        IngredientName = c.String(),
                        IngredientAmount = c.Double(nullable: false),
                        Unit = c.String(),
                    })
                .PrimaryKey(t => t.IngredientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ingredients");
        }
    }
}
