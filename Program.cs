using System;
namespace Program
{
    class Solve
    {
        static void OneToNine(int n)
        {
            switch (n)
            {
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("Six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
                default:
                    //Console.WriteLine("out of ability");
                    break;
            }
        }
        static void TenToNineteen(int n)
        {
            switch (n)
            {
                case 10:
                    Console.Write("Ten");
                    break;
                case 11:
                    Console.Write("Eleven");
                    break;
                case 12:
                    Console.Write("Twelve");
                    break;
                case 13:
                    Console.Write("Thirteen");
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
                default:
                    break;
            }
        }
        static void RoundNumber(int n)
        {
            switch (n)
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
                default:
                    break;
            }
        }
        static void TwentyToNinetyNine(int n)
        {
            int a = n / 10;
            int b = n % 10;
            RoundNumber(a);     
            Console.Write(" ");
            if(b != 0){
                OneToNine(b);
            }
        }
        static void Main(string[] s)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n < 10 && n >= 0)
            {
                if(n == 0)
                {
                    Console.WriteLine("Zero");
                }
                else if(n > 0 && n < 10)
                {
                    OneToNine(n);
                }
                else
                {
                    Console.WriteLine("out of ability");
                }
            }
            else if(n >= 10 && n < 20)
            {
                TenToNineteen(n);
            }
            else if(n >= 20 && n < 100)
            {
                // n = a * 10 + b
                TwentyToNinetyNine(n);
            }
            else
            {
                // n = a * 100 + b * 10 + c;
                int a = n / 100;
                int b = (n / 10) % 10;
                int c = n % 10;
                OneToNine(a);
                Console.Write(" Hundred ");
                n  = n - (n / 100) * 100;
                if(n != 0)
                {
                    Console.Write("And ");
                }
                if(n >= 10 && n < 20)
                {
                    TenToNineteen(n);
                }
                else if(n >= 20 && n < 100)
                {
                    TwentyToNinetyNine(n);
                }else
                {
                    OneToNine(n);
                }
            }
        }
    }
}
