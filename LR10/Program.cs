using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix();

            
            m1.GenerateMatrix(5, 5);
            m1.SaveMatrix("Matrix1.txt");
            m2.GenerateMatrix(4, 4);
            m2.SaveMatrix("Matrix2.txt");

                        
            if (m1.LoadMatrix("Matrix1.txt"))
                m1.PrintMatrix();
            Console.WriteLine("\n\n");
            if (m2.LoadMatrix("Matrix2.txt"))
                m2.PrintMatrix();
            Console.WriteLine("\n\n");

            //Вывод суммы элементов по гл диагонали 
            float sumg, sump;
            sumg = m1.GetSumgValue;
            sump = m2.GetSumpValue;
            Console.WriteLine("Сумма элементов гл.диагонали 1-ой матриц: " + sumg.ToString("E3"));
            Console.WriteLine("Сумма элементов побоч.диагонали 2-ой матриц: " + sump.ToString("E3"));

            Console.ReadKey();
        }
    }
}
