using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesMan
{
    public class Engine
    {
        //private int? displacement;// this can set int to null if it's empty

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

        public int? Displacement
        {
            get;
            set;
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
            string displacementStr = this.Displacement.HasValue ? this.Displacement.ToString() : "n/a";
            string efficiencyStr = string.IsNullOrEmpty(this.Efficiency) ? "n/a" : this.Efficiency;

            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  Power: {this.Power}");
            sb.AppendLine($"  Displacement: {displacementStr}");         
            sb.Append($"  Efficiency: {efficiencyStr}");

            return sb.ToString().TrimEnd();
        }
    }
}
