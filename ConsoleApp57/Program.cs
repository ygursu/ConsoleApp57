// using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trafiklambasiswitchcase
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("Lütfen trafik lambası rengini giriniz");
            string renk = Console.ReadLine();

            switch (renk)
            {
                case "kırmızı": Console.WriteLine("Dur"); break;
                case "sarı": Console.WriteLine("Hazır Ol"); break;
                case "yeşil": Console.WriteLine("İlerle"); break;

                default: Console.WriteLine("Böyle bir trafik rengi yok"); break;
            }

            Console.ReadLine();
        }
    }
}
