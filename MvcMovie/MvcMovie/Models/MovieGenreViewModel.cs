using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies { get; internal set; }
        public SelectList genres { get; internal set; }
        public string movieGenre { get; set; }
    }
}
