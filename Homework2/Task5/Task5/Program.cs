using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Program
    {
        public static void RemoveDuplicates(int[] array)
        {
            List<int> list = new List<int>();
            for(int i = 0;i<array.Length-1;i++)
            {
                if(array[i]!=array[i+1])
                {
                    list.Add(array[i]);
                }
                else
                {
                    continue;
                }
            }
            if(list.Last<int>()!=array[array.Length-1])
            {
                list.Add(array[array.Length - 1]);
            }
            foreach(var i in list)
            {
                Console.Write(i + " ");
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = { 2, 3, 6, 6, 8, 9, 10, 10, 10, 12, 12 };
            RemoveDuplicates(arr);        
        }
    }
}
