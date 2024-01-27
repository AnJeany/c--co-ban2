using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace can_nang_co_the
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float height, weight;
            do
            {
                Console.Write("Moi nhap chieu cao don vi met: ");
                height = float.Parse(Console.ReadLine());
                Console.Write("Moi nhap can nang don vi kilogam: ");
                weight = float.Parse(Console.ReadLine());
                if (height <= 0 || weight <= 0)
                {
                    Console.WriteLine("Nhap sai, moi nhap lai!");
                }
            }while (height <= 0 || weight <= 0);

            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);

            if (bmi < 18.5f)
            {
                Console.WriteLine("Ban dang thieu can!");
            }
            else if (bmi >= 18.8 && bmi < 25f)
            {
                Console.WriteLine("Ban dang can doi!");
            }
            else if (bmi >= 25f && bmi < 30)
            {
                Console.WriteLine("Ban dang thua can!");
            }
            else
            {
                Console.WriteLine("Ban dang beo phi!");
            }
            
        }
    }
}
