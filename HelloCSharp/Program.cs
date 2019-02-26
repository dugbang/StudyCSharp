using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
            Console.WriteLine("Hello {0}", args[0]);

            Console.ReadKey();
        }
    }
}
