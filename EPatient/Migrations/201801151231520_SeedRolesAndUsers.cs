namespace EPatient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRolesAndUsers : DbMigration
    {
        public override void Up()
        {
            Sql("            INSERT INTO \"dbo\".\"Roles\" (\"Name\") VALUES ('Admin');" +
                "            INSERT INTO \"dbo\".\"Roles\" (\"Name\") VALUES ('Operator');" +
                "            INSERT INTO \"dbo\".\"Roles\" (\"Name\") VALUES ('Doctor');" +
                " INSERT INTO \"dbo\".\"Roles\" (\"Name\") VALUES ('Nurse');" +
                "          ");
        }
        
        public override void Down()
        {
        }
    }
}
