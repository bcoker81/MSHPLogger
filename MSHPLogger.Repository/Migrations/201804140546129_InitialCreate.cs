namespace MSHPLogger.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppCode = c.String(nullable: false, maxLength: 4),
                        ErrorClass = c.String(nullable: false, maxLength: 100),
                        Platform = c.String(nullable: false, maxLength: 20),
                        ExceptionCode = c.String(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 150),
                        TransactionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LogEntries");
        }
    }
}
