using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_querries
{
    public partial class MainForm : Form
    {
        static List<RoomOption> commonOptions;

        List<Room> rooms;
        List<RegularCustomer> regularCustomers;

        public MainForm()
        {
            InitializeComponent();

            LoadCSV();

            listBox2.DataSource = regularCustomers;
            checkedListBox1.DataSource = commonOptions;

            UpdateRooms();
        }

        public static RoomOption GetCommonOption(string name)
        {
            return commonOptions.FirstOrDefault(op => op.Name == name);
        }

        private void LoadCSV()
        {
            commonOptions = File.ReadAllText("RoomOptions.csv", System.Text.Encoding.UTF8).Split('\n').Select(s => { string[] s1 = s.Split(','); return new RoomOption(s1[0], int.Parse(s1[1])); }).ToList();
            rooms = File.ReadAllText("Rooms.csv", System.Text.Encoding.UTF8).Split('\n').Select(s => { string[] s1 = s.Split(','); return new Room(int.Parse(s1[0]), int.Parse(s1[1]), int.Parse(s1[2]), (s1.Count() > 3) ? s1.Skip(3).Select(opName => GetCommonOption(opName)).ToList() : null); }).ToList();
            regularCustomers = File.ReadAllText("RegularCustomers.csv", System.Text.Encoding.UTF8).Split('\n').Select(s => { string[] s1 = s.Split(','); return new RegularCustomer(s1[0], int.Parse(s1[1])); }).ToList();
        }

        private void UpdateRooms()
        {
            List<Room> filtered = rooms.Where(r => r.Beds >= numericUpDown1.Value && checkedListBox1.CheckedItems.Cast<RoomOption>().All(op => r.Options.Contains(op)) && (!checkBox2.Checked || !r.Booked)).ToList();
            listBox1.DataSource = filtered;
            label4.Text = $"Найдено: {filtered.Count()}, Свободно: {filtered.Count(r => !r.Booked)}";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRooms();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateRooms();
        }

        private void checkedListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateRooms();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room room = (Room)listBox1.SelectedItem;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Room room = (Room)listBox1.SelectedItem;
            if (room == null)
            {
                MessageBox.Show("Комната не выбрана!");
                return;
            }

            if (room.Booked)
                MessageBox.Show("Комната уже занята!");
            else
            {
                room.Booked = true;
                MessageBox.Show($"Комната забронирована! К оплате {Math.Floor(room.Price * (1 - ((((RegularCustomer)listBox2.SelectedItem)?.Discount ?? 0) + (checkBox1.Checked ? 10 : 0)) / 100f))}₽.");
            }

            UpdateRooms();
        }
    }
}