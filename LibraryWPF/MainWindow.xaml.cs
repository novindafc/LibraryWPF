using LibraryWPF.Model.BookLog;
using System;
using System.Collections.Generic;
using System.Linq;
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
using LibraryWPF.AppConfig;
using LibraryWPF.Model;

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OnLoadCommandBookLog command = new OnLoadCommandBookLog();
     
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            Root root = await command.GetAPIAsync("https://localhost:5001/api/BookLog/GetBookLog");
            String strJson = Newtonsoft.Json.JsonConvert.SerializeObject(root);
            Root deserializedObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(strJson);
            dataGrid.ItemsSource = deserializedObject.value.data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BookLogAddWindow window = new BookLogAddWindow();
            window.Show();
            window.Activate();
            

        }

        private void MenuItemBook_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BookWindow window = new BookWindow();
            window.Show();
            window.Activate();
           

        }
        private void MenuItemHome_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.Show();


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


    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    

    

    


}

