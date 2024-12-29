using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQ_querries
{
    public partial class ChangeRooms : Form
    {
        public ChangeRooms()
        {
            InitializeComponent();
            checkedListBoxOptions.DataSource = MainForm.commonOptions;
            listBoxRooms.DataSource = MainForm.rooms;
        }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownRooms.Value = ((Room)listBoxRooms.SelectedItem).Rooms;
            numericUpDownBeds.Value = ((Room)listBoxRooms.SelectedItem).Beds;
            for (int i = 0; i < checkedListBoxOptions.Items.Count; i++)
                if (((Room)listBoxRooms.SelectedItem).Options.Contains((RoomOption)checkedListBoxOptions.Items[i]))
                    checkedListBoxOptions.SetItemChecked(i, true);
                else
                    checkedListBoxOptions.SetItemChecked(i, false);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MainForm.rooms.Add(new Room(MainForm.rooms.Max(r => r.Number + 1), (int)numericUpDownBeds.Value, (int)numericUpDownRooms.Value, checkedListBoxOptions.CheckedItems.OfType<RoomOption>().ToList()));
            listBoxRooms.DataSource = MainForm.rooms.ToArray();
            File.WriteAllText("Rooms.csv", MainForm.rooms.Select(r => r.Number + "," + r.Beds + "," + r.Rooms + "," + r.Options.Select(op => op.Id.ToString()).Aggregate((id, id1) => id + "<" + id1)).Aggregate((r, r1) => r + "\n" + r1));
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Room room = (Room)listBoxRooms.SelectedItem;
            room.Beds = (int)numericUpDownBeds.Value;
            room.Rooms = (int)numericUpDownRooms.Value;
            room.Options = checkedListBoxOptions.CheckedItems.OfType<RoomOption>().ToList();
            listBoxRooms.DataSource = MainForm.rooms.ToArray();
            File.WriteAllText("Rooms.csv", MainForm.rooms.Select(r => r.Number + "," + r.Beds + "," + r.Rooms + "," + r.Options.Select(op => op.Id.ToString()).Aggregate((id, id1) => id + "<" + id1)).Aggregate((r, r1) => r + "\n" + r1));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MainForm.rooms.Remove((Room)listBoxRooms.SelectedItem);
            listBoxRooms.DataSource = MainForm.rooms.ToArray();
            File.WriteAllText("Rooms.csv", MainForm.rooms.Select(r => r.Number + "," + r.Beds + "," + r.Rooms + "," + r.Options.Select(op => op.Id.ToString()).Aggregate((id, id1) => id + "<" + id1)).Aggregate((r, r1) => r + "\n" + r1));
        }

        private void buttonChangeOptions_Click(object sender, EventArgs e)
        {
            new FormChangeOptions().ShowDialog();
            checkedListBoxOptions.DataSource = MainForm.commonOptions.ToArray();
        }
    }
}
