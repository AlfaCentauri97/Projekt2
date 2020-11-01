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
    public partial class MyBase : Page
    {
        public MyBase()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda polaczenia z baza danych oraz wyswietleniem
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Zwróć tablice danych. </return>
        /// </summary>
        private void Button_Click_Open_Base1(object sender, RoutedEventArgs e)
        {
            //Szukanie danych
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            try
            {
                //Wpisanie polecenia w SQL do zarzadzania danymi (Wyswietlenie wszystkich danych "MyBase")
                sqlCon.Open();
                String query = "SELECT * FROM MyBase";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("MyBase");
                dataAdp.Fill(dt);
                                //Wyswietlenie tablicy
                Data.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Metoda aktualizacji tablicy
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Aktualiacja oraz wyswietlenie tablicy danych. </return>
        /// </summary>
        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
                SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
                try
                {
                //Wpisanie polecenia w SQL do zarzadzania danymi (Zmiana danych nazwa,czas,ocena dla id w tablicy "MyBase")
                    sqlCon.Open();
                    String query = "UPDATE  MyBase set Name='" + this.txtName.Text + "',Time='"+ this.txtTime.Text + "',Score='" + this.txtScore.Text + "' WHERE ID='" + this.txtID.Text + "' ";
                    SqlCommand createCommand = new SqlCommand(query, sqlCon);
                    createCommand.ExecuteNonQuery();
                //Powiadomienie o udanej aktualizacji
                    MessageBox.Show("Updated.");
                    sqlCon.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            try
            {
                //Wyświetlenie ponownie bazy w celu zaaktualizowania widoku tablicy
                sqlCon.Open();
                String query = "SELECT * FROM MyBase";
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



        /// <summary>
        /// Metoda dodawanie elementow do tablicy
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Dodanie oraz wyswietlenie tablicy danych. </return>
        /// </summary>
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            //Wpisanie polecenia w SQL do zarzadzania danymi (Dodanie danych nazwa,czas,ocena,id w tablicy "MyBase")
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            try
            {
                sqlCon.Open();
                String query = "INSERT INTO MyBase (ID,Name,Score,Time) values('" + this.txtID.Text + "','" + this.txtName.Text + "','" + this.txtScore.Text + "','" + this.txtTime.Text + "')";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                MessageBox.Show("Saved.");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //Wyświetlenie ponownie bazy w celu zaaktualizowania widoku tablicy
                sqlCon.Open();
                String query = "SELECT * FROM MyBase";
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
        /// <summary>
        /// Metoda usuwanie elementow z tablicy
        /// <param name="sender">kontrolka dla ktorej jest wykonywana akcja </param>
        /// <param name="r">argumenty który implementator tego zdarzenia może uznać za przydatny</param>
        /// <return> Usuniecie oraz wyswietlenie tablicy danych. </return>
        /// </summary>
        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Globals.ConnString);
            try
            {
                //Wpisanie polecenia w SQL do zarzadzania danymi (Usuniecie danych dla ID w tablicy "MyBase")
                sqlCon.Open();
                String query = "DELETE FROM MyBase WHERE ID='" + this.txtID.Text + "'";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted.");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //Wyświetlenie ponownie bazy w celu zaaktualizowania widoku tablicy
                sqlCon.Open();
                String query = "SELECT * FROM MyBase";
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
