using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projekt_programowanie
{
    /// <summary>
    /// Interaction logic for PageSearch.xaml
    /// </summary>
    public partial class PageSearch : Page
    {
        public PageSearch()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Metoda wyswietlenia szukanych elementow w tablicy "Movies"
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć tablice danych. </return>
        /// </summary>
        private void Button_Click_Search_Movie(object sender, RoutedEventArgs e)
        {
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            try
            {
                sqlCon.Open();
                String query = "SELECT * FROM Movies WHERE Name='" + this.txtName.Text + "'";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Movies");
                dataAdp.Fill(dt);
                Data.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        ///Metoda wyswietlenia szukanych elementow w tablicy "Series"
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć tablice danych. </return>
        /// </summary>
        private void Button_Click_Search_Series(object sender, RoutedEventArgs e)
        {
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            try
            {
                sqlCon.Open();
                String query = "SELECT * FROM Series WHERE Name='" + this.txtName.Text + "'";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Series");
                dataAdp.Fill(dt);
                Data.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        ///Metoda wyswietlenia szukanych elementow w tablicy "MyBase"
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć tablice danych. </return>
        /// </summary>
        private void Button_Click_Search_Base(object sender, RoutedEventArgs e)
        {
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            try
            {
                sqlCon.Open();
                String query = "SELECT * FROM MyBase WHERE Name='" + this.txtName.Text + "'";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("MyBase");
                dataAdp.Fill(dt);
                Data.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
