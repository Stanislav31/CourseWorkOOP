using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class ContinentInfoForm : Form
    {
        Continent Continent { get; set; }
        public ContinentInfoForm(Continent continent)
        {
            InitializeComponent();

            Continent = continent;
            this.Text = Continent.Name;           
            continentName.Text = Continent.Name;
            descriptionTitle.Text = Continent.Name;
            continentDescription.Text = Continent.Description;
            population.Text = "Населення(осіб): " + Continent.Population;
            countryCount.Text = "Кількість країн: " + Continent.Countries.Count;
            area.Text = "Площа(км^2): " + Continent.Area;
        }
    }
}
