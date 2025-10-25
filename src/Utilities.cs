using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNK_Shell.codecrafters_shell_csharp.src
{
    internal class Utilities
    {
        public static void Echo(string words)
        {
            string[] input = words.Split(' ');

            if (input.Length > 1)
            {
                Console.WriteLine(string.Join(" ", input.Skip(1)));
                return;
            }
            Console.WriteLine("");
        }
        

    }
}
