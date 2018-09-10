namespace MarvelMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Director", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Director", c => c.String());
        }
    }
}
