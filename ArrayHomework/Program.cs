using System;
using System.Linq;

namespace ArrayHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySum();
            ArrayFindOddEven();
            ArrayPopulation();
        }
        static void ArraySum()
        {
            int[] sumArray = {3, 6, 9, 11, 15};
            int sum = 0;

            for (var i=0; i<sumArray.Length; i++)
            {
                sum += sumArray[i];
            }
            Console.WriteLine($"The sum of all elements in the array is :  {sum}");
            Console.ReadLine();
        }
        static void ArrayFindOddEven()
        {
            int[] numbers = {5, 6, 19, 22, 24, 35, 50};
          
            foreach (var numbVal in numbers)
                {
                if (numbVal % 2 == 0)
                {
                    Console.WriteLine(numbVal + " - even number");
                }
                else
                {
                    Console.WriteLine(numbVal + " - odd number");
                }
                }
            Console.ReadLine();
        }
        static void ArrayPopulation()
        {
            int[] array1 = {12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1};
            int[] array2 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array1[i]);
                Console.WriteLine(array2[i]=array1[i]);
            }
            Console.ReadLine();
        }
    }
}
