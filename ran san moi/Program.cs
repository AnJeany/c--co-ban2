using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ran_san_moi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1;i <= 4; i++)
            {
                for (int j = 1;j <= i; j++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O");
                }  
                Console.WriteLine();
            }
            int x =0; int y =3;
            Console.SetCursorPosition(x,y);
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    y--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    y++;
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow && x >0)
                {
                    x--;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    x++;
                }
                Console.SetCursorPosition(x,y);
            }
            
        }
    }
}
