using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;

namespace postsharp_log4net
{
    internal sealed class Foo
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(Foo));

        [Log]
        internal void DoSomething(string message)
        {
            _logger.InfoFormat("Doing something: {0}", message);
        }

        [Log]
        internal void DoSomethingElse(string message)
        {
            _logger.InfoFormat("Doing something else: {0}", message);
        }
    }
}
