using System;
using System.Globalization;
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
                double waga = double.Parse(Waga.Text, CultureInfo.InvariantCulture);
                double dlugosc = double.Parse(Długość.Text, CultureInfo.InvariantCulture);
                double szerokosc = double.Parse(Szerokość.Text, CultureInfo.InvariantCulture);
                double wysokosc = double.Parse(Wysokość.Text, CultureInfo.InvariantCulture);

                Random random = new Random();

                double dhlCena = ObliczLosowaCene(waga, dlugosc, szerokosc, wysokosc, random);
                double upsCena = ObliczLosowaCene(waga, dlugosc, szerokosc, wysokosc, random);
                double fedexCena = ObliczLosowaCene(waga, dlugosc, szerokosc, wysokosc, random);

                string najtanszaFirma = WyznaczNajtanszaFirme(dhlCena, upsCena, fedexCena);

                Wynik.Text = $"Cena DHL: {dhlCena:F2} PLN\n" +
                             $"Cena UPS: {upsCena:F2} PLN\n" +
                             $"Cena FedEx: {fedexCena:F2} PLN\n\n" +
                             $"Najtańsza oferta: {najtanszaFirma}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Proszę podać prawidłowe wartości.");
            }
        }

        private double ObliczLosowaCene(double waga, double dlugosc, double szerokosc, double wysokosc, Random random)
        {
            double basePrice = waga * 10 + (dlugosc + szerokosc + wysokosc) * 0.5;
            double randomFactor = random.NextDouble() * 0.2 + 0.9;
            return basePrice * randomFactor;
        }

        private string WyznaczNajtanszaFirme(double dhlCena, double upsCena, double fedexCena)
        {
            if (dhlCena <= upsCena && dhlCena <= fedexCena)
            {
                return "DHL";
            }
            else if (upsCena <= dhlCena && upsCena <= fedexCena)
            {
                return "UPS";
            }
            else
            {
                return "FedEx";
            }
        }
    }
}
