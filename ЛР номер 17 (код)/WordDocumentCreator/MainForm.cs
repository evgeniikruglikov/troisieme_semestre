using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WordDocumentCreator
{
    public partial class MainForm : Form
    {
        public string Author => "Кругликов Е.А.";
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateTitle_Click(object sender, EventArgs e)
        {
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add();
            Word.Paragraph oPr = oDoc.Paragraphs.Add();

            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Министерство транспорта Российской Федерации";
            oPr.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oPr.Range.Text += "Федеральное государственное автономное образовательное" +
                "\nучреждение высшего образования" +
                "\n«Российский университет транспорта»" +
                "\n(ФГАОУ ВО РУТ(МИИТ), РУТ (МИИТ)" +
                "\n\nИнститут транспортной техники и систем управления" +
                "\n\nКафедра «Управление и защита информации»" +
                "\n\n\n\n";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 28;
            oPr.Range.Text = (comboBoxDocType.SelectedIndex >= 0 ? comboBoxDocType.Text : comboBoxWorkType.Text) + " №" + comboBoxWorkNumber.Text;

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = $"по дисциплине: «{textBoxDisciplineName.Text}»";
            oPr.Range.Text += $"на тему: «{textBoxWorkTheme.Text}»" +
                $"\n{textBoxWorkName.Text}" +
                $"\n\n\n\n";

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Выполнил: ст. гр. ТУУ-211";
            oPr.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

            oPr.Range.Text += "\n" + Author;
            if (comboBoxAuthorFont.SelectedIndex == 1)
                oPr.Range.Bold = 1;
            if (comboBoxAuthorFont.SelectedIndex == 2)
                oPr.Range.Italic = 1;
            if (comboBoxAuthorFont.SelectedIndex == 3)
                oPr.Range.Underline = Word.WdUnderline.wdUnderlineSingle;
            oPr.Range.Text += "\nВариант №8";
            oPr.Range.Bold = 0;
            oPr.Range.Italic = 0;
            oPr.Range.Underline = Word.WdUnderline.wdUnderlineNone;
            oPr.Range.Text += $"Проверил: {textBoxRevisor.Text}";
            if (comboBoxRevisorFont.SelectedIndex == 1)
                oPr.Range.Bold = 1;
            if (comboBoxRevisorFont.SelectedIndex == 2)
                oPr.Range.Italic = 1;
            if (comboBoxRevisorFont.SelectedIndex == 3)
                oPr.Range.Underline = Word.WdUnderline.wdUnderlineSingle;
            oPr.Range.Text += "\n\n";
            oPr.Range.Bold = 0;
            oPr.Range.Italic = 0;
            oPr.Range.Underline = Word.WdUnderline.wdUnderlineNone;

            oPr.Range.InsertParagraphAfter();
            oPr.Range.Font.Name = "Times new roman";
            oPr.Range.Font.Size = 14;
            oPr.Range.Text = "Москва – 2024 г.";
            oPr.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            oDoc.SaveAs2(Application.StartupPath + "\\Титульный лист.docx");
            oWord.Quit();
        }

        private void buttonCreateDoc_Click(object sender, EventArgs e)
        {
            Word.Application oWord = new Word.Application();
            Word.Document oDoc = oWord.Documents.Add();
            Word.Paragraph oPr = oDoc.Paragraphs.Add();

            oWord.Visible = true;

            var oTab = oDoc.Tables.Add(oPr.Range, 2, 2);
            oTab.Borders.Enable = 1;
            oTab.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth225pt;
            oTab.Borders.InsideLineWidth = Word.WdLineWidth.wdLineWidth225pt;
            oTab.Columns[1].Width = 120;
            oTab.Columns[2].Width = 380;

            for(int i = 0; i < 2; i++)
            {
                Word.Cell cell = oTab.Cell(i + 1, 2);
                cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                Word.Table tab = cell.Tables.Add(cell.Range, 1, 2);
                tab.Columns[1].Width = 200;
                for(int j = 0; j < 14; j++)
                    tab.Rows.Add();

                tab.Cell(1, 1).Merge(tab.Cell(1, 2));
                tab.Cell(1, 1).Range.Text = "ООО «БТИ - сервис»";
                tab.Cell(1, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(1, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                tab.Cell(2, 1).Merge(tab.Cell(2, 2));
                tab.Cell(2, 1).Range.Text = "Наименование получателя платежа";
                tab.Cell(2, 1).Range.Font.Size = 8;
                tab.Cell(2, 1).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(3, 1).Range.Text = "5404518728";
                tab.Cell(3, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                tab.Cell(3, 1).Range.Font.Size = 11;
                tab.Cell(3, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(3, 2).Range.Text = "40702810700800764000";
                tab.Cell(3, 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                tab.Cell(3, 2).Range.Font.Size = 11;
                tab.Cell(3, 2).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(4, 1).Range.Text = "(ИНН получателя платежа)";
                tab.Cell(4, 1).Range.Font.Size = 8;
                tab.Cell(4, 1).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(4, 2).Range.Text = "(номер счета получателя платежа)";
                tab.Cell(4, 2).Range.Font.Size = 8;
                tab.Cell(4, 2).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(5, 1).Range.Text = "Филиал «Новосибирск» КБ «ЛОКО-банк» (ЗАО)";
                tab.Cell(5, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                tab.Cell(5, 1).Range.Font.Size = 9;
                tab.Cell(5, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(5, 2).Range.Text = "БИК:                   045003855";
                tab.Cell(5, 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
                tab.Cell(5, 2).Range.Font.Size = 11;
                tab.Cell(5, 2).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(5, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(6, 1).Range.Text = "(наименование банка получателя платежа)";
                tab.Cell(6, 1).Range.Font.Size = 8;
                tab.Cell(6, 1).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(7, 1).Range.Text = "Номер корр./сч. банка получателя платежа:";
                tab.Cell(7, 1).Range.Font.Size = 8;
                tab.Cell(7, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(7, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(7, 2).Range.Text = "30101810550030000855";
                tab.Cell(7, 2).Range.Font.Size = 11;
                tab.Cell(7, 2).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(8, 1).Range.Text = "Кадастровые работы";
                tab.Cell(8, 1).Range.Font.Size = 11;
                tab.Cell(8, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(8, 2).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(9, 1).Range.Text = "(наименование платежа)";
                tab.Cell(9, 1).Range.Font.Size = 8;
                tab.Cell(9, 1).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(9, 2).Range.Text = "(номер лицевого счета (код) плательщика)";
                tab.Cell(9, 2).Range.Font.Size = 8;
                tab.Cell(9, 2).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(10, 1).Range.Text = "Ф.И.О. плательщика";
                tab.Cell(10, 1).Range.Font.Size = 10;
                tab.Cell(10, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(10, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(11, 1).Range.Text = "Адрес";
                tab.Cell(11, 1).Range.Font.Size = 10;
                tab.Cell(11, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(11, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(12, 1).Range.Text = "Сумма платежа________руб.____00____коп.";
                tab.Cell(12, 1).Range.Font.Size = 9;
                tab.Cell(12, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(12, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(12, 2).Range.Text = "Сумма платы за услуги_____руб._____коп.";
                tab.Cell(12, 2).Range.Font.Size = 9;
                tab.Cell(12, 2).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(12, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(13, 1).Range.Text = "Итого______________руб._____коп.";
                tab.Cell(13, 1).Range.Font.Size = 10;
                tab.Cell(13, 1).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(13, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(13, 2).Range.Text = "\"__\"_____________20___г.";
                tab.Cell(13, 2).Range.Font.Size = 10;
                tab.Cell(13, 2).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(13, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(14, 1).Merge(tab.Cell(14, 2));
                tab.Cell(14, 1).Range.Text = "С условиями приема указанной в платежном документе суммы, в т.ч. с суммой взимаемой платы за услуги банка,";
                tab.Cell(14, 1).Range.Font.Size = 7;
                tab.Cell(14, 1).Range.Paragraphs.SpaceAfter = 8;
                tab.Cell(14, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(15, 1).Range.Text = "ознакомлен и согласен.";
                tab.Cell(15, 1).Range.Font.Size = 8;
                tab.Cell(15, 1).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(15, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                tab.Cell(15, 2).Range.Text = "Подпись плательщика: ";
                tab.Cell(15, 2).Range.Font.Size = 8;
                tab.Cell(15, 2).Range.Paragraphs.SpaceAfter = 0;
                tab.Cell(15, 2).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            }

            for(int i = 0; i < 2; i++)
            {
                Word.Cell cell = oTab.Cell(i + 1, 1);
                cell.Range.Font.Bold = 1;
                cell.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                Word.Table tab = cell.Tables.Add(cell.Range, 1, 1);
                tab.Cell(1, 1).Range.Text = "\nИзвещение\n\n\n\n\n\n\n\n";
                tab.Cell(0, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
                tab.Rows.Add();
                tab.Cell(2, 1).Range.Text = "Кассир";
                tab.Cell(2, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;
            }

            oDoc.SaveAs2(Application.StartupPath + "\\Новый документ.docx");
            oWord.Quit();
        }
    }
}