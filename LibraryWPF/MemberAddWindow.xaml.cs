using LibraryWPF.Model.Member;
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

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MemberAddWindow : Window
    {
        public MemberAddWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            Datum data = new Datum();
            data.name = name.Text.ToString();
            data.gender = gender.Text.ToString();
            data.phone = phone.Text.ToString();
            data.occupation = occupation.Text.ToString();
            data.email = email.Text.ToString();
       
            var myJSON = JsonConvert.SerializeObject(data);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:5001/api/Member/AddMember");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(myJSON);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            this.Hide();
            MemberWindow window = new MemberWindow();
            window.Show();
            window.Activate();

        }
        private void MenuItemHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
            window.Activate();

        }

    }
}