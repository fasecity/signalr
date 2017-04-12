namespace SignalrPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Extenduser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "displayName", c => c.String());
            AddColumn("dbo.AspNetUsers", "age", c => c.String());
            AddColumn("dbo.AspNetUsers", "description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "description");
            DropColumn("dbo.AspNetUsers", "age");
            DropColumn("dbo.AspNetUsers", "displayName");
        }
    }
}
