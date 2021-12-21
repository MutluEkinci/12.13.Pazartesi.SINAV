using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tamsayı
    {
        List<int> list = new List<int>();
        public List<int> Bul(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 4 == 0 || dizi[i] % 5 == 0)
                {
                    list.Add(dizi[i]);
                }
            }
            return list;
        }
    }
   
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[100];

            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 2000);
            }

            

            Tamsayı t = new Tamsayı();

            foreach (var item in t.Bul(dizi))
            {
                Console.WriteLine(item);
            }




        }
    }
}
