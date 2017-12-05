namespace CandyFramework.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LOGS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TYPE = c.Int(nullable: false),
                        LEVEL = c.Int(nullable: false),
                        ERROR_MESSAGE = c.String(nullable: false),
                        ERROR_DETAIL = c.String(nullable: false),
                        INNER_EXCEPTION = c.String(nullable: false),
                        CREATE_USER = c.String(nullable: false),
                        CREATE_DATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SETTINGS",
                c => new
                    {
                        CREATE_DATE = c.DateTime(nullable: false),
                        UPDATE_DATE = c.DateTime(nullable: false),
                        CREATE_USER = c.String(nullable: false, maxLength: 30),
                        UPDATE_USER = c.String(nullable: false, maxLength: 30),
                        Id = c.Int(nullable: false, identity: true),
                        KEYNAME = c.String(nullable: false, maxLength: 50),
                        VALUE = c.String(nullable: false, maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.KEYNAME, unique: true, name: "IX_SETTINGS_1");
            
            CreateTable(
                "dbo.USER_GROUP",
                c => new
                    {
                        CREATE_DATE = c.DateTime(nullable: false),
                        UPDATE_DATE = c.DateTime(nullable: false),
                        CREATE_USER = c.String(nullable: false, maxLength: 30),
                        UPDATE_USER = c.String(nullable: false, maxLength: 30),
                        STATE = c.Int(nullable: false),
                        Id = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NAME, unique: true, name: "IX_USER_GROUP_NAME");
            
            CreateTable(
                "dbo.USERS",
                c => new
                    {
                        CREATE_DATE = c.DateTime(nullable: false),
                        UPDATE_DATE = c.DateTime(nullable: false),
                        CREATE_USER = c.String(nullable: false, maxLength: 30),
                        UPDATE_USER = c.String(nullable: false, maxLength: 30),
                        ID = c.Int(nullable: false, identity: true),
                        PASSWORD = c.String(nullable: false, maxLength: 30),
                        PROFIL_PHOTO = c.Binary(),
                        USER_GROUP_ID = c.Int(nullable: false),
                        FIRSTNAME = c.String(nullable: false, maxLength: 100),
                        LASTNAME = c.String(nullable: false, maxLength: 100),
                        EMAIL = c.String(nullable: false, maxLength: 100),
                        BIRTDATE = c.DateTime(nullable: false),
                        USERNAME = c.String(nullable: false, maxLength: 30),
                        STATE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.USER_GROUP", t => t.USER_GROUP_ID, cascadeDelete: true)
                .Index(t => t.USER_GROUP_ID)
                .Index(t => new { t.USERNAME, t.STATE }, unique: true, name: "IX_USERS_1");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.USERS", "USER_GROUP_ID", "dbo.USER_GROUP");
            DropIndex("dbo.USERS", "IX_USERS_1");
            DropIndex("dbo.USERS", new[] { "USER_GROUP_ID" });
            DropIndex("dbo.USER_GROUP", "IX_USER_GROUP_NAME");
            DropIndex("dbo.SETTINGS", "IX_SETTINGS_1");
            DropTable("dbo.USERS");
            DropTable("dbo.USER_GROUP");
            DropTable("dbo.SETTINGS");
            DropTable("dbo.LOGS");
        }
    }
}
