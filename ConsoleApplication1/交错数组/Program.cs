using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 交错数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] Arr;
            Arr = new int[3][,];

            Arr[0] = new int[,] { { 10, 20 }, { 100, 200 } };

            Arr[1] = new int[,] { { 30, 40,50 }, { 300, 400,500 } };
            Arr[2] = new int[,] { { 60, 70,80,90 }, { 600, 700,800,900} };

            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr[i].GetLength(0); j++)
                {
                    for (int k = 0; k < Arr[i].GetLength(1); k++)
                    {
                        Console.WriteLine("[{0}][{1},{2}] = {3}",i,j,k,Arr[i][j,k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
