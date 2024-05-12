using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Continent
    {
        public List<Country> Countries { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
    }
}
