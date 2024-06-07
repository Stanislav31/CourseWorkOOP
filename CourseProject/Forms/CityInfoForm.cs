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
        City City { get; set; }
        MainForm MainForm { get; set; }
        public CityInfoForm(City city, MainForm mainForm)
        {
            InitializeComponent();

            City = city;
            MainForm = mainForm;
            this.Text = "Місто " + City.Name;
            cityName.Text = City.Name;
            descriptionTitle.Text = City.Name;
            cityDescription.Text = City.Description;
            population.Text = "Населення(осіб): " + City.Population;
            country.Text = "Країна: " + City.Country.Name;
            continent.Text = "Материк: " + City.Country.Continent.Name;
            coordinates.Text = "Географічні координати:\n" + "Широта:\n" + City.Coordinates[0].ToString() + "\nДовгота:\n" + City.Coordinates[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете видалити місто " + City.Name, "Видалити місто",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                City.Country.Cities.Remove(City);
                MainForm.FillTreeData();
                this.Close();
            } else
            {
                return;
            }
            
        }
    }
}
