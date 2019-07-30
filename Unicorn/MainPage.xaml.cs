using System;
using Windows.UI.Xaml.Controls;
using Microsoft.WindowsAzure.MobileServices;
using System.Text.RegularExpressions;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
public static MobileServiceClient MobileService = new MobileServiceClient("https://unnati1.azurewebsites.net");

namespace Unicorn
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>


    public sealed partial class MainPage : Page
    {
        int a=0;

        public MainPage()
        {
            
            this.InitializeComponent();
            fillCombo();
            DateTime temp = DateTime.Now;
            string date11;
            date11= temp.AddDays(1).ToString();
            date1.Content = date11.Substring(0, 10);
            date11 = temp.AddDays(2).ToString();
            date2.Content = date11.Substring(0, 10);
            date11 = temp.AddDays(3).ToString();
            date3.Content = date11.Substring(0, 10);
            date11 = temp.AddDays(4).ToString();
            date4.Content = date11.Substring(0, 10);
            date11 = temp.AddDays(5).ToString();
            date5.Content = date11.Substring(0, 10);
            date11 = temp.AddDays(6).ToString();
            date6.Content = date11.Substring(0, 10);
            date11 = temp.AddDays(7).ToString();
            date7.Content = date11.Substring(0, 10);




    }

    
        private void fillCombo()
        {
            cb.Items.Add("Rice");
            cb.Items.Add("Wheat");
            cb.Items.Add("Jowar");
            cb.Items.Add("Bajra");
            cb.Items.Add("Maize");
            cb.Items.Add("Barley");
            cb.Items.Add("Ragi");
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string w = weight.Text;

            if(a==1&& Regex.IsMatch(w, @"^\d+$")
            {
                Submit.IsEnabled = true;
                //The algorithm to find the best day is to be written
            }
)
        }
        


            private void cb_LostFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            a = 1;
        }

        private void Submit_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            TodoItem item = new TodoItem
            {
                Grain = cb.ToString(),
                Weight = weight.Text,
                date = date1.Content.ToString()

            };
            await App.MobileService.GetTable<todoitem>().InsertAsync(item);
            Submit.IsEnabled = false;
        }
    }

    internal class TodoItem
    {
        public string Grain { get; set; }
        public string Weight { get; set; }
        public string date { get; set; }
    }
}
