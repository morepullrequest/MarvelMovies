namespace MarvelMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 60),
                        Year = c.DateTime(nullable: false),
                        Rated = c.String(maxLength: 5),
                        Released = c.DateTime(nullable: false),
                        Runtime = c.Int(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 30),
                        Director = c.String(maxLength: 30),
                        Actors = c.String(maxLength: 30),
                        Plot = c.String(),
                        Poster = c.String(maxLength: 30),
                        ImdbRating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImdbVotes = c.Int(nullable: false),
                        ImdbID = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
