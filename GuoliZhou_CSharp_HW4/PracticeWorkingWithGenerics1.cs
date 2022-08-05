using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuoliZhou_CSharp_HW4
{
    public class MyStack <T>
    {
        public static int Count(List<T> stack)
        {
            int ans = stack.Count();
            return ans;
        }

        public static T Pop(T obj)
        {

            return obj;
        }

        public static void Push(List<T> stack, T obj)
        {
            stack.Add(obj);
        }


    }
}
