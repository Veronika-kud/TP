using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА 1. РАЗРАБОТКА КОНСОЛЬНОГО ПРИЛОЖЕНИЯ");
			Console.WriteLine("Выполнила: Куделя Веоника Владимирвна");
			Console.WriteLine("группа: ИНС-б-о-191");
			Console.WriteLine("10 ноября 2001г.");
			Console.WriteLine("г. Ставрополь");
			Console.WriteLine("любимый предмет в школе: математика, физика, информатика");
			Console.WriteLine("мое хобби - живопись и кастомизация одежды(роспись красками), так же увлекаюсь спортом");
			Console.WriteLine("*********************************************************");


			double a, z, E, t, U;

			Console.Write("Ведите а =");
			a = Convert.ToDouble(Console.ReadLine());
			Console.Write("Ведите z =");
			z = Convert.ToDouble(Console.ReadLine());
			Console.Write("Ведите E =");
			E = Convert.ToDouble(Console.ReadLine());
			Console.Write("Ведите t =");
			t = Convert.ToDouble(Console.ReadLine());

			U = (35 / a) * z + (z * a) + ((a + E * t) / 4);
			Console.WriteLine($"Переменная U = {U}");

			Console.ReadKey();
		}
	}
}
