using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace WebApiFireAlarmTester
{
    //  TODO 01 : XAML opmaken (via snippet)
    //  TODO 02: Maak classe FireAlarm

    public partial class MainWindow : Window
    {
        //  TODO 03: HTTP-client maken
        HttpClient _httpClient = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();

            //TODO 04: Client instellen

            _httpClient.BaseAddress = new Uri("https://localhost:44341/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // TODO 05: GET-method aanspreken om alle data op te vragen

        private async void UpdateListView()
        {
            List<FireAlarm> fireAlarms = null;

            //HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("/"); //werkt niet
            //HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(new Uri("https://localhost:44341/api/FireAlarms/")); //werkt wel
            //HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(new Uri("/")); //werkt niet
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/FireAlarms/"); //werkt wel
           //HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(new Uri("https://localhost:44341/api/FireAlarms/")); //werkt wel


            //TODO 06: via NuGet Microsoft... WebApi.Client installeren

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                fireAlarms = await httpResponseMessage.Content.ReadAsAsync<List<FireAlarm>>();
            }

            fireAlarms.Sort(); //hiervoor hebben we Icomparable geimplementeerd
            lstFireAlarms.ItemsSource = fireAlarms;
        }
        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            //TODO 07: List updaten
            UpdateListView();
        }

        private async void btnPost_Click(object sender, RoutedEventArgs e)
        {
            //TODO 08: Code voor posten
            FireAlarm fireAlarm = new FireAlarm();
            fireAlarm.Location = tbxLocationPost.Text;
            fireAlarm.Active = (bool)cbxActivePost.IsChecked;
            fireAlarm.Reason = ((ComboBoxItem)cbxReasonPost.SelectedValue).Content.ToString();

            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/firealarms", fireAlarm);

            httpResponseMessage.EnsureSuccessStatusCode();

            UpdateListView();
        }

        private async void btnPut_Click(object sender, RoutedEventArgs e)
        {
            //TODO 09: put, bestaande updaten
            FireAlarm fireAlarm = new FireAlarm();
            fireAlarm.Id = Convert.ToUInt64(tbxIdPut.Text);
            fireAlarm.Location = tbxLocationPut.Text;
            fireAlarm.Active = (bool)cbxActivePut.IsChecked;
            fireAlarm.Reason = ((ComboBoxItem)cbxReasonPut.SelectedValue).Content.ToString();

            HttpResponseMessage httpResponseMessage = await _httpClient.PutAsJsonAsync("api/firealarms/" + fireAlarm.Id, fireAlarm);

            httpResponseMessage.EnsureSuccessStatusCode();

            UpdateListView();
        }
        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //TODO 10: delete
         
            HttpResponseMessage httpResponseMessage = await _httpClient.DeleteAsync($"api/firealarms/{tbxIdDelete.Text}");

            UpdateListView();

        }


        private void tbx_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
