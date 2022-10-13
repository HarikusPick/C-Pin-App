using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Pin Belirleyiniz");
            int pin = Convert.ToInt16(Console.ReadLine());

            int hak = 3, girilen;

            while (hak > 0)
            {
                Console.Write("Pin Girin.....");
                girilen = Convert.ToInt32(Console.ReadLine());

                if (girilen == pin)
                {
                    Console.Write("..........Pin Doğruu !... Hoşgeldiniz...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Pin Doğru Değil Tekrar Gir!");
                    hak--;
                }
            }

            if (hak == 0)
            {

                for (int i = 10; i > 0; i--)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.Write(i);
                }
                Console.Write("Pin Doğru Değil! KAPANIYORR....");


                Console.ReadKey();
            }
        }
    }
}