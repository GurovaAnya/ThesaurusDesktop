using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Data;

namespace DefinitionExtraction
{
    static class MSImport
    {
        public static int ExcelRead(string filePath)
        {
            Microsoft.Office.Interop.Excel.Application ObjWorkExcel = new Microsoft.Office.Interop.Excel.Application(); //открыть эксель
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист


            int iLastRow = ObjWorkSheet.Cells[ObjWorkSheet.Rows.Count, "A"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row; 
            var arrData = (object[,])ObjWorkSheet.Range["A2:M" + iLastRow].Value;

            ObjWorkBook.Close(false, Type.Missing, Type.Missing); 
            ObjWorkExcel.Quit();
            GC.Collect();
            return AddData(arrData);
        }

        private static int AddData(object [,] info)
        {
            int count = 0;
            try
            {
                for (int i = 1; i <= info.GetLength(0); i++)
                {
                    if (info[i, 2] == null)
                        info[i, 2] = string.Empty;
                    string[] ascriptors = info[i, 8].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    bool b = info[i, 4] is double;
                    double[] ints = new double[] { (double)info[i, 4], (double)info[i, 5],(double)info[i, 6],(double)info[i, 7],
                        (double)info[i, 10], (double)info[i, 11], (double)info[i, 12], (double)info[i, 13],};
                    DBQueries db = new DBQueries();
                    ReturnState rs = db.AddDescriptor(info[i, 1].ToString(),
                    (int)ints[0], (int)ints[1], (int)ints[2], (int)ints[3],
                    info[i, 9].ToString(),
                    (int)ints[4], (int)ints[5], (int)ints[6], (int)ints[7], ascriptors,
                    info[i, 2].ToString());
                    if (rs==ReturnState.Success)
                        count++;
                }
            }
            catch (NullReferenceException)
            {

            }
            return count;
        }

        public static void LoadReport()
        {

        }
    }
}
