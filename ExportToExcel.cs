using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Data;
using System.Windows.Forms;

namespace QuanLyCongTrinh
{
    public static class ExportToExcel
    {
        private static String[] tittles = { "STT", "Ngày", "Vật tư", "ĐVT", "Số lượng", "Đơn giá", "Thành tiền", "Ghi chú" };
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void Export(DataGridView dt, String fileName)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i, j;
            
            for (i = 0; i < 8; i++)
                xlWorkSheet.Cells[1, i + 1] = tittles[i];

            for (i = 0; i <= dt.RowCount - 1; i++)
            {
                for (j = 0; j <= dt.ColumnCount - 1; j++)
                {
                    if (dt[j, i].Value != null)
                    {
                        if (j != 1)
                            xlWorkSheet.Cells[i + 2, j + 1] = dt[j, i].Value.ToString();
                        else
                            xlWorkSheet.Cells[i + 2, j + 1] = String.Format("{0:dd-MM-yyyy}", dt[j, i].Value);
                    }
                    else
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }

            xlWorkBook.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
        }
     
    }
}
