namespace IngredientTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ingredient1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ingredients", "IngredientName", c => c.String(nullable: false));
            AlterColumn("dbo.Ingredients", "Unit", c => c.String(nullable: false));
            DropTable("dbo.Recipes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        RecipeId = c.Int(nullable: false, identity: true),
                        RecipeName = c.String(),
                    })
                .PrimaryKey(t => t.RecipeId);
            
            AlterColumn("dbo.Ingredients", "Unit", c => c.String());
            AlterColumn("dbo.Ingredients", "IngredientName", c => c.String());
        }
    }
}
