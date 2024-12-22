
namespace LINQ_querries
{
    partial class FormBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxWithChild = new System.Windows.Forms.CheckBox();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Постоянные покупатели:";
            // 
            // checkBoxWithChild
            // 
            this.checkBoxWithChild.AutoSize = true;
            this.checkBoxWithChild.Location = new System.Drawing.Point(15, 429);
            this.checkBoxWithChild.Name = "checkBoxWithChild";
            this.checkBoxWithChild.Size = new System.Drawing.Size(136, 17);
            this.checkBoxWithChild.TabIndex = 13;
            this.checkBoxWithChild.Text = "С ребенком до 12 лет";
            this.checkBoxWithChild.UseVisualStyleBackColor = true;
            this.checkBoxWithChild.CheckedChanged += new System.EventHandler(this.checkBoxWithChild_CheckedChanged);
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.HorizontalScrollbar = true;
            this.listBoxClients.Location = new System.Drawing.Point(15, 65);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(186, 355);
            this.listBoxClients.TabIndex = 12;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(199, 455);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(131, 23);
            this.buttonBook.TabIndex = 15;
            this.buttonBook.Text = "Забронировать";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(207, 177);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(123, 23);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(207, 206);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(207, 235);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(123, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(207, 81);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 20);
            this.textBoxName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя клиента";
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.Location = new System.Drawing.Point(207, 130);
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownDiscount.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Персональная скидка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "К оплате:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(73, 9);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 13);
            this.labelPrice.TabIndex = 24;
            this.labelPrice.Text = "1000₽";
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 490);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxWithChild);
            this.Controls.Add(this.listBoxClients);
            this.Name = "FormBook";
            this.Text = "FormBook";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxWithChild;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPrice;
    }
}