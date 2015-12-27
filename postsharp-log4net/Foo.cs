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
        internal void DoSomething()
        {
            _logger.Info("Doing something");
        }

        [Log]
        internal void DoSomethingElse()
        {
            _logger.Info("Doing something else");
        }
    }
}
