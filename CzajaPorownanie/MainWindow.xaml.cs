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

        private void Obliczanie(object sender, RoutedEventArgs e)
        {
            try
            {
                double waga = double.Parse(Waga.Text);
                double dlugosc = double.Parse(Długość.Text);
                double szerokosc = double.Parse(Szerokość.Text);
                double wysokosc = double.Parse(Wysokość.Text);

                double dhlPrice = ObliczCeneDHL(waga, dlugosc, szerokosc, wysokosc);
                double upsPrice = ObliczCeneUPS(waga, dlugosc, szerokosc, wysokosc);
                double fedexPrice = ObliczCeneFedEx(waga, dlugosc, szerokosc, wysokosc);

                MessageBox.Show($"Cena DHL: {dhlPrice} zł\nCena UPS: {upsPrice} zł\nCena FedEx: {fedexPrice} zł");
            }
            catch (FormatException)
            {
                MessageBox.Show("Proszę wprowadzić poprawne dane.");
            }
        }

        private double ObliczCeneDHL(double waga, double dlugosc, double szerokosc, double wysokosc)
        {
            double basePrice = 30.0;
            double weightFactor = 5.0;
            double sizeFactor = 1.0;

            return basePrice + (waga * weightFactor) + ((dlugosc + szerokosc + wysokosc) * sizeFactor);
        }

        private double ObliczCeneUPS(double waga, double dlugosc, double szerokosc, double wysokosc)
        {
            double basePrice = 25.0;
            double weightFactor = 6.0;
            double sizeFactor = 1.5;

            return basePrice + (waga * weightFactor) + ((dlugosc + szerokosc + wysokosc) * sizeFactor);
        }

        private double ObliczCeneFedEx(double waga, double dlugosc, double szerokosc, double wysokosc)
        {
            double basePrice = 28.0;
            double weightFactor = 4.0;
            double sizeFactor = 1.2;

            return basePrice + (waga * weightFactor) + ((dlugosc + szerokosc + wysokosc) * sizeFactor);
        }
    }
}
