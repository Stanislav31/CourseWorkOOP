using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class UserLocation
    {
        public string Country { get; set; }
        public string City { get; set; }
        public UserLocation()
        {
            try
            {
                string ip = new WebClient().DownloadString("https://api.ipify.org");
                string url = "https://freeipapi.com/api/json/" + ip;

                WebRequest wrGetUrl = WebRequest.Create(url);
                Stream stream = wrGetUrl.GetResponse().GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                var data = JsonObject.Parse(sr.ReadLine());
                Country = data["countryName"].ToString();
                City = data["cityName"].ToString();
            } catch (Exception e)
            {
                Country = "Невизначено";
                City = "Невизначено";
            }
            
        }
    }
}
