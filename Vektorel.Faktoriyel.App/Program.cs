using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Faktoriyel.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sinir = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            for (int i = 1; i <= sinir; i++)
            {
                sonuc *= i;
            }
            Console.WriteLine("Faktoriyel Sonucu:"+sonuc);
            Console.ReadKey();


        }
    }
}
