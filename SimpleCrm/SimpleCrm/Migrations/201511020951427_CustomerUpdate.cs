namespace SimpleCrm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Telephone", c => c.Long(nullable: false));
            AddColumn("dbo.Customer", "BirthDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customer", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customer", "MiddleName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Customer", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customer", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "MobileNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "MobileNumber", c => c.String());
            AlterColumn("dbo.Customer", "EmailAddress", c => c.String());
            AlterColumn("dbo.Customer", "LastName", c => c.String());
            AlterColumn("dbo.Customer", "MiddleName", c => c.String());
            AlterColumn("dbo.Customer", "FirstName", c => c.String());
            DropColumn("dbo.Customer", "BirthDay");
            DropColumn("dbo.Customer", "Telephone");
        }
    }
}
