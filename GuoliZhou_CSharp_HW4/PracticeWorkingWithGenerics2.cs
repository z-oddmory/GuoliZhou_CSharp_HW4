using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuoliZhou_CSharp_HW4
{
    public class PracticeWorkingWithGenerics2 <T>
    {   
        private List<T> aList = new List<T>();
        public void Add(T element)
        {
            aList.Add(element);
        }

        public T Remove(int index)
        {
            Console.WriteLine($"Remove item is {aList[index]}");
            aList.Remove(aList[index]);
            //The new item at index
            return aList[index];//???
        }

        public bool Contains(T item)
        {
            for(int i = 0; i > aList.Count(); i++)
            {
                if (aList.Contains(item))
                {
                    return true;
                }
                
            }
            return false;
        }

        public void Clear()
        {
            aList.Clear();
        }

        public void InsertAt(T element, int index)
        {
            aList[index] = element;//?
        }

        public void DeleteAt(int index)
        {
            aList.RemoveAt(index);//?
        }

        public T Find(int index)
        {
           
            if (Contains(aList[index]))
            {
                return aList[index];
            }
            Console.WriteLine("The list do not have this value.");
            return aList[index];//?
        }

    }
}
