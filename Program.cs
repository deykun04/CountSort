using System;
using System.Linq;

namespace CoutingSort
{
    class CoutingSort
    {
        static void Generate(int[] array)
        {
            Random rand = new Random();
            for(int i=0; i < array.Length; i++)
            {
                array[i] = rand.Next(150);
            }
        }
        static void Sort (int[] array)
        {
             int length = array.Length;
             int[] resultArr = new int[length];
             int[] countArr = new int[256];
            for (int i = 0; i < length; ++i)
            {
              ++countArr[array[i]];  
            }
            for (int i = 1; i <= 255; ++i)
            {
                countArr[i] += countArr[i - 1];
            }
            for (int i = length - 1; i >= 0; i--)
            {
                resultArr[countArr[array[i]] - 1] = array[i];
                --countArr[array[i]];
            }
            for (int i = 0; i < length; ++i)
            {
                array[i] = resultArr[i];
            }
        }
        public static void Main (String[] args)
        {        
            int[] array = new int[10];
            Generate(array);
            for(int i=0; i < array.Length; i++)
            {
                Console.Write("\t"+ array[i]);
            }
            Console.WriteLine("\n");
            Sort(array);
            Console.WriteLine("Array after couting sort: ");
            for(int i=0; i < array.Length; i++)
            {
                Console.Write("\t"+ array[i]);
            }
        }
    };
}
