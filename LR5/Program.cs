using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк N:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов M:");
            int M = Convert.ToInt32(Console.ReadLine());
            TextWriter saveout = Console.Out;
            var new_out = new StreamWriter("input.txt");
            Console.SetOut(new_out);


            int i, j;
            int[,] arr = new int[N, M];
            Random r = new Random();
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    arr[i, j] = Convert.ToInt32(r.Next(-100000, 100000) / 10.00);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.SetOut(saveout); new_out.Close();

            TextReader save_in = Console.In;
            TextWriter save_out = Console.Out;
            var Newout = new StreamWriter("output.txt");
            var Newin = new StreamReader("input.txt");
            Console.SetOut(Newout);
            Console.SetIn(Newin);

            //Вывод исходной матрицы
            Console.WriteLine("***Исходная матрица M x N***");
            
            int[,] mas = new int[N, M];
            for (i = 0; i < N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Сумма элементов по каждой строке
            Console.WriteLine("***Сумма элементов по каждой строке***");
            float sum = 0;
            float k = 0;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    k += mas[i, j];
                    sum = 1.0f + k - 1 ;
                }
                k = 0;
                Console.WriteLine(sum);
            }
            Console.WriteLine();

            //Среднее арифметическое по каждому столбцу
            Console.WriteLine("***Среднее арифметическое элементов по каждому столбцу***");
            float sa = 0;
            float summa = 0;
            for (j = 0; j < M; j++)
            {
                for (i = 0; i < N; i++)
                {
                    summa += mas[i, j];
                    sa = 1.0f * summa / N;
                }
                summa = 0;
                Console.WriteLine(sa);
            }
            

            Console.SetOut(save_out); Newout.Close();
            Console.SetIn(save_in); Newin.Close();
        }

    }
}

