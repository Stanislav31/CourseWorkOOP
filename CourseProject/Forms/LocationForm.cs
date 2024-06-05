using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CourseProject.Forms
{
    public partial class LocationForm : Form
    {
        public LocationForm()
        {
            InitializeComponent();
            this.Text = "Ваше місцезнаходження";
            UserLocation location = new UserLocation();
            country.Text = "Країна: " + location.Country;
            city.Text = "Місто: " + location.City;
        }
    }
}
