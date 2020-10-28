using BloedPressureApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloedPressureApp
{
    public class TimeSlotModel
    {
        public int Id { get; set; }
        public int Roomid { get; set; }
        public string Datetime { get; set; }
        public string Timeslot { get; set; }
        public bool Booked { get; set; }
    }
}
