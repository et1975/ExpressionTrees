using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        class T {public int x {get;set;}}

        static void Main(string[] args)
        {
            for (var ii = 0; ii < 4; ii++)
            {
				var sw = Stopwatch.StartNew();
                Enumerable.Range(0,10000)
                    .Select(i => (Expression<Func<T,bool>>)(t => t.x == i ))
                    .ToList();
				Console.WriteLine("Elapsed: {0}", sw.Elapsed);
            }
        }
    }
}
