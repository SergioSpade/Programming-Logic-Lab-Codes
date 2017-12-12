using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Program
{
    class Elevator
    {

        private double MaxWeight;
        private Passenger[] Occupants;

        public void AddOccupants(Passenger passenger, int index)
        {
            if (index < Occupants.Length)
            {
                Occupants[index] = passenger;
            }
        }

        public Elevator(int maxOccupants, double maxWeight)
        {

            MaxWeight = maxWeight;
            Occupants = new Passenger[maxOccupants];
        }

        public Boolean IsOverMaxCapacity()
        {
            if (GetCurrentWeight()>MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetCurrentWeight()
        {
            double sum = 0;
            for (int t = 0; t < Occupants.Length; t++)
            {
                if (Occupants[t] != null)
                {
                    sum += Occupants[t].GetWeight();

                }
            }
            return sum;
        }


    }
}
