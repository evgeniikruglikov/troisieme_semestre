
namespace LINQ_querries
{
    partial class ChangeRooms
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
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownRooms = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBeds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChangeOptions = new System.Windows.Forms.Button();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeds)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.Location = new System.Drawing.Point(541, 56);
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(191, 289);
            this.checkedListBoxOptions.TabIndex = 2;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(417, 352);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(541, 352);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(657, 352);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownRooms
            // 
            this.numericUpDownRooms.Location = new System.Drawing.Point(440, 56);
            this.numericUpDownRooms.Name = "numericUpDownRooms";
            this.numericUpDownRooms.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownRooms.TabIndex = 6;
            // 
            // numericUpDownBeds
            // 
            this.numericUpDownBeds.Location = new System.Drawing.Point(440, 109);
            this.numericUpDownBeds.Name = "numericUpDownBeds";
            this.numericUpDownBeds.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownBeds.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Комнат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Кроватей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Опции:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выбранный номер";
            // 
            // buttonChangeOptions
            // 
            this.buttonChangeOptions.Location = new System.Drawing.Point(621, 27);
            this.buttonChangeOptions.Name = "buttonChangeOptions";
            this.buttonChangeOptions.Size = new System.Drawing.Size(111, 23);
            this.buttonChangeOptions.TabIndex = 12;
            this.buttonChangeOptions.Text = "Изменить опции";
            this.buttonChangeOptions.UseVisualStyleBackColor = true;
            this.buttonChangeOptions.Click += new System.EventHandler(this.buttonChangeOptions_Click);
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.Location = new System.Drawing.Point(12, 12);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(403, 329);
            this.listBoxRooms.TabIndex = 1;
            this.listBoxRooms.SelectedIndexChanged += new System.EventHandler(this.listBoxRooms_SelectedIndexChanged);
            // 
            // ChangeRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 387);
            this.Controls.Add(this.buttonChangeOptions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownBeds);
            this.Controls.Add(this.numericUpDownRooms);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.checkedListBoxOptions);
            this.Controls.Add(this.listBoxRooms);
            this.Name = "ChangeRooms";
            this.Text = "ChangeRooms";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownRooms;
        private System.Windows.Forms.NumericUpDown numericUpDownBeds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChangeOptions;
        private System.Windows.Forms.ListBox listBoxRooms;
    }
}