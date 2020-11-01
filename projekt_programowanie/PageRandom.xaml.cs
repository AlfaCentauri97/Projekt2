using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
    public partial class PageRandom : Page
    {
        public PageRandom()
        {
            InitializeComponent();
        }
        /// <summary>
        ///Metoda wyswietlenia losowych rekordow wybranej tablicy
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć tablice danych.</return>
        /// </summary>
        private void Random(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            //Przemieszcza margines (czesc estetyczna) dodaje 260 do parametru umozliwiajac przesuwanie poziome 
            GridCursor.Margin = new Thickness(0 + (260 * index), 0 , 0, 0);
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            switch (index)
            {

                case 0:
                    //Wyswietlenie losowego wiersza z tablicy "Movies"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM Movies ORDER BY NEWID()";
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
                    //Wyswietlenie losowego wiersza z tablicy "Series"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM Series ORDER BY NEWID()";
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
                    //Wyswietlenie losowego wiersza z tablicy "MyBase"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM MyBase ORDER BY NEWID()";
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
