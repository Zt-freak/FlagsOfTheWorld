using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Web;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;

namespace FlagsOfTheWorld
{
    public partial class Form1 : Form
    {
        private List<CountriesRoot> countries;
        private CountriesRoot currentCountry;
        private int gameMode = 0;
        private int score = 0;
        private const string countriesURL = "https://restcountries.eu/rest/v2/all?fields=name;alpha2Code";
        private const string countriesData = @"";
        public Form1()
        {
            this.countries = this.Fetch_countries();
            //Debug.WriteLine(this.countries);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Fill_dropdown(this.dropdown, this.countries);
            this.switchModeButton.Text = "play";
        }

        private List<CountriesRoot> Fetch_countries()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(countriesURL);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.ContentLength = countriesData.Length;

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    string response = responseReader.ReadToEnd();
                    Console.Out.WriteLine(response);
                    return JsonConvert.DeserializeObject<List<CountriesRoot>>(response);
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            return new List<CountriesRoot>();
        }

        private void Fill_dropdown(ComboBox dropdown, List<CountriesRoot> countries)
        {
            foreach (var country in countries)
            {
                dropdown.Items.Add(country.name);
            }
        }

        private void switchModeButton_Click(object sender, EventArgs e)
        {
            switch (this.gameMode)
            {
                case 0: // practice mode to game mode
                    this.new_round();
                    this.gameMode = 1;
                    this.switchModeButton.Text = "practice";
                    break;
                case 1: // game mode to practice mode
                    this.gameMode = 0;
                    this.switchModeButton.Text = "play";
                    break;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            CountriesRoot country = this.countries.FirstOrDefault(item => item.name == this.dropdown.Text);
            string flagURL;
            switch (this.gameMode)
            {
                case 0: // practice mode
                    if (country != null)
                    {
                        flagURL = "https://www.countryflags.io/" + country.alpha2Code + "/flat/64.png";
                    }
                    else
                    {
                        flagURL = "https://upload.wikimedia.org/wikipedia/commons/c/cc/Flag_missing.jpg";
                    }
                    this.flagBox.Load(flagURL);
                    break;
                case 1: // game mode
                    if (country != null)
                    {
                        if (country.alpha2Code == this.currentCountry.alpha2Code)
                        {
                            this.score++;
                        }
                        else
                        {
                            this.score = 0;
                        }
                        this.scoreLabel.Text = "score: " + this.score.ToString();
                        this.new_round();
                    }
                    break;
            }
        }

        private void new_round()
        {
            var random = new Random();
            int randomIndex = random.Next(this.countries.Count);
            this.currentCountry = this.countries[randomIndex];
            string flagURL = "https://www.countryflags.io/" + this.currentCountry.alpha2Code + "/flat/64.png";
            this.flagBox.Load(flagURL);
        }
    }

    public class CountriesRoot
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("alpha2Code")]
        public string alpha2Code { get; set; }
    }
}
