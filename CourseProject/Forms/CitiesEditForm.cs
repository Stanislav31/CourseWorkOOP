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
    public partial class CitiesEditForm : Form
    {
        Country Country { get; set; }
        MainForm MainForm { get; set; }
        public CitiesEditForm(Country country, MainForm mainForm)
        {
            InitializeComponent();
            Country = country;
            MainForm = mainForm;
            this.Text = "Редагування міст країни " + Country.Name;
            label1.Text += Country.Name;
            cityBindingSource.DataSource = Country.Cities;
        }

        private void fillFormData()
        {
            City city = citiesBox.SelectedItem as City;
            nameBox.Text = city.Name;
            populationBox.Text = city.Population.ToString();
            latitudeBox.Text = city.Coordinates[0].ToString();
            longtitudeBox.Text = city.Coordinates[1].ToString();
            descriptionBox.Text = city.Description;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Country.Cities.Add(new City
            {
                Name = "Нове місто",
                Description = "",
                Country = this.Country,
                Population = 0,
                Coordinates = [0, 0]
            });
            cityBindingSource.DataSource = null;
            cityBindingSource.DataSource = Country.Cities;
            citiesBox.SelectedIndex = citiesBox.Items.Count - 1;
            fillFormData();
            MainForm.FillTreeData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            City city = citiesBox.SelectedItem as City;
            Country.Cities.Remove(city);
            cityBindingSource.DataSource = null;
            cityBindingSource.DataSource = Country.Cities;
            MainForm.FillTreeData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            City city = citiesBox.SelectedItem as City;
            if (city == null)
            {
                return;
            }
            city.Name = nameBox.Text;
            city.Description = descriptionBox.Text;
            city.Population = Convert.ToInt32(populationBox.Text);
            city.Coordinates[0] = Convert.ToDouble(latitudeBox.Text);
            city.Coordinates[1] = Convert.ToDouble(longtitudeBox.Text);
            cityBindingSource.DataSource = null;
            cityBindingSource.DataSource = Country.Cities;
            MainForm.FillTreeData();
        }

        private void citiesBox_DoubleClick(object sender, EventArgs e)
        {
            fillFormData();
        }

        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in nameBox.Text)
            {
                if (!Char.IsLetter(c) && c.ToString() != " ")
                {
                    nameBox.Text = nameBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void populationBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(populationBox.Text, out double population);
            if (!isNumber || population < 0)
            {
                populationBox.Text = "0";
            }
        }

        private void latitudeBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(latitudeBox.Text, out double latitude);
            if (!isNumber || latitude < -90 || latitude > 90)
            {
                latitudeBox.Text = "0";
            }
        }

        private void longtitudeBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(longtitudeBox.Text, out double longtitude);
            if (!isNumber || longtitude < -180 || longtitude > 180)
            {
                longtitudeBox.Text = "0";
            }
        }
    }
}
