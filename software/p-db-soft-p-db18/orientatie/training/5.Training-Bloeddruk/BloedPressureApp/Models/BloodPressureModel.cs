using BloedPressureApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloedPressureApp
{
    public class BloodPressureModel
    {
        public int Id { get; set; }
        public int UpperPressure { get; set; }
        public int UnderPressure { get; set; }
        public string Result { get; set; }
        public string Notes { get; set; }

        public decimal MeanArterialPressure
        {
            get
            {
                return UnderPressure + ((UpperPressure - UnderPressure) / 3);
            }
        }
    }
}
