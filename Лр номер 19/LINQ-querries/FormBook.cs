using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_querries
{
    public partial class FormBook : Form
    {
        public FormBook()
        {
            InitializeComponent();
            listBoxClients.DataSource = MainForm.regularCustomers;
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelPrice.Text = Math.Floor(MainForm.selectedRoom.Price * (1 - ((((RegularCustomer)listBoxClients.SelectedItem)?.Discount ?? 0) + (checkBoxWithChild.Checked ? 10 : 0)) / 100f)) + "₽";
            textBoxName.Text = ((RegularCustomer)listBoxClients.SelectedItem).Name;
            numericUpDownDiscount.Value = ((RegularCustomer)listBoxClients.SelectedItem).Discount;
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            MainForm.selectedRoom.Booked = true;
            MessageBox.Show($"Комната забронирована!");
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            RegularCustomer customer = (RegularCustomer)listBoxClients.SelectedItem;
            customer.Name = textBoxName.Text;
            customer.Discount = (int)numericUpDownDiscount.Value;
            listBoxClients.DataSource = MainForm.regularCustomers.ToArray();
            File.WriteAllText("RegularCustomers.csv", MainForm.regularCustomers.Select(c => c.Name + ',' + c.Discount).Aggregate((s, s1) => s + '\n' + s1));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MainForm.regularCustomers.Add(new RegularCustomer(textBoxName.Text, (int)numericUpDownDiscount.Value));
            listBoxClients.DataSource = MainForm.regularCustomers.ToArray();
            File.WriteAllText("RegularCustomers.csv", MainForm.regularCustomers.Select(c => c.Name + ',' + c.Discount).Aggregate((s, s1) => s + '\n' + s1));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MainForm.regularCustomers.Remove((RegularCustomer)listBoxClients.SelectedItem);
            listBoxClients.DataSource = MainForm.regularCustomers.ToArray();
            File.WriteAllText("RegularCustomers.csv", MainForm.regularCustomers.Select(c => c.Name + ',' + c.Discount).Aggregate((s, s1) => s + '\n' + s1));
        }

        private void checkBoxWithChild_CheckedChanged(object sender, EventArgs e)
        {
            labelPrice.Text = Math.Floor(MainForm.selectedRoom.Price * (1 - ((((RegularCustomer)listBoxClients.SelectedItem)?.Discount ?? 0) + (checkBoxWithChild.Checked ? 10 : 0)) / 100f)) + "₽";
        }
    }
}