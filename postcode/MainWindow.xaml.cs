using Newtonsoft.Json;
using postcode.Xml3CSharp;
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
using System.Xml.Serialization;

namespace postcode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string postcode = "WR14 2XD";
        QRZDatabase session;

        // https://api.postcodes.io/postcodes/%20WR14%202XD

        private const string URL = "https://api.postcodes.io/postcodes/";
        private const string DATA = @"";

        string urlcallsign = @"https://xmldata.qrz.com/xml/current/?s=";

        public MainWindow()
        {
            InitializeComponent();

            string s = get(URL);

        //    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(s);

        }

        public string get(string url)
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
        public string HttpGet7(string URI)
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

            string s = Access.get(newu);

            //string s = get(newu);

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(s);

            Console.WriteLine(s);

            output.Text = s;
        }

        private void getxml(object sender, RoutedEventArgs e)
        {
            //string s = File.ReadAllText("xml.txt");

            string url = @"https://xmldata.qrz.com/xml/current/?username=M0JFG;password=" + password.Text;

            string s = get(url);

            XmlSerializer serializer = new XmlSerializer(typeof(QRZDatabase));
            using (StringReader reader = new StringReader(s))
            {
                session = (QRZDatabase)serializer.Deserialize(reader);
             }
        }

        private void getxml2(object sender, RoutedEventArgs e)
        {
            if ( session == null )
            {
                MessageBox.Show("No session");
                return;
            }

            string news = urlcallsign + session.Session.Key + ";callsign=M0JFG";

            string s = get(news);

            //string s = File.ReadAllText("xml2.txt");

            XmlSerializer serializer = new XmlSerializer(typeof(Xml2CSharp.QRZDatabase));
            using (StringReader reader = new StringReader(s))
            {
                var test = (Xml2CSharp.QRZDatabase)serializer.Deserialize(reader);

                output.Text = Newtonsoft.Json.JsonConvert.SerializeObject(test, Formatting.Indented );
            }
        }
    }
}
