using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _260219_homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please insert a number from 1-10");

            int number = Convert.ToInt32(Console.ReadLine());
            printnumbersandtf(number);

            number = Convert.ToInt32(Console.ReadLine());

            printnumbersandtf(number);

            number = Convert.ToInt32(Console.ReadLine());

            printnumbersandtf(number);

            number = Convert.ToInt32(Console.ReadLine());

            printnumbersandtf(number);

            Thread.Sleep(2000);
            
            int num = 1;
            NextNumber(num);
            
        }

        private static void printnumbersandtf(int number)
        {
            if (PrintNumber1to10(number))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static void NextNumber(int number)
        {
            if(number < 11)
            {
                Console.WriteLine(number);
                number++;
                NextNumber(number);
            }
            
            
        }








        private static bool PrintNumber1to10(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("one");
                    return true;
                    
                case 2:
                    Console.WriteLine("two");
                    return true;
                case 3:
                    Console.WriteLine("three");
                    return true;
                case 4:
                    Console.WriteLine("four");
                    return true;
                case 5:
                    Console.WriteLine("five");
                    return true;
                case 6:
                    Console.WriteLine("six");
                    return true;
                case 7:
                    Console.WriteLine("seven");
                    return true;
                case 8:
                    Console.WriteLine("eight");
                    return true;
                case 9:
                    Console.WriteLine("nine");
                    return true;
                case 10:
                    Console.WriteLine("ten");
                    return true;
                default:
                    Console.WriteLine("number not in range");
                    return false;
            }
        }
    }
}
