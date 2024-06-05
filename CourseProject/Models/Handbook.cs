using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Handbook
    {
        public List<Continent> Continents { get; set; }
        public List<Country> Countries { get; set; }
        public Handbook()
        {
            Continents = new List<Continent>();
            Countries = new List<Country>();
            GenerateTestData(50);
        }
        public void GenerateBaseData()
        {
            Continents.Clear();
            Countries.Clear();
            string DESCRIPTION = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi ornare convallis tortor, a hendrerit metus suscipit id. Morbi tincidunt tempor dui vitae viverra. Sed vel nisl vitae mi volutpat venenatis. Sed arcu tellus, fringilla quis egestas convallis, sollicitudin eu erat. Aliquam sed ipsum nibh. Nam vestibulum euismod viverra. Aenean a.";
            for (int i = 0; i < 5; i++)
            {
                Continents.Add(new Continent
                {
                    Countries = [],
                    Name = "Continent" + i,
                    Description = DESCRIPTION,
                    Area = i * 50000,
                    Population = i * 100000
                });
            }
        }
        public void GenerateTestData(int count)
        {
            string DESCRIPTION = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi ornare convallis tortor, a hendrerit metus suscipit id. Morbi tincidunt tempor dui vitae viverra. Sed vel nisl vitae mi volutpat venenatis. Sed arcu tellus, fringilla quis egestas convallis, sollicitudin eu erat. Aliquam sed ipsum nibh. Nam vestibulum euismod viverra. Aenean a.";
            Continents.Clear();
            Countries.Clear();
            for (int i = 0; i < count/10; i++)
            {
                Continents.Add(new Continent
                {
                    Countries = [],
                    Name = "Continent" + i,
                    Description = DESCRIPTION,
                    Area = i * 50000,
                    Population = i * 100000
                });;
                for (int j = 0; j < count; j++)
                {
                    Continents[i].Countries.Add(new Country
                    {
                        Name = "Country" + j,
                        CountryCode = "C" + j,
                        Capital = "CapitalOf" + j,
                        Description = DESCRIPTION,
                        Government = "GovernmentOf" + j,
                        Language = "LanguageOf" + j,
                        Population = j * 10000,
                        Area = j * 500,
                        Cities = [],
                        Continent = Continents[i],
                        //TimeZone = TimeZoneInfo.Local
                    });
                    for (int k = 0; k < count/5; k++)
                    {
                        Continents[i].Countries[j].Cities.Add(new City
                        {
                            Name = "City" + k,
                            Description = DESCRIPTION,
                            Country = Continents[i].Countries[j],
                            Population = k * 1000,
                            Coordinates = [0.6 * k, 0.65 * k]
                        });
                    }
                    Countries.Add(Continents[i].Countries[j]);
                }
            }
            
        }

        internal List<Continent> SearchContinent(string name, double[] area, int[] population)
        {
            List<Continent> result = new List<Continent>();
            foreach (var cont in Continents)
            {
                if (cont.Name.Contains(name) && (cont.Area >= area[0] && cont.Area <= area[1]) && (cont.Population >= population[0] && cont.Population <= population[1]))
                {
                    result.Add(cont);
                }
            }
            return result;
        }
        internal List<Country> SearchCountry(string name, string continent, double[] area, int[] population)
        {
            List<Country> result = new List<Country>();
            foreach (var c in Countries)
            {
                if (c.Name.Contains(name) && c.Continent.Name.Contains(continent) && (c.Area >= area[0] && c.Area <= area[1]) && (c.Population >= population[0] && c.Population <= population[1]))
                {
                    result.Add(c);
                }
            }
            return result;
        }
        internal List<City> SearchCity(string name, string continent, int[] population)
        {
            List<City> result = new List<City>();
            foreach (var country in Countries)
            {
                if (country.Continent.Name.Contains(continent))
                {
                    foreach (var city in country.Cities)
                    {
                        if (city.Name.Contains(name) && (city.Population >= population[0] && city.Population <= population[1]))
                        {
                            result.Add(city);
                        }
                    }
                }               
            }
            return result;
        }
        public void SaveData(string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(this, options = options);
            File.WriteAllText(path + "HandbookData.txt", json);
        }
        public Handbook LoadData(string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };
            Continents.Clear();
            Countries.Clear();
            string json = File.ReadAllText(path + "HandbookData.txt");
            return JsonSerializer.Deserialize<Handbook>(json, options = options);
        }
        //public void SaveData(string path)
        //{
        //    JsonSerializerOptions options = new JsonSerializerOptions
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve,
        //        WriteIndented = true
        //    };

        //    string json = JsonSerializer.Serialize(this.Continents, options = options);
        //    File.WriteAllText(path + "Continents.txt", json);
        //    json = JsonSerializer.Serialize(this.Countries, options = options);
        //    File.WriteAllText(path + "Countries.txt", json);
        //}
        //public void LoadData(string path)
        //{
        //    JsonSerializerOptions options = new JsonSerializerOptions
        //    {
        //        ReferenceHandler = ReferenceHandler.Preserve,
        //        WriteIndented = true
        //    };
        //    string json = File.ReadAllText(path + "Continents.txt");
        //    Continents = JsonSerializer.Deserialize<List<Continent>>(json, options = options);
        //    json = File.ReadAllText(path + "Countries.txt");
        //    Countries = JsonSerializer.Deserialize<List<Country>>(json, options = options);
        //}
    }
}
