using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_querries
{
    public partial class FormChangeOptions : Form
    {
        public FormChangeOptions()
        {
            InitializeComponent();
            listBoxOptions.DataSource = MainForm.commonOptions;
        }

        private void listBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxName.Text = ((RoomOption)listBoxOptions.SelectedItem).Name;
            numericUpDownPrice.Value = ((RoomOption)listBoxOptions.SelectedItem).Price;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MainForm.commonOptions.Add(new RoomOption(MainForm.commonOptions.Max(op => op.Id + 1), textBoxName.Text, (int)numericUpDownPrice.Value));
            listBoxOptions.DataSource = MainForm.commonOptions.ToArray();
            File.WriteAllText("RoomOptions.csv", MainForm.commonOptions.Select(op => op.Id + "," + op.Name + "," + op.Price).Aggregate((s, s1) => s + "\n" + s1));
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            RoomOption option = (RoomOption)listBoxOptions.SelectedItem;
            option.Name = textBoxName.Text;
            option.Price = (int)numericUpDownPrice.Value;
            listBoxOptions.DataSource = MainForm.commonOptions.ToArray();
            File.WriteAllText("RoomOptions.csv", MainForm.commonOptions.Select(op => op.Id + "," + op.Name + "," + op.Price).Aggregate((s, s1) => s + "\n" + s1));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MainForm.commonOptions.Remove((RoomOption)listBoxOptions.SelectedItem);
            foreach (Room room in MainForm.rooms)
                room.Options.Remove((RoomOption)listBoxOptions.SelectedItem);

            listBoxOptions.DataSource = MainForm.commonOptions.ToArray();
            File.WriteAllText("Rooms.csv", MainForm.rooms.Select(r => r.Number + "," + r.Beds + "," + r.Rooms + "," + r.Options.Select(op => op.Id.ToString()).Aggregate((id, id1) => id + "<" + id1)).Aggregate((r, r1) => r + "\n" + r1));
            File.WriteAllText("RoomOptions.csv", MainForm.commonOptions.Select(op => op.Id + "," + op.Name + "," + op.Price).Aggregate((s, s1) => s + "\n" + s1));
        }
    }
}