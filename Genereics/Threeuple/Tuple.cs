using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
   public class Tuple<TFirst,TSecond,TThird> 
    {
        public TFirst FisrtItem { get; set; }
        public TSecond SecondItem { get; set; }
        public TThird ThirdItem { get; set; }

        public Tuple(TFirst firstItem, TSecond secondItem, TThird thirdItem)
        {
            this.FisrtItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
        }

        public override string ToString()
        {
            return $"{this.FisrtItem} -> {this.SecondItem} -> {this.ThirdItem}"; 
        }


    }
}
