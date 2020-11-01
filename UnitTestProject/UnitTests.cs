using System;
using System.Data;
using System.Data.SqlClient;
using NUnit.Framework;
using projekt_programowanie;

namespace UnitTestProject
{
    
    [TestFixture]
    public class UnitTests
    {
        [TestCase, Category("Base")]
        public void CheckDatabaseExist()
        {
            Assert.IsTrue(PageMovie.CheckDatabaseExists(null, "Projekt"));
        }

        [TestCase, Category("Base")]
        public void ConnectionDatabaseTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                conn.Open();
                conn.Close();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }

            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Best")]
        public void TopMoviesTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT TOP 10 * FROM Movies ORDER BY Score DESC", conn);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                res = count > 0 && count <= 10;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Best")]
        public void TopSeriesTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT TOP 10 * FROM Series ORDER BY Score DESC", conn);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                res = count > 0 && count <= 10;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Best")]
        public void TopMyBaseTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT TOP 10 * FROM MyBase ORDER BY Score DESC", conn);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                res = count > 0 && count <= 10;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Movie")]
        public void ShowMoviesTableTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Movies", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Movies");
                res = dt.Rows.Count > 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Random")]
        public void RandomMovieSelectionTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT TOP 1 & FROM Movies ORDER BY NEWID()", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Movies");
                res = dt.Rows.Count > 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Random")]
        public void RandomSeriesSelectionTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT TOP 1 & FROM Series ORDER BY NEWID()", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Series");
                res = dt.Rows.Count > 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Random")]
        public void RandomMyBaseSelectionTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT TOP 1 & FROM MyBase ORDER BY NEWID()", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("MyBase");
                res = dt.Rows.Count > 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Search")]
        public void SearchMovieTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Movies WHERE Name ='World of Warcraft'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Movies");
                res = dt.Rows.Count > 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Search")]
        public void SearchSeriesTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Series WHERE Name ='Lucyfer'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Series");
                res = dt.Rows.Count > 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Search")]
        public void SearchMyBaseTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM MyBase WHERE Name ='High School DxD'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("MyBase");
                res = dt.Rows.Count > 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }

        [TestCase, Category("Page Series")]
        public void GetAllFromSeriesTest()
        {
            bool res;
            try
            {
                SqlConnection conn = new SqlConnection(Globals.ConnString);
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM Series", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Series");
                res = dt.Rows.Count > 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }
    }
}
