using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Continent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public List<Country> Countries { get; set; }
    }
}
