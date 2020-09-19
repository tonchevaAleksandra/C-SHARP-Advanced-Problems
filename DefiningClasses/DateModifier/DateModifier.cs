using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateModifier
{
   public class DateModifier
    {
       
        public int CalculateDifference(string date1, string date2)
        {
            var arr1 = date1.Split().Select(int.Parse).ToArray();
            var arr2 = date2.Split().Select(int.Parse).ToArray();

            DateTime firstDate = new DateTime(arr1[0], arr1[1], arr1[2]);
            DateTime secondDate = new DateTime(arr2[0], arr2[1], arr2[2]);

            return Math.Abs((secondDate - firstDate).Days);

        }
    }
}
