using LibraryWPF.Model.Book;
using LibraryWPF.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Collections;
using System.Net;
using System.IO;

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        OnLoadCommandBook command = new OnLoadCommandBook();
        private Visual sender;

        public BookWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            Root root = await command.GetAPIAsync("https://localhost:5001/api/Book/GetBook");
            String strJson = Newtonsoft.Json.JsonConvert.SerializeObject(root);
            Root deserializedObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(strJson);
            dataGrid.ItemsSource = deserializedObject.value.data;
        }

        private void MenuItemBook_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BookWindow window = new BookWindow();
            window.Show();
            window.Activate();


        }
        private void MenuItemMember_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MemberWindow window = new MemberWindow();
            window.Show();
            window.Activate();
        }
        private void MenuItemBookLog_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BookLogWindow window = new BookLogWindow();
            window.Show();
            window.Activate();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookAddWindow window = new BookAddWindow();
            window.Show();
            window.Activate();

        }
        private void btnView_Delete(object sender, RoutedEventArgs e)
        {
            Datum row = dataGrid.SelectedItem as Datum;
            int id = row.id;
            string uri = "https://localhost:5001/api/Book/DeleteBook?Id="+id.ToString();
            
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            
            httpWebRequest.Method = "DELETE";
            httpWebRequest.GetRequestStream();

           
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

            }
            catch (WebException webex)
            {
                WebResponse errResp = webex.Response;
                using (Stream respStream = errResp.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(respStream);
                    string text = reader.ReadToEnd();
                }
            }
            this.Hide();
            LoadData();
            this.Show();
            CollectionViewSource.GetDefaultView(dataGrid.ItemsSource).Refresh();
            MessageBox.Show("Delete Succes!");

        }
        private void btnView_Edit(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Datum data = dataGrid.SelectedItem as Datum;
            BookEditWindow window = new BookEditWindow(data);
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
