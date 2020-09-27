using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingListTemplate
{
   public static class EnumarableExtensions
    {
        public static MyList<T> ToMyList<T>(this IEnumerable<T> enumarable)
        {
            var list = new MyList<T>();

            foreach (var item in enumarable)
            {
                list.Add(item);
            }
            return /*new MyList<T>()*/ list;
        }
    }
}
