using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class LinkedList
    {
        public static LinkedList<int> Revert(LinkedList<int> linkedList)
        {
            LinkedList<int> temp = new LinkedList<int>();
            linkedList.ToArray<int>();
            while (linkedList.Any())
            {
                temp.AddLast(linkedList.Last<int>());
                linkedList.RemoveLast();
            }
            return temp;
        }
        static void Main(string[] args)
        {
            LinkedList<int> linked = new LinkedList<int>();
            int[] temp = {1,2,3,4,5,6,7,8,9,10};
            foreach(var item in temp)
            {
                linked.AddLast(item);
            }
            linked=Revert(linked);
            foreach(var item in linked)
            {
                Console.Write(item + " ");
            }
        }
    }
}
