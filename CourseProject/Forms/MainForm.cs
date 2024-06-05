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
using System.Net;
using System.Xml.Linq;

namespace CourseProject.Forms
{
    public partial class MainForm : Form
    {
        Handbook handbook = new Handbook();
        public MainForm()
        {
            InitializeComponent();
            //handbook.SaveData(".//");
            try
            {
                handbook = handbook.LoadData(".//");
            }
            catch (Exception e)
            {
                handbook.GenerateBaseData();
                handbook.SaveData(".//");
                MessageBox.Show("Було створено новий файл для збереження даних", "Сталася помилка при заванатженні данних");
            }
            FillTreeData();
            searchType.SelectedIndex = 0;
            searchType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void FillTreeData()
        {
            dataView.Nodes.Clear();
            for (int i = 0; i < handbook.Continents.Count; i++)
            {
                TreeNode node = new TreeNode(handbook.Continents[i].Name);
                for (int j = 0; j < handbook.Continents[i].Countries.Count; j++)
                {
                    node.Nodes.Add(new TreeNode(handbook.Continents[i].Countries[j].Name));
                    for (int k = 0; k < handbook.Continents[i].Countries[j].Cities.Count; k++)
                    {
                        node.Nodes[j].Nodes.Add(new TreeNode(handbook.Continents[i].Countries[j].Cities[k].Name));
                    }
                }
                dataView.Nodes.Add(node);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            double areaMin, areaMax;
            int populationMin, populationMax;
            if (areaBoxMin.Text == "")
            {
                areaMin = 0;
            }
            else
            {
                areaMin = Convert.ToDouble(areaBoxMin.Text);
            }
            if (areaBoxMax.Text == "")
            {
                areaMax = Int32.MaxValue;
            }
            else
            {
                areaMax = Convert.ToDouble(areaBoxMax.Text);
            }
            if (populationBoxMin.Text == "")
            {
                populationMin = 0;
            }
            else
            {
                populationMin = Convert.ToInt32(populationBoxMin.Text);
            }
            if (populationBoxMax.Text == "")
            {
                populationMax = Int32.MaxValue;
            }
            else
            {
                populationMax = Convert.ToInt32(populationBoxMax.Text);
            }
            if (searchType.SelectedIndex == 0)
            {
                continentBindingSource.DataSource = handbook.SearchContinent(nameBox.Text, [areaMin, areaMax], [populationMin, populationMax]);
                countryBindingSource.DataSource = handbook.SearchCountry(nameBox.Text, continentBox.Text, [areaMin, areaMax], [populationMin, populationMax]);
                cityBindingSource.DataSource = handbook.SearchCity(nameBox.Text, continentBox.Text, [populationMin, populationMax]);
                searchResultBoxContinents.Visible = true;
                searchResultBoxCountries.Visible = true;
                searchResultBoxCities.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                searchResultBox.Visible = false;
            }
            else if (searchType.SelectedIndex == 1)
            {
                typeSearchBindingSource.DataSource = handbook.SearchContinent(nameBox.Text, [areaMin, areaMax], [populationMin, populationMax]);
                searchResultBoxContinents.Visible = false;
                searchResultBoxCountries.Visible = false;
                searchResultBoxCities.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                searchResultBox.Visible = true;
            }
            else if (searchType.SelectedIndex == 2)
            {
                typeSearchBindingSource.DataSource = handbook.SearchCountry(nameBox.Text, continentBox.Text, [areaMin, areaMax], [populationMin, populationMax]);
                searchResultBoxContinents.Visible = false;
                searchResultBoxCountries.Visible = false;
                searchResultBoxCities.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                searchResultBox.Visible = true;
            }
            else if (searchType.SelectedIndex == 3)
            {
                typeSearchBindingSource.DataSource = handbook.SearchCity(nameBox.Text, continentBox.Text, [populationMin, populationMax]);
                searchResultBoxContinents.Visible = false;
                searchResultBoxCountries.Visible = false;
                searchResultBoxCities.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                searchResultBox.Visible = true;
            }
        }

        private void areaBoxMin_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(areaBoxMin.Text, out double areaMin);
            double.TryParse(areaBoxMax.Text, out double areaMax);
            if (!isNumber || areaMin < 0)
            {
                areaBoxMin.Text = "";
            }
            if (areaMax < areaMin)
            {
                areaBoxMin.Text = areaBoxMax.Text;
            }
        }

        private void areaBoxMax_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(areaBoxMax.Text, out double areaMax);
            double.TryParse(areaBoxMin.Text, out double areaMin);
            if (!isNumber || areaMax < 0)
            {
                areaBoxMax.Text = "";
            }
            if (areaMax < areaMin)
            {
                areaBoxMax.Text = areaBoxMin.Text;
            }
        }

        private void populationBoxMin_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(populationBoxMin.Text, out double populationMin);
            double.TryParse(populationBoxMax.Text, out double populationMax);
            if (!isNumber || populationMin < 0)
            {
                populationBoxMin.Text = "";
            }
            if (populationMax < populationMin)
            {
                populationBoxMin.Text = populationBoxMax.Text;
            }
        }



        private void populationBoxMax_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(populationBoxMax.Text, out int populationMax);
            int.TryParse(populationBoxMin.Text, out int populationMin);
            if (!isNumber || populationMax < 0)
            {
                populationBoxMax.Text = "";
            }
            if (populationMax < populationMin)
            {
                populationBoxMax.Text = populationBoxMin.Text;
            }
        }

        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in nameBox.Text)
            {
                if (!Char.IsLetter(c))
                {
                    nameBox.Text = nameBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void continentBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in continentBox.Text)
            {
                if (!Char.IsLetter(c))
                {
                    continentBox.Text = continentBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void searchResultBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (searchType.SelectedIndex == 1)
            {
                Continent continent = searchResultBox.SelectedItem as Continent;
                ContinentInfoForm continentInfoForm = new ContinentInfoForm(continent);
                continentInfoForm.Show();
            }
            else if (searchType.SelectedIndex == 2)
            {
                Country country = searchResultBox.SelectedItem as Country;
                CountryInfoForm countryInfoForm = new CountryInfoForm(country);
                countryInfoForm.Show();
            }
            else if (searchType.SelectedIndex == 3)
            {
                City city = searchResultBox.SelectedItem as City;
                CityInfoForm cityInfoForm = new CityInfoForm(city);
                cityInfoForm.Show();
            }
        }

        private void countryView_DoubleClick(object sender, EventArgs e)
        {
            int lavel = dataView.SelectedNode.Level;
            if (lavel == 0)
            {
                string name = dataView.SelectedNode.Text;
                for (int i = 0; i < handbook.Continents.Count; i++)
                {
                    if (name == handbook.Continents[i].Name)
                    {
                        ContinentInfoForm continentInfoForm = new ContinentInfoForm(handbook.Continents[i]);
                        continentInfoForm.Show();
                        return;
                    }
                }
            }
            if (lavel == 1)
            {
                string name = dataView.SelectedNode.Text;
                for (int i = 0; i < handbook.Countries.Count; i++)
                {
                    if (name == handbook.Countries[i].Name)
                    {
                        CountryInfoForm countryInfoForm = new CountryInfoForm(handbook.Countries[i]);
                        countryInfoForm.Show();
                        return;
                    }
                }
            }
            if (lavel == 2)
            {
                string cityName = dataView.SelectedNode.Text;
                string countryName = dataView.SelectedNode.Parent.Text;
                for (int i = 0; i < handbook.Countries.Count; i++)
                {
                    if (countryName == handbook.Countries[i].Name)
                    {
                        for (int j = 0; j < handbook.Countries[i].Cities.Count; j++)
                        {
                            if (cityName == handbook.Countries[i].Cities[j].Name)
                            {
                                CityInfoForm cityInfoForm = new CityInfoForm(handbook.Countries[i].Cities[j]);
                                cityInfoForm.Show();
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void searchResultBoxContinents_DoubleClick(object sender, EventArgs e)
        {
            Continent continent = searchResultBoxContinents.SelectedItem as Continent;
            ContinentInfoForm continentInfoForm = new ContinentInfoForm(continent);
            continentInfoForm.Show();
        }

        private void searchResultBoxCountries_DoubleClick(object sender, EventArgs e)
        {
            Country country = searchResultBoxCountries.SelectedItem as Country;
            CountryInfoForm countryInfoForm = new CountryInfoForm(country);
            countryInfoForm.Show();
        }

        private void searchResultBoxCities_DoubleClick(object sender, EventArgs e)
        {
            City city = searchResultBoxCities.SelectedItem as City;
            CityInfoForm cityInfoForm = new CityInfoForm(city);
            cityInfoForm.Show();
        }

        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchType.SelectedIndex == 1)
            {
                continentBox.Enabled = false;
                if (!areaBoxMin.Enabled && !areaBoxMax.Enabled)
                {
                    areaBoxMin.Enabled = true;
                    areaBoxMax.Enabled = true;
                }
            }
            else if (searchType.SelectedIndex == 3)
            {
                areaBoxMin.Enabled = false;
                areaBoxMax.Enabled = false;
                if (!continentBox.Enabled)
                {
                    continentBox.Enabled = true;
                }
            }
            else
            {
                if (!continentBox.Enabled)
                {
                    continentBox.Enabled = true;
                }
                if (!areaBoxMin.Enabled && !areaBoxMax.Enabled)
                {
                    areaBoxMin.Enabled = true;
                    areaBoxMax.Enabled = true;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            continentBox.Text = "";
            areaBoxMin.Text = "";
            areaBoxMax.Text = "";
            populationBoxMin.Text = "";
            populationBoxMax.Text = "";
            searchType.SelectedIndex = 0;
            typeSearchBindingSource.DataSource = null;
            continentBindingSource.DataSource = null;
            countryBindingSource.DataSource = null;
            cityBindingSource.DataSource = null;
            searchResultBoxContinents.Visible = false;
            searchResultBoxCountries.Visible = false;
            searchResultBoxCities.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            searchResultBox.Visible = true;
        }

        private void getLocationButton_Click(object sender, EventArgs e)
        {
            LocationForm locationForm = new LocationForm();
            locationForm.Show();
        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            AddCountryForm addCountryForm = new AddCountryForm(handbook, this);
            addCountryForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            handbook.SaveData(".//");
        }
    }
}
