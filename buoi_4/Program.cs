using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bai1
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 0 && age <= 2)
            //{
            //    Console.WriteLine("Tre so sinh");
            //}
            //else if (age > 2 && age <= 10)
            //{
            //    Console.WriteLine("Nhi dong");
            //}
            //else if (age >10 && age <= 17)
            //{
            //    Console.WriteLine("Vi thanh nien");
            //}
            //else if (age > 17 && age <= 39)
            //{
            //    Console.WriteLine("Thanh nien");
            //}
            //else if (age > 39 && age <= 50)
            //{
            //    Console.WriteLine("Trung nien");
            //}
            //else
            //{
            //    Console.WriteLine("Cao nien");
            //}
            #endregion

            #region Bai2
            //Console.WriteLine("Moi nhap nam");
            //int years = int.Parse(Console.ReadLine());
            //if (years >= 15)
            //{
            //    Console.WriteLine("Thay the");
            //}
            //else if (years >= 10 && years < 15)
            //{
            //    Console.WriteLine("Bao tri");
            //}
            //else
            //{
            //    Console.WriteLine("Khong co de xuat");
            //}
            #endregion

            #region Bai3
            //float point = float.Parse(Console.ReadLine());
            //if (point >= 9 )
            //{
            //    Console.WriteLine("Hoc bong la: 5.000.000");
            //}
            //else if (point >=  8 && point < 9)
            //{
            //    Console.WriteLine("Hoc bong la: 3.000.000");
            //}
            //else if (point >= 7 && point < 8)
            //{
            //    Console.WriteLine("Hoc bong la: 1.000.000");
            //}
            //else
            //{
            //    Console.WriteLine("Hoc bong la: 0");
            //}
            #endregion

            #region Bai4
            //Console.Write("Moi nhap gio: ");
            //int hour = int.Parse(Console.ReadLine());
            //Console.Write("Moi nhap luong: ");
            //float luong = float.Parse(Console.ReadLine());
            //float sum;
            //if (hour >= 200)
            //{
            //    sum = luong * 0.2f;
            //    Console.WriteLine(sum);
            //}
            //else if (hour >= 100 && hour < 200)
            //{
            //    sum = luong * 0.1f;
            //    Console.WriteLine(sum);
            //}
            #endregion

            #region Bai5
            float N = float.Parse(Console.ReadLine());

            if (N == (int)N)
            {
                Console.WriteLine("N la so nguyen");
                if (N % 2 == 0)
                {
                    Console.WriteLine("so chan");
                }
                else if (N % 2 == 1)
                {
                    Console.WriteLine("So le");
                }
                if (N > 0 && N % 2 == 0)
                {
                    Console.WriteLine("N chan duong");
                }
                else if (N > 0 && N % 2 == 1)
                {
                    Console.WriteLine("N le duong");
                }
                else if (N < 0 && N % 2 == -1)
                {
                    Console.WriteLine("N  le am");
                }
                else if (N < 0 && N % 2 == 0)
                {
                    Console.WriteLine("N khong le am");
                }

                float canBacHaiN = (float)Math.Sqrt(N);
                int phanNguyenCuaCanBacHai = (int)canBacHaiN;
                if (phanNguyenCuaCanBacHai == canBacHaiN)
                {
                    Console.WriteLine("La so chinh phuong");
                }
                else
                    Console.WriteLine("Khong phai so chinh phuong");
            }
            else if (N != (int)N)
            {
                Console.WriteLine("N khong la so nguyen");
            }

            #endregion
        }
    }
}
