using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_toplama_çıkarma_operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Toplama operatörü : +
            //Çıkarma operatörü : -
            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 6;
            int sayi4 = 1;
            int sonuç = sayi1 + sayi2 - (sayi3 + sayi4);
            Console.WriteLine(sonuç);
            Console.ReadLine();
        }
    }
}
