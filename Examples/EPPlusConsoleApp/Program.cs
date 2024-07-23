using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPPlusConsoleApp
{
    internal class Program
    {
        // Reference: https://epplussoftware.com/zh/Developers/
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var files = new string[] { "myWorkbook.xlsx", "Workbook1.xlsx", "Workbook2.xlsx", "Workbook3.xlsx", "Workbook4.xlsx" };
            foreach(var fileName in files)
            {
                FileInfo workbook = new FileInfo(fileName);
                if (workbook.Exists)
                {
                    workbook.Delete();
                    workbook = new FileInfo(fileName);
                }
            }

            // Example 01: create myWorkbook.xlsx  
            using (var package = new ExcelPackage(@"myWorkbook.xlsx"))
            {
                var sheet = package.Workbook.Worksheets.Add("My Sheet");
                sheet.Cells["A1"].Value = "Hello World!";

                // Save to file
                package.Save();
            }

            // Example 02: create Workbook1.xlsx and AnotherWorkbook.xlsx
            using (var package = new ExcelPackage("Workbook1.xlsx"))
            {
                var sheet = package.Workbook.Worksheets.Add("Worksheet1");
                sheet.Cells["A1"].Value = 1;
                sheet.Cells["A2"].Value = 2;

                package.Save();

                package.Workbook.Worksheets["Worksheet1"].Cells["A3"].Formula = "SUM(A1:A2)";
                var newFile = new FileInfo("AnotherWorkbook.xlsx");
                var workbook = package.Workbook;
                package.SaveAs(newFile);
            }

            // Example 03
            using (var package = new ExcelPackage())
            {
                var sheet = package.Workbook.Worksheets.Add("My Sheet");

                //get the workbook as a bytearray
                var excelBytes = package.GetAsByteArray();
            }

            // Example 04
            using (var package = new ExcelPackage("Workbook2.xlsx"))
            {
                var worksheet = package.Workbook.Worksheets.Add("Worksheet1");
                worksheet.Cells["B1"].Value = "This is cell B1"; // Sets the value of Cell B1
                worksheet.Cells[1, 2].Value = "This is cell B1"; // Also sets the value of Cell B1

                // A1
                worksheet.Cells[1, 1].Value = 123;

                worksheet.Cells["A1:B3"].Style.Numberformat.Format = "#,##0"; //Sets the numberformat for a range
                worksheet.Cells[1, 1, 3, 2].Style.Numberformat.Format = "#,##0"; //Same as above,A1:B3

                worksheet.Cells["A1:B3,D1:E57"].Style.Numberformat.Format = "#,##0"; //Sets the numberformat for a range containing two addresses.
                worksheet.Cells["A:B"].Style.Font.Bold = true; //Sets font-bold to true for column A & B
                worksheet.Cells["1:1,A:A,C3"].Style.Font.Bold = true; //Sets font-bold to true for row 1,column A and cell C3
                worksheet.Cells["A:XFD"].Style.Font.Name = "Arial"; //Sets font to Arial for all cells in a worksheet.
                worksheet.Cells.Style.Font.Name = "Arial"; //This is equal to the above.

                worksheet.Cells["B1"].Style.Font.Name = "Andika";

                package.Save();
            }

            // Example 05
            var myList = new List<string>();
            myList.Add("A1");
            myList.Add("B1");
            myList.Add("C2");
            
            var myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "ABC");
            myDictionary.Add(2, "DEF");
            myDictionary.Add(3, "GHI");

            var myStringArray = new string[] { "Hello", "World" };

            using (var package = new ExcelPackage("Workbook3.xlsx"))
            {
                var sheet = package.Workbook.Worksheets.Add("Sheet1");
                sheet.Cells["A1"].LoadFromCollection(myList);
                sheet.Cells["B1"].LoadFromCollection(myList, true);
                //sheet.Cells["D1"].LoadFromCollection(myList, true, TableStyles.Medium3);
                sheet.Cells["D1"].LoadFromCollection(myDictionary, true, TableStyles.Light1);
                sheet.Cells["F1"].LoadFromCollection(myStringArray, true, TableStyles.Medium4);
                sheet.Cells["F:F"].Style.Font.Italic = true;

                package.Save();
            }

            // Example 06
            

            using (var package = new ExcelPackage())
            {
                //Get a DataTable with data that we will load into the worksheet...
                DataTable dt = GetDataTable();

                //Add a worksheet
                var sheet = package.Workbook.Worksheets.Add("FromDataTable");

                //Load the datatable into the worksheet...
                sheet.Cells["A1"].LoadFromDataTable(dt, PrintHeaders: true, TableStyles.Medium9);

                var newFile = new FileInfo("Workbook4.xlsx");
                var workbook = package.Workbook;
                package.SaveAs(newFile);
            }
        }

        static DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Dosage", typeof(int));
            dt.Columns.Add("Drug", typeof(string));
            dt.Columns.Add("Diagnosis", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            //dt.Columns.Add("Date", typeof(DateTime));

            dt.Rows.Add(25, "Drug A", "Disease A", DateTime.Now.ToString("yyyy-MM-dd"));
            dt.Rows.Add(50, "Drug Z", "Problem Z", DateTime.Now.ToString("yyyy-MM-dd"));
            dt.Rows.Add(10, "Drug Q", "Disorder Q", DateTime.Now.ToString("yyyy-MM-dd"));
            dt.Rows.Add(21, "Medicine A", "Diagnosis A", DateTime.Now.ToString("yyyy-MM-dd"));

            return dt;
        }
    }
}
