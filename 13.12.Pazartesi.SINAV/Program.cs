using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._12.Pazartesi.SINAV
{
    class ASCII
    {
        public string Numeric(string ifade)
        {
            string sonuc = "";
            foreach (var item in ifade)
            {
                sonuc += (byte)item;
            }
            return sonuc;
        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Soru1:
            ASCII asc = new ASCII();

            Console.WriteLine(asc.Numeric("Mutlu"));

        }
    }
}
