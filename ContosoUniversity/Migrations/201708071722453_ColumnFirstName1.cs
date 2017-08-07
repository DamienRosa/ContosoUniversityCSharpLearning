namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnFirstName1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "First Name", newName: "FirstName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "FirstName", newName: "First Name");
        }
    }
}
