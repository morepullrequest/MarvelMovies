namespace MarvelMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class year : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Year");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Year", c => c.DateTime(nullable: false));
        }
    }
}
