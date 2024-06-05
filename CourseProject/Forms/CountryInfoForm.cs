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
        public CountryInfoForm(Country country)
        {
            InitializeComponent();
            this.Text = country.Name;
            countryName.Text = country.Name;
            descriptionTitle.Text = country.Name;
            capital.Text = "Столиця: " + country.Capital;
            government.Text = "Форма правління: " + country.Government;
            language.Text = "Офіційні мови: " + country.Language;
            population.Text = "Населення(млн осіб): " + country.Population;
            area.Text = "Площа(км^2): " + country.Area;
            countryCode.Text = "Коди ISO 3166: " + country.CountryCode;
            continent.Text = "Материк: " + country.Continent.Name;
            //timeZone.Text = "Часовий пояс: " + country.TimeZone.DisplayName[..11];
            string desc = country.Description;
            desc += "\n\nНайбільші міста:\n";
            for (int i = 0; i < country.Cities.Count; i++)
            {
                desc += $"{country.Cities[i].Name}, ";
            }
            desc = desc[..(desc.Length-2)] + ".";
            countryDescription.Text = desc;
        }
    }
}
