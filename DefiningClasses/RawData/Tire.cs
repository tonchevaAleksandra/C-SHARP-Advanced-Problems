using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Tire
    {
        private double tirePressure;

        public double TirePressure
        {
            get { return tirePressure; }
            set { tirePressure = value; }
        }

        private int tireAge;

        public int TireAge
        {
            get { return tireAge; }
            set { tireAge = value; }
        }

        public Tire(double tirePressure, int tireAge)
        {
            this.TirePressure = tirePressure;
            this.TireAge = tireAge;
        }
    }
}
