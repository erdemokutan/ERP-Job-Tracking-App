namespace JobTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StaffInfoes", "RelativesFullName", c => c.String(maxLength: 75));
            AlterColumn("dbo.StaffInfoes", "PositionDetail", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StaffInfoes", "PositionDetail", c => c.String(maxLength: 75));
            DropColumn("dbo.StaffInfoes", "RelativesFullName");
        }
    }
}
