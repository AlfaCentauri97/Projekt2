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

namespace projekt_programowanie
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Interakcja z przyciskami menu
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć wybraną strone. </return>
        /// </summary>
        private void Button_ClickMenu(object sender, RoutedEventArgs e)
        {
            //Zmienna index przypisuje wartości Uid od 0 do 5 
            int index = int.Parse(((Button)e.Source).Uid);
            //Przemieszcza margines (czesc estetyczna) dodaje 160 do parametru umozliwiajac przesuwanie poziome 
            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);
            //Tworzy nowa strone dla frame "Main"
            switch (index)
            {
                case 0:
                    Main.Content = new PageHome();
                    break;
                case 1:
                    Main.Content = new PageMovie();
                    break;
                case 2:
                    Main.Content = new PageSeries();
                    break;
                case 3:
                    Main.Content = new MyBase();
                    break;
                case 4:
                    Main.Content = new PageBest();
                    break;
                case 5:
                    Main.Content = new PageRandom();
                    break;
            }
        }
        /// <summary>
        /// Metoda wylaczenia programu
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zamkniecie programu. </return>
        /// </summary>
        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Metoda sluzaca do przekierowania na strone internetowa
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć strone internetowa. </return>
        /// </summary>
        private void ButtonOpenWebSearch1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://filmweb.pl");
        }
        /// <summary>
        /// Metoda do zmiany strony
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć strone "Search". </return>
        /// </summary>
        private void ButtonOpenBaseSearch1(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageSearch();
        }
    }
}
