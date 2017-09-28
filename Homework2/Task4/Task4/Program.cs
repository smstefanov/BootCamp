using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        public static void Intersect(int[] arr1, int[] arr2)
        {
            List<int> temp=new List<int>();
            if (arr1.Length < arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            temp.Add(arr1[i]);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        if (arr2[i] == arr1[j])
                        {
                            temp.Add(arr2[i]);
                        }
                    }
                }
            }
           foreach(var item in temp)
           {
               Console.Write(item + " ");
           }
        }
        public static void Main(string[] args)
        {
            int[] arr1 = { 4, 7, 3, 9, 2 };
            int[] arr2 = { 3, 2, 12, 9, 40, 32, 4 };
            Intersect(arr1, arr2);
        }
    }
}
