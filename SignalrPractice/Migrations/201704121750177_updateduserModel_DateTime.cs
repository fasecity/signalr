namespace SignalrPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateduserModel_DateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "dateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "dateTime");
        }
    }
}
