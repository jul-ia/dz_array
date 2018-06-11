using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No 1:");
            Matrix m1 = new MyMatrix();
            m1.ShowMatrix();

            Console.WriteLine("\nNo 2:");
            Matrix m2 = new MyMatrix(4, 3);
            m2.ShowMatrix();
            Console.WriteLine();
            m2.changeSize(2, 5);
            m2.ShowMatrix();

            Console.ReadLine();
        }
    }
}
