namespace Fifth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarDbContext : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cars", name: "FirstName", newName: "Marka");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Cars", name: "Marka", newName: "FirstName");
        }
    }
}
