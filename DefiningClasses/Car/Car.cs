using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
        //    get { return this.year; }
        //    set
        //    {
        //        if(value <1989)
        //        {
        //            throw new  InvalidOperationException("Year can not be  less than 1989");
        //        }

        //        this.year = value;
        //    }
        //}
    }
}
