using LibraryWPF.Model.Book;
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
    public partial class BookEditWindow : Window
    {
        private Datum _data;
        public BookEditWindow(Datum data)
        {
            InitializeComponent();
            _data = data;
            OnLoad();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
            title.Text = _data.title;
            author.Text = _data.author;
            position.Text = _data.position;
            quantity.Text = _data.qty.ToString();
            remains.Text = _data.remains.ToString();

        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numberQty = 0;
            int numberRemain = 0;
            int iD = 0;
            bool valid = true;
            Datum data = new Datum();
            data.title = title.Text.ToString();
            data.author = author.Text.ToString();
            data.position = position.Text.ToString();
            string qty = quantity.Text.ToString();
            valid = int.TryParse(qty, out numberQty);
            if (valid == true)
            {
                data.qty = numberQty;
                string remain = remains.Text.ToString();
                valid = int.TryParse(remain, out numberRemain);
                if (valid == true)
                {
                    data.remains = numberRemain;
                    string idStr = id.Text.ToString();
                    valid = int.TryParse(idStr, out iD);
                    if (valid == true)
                    {
                        data.id = iD;
                        var myJSON = JsonConvert.SerializeObject(data);
                        var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:5001/api/Book/EditBook");
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
                        MessageBox.Show("Unable to save file, try again.");
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
