using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineCode;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter matrix P:");
            string mat = Console.ReadLine() + "\n" + Console.ReadLine();
            Code code = new Code(mat);
            Console.WriteLine(code.FormingPrint());
            Console.WriteLine("Enter i:");
            string i = Console.ReadLine();
            var v = code.Coding(i);
            Console.WriteLine("v = {0}",v);
            var e = code.RandomExp();
            Console.WriteLine("e = {0}\nu = {1}",e,code.AddingVectors(v,e));
            var se = code.SearchExp(code.AddingVectors(v, e));
            Console.WriteLine(se);
        }
    }
}
