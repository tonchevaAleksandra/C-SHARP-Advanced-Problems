using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
   public class Cat
    {

        //Member => 
        //Field => all datas of the class
        //Property => the properties of the class
        //Methods
        private int miceKilled;//keeps information for the object - this is private info not public

        public void KillMouse()
        {
            miceKilled++;
        }

        private void GoToSleep()
        {

        }
        //public string Name { get; set; }//the properties can be used to receve the data saved
        private string name;
        public string Name
        { 
            get 
            { 
                return this.name;
            
            }
            set
            {
                if(value !=null)
                {
                    this.name = value;
                }
            }
        }

       public string SayMew()
        {
            return $"Mew from {this.name}!";
        }
        public int Age { get; set; }

        public string Color { get; set; }
    }
}
