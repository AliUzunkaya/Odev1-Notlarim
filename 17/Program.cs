using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            //20 ye kadar sayi olan bir zar
            //15-20 arasında büyük zarar
            //10-15 arasında orta boyut zarar
            //5-10 arasında zarar yok
            //0-5 kendine zarar

            Random zar = new Random();

            int birinciAtis = zar.Next(1, 21);
            int ikinciAtis = zar.Next(1, 21);
            int ucuncuAtis = zar.Next(1, 21);
            int dorduncuAtis = zar.Next(1, 21);
            int besinciAtis = zar.Next(1, 21);

            float ortalama = (birinciAtis + ikinciAtis + ucuncuAtis) / 3f;

            if(ortalama > 15)
            {
                Console.WriteLine("Büyük Zarar Verdin");
            }

            if(ortalama >10 && ortalama <=15)
            {
                Console.WriteLine("Orta Zarar Verdin");
            }

            if(ortalama > 5 && ortalama <= 10)
            {
                Console.WriteLine("Zarar Yok");
            }

            if(ortalama <= 5)
            {
                Console.WriteLine("Kendine Zarar Verdin");
            }

            Console.WriteLine(ortalama);
            Console.ReadLine();
        }
    }
}
        
