namespace IngredientTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recipe1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        RecipeId = c.Int(nullable: false, identity: true),
                        RecipeName = c.String(nullable: false),
                        RecipeDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RecipeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recipes");
        }
    }
}
