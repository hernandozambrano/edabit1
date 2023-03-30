using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doble_letras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(dobleletras("pErto"));
            Console.WriteLine(dobleletras("soyelmejorr"));
            Console.ReadKey();
        }
        public static Boolean dobleletras(string palabra)
        {
            char[] chars = palabra.ToUpper().ToCharArray();
            for (int c =0;c<chars.Length-1;c++)
            {
                if (chars[c] == chars[c + 1])
                return true;
            }
            return false;
        } 
    }

}
  