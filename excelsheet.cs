using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
namespace new_project1
{

    public class excelsheet
    {
        public void abuio(ListView listview1)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wbk = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet wsh = null;
            wsh = (_Worksheet)wbk.Sheets["sheet1"];
            wsh = (_Worksheet)wbk.ActiveSheet;

            for (int j = 1; j < listview1.Columns.Count + 1; j++)
            {
                wsh.Cells[1, j] = listview1.Columns[j - 1].Text;
            }

            for (int i = 0; i < listview1.Items.Count; i++)
            {
                int io = i;
                for (int j = 0; j < listview1.Columns.Count; j++)
                {
                    wsh.Cells[i + 2, j + 1] = listview1.Items[i].SubItems[j].Text;
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "2016|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        wbk.SaveAs(saveFileDialog.FileName, Type.Missing);
                        MessageBox.Show(" The Export is Done ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            app.Quit();
        }
    }
   

}
