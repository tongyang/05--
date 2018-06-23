using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 5, 6, 11, 7, 32, 22, 31 };
            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    for (int j = 0; j < numbers.Length - 1 - i; j++)
            //    {
            //        if (numbers[j] > numbers[j + 1])
            //        {
            //            int temp = numbers[j];
            //            numbers[j] = numbers[j + 1];
            //            numbers[j + 1] = temp;
            //        }
            //    }
            //}

            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                
            }
            Console.ReadKey();

            
        }
    }
}
