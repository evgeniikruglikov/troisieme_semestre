namespace WordDocumentCreator
{
    partial class MainForm
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
            this.textBoxRevisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkType = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkNumber = new System.Windows.Forms.ComboBox();
            this.textBoxWorkName = new System.Windows.Forms.TextBox();
            this.textBoxWorkTheme = new System.Windows.Forms.TextBox();
            this.textBoxDisciplineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxRevisorFont = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthorFont = new System.Windows.Forms.ComboBox();
            this.buttonCreateTitle = new System.Windows.Forms.Button();
            this.buttonCreateDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRevisor
            // 
            this.textBoxRevisor.Location = new System.Drawing.Point(15, 25);
            this.textBoxRevisor.Name = "textBoxRevisor";
            this.textBoxRevisor.Size = new System.Drawing.Size(185, 20);
            this.textBoxRevisor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Проверяющее лицо:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вид отчетного документа:";
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Items.AddRange(new object[] {
            "отчёт",
            "реферат",
            "эссе",
            "курсовой проект",
            "курсовая работа",
            "доклад",
            "домашнее задание"});
            this.comboBoxDocType.Location = new System.Drawing.Point(15, 78);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(185, 21);
            this.comboBoxDocType.TabIndex = 3;
            // 
            // comboBoxWorkType
            // 
            this.comboBoxWorkType.FormattingEnabled = true;
            this.comboBoxWorkType.Items.AddRange(new object[] {
            "лабораторная работа",
            "практическая работа",
            "индивидуальное задание",
            "учебная практика",
            "производственная практика",
            "преддипломная практика"});
            this.comboBoxWorkType.Location = new System.Drawing.Point(217, 78);
            this.comboBoxWorkType.Name = "comboBoxWorkType";
            this.comboBoxWorkType.Size = new System.Drawing.Size(185, 21);
            this.comboBoxWorkType.TabIndex = 4;
            // 
            // comboBoxWorkNumber
            // 
            this.comboBoxWorkNumber.FormattingEnabled = true;
            this.comboBoxWorkNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxWorkNumber.Location = new System.Drawing.Point(426, 78);
            this.comboBoxWorkNumber.Name = "comboBoxWorkNumber";
            this.comboBoxWorkNumber.Size = new System.Drawing.Size(98, 21);
            this.comboBoxWorkNumber.TabIndex = 5;
            // 
            // textBoxWorkName
            // 
            this.textBoxWorkName.Location = new System.Drawing.Point(15, 139);
            this.textBoxWorkName.Name = "textBoxWorkName";
            this.textBoxWorkName.Size = new System.Drawing.Size(387, 20);
            this.textBoxWorkName.TabIndex = 6;
            // 
            // textBoxWorkTheme
            // 
            this.textBoxWorkTheme.Location = new System.Drawing.Point(15, 196);
            this.textBoxWorkTheme.Name = "textBoxWorkTheme";
            this.textBoxWorkTheme.Size = new System.Drawing.Size(387, 20);
            this.textBoxWorkTheme.TabIndex = 7;
            // 
            // textBoxDisciplineName
            // 
            this.textBoxDisciplineName.Location = new System.Drawing.Point(15, 255);
            this.textBoxDisciplineName.Name = "textBoxDisciplineName";
            this.textBoxDisciplineName.Size = new System.Drawing.Size(387, 20);
            this.textBoxDisciplineName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вид работы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Номер работы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Наименование работы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Тема работы:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Наименование дисциплины:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Шрифт проверяющего лица:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(638, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Шрифт автора:";
            // 
            // comboBoxRevisorFont
            // 
            this.comboBoxRevisorFont.FormattingEnabled = true;
            this.comboBoxRevisorFont.Items.AddRange(new object[] {
            "обычный",
            "полужирный",
            "курсив",
            "подчеркивание"});
            this.comboBoxRevisorFont.Location = new System.Drawing.Point(641, 25);
            this.comboBoxRevisorFont.Name = "comboBoxRevisorFont";
            this.comboBoxRevisorFont.Size = new System.Drawing.Size(147, 21);
            this.comboBoxRevisorFont.TabIndex = 16;
            // 
            // comboBoxAuthorFont
            // 
            this.comboBoxAuthorFont.FormattingEnabled = true;
            this.comboBoxAuthorFont.Items.AddRange(new object[] {
            "обычный",
            "полужирный",
            "курсив",
            "подчеркивание"});
            this.comboBoxAuthorFont.Location = new System.Drawing.Point(641, 78);
            this.comboBoxAuthorFont.Name = "comboBoxAuthorFont";
            this.comboBoxAuthorFont.Size = new System.Drawing.Size(147, 21);
            this.comboBoxAuthorFont.TabIndex = 17;
            // 
            // buttonCreateTitle
            // 
            this.buttonCreateTitle.Location = new System.Drawing.Point(641, 386);
            this.buttonCreateTitle.Name = "buttonCreateTitle";
            this.buttonCreateTitle.Size = new System.Drawing.Size(147, 23);
            this.buttonCreateTitle.TabIndex = 18;
            this.buttonCreateTitle.Text = "Создать титульный лист";
            this.buttonCreateTitle.UseVisualStyleBackColor = true;
            this.buttonCreateTitle.Click += new System.EventHandler(this.buttonCreateTitle_Click);
            // 
            // buttonCreateDoc
            // 
            this.buttonCreateDoc.Location = new System.Drawing.Point(641, 415);
            this.buttonCreateDoc.Name = "buttonCreateDoc";
            this.buttonCreateDoc.Size = new System.Drawing.Size(147, 23);
            this.buttonCreateDoc.TabIndex = 19;
            this.buttonCreateDoc.Text = "Создать документ";
            this.buttonCreateDoc.UseVisualStyleBackColor = true;
            this.buttonCreateDoc.Click += new System.EventHandler(this.buttonCreateDoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateDoc);
            this.Controls.Add(this.buttonCreateTitle);
            this.Controls.Add(this.comboBoxAuthorFont);
            this.Controls.Add(this.comboBoxRevisorFont);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDisciplineName);
            this.Controls.Add(this.textBoxWorkTheme);
            this.Controls.Add(this.textBoxWorkName);
            this.Controls.Add(this.comboBoxWorkNumber);
            this.Controls.Add(this.comboBoxWorkType);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRevisor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRevisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.ComboBox comboBoxWorkType;
        private System.Windows.Forms.ComboBox comboBoxWorkNumber;
        private System.Windows.Forms.TextBox textBoxWorkName;
        private System.Windows.Forms.TextBox textBoxWorkTheme;
        private System.Windows.Forms.TextBox textBoxDisciplineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxRevisorFont;
        private System.Windows.Forms.ComboBox comboBoxAuthorFont;
        private System.Windows.Forms.Button buttonCreateTitle;
        private System.Windows.Forms.Button buttonCreateDoc;
    }
}

