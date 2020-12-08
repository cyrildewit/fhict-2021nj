using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCarCurrentValue
{
    class MotorFuelTypeDescriptor
    {
        private readonly Dictionary<MotorFuelType, string> descriptions = new Dictionary<MotorFuelType, string>
        {
            { MotorFuelType.Gasoline, "benzine-" },
            { MotorFuelType.Diesel, "diesel" },
            { MotorFuelType.LPG, "LPG-" },
            { MotorFuelType.Electric, "elektrische " },
        };

        public string Get(MotorFuelType fuelType)
        {
            return descriptions[fuelType];
        }
    }
}
