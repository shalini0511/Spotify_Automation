/*summary :DB Automation for Insert and select query
  Author: V SHALINI
  Date  : 20-08-21
*/


using System;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spotify_DB_Automation
{
    [TestClass]
    public class InsertQuery
    {
        SqlConnection conn = new SqlConnection();
        [TestMethod]
        public void RetrieveDataFromDatabase()
        {
            conn.ConnectionString = @"server=DESKTOP-TKJCNNQ;Database=Spotify_Automation;Trusted_Connection=True";
            string query = @"select * FROM Spotify";
            SqlCommand selectCommand = new SqlCommand(query, conn);
            SqlDataReader reader;
            conn.Open();
            reader = selectCommand.ExecuteReader();
            Assert.AreEqual(1, reader.VisibleFieldCount);
           



        }
        [TestMethod]
        public void TestMethod1()
        {
           

            conn.ConnectionString = @"server=DESKTOP-TKJCNNQ;Database=Spotify_Automation;Trusted_Connection=True";
            conn.Open();

            SqlCommand insertCommand3 = new SqlCommand("INSERT INTO Spotify(userName,Playlist,Tracks)VALUES(@0,@1,@2)", conn);
            insertCommand3.Parameters.Add(new SqlParameter("0", "ram"));
            insertCommand3.Parameters.Add(new SqlParameter("1", "Melody"));
            insertCommand3.Parameters.Add(new SqlParameter("2", "Secrete"));
           


            int rows = insertCommand3.ExecuteNonQuery();
            Assert.AreEqual(1, rows);
        }
    }
}
