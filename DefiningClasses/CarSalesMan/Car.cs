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
        public Car(string model, Engine engine)
            : this()
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
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

        public int? Weight
        {
            get;
            set;
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

            string weightStr = this.Weight.HasValue ? this.Weight.ToString() : "n/a";
            string colorStr = String.IsNullOrEmpty(this.Color) ? "n/a" : this.Color;

            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($" {this.Engine.ToString()}");
            sb.AppendLine($" Weight: {weightStr}");
            sb.Append($" Color: {colorStr}");

            return sb.ToString().TrimEnd();
        }
    }
}
