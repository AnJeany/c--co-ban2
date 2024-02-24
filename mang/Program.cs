using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Nhap phan tu thu " + i + ":");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap vi tri x muon thay the: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Gia tri tai vi tri x: ");
            int value = int.Parse(Console.ReadLine());
            for (int i = 9; i >x ; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[x] = value;
            for (int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
