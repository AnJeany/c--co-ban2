using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace bt_20._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] arr_tong = new int[50, 50];
            Console.WriteLine("Nhap kich thuoc cua ma tran 1 (<5): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap cac phan tu ma tran 1: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    arr1[i,j] = int.Parse(Console.ReadLine()) ;
            }

            Console.WriteLine("Nhap cac phan tu ma tran 2: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    arr2[i, j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("In ma tran 1");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.WriteLine(arr1[i,j]);
            }

            Console.WriteLine("in ma tran 2");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.WriteLine(arr2[i, j]);
            }
            int max1 = arr1[0, 0];
            int max2 = arr1[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max1 < arr1[i,j])
                        max1 = arr1[i,j];
                }
                
            }
            Console.WriteLine("\n gia tri lon nhat trong ma tran 1 la: " + max1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max2 < arr2[i, j])
                        max2 = arr2[i, j];
                }
            }
            Console.WriteLine("gia tri lon nhat trong ma tran 2 la: " + max2);
        }
    }
}
