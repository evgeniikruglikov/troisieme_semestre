using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_querries
{
    public partial class MainForm : Form
    {
        public static List<RoomOption> commonOptions;

        public static List<Room> rooms;
        public static List<RegularCustomer> regularCustomers;
        public static Room selectedRoom;

        public MainForm()
        {
            LoadCSV();

            InitializeComponent();

            checkedListBoxOptions.DataSource = commonOptions;

            UpdateRooms();
        }

        public static RoomOption GetCommonOption(int id)
        {
            return commonOptions.FirstOrDefault(op => op.Id == id);
        }

        private void LoadCSV()
        {
            commonOptions = File.ReadAllText("RoomOptions.csv", System.Text.Encoding.UTF8).Split('\n').Select(s => { string[] s1 = s.Split(','); return new RoomOption(int.Parse(s1[0]), s1[1], int.Parse(s1[2])); }).ToList();
            rooms = File.ReadAllText("Rooms.csv", System.Text.Encoding.UTF8).Split('\n').Select(s => { string[] s1 = s.Split(','); return new Room(int.Parse(s1[0]), int.Parse(s1[1]), int.Parse(s1[2]), (s1.Count() > 3) ? s1[3].Split('<').Select(opId => GetCommonOption(int.Parse(opId))).ToList() : null); }).ToList();
            regularCustomers = File.ReadAllText("RegularCustomers.csv", System.Text.Encoding.UTF8).Split('\n').Select(s => { string[] s1 = s.Split(','); return new RegularCustomer(s1[0], int.Parse(s1[1])); }).ToList();
        }

        private void UpdateRooms()
        {
            List<Room> filtered = rooms.Where(r => r.Beds >= numericUpDownPlaces.Value && checkedListBoxOptions.CheckedItems.Cast<RoomOption>().All(op => r.Options.Contains(op)) && (!checkBoxFreeOnly.Checked || !r.Booked)).ToList();
            listBoxRooms.DataSource = filtered;
            label4.Text = $"Найдено: {filtered.Count()}, Свободно: {filtered.Count(r => !r.Booked)}";
        }

        private void checkBoxFreeOnly_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRooms();
        }

        private void checkedListBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRooms();
        }

        private void buttonFree_Click(object sender, EventArgs e)
        {
            Room room = (Room)listBoxRooms.SelectedItem;
            if (room == null)
            {
                MessageBox.Show("Комната не выбрана!");
                return;
            }

            if (room.Booked)
            {
                room.Booked = false;
                MessageBox.Show("Комната освобождена!");
            }
            else
                MessageBox.Show("Комната уже свободна!");

            UpdateRooms();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            selectedRoom = (Room)listBoxRooms.SelectedItem;
            if (selectedRoom == null)
            {
                MessageBox.Show("Комната не выбрана!");
                return;
            }

            if (selectedRoom.Booked)
                MessageBox.Show("Комната уже занята!");
            else
            {
                new FormBook().ShowDialog();
            }

            UpdateRooms();
        }

        private void numericUpDownPlaces_ValueChanged(object sender, EventArgs e)
        {
            UpdateRooms();
        }

        private void buttonChangeRooms_Click(object sender, EventArgs e)
        {
            new ChangeRooms().ShowDialog();
            UpdateRooms();
            checkedListBoxOptions.DataSource = commonOptions.ToArray();
        }
    }
}