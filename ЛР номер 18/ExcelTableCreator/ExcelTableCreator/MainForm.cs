using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelAlphabet;
using Microsoft.Office.Interop.Excel;

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
        }

        private void buttonExportData_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = false;
            Workbook wb = app.Workbooks.Add(Missing.Value);
            Worksheet ws = (Worksheet)wb.Sheets.Add();
            ws.Activate();

            int cols = headers[0].Length;
            int rows = headers.Length;

            Range cells = ws.Range[AlphabetClass.ExcelCellTranslator(1, 1), AlphabetClass.ExcelCellTranslator(rows, cols)];
            cells.Borders.Weight = 2;

            for (int i = 1; i < 17; i++)
            {
                ws.Range[AlphabetClass.ExcelCellTranslator(1, i), AlphabetClass.ExcelCellTranslator(2, i)].Merge();
                ws.Cells[1, i] = headers[0][i - 1];
                ws.Cells[2, i] = headers[1][i - 1];
            }

            ws.Range[AlphabetClass.ExcelCellTranslator(1, 4), AlphabetClass.ExcelCellTranslator(1, 5)].UnMerge();
            ws.Range[AlphabetClass.ExcelCellTranslator(1, 11), AlphabetClass.ExcelCellTranslator(1, 12)].UnMerge();
            ws.Range[AlphabetClass.ExcelCellTranslator(1, 4), AlphabetClass.ExcelCellTranslator(1, 5)].Merge();
            ws.Range[AlphabetClass.ExcelCellTranslator(1, 11), AlphabetClass.ExcelCellTranslator(1, 12)].Merge();

            ws.Range[AlphabetClass.ExcelCellTranslator(1, 1), AlphabetClass.ExcelCellTranslator(1, 1)].RowHeight = 30f;
            ws.Range[AlphabetClass.ExcelCellTranslator(2, 1), AlphabetClass.ExcelCellTranslator(2, 1)].RowHeight = 40f;

            Range r = ws.Range[AlphabetClass.ExcelCellTranslator(1, 1), AlphabetClass.ExcelCellTranslator(2, 16)];
            r.WrapText = true;
            r.HorizontalAlignment = Constants.xlCenter;
            r.VerticalAlignment = Constants.xlCenter;
            r = ws.Range[AlphabetClass.ExcelCellTranslator(3, 1), AlphabetClass.ExcelCellTranslator(5, 16)];
            r.Borders[XlBordersIndex.xlEdgeTop].Weight = 4;
            r.Borders[XlBordersIndex.xlEdgeLeft].Weight = 4;
            r.Borders[XlBordersIndex.xlEdgeRight].Weight = 4;
            r.Borders[XlBordersIndex.xlEdgeBottom].Weight = 4;

            for (int i = 0; i < csv.Length; i++)
            {
                ws.Cells[3 + i / cols, 1 + i % cols] = csv[i];
            }

            app.UserControl = true;
            wb.SaveCopyAs(System.Windows.Forms.Application.StartupPath + Name + ".xlsx");
            wb.Close(false);
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < headers[0].Length; i++)
                CsvDataGridView.Columns.Add("Column" + i, headers[1][i] == "" ? headers[0][i] : headers[1][i]);

            for (int i = 0; i < csv.Length; i += headers[0].Length)
                CsvDataGridView.Rows.Add(csv.Skip(i).Take(i + headers[0].Length).ToArray());
        }
    }
}