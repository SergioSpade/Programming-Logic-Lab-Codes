using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_Program
{
    class Passenger
    {

        private string Name;
        private double Weight;
        
        public Passenger(string x, double y)
        {

            Name = x;
            Weight = y;

        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
    


    }
}
