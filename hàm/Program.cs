using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hàm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Console.WriteLine("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i ++)
            {
                Console.WriteLine("Nhap phan tu thu " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(dem(arr,n));

             int dem (int[] arr1, int n1)
            {
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
