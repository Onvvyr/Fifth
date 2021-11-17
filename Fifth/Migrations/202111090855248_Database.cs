namespace Fifth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Database : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cars", name: "Kraj", newName: "Country");
            AlterColumn("dbo.Cars", "Country", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Country", c => c.String(nullable: false));
            RenameColumn(table: "dbo.Cars", name: "Country", newName: "Kraj");
        }
    }
}
