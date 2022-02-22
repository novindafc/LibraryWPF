using LibraryWPF.Model.BookLog;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for BookLogEditWindow.xaml
    /// </summary>
    public partial class BookLogEditWindow : Window
    {
        private Datum _data;
        public BookLogEditWindow(Datum data)
        {
            InitializeComponent();
            _data = data;
            OnLoad();
        }
        private void OnLoad()
        {
            id.Text = _data.id.ToString();
            startTime.Text = _data.startTime.ToString();
            endTime.Text = _data.endTime.ToString();
            bookId.Text = _data.bookId.ToString();
            memberId.Text = _data.memberId.ToString();
            status.Text = _data.status;

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
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
            int idbook = 0;
            int idmember = 0;
            bool valid = true;
            int iD = 0;
            Datum data = new Datum();
            string format = "yyyy.MM.dd HH:mm:ss:ffff";
            string start = startTime.Text.ToString();
            string end = endTime.Text.ToString();
            DateTime dateStart = DateTime.ParseExact(start, format,
                                       CultureInfo.InvariantCulture);
            DateTime dateEnd = DateTime.ParseExact(end, format,
                CultureInfo.InvariantCulture);
            data.startTime = dateStart;
            data.endTime = dateEnd;
            string book_id = bookId.Text.ToString();
            valid = int.TryParse(book_id, out idbook);
            if (valid == true)
            {
                data.bookId = idbook;
                string member_id = memberId.Text.ToString();
                valid = int.TryParse(member_id, out idmember);
                if (valid == true)
                {
                    data.memberId = idmember;
                    data.status = status.Text.ToString();
                    string _id = id.Text.ToString();
                    valid = int.TryParse(_id, out iD);
                    if (valid == true)
                    {
                        data.id = iD;
                        var myJSON = JsonConvert.SerializeObject(data);
                        var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://localhost:5001/api/BookLog/EditBookLog");
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
                    
                }
                else
                {
                    MessageBox.Show("Unable to edit file, try again.");
                }
            }
            else
            {
                MessageBox.Show("Unable to edit file, try again.");
            }
            this.Hide();
            BookLogWindow window = new BookLogWindow();
            window.Show();
            window.Activate();
        }

    }
    }

