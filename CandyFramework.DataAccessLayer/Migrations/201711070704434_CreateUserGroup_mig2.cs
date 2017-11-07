namespace CandyFramework.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUserGroup_mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USER_GROUP",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CREATE_USER = c.String(nullable: false, maxLength: 30),
                        CREATE_DATE = c.DateTime(nullable: false),
                        UPDATE_USER = c.String(nullable: false, maxLength: 30),
                        UPDATE_DATE = c.DateTime(nullable: false),
                        STATE = c.Int(nullable: false),
                        NAME = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.NAME, unique: true, name: "IX_USER_GROUP_NAME");
            
            AddColumn("dbo.USERS", "UserGroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.USERS", "UserGroupId");
            AddForeignKey("dbo.USERS", "UserGroupId", "dbo.USER_GROUP", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.USERS", "UserGroupId", "dbo.USER_GROUP");
            DropIndex("dbo.USER_GROUP", "IX_USER_GROUP_NAME");
            DropIndex("dbo.USERS", new[] { "UserGroupId" });
            DropColumn("dbo.USERS", "UserGroupId");
            DropTable("dbo.USER_GROUP");
        }
    }
}
