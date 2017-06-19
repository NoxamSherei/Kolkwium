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
            int[] punkt = new int[4];
            Console.WriteLine("prosze podac x1,y1,x2,y2");
            for(int i =0;i<=punkt.Length;i++)
            {
                punkt[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(otrzymanyKatAlpha);
            Console.ReadKey();
        }
        
    }
    class ModulLiczacy
    {
        public float Kat(int x, int y)
        {
            double kat = 0;
            kat = Math.Tan(1);
            return Convert.ToSingle(kat);
        }
        public float Kat(int x1, int y1, int x2, int y2)
        {
            float kat=0;
            return kat;
        }
    }
}
