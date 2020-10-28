using BloedPressureApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloedPressureApp
{
    public partial class HomeScreen : Form
    {
        List<DateTime> bookableDateTimes = new List<DateTime>();

        List<TimeSlotModel> timeSlots = new List<TimeSlotModel>();

        List<Button> reserveTimeSlotButtons = new List<Button>();

        public HomeScreen()
        {
            InitializeComponent();

            LoadBookableDateTimes();
            LoadBookableTimeSlots();

            LoadReserveTimeSlotButtons();

            //LoadAvailability();
        }

        private void LoadBookableDateTimes()
        {
            DateTime now = DateTime.Now;

            for (int i = 0; i < 14; i++)
            {
                DateTime tomorrow = now.AddDays(i);

                bookableDateTimes.Add(tomorrow);
                comboBoxDates.Items.Add(tomorrow.ToString("MMMM dd, yyyy"));
            }

            comboBoxDates.SelectedIndex = 0;
        }

        private void LoadBookableTimeSlots()
        {
            comboBoxTimeSlots.Items.Add("09:00 - 11:55");
            comboBoxTimeSlots.Items.Add("12:00 - 16:55");
            comboBoxTimeSlots.Items.Add("17:00 - 19:30");


            comboBoxTimeSlots.SelectedItem = comboBoxTimeSlots.Items[0];
            //comboBoxTimeSlots.SelectedItem = 0;
        }

        private void LoadReserveTimeSlotButtons()
        {
            reserveTimeSlotButtons.Add(buttonReserveRoom1);
            reserveTimeSlotButtons.Add(buttonReserveRoom2);
            reserveTimeSlotButtons.Add(buttonReserveRoom3);
            reserveTimeSlotButtons.Add(buttonReserveRoom4);
            reserveTimeSlotButtons.Add(buttonReserveRoom5);
            reserveTimeSlotButtons.Add(buttonReserveRoom6);
            reserveTimeSlotButtons.Add(buttonReserveRoom7);
            reserveTimeSlotButtons.Add(buttonReserveRoom8);
            reserveTimeSlotButtons.Add(buttonReserveRoom9);
            reserveTimeSlotButtons.Add(buttonReserveRoom10);
            reserveTimeSlotButtons.Add(buttonReserveRoom11);
            reserveTimeSlotButtons.Add(buttonReserveRoom12);
        }

        private void LoadAvailability()
        {
            // If 
            if (comboBoxDates.SelectedIndex < 0 || comboBoxTimeSlots.SelectedIndex < 0)
            {
                return;
            }

            DateTime selectedDateTime = bookableDateTimes[comboBoxDates.SelectedIndex];
            string selectedTimeSlot = comboBoxTimeSlots.Items[comboBoxTimeSlots.SelectedIndex].ToString();

            timeSlots = SqliteDataAccess.LoadTimeSlots(selectedDateTime.ToShortDateString(), selectedTimeSlot);

            foreach (Button button in reserveTimeSlotButtons)
            {
                button.Enabled = true;
            }

            foreach (TimeSlotModel timeSlotModel in timeSlots)
            {
                if (reserveTimeSlotButtons.ElementAtOrDefault(timeSlotModel.Roomid - 1) != null)
                {
                    MessageBox.Show(timeSlotModel.Booked.ToString());
                    reserveTimeSlotButtons[timeSlotModel.Roomid - 1].Enabled = false;
                }
            }
        }

        private void comboBoxDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailability();
        }

        private void buttonCheckAvailability_Click(object sender, EventArgs e)
        {
            LoadAvailability();
        }

        private void comboBoxTimeSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailability();
        }

        private void BookRoom(int roomId) {
            TimeSlotModel timeslot = new TimeSlotModel
            {
                Roomid = roomId,
                Datetime = bookableDateTimes[comboBoxDates.SelectedIndex].ToShortDateString(),
                Timeslot = comboBoxTimeSlots.Items[comboBoxTimeSlots.SelectedIndex].ToString(),
                Booked = true
            };

            SqliteDataAccess.BookTimeSlot(timeslot);

            LoadAvailability();
        }

        private void buttonReserveRoom1_Click(object sender, EventArgs e)
        {
            BookRoom(1);
        }

        private void buttonReserveRoom2_Click(object sender, EventArgs e)
        {
            BookRoom(2);
        }

        private void buttonReserveRoom3_Click(object sender, EventArgs e)
        {
            BookRoom(3);
        }

        private void buttonReserveRoom4_Click(object sender, EventArgs e)
        {
            BookRoom(4);
        }

        private void buttonReserveRoom5_Click(object sender, EventArgs e)
        {
            BookRoom(5);
        }

        private void buttonReserveRoom6_Click(object sender, EventArgs e)
        {
            BookRoom(6);
        }

        private void buttonReserveRoom7_Click(object sender, EventArgs e)
        {
            BookRoom(7);

        }

        private void buttonReserveRoom8_Click(object sender, EventArgs e)
        {
            BookRoom(8);

        }

        private void buttonReserveRoom9_Click(object sender, EventArgs e)
        {
            BookRoom(9);

        }

        private void buttonReserveRoom10_Click(object sender, EventArgs e)
        {
            BookRoom(10);

        }

        private void buttonReserveRoom11_Click(object sender, EventArgs e)
        {
            BookRoom(11);

        }

        private void buttonReserveRoom12_Click(object sender, EventArgs e)
        {
            BookRoom(12);
        }
    }
}
