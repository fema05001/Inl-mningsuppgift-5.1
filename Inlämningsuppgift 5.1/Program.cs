using System;
namespace Uppgift_5_1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] a = new string[5];
            a[0] = ("Hej och välkommen");
            a[1] = ("Till mitt program");
            a[2] = ("Där meningar skrivs ut");
            a[3] = ("En efter den andra");
            a[4] = ("Tills programet är klart.");
            
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(a[i]);
                Console.WriteLine(" ");
            }
        }
    }
}