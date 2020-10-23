using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {

        public Engine(int engineSpeed, int enginePower)
        {
            this.EndineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
        private int engineSpeed;

        public int EndineSpeed
        {
            get { return engineSpeed; }
            set { engineSpeed = value; }
        }

        private int enginePower;

        public int EnginePower
        {
            get { return enginePower; }
            set { enginePower = value; }
        }



    }
}
