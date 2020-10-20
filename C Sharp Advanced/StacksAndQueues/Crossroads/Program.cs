using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int carsPassed = 0;
            string crashedCar = string.Empty;
            int hitIndex = 0;
            string command;
            bool isCrashed = false;
            while ((command = Console.ReadLine()) != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);

                }
                else
                {
                    int currGreen = greenLightDuration;
                    
                    while (currGreen>0 && cars.Any())
                    {
                        string currCar = cars.Peek();
                        int lengthCar = currCar.Length;
                        if(lengthCar<=currGreen)
                        {
                            currGreen -= lengthCar;
                            carsPassed++;
                            cars.Dequeue();
                        }
                        else
                        {                                                     
                            if(lengthCar- currGreen<=freeWindow)
                            {                              
                                carsPassed++;
                                cars.Dequeue();
                            }
                            else
                            {
                                isCrashed = true;
                                crashedCar = currCar;
                                hitIndex = currGreen + freeWindow;
                               
                                break;
                            }
                            currGreen = 0;
                        }
                    }                  
                }

                if(isCrashed)
                {
                    break;
                }
            }
            if (isCrashed)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{crashedCar} was hit at {crashedCar[hitIndex]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}
