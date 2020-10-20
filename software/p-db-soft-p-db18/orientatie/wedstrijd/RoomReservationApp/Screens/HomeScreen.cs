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
        List<DateTime> availableDays = new List<DateTime>() {
            new DateTime(2020, 10, 13),
            new DateTime(2020, 10, 14),
            new DateTime(2020, 10, 15),
            new DateTime(2020, 10, 16),
            new DateTime(2020, 10, 19),
            new DateTime(2020, 10, 20),
            new DateTime(2020, 10, 21),
            new DateTime(2020, 10, 22),
            new DateTime(2020, 10, 23),
        };

        List<String> possibleTimeSlots = new List<String>() {
            "09:00 - 11:55",
            "12:00 - 16:55",
            "17:00 - 19:30",
        };

        List<TimeSlotModel> timeSlots = new List<TimeSlotModel>();

        List<Button> reserveTimeSlotButtons = new List<Button>();

        public HomeScreen()
        {
            InitializeComponent();

            LoadAvailableDays();
            LoadPossibleTimeSlots();

            LoadReserveTimeSlotButtons();

            LoadAvailability();
        }

        private void LoadAvailableDays()
        {
            foreach (DateTime availableDay in availableDays) {
                comboBoxDates.Items.Add(availableDay.ToString("MMMM dd, yyyy"));
            }

            comboBoxDates.SelectedItem = comboBoxDates.Items[0];
        }

        private void LoadPossibleTimeSlots()
        {
            foreach (String timeSlot in possibleTimeSlots)
            {
                comboBoxTimeSlots.Items.Add(timeSlot);
            }

            comboBoxTimeSlots.SelectedItem = comboBoxTimeSlots.Items[0];
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
            DateTime dateTime = availableDays[comboBoxDates.SelectedIndex];
            int timeSlot = comboBoxTimeSlots.SelectedIndex;

            timeSlots = SqliteDataAccess.LoadTimeSlots(dateTime.ToShortDateString());

            foreach (Button button in reserveTimeSlotButtons)
            {
                button.Enabled = true;
            }

            foreach (TimeSlotModel timeSlotModel in timeSlots)
            {
                if (reserveTimeSlotButtons.ElementAtOrDefault(timeSlotModel.Id - 1) != null)
                {
                    reserveTimeSlotButtons[timeSlotModel.Id - 1].Enabled = timeSlotModel.Booked;
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

        private void buttonReserveRoom1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
