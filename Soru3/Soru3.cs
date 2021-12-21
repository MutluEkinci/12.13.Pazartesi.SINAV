using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static List<int> DortBes(int[] sayilar)
        {
            List<int> _sayilar = new List<int>();
            foreach (int sayi in sayilar)
            {
                if (sayi % 4 == 0 || sayi % 5 == 0)
                    _sayilar.Add(sayi);
            }
            return _sayilar;
        }
        static void Main(string[] args)
        {
            int[] dizi = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 2000);
            }
            foreach (var sayi in DortBes(dizi))
            {
                Console.Write(sayi + " " );
            }
        }
    }
}
