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
    public partial class AddCountryForm : Form
    {
        public Handbook Handbook { get; set; }
        public MainForm MainForm { get; set; }
        public AddCountryForm(Handbook handbook, MainForm mainForm)
        {
            InitializeComponent();
            Handbook = handbook;
            MainForm = mainForm;
            continentBindingSource.DataSource = Handbook.Continents;
            continentBox.SelectedIndex = 0;
            continentBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Continent continent = Handbook.Continents[continentBox.SelectedIndex];
            foreach (Control control in Controls)
            {
                if (control.Name.Contains("Box") && control.Text == "")
                {
                    DialogResult result = MessageBox.Show("Продовжити заповнення?", "Є не заповнені поля", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
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
            }

            Handbook.Countries.Add(new Country
            {
                Name = nameBox.Text,
                CountryCode = countryCodeBox.Text,
                Capital = capitalBox.Text,
                Description = descriptionBox.Text,
                Government = governmentBox.Text,
                Language = languageBox.Text,
                Population = Convert.ToInt32(populationBox.Text),
                Area = Convert.ToInt32(areaBox.Text),
                Cities = [],
                Continent = continent,
            });
            continent.Countries.Add(Handbook.Countries[Handbook.Countries.Count - 1]);
            this.Close();
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
                if (!Char.IsLetter(c))
                {
                    capitalBox.Text = capitalBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void governmentBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in governmentBox.Text)
            {
                if (!Char.IsLetter(c))
                {
                    governmentBox.Text = governmentBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void languageBox_Validating(object sender, CancelEventArgs e)
        {
            foreach (var c in languageBox.Text)
            {
                if (!Char.IsLetter(c))
                {
                    languageBox.Text = languageBox.Text.Replace(c.ToString(), "");
                }
            }
        }

        private void populationBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(populationBox.Text, out int population);
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

        private bool IsFormFilled()
        {
            bool isFilled = true;
            foreach (Control control in Controls)
            {
                if (control.Name.Contains("Box") && control.Text == "")
                {
                    isFilled = false;
                    break;
                }
            }
            return isFilled;
        }

        private void AddCountryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsFormFilled())
            {
                MainForm.FillTreeData();
                return;
            }
            DialogResult result = MessageBox.Show("Зберегти внесені зміни?", "Підтвердіть закриття", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
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
                } else
                {
                    population = Convert.ToInt32(populationBox.Text);
                }
                if (areaBox.Text == "")
                {
                    area = 0;
                } else
                {
                    area = Convert.ToDouble(areaBox.Text);
                }
                
                Handbook.Countries.Add(new Country
                {
                    Name = name,
                    CountryCode = code,
                    Capital = capital,
                    Description = descriptionBox.Text,
                    Government = government,
                    Language = language,
                    Population = population,
                    Area = area,
                    Cities = [],
                    Continent = continent,
                });
                continent.Countries.Add(Handbook.Countries[Handbook.Countries.Count - 1]);
                MainForm.FillTreeData();
                return;
            }
            if (result == DialogResult.No)
            {
                MainForm.FillTreeData();
                return;
            }
        }
    }
}
