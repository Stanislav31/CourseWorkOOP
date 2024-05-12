using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Capital { get; set; }
        public string Description { get; set; }
        public string Government { get; set; }
        public string Language { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }
        public List<City> Cities { get; set; }
        public Continent Continent { get; set; }
    }
}
