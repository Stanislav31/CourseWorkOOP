using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Country Country { get; set; }
        public int Population { get; set; }
        public double[] Coordinates { get; set; } = new double[2];
    }
}
