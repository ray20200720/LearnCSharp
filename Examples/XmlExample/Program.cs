using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region example 1
            
            /*  
             *  https://www.cnblogs.com/liweis/p/13714648.html
             *  Load：支持xml路径、文件流、不支持XML文本；
             *  LoadXml：支持XML文本，不支持xml路径。
            */

            XmlDataDocument xmlDocument1 = new XmlDataDocument();

            //xmlDocument.LoadXml("D:\\people.xml"); //System.Xml.XmlException 在根層次的資料無效。 行 1，位置 1。 
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?><people><person><name>Ray</name><age>20</age></person><person><name>Yumiko</name><age>18</age></person></people>";
            xmlDocument1.LoadXml(xml);
            
            Console.WriteLine(xmlDocument1.InnerText);


            XmlDataDocument xmlDocument2 = new XmlDataDocument();

            xmlDocument2.Load(@"D:\\Ray\\MyProjects\\LearnCSharp\\Examples\\XmlExample\\people.xml");
            Console.WriteLine(xmlDocument2.InnerText);

            #endregion

            Console.ReadLine();

            #region example 2
            DataSet dataSet = new DataSet("MyDataSet");
            DataTable dataTable = new DataTable("MyDataTable");

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name",  typeof(string));
            dataTable.Rows.Add(1, "Ray");
            dataTable.Rows.Add(2, "Yumiko");
            dataSet.Tables.Add(dataTable);

            XmlDataDocument xmlDataDocument = new XmlDataDocument(dataSet);

            XmlElement rootElement = xmlDataDocument.DocumentElement;
            Console.WriteLine("Root element name: " + rootElement.Name);

            XmlNodeList rows = rootElement.GetElementsByTagName("MyDataTable");
            
            foreach (XmlNode row in rows)
            {
                //Console.WriteLine(row.InnerText);
                Console.WriteLine(row.SelectSingleNode("ID").InnerText);
                Console.WriteLine(row.SelectSingleNode("Name").InnerText);
            }

            dataTable.Rows[0]["Name"] = "Carol";

            xmlDataDocument.Save(Console.Out);

            Console.WriteLine();

            #endregion

            Console.ReadLine();

            #region example 3
            XmlDocument xmlDocument3 = new XmlDocument();
            XmlNode elements = xmlDocument3.CreateElement("students");

            XmlElement student1 = xmlDocument3.CreateElement("student");
            XmlAttribute attribute1 = xmlDocument3.CreateAttribute("id");
            attribute1.Value = "1";

            student1.Attributes.Append(attribute1);
            //element.SetAttribute("id", i.ToString());

            XmlElement name = xmlDocument3.CreateElement("name");
            name.InnerText = "小明";
            student1.AppendChild(name);

            XmlElement age = xmlDocument3.CreateElement("age");
            age.InnerText = "18";
            student1.AppendChild(age);

            elements.AppendChild(student1);


            XmlElement student2 = xmlDocument3.CreateElement("student");
            XmlAttribute attribute2 = xmlDocument3.CreateAttribute("id");
            attribute2.Value = "2";

            student2.Attributes.Append(attribute2);
            //element.SetAttribute("id", i.ToString());

            XmlElement name2 = xmlDocument3.CreateElement("name");
            name2.InnerText = "小紅";
            student2.AppendChild(name2);

            XmlElement age2 = xmlDocument3.CreateElement("age");
            age2.InnerText = "17";
            student2.AppendChild(age2);

            elements.AppendChild(student2);

            xmlDocument3.AppendChild(elements);

            xmlDocument3.Save(Console.Out);

            Console.ReadLine();
            #endregion
        }
    }
}
