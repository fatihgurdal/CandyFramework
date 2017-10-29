namespace CandyFramework.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USERS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(nullable: false, maxLength: 30),
                        ProfilPhoto = c.Binary(),
                        CreateUser = c.String(nullable: false, maxLength: 30),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateUser = c.String(nullable: false, maxLength: 30),
                        UpdateDate = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        Birtdate = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 30),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.UserName, t.State }, unique: true, name: "IX_USERS_1");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.USERS", "IX_USERS_1");
            DropTable("dbo.USERS");
        }
    }
}
