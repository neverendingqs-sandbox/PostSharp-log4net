using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postsharp_log4net
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo();
            f.DoSomething();
            f.DoSomethingElse();

            Console.In.Read();
        }
    }
}
