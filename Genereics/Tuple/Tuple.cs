using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
   public class Tuple<TFirst,TSecond> 
    {
        public TFirst FisrtItem { get; set; }
        public TSecond SecondItem { get; set; }

        public Tuple(TFirst firstItem, TSecond secondItem)
        {
            this.FisrtItem = firstItem;
            this.SecondItem = secondItem;

        }

        public override string ToString()
        {
            return $"{this.FisrtItem} -> {this.SecondItem}"; 
        }


    }
}
