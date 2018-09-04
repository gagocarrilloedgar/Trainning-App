namespace TrainningApp.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "gender");
        }
    }
}
