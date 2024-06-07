using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class CountryInfoForm : Form
    {
        Country Country { get; set; }
        Handbook Handbook { get; set; }
        MainForm MainForm { get; set; }
        public CountryInfoForm(Country country, Handbook handbook, MainForm mainForm)
        {
            InitializeComponent();
            Country = country;
            Handbook = handbook;
            MainForm = mainForm;
            this.Text = "Країна " + Country.Name;
            countryName.Text = Country.Name;
            descriptionTitle.Text = Country.Name;
            capital.Text = "Столиця: " + Country.Capital;
            government.Text = "Форма правління: " + Country.Government;
            language.Text = "Офіційні мови: " + Country.Language;
            population.Text = "Населення(осіб): " + Country.Population;
            area.Text = "Площа(км^2): " + Country.Area;
            countryCode.Text = "Коди ISO 3166: " + Country.CountryCode;
            continent.Text = "Материк: " + Country.Continent.Name;
            string desc = Country.Description;
            if (Country.Cities.Count > 0 )
            {
                desc += "\n\nМіста:\n";
                for (int i = 0; i < Country.Cities.Count; i++)
                {
                    desc += $"{Country.Cities[i].Name}, ";
                }
                desc = desc[..(desc.Length - 2)] + ".";
            }           
            countryDescription.Text = desc;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            CitiesEditForm citiesEditForm = new CitiesEditForm(Country, MainForm);
            citiesEditForm.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете видалити країну " + Country.Name, "Видалити країну",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Handbook.DeleteCountry(Country);
                MainForm.FillTreeData();
                this.Close();
            } else
            {
                return;
            }
        }
    }
}
