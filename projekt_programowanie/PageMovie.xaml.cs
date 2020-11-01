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

    public partial class PageMovie : Page
    {
        public PageMovie()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda wyswietlenia tablicy "Movies"
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć tablice danych. </return>
        /// </summary>
        private void ButtonStartHome_Click(object sender, RoutedEventArgs e)
        {
            //Polaczenie z baza danych
            bool check = CheckDatabaseExists(null, "Projekt");
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            try
            {
                //Wyswietlenie tablicy "Movies"
                sqlCon.Open();
                String query = "SELECT * FROM Movies";
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
        }
        public static bool CheckDatabaseExists(SqlConnection tmpConn, string databaseName)
        {
            string sqlCreateDBQuery;
            bool result = false;

            try
            {
                tmpConn = new SqlConnection(Globals.ConnString);

                sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);

                using (tmpConn)
                {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                    {
                        tmpConn.Open();

                        object resultObj = sqlCmd.ExecuteScalar();

                        int databaseID = 0;

                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }

                        tmpConn.Close();

                        result = (databaseID > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
