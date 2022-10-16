using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NewMethod();

            M();

            Console.ReadKey();
        }
        public static void NewMethod()
        {
            M();
        }

        public static void M()
        {
            Console.WriteLine("This is M method.");
        }

        
    }
}
