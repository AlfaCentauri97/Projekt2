using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
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
    /// <summary>
    /// Interaction logic for PageBest.xaml
    /// </summary>
    public partial class PageBest : Page
    {

        /// <summary>
        ///Metoda wyswietlenia 10 najwyzszych rekordow wybranej tablicy
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć tablice danych.</return>
        /// </summary>
        private void Button_Click_Menu_Top(object sender, RoutedEventArgs e)
        {
            //Zmienna index przypisuje wartości Uid od 0 do 2 
            int index = int.Parse(((Button)e.Source).Uid);
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            switch (index)
            {
                case 0:
                    //Wyswietlenie najwyzszych rekordow z tablicy "Movies"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM Movies ORDER BY Score DESC";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("Movies");
                        dataAdp.Fill(dt);
                        Data.ItemsSource = dt.DefaultView;
                        dataAdp.Update(dt);
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 1:
                    try
                    {
                        //Wyswietlenie najwyzszych rekordow z tablicy "Series"
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM Series ORDER BY Score DESC";
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
                    break;
                case 2:
                    try
                    {
                        //Wyswietlenie najwyzszych rekordow z tablicy "MyBase"
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM MyBase ORDER BY Score DESC";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("MyBase");
                        dataAdp.Fill(dt);
                        Data.ItemsSource = dt.DefaultView;
                        dataAdp.Update(dt);
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
    }
}
