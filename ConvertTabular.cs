using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class ConvertTabular
    {
        static void Main(string[] args)
        {
            CsvToDataTable obj = new CsvToDataTable();
            DataTable dtData = obj.ConvertCsvToDataTable(@"C:\Users\Anitha\source\repos\Assignments2\Assignments2\EmpData.csv");
            obj.ShowData(dtData);
        }

        class CsvToDataTable
        {
            public DataTable ConvertCsvToDataTable(string filePath)
            {
                //reading all the lines(rows) from the file.
                string[] rows = File.ReadAllLines(filePath);

                DataTable dtData = new DataTable();
                string[] rowValues = null;
                DataRow dr = dtData.NewRow();

                if (rows.Length > 0)
                {
                    foreach (string columnName in rows[0].Split(','))
                        dtData.Columns.Add(columnName);
                }

                for (int row = 1; row < rows.Length; row++)
                {
                    rowValues = rows[row].Split(',');
                    dr = dtData.NewRow();
                    dr.ItemArray = rowValues;
                    dtData.Rows.Add(dr);
                }

                return dtData;
            }

            public void ShowData(DataTable dtData)
            {
                if (dtData != null && dtData.Rows.Count > 0)
                {
                    foreach (DataColumn dc in dtData.Columns)
                    {
                        Console.Write(dc.ColumnName + " ");
                    }
                    Console.WriteLine("\n-----------------------------------------------");

                    foreach (DataRow dr in dtData.Rows)
                    {
                        foreach (var item in dr.ItemArray)
                        {
                            Console.Write(item.ToString() + "      ");
                        }
                        Console.Write("\n");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
