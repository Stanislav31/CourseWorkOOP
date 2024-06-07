using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public void AddCountry(Country country)
        {
            Countries.Add(country);
            foreach (var continent in Continents)
            {
                if (continent.Name == country.Continent.Name)
                {
                    continent.Countries.Add(country);
                }
            }
        }
        public void AddCountry(string name,
                    string code,
                    string capital,
                    string description,
                    string government,
                    string language,
                    int population,
                    double area,
                    List<City> cities,
                    Continent continent)
        {
            Countries.Add(new Country
            {
                Name = name,
                CountryCode = code,
                Capital = capital,
                Description = description,
                Government = government,
                Language = language,
                Population = population,
                Area = area,
                Cities = cities,
                Continent = continent,
            });
            continent.Countries.Add(Countries[Countries.Count - 1]);
        }
        public Country DeleteCountry(Country country)
        {
            foreach (var continent in Continents)
            {
                if (continent.Name == country.Continent.Name)
                {
                    continent.Countries.Remove(country);
                }
            }
            Countries.Remove(country);
            return country;
        }
        public void GenerateBaseData()
        {
            Continents.Clear();
            Countries.Clear();
            Continents.Add(new Continent
            {
                Countries = [],
                Name = "Австралія й Океанія",
                Description = "Австралія й Океанія — частина світу, що складається з материка Австралія, островів, " +
                "що прилягають до Австралії та островів, які входять в Океанію.\nЗагальна площа Австралії та Океанії " +
                "становить 8,52 млн км², населення — 43 млн осіб. (9 вересня 2021) (0,6 % населення Землі)." +
                "\nДля Австралії та Океанії характерні теплий морський клімат, високий ендемізм флори і фауни.",
                Area = 8520000,
                Population = 43000000
            });
            Continents.Add(new Continent
            {
                Countries = [],
                Name = "Африка",
                Description = "Африка — другий за площею і населенням материк у світі, після Євразії. " +
                "Загальна площа континенту становить понад 30,27 млн км², враховуючи прилеглі острови — він займає 5,9 % " +
                "площі земної поверхні і 20,3 % площі суходолу.\nНаселення континенту, станом на 2023 рік, оцінюється майже " +
                "в 1,3 млрд (понад 16 % населення світу). Населення Африки є наймолодшим серед усіх континентів; " +
                "середній вік 2012 року становив 19,7, проти середньосвітового — 30,4. Сучасна карта " +
                "континенту — це велике різноманіття народів, народностей, їхніх традицій, вірувань, культур і мов." +
                "\nКонтинент омивається на сході водами Індійського океану і Червоного моря, на заході — Атлантичного, " +
                "на півночі — Середземного моря останнього. На північному заході Африка відділена Гібралтарською протокою від " +
                "Європи, на північному сході — Суецьким каналом і Баб-ель-Мандебською протокою від Азії. Найбільший острів, " +
                "що належить до континенту — Мадагаскар. Африка — єдиний материк, розташований у всіх чотирьох " +
                "півкулях Землі: Північній, Південній, Східній і Західній. Через центральну частину материка проходить екватор, " +
                "від якого на північ і південь майже симетрично розходяться природні зони. Це єдиний материк, " +
                "що простягнувся від північного до південного субтропічного поясу.",
                Area = 30370000,
                Population = 1216000000
            });
            Continents.Add(new Continent
            {
                Countries = [],
                Name = "Євразія",
                Description = "Євразія — найбільший за розмірами та населенням материк на Землі, що складається " +
                "з Європи та Азії. Розташований в основному між північною та східною півкулями, межує з Атлантичним " +
                "океаном на заході, Тихим на сході, Північно-Льодовитим на півночі, а також Африкою, Середземним морем " +
                "та Індійським океаном на півдні. Історично, поділ між Європою та Азією на два різні континенти завжди " +
                "був соціально-культурним, і не мав чіткого фізичного кордону між ними; таким чином, у деяких частинах " +
                "світу, Євразія визнана найбільшим з шести, п'яти чи навіть чотирьох континентів Землі. " +
                "У геології, Євразія часто розглядається, як єдиний жорсткий мегаблок. Однак, жорсткість Євразії обговорюється, " +
                "і основана на палеомагнітних даних.\nМатерик займає близько 55 000 000 км², " +
                "або близько 36,2 % загальної площі суходолу Землі. Суходіл населяє понад 5 мільярдів людей, що становить " +
                "приблизно 70 % населення Землі. Серед основних островів, які часто включають до широковживаного " +
                "визначення Євразії, незважаючи на те, що вони відокремлені від суцільної суші: Велика Британія, Ісландія, " +
                "Ірландія та Шрі-Ланка, а також Японія, Філіппіни та більшу частину Індонезії.",
                Area = 55000000,
                Population = 5349000000
            });
            Continents.Add(new Continent
            {
                Countries = [],
                Name = "Південна Америка",
                Description = "Південна Америка — материк, розташований в Західній, Південній і частково в Північній " +
                "півкулях планети Земля. На заході омивається водами Тихого океану, на сході — Атлантичного. " +
                "На півночі з'єднаний Панамським перешийком з Північною Америкою.\nДо складу Південної Америки входить " +
                "також низка островів. Великі й Малі Антильські острови Карибського моря належать до Північної Америки." +
                "\nНазву «Америка» стосовно цього континенту вперше застосував Мартін Вальдземюллер, нанісши на свою карту " +
                "латинський варіант імені Амеріго Веспуччі, який вперше припустив, що відкриті Христофором Колумбом землі " +
                "не мають стосунку до Індії, тобто не є Вест-Індією, а є Новим світом, невідомим до того європейцям.",
                Area = 17800000,
                Population = 423000000
            });
            Continents.Add(new Continent
            {
                Countries = [],
                Name = "Північна Америка",
                Description = "Північна Америка — материк у Західній півкулі, північна частина частини світу Америки. " +
                "Повністю розташований у північній півкулі та майже повністю — у західній." +
                "\nНа півночі омивається Північним Льодовитим океаном, на сході — Атлантичним океаном, на заході — Тихим океаном, " +
                "на півдні — Карибським морем; також на півдні з'єднується Панамським перешийком з Південною Америкою. " +
                "Загальна площа 24 709 000 км², що становить близько 4,8 % площі планети або 16,5 % площі її суші." +
                "\nПівнічна Америка є третім за величиною і кількістю населення континентом після Євразії та Африки.",
                Area = 24709000,
                Population = 579000000
            });
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
                        Continent = Continents[i]
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
