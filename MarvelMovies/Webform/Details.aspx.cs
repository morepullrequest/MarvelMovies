using MarvelMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarvelMovies.Webform
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Movie> GetMovie([QueryString("ID")] int? id)
        {
            var _db = new MovieContext();
            IQueryable<Movie> query = _db.Movies;

            if(id.HasValue && id > 0)
            {
                query = query.Where(m => m.ID == id);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}