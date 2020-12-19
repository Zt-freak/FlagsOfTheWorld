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
        public List<CountriesRoot> countries;
        private const string URL = "https://restcountries.eu/rest/v2/all?fields=name;alpha2Code";
        private const string DATA = @"";
        public Form1()
        {
            this.countries = this.Fetch_countries();
            //Debug.WriteLine(this.countries);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Fill_dropdown(this.dropdown, this.countries);
        }

        private List<CountriesRoot> Fetch_countries()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;

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
    }

    public class CountriesRoot
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("alpha2Code")]
        public string alpha2Code { get; set; }
    }
}
