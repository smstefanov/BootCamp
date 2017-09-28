using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public static string ReverseString(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return s;
            }
            return s.Last<char>().ToString() + ReverseString(s.Substring(0,s.Length-1));  
       }
        public static void Main(string[] args)
        {
            string s = "abc";
            Console.WriteLine(ReverseString(s));
        }
    }
}
