namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterLanguage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Languages", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Languages", "Code", c => c.String(nullable: false, maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Languages", "Code", c => c.String());
            AlterColumn("dbo.Languages", "Name", c => c.String());
        }
    }
}
