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
            this.buttonExportData = new System.Windows.Forms.Button();
            this.CsvDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CsvDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExportData
            // 
            this.buttonExportData.Location = new System.Drawing.Point(317, 191);
            this.buttonExportData.Name = "buttonExportData";
            this.buttonExportData.Size = new System.Drawing.Size(117, 23);
            this.buttonExportData.TabIndex = 0;
            this.buttonExportData.Text = "Выгрузка в Excel";
            this.buttonExportData.UseVisualStyleBackColor = true;
            this.buttonExportData.Click += new System.EventHandler(this.buttonExportData_Click);
            // 
            // CsvDataGridView
            // 
            this.CsvDataGridView.AllowUserToAddRows = false;
            this.CsvDataGridView.AllowUserToDeleteRows = false;
            this.CsvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CsvDataGridView.Location = new System.Drawing.Point(10, 10);
            this.CsvDataGridView.Name = "CsvDataGridView";
            this.CsvDataGridView.ReadOnly = true;
            this.CsvDataGridView.Size = new System.Drawing.Size(665, 175);
            this.CsvDataGridView.TabIndex = 1;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(212, 191);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(99, 23);
            this.buttonPreview.TabIndex = 2;
            this.buttonPreview.Text = "Предпросмотр";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 221);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.CsvDataGridView);
            this.Controls.Add(this.buttonExportData);
            this.Name = "MainForm";
            this.Text = "Задание №18 выполнил: Кругликов Е.А., Номер варианта: 8 Дата выполнения: 03/11/20" +
    "24";
            ((System.ComponentModel.ISupportInitialize)(this.CsvDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonExportData;
        private DataGridView CsvDataGridView;
        private Button buttonPreview;
    }
}
