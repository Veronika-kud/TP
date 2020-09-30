using System;
using System.Collections.Generic;
using System.IO;
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

			double a1, a2, a3, a4, a5;
			double s, k;
			a1 = Convert.ToDouble(Console.ReadLine());
			a2 = Convert.ToDouble(Console.ReadLine());
			a3 = Convert.ToDouble(Console.ReadLine());
			a4 = Convert.ToDouble(Console.ReadLine());
			a5 = Convert.ToDouble(Console.ReadLine());

			if ((a3-a5<=0) || (a3-a1==0) || (a2 - a1<0) || (a1 < 0))
            Console.WriteLine("ERROR!!!");
            
					else
            {
				s = Math.Sqrt((a2 - a1) / (a3 - a5)) + Math.Sqrt(a1) / (a3 - a1);
				Console.WriteLine(String.Format("{0:0.0000}", s));
			}

			if ((a2 - a3 == 0) || (a2 - a4 == 0))
			Console.WriteLine("ERROR!!!");
					else
			{
				k = Math.Sqrt(1000 / (a1 - a3)) * (1/Math.Pow(a2-a4, 2));
				Console.WriteLine(String.Format("{0:0.0000}", k));
			}

			Console.SetOut(save_out);
			new_out.Close();
			Console.SetIn(save_in);
			new_in.Close();

		}

        private static object StreamReader(string v)
        {
            throw new NotImplementedException();
        }
    }
}
