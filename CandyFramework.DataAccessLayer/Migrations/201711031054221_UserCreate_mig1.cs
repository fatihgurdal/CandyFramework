namespace CandyFramework.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserCreate_mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USERS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PASSWORD = c.String(nullable: false, maxLength: 30),
                        ProfilPhoto = c.Binary(),
                        CREATE_USER = c.String(nullable: false, maxLength: 30),
                        CREATE_DATE = c.DateTime(nullable: false),
                        UPDATE_USER = c.String(nullable: false, maxLength: 30),
                        UPDATE_DATE = c.DateTime(nullable: false),
                        FIRSTNAME = c.String(nullable: false, maxLength: 100),
                        LASTNAME = c.String(nullable: false, maxLength: 100),
                        EMAIL = c.String(nullable: false, maxLength: 100),
                        BIRTDATE = c.DateTime(nullable: false),
                        USERNAME = c.String(nullable: false, maxLength: 30),
                        STATE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.USERNAME, t.STATE }, unique: true, name: "IX_USERS_1");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.USERS", "IX_USERS_1");
            DropTable("dbo.USERS");
        }
    }
}
