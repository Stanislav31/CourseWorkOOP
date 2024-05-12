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
    public partial class MainForm : Form
    {
        Handbook handbook = new Handbook();
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < handbook.Continents.Count; i++)
            {
                TreeNode node = new TreeNode(handbook.Continents[i].Name);
                for (int j = 0; j < handbook.Continents[i].Countries.Count; j++)
                {
                    node.Nodes.Add(new TreeNode(handbook.Continents[i].Countries[j].Name));
                    for (int k = 0; k < handbook.Continents[i].Countries.Count; k++)
                    {
                        node.Nodes[j].Nodes.Add(new TreeNode(handbook.Continents[i].Countries[j].Cities[k].Name));
                    }
                }
                countryView.Nodes.Add(node);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            double areaMin, areaMax;
            int populationMin, populationMax;
            if (areaBoxMin.Text == "")
            {
                areaMin = 0;
            } else
            {
                areaMin = Convert.ToDouble(areaBoxMin.Text);
            }
            if (areaBoxMax.Text == "")
            {
                areaMax = Int32.MaxValue;
            } else
            {
                areaMax = Convert.ToDouble(areaBoxMax.Text);
            }
            if (populationBoxMin.Text == "")
            {
                populationMin = 0;
            } else
            {
                populationMin = Convert.ToInt32(populationBoxMin.Text);
            }
            if (populationBoxMax.Text == "")
            {
                populationMax = Int32.MaxValue;
            } else
            {
                populationMax = Convert.ToInt32(populationBoxMax.Text);
            }
            countryBindingSource1.DataSource = handbook.Search(nameBox.Text, continentBox.Text, [areaMin, areaMax], [populationMin, populationMax]);
        }

        private void areaBoxMin_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(areaBoxMin.Text, out double areaMin);
            if (!isNumber || areaMin < 0)
            {
                areaBoxMin.Text = "0";
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
            bool isNumber = int.TryParse(populationBoxMin.Text, out int populationMin);
            if (!isNumber || populationMin < 0)
            {
                populationBoxMin.Text = "0";
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
    }
}
