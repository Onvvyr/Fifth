namespace Fifth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Required : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cars", name: "Country", newName: "Kraj");
            AlterColumn("dbo.Cars", "Kraj", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Kraj", c => c.String());
            RenameColumn(table: "dbo.Cars", name: "Kraj", newName: "Country");
        }
    }
}
