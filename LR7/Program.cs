using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"Cube_output.txt");
            var new_in = new StreamReader(@"Cube_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Cube c1, c2;
#if DEBUG
            c1 = new Cube(19);
            c1.Info(ConsoleColor.Red, ConsoleColor.White);
#endif

#if !DEBUG
            c1 = Cube.CreateCubeFromFile();
            c1.Info();
            c2 = new Cube(5);
            c2.Info();
#endif

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
