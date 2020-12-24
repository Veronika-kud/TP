using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace лаб11
{
    class Program
    {

        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_07.csv");
#if !DEBUG
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"lr11.txt");
            Console.SetOut(new_out);
#endif

            List<SiteLr> all = new List<SiteLr>();

            try
            {
                String line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                {
                    all.Add(SiteLr.Create(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Всего пользователей: {0}", all.Count);
            foreach (var p in all)
                Console.WriteLine(p);



            Console.WriteLine("******************************* Задание 1 *******************************");
            Console.WriteLine("******* Количество сотрудников без логина *******\n");

            int amount = all.FindAll(p => p.Login == "").ToList().Count;
            Console.WriteLine("Количество сотрудников без логина: {0}", amount);

            Console.WriteLine("\n\n");


            Console.WriteLine("******************************* Задание 2 *******************************");
            Console.WriteLine("*******  Средняя заработная плата по каждому из 4-х отделов *******\n");

            float averageA = (from p in all
                                       where (p.DepartmentName == Department.A)
                                       select p.Salary).Average();
            float averageB = (from p in all
                              where (p.DepartmentName == Department.B)
                              select p.Salary).Average();
            float averageC = (from p in all
                              where (p.DepartmentName == Department.C)
                              select p.Salary).Average();
            float averageD = (from p in all
                              where (p.DepartmentName == Department.D)
                              select p.Salary).Average();
            Console.WriteLine(String.Format("Средння з/п в отделе А: ${0}", averageA));
            Console.WriteLine(String.Format("Средння з/п в отделе B: ${0}", averageB));
            Console.WriteLine(String.Format("Средння з/п в отделе C: ${0}", averageC));
            Console.WriteLine(String.Format("Средння з/п в отделе D: ${0}", averageD));

            Console.WriteLine("\n\n");


            Console.WriteLine("******************************* Задание 3 *******************************");
            Console.WriteLine("******* Максимальная з/п сотрудников у которых есть собака или кошка *******\n");
            float SalaryAMaxC = (from p in all
                               where (p.DepartmentName == Department.A) && p.HasCat
                               select p.Salary).Max();
            float SalaryBMaxC = (from p in all
                                 where (p.DepartmentName == Department.B) && p.HasCat
                                 select p.Salary).Max();
            float SalaryCMaxC = (from p in all
                                 where (p.DepartmentName == Department.C) && p.HasCat
                                 select p.Salary).Max();
            float SalaryDMaxC = (from p in all
                                 where (p.DepartmentName == Department.D) && p.HasCat
                                 select p.Salary).Max();
            float SalaryAMaxD = (from p in all
                                 where (p.DepartmentName == Department.A) && p.HasDog
                                 select p.Salary).Max();
            float SalaryBMaxD = (from p in all
                                 where (p.DepartmentName == Department.B) && p.HasDog
                                 select p.Salary).Max();
            float SalaryCMaxD = (from p in all
                                 where (p.DepartmentName == Department.C) && p.HasDog
                                 select p.Salary).Max();
            float SalaryDMaxD = (from p in all
                                 where (p.DepartmentName == Department.D) && p.HasDog
                                 select p.Salary).Max();


            float[] max = new float [8];
            max[0] = SalaryAMaxC;
            max[1] = SalaryBMaxC;
            max[2] = SalaryCMaxC;
            max[3] = SalaryDMaxC;
            max[4] = SalaryAMaxD;
            max[5] = SalaryBMaxD;
            max[6] = SalaryCMaxD;
            max[7] = SalaryDMaxD;

            float MaxSalary = max.Max();
            Console.WriteLine(" Максимальная з/п сотрудников у которых есть собака или кошка: " + MaxSalary + "$");

            Console.WriteLine("\n\n\n");


            Console.WriteLine("******************************* Задание 4 *******************************");
            Console.WriteLine("******* Средняя з/п у сотрудников с оружием и без. *******\n");

            float AverageAMaxC = (from p in all
                                 where (p.DepartmentName == Department.A) && p.HasGun
                                 select p.Salary).Average();
            float AverageBMaxC = (from p in all
                                 where (p.DepartmentName == Department.B) && p.HasGun
                                 select p.Salary).Average();
            float AverageCMaxC = (from p in all
                                 where (p.DepartmentName == Department.C) && p.HasGun
                                 select p.Salary).Average();
            float AverageDMaxC = (from p in all
                                 where (p.DepartmentName == Department.D) && p.HasGun
                                 select p.Salary).Average();
            float AverageAMaxD = (from p in all
                                 where (p.DepartmentName == Department.A) && !p.HasGun
                                 select p.Salary).Average();
            float AverageBMaxD = (from p in all
                                 where (p.DepartmentName == Department.B) && !p.HasGun
                                 select p.Salary).Average();
            float AverageCMaxD = (from p in all
                                 where (p.DepartmentName == Department.C) && !p.HasGun
                                  select p.Salary).Average();
            float AverageDMaxD = (from p in all
                                 where (p.DepartmentName == Department.D) && !p.HasGun
                                  select p.Salary).Average();
;
            Console.WriteLine(String.Format("Средння зарплата отдела А с оружием: ${0}", AverageAMaxC));
            Console.WriteLine(String.Format("Средння зарплата отдела B с оружием: ${0}", AverageBMaxC));
            Console.WriteLine(String.Format("Средння зарплата отдела C с оружием: ${0}", AverageCMaxC));
            Console.WriteLine(String.Format("Средння зарплата отдела D с оружием: ${0}", AverageDMaxC));
            Console.WriteLine(String.Format("Средння зарплата отдела А без оружия: ${0}", AverageAMaxD));
            Console.WriteLine(String.Format("Средння зарплата отдела B без оружия: ${0}", AverageBMaxD));
            Console.WriteLine(String.Format("Средння зарплата отдела C без оружия: ${0}", AverageCMaxD));
            Console.WriteLine(String.Format("Средння зарплата отдела D без оружия: ${0}", AverageDMaxD));

#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#endif
        }
    }
}
