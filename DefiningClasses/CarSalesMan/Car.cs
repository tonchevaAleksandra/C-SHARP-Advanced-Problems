using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesMan
{
    public class Car
    {
       
        public Car()
        {
            this.Color = "n/a";
        }
        public Car(string model,Engine engine)
            :this()
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            :this(model,engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color)
            :this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
            :this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($" {this.Engine.ToString()}");
            if (this.Weight == 0)
            {
                sb.AppendLine($" Weight: n/a");
            }
            else
            {
                sb.AppendLine($" Weight: {this.Weight}");
            }
            sb.Append($" Color: {this.Color}");
            return sb.ToString();
        }
    }
}
