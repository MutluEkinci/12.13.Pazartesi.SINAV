using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_1
{

    class Program
    {
        //1.soru

        static string ASCII(string str)
        {
            string yenistr = "";
            for (int i = 0; i < str.Length; i++)
            {
                yenistr += (byte)str[i];
            }
            return yenistr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ASCII("Merhaba Dünya"));
        }
    }
}
