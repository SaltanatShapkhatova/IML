using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            while (cnt < 20)
            {
                string text = System.IO.File.ReadAllText(@"C:\Users\Saltanat\Desktop\machinka\dataset\");
                cnt++;
            }
            
        }
    }
}
