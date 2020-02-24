using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n=== StaticLocalFunctions ===");
            StaticLocalFunction.Demo();

            Console.WriteLine("\n=== SwitchExpressions ===");
            SwitchExpressions.Demo();

            Console.WriteLine("\n=== TargetTypedNew ===");
            TargetTypedNew.Demo();
        }
    }
}
