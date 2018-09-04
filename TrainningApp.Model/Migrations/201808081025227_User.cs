namespace TrainningApp.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Breakfasts",
                c => new
                    {
                        BreakfastID = c.Int(nullable: false, identity: true),
                        Food_FoodID = c.Int(),
                    })
                .PrimaryKey(t => t.BreakfastID)
                .ForeignKey("dbo.Foods", t => t.Food_FoodID)
                .Index(t => t.Food_FoodID);
            
            CreateTable(
                "dbo.Elements",
                c => new
                    {
                        ElementID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EnergeticValue = c.Int(nullable: false),
                        proteins = c.Int(nullable: false),
                        Fats = c.Int(nullable: false),
                        Carbs = c.Int(nullable: false),
                        Breakfast_BreakfastID = c.Int(),
                        Dinner_DinnerId = c.Int(),
                        Extra_ExtraID = c.Int(),
                        Lunch_LunchId = c.Int(),
                    })
                .PrimaryKey(t => t.ElementID)
                .ForeignKey("dbo.Breakfasts", t => t.Breakfast_BreakfastID)
                .ForeignKey("dbo.Dinners", t => t.Dinner_DinnerId)
                .ForeignKey("dbo.Extras", t => t.Extra_ExtraID)
                .ForeignKey("dbo.Lunches", t => t.Lunch_LunchId)
                .Index(t => t.Breakfast_BreakfastID)
                .Index(t => t.Dinner_DinnerId)
                .Index(t => t.Extra_ExtraID)
                .Index(t => t.Lunch_LunchId);
            
            CreateTable(
                "dbo.Dinners",
                c => new
                    {
                        DinnerId = c.Int(nullable: false, identity: true),
                        Food_FoodID = c.Int(),
                    })
                .PrimaryKey(t => t.DinnerId)
                .ForeignKey("dbo.Foods", t => t.Food_FoodID)
                .Index(t => t.Food_FoodID);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        ExtraID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ExtraID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.FoodID);
            
            CreateTable(
                "dbo.Lunches",
                c => new
                    {
                        LunchId = c.Int(nullable: false, identity: true),
                        Food_FoodID = c.Int(),
                    })
                .PrimaryKey(t => t.LunchId)
                .ForeignKey("dbo.Foods", t => t.Food_FoodID)
                .Index(t => t.Food_FoodID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        UserNickname = c.String(),
                        Password = c.String(),
                        Age = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        IMC = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lunches", "Food_FoodID", "dbo.Foods");
            DropForeignKey("dbo.Elements", "Lunch_LunchId", "dbo.Lunches");
            DropForeignKey("dbo.Dinners", "Food_FoodID", "dbo.Foods");
            DropForeignKey("dbo.Breakfasts", "Food_FoodID", "dbo.Foods");
            DropForeignKey("dbo.Elements", "Extra_ExtraID", "dbo.Extras");
            DropForeignKey("dbo.Elements", "Dinner_DinnerId", "dbo.Dinners");
            DropForeignKey("dbo.Elements", "Breakfast_BreakfastID", "dbo.Breakfasts");
            DropIndex("dbo.Lunches", new[] { "Food_FoodID" });
            DropIndex("dbo.Dinners", new[] { "Food_FoodID" });
            DropIndex("dbo.Elements", new[] { "Lunch_LunchId" });
            DropIndex("dbo.Elements", new[] { "Extra_ExtraID" });
            DropIndex("dbo.Elements", new[] { "Dinner_DinnerId" });
            DropIndex("dbo.Elements", new[] { "Breakfast_BreakfastID" });
            DropIndex("dbo.Breakfasts", new[] { "Food_FoodID" });
            DropTable("dbo.Users");
            DropTable("dbo.Lunches");
            DropTable("dbo.Foods");
            DropTable("dbo.Extras");
            DropTable("dbo.Dinners");
            DropTable("dbo.Elements");
            DropTable("dbo.Breakfasts");
        }
    }
}
