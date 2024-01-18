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
            string sql = "SELECT * FROM Student; ";
            
            using (SQLiteConnection conn = new SQLiteConnection(cs))
            {
                var students = conn.Query<Student>(sql).ToList();

                foreach (var student in students)
                {
                    Console.WriteLine("{0} {1} {2} {3}", student.ID, student.FirstName, student.LastName, student.Gender);
                }

                var firstStudent = conn.QueryFirst<Student>(sql);
                Console.WriteLine("{0} {1} {2} {3}", firstStudent.ID, firstStudent.FirstName, firstStudent.LastName, firstStudent.Gender);

                var firstOrDefaultStudent = conn.QueryFirstOrDefault<Student>(sql);
                Console.WriteLine("{0} {1} {2} {3}", firstOrDefaultStudent.ID, firstOrDefaultStudent.FirstName, firstOrDefaultStudent.LastName, firstOrDefaultStudent.Gender);

                // QuerySingle 查詢結果若為多筆,則拋錯
                sql = "SELECT * FROM Student WHERE ID = '5'; "; //此行註解則會報錯,因為查詢結果為多筆
                var singleStudent = conn.QuerySingle<Student>(sql);
                Console.WriteLine("{0} {1} {2} {3}", singleStudent.ID, singleStudent.FirstName, singleStudent.LastName, singleStudent.Gender);
            }

            Console.ReadKey();
        }
    }
}
