using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTableCreator
{
    public partial class MainForm : Form
    {
        private readonly string[][] headers = new string[][]
            {
                new string[] { "Структурное подразделение", "Вид деятельности", "Склад", "Место хранения", "", "Марка", "Сорт", "Профиль", "Размер", "Номенклатурный номер", "Единица измерения", "", "Цена, руб. коп.", "Норма запаса", "Срок годности", "Поставщик" },
                new string[] { "", "", "", "стеллаж", "ячейка", "", "", "", "", "", "код", "наименование", "", "", "", "" }
            };

        private string[] csv;

        public MainForm()
        {
            InitializeComponent();
            csv = File.ReadAllText("Data.csv", System.Text.Encoding.UTF8).Split(',');

            for (int i = 0; i < headers[0].Length; i++)
                CsvDataGridView.Columns.Add("Column" + i, headers[1][i] == "" ? headers[0][i] : headers[1][i]);

            for (int i = 0; i < csv.Length; i += headers[0].Length)
                CsvDataGridView.Rows.Add(csv.Skip(i).Take(i + headers[0].Length).ToArray());
        }

        private void buttonExportData_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = false;
            Excel.Workbook wb = app.Workbooks.Add(Missing.Value);
            Excel.Worksheet ws = (Worksheet)wb.Sheets.Add();
            ws.Activate();

            for (int i = 0; i < 16; i++)
            {
                ws.Range[((char)('A' + i)) + "1", ((char)('A' + i)) + "2"].Merge();
            }

            ws.Range["D1", "E1"].UnMerge();
            ws.Range["K1", "L1"].UnMerge();
            ws.Range["D1", "E1"].Merge();
            ws.Range["K1", "L1"].Merge();

            for (int i = 0; i < 16; i++)
            {
                ws.Cells[1, i + 1] = headers[0][i];
                ws.Cells[2, i + 1] = headers[1][i];
            }

            ws.Range["A1", "A1"].RowHeight = 30f;
            ws.Range["A2", "A2"].RowHeight = 40f;

            Excel.Range r = ws.Range["A1", "P2"];
            r.WrapText = true;
            r.HorizontalAlignment = Excel.Constants.xlCenter;
            r.VerticalAlignment = Excel.Constants.xlCenter;
            r = ws.Range["A3", "P5"];
            r.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = 4;
            r.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = 4;
            r.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = 4;
            r.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = 4;

            for (int i = 0; i < csv.Length; i++)
            {
                ws.Cells[3 + i / 16, 1 + i % 16] = csv[i];
            }

            app.UserControl = true;
            wb.SaveCopyAs(System.Windows.Forms.Application.StartupPath + Name + ".xlsx");
            wb.Close(false);
        }
    }
}