namespace MarvelMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Director", c => c.String());
            AlterColumn("dbo.Movies", "Actors", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Actors", c => c.String(maxLength: 30));
            AlterColumn("dbo.Movies", "Director", c => c.String(maxLength: 30));
        }
    }
}
