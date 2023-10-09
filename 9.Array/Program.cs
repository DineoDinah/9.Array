using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oneWayAttribute way of creating an array
            int[] luckynNumbers = { 4, 5, 8, 9, };
            Console.WriteLine(luckynNumbers[0]);

            //if you wanna populate it later, the 5 is the size
            string[] friends = new string[5];
            friends[0] = "Katlego";
            friends[1] = "Lerato";
            friends[2] = "Kemelo";
            Console.WriteLine(friends[0]);

            Console.Read();

        }
    }
}
