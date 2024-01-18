using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"Data Source=.\Demo.db";
            string sql = "SELECT * FROM Student";

            //QueryAllFromStudent(cs, sql);

            //QueryFirstFromStudent(cs, sql);

            //QueryFirstOrDefaultFromStudent(cs, sql);

            QuerySingleFromStudent(cs, sql, 3);

            Console.ReadKey();
        }

        static void QueryAllFromStudent(string connectionString, string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                var students = conn.Query<Student>(sql).ToList();

                foreach (var student in students)
                {
                    Console.WriteLine("{0} {1} {2} {3}", student.ID, student.FirstName, student.LastName, student.Gender);
                }
            }
        }
        static void QueryFirstFromStudent(string connectionString, string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                var firstStudent = conn.QueryFirst<Student>(sql);
                Console.WriteLine("{0} {1} {2} {3}", firstStudent.ID, firstStudent.FirstName, firstStudent.LastName, firstStudent.Gender);
            }
        }
        static void QueryFirstOrDefaultFromStudent(string connectionString, string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                var firstOrDefaultStudent = conn.QueryFirstOrDefault<Student>(sql);
                Console.WriteLine("{0} {1} {2} {3}", firstOrDefaultStudent.ID, firstOrDefaultStudent.FirstName, firstOrDefaultStudent.LastName, firstOrDefaultStudent.Gender);
            }
        }
        static void QuerySingleFromStudent(string connectionString, string sql, int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                // QuerySingle 查詢結果若為多筆,則拋錯
                sql = string.Format("{0} WHERE ID = '{1}';", sql, id); 
                var singleStudent = conn.QuerySingle<Student>(sql);
                Console.WriteLine("{0} {1} {2} {3}", singleStudent.ID, singleStudent.FirstName, singleStudent.LastName, singleStudent.Gender);
            }
        }
    }
}
