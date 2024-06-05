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
        public ContinentInfoForm(Continent continent)
        {
            InitializeComponent();

            this.Text = continent.Name;
            continentName.Text = continent.Name;
            descriptionTitle.Text = continent.Name;
            continentDescription.Text = continent.Description;
            population.Text = "Населення(млн. осіб): " + continent.Population;
            countryCount.Text = "Кількість країн: " + continent.Countries.Count;
            area.Text = "Площа(км^2): " + continent.Area;
        }
    }
}
