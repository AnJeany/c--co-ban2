using System;

namespace buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Nhap so can doc: ");
                number = int.Parse(Console.ReadLine());
                if (number <= 0 || number > 999)
                {
                    Console.WriteLine("Nhap sai! Nhap lai!");
                }
            } while (number <= 0 || number > 999);
            if (number <= 10) // 1 chu so
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                }
            }

            else if (number > 10 && number <= 20) // 2 chu so be hon 20
            {
                switch (number)
                {
                    case 11:
                        Console.Write("Eleven");
                        break;
                    case 12:
                        Console.Write("twelve");
                        break;
                    case 13:
                        Console.Write("thirteen");
                        break;
                    case 14:
                        Console.Write("Fourteen");
                        break;
                    case 15:
                        Console.Write("Fifteen");
                        break;
                    case 16:
                        Console.Write("Sixteen");
                        break;
                    case 17:
                        Console.Write("Seventeen");
                        break;
                    case 18:
                        Console.Write("Eighteen");
                        break;
                    case 19:
                        Console.Write("Nineteen");
                        break;
                    case 20:
                        Console.WriteLine("Tewnty");
                        break;
                }
            }
            else if (number > 20 && number < 100)// 2 chu so lon hon 20
            {
                int hang_chuc, donvi;
                hang_chuc = number / 10;
                donvi = number % 10;
                
                
                switch (hang_chuc)
                {
                    case 2:
                        Console.Write("Twenty");
                        break;
                    case 3:
                        Console.Write("Thirty");
                        break;
                    case 4:
                        Console.Write("Fourty");
                        break;
                    case 5:
                        Console.Write("Fifty");
                        break;
                    case 6:
                        Console.Write("Sixty");
                        break;
                    case 7:
                        Console.Write("Seventy");
                        break;
                    case 8:
                        Console.Write("Eighty");
                        break;
                    case 9:
                        Console.Write("Ninety");
                        break;
                }
                switch (donvi)
                {
                    case 1:
                        Console.Write(" One");
                        break;
                    case 2:
                        Console.Write(" Two");
                        break;
                    case 3:
                        Console.Write(" Three");
                        break;
                    case 4:
                        Console.Write(" Four");
                        break;
                    case 5:
                        Console.Write(" Five");
                        break;
                    case 6: 
                        Console.Write(" Six");
                        break;
                    case 7:
                        Console.Write(" Seven");
                        break;
                    case 8:
                        Console.Write(" Eight");
                        break;
                    case 9:
                        Console.Write(" Nine");
                        break;
                }

            }
            else if (number >= 100 && number <=999)// 3 chu so be hon 999
            {
                int tram = number / 100;
                int chuc = (number / 10) % 10;
                int donvi = number % 10;
                switch (tram) 
                {
                    case 1:
                        Console.Write(" Onehundred and ");
                        break;
                    case 2:
                        Console.WriteLine(" Twohundred and ");
                        break;
                    case 3:
                        Console.Write(" Threehundred and ");
                        break;
                    case 4:
                        Console.Write(" Fourhundred and ");
                        break;
                    case 5:
                        Console.Write(" Fivehundred and ");
                        break;
                    case 6:
                        Console.Write(" Sixhundred and ");
                        break;
                    case 7:
                        Console.Write(" Sevenhundred and ");
                        break;
                    case 8:
                        Console.Write(" Eighthundred and ");
                        break;
                    case 9:
                        Console.Write(" Ninehundred and ");
                        break;
                }
                if (chuc < 2 && chuc != 0)
                {
                    switch (chuc)
                    {
                        case 1:
                            Console.Write("Eleven");
                            break;
                        case 2:
                            Console.Write("twelve");
                            break;
                        case 3:
                            Console.Write("thirteen");
                            break;
                        case 4:
                            Console.Write("Fourteen");
                            break;
                        case 5:
                            Console.Write("Fifteen");
                            break;
                        case 6:
                            Console.Write("Sixteen");
                            break;
                        case 7:
                            Console.Write("Seventeen");
                            break;
                        case 8:
                            Console.Write("Eighteen");
                            break;
                        case 9:
                            Console.Write("Nineteen");
                            break;
                        case 0:
                            Console.WriteLine("Tewnty");
                            break;
                    }
                    
                }
                switch (chuc)
                {
                    case 0:
                        Console.Write(" ");
                        break;
                    case 2:
                        Console.Write("Twenty");
                        break;
                    case 3:
                        Console.Write("Thirty");
                        break;
                    case 4:
                        Console.Write("Fourty");
                        break;
                    case 5:
                        Console.Write("Fifty");
                        break;
                    case 6:
                        Console.Write("Sixty");
                        break;
                    case 7:
                        Console.Write("Seventy");
                        break;
                    case 8:
                        Console.Write("Eighty");
                        break;
                    case 9:
                        Console.Write("Ninety");
                        break;
                }
                switch (donvi)
                {
                    case 0:
                        Console.WriteLine(" Zero ");
                        break;
                    case 1:
                        Console.Write(" One");
                        break;
                    case 2:
                        Console.WriteLine(" Two");
                        break;
                    case 3:
                        Console.Write(" Three");
                        break;
                    case 4:
                        Console.Write(" Four");
                        break;
                    case 5:
                        Console.Write(" Five");
                        break;
                    case 6:
                        Console.Write(" Six");
                        break;
                    case 7:
                        Console.Write(" Seven");
                        break;
                    case 8:
                        Console.Write(" Eight");
                        break;
                    case 9:
                        Console.Write(" Nine");
                        break;
                }
            }   
            else if (number > 1000)
            {
                Console.WriteLine("Out of ability");
            }



        }
    }
}
