namespace Lap456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addiscanceledcolumntocourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
