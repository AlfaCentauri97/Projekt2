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
    public partial class PageHome : Page
    {
        public PageHome()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Metoda obslugi menu chowanego
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Wysuniecie menu </return>
        /// </summary>
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            //Wysuniecie menu na widoczne
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }
        /// <summary>
        ///Metoda obslugi menu chowanego
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zasuniecie menu </return>
        /// </summary>
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            //Wysuniecie menu na niewidoczne
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }


        /// <summary>
        ///Metoda opcji wyboru
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć wybraną strone. </return>
        /// </summary>
        /// 
        private void ButtonHome_Menu(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            switch (index)
            {
                //Przemieszczanie po stronach
                case 0:
                    PageMovie page = new PageMovie();
                    NavigationService.Navigate(page);
                    break;
                case 1:
                    PageSeries page1 = new PageSeries();
                    NavigationService.Navigate(page1);
                    break;
                case 2:
                    MyBase page2 = new MyBase();
                    NavigationService.Navigate(page2);
                    break;
                case 3:
                    PageBest page3 = new PageBest();
                    NavigationService.Navigate(page3);
                    break;
                case 4:
                    PageRandom page4 = new PageRandom();
                    NavigationService.Navigate(page4);
                    break;
                case 5:
                    PageSearch page5 = new PageSearch();
                    NavigationService.Navigate(page5);
                    break;
            }
        }
    }
}
