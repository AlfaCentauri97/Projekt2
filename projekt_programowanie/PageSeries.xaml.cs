using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projekt_programowanie
{
    /// <summary>
    /// Interaction logic for PageSeries.xaml
    /// </summary>
    public partial class PageSeries : Page
    {
        public PageSeries()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda wyswietlenia tablicy "Series"
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć tablice danych. </return>
        /// </summary>
        private void ButtonOpenSeries(object sender, RoutedEventArgs e)
        {
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            try
            {
                //Wyswietlenie tablicy "Series"
                sqlCon.Open();
                String query = "SELECT * FROM Series";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Series");
                dataAdp.Fill(dt);
                Data.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
