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
            int n = Convert.ToInt32(Console.ReadLine());
            TextWriter saveout = Console.Out;
            var new_out = new StreamWriter("input.txt");
            Console.SetOut(new_out);
            Console.WriteLine(n);
            Random r = new Random();
            int a = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                a = Convert.ToInt32(r.Next(-10000, 10000) / 10.00);
                Console.Write(a + " ");
            }

            Console.SetOut(saveout); new_out.Close();
            TextReader save_in = Console.In;
            TextWriter save_out = Console.Out;
            var newout = new StreamWriter("output.txt");
            var newin = new StreamReader("input.txt");
            Console.SetOut(newout);
            Console.SetIn(newin);

            int N = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            string[] str_el = str.Split(' ');

            int[] mas = new int[N];
            for (i = 0; i < N; i++)
                mas[i] = Convert.ToInt32(str_el[i]);

            //Максимальное четное число
            int max = mas[0];
            for (i = 0; i < N; i++)
                if ((mas[i] % 2 == 0) && (mas[i] > max))
                    max = mas[i];
            Console.WriteLine(max);

            //Минимальное нечетное число
            int min = mas[0];
            for (i = 0; i < N; i++)
                if ((mas[i] < min) && (mas[i] % 2 != 0))
                    min = mas[i];
            Console.WriteLine(min);

            //Сумма элементов, кратных 5
            int s = 0;
            for (i = 0; i < N; i++)
                if (mas[i] % 5 == 0)
                    s += mas[i];
            Console.WriteLine(s);

            Console.SetOut(save_out); newout.Close();
            Console.SetIn(save_in); newin.Close();
        }

    }
}

