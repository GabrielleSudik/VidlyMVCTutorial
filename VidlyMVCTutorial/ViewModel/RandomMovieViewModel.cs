using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVCTutorial.Models;

namespace VidlyMVCTutorial.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}