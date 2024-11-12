using System.Drawing;
using System.Windows.Forms;

namespace ExcelTableCreator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonExportData = new Button();
            CsvDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CsvDataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonExportData
            // 
            buttonExportData.Location = new Point(342, 220);
            buttonExportData.Name = "buttonExportData";
            buttonExportData.Size = new Size(116, 23);
            buttonExportData.TabIndex = 0;
            buttonExportData.Text = "Выгрузка в Excel";
            buttonExportData.UseVisualStyleBackColor = true;
            buttonExportData.Click += buttonExportData_Click;
            // 
            // CsvDataGridView
            // 
            CsvDataGridView.AllowUserToAddRows = false;
            CsvDataGridView.AllowUserToDeleteRows = false;
            CsvDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CsvDataGridView.Location = new Point(12, 12);
            CsvDataGridView.Name = "CsvDataGridView";
            CsvDataGridView.ReadOnly = true;
            CsvDataGridView.Size = new Size(776, 202);
            CsvDataGridView.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 255);
            Controls.Add(CsvDataGridView);
            Controls.Add(buttonExportData);
            Name = "MainForm";
            Text = "Задание №18 выполнил: Кругликов Е.А., Номер варианта: 8 Дата выполнения: 03/11/2024";
            ((System.ComponentModel.ISupportInitialize)CsvDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonExportData;
        private DataGridView CsvDataGridView;
    }
}
