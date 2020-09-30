using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int t = 0, N = 1;
            double X = 0, Y = 0, s = 0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            int i = 1, step = 1;
            double znam = 1, chisl;

            if (t == 0)
            {
                for (i = 1; i <= N; i++)
                {
                    step = i;
                    znam = step * (step + 2);
                    if (i % 2 == 1)
                        chisl = Y * -Math.Pow(X, step++);
                    else
                        chisl = X * Math.Pow(Y, step++);

                    s += chisl / znam;
                }
            }

            if (t == 1)
            {
                i = 1;
                while (i<=N)
                {
                    step = i;
                    znam = step * (step + 2);
                    if (i % 2 == 1)
                        chisl = Y * -Math.Pow(X, step++);
                    else
                        chisl = X * Math.Pow(Y, step++);

                    s += chisl / znam;
                    i++;
                }
            }

            if (t == 2)
            {
                i = 1;
                do
                {
                    step = i;
                    znam = step * (step + 2);
                    if (i % 2 == 1)
                        chisl = Y * -Math.Pow(X, step++);
                    else
                        chisl = X * Math.Pow(Y, step++);

                    s += chisl / znam;
                    i++;
                } while (i <= N);
            }

            Console.WriteLine(String.Format("{0:0.0000}", s));

            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
        }
    }
}
