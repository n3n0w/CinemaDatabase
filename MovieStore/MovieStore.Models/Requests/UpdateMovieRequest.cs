using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Requests
{
    public class UpdateMovieRequest
    {
        public String Id { get; set; }

        public String Title { get; set; }

        public String Year { get; set; }
    }
}
