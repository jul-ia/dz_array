using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    class Program
    {

        public static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        public static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                    max = a[i];
            }
            return max;
        }

        public static int Min(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            return min;
        }

        public static int Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];

            return sum;
        }

        public static double Average(int[] a)
        {
            return (double)Sum(a) / a.Length;
        }

        public static void Odd(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                    Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter the size of your array: ");
            int.TryParse(Console.ReadLine(), out (size));
            int[] a = new int[size];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
                a[i] = rand.Next(0, 50);

            Console.WriteLine("\nArray:");
            printArray(a);

            Console.WriteLine("\nMax: {0}", Max(a));
            Console.WriteLine("\nMin: {0}", Min(a));

            Console.WriteLine("\nSum of all elements: {0}", Sum(a));
            Console.WriteLine("\nAverage: {0}", Average(a));
            Console.WriteLine("\nOdd numbers:");
            Odd(a);

            Console.ReadLine();
        }
    }
}
