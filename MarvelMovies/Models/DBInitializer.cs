using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace MarvelMovies.Models
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            List<Movie> movies = MarvelMovies.Migrations.Configuration.GetMovies();
            movies.ForEach(m => context.Movies.Add( m));
        }
    }
}