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
    public partial class CountryAddForm : Form
    {
        public Handbook Handbook { get; set; }
        public MainForm MainForm { get; set; }
        public CountryAddForm(Handbook handbook, MainForm mainForm)
        {
            InitializeComponent();
            Handbook = handbook;
            MainForm = mainForm;
            continentBindingSource.DataSource = Handbook.Continents;
            continentBox.SelectedIndex = 0;
            continentBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool IsFormFilled()
        {
            if (nameBox.Text == "")
            {
                return false;
            }
            if (countryCodeBox.Text == "")
            {
                return false;
            }
            if (capitalBox.Text == "")
            {
                return false;
            }
            if (governmentBox.Text == "")
            {
                return false;
            }
            if (languageBox.Text == "")
            {
                return false;
            }
            if (areaBox.Text == "")
            {
                return false;
            }
            if (populationBox.Text == "")
            {
                return false;
            }
            return true;
        }

        private void AddCountryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsFormFilled())
            {
                MainForm.FillTreeData();
                return;
            }
            DialogResult result = MessageBox.Show("Зберегти внесені зміни?", "Підтвердіть закриття",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                string name = nameBox.Text;
                string code = countryCodeBox.Text;
                string capital = capitalBox.Text;
                string government = governmentBox.Text;
                string language = languageBox.Text;
                int population;
                double area;
                Continent continent = Handbook.Continents[continentBox.SelectedIndex];
                if (nameBox.Text == "")
                {
                    name = "Нова країна";
                }
                if (countryCodeBox.Text == "")
                {
                    code = "cnt";
                }
                if (capitalBox.Text == "")
                {
                    capital = "Столиця не вказана";
                }
                if (governmentBox.Text == "")
                {
                    government = "Форма правління не вказана";
                }
                if (languageBox.Text == "")
                {
                    language = "Мова не вказана";
                }

                if (populationBox.Text == "")
                {
                    population = 0;
                }
                else
                {
                    population = Convert.ToInt32(populationBox.Text);
                }
                if (areaBox.Text == "")
                {
                    area = 0;
                }
                else
                {
                    area = Convert.ToDouble(areaBox.Text);
                }
                Handbook.AddCountry(name, code, capital, descriptionBox.Text, government, language, population, area, [], continent);
                MainForm.FillTreeData();
                return;
            }
            if (result == DialogResult.No)
            {
                MainForm.FillTreeData();
                return;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Continent continent = Handbook.Continents[continentBox.SelectedIndex];
            if (!IsFormFilled())
            {
                DialogResult result = MessageBox.Show("Продовжити заповнення?", "Є не заповнені поля",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    return;
                }
                if (result == DialogResult.No)
                {
                    this.Close();
                    return;
                }
            }
            Handbook.AddCountry(nameBox.Text, countryCodeBox.Text, capitalBox.Text, descriptionBox.Text, governmentBox.Text,
                languageBox.Text, Convert.ToInt32(populationBox.Text), Convert.ToInt32(areaBox.Text), [], continent);
            DialogResult res = MessageBox.Show("Бажаєте додати міста?", "Додано нову країну",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                CitiesEditForm citiesEditForm = new CitiesEditForm(Handbook.Countries[Handbook.Countries.Count - 1], MainForm);
                citiesEditForm.Show();
                this.Close();
            }
            this.Close();
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

        private void countryCodeBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in countryCodeBox.Text)
            {
                if (!Char.IsLetter(c))
                {
                    countryCodeBox.Text = countryCodeBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void capitalBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in capitalBox.Text)
            {
                if (!Char.IsLetter(c) && c.ToString() != " ")
                {
                    capitalBox.Text = capitalBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void governmentBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in governmentBox.Text)
            {
                if (!Char.IsLetter(c) && c.ToString() != " ")
                {
                    governmentBox.Text = governmentBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void languageBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in languageBox.Text)
            {
                if (!Char.IsLetter(c) && c.ToString() != " ")
                {
                    languageBox.Text = languageBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void populationBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(populationBox.Text, out double population);
            if (!isNumber || population < 0)
            {
                populationBox.Text = "";
            }
        }

        private void areaBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(areaBox.Text, out int area);
            if (!isNumber || area < 0)
            {
                areaBox.Text = "";
            }
        }
    }
}
