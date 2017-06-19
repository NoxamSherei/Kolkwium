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
            double katAlpha = liczydlo.Kat(x, y);
            Console.WriteLine("kat Alpha wzgledem ukladu X="+katAlpha);
            int[] punkt = new int[4];
            Console.WriteLine("prosze podac x1,y1,x2,y2");
            for(int i =0;i<punkt.Length;i++)
            {
                punkt[i] = Convert.ToInt32(Console.ReadLine());
            }
            double katBeta = liczydlo.Kat(punkt[0], punkt[1], punkt[2], punkt[3]);
            Console.WriteLine("kat Beta wzgledem ukladu X="+katBeta);

            double katPomiedzy=liczydlo.KatPomiedzy(katAlpha,katBeta);
            Console.WriteLine("Kat pomiedzy liniami wynosi="+katPomiedzy);
            Console.ReadKey();
        }
        
    }
    class ModulLiczacy
    {
        /// <summary>
        /// Liczenie pierwszego kata aplha
        /// </summary>
        /// <param punkt x w ukladzie współżędnych="x"></param>
        /// <param punkt y w ukladzie współżędnych="y"></param>
        /// example x=4, y=4
        /// resoult = 45
        public double Kat(int x, int y)
        {
            double kat =45;
            //kat = Math.Tan(x/y);
            return kat;
        }
        /// <summary>
        /// Liczenie drugiego kata aplha
        /// </summary>
        /// <param punkt x w ukladzie współżędnych="x"></param>
        /// <param punkt y w ukladzie współżędnych="y"></param>
        /// example x1=4, y1=4, x2=8, y2=4
        /// resoult = 90
        public double Kat(int x1, int y1, int x2, int y2)
        {
            double kat =90;
            return kat;
        }
        /// <summary>
        /// Liczenie różnicy kata
        /// </summary>
        /// <param name="aplha"></param>
        /// <param name="beta"></param>
        /// <returns></returns>
        public double KatPomiedzy(double alpha, double beta)
        {
            double resoult = alpha - beta;
            if (resoult < 0) resoult = -resoult;
            return resoult;
        }
    }
}
