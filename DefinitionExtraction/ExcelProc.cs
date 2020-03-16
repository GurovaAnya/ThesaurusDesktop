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
    static class ExcelProc
    {
        public static int ExcelP(string filePath)
        {
            //var app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = 
            //    app.Workbooks.Open(@"d:\kursy\C#\Spiski\Spisok.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл

            //app.Visible = true;
            //var arrData = (object[,])xlSht.Range["A1:Z" + iLastRow].Value;

            //var wb = app.Workbooks.Add();
            //var ws = wb.Worksheets[1] as Worksheet;
            //ws.Cells[1, 1].Value = 567;
            //wb.SaveAs("fevewrvev.xlsx");
            //app.Quit();

            Microsoft.Office.Interop.Excel.Application ObjWorkExcel = new Microsoft.Office.Interop.Excel.Application(); //открыть эксель
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист


            int iLastRow = ObjWorkSheet.Cells[ObjWorkSheet.Rows.Count, "A"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row;  //последняя заполненная строка в столбце А
            var arrData = (object[,])ObjWorkSheet.Range["A2:M" + iLastRow].Value;

            ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
            ObjWorkExcel.Quit(); // выйти из экселя
            GC.Collect(); // убрать за собой -- в том числе не используемые явно объекты !
            return AddData(arrData);
        }

        private static int AddData(object [,] info)
        {
            int count = 0;
            try
            {
                for (int i = 1; i <= info.GetLength(0); i++)
                {
                    //Termin termin = new Termin(info[i, 0].ToString(), info[i, 1].ToString(),
                    //    (int)info[i, 3], (int)info[i, 4], (int)info[i, 5], (int)info[i, 6]);
                    if (info[i, 2] == null)
                        info[i, 2] = string.Empty;
                    string[] ascriptors = info[i, 8].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    bool b = info[i, 4] is double;
                    double[] ints = new double[] { (double)info[i, 4], (double)info[i, 5],(double)info[i, 6],(double)info[i, 7],
                        (double)info[i, 10], (double)info[i, 11], (double)info[i, 12], (double)info[i, 13],};
                    using (DB db = new DB())
                    {
                        ReturnState rs = db.AddDescriptor(info[i, 1].ToString(),
                        (int)ints[0], (int)ints[1], (int)ints[2], (int)ints[3],
                        info[i, 9].ToString(),
                        (int)ints[4], (int)ints[5], (int)ints[6], (int)ints[7], ascriptors,
                        info[i, 2].ToString());
                        if (rs==ReturnState.Success)
                            count++;
                    }
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
