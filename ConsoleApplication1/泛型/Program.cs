using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            var intArray = new int[] { 3, 5, 6, 2, 9 };
            var stringArray = new string[] { "jxl", "lihaiwnag" ,"zhuxu"};
            var doubleArray = new double[] { 12.2323, 30.222, 5.666 };
            Simple.ReverseAndPrint<int>(intArray);
            Simple.ReverseAndPrint(intArray);
            Simple.ReverseAndPrint<string>(stringArray);
            Simple.ReverseAndPrint(stringArray);
            Simple.ReverseAndPrint<double>(doubleArray);
            Simple.ReverseAndPrint(doubleArray);
            Console.ReadKey();

        }
    }
    class Simple
    {
        static public void ReverseAndPrint<T>(T[] arr)
        {
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write("{0},",item.ToString());

            }
            Console.WriteLine();
        }

    }
}
