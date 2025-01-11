namespace Diagramms
{
    partial class SmellDiagram
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonShiftLeft = new System.Windows.Forms.Button();
            this.buttonShiftRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MyChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            legend1.Title = "Smell";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.MyChart.Legends.Add(legend1);
            this.MyChart.Location = new System.Drawing.Point(12, 12);
            this.MyChart.Name = "MyChart";
            this.MyChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "PieStartAngle=270";
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "{0:0}%";
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            this.MyChart.Series.Add(series1);
            this.MyChart.Size = new System.Drawing.Size(776, 426);
            this.MyChart.TabIndex = 0;
            this.MyChart.Text = "chart1";
            // 
            // buttonShiftLeft
            // 
            this.buttonShiftLeft.Location = new System.Drawing.Point(488, 444);
            this.buttonShiftLeft.Name = "buttonShiftLeft";
            this.buttonShiftLeft.Size = new System.Drawing.Size(147, 36);
            this.buttonShiftLeft.TabIndex = 1;
            this.buttonShiftLeft.Text = "Сдвиг влево";
            this.buttonShiftLeft.UseVisualStyleBackColor = true;
            this.buttonShiftLeft.Click += new System.EventHandler(this.buttonShiftLeft_Click);
            // 
            // buttonShiftRight
            // 
            this.buttonShiftRight.Location = new System.Drawing.Point(641, 444);
            this.buttonShiftRight.Name = "buttonShiftRight";
            this.buttonShiftRight.Size = new System.Drawing.Size(147, 36);
            this.buttonShiftRight.TabIndex = 2;
            this.buttonShiftRight.Text = "Сдвиг вправо";
            this.buttonShiftRight.UseVisualStyleBackColor = true;
            this.buttonShiftRight.Click += new System.EventHandler(this.buttonShiftRight_Click);
            // 
            // SmellDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.buttonShiftRight);
            this.Controls.Add(this.buttonShiftLeft);
            this.Controls.Add(this.MyChart);
            this.Name = "SmellDiagram";
            this.Text = "Задание №20 выполнил: Кругликов Е.А., Номер варианта: 8 Дата выполнения: 26/12/20" +
    "24";
            ((System.ComponentModel.ISupportInitialize)(this.MyChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MyChart;
        private System.Windows.Forms.Button buttonShiftLeft;
        private System.Windows.Forms.Button buttonShiftRight;
    }
}

