namespace JobTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StaffProjects", "ProjectProgressStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StaffProjects", "ProjectProgressStatus", c => c.String(maxLength: 4));
        }
    }
}
