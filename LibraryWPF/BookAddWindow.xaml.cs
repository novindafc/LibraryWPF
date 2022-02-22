using LibraryWPF.Model.Book;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    public partial class BookAddWindow : Window
    {
        public BookAddWindow()
        {
            InitializeComponent();
        }
        

        private void TextBox_TextTitle(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextAuthor(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_TextPosition(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextQuantity(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_TextRemains(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItemHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.Show();
            window.Activate();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numberQty = 0;
            int numberRemain = 0;
            bool valid = true;
            Datum data = new Datum();
            data.title = title.Text.ToString();
            data.author = author.Text.ToString();
            data.position = position.Text.ToString();
            string qty = quantity.Text.ToString();
            valid = int.TryParse(qty, out numberQty); 
            if(valid == true)
            {
                data.qty = numberQty;
                string remain = remains.Text.ToString();
                valid = int.TryParse(remain, out numberRemain);
                if (valid == true)
                {
                    data.remains = numberRemain;
                    var myJSON = JsonConvert.SerializeObject(data);
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:5001/api/Book/AddBook");
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
                }
                else
                {
                    MessageBox.Show("Unable to save file, try again.");
                }
            }
            else
            {
                MessageBox.Show("Unable to save file, try again.");
            }
            this.Hide();
            BookWindow window = new BookWindow();
            window.Show();
            window.Activate();

        }
    }
}
