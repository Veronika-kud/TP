using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class matrix
    {
        private int N, M;
        private int[,] mas;

        public double GetMin()
        {
            
            int min = 10001;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] < min)
                        min = mas[i, j];
                }
            }
            return min;
        }

        public double GetMax()
        {
            int max = -10001;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] > max)
                        max = mas[i, j];

                }
            }
            return max;
        }


        public void Info()
        {
            string str = "\nМатрица \n";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    str += mas[i, j] + " ";
                }
                str += "\n";
            }
            Console.WriteLine(str);
            Console.WriteLine(string.Format("N x M = {0} x {1}", N, M));
            Console.WriteLine(string.Format("Min = {0:0.00}", GetMin()));
            Console.WriteLine(string.Format("Max = {0:0.00}", GetMax()));

        }

        public void Load()
        {
            Console.WriteLine("кол-во строк: ");
            N = Convert.ToInt32(Console.ReadLine()); //кол-во строк
            Console.WriteLine("кол-во столбцов: ");
            M = Convert.ToInt32(Console.ReadLine()); //кол-во столбцов
            mas = new int[N, M];
            Random r = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(r.Next(-100000, 100000) / 10.00);
                }
            }
        }
    }
}
