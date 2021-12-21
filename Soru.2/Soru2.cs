using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru._2
{
    class Program
    {
        static Dictionary<char,int> Frekans(string str,params char [] karakterler)
        {
            Dictionary<char,int> frekans =new Dictionary<char, int>();
            foreach (char c in karakterler)
            {
                frekans.Add(c, 0);
            }

            foreach (char c in str)
            {
                if(frekans.Keys.Contains(c))
                frekans[c]++;
            }
            return frekans;
        }
        static void Main(string[] args)
        {
            Dictionary<char, int> fr = Frekans("Bugun hava ne guzel", 'u', 'a','n');

            foreach (var item in fr.Keys)
            {
                Console.WriteLine(item+"="+fr[item]);
            }
        }
    }
}
