using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace postcode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string postcode = "WR14 2XD";

        // https://api.postcodes.io/postcodes/%20WR14%202XD

        private const string URL = "https://api.postcodes.io/postcodes/";
        private const string DATA = @"";

        public MainWindow()
        {
            InitializeComponent();

            string s = get(URL);

        //    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(s);

        }

        protected string get(string url)
        {
            try
            {
                string rt;

                System.Net.WebRequest request = WebRequest.Create(url);

                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                rt = reader.ReadToEnd();

                Console.WriteLine(rt);

                reader.Close();
                response.Close();

                return rt;
            }

            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
        public string HttpGet(string URI)
        {
            WebClient client = new WebClient();

            // Add a user agent header in case the 
            // requested URI contains a query.

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead(URI);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return s;
        }

        private void getres(object sender, RoutedEventArgs e)
        {
            string newu = URL + posty.Text;
            string s = get(newu);

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(s);

            Console.WriteLine(s);

            output.Text = s;
        }
    }
}
