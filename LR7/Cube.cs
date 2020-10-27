using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    class Cube
    {
        private double a;

        public Cube() { }

        public Cube(double pA) 
        { 
            a = pA;
        }

        public void Load() 
        { 
            a = Convert.ToDouble(Console.ReadLine());
        }

        public static Cube CreateCubeFromFile()
        {
            double aa = Convert.ToDouble(Console.ReadLine());
            return new Cube(aa);
        }

        public double GetV() { return a * a * 6; }

        public double GetS() { return a * a * a; }

        public void Info()
        {
            String str =

                "\n ____________________ \n" +
                "\n|                    |  \n" +
                "\n|        КУБ         | \n" +
                "\n|                    | \n" +
                "\n|____________________| \n";

            Console.WriteLine(str);
            Console.WriteLine(string.Format("сторона куба: " + "A = {0:.0.00}", a));
            Console.WriteLine(string.Format("Объем: " + "V= {0:.0.00}", GetV()));
            Console.WriteLine(string.Format("Площадь поверхности: " + "S = {0:.0.00}", GetS()));
            Console.WriteLine();
        }

        public void Info(ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Info();
        }
    }
}
