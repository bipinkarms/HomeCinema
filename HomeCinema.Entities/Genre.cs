using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Entities
{
    public class Genre : EntityBase
    {
        public Genre()
        {
            Movies = new List<Movie>();
        }

        public string Name { get; set; }
        
        public virtual ICollection<Movie> Movies { get; set; } 
    }
}
