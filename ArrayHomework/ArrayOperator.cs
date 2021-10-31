using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomework
{
    public class ArrayOperator
    {
        private int[] arrayA = { 12, 223, 3343, 45345, 23423, 23, 1112, 456, 33, 1 };
        private int[] arrayB = new int[10];

        public int[] ArrayA
        {
            get { return arrayA;}
            set { arrayA = value; }
        }
        public int[] ArrayB 
        {
            get { return arrayB; }
            set { arrayB = value; } 
        }
        public void callArray()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ArrayA[i]);
                Console.WriteLine(ArrayB[i] = ArrayA[i]);
                Console.ReadLine();
            }
        }
    }
}
