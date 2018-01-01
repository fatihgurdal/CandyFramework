namespace CandyFramework.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class passwordUpgrade : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.USERS", "PASSWORD", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.USERS", "PASSWORD", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
