using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class CityInfoForm : Form
    {
        public CityInfoForm(City city)
        {
            InitializeComponent();

            this.Text = city.Name;
            cityName.Text = city.Name;
            descriptionTitle.Text = city.Name;
            cityDescription.Text = city.Description;
            population.Text = "Населення(тис. осіб): " + city.Population;
            country.Text = city.Country.Name;
            continent.Text = city.Country.Continent.Name;
            coordinates.Text = "Географічні координати:\n" + "Широта:\n" + city.Coordinates[0] + "\nДовгота:\n" + city.Coordinates[1];
        }
    }
}
