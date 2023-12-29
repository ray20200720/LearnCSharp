using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SQLITE_VERSION
            //string cs = "Data Source=:memory:";
            //string stm = "SELECT SQLITE_VERSION()";

            //var con = new SQLiteConnection(cs);
            //con.Open();

            //var cmd = new SQLiteCommand(stm, con);

            //string version = cmd.ExecuteScalar().ToString();
            //Console.WriteLine($"{version}");

            Execute_Sqlite_Version();
            #endregion

            #region Read DataTable: D:\Ray\MyProjects\DBeaver\EntityFramework\Demo.db
            string cs = @"Data Source=D:\Ray\MyProjects\DBeaver\EntityFramework\Demo.db";
            string stm = "SELECT * FROM Student; ";

            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(stm, con);

            SQLiteDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("ID: " + "\tFirstName: " + "\tLastName: " + "\tGender ");
            while (reader.Read())
            {
                //Console.WriteLine("ID: " + reader["ID"] + "\tFirstName: " + reader["FirstName"] + "\tLastName: " + reader["LastName"] + "\tGender: " + reader["Gender"]);
                Console.WriteLine("" + reader["ID"] + "\t" + reader["FirstName"] + "\t\t" + reader["LastName"] + "\t\t" + reader["Gender"]);
            }
            #endregion

            Console.ReadKey();
        }

        static void Execute_Sqlite_Version()
        {
            string cs = "Data Source=:memory:";
            string stm = "SELECT SQLITE_VERSION()";

            var con = new SQLiteConnection(cs);
            con.Open();

            var cmd = new SQLiteCommand(stm, con);

            string version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"{version}");
        }
    }
}
