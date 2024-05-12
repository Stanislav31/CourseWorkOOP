using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Handbook
    {
        public List<Country> Countries { get; set; }
        public List<Continent> Continents { get; set; }
        public Handbook()
        {
            Countries = new List<Country>();
            Continents = new List<Continent>();
            GenerateTestData(50);
        }
        public void GenerateTestData(int count)
        {
            Continents.Clear();
            Countries.Clear();
            for (int i = 0; i < count/10; i++)
            {
                Continents.Add(new Continent
                {
                    Countries = [],
                    Name = "Continent" + i,
                    Area = i * 50000,
                    Population = i * 100000
                });
                for (int j = 0; j < count; j++)
                {
                    Continents[i].Countries.Add(new Country
                    {
                        Name = "Country" + j,
                        CountryCode = "C" + j,
                        Capital = "CapitalOf" + j,
                        Description = "DescriptionOf" + j,
                        Government = "GovernmentOf" + j,
                        Language = "LanguageOf" + j,
                        Population = j * 10000,
                        Area = j * 500,
                        Cities = [],
                        Continent = Continents[i]
                    });
                    for (int k = 0; k < count * 5; k++)
                    {
                        Continents[i].Countries[j].Cities.Add(new City
                        {
                            Name = "City" + k,
                            Country = Continents[i].Countries[j],
                            Population = k * 1000,
                            Coordinates = [0.6 * k, 0.65 * k]
                        });
                    }
                    Countries.Add(Continents[i].Countries[j]);
                }
            }
            
        }

        internal List<Country> Search(string name, string continent, double[] area, int[] population)
        {
            List<Country> result = new List<Country>();
            foreach(var c in Countries)
            {
                if (c.Name.Contains(name) && c.Continent.Name.Contains(continent) && (c.Area > area[0] && c.Area < area[1]) && (c.Population > population[0] && c.Population < population[1]))
                {
                    result.Add(c);
                }
            }
            return result;
        }
    }
}
