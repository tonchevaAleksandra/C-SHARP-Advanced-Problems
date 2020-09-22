using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int count;
        public int Count
        {
            get { return this.cars.Count; }
            
        }

         
        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
      
        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.Capacity = capacity;
        }

        public string AddCar(Car car)
        {

            if (this.cars.Find(c => c.RegistrationNumber == car.RegistrationNumber) != null)
            {
                return $"Car with that registration number, already exists!";
            }
            else
            {
                if (this.cars.Count >= this.Capacity)
                {
                    return $"Parking is full!";
                }
                else
                {
                    this.cars.Add(car);
                    return $"Successfully added new car { car.Make } { car.RegistrationNumber}";
                }
            }
         
        }

        public string RemoveCar(string registrationNumber)
        {
            if (this.cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                Car currCar = this.cars.Find(c => c.RegistrationNumber == registrationNumber);
                this.cars.Remove(currCar);
                return $"Successfully removed {currCar.RegistrationNumber}";
            }
            else
            {
                return $"Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return this.cars.Find(c => c.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string regNum in registrationNumbers)
            {
                while (this.cars.Any(c => c.RegistrationNumber == regNum))
                {
                    Car currCar = this.cars.Find(c => c.RegistrationNumber == regNum);
                    this.cars.Remove(currCar);
                }
            }
        }
    }
}
