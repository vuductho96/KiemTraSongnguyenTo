using System;
using System.Runtime.Intrinsics.X86;

namespace KiemTrAsONGYTENtO;
class KiemTrA
{

    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter Number");
        number = int.Parse(Console.ReadLine());
        if (number < 2) {
            Console.WriteLine(number + " is not a prime");

    }
        else
            {
            int i = 2;
            bool check = true;
            while (i <= Math.Sqrt(number))
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }
            if (check)
            {
                Console.WriteLine(number + " is a prime");
            }
            else
            {
                Console.WriteLine(number + " is not a prime");
            }
        }


    }}



