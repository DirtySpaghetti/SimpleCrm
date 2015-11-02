namespace SimpleCrm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Message = c.String(),
                        CustomerID = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        MobileNumber = c.String(),
                        StreetAddress = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        JobTitle = c.String(),
                        YearlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Comment", new[] { "CustomerID" });
            DropTable("dbo.Customer");
            DropTable("dbo.Comment");
        }
    }
}
