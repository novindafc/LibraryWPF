using LibraryWPF.Model.Member;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for MemberEditWindow.xaml
    /// </summary>
    public partial class MemberEditWindow : Window
    {
        private Datum _data;
        public MemberEditWindow(Datum data)
        {
            InitializeComponent();
            _data = data;
            OnLoad();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool valid = true;
            int iD = 0;
            Datum data = new Datum();
            data.name = name.Text.ToString();
            data.gender = gender.Text.ToString();
            data.phone = phone.Text.ToString();
            data.occupation = occupation.Text.ToString();
            data.email = email.Text.ToString();
            string _id = id.Text.ToString();
            valid = int.TryParse(_id, out iD);
            if (valid == true)
            {
                data.id = iD;
                var myJSON = JsonConvert.SerializeObject(data);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:5001/api/Member/EditMember");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(myJSON);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("Unable to edit file, try again.");
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

        private void OnLoad()
        {
            id.Text = _data.id.ToString();
            name.Text = _data.name;
            gender.Text = _data.gender;
            phone.Text = _data.phone;
            occupation.Text = _data.occupation;
            email.Text = _data.email;

        }

    }
}
