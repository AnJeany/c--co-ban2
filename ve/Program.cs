using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bai3
            //int n, m;
            //Console.Write("nhap chieu dai theo canh ngang n=:");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("nhap chieu rong theo canh doc m=:");
            //m = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= m; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}  
            #endregion

            int n, m;
            int i = 1;
            int j = 1;
            Console.Write("nhap chieu dai theo canh ngang n=:");
            n = int.Parse(Console.ReadLine());
            Console.Write("nhap chieu rong theo canh doc m=:");
            m = int.Parse(Console.ReadLine());
            while (j <= m)
            {
                j++;

                while (i <= n)
                {
                    i++;
                    Console.Write("*");
                }
                i = 1;

                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
