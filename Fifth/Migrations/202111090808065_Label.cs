namespace Fifth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Label : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Brand", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Brand", c => c.String());
        }
    }
}
