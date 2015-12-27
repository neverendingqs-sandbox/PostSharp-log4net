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
            f.DoSomething("First call");
            f.DoSomethingElse("Second call");

            /*  Output
                DEBUG postsharp_log4net.Foo - Entering: Foo.DoSomething(this = {postsharp_log4net.Foo}, "First call")
                INFO  postsharp_log4net.Foo - Doing something: First call
                DEBUG postsharp_log4net.Foo - Leaving: Foo.DoSomething(this = {postsharp_log4net.Foo}, "First call")
                DEBUG postsharp_log4net.Foo - Entering: Foo.DoSomethingElse(this = {postsharp_log4net.Foo}, "Second call")
                INFO  postsharp_log4net.Foo - Doing something else: Second call
                DEBUG postsharp_log4net.Foo - Leaving: Foo.DoSomethingElse(this = {postsharp_log4net.Foo}, "Second call")
             */

            Console.In.Read();
        }
    }
}
