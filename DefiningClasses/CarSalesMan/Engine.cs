using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesMan
{
    public class Engine
    {

        public Engine()
        {
            this.Efficiency = "n/a";
            
        }
        public Engine(string model, int power)
            :this()
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int displacement)
            :this(model, power)
        {
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency)
            :this(model, power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency)
            :this( model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        private int displacement;

        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        private string efficiency;

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  Power: {this.Power}");
            if (this.Displacement == 0)
            {                        
                sb.AppendLine($"  Displacement: n/a");                      
            }
            else
            {  
                sb.AppendLine($"  Displacement: {this.Displacement}");
            }
            sb.Append($"  Efficiency: {this.Efficiency}");
            return sb.ToString();
        }
    }
}
