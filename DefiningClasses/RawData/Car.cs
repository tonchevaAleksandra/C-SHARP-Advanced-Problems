using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Car
    {
        //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private List<Tire> tires;

        public List<Tire> Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        private Cargo cargo;

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }



    }
}
