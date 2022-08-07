using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngü_Yapısı_1_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While döngülerden biridir basit bir örnek yapalım
            // 1'den 10'a kadar olansayıları yazdırma programı

            /* 1. ÖRNEK 
            var sayac=0;
            while (sayac <= 10) 
            {
                Console.WriteLine(sayac);
                sayac++;
            } 
            Console.ReadLine();
            */

            /* 2. örnek sayac 100'e eşit olana kadar 2'şer arttır
            var sayac = 2;
            while (sayac <= 100) 
            {
                Console.WriteLine(sayac);
                sayac = sayac+2;
            }
            Console.ReadLine();
             */

            string isim="muhammet";
            int sayac = 0;

            while (isim == "Muhammet") 
            {
                Console.WriteLine(isim);
                sayac++;
                if(sayac == 10)
                {
                    isim = "";
                }
            }
            Console.ReadLine();

        }
    }
}
