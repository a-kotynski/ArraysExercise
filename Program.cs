using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1,2,3}; //different way: var numbers = new int[3];
            //numbers[0] = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            bool[] flags = new bool[3] {true, false, true};
            //flags[0] = true;
            for (int i = 0; i < flags.Length; i++)
            {
                Console.WriteLine(flags[i]);

            }

            string[] strings = new string[3] { "test0", "test1", "test2" };
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }
}