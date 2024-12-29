
namespace LINQ_querries
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
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.buttonFree = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.checkBoxFreeOnly = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPlaces = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChangeRooms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaces)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.HorizontalScrollbar = true;
            this.listBoxRooms.Location = new System.Drawing.Point(197, 25);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(425, 381);
            this.listBoxRooms.TabIndex = 1;
            // 
            // buttonFree
            // 
            this.buttonFree.Location = new System.Drawing.Point(412, 412);
            this.buttonFree.Name = "buttonFree";
            this.buttonFree.Size = new System.Drawing.Size(102, 23);
            this.buttonFree.TabIndex = 2;
            this.buttonFree.Text = "Освободить";
            this.buttonFree.UseVisualStyleBackColor = true;
            this.buttonFree.Click += new System.EventHandler(this.buttonFree_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(520, 412);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(102, 23);
            this.buttonBook.TabIndex = 3;
            this.buttonBook.Text = "Забронировать";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.HorizontalScrollbar = true;
            this.checkedListBoxOptions.Location = new System.Drawing.Point(6, 127);
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(164, 289);
            this.checkedListBoxOptions.TabIndex = 6;
            this.checkedListBoxOptions.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxOptions_SelectedIndexChanged);
            // 
            // checkBoxFreeOnly
            // 
            this.checkBoxFreeOnly.AutoSize = true;
            this.checkBoxFreeOnly.Location = new System.Drawing.Point(9, 66);
            this.checkBoxFreeOnly.Name = "checkBoxFreeOnly";
            this.checkBoxFreeOnly.Size = new System.Drawing.Size(122, 17);
            this.checkBoxFreeOnly.TabIndex = 7;
            this.checkBoxFreeOnly.Text = "Только свободные";
            this.checkBoxFreeOnly.UseVisualStyleBackColor = true;
            this.checkBoxFreeOnly.CheckedChanged += new System.EventHandler(this.checkBoxFreeOnly_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Удобства:";
            // 
            // numericUpDownPlaces
            // 
            this.numericUpDownPlaces.Location = new System.Drawing.Point(9, 40);
            this.numericUpDownPlaces.Name = "numericUpDownPlaces";
            this.numericUpDownPlaces.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPlaces.TabIndex = 9;
            this.numericUpDownPlaces.ValueChanged += new System.EventHandler(this.numericUpDownPlaces_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Количество мест:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Найдено: 0, Свободно: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxOptions);
            this.groupBox1.Controls.Add(this.numericUpDownPlaces);
            this.groupBox1.Controls.Add(this.checkBoxFreeOnly);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 422);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // buttonChangeRooms
            // 
            this.buttonChangeRooms.Location = new System.Drawing.Point(194, 412);
            this.buttonChangeRooms.Name = "buttonChangeRooms";
            this.buttonChangeRooms.Size = new System.Drawing.Size(130, 23);
            this.buttonChangeRooms.TabIndex = 15;
            this.buttonChangeRooms.Text = "Изменить комнаты";
            this.buttonChangeRooms.UseVisualStyleBackColor = true;
            this.buttonChangeRooms.Click += new System.EventHandler(this.buttonChangeRooms_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 443);
            this.Controls.Add(this.buttonChangeRooms);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.buttonFree);
            this.Controls.Add(this.listBoxRooms);
            this.Name = "MainForm";
            this.Text = "Задание №19 выполнил: Кругликов Е.А., Номер варианта: 8 Дата выполнения: 24/11/20" +
    "24";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlaces)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.Button buttonFree;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxFreeOnly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPlaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonChangeRooms;
    }
}

