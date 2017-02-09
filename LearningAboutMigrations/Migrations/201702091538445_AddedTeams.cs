namespace LearningAboutMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTeams : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameScores", "Team", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.GameScores", "Team");
        }
    }
}
