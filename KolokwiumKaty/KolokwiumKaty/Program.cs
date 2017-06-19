using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumKaty
{
    class Program
    {
        static void Main(string[] args)
        {
            ModulLiczacy liczydlo = new ModulLiczacy();
            bool ifWhile = false;
            string colect;
            Console.Write("prosze podac x: ");
            colect = Console.ReadLine();
            int x = Convert.ToInt32(colect);
            Console.Write("prosze podac y: ");
            colect = Console.ReadLine();
            int y = Convert.ToInt32(colect);
            float otrzymanyKatAlpha= liczydlo.Kat(x, y);
            Console.WriteLine(otrzymanyKatAlpha);
            Console.ReadKey();
        }
        
    }
    class ModulLiczacy
    {
        public float Kat(int x, int y)
        {
            float kat = 0;
            kat = x / y;
            return kat;
        }
    }
}
