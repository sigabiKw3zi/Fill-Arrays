using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillArrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 100, min = 1, max = 100;
            int[] array = new int[size];

            array = FillArray(size, min, max);

            DisplayArray(array);
        }

        static int[] FillArray(int size, int min, int max)
        {
            //int[] array = new int[size];

            //Random rnd = new Random();
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = rnd.Next(min, max);
            //}
            //return array;

            int[] array = new int[size];
            int temp;
            bool found;

            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                do
                {
                    temp = rnd.Next(min, max + 1);
                    found = false;
                    for (int f = 0; f < i; f++)
                    {
                        if (temp == array[f])
                        {
                            found = true;
                            f = i;
                        }
                    }
                    if (found == false)
                    {
                        array[i] = temp;
                    }
                }
                while (found == true);
            }
            return array;
        }

        static void DisplayArray(int[] array)
        {
            for(int x = 0; x < array.Length -1; x++)
            {
                Console.Write("[{0}] {1}, ", x, array[x]);
            }
            Console.WriteLine("[{0}]{1}", array.Length -1 , array[array.Length -1]);

        }
    }
}
