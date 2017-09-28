using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static void FindIndex(int[] array)
        {
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 1; i < array.Length - 1; i++)
            {
                for(int j = 0;j < i; j++)
                {
                    sum1 += array[j];
                }
                for(int k = i+1; k < array.Length; k++)
                {
                    sum2 += array[k];
                }
                if(sum1 == sum2)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    sum1 = 0;
                    sum2 = 0;
                }
            }
        }
        public static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,6};
            FindIndex(array);
        }
    }
}
