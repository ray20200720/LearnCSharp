using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableExample
{
    internal class Program
    {
        /*  Reference:
            https://www.dotnetperls.com/datatable
            https://www.dotnetperls.com/datatable-select
        */

        static void Main(string[] args)
        {
            DataTable table = GetTable();
            Console.WriteLine("Dosage\tDrug\tDiagnosis\tDate");

            for(var i=0; i < table.Rows.Count; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", table.Rows[i]["Dosage"], table.Rows[i][1], table.Rows[i][2], table.Rows[i][3]);
            }

            Console.WriteLine("============================================================");

            DataTable table2 = GetDataTable();

            for (var i = 0; i < table2.Rows.Count; i++)
            {
                Console.WriteLine("{0}\t{1}", table2.Rows[i]["ID"], table2.Rows[i]["Date"]);
            }

            Example03();

            Console.ReadKey();
        }

        // Creating a Simple DataTable
        static DataTable GetTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Diagnosis", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            table.Rows.Add(25, "Drug A", "Disease A", DateTime.Now);
            table.Rows.Add(50, "Drug Z", "Problem Z", DateTime.Now);
            table.Rows.Add(10, "Drug Q", "Disorder Q", DateTime.Now);
            table.Rows.Add(21, "Medicine A", "Diagnosis A", DateTime.Now);

            return table;
        }

        // Creating another DataTable
        static DataTable GetDataTable()
        {
            DataTable table = new DataTable("Widgets");
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("Date", typeof(DateTime)));

            table.Rows.Add(100, new DateTime(2001, 1, 1));
            table.Rows.Add(200, new DateTime(2002, 1, 1));
            table.Rows.Add(300, new DateTime(2003, 1, 1));

            return table;
        }

        static void Example03()
        {
            DataTable table3 = new DataTable("Players");
            table3.Columns.Add(new DataColumn("Size", typeof(int)));
            table3.Columns.Add(new DataColumn("Team", typeof(char)));

            table3.Rows.Add(100, 'a');
            table3.Rows.Add(235, 'a');
            table3.Rows.Add(250, 'b');
            table3.Rows.Add(310, 'b');
            table3.Rows.Add(150, 'b');

            // Search for players above a certain size.
            // ... Require certain team.
            DataRow[] result = table3.Select("Size >= 230 AND Team = 'b'");
            foreach (DataRow row in result)
            {
                Console.WriteLine("{0}, {1}", row[0], row[1]);
            }
        }
    }
}
