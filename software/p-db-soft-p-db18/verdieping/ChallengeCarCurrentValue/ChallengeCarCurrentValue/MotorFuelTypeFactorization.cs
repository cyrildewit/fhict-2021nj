using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCarCurrentValue
{
    class MotorFuelTypeFactorization
    {
        private readonly Dictionary<MotorFuelType, int> factors = new Dictionary<MotorFuelType, int>
        {
            { MotorFuelType.Gasoline, 100 },
            { MotorFuelType.Diesel, 150 },
            { MotorFuelType.LPG, 90 },
            { MotorFuelType.Electric, 130 },
        };

        public int Get(MotorFuelType fuelType)
        {
            return factors[fuelType];
        }
    }
}
