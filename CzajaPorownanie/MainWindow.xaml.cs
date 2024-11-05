using System.Net.Http;
using System;
using System.Windows;

namespace CzajaPorownanie
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Obliczanie(object sender, RoutedEventArgs e)
        {
            /* Narazie nie   działa  obliczanie bo nic tu nie ma
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-mock.dhl.com/mydhlapi/rates" +
                                                                            "?accountNumber=" +
                                                                            "&originCountryCode=" +
                                                                            "&originCityName=" +
                                                                            "&destinationCountryCode=" +
                                                                            "&destinationCityName=" +
                                                                            "&weight=" +
                                                                            "&length=" +
                                                                            "&width=" +
                                                                            "&height=" +
                                                                            "&plannedShippingDate=" +
                                                                            "&isCustomsDeclarable=false" +
                                                                            "&unitOfMeasurement=metric"),
                Headers =
                {
                    { "Message-Reference", "SOME_STRING_VALUE" },
                    { "Message-Reference-Date", "SOME_STRING_VALUE" },
                    { "Plugin-Name", "SOME_STRING_VALUE" },
                    { "Plugin-Version", "SOME_STRING_VALUE" },
                    { "Shipping-System-Platform-Name", "SOME_STRING_VALUE" },
                    { "Shipping-System-Platform-Version", "SOME_STRING_VALUE" },
                    { "Webstore-Platform-Name", "SOME_STRING_VALUE" },
                    { "Webstore-Platform-Version", "SOME_STRING_VALUE" },
                    { "Authorization", "Basic REPLACE_BASIC_AUTH" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                MessageBox.Show(body);
            }*/
            MessageBox.Show("Test chyba zadziałał , no cóz niz wiecej niema");
        }
    }
}
