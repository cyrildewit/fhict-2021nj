using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCarCurrentValue
{
    class Car
    {
        private MotorFuelType fuelType;
        private int mileAge = 1;
        private readonly string licensePlate;

        private readonly MotorFuelTypeDescriptor fuelTypeDescription = new MotorFuelTypeDescriptor();
        private readonly MotorFuelTypeFactorization fuelTypeFactors = new MotorFuelTypeFactorization();

        

        public int MileAge {
            get { return mileAge; }
            private set { mileAge = 1; }
        }
        public int CurrentValue {
            get { return (500000 / MileAge) * fuelTypeFactors.Get(fuelType); }
        }

        public Car(string licensePlate, MotorFuelType fuelType) {
            this.licensePlate = licensePlate;
            this.fuelType = fuelType;
        }

        /**
         * Drive the car for the given distance.
         * 
         * @param  int Distance in kilometers;
         */
        public void Drive(int distance) {
            if (distance > 0) {
                mileAge += distance;
            }
        }

        public override string ToString()
        {
            return $"{ licensePlate } { fuelTypeDescription.Get(fuelType) }auto heeft een kilometerstand van { mileAge }km en een dagwaarde van  { CurrentValue }";
        }
    }
}
