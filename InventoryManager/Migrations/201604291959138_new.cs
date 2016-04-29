namespace InventoryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inventories", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inventories", "Location");
        }
    }
}
